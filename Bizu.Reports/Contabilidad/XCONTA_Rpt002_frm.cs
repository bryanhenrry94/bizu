using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Bizu.Application.Contabilidad;
using Bizu.Domain.Contabilidad;
using Bizu.Application.General;
using Bizu.Reports.Contabilidad;
using Bizu.Domain.General;

namespace Bizu.Reports.Contabilidad
{

    public partial class XCONTA_Rpt002_frm : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> listPeriodo = new List<ct_Periodo_Info>();
        ct_Periodo_Info infoPeriodo = new ct_Periodo_Info();
        List<XCONTA_Rpt002_Info> lista = new List<XCONTA_Rpt002_Info>();
        XCONTA_Rpt002_Bus bus = new XCONTA_Rpt002_Bus();
        XCONTA_Rpt002_Info Info_Fila = new XCONTA_Rpt002_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        int dia_mes = DateTime.Now.Day;
        int mes = DateTime.Now.Month;
        int año = DateTime.Now.Year;
        int dias_mes = DateTime.Now.Day;
        string nom_mes = "";

        #endregion

        public XCONTA_Rpt002_frm()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt002_frm_Load(object sender, EventArgs e)
        {
            try
            {
                uCct_Menu_Reportes1.Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gw_balance_comp_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Info_Fila = (XCONTA_Rpt002_Info)gw_balance_comp.GetFocusedRow();

                if (col_pc_EsMovimiento.Name == e.Column.Name)
                {
                    llamada_movi_x_cta();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llamada_movi_x_cta()
        {
            try
            {

                if (Info_Fila != null)
                {
                    if (Info_Fila.pc_EsMovimiento == "S")
                    {
                        DateTime FechaIni = DateTime.Now;
                        DateTime FechaFin = DateTime.Now;


                        int IdPunto_Cargo_Grupo = 0;
                        int IdPunto_Cargo = 0;
                        string IdCentroCosto = "";

                        string[] cadena = Info_Fila.IdCtaCble.Split();

                        IdCentroCosto = uCct_Menu_Reportes1.Get_info_Centro_costo() == null ? "" : uCct_Menu_Reportes1.Get_info_Centro_costo().IdCentroCosto;

                        FechaIni = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Desde.EditValue);
                        FechaFin = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);
                        bool mostrar_asiento_cierre = Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check3.EditValue);

                        XCONTA_Rpt006_rpt Reporte = new XCONTA_Rpt006_rpt();

                        Reporte.RequestParameters = false;
                        ReportPrintTool pt = new ReportPrintTool(Reporte);
                        pt.AutoShowParametersPanel = false;

                        Reporte.P_IdEmpresa.Value = param.IdEmpresa;
                        Reporte.P_FechaIni.Value = FechaIni;
                        Reporte.P_FechaFin.Value = FechaFin;
                        Reporte.P_IdCtaCble.Value = cadena[0];
                        Reporte.P_IdPuntoCargo.Value = IdPunto_Cargo;
                        Reporte.P_IdPuntoCargo_Grupo.Value = IdPunto_Cargo_Grupo;
                        Reporte.P_IdCentro_Costo.Value = Info_Fila.IdCentroCosto;
                        Reporte.P_Mostrar_Asiento_cierre.Value = mostrar_asiento_cierre;
                        Reporte.Visible_col_CentroCosto = false;
                        Reporte.Visible_col_PuntoCargo = false;

                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                if (Reporte.P_IdCentro_Costo.Value == "")
                                {
                                    Reporte.bMostrarCentroCosto = true;
                                }
                                break;
                        }

                        //Reporte.bMostrarCentroCosto = true;
                        Reporte.ShowPreview();

                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCct_Menu_Reportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCct_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();
                XCONTA_Rpt002_Rpt Reporte = new XCONTA_Rpt002_Rpt();

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo = 0;
                int IdPunto_cargo = 0;

                DateTime FechaIni;
                DateTime FechaFin;

                List<string> ListIdCentroCosto = new List<string>();

                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo = "";
                string Nom_Punto_Cargo = "";
                bool Mostrar_CC = false;
                bool Mostrar_saldo_0 = false;
                bool Considerar_Asiento_cierre_anual = false;

                IdEmpresa = param.IdEmpresa;
                FechaIni = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Desde.EditValue);
                FechaFin = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);

                ListIdCentroCosto = new List<string>();
                ListIdCentroCosto.Add(Convert.ToString(uCct_Menu_Reportes1.bei_Centro_costo.EditValue));  //PARA UN SOLO CENTRO DE COSTO
                //ListIdCentroCosto = uCct_Menu_Reportes1.Get_list_CentroCosto_Cheked(); //PARA MULTIPLES CENTROS DE COSTO

                //SETEAMOS LOS VALORES A LAS VARIABLES
                IdNivel_a_mostrar = uCct_Menu_Reportes1.bei_Nivel.EditValue == null ? 0 : Convert.ToInt32(uCct_Menu_Reportes1.bei_Nivel.EditValue);
                Mostrar_saldo_0 = uCct_Menu_Reportes1.bei_Check.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check.EditValue);
                Mostrar_CC = uCct_Menu_Reportes1.bei_Check2.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check2.EditValue);
                Considerar_Asiento_cierre_anual = uCct_Menu_Reportes1.bei_Check3.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check3.EditValue);

                //SETEAMOS LOS VALORES AL REPORTE
                Reporte.listIdCentroCosto = ListIdCentroCosto;
                Reporte.PIdEmpresa.Value = IdEmpresa;
                Reporte.PFechaIni.Value = FechaIni;
                Reporte.PFechaFin.Value = FechaFin;
                Reporte.PIdNivel_a_mostrar.Value = IdNivel_a_mostrar;
                Reporte.PIdPunto_Cargo.Value = IdPunto_cargo;
                Reporte.PIdPunto_Cargo_Grupo.Value = IdPunto_cargo_grupo;
                Reporte.PMostrar_Reg_en_cero.Value = Mostrar_saldo_0;
                Reporte.P_MostrarCC.Value = Mostrar_CC;
                Reporte.PIdCentroCosto.Value = Convert.ToString(uCct_Menu_Reportes1.bei_Centro_costo.EditValue);
                Reporte.PConsiderar_Asiento_cierre_anual.Value = Considerar_Asiento_cierre_anual;


                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreview();
                splashScreenManager.CloseWaitForm();//terminar splash
            }
            catch (Exception ex)
            {
                if (splashScreenManager.IsSplashFormVisible)
                {
                    splashScreenManager.CloseWaitForm();//terminar splash
                }
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCct_Menu_Reportes1_event_btn_Mostrar_en_tabla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                string msg = "";
                XCONTA_Rpt002_Bus Bus = new XCONTA_Rpt002_Bus();
                List<XCONTA_Rpt002_Info> lista = new List<XCONTA_Rpt002_Info>();

                int IdEmpresa = 0;
                int IdNivel_a_mostrar = 0;
                int IdPunto_cargo_grupo = 0;
                int IdPunto_cargo = 0;

                DateTime FechaIni;
                DateTime FechaFin;

                List<string> ListIdCentroCosto = new List<string>();
                string Nom_centro_Costo = "";
                string Nom_Punto_Cargo_Grupo = "";
                string Nom_Punto_Cargo = "";
                bool Mostrar_CC = false;
                bool Mostrar_saldo_0 = false;
                bool Considerar_Asiento_cierre_anual = false;

                IdEmpresa = param.IdEmpresa;
                FechaIni = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Desde.EditValue);
                FechaFin = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);

                ListIdCentroCosto = new List<string>();
                ListIdCentroCosto.Add(Convert.ToString(uCct_Menu_Reportes1.bei_Centro_costo.EditValue));  //PARA UN SOLO CENTRO DE COSTO

                IdNivel_a_mostrar = uCct_Menu_Reportes1.bei_Nivel.EditValue == null ? 0 : Convert.ToInt32(uCct_Menu_Reportes1.bei_Nivel.EditValue);

                Mostrar_saldo_0 = uCct_Menu_Reportes1.bei_Check.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check.EditValue);
                Mostrar_CC = uCct_Menu_Reportes1.bei_Check2.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check2.EditValue);
                Considerar_Asiento_cierre_anual = uCct_Menu_Reportes1.bei_Check3.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check3.EditValue);

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        lista = Bus.consultar_data_RangoFecha(IdEmpresa, FechaIni, FechaFin, ListIdCentroCosto, IdNivel_a_mostrar, IdPunto_cargo_grupo,
                                                    IdPunto_cargo, Mostrar_saldo_0, Mostrar_CC, Considerar_Asiento_cierre_anual, param.IdUsuario, ref msg);
                        break;

                    default:
                        lista = Bus.consultar_data(IdEmpresa, FechaIni, FechaFin, ListIdCentroCosto, IdNivel_a_mostrar,
                    IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_saldo_0, Mostrar_CC, Considerar_Asiento_cierre_anual, param.IdUsuario, ref msg);

                        break;
                }

                ///////////////////////////////////////////////////
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        foreach (var item in lista)
                        {
                            if (item.IdCtaCble.Length == 5 && item.Saldo > 0)
                            {
                                string idctacble = "", nom_cuenta = "";
                                idctacble = item.IdCtaCble;
                                nom_cuenta = item.nom_cuenta;

                                item.IdCtaCble = "";
                                item.nom_cuenta = "";
                                item.IdCtaCble = idctacble + " Sin CC";
                                item.nom_cuenta = nom_cuenta + "/Sin Centro de Costo";
                            }
                        }
                        break;
                }



                gc_balance.DataSource = lista;
                gc_balance.RefreshDataSource();


                string Titulo = "";
                Titulo = "ESTADO DE RESULTADOS \n";
                Titulo = Titulo + " Desde:" + FechaIni.ToShortDateString() + "  Hasta:" + FechaFin.ToShortDateString() + "\n";

                //if (IdCentroCosto != "")
                //{
                //    Titulo = Titulo + " Centro Costo:" + "[" + IdCentroCosto + "] - " + Nom_centro_Costo + "\n";
                //}

                if (IdPunto_cargo_grupo > 0)
                {
                    Titulo = Titulo + " Grupo:" + Nom_Punto_Cargo_Grupo + "\n";
                }

                if (IdPunto_cargo > 0)
                {
                    Titulo = Titulo + " Punto Cargo:" + Nom_Punto_Cargo + "\n";
                }


                gw_balance_comp.ViewCaption = Titulo;

                splashScreenManager.CloseWaitForm();//terminar splash
            }
            catch (Exception ex)
            {
                if (splashScreenManager.IsSplashFormVisible)
                {
                    splashScreenManager.CloseWaitForm();//terminar splash
                }
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCct_Menu_Reportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XCONTA_Rpt002_Rpt Reporte = new XCONTA_Rpt002_Rpt();
            XCONTA_Rpt002_Bus Bus = new XCONTA_Rpt002_Bus();
            List<XCONTA_Rpt002_Info> lista = new List<XCONTA_Rpt002_Info>();
            string msg = "";

            int IdEmpresa = 0;
            int IdNivel_a_mostrar = 0;
            int IdPunto_cargo_grupo = 0;
            int IdPunto_cargo = 0;

            DateTime FechaIni;
            DateTime FechaFin;

            List<string> ListIdCentroCosto = new List<string>();
            string Nom_centro_Costo = "";
            string Nom_Punto_Cargo_Grupo = "";
            string Nom_Punto_Cargo = "";
            bool Mostrar_CC = false;
            bool Mostrar_saldo_0 = false;
            bool Considerar_Asiento_cierre_anual = false;

            IdEmpresa = param.IdEmpresa;
            FechaIni = uCct_Menu_Reportes1.bei_Desde.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Desde.EditValue);
            FechaFin = uCct_Menu_Reportes1.bei_Hasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(uCct_Menu_Reportes1.bei_Hasta.EditValue);

            ListIdCentroCosto = new List<string>();
            ListIdCentroCosto.Add(Convert.ToString(uCct_Menu_Reportes1.bei_Centro_costo.EditValue));  //PARA UN SOLO CENTRO DE COSTO
            //ListIdCentroCosto = uCct_Menu_Reportes1.Get_list_CentroCosto_Cheked(); //PARA MULTIPLES CENTROS DE COSTO

            IdNivel_a_mostrar = uCct_Menu_Reportes1.bei_Nivel.EditValue == null ? 0 : Convert.ToInt32(uCct_Menu_Reportes1.bei_Nivel.EditValue);

            Mostrar_saldo_0 = uCct_Menu_Reportes1.bei_Check.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check.EditValue);
            Mostrar_CC = uCct_Menu_Reportes1.bei_Check2.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check2.EditValue);
            Considerar_Asiento_cierre_anual = uCct_Menu_Reportes1.bei_Check3.EditValue == null ? false : Convert.ToBoolean(uCct_Menu_Reportes1.bei_Check3.EditValue);

            lista = Bus.consultar_data_RangoFecha(IdEmpresa, FechaIni, FechaFin, ListIdCentroCosto, IdNivel_a_mostrar, IdPunto_cargo,
                IdPunto_cargo_grupo, Mostrar_saldo_0, Mostrar_CC, Considerar_Asiento_cierre_anual, param.IdUsuario, ref msg);

            gridControlCbteBanDep.DataSource = lista.ToArray();

            gridControlCbteBanDep.ShowPrintPreview();

        }
    }
}