using System;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.DataAccess;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Contabilidad;
using System.ComponentModel;
using DevExpress.DataAccess.ConnectionParameters;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class FrmCon_Dashboard : DevExpress.XtraEditors.XtraForm
    {
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private ct_dashboard_financiero_Bus bus_dashboard_financiero;
        private List<ct_dashboard_financiero_Info> list_dashboard_financiero;
        private BindingList<ct_dashboard_financiero_Info> bindinglist_dashboard_financiero;
        private string current_process_description = "";
        tb_Conexion_Dashboard_Bus bus_ConexionDashboard = new tb_Conexion_Dashboard_Bus();

        BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };
        
        public FrmCon_Dashboard()
        {
            InitializeComponent();

            this.bus_dashboard_financiero = new ct_dashboard_financiero_Bus();

            this.dashboardViewer_Financiero.Parameters["pIdEmpresa"].SelectedValue = param.IdEmpresa;
            this.dashboardViewer_Financiero.Parameters["pIdUsuario"].SelectedValue = param.IdUsuario;        
            this.dashboardViewer_Financiero.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs;
        }
        
        private void FrmCon_Dashboard_Load(object sender, EventArgs e)
        {
            this.barButtonItem_start.Enabled = true;
            this.barButtonItem_stop.Enabled = false;
            this.barButtonItem_close.Enabled = true;
            
            this.lblStatus.Text = "0.00%";
            this.progressBar.Value = 0;

            //INICIALIZA LOS EVENTOS DELEGADOS DE LA BARRA DE PROGRESO
            this.bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            this.bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            this.bw.DoWork += bw_DoWork;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int iRow = 0;
                int iRowCount = 0;
                
                int IdNivel_a_mostrar = 9;
                string msg = "";

                List<ct_AnioFiscal_Info> list_anio_fiscal = new List<ct_AnioFiscal_Info>();
                ct_AnioFiscal_Bus bus_anio_fiscal = new ct_AnioFiscal_Bus();

                list_anio_fiscal = bus_anio_fiscal.Get_list_AnioFiscal("A");

                // ELIMINAMOS EL PROCESO ANTERIOR POR EL USUARIO ACTUAL
                this.bus_dashboard_financiero.EliminarBD(param.IdEmpresa, param.IdUsuario);

                // ASIGNAMOS EL TOTAL DEL PROGRESS BAR
                iRowCount = list_anio_fiscal.Count;

                // INICIALIZAMOS EL CONTADOR DEL PROGRESS EN CER0
                iRow = 0;

                XCONTA_Rpt001_Bus Bus_BG = new XCONTA_Rpt001_Bus();
                XCONTA_Rpt002_Bus Bus_ER = new XCONTA_Rpt002_Bus();

                List<XCONTA_Rpt001_Info> lista_bg = new List<XCONTA_Rpt001_Info>();
                List<XCONTA_Rpt002_Info> lista_er = new List<XCONTA_Rpt002_Info>();

                List<tb_Mes_info> listMes = new List<tb_Mes_info>();
                tb_Mes_Bus busMes = new tb_Mes_Bus();

                listMes = busMes.Get_List_Mes();

                foreach (var _anio_fiscal in list_anio_fiscal)
                {
                    iRow++;

                    foreach(var item in listMes)
                    {
                        this.current_process_description = $"procesando periodo {_anio_fiscal.IdanioFiscal} - {item.smes} {iRow}/{iRowCount}";

                        // Fecha inicial del mes (siempre dia 1)
                        DateTime FechaIni = new DateTime(_anio_fiscal.IdanioFiscal, item.idMes, 1);

                        // Calcula el ultimo dia del mes
                        int ultimoDia = DateTime.DaysInMonth(_anio_fiscal.IdanioFiscal, item.idMes);

                        // Fecha final del mes
                        DateTime FechaFin = new DateTime(_anio_fiscal.IdanioFiscal, item.idMes, ultimoDia);

                        //DETIENE EL PROCESO SOLICTADO POR EL USUARIO, Y VERIFICA SI FUE CANCELADO
                        if (bw.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        // SI ANIO FISCAL ES IGUAL ANIO EN CURSO SALTO LA EJECUCION
                        if (_anio_fiscal.IdanioFiscal == DateTime.Now.Year)
                        {
                            // ACTUALIZAMOS EL ESTADO DEL PROGRESS BAR
                            update_progressBar((Convert.ToDouble(iRow) / Convert.ToDouble(iRowCount)) * 100);
                            continue;
                        }

                        // BALANCE GENERAL, OBTENEMOS EL MOVIMIENTO DE CUENTAS TOTALIZADAS SEGUN EL PERIODO ESTABLECIDO (CUENTAS DEL 1 AL 3)
                        lista_bg = Bus_BG.consultar_data(param.IdEmpresa, FechaIni, FechaFin, "", IdNivel_a_mostrar, 0, 0, false, false, true, param.IdUsuario, ref msg);
                        lista_bg = lista_bg.FindAll(q => q.gc_estado_financiero == "BG");

                        // ESTADO DE RESULTADO, OBTENEMOS EL MOVIMIENTO DE CUENTAS TOTALIZADAS SEGUN EL PERIODO ESTABLECIDO (CUENTAS DEL 4 AL 7)
                        lista_er = Bus_ER.consultar_data_RangoFecha(param.IdEmpresa, FechaIni, FechaFin, "", IdNivel_a_mostrar, 0, 0, false, false, false, param.IdUsuario, ref msg);
                        lista_er = lista_er.FindAll(q => q.gc_estado_financiero == "ER");

                        if (lista_bg.Count <= 0 || lista_er.Count <= 0)
                        {
                            // ACTUALIZAMOS EL ESTADO DEL PROGRESS BAR
                            update_progressBar((Convert.ToDouble(iRow) / Convert.ToDouble(iRowCount)) * 100);
                            continue;
                        }

                        // CUANTAS CONTABLES QUE PERTENECEN AL GRUPO BALANCE GENERAL
                        double _activo = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "1") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "1").Saldo)) : 0;
                        double _activo_corriente = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "101") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "101").Saldo)) : 0;
                        double _activo_no_corriente = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "102") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "102").Saldo)) : 0;
                        double _pasivo_corriente = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "201") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "201").Saldo)) : 0;
                        double _pasivo_no_corriente = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "202") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "202").Saldo)) : 0;
                        double _inventarios = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "10103") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "10103").Saldo)) : 0;
                        double _efectivo_equivalente_al_efectivo = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "10101") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "10101").Saldo)) : 0;
                        double _activos_financieros = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "10102") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "10102").Saldo)) : 0;
                        double _documentos_y_cuentas_x_cobrar = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "1010205") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "1010205").Saldo)) : 0;
                        double _pasivo = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "2") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "2").Saldo)) : 0;
                        double _patrimonio = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "3") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "3").Saldo)) : 0;
                        double _cuentas_y_documentos_x_pagar = (lista_bg.FirstOrDefault(q => q.IdCtaCble == "20101") != null) ? Math.Abs(Convert.ToDouble(lista_bg.FirstOrDefault(q => q.IdCtaCble == "20101").Saldo)) : 0;

                        // CUANTAS CONTABLES QUE PERTENECEN AL GRUPO ESTADO DE RESULTADO
                        double _ingresos_operacionales = (lista_er.FirstOrDefault(q => q.IdCtaCble == "4") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "4").Saldo)) : 0;
                        double _egresos_operacionales = (lista_er.FirstOrDefault(q => q.IdCtaCble == "5") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "5").Saldo)) : 0;
                        double _venta_de_bienes = (lista_er.FirstOrDefault(q => q.IdCtaCble == "401") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "401").Saldo)) : 0;
                        double _venta_de_servicio = (lista_er.FirstOrDefault(q => q.IdCtaCble == "402") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "402").Saldo)) : 0;
                        double _descuento_en_venta = (lista_er.FirstOrDefault(q => q.IdCtaCble == "403") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "403").Saldo)) : 0;
                        double _venta_diferida = (lista_er.FirstOrDefault(q => q.IdCtaCble == "404") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "404").Saldo)) : 0;
                        double _costo_venta = (lista_er.FirstOrDefault(q => q.IdCtaCble == "501") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "501").Saldo)) : 0;
                        double _gasto_administracion_y_ventas = (lista_er.FirstOrDefault(q => q.IdCtaCble == "6") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "6").Saldo)) : 0;
                        double _costo_financieros = (lista_er.FirstOrDefault(q => q.IdCtaCble == "70302") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "70302").Saldo)) : 0;
                        double _resultado_bruto = _ingresos_operacionales - _egresos_operacionales;
                        double _resultado_operacional = _resultado_bruto + (_gasto_administracion_y_ventas * -1);
                        double _gasto_personal = (lista_er.FirstOrDefault(q => q.IdCtaCble == "60101") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "60101").Saldo)) : 0;
                        double _honorarios_profesional = (lista_er.FirstOrDefault(q => q.IdCtaCble == "60102") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "60102").Saldo)) : 0;
                        double _servicios_basicos = (lista_er.FirstOrDefault(q => q.IdCtaCble == "60103") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "60103").Saldo)) : 0;
                        double _gasto_personal_2 = (lista_er.FirstOrDefault(q => q.IdCtaCble == "60201") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "60201").Saldo)) : 0;
                        double _honorarios_profesional_2 = (lista_er.FirstOrDefault(q => q.IdCtaCble == "60202") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "60202").Saldo)) : 0;
                        double _servicios_basicos_2 = (lista_er.FirstOrDefault(q => q.IdCtaCble == "60203") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "60203").Saldo)) : 0;
                        double _gasto_financiero = (lista_er.FirstOrDefault(q => q.IdCtaCble == "703") != null) ? Math.Abs(Convert.ToDouble(lista_er.FirstOrDefault(q => q.IdCtaCble == "703").Saldo)) : 0;

                        ct_dashboard_financiero_Info info_dashboard_financiero = new ct_dashboard_financiero_Info();
                        info_dashboard_financiero.IdEmpresa = param.IdEmpresa;
                        info_dashboard_financiero.IdUsuario = param.IdUsuario;
                        info_dashboard_financiero.anio_fiscal = _anio_fiscal.IdanioFiscal;
                        info_dashboard_financiero.IdMes = item.idMes;
                        info_dashboard_financiero.nomMes = item.smes;

                        // Ratios de Líquidez
                        info_dashboard_financiero.liq_razon_circulante = _activo_corriente / _pasivo_corriente; // Razón Circulante (Razón Líquidez, Líquidez General, Solvencía) 
                        info_dashboard_financiero.liq_razon_circulante_objetivo = 0; // objetivo
                        info_dashboard_financiero.liq_prueba_acida = (_activo_corriente - _inventarios) / _pasivo_corriente; // Prueba Ácida
                        info_dashboard_financiero.liq_prueba_acida_objetivo = 0; // objetivo
                        info_dashboard_financiero.liq_ratio_caja = (_efectivo_equivalente_al_efectivo + _activos_financieros) / _pasivo_corriente; // Ratio de caja (Prueba Defensiva)
                        info_dashboard_financiero.liq_dias_de_cobranza = (_documentos_y_cuentas_x_cobrar * 365) / (_venta_de_bienes + _venta_de_servicio + _descuento_en_venta + _venta_diferida); // Días de Cobranza (Período Promedio de Cobranza)
                        info_dashboard_financiero.liq_dias_de_inventario = ((_inventarios * 365) / _costo_venta); // Días de Inventario (Período Promedio de Inventario)
                        info_dashboard_financiero.liq_dias_de_pago = ((_cuentas_y_documentos_x_pagar * 365) / _costo_venta); // Días de Pago (Período Promedio de Pago)
                        info_dashboard_financiero.liq_rotarion_del_efectivo = ((_efectivo_equivalente_al_efectivo + _activos_financieros) * 365) / (_venta_de_bienes + _venta_de_servicio + _descuento_en_venta + _venta_diferida); // Rotación de Efectivo
                        info_dashboard_financiero.liq_rotacion_del_activo = (_venta_de_bienes + _venta_de_servicio + _descuento_en_venta + _venta_diferida) / _activo; // Rotación del Activo (ROA)
                        info_dashboard_financiero.liq_rotacion_del_activo_objetivo = 0; // objetivo
                        info_dashboard_financiero.liq_rotacion_del_activo_fijio = (_venta_de_bienes + _venta_de_servicio + _descuento_en_venta + _venta_diferida) / _activo_no_corriente; // Rotación del Activo Fijo
                        info_dashboard_financiero.liq_rotacion_del_activo_fijio_objetivo = 1; // objetvo
                        info_dashboard_financiero.liq_capital_de_trabajo = _activo_corriente - _pasivo_corriente; // Capital de Trabajo
                                                                                                                  // Ratios de Endeudamiento
                        info_dashboard_financiero.end_pasivo_total_x_patrimonio_total = _pasivo / _patrimonio; // Ratio de Endeudamiento (Estructura del Capital)
                        info_dashboard_financiero.end_pasivo_circulante_x_patrimonio_total = _pasivo_corriente / _patrimonio; // Ratio de Endeudamiento
                        info_dashboard_financiero.end_pasivo_no_circulante_x_patrimonio_total = _pasivo_no_corriente / _patrimonio; // Ratio de Endeudamiento
                        info_dashboard_financiero.end_pasivo_total_x_activo_total = _pasivo / _activo; // Ratio de Endeudamiento
                        info_dashboard_financiero.end_cobertura_gastos_financieros = _resultado_operacional / _gasto_financiero; // Cobertura de Gastos Financiero
                        info_dashboard_financiero.end_cobertura_gastos_financieros_objetivo = 0; // objetivo
                        info_dashboard_financiero.end_cobertura_gastos_fijos = _resultado_operacional / (_gasto_personal + _honorarios_profesional + _servicios_basicos + _gasto_personal_2 + _honorarios_profesional_2 + _servicios_basicos_2); // Cobertura de Gastos Fijos
                        info_dashboard_financiero.end_cobertura_gastos_fijos_objetivo = 0; // objetivo
                        info_dashboard_financiero.end_rotacion_inventario = _costo_venta / _inventarios; // Rotación de Inventario
                        info_dashboard_financiero.end_rotacion_inventario_objetivo = 0; // objetivo
                                                                                        // Ratios de Rentabilidad
                        info_dashboard_financiero.ren_sobre_la_inversion = _resultado_operacional / _activo; // Rendimiento Sobre la Inversión(Utilidad del Activo)
                        info_dashboard_financiero.ren_sobre_la_venta = _resultado_operacional / (_venta_de_bienes + _venta_de_servicio + _descuento_en_venta + _venta_diferida); // Rendimiento Sobre la Venta(Utilidad de  la Venta)
                        info_dashboard_financiero.ren_sobre_el_patrimonio = _resultado_operacional / _patrimonio; // Rendimiento Sobre el Patrimonio(ROE)
                        info_dashboard_financiero.ren_utilidad_accion = 0; // Utilidad de la Acción
                        info_dashboard_financiero.ren_margen_utilidad_bruta = (_ingresos_operacionales == 0) ? 0 : _resultado_bruto / _ingresos_operacionales; // Margen de Utilidad Bruta
                                                                                                                                                               // Ratios Totales
                        info_dashboard_financiero.pasivo_neto = _pasivo / (_pasivo + _patrimonio);
                        info_dashboard_financiero.patrimonio_neto = _patrimonio / (_pasivo + _patrimonio);

                        // REGISTRO EL CALCULO DEL INDICADOR EN LA BASE DE DATOS
                        if (!this.bus_dashboard_financiero.GrabarBD(info_dashboard_financiero))
                        {
                            MessageBox.Show("Error al grabar el indicador del dashboard", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                            return;
                        }
                    }

                    // ACTUALIZAMOS EL ESTADO DEL PROGRESS BAR
                    update_progressBar((Convert.ToDouble(iRow) / Convert.ToDouble(iRowCount)) * 100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_progressBar(double value)
        {
            this.bw.ReportProgress((int)value);
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.ProgressPercentage <= progressBar.Maximum)
                {
                    progressBar.Value = e.ProgressPercentage;
                    lblStatus.Text = this.current_process_description + " " + e.ProgressPercentage.ToString() + "%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("El proceso ha sido detenido por el usuario, revise por favor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.Message, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                barButtonItem_start.Enabled = true;
                barButtonItem_stop.Enabled = false;
                barButtonItem_close.Enabled = true;

                // CARGA DASHBOARD
                this.list_dashboard_financiero = this.bus_dashboard_financiero.GetList(param.IdEmpresa, param.IdUsuario);
                this.bindinglist_dashboard_financiero = new BindingList<ct_dashboard_financiero_Info>(this.list_dashboard_financiero);

                this.dashboardViewer_Financiero.ReloadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dashboardViewer_Financiero_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
            try
            {
                tb_Conexion_Dashboard_Info Info_ConexionDashboard = bus_ConexionDashboard.Get_Conexion_Dashboard();

                if (Info_ConexionDashboard == null)
                {
                    MessageBox.Show("La configuracion de conexion para el dashboard esta vacia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Checks the name of the connection for which the event has been raised.
                if (e.DataSourceName == "Origen de datos SQL 1")
                {
                    // Gets the connection parameters used to establish a connection to the database.
                    switch (Info_ConexionDashboard.Provider)
                    {
                        case "MySQL":
                            MySqlConnectionParameters parameters = (MySqlConnectionParameters)e.ConnectionParameters;
                            parameters.ServerName = Info_ConexionDashboard.ServerName; // "10.0.0.11";
                            parameters.PortNumber = Convert.ToInt32(Info_ConexionDashboard.PortNumber); // 3306;
                            parameters.DatabaseName = Info_ConexionDashboard.DatabaseName; // "DBERP_PRODUCCION";
                            parameters.UserName = Info_ConexionDashboard.UserName; // "mysql_sa";
                            parameters.Password = Info_ConexionDashboard.Password; // "admin*2012";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem_start_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Este proceso puede tardar unos minutos. ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                //INICIALIZA LOS VALORES
                progressBar.Maximum = 100;
                progressBar.Value = 0;

                //VERIFICA QUE LA TAREA EN BACKGROUND ESTA EJECUTANDOSE ASINCRONICAMENTE
                if (bw.IsBusy) { return; }

                barButtonItem_start.Enabled = false;
                barButtonItem_stop.Enabled = true;
                barButtonItem_close.Enabled = false;

                //EMPIEZA A EJECUTAR LA TAREA EN BACKGROUND
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem_stop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bw.WorkerSupportsCancellation)
            {
                if (MessageBox.Show("Desea finalizar el proceso?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bw.CancelAsync();

                    barButtonItem_start.Enabled = true;
                    barButtonItem_stop.Enabled = false;
                    barButtonItem_close.Enabled = true;

                    this.lblStatus.Text = "0.00%";
                    this.progressBar.Value = 0;
                }
            }
        }
    }
}