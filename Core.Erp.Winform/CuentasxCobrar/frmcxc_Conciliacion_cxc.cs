﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Reportes.CuentasxCobrar;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Conciliacion_cxc : DevExpress.XtraEditors.XtraForm
    {
        //Bus       
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwcxc_cartera_x_cobrar_Bus cartera_B = new vwcxc_cartera_x_cobrar_Bus();
        cxc_conciliacion_Bus Bus_Conciliacion = new cxc_conciliacion_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_conciliacion_det_Bus Bus_DetConcilia = new cxc_conciliacion_det_Bus();
        fa_notaCreDeb_x_cxc_cobro_Bus Bus_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Bus();
        cxc_cobro_Bus cobro_B = new cxc_cobro_Bus();
        vwcxc_cobros_Pendientes_x_conciliar_Bus Bus_CreDeb = new vwcxc_cobros_Pendientes_x_conciliar_Bus();
        vwcxc_anticipos_x_cruzar_Bus Bus_Anticipo = new vwcxc_anticipos_x_cruzar_Bus();
        cxc_parametro_Bus paramCxcBus = new cxc_parametro_Bus();
        fa_notaCredDeb_Bus Bus_NCreDeb = new fa_notaCredDeb_Bus();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        //listas
        List<vwcxc_cartera_x_cobrar_Info> lst;
        List<vwcxc_cartera_x_cobrar_Info> list_Saldo;
        List<cxc_conciliacion_det_Info> Listdet;
        List<vwcxc_cobros_Pendientes_x_conciliar_Info> List_CreDeb;
        List<vwcxc_anticipos_x_cruzar_Info> List_Anticipo = new List<vwcxc_anticipos_x_cruzar_Info>();
        List<vwcxc_anticipos_facturados_x_cruzar_Info> List_Anticipo_Facturado = new List<vwcxc_anticipos_facturados_x_cruzar_Info>();
        List<cxc_conciliacion_det_Info> Listdetalle = new List<cxc_conciliacion_det_Info>();
        List<cxc_conciliacion_det_Info> Listdet_cobro = new List<cxc_conciliacion_det_Info>();

        //BindingList        
        BindingList<vwcxc_cartera_x_cobrar_Info> DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>();
        BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info> DataSource_CreDeb = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>();
        BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info> DataSource_CreDeb2 = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>();
        BindingList<vwcxc_anticipos_x_cruzar_Info> DataSource_Anticipo = new BindingList<vwcxc_anticipos_x_cruzar_Info>();
        BindingList<vwcxc_anticipos_facturados_x_cruzar_Info> DataSource_Anticipo_Facturado = new BindingList<vwcxc_anticipos_facturados_x_cruzar_Info>();
        public delegate void delegate_frmcxc_Conciliacion_cxc_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmcxc_Conciliacion_cxc_FormClosing event_frmcxc_Conciliacion_cxc_FormClosing;

        Cl_Enumeradores.eTipo_action _Accion;
        //Variables
        decimal IdCliente = 0;
        int IdSucursal = 0;
        int band = 0;
        int IdTipoCbteConciliaAnt = 0;

        Cl_Enumeradores.TipoConciliacion IdTipoConciliacion;
        string MensajeError = "";

        public frmCxc_Conciliacion_cxc()
        {
            try
            {
                InitializeComponent();
                event_frmcxc_Conciliacion_cxc_FormClosing += frmcxc_Conciliacion_cxc_event_frmcxc_Conciliacion_cxc_FormClosing;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnImprimirSoporte_Click += ucGe_Menu_event_btnImprimirSoporte_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarDatos()
        {
            try
            {
                cab = new cxc_conciliacion_Info();
                cab.Detalle = new List<cxc_conciliacion_det_Info>();
                Listdetalle = new List<cxc_conciliacion_det_Info>();
                Listdet_cobro = new List<cxc_conciliacion_det_Info>();
                cab.DetalleCobroFact = new List<cxc_conciliacion_det_Info>();
                txtObservacion.Text = "";
                DataSource_CreDeb = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                this.gridControlCreDebSaldo.DataSource = DataSource_CreDeb;
                DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>();
                this.gridControlFacturas.DataSource = DataSource;
                CbteCbleInfo = new ct_Cbtecble_Info();
                CbteCbleInfo._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                ucCon_GridDiario.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                List<XCXC_Rpt003_Info> lstRpt = new List<XCXC_Rpt003_Info>();
                XCXC_Rpt003_Bus busRpt = new XCXC_Rpt003_Bus();
                XCXC_Rpt003_rpt Reporte = new XCXC_Rpt003_rpt(param.IdUsuario);

                Reporte.RequestParameters = false;
                lstRpt = busRpt.get_ImpresionConciliacion(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToDecimal(txtNumConcilia.Text));
                Reporte.lstRpt = lstRpt;

                Reporte.CreateDocument();
                Reporte.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular_Conciliacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                    if (Insertar_Conciliacion())
                        this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Insertar_Conciliacion();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();

        public frmCxc_Conciliacion_cxc(Cl_Enumeradores.eTipo_action Numerador)
            : this()
        {
            try
            {
                enu = Numerador;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmcxc_Conciliacion_cxc_Load(object sender, EventArgs e)
        {
            try
            {     
                cxc_parametro_Info paramCxcInfo = new cxc_parametro_Info();
                this.cmbSaldo.SelectedIndex = 0;
                dteFecha.EditValue = param.Fecha_Transac;
                _Accion = enu;
                paramCxcInfo = paramCxcBus.Get_Info_parametro(param.IdEmpresa);
                IdTipoCbteConciliaAnt = Convert.ToInt32(paramCxcInfo.pa_IdTipoCbte_x_conciliacion);
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dteFecha.EditValue), ref MensajeError);
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        lblAnulado.Visible = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtNumConcilia.Enabled = false;
                        this.txtNumConcilia.BackColor = System.Drawing.Color.White;
                        this.txtNumConcilia.ForeColor = System.Drawing.Color.Black;
                        ucGe_Menu.Enabled_btnImprimirSoporte = false;
                        //  gridColumnEstadoPago.OptionsColumn.AllowEdit = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        this.txtNumConcilia.Enabled = false;
                        this.txtNumConcilia.BackColor = System.Drawing.Color.White;
                        this.txtNumConcilia.ForeColor = System.Drawing.Color.Black;
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                        cmbSaldo.Enabled = false;
                        SETINFO();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        //ucfA_Cliente_Facturacion1.Enabled = false;
                        //ucIn_Sucursal_Bodega1.Enabled = false;
                        cmbSaldo.Enabled = false;
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                        SETINFO();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public cxc_conciliacion_Info SETINFO_ { get; set; }
  
        ct_Cbtecble_Info CbteCbleInfo = new ct_Cbtecble_Info();

        void GeneraDiarioAnticipo()
        {
            try
            {
                List<ct_Cbtecble_det_Info> ListDetalle = new List<ct_Cbtecble_det_Info>();
                string IdCtaCble = "";
                double valorTotal = 0;
                ucCon_GridDiario.LimpiarGrid();
                foreach (var item in list_Saldo)
                {
                    if (item.check_cartera == true)
                    {
                        valorTotal = valorTotal + Convert.ToDouble(item.valor_aplicar);
                    }
                }

                foreach (var item in List_CreDeb)
                {
                    if (item.check_cds == true)
                    {
                        ct_Cbtecble_det_Info pagos = new ct_Cbtecble_det_Info();
                        pagos.IdEmpresa = param.IdEmpresa;
                        pagos.IdCtaCble = item.IdCtaCble_Anti;
                        IdCtaCble = item.IdCtaCble_cxc;
                        pagos.dc_Valor = (valorTotal == 0) ? item.Saldo : valorTotal;
                        pagos.dc_Observacion = "Conciliación por Anticipo " + item.Tipo + "";

                        ListDetalle.Add(pagos);
                    }
                }

                foreach (var item in List_Anticipo)
                {
                    if (item.check_cds == true)
                    {
                        ct_Cbtecble_det_Info pagos = new ct_Cbtecble_det_Info();
                        pagos.IdEmpresa = param.IdEmpresa;
                        pagos.IdCtaCble = item.IdCtaCble_Anti;
                        IdCtaCble = item.IdCtaCble_cxc;
                        pagos.dc_Valor = (valorTotal == 0) ? item.Saldo_Pendiente : valorTotal;
                        pagos.dc_Observacion = "Conciliación por Anticipo " + item.IdCobro_tipo + "";

                        ListDetalle.Add(pagos);
                    }
                }

                foreach (var item in List_Anticipo_Facturado)
                {
                    if (item.check_cds == true)
                    {
                        ct_Cbtecble_det_Info pagos = new ct_Cbtecble_det_Info();
                        pagos.IdEmpresa = param.IdEmpresa;
                        pagos.IdCtaCble = item.IdCtaCble_Anti;
                        IdCtaCble = item.IdCtaCble_cxc;
                        pagos.dc_Valor = (valorTotal == 0) ? item.Saldo_Pendiente : valorTotal;
                        pagos.dc_Observacion = "Conciliación por Anticipo " + item.IdCobro_tipo + "";

                        ListDetalle.Add(pagos);
                    }
                }

                foreach (var item in list_Saldo)
                {
                    if (item.check_cartera == true)
                    {
                        ct_Cbtecble_det_Info cbtes = new ct_Cbtecble_det_Info();
                        cbtes.IdEmpresa = param.IdEmpresa;
                        cbtes.IdCtaCble = IdCtaCble;
                        cbtes.dc_Valor = (Convert.ToDouble(item.valor_aplicar) > 0) ? Convert.ToDouble(item.valor_aplicar) * -1 : 0;
                        cbtes.dc_Observacion = "Conciliación por Anticipo " + item.vt_tipoDoc + "";

                        ListDetalle.Add(cbtes);
                    }
                }
                ucCon_GridDiario.setDetalle(ListDetalle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ct_Cbtecble_Info getCbtecble()
        {
            try
            {
                CbteCbleInfo.IdEmpresa = param.IdEmpresa;
                CbteCbleInfo.IdTipoCbte = IdTipoCbteConciliaAnt;
                CbteCbleInfo.CodCbteCble = "";
                CbteCbleInfo.IdPeriodo = Per_I.IdPeriodo;

                CbteCbleInfo.cb_Fecha = Convert.ToDateTime(dteFecha.EditValue);
                CbteCbleInfo.cb_Valor = ucCon_GridDiario.Get_ValorCbteCble();
                CbteCbleInfo.cb_Observacion = txtObservacion.Text.Trim();
                CbteCbleInfo.Secuencia = 0;
                CbteCbleInfo.Estado = "A";

                CbteCbleInfo.Anio = Convert.ToDateTime(dteFecha.EditValue).Year;

                CbteCbleInfo.Mes = Convert.ToDateTime(dteFecha.EditValue).Month;
                CbteCbleInfo.IdUsuario = param.IdUsuario;
                CbteCbleInfo.IdUsuarioUltModi = param.IdUsuario;
                CbteCbleInfo.cb_FechaTransac = param.Fecha_Transac;
                CbteCbleInfo.cb_FechaUltModi = param.Fecha_Transac;
                CbteCbleInfo.Mayorizado = "N";
                CbteCbleInfo.IdCbteCble = (txtNumConcilia.EditValue == "") ? 0 : Convert.ToDecimal(txtNumConcilia.EditValue);


                getCbteCble_Det();

                return CbteCbleInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_Info();
            }
        }

        public List<ct_Cbtecble_det_Info> getCbteCble_Det()
        {
            try
            {
                var lstDetalle = ucCon_GridDiario.Get_Info_CbteCble()._cbteCble_det_lista_info;
                int i = 1;
                foreach (var dte in lstDetalle)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = (txtNumConcilia.EditValue == "") ? 0 : Convert.ToDecimal(txtNumConcilia.EditValue);
                    dte.IdTipoCbte = IdTipoCbteConciliaAnt;

                    dte.secuencia = i++;
                }
                CbteCbleInfo._cbteCble_det_lista_info = lstDetalle;

                return lstDetalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        void bloquearDiario(object sender, EventArgs e)
        {
            try
            {
                if (Cl_Enumeradores.TipoConciliacion.ANT_CLI == IdTipoConciliacion)
                    ucCon_GridDiario.Enabled = true;
                else
                    ucCon_GridDiario.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SETINFO()
        {
            try
            {
                cxc_conciliacion_det_Info conciDetInfo = new cxc_conciliacion_det_Info();
                List<vwcxc_cobros_conciliados_Info> lstCobroConciliado = new List<vwcxc_cobros_conciliados_Info>();
                vwcxc_cobros_conciliados_Bus conciliadoBus = new vwcxc_cobros_conciliados_Bus();
                List<vwcxc_conciliacion_Det_Cobro_Info> lstConciliaDetInfo = new List<vwcxc_conciliacion_Det_Cobro_Info>();
                List<vwcxc_cartera_x_cobrar_Info> listSaldoFactu = new List<vwcxc_cartera_x_cobrar_Info>();
                vwcxc_conciliacion_Det_Cobro_Bus ConciliaDetBus = new vwcxc_conciliacion_Det_Cobro_Bus();
                BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info> bindignPendientesInfo = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                SETINFO_.IdEmpresa = param.IdEmpresa;

                this.txtNumConcilia.EditValue = SETINFO_.IdConciliacion;
                this.txtObservacion.Text = SETINFO_.Observacion;
                this.dteFecha.EditValue = SETINFO_.Fecha;

                ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = SETINFO_.IdSucursal;
                ucfA_Cliente_Facturacion1.cmb_cliente.EditValue = SETINFO_.IdCliente;

                string mensaje = "";
                lstConciliaDetInfo = ConciliaDetBus.Get_List_conciliacion_Det_Cobro(param.IdEmpresa, SETINFO_.IdSucursal,
                    SETINFO_.IdConciliacion, ref mensaje);

                ucCon_GridDiario.setInfo(SETINFO_.IdEmpresa_cbte_cble, SETINFO_.IdTipoCbte_cbte_cble, SETINFO_.IdCbteCble_cbte_cble);
                foreach (var item in lstConciliaDetInfo)
                {
                    vwcxc_cartera_x_cobrar_Info info_Fact = new vwcxc_cartera_x_cobrar_Info();
                    info_Fact.check_cartera = true;
                    info_Fact.IdEmpresa = item.IdEmpresa;
                    info_Fact.IdSucursal = item.IdSucursal;
                    info_Fact.IdBodega = Convert.ToInt32(item.IdBodega);
                    info_Fact.vt_tipoDoc = item.vt_tipoDoc;
                    info_Fact.vt_NunDocumento = item.vt_NunDocumento;
                    info_Fact.Referencia = item.Referencia;
                    info_Fact.IdComprobante = item.IdComprobante;
                    info_Fact.CodComprobante = item.CodComprobante;
                    info_Fact.Su_Descripcion = item.Su_Descripcion;
                    info_Fact.IdCliente = item.IdCliente;
                    info_Fact.vt_fecha = item.vt_fecha;
                    info_Fact.vt_total = item.vt_total;
                    info_Fact.TotalxCobrado = item.TotalxCobrado;
                    info_Fact.Bodega = item.Bodega;
                    info_Fact.vt_Subtotal = item.vt_Subtotal;
                    info_Fact.vt_iva = item.vt_iva;
                    info_Fact.vt_fech_venc = item.vt_fech_venc;
                    info_Fact.NomCliente = item.NomCliente;
                    info_Fact.pe_nombreCompleto = "[" + info_Fact.IdCliente + "] : " + item.em_nombre;
                    info_Fact.SaldoAUX = item.Saldo;
                    info_Fact.Saldo = item.Saldo;
                    info_Fact.valor_aplicar = item.TotalxCobrado;
                    listSaldoFactu.Add(info_Fact);
                }
                this.gridControlFacturas.DataSource = listSaldoFactu;

                if (SETINFO_.Estado == "I")
                {
                    this.lblAnulado.Visible = true;
                }
                else
                {
                    this.lblAnulado.Visible = false;
                }

                conciDetInfo = SETINFO_.Detalle.First();
                lstCobroConciliado = conciliadoBus.Get_List_cobros_conciliados(param.IdEmpresa, SETINFO_.IdSucursal, SETINFO_.IdConciliacion, conciDetInfo.IdTipoConciliacion, ref mensaje);
                bindignPendientesInfo = setAnticiposCredDebConciliacion(lstCobroConciliado);
          
                if (conciDetInfo.IdTipoConciliacion == Cl_Enumeradores.TipoConciliacion.ANT_CLI.ToString())
                {
                    IdTipoConciliacion = Cl_Enumeradores.TipoConciliacion.ANT_CLI;

                    //SE DEBE CORREGIR NO ESTA CONSULTANDO TODOS LOS CAMPOS NECESARIOS A MOSTRAR EN LA TABLA DE CONCILIACION POR ANTICIPO
                    DataSource_Anticipo = new BindingList<vwcxc_anticipos_x_cruzar_Info>(List_Anticipo);
                    this.gridControlAnticipoClientes.DataSource = DataSource_Anticipo;

                    TabControl.SelectedIndex = 1;
                }

                if (conciDetInfo.IdTipoConciliacion == Cl_Enumeradores.TipoConciliacion.NT_CR_DB.ToString())
                {
                    IdTipoConciliacion = Cl_Enumeradores.TipoConciliacion.NT_CR_DB;
                    gridControlCreDebSaldo.DataSource = bindignPendientesInfo;
                    TabControl.SelectedIndex = 0;
                }

                //bloqueamos pa que no modifiquen
                /*this.colcheck_cds.OptionsColumn.ReadOnly = true;
                this.colcheck_cds1.OptionsColumn.ReadOnly = true;
                this.colcheck_cartera.OptionsColumn.ReadOnly = true;*/
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info> setAnticiposCredDebConciliacion(List<vwcxc_cobros_conciliados_Info> lstCobroConciliado)
        {
            try
            {
                List<vwcxc_cobros_Pendientes_x_conciliar_Info> List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                foreach (var item in lstCobroConciliado)
                {
                    vwcxc_cobros_Pendientes_x_conciliar_Info info_CreDeb = new vwcxc_cobros_Pendientes_x_conciliar_Info();
                    info_CreDeb.check_cds = true;
                    info_CreDeb.IdEmpresa = item.IdEmpresa;
                    info_CreDeb.IdSucursal = item.IdSucursal;
                    info_CreDeb.IdBodega = item.IdBodega;
                    info_CreDeb.Tipo = item.Tipo;
                    info_CreDeb.IdNota = item.IdNota;
                    info_CreDeb.CreDeb = item.CreDeb;
                    info_CreDeb.Serie1 = item.Serie1;
                    info_CreDeb.Serie2 = item.Serie2;
                    info_CreDeb.NumNota_Impresa = item.NumNota_Impresa;
                    info_CreDeb.IdCliente = item.IdCliente;
                    info_CreDeb.NomSucursal = item.NomSucursal;
                    info_CreDeb.Nom_Bodega = item.Nom_Bodega;
                    info_CreDeb.no_fecha = item.no_fecha;
                    info_CreDeb.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                    info_CreDeb.sc_observacion = item.sc_observacion;
                    info_CreDeb.Nom_Cliente = item.Nom_Cliente;
                    info_CreDeb.Motivo_Nota = item.Motivo_Nota;
                    info_CreDeb.Referencia = item.Referencia;
                    info_CreDeb.sc_total = Convert.ToDouble(item.sc_total);
                    info_CreDeb.Saldo = item.saldoAUX_CreDeb;
                    info_CreDeb.saldoAUX_CreDeb = item.saldoAUX_CreDeb;
                    info_CreDeb.IdTipoConciliacion = item.IdTipoConciliacion;
                    info_CreDeb.IdCobro_Tipo = item.IdCobro_Tipo;
                    info_CreDeb.IdCobro = item.IdCobro;
                    info_CreDeb.IdTipoNota = item.IdTipoNota;
                    info_CreDeb.NombreCompleto = item.NombreCompleto;

                    info_CreDeb.IdCaja = item.IdCaja;

                    List_CreDeb.Add(info_CreDeb);

                }
                DataSource_CreDeb = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>(List_CreDeb);
                return DataSource_CreDeb;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>();
            }
        }

        cxc_conciliacion_Info cab = new cxc_conciliacion_Info();

        public void GetCabecera()
        {
            try
            {
                cab.IdEmpresa = param.IdEmpresa;
                cab.IdSucursal = IdSucursal;
                cab.IdCliente = IdCliente;
                cab.Observacion = txtObservacion.Text;
                cab.Estado = "A";
                cab.Fecha = Convert.ToDateTime(dteFecha.EditValue);
                cab.Fecha_Transaccion = param.Fecha_Transac;
                cab.IdUsuario = param.IdUsuario;
                cab.nom_pc = param.nom_pc;
                cab.ip = param.ip;
                GetDetalle();
                // cab.Detalle = Listdet; 
                cab.Detalle = Listdetalle;
                cab.DetalleCobroFact = Listdet_cobro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        public void GetDetalle()
        {
            try
            {
                Listdetalle = new List<cxc_conciliacion_det_Info>();
                Listdet_cobro = new List<cxc_conciliacion_det_Info>();
                decimal IdCobro = 0;
                
                if (TabControl.SelectedTab.Name == "TabAntiCli")
                {
                    GetDetalle_Anticipo(ref IdCobro);
                }

                if (TabControl.SelectedTab.Name == "TabAntiCli_Pendientes_De_Diario")
                {
                    GetDetalle_Anticipo_PendienteDiario(ref IdCobro);
                }

                if (TabControl.SelectedTab.Name == "TabDebCre")
                {
                    GetDetalle_CreDeb(ref IdCobro);
                }

                int focus = this.gridViewFacturas.FocusedRowHandle;
                gridViewFacturas.FocusedRowHandle = focus + 1;

                DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>(list_Saldo);
                this.gridControlFacturas.DataSource = DataSource;
                foreach (var item in DataSource)
                {
                    cxc_conciliacion_det_Info info_det = new cxc_conciliacion_det_Info();
                    info_det.check = item.check_cartera;
                    if (info_det.check == true)
                    {
                        info_det.IdEmpresa_cbr = null;
                        info_det.IdSucursal_cbr = null;
                        info_det.IdCobro = IdCobro;
                        info_det.IdEmpresa = param.IdEmpresa;
                        info_det.IdSucursal = item.IdSucursal;
                        info_det.IdTipoConciliacion = Cl_Enumeradores.TipoConciliacion.VTA.ToString();
                        info_det.IdEmpresa_nt = null;
                        info_det.IdSucursal_nt = null;
                        info_det.IdBodega_nt = null;
                        info_det.IdNota_nt = null;
                        info_det.IdEmpresa_fa = null;
                        info_det.IdSucursal_fa = null;
                        info_det.IdBodega_fa = null;
                        info_det.IdCbteVta_fa = null;

                        //SI EL DOCUMENTO SELECCIONADO ES UNA N/D SE PASAN LOS VALORES CASO CONTRARIO ES UNA FACTURA
                        if (Cl_Enumeradores.eTipoDocumento_Talonario.NTDB.ToString() == item.vt_tipoDoc)
                        {
                            info_det.IdEmpresa_nt = item.IdEmpresa;
                            info_det.IdSucursal_nt = item.IdSucursal;
                            info_det.IdBodega_nt = item.IdBodega;
                            info_det.IdNota_nt = item.IdComprobante; // IdComprobante == IdNota
                        }
                        else
                        {
                            info_det.IdEmpresa_fa = item.IdEmpresa;
                            info_det.IdSucursal_fa = item.IdSucursal;
                            info_det.IdBodega_fa = item.IdBodega;
                            info_det.IdCbteVta_fa = item.IdComprobante;
                        }

                        //No se debe enviar IdCobro en null
                        //info_det.IdCobro = null;
                        info_det.Saldo_por_aplicar = Convert.ToDouble(item.Saldo);
                        info_det.Valor_Aplicado = item.valor_aplicar;
                        info_det.TipoDoc_vta = item.vt_tipoDoc;
                        // Listdet.Add(info_det);

                        Listdetalle.Add(info_det);
                        Listdet_cobro.Add(info_det);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int CreDeb_IdEmpresa_nt = 0;
        int CreDeb_IdSucursal_nt = 0;
        int CreDeb_IdBodega_nt = 0;
        int CreDeb_IdNota_nt = 0;

        public void GetDetalle_CreDeb(ref decimal IdCobro)
        {
            try
            {
                int focus = this.gridViewCreDebSaldo.FocusedRowHandle;
                gridViewCreDebSaldo.FocusedRowHandle = focus + 1;
                cxc_cobro_Info cxcCobroInfo = new cxc_cobro_Info();
                DataSource_CreDeb = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>(List_CreDeb);
                this.gridControlCreDebSaldo.DataSource = DataSource_CreDeb;

                foreach (var item in DataSource_CreDeb)
                {
                    cxc_conciliacion_det_Info info_CreDeb = new cxc_conciliacion_det_Info();
                    info_CreDeb.check_cds = item.check_cds;
                    if (info_CreDeb.check_cds == true)
                    {
                        info_CreDeb.IdEmpresa = param.IdEmpresa;
                        info_CreDeb.IdSucursal = Convert.ToInt32(item.IdSucursal);
                        info_CreDeb.IdEmpresa_cbr = null;
                        info_CreDeb.IdSucursal_cbr = null;
                        info_CreDeb.IdTipoConciliacion = item.IdTipoConciliacion;
                        if (item.IdTipoConciliacion == Cl_Enumeradores.TipoConciliacion.NT_CR_DB.ToString())
                        {
                            info_CreDeb.IdEmpresa_nt = item.IdEmpresa;
                            info_CreDeb.IdSucursal_nt = item.IdSucursal;
                            info_CreDeb.IdBodega_nt = item.IdBodega;
                            info_CreDeb.IdNota_nt = item.IdNota;
                            info_CreDeb.IdCobro = null;
                        }
                        else
                        {
                            info_CreDeb.IdCobro = item.IdCobro;
                            info_CreDeb.IdEmpresa_nt = null;
                            info_CreDeb.IdSucursal_nt = null;
                            info_CreDeb.IdBodega_nt = null;
                            info_CreDeb.IdNota_nt = null;
                        }
                        info_CreDeb.IdEmpresa_fa = null;
                        info_CreDeb.IdSucursal_fa = null;
                        info_CreDeb.IdBodega_fa = null;
                        info_CreDeb.IdCbteVta_fa = null;
                        info_CreDeb.Saldo_por_aplicar = Convert.ToDouble(item.Saldo);
                        info_CreDeb.Valor_Aplicado = Convert.ToDouble(item.saldoAUX_CreDeb - item.Saldo);
                        info_CreDeb.TipoDoc_vta = null;

                        if (item.IdCobro_Tipo == "NTDE") { item.IdCobro_Tipo = "NTDB"; }

                        info_CreDeb.IdCobro_Tipo = item.IdCobro_Tipo;
                        info_CreDeb.IdTipoNota = Convert.ToInt32(item.IdTipoNota);
                        info_CreDeb.IdCaja = item.IdCaja;
                        //variables
                        cxcCobroInfo.IdCobro_tipo = info_CreDeb.IdCobro_Tipo;
                        cxcCobroInfo.IdTipoNotaCredito = info_CreDeb.IdTipoNota;
                        cxcCobroInfo.IdCaja = info_CreDeb.IdCaja;
                        cxcCobroInfo.cr_TotalCobro = info_CreDeb.Valor_Aplicado;
                        cxcCobroInfo.cr_observacion = item.Nom_Cliente;
                        cxcCobroInfo.EsNegativo = "";

                        if (cmbSaldo.SelectedIndex == 1)
                        {
                            cxcCobroInfo.EsNegativo = "SI";
                        }

                        CreDeb_IdEmpresa_nt = Convert.ToInt32(info_CreDeb.IdEmpresa_nt);
                        CreDeb_IdSucursal_nt = Convert.ToInt32(info_CreDeb.IdSucursal_nt);
                        CreDeb_IdBodega_nt = Convert.ToInt32(info_CreDeb.IdBodega_nt);
                        CreDeb_IdNota_nt = Convert.ToInt32(info_CreDeb.IdNota_nt);
                        IdCobro = Convert.ToDecimal(info_CreDeb.IdCobro);
                        //variables
                        cab.cxc_cobro_Info = cxcCobroInfo;
                        Listdetalle.Add(info_CreDeb);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetDetalle_Anticipo(ref decimal IdCobro)
        {
            try
            {
                int focus = this.gridViewCreDebSaldo.FocusedRowHandle;
                gridViewCreDebSaldo.FocusedRowHandle = focus + 1;
                cxc_cobro_Info cxcCobroInfo = new cxc_cobro_Info();
                DataSource_Anticipo = new BindingList<vwcxc_anticipos_x_cruzar_Info>(List_Anticipo);
                this.gridControlAnticipoClientes.DataSource = DataSource_Anticipo;

                foreach (var item in DataSource_Anticipo)
                {
                    cxc_conciliacion_det_Info info_Anticipo = new cxc_conciliacion_det_Info();
                    info_Anticipo.check_cds = item.check_cds;

                    if (info_Anticipo.check_cds == true)
                    {
                        info_Anticipo.IdEmpresa = param.IdEmpresa;
                        info_Anticipo.IdSucursal = Convert.ToInt32(item.IdSucursal);
                        info_Anticipo.IdEmpresa_cbr = null;
                        info_Anticipo.IdSucursal_cbr = null;
                        info_Anticipo.IdTipoConciliacion = "ANT_CLI";
                        info_Anticipo.IdCobro = item.IdCobro_cobro;
                        info_Anticipo.IdEmpresa_nt = null;
                        info_Anticipo.IdSucursal_nt = null;
                        info_Anticipo.IdBodega_nt = null;
                        info_Anticipo.IdNota_nt = null;
                        info_Anticipo.IdEmpresa_fa = null;
                        info_Anticipo.IdSucursal_fa = null;
                        info_Anticipo.IdBodega_fa = null;
                        info_Anticipo.IdCbteVta_fa = null;
                        info_Anticipo.Saldo_por_aplicar = Convert.ToDouble(item.Saldo_Pendiente);
                        info_Anticipo.Valor_Aplicado = Convert.ToDouble(item.SaldoAUX - item.Saldo_Pendiente);
                        info_Anticipo.TipoDoc_vta = null;
                        info_Anticipo.IdCobro_Tipo = item.IdCobro_tipo;
                        //info_Anticipo.IdTipoNota = 0;
                        info_Anticipo.IdCaja = item.IdCaja;
                        //variables
                        cxcCobroInfo.IdCobro_tipo = info_Anticipo.IdCobro_Tipo;
                        cxcCobroInfo.IdTipoNotaCredito = info_Anticipo.IdTipoNota;
                        cxcCobroInfo.IdCaja = info_Anticipo.IdCaja;
                        cxcCobroInfo.cr_TotalCobro = info_Anticipo.Valor_Aplicado;
                        cxcCobroInfo.cr_observacion = item.pe_apellido + item.pe_nombre;
                        //CreDeb_IdEmpresa_nt = Convert.ToInt32(info_Anticipo.IdEmpresa_nt);
                        //CreDeb_IdSucursal_nt = Convert.ToInt32(info_Anticipo.IdSucursal_nt);
                        //CreDeb_IdBodega_nt = Convert.ToInt32(info_Anticipo.IdBodega_nt);
                        //CreDeb_IdNota_nt = Convert.ToInt32(info_Anticipo.IdNota_nt);
                        IdCobro = Convert.ToDecimal(info_Anticipo.IdCobro);
                        //variables
                        cab.cxc_cobro_Info = cxcCobroInfo;
                        Listdetalle.Add(info_Anticipo);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetDetalle_Anticipo_PendienteDiario(ref decimal IdCobro)
        {
            try
            {
                int focus = this.gridViewCreDebSaldo.FocusedRowHandle;
                gridViewCreDebSaldo.FocusedRowHandle = focus + 1;
                cxc_cobro_Info cxcCobroInfo = new cxc_cobro_Info();
                DataSource_Anticipo = new BindingList<vwcxc_anticipos_x_cruzar_Info>(List_Anticipo);
                this.gridControlAnticipoClientesPendientesDiario.DataSource = DataSource_Anticipo;

                foreach (var item in DataSource_Anticipo)
                {
                    cxc_conciliacion_det_Info info_Anticipo = new cxc_conciliacion_det_Info();
                    info_Anticipo.check_cds = item.check_cds;

                    if (info_Anticipo.check_cds == true)
                    {
                        info_Anticipo.IdEmpresa = param.IdEmpresa;
                        info_Anticipo.IdSucursal = Convert.ToInt32(item.IdSucursal);
                        info_Anticipo.IdEmpresa_cbr = null;
                        info_Anticipo.IdSucursal_cbr = null;
                        info_Anticipo.IdTipoConciliacion = "ANT_CLI";
                        info_Anticipo.IdCobro = item.IdCobro_cobro;
                        info_Anticipo.IdEmpresa_nt = null;
                        info_Anticipo.IdSucursal_nt = null;
                        info_Anticipo.IdBodega_nt = null;
                        info_Anticipo.IdNota_nt = null;
                        info_Anticipo.IdEmpresa_fa = null;
                        info_Anticipo.IdSucursal_fa = null;
                        info_Anticipo.IdBodega_fa = null;
                        info_Anticipo.IdCbteVta_fa = null;
                        info_Anticipo.Saldo_por_aplicar = Convert.ToDouble(item.Saldo_Pendiente);
                        info_Anticipo.Valor_Aplicado = Convert.ToDouble(item.SaldoAUX - item.Saldo_Pendiente);
                        info_Anticipo.TipoDoc_vta = null;
                        info_Anticipo.IdCobro_Tipo = item.IdCobro_tipo;
                        //info_Anticipo.IdTipoNota = 0;
                        info_Anticipo.IdCaja = item.IdCaja;
                        //variables
                        cxcCobroInfo.IdCobro_tipo = info_Anticipo.IdCobro_Tipo;
                        cxcCobroInfo.IdTipoNotaCredito = info_Anticipo.IdTipoNota;
                        cxcCobroInfo.IdCaja = info_Anticipo.IdCaja;
                        cxcCobroInfo.cr_TotalCobro = info_Anticipo.Valor_Aplicado;
                        cxcCobroInfo.cr_observacion = item.pe_apellido + item.pe_nombre;
                        //CreDeb_IdEmpresa_nt = Convert.ToInt32(info_Anticipo.IdEmpresa_nt);
                        //CreDeb_IdSucursal_nt = Convert.ToInt32(info_Anticipo.IdSucursal_nt);
                        //CreDeb_IdBodega_nt = Convert.ToInt32(info_Anticipo.IdBodega_nt);
                        //CreDeb_IdNota_nt = Convert.ToInt32(info_Anticipo.IdNota_nt);
                        IdCobro = Convert.ToDecimal(info_Anticipo.IdCobro);
                        //variables
                        cab.cxc_cobro_Info = cxcCobroInfo;
                        Listdetalle.Add(info_Anticipo);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean Validar()
        {
            try
            {
                //  IdCliente = Convert.ToDecimal(ucfA_Cliente_Facturacion1.cmb_cliente.EditValue);
                IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                //  fa_Cliente_Info ucfA_Cliente_Facturacion1 = (fa_Cliente_Info)ucfA_Cliente_Facturacion1.IdCliente;

                if (ucfA_Cliente_Facturacion1.cmb_cliente.EditValue == "" || ucfA_Cliente_Facturacion1.cmb_cliente.EditValue == null)
                {
                    MessageBox.Show("Ingrese el cliente", "Sistemas");
                    return false;

                }

                if (IdSucursal == null || IdSucursal == 0)
                {
                    MessageBox.Show("Ingrese la sucursal", "Sistemas");
                    return false;
                }

                if (this.txtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese la observación", "Sistemas");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Anular_Conciliacion()
        {
            try
            {
                if (SETINFO_ != null)
                {

                    if (SETINFO_.Estado.ToString() == "A")
                    {

                        if (MessageBox.Show("¿Está seguro que desea anular la conciliación #: " + SETINFO_.IdConciliacion + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                            oFrm.ShowDialog();

                            SETINFO_.MotivoAnulacion = oFrm.motivoAnulacion;
                            SETINFO_.IdUsuarioUltAnu = param.IdUsuario;
                            SETINFO_.Fecha_UltAnu = param.Fecha_Transac;

                            DateTime fechaAnulac;
                            fechaAnulac = oFrm.fechaAnul;
                            SETINFO_.Fecha_UltAnu = fechaAnulac;

                            string mensaje = "";
                            if (Bus_Conciliacion.Anular_Conciliacion(SETINFO_, ref  mensaje))
                            {

                                foreach (var item in SETINFO_.Detalle)
                                {
                                    if (item.TipoDoc_vta != null)
                                    {
                                        cxc_cobro_Det_Bus BusDetCob = new cxc_cobro_Det_Bus();

                                        if (item.TipoDoc_vta == "NTDB")
                                        {
                                            BusDetCob.EliminarDetalleCobro_x_Conciliacion(Convert.ToInt32(item.IdEmpresa_cbr), Convert.ToInt32(item.IdSucursal_cbr), Convert.ToDecimal(item.IdCobro), item.TipoDoc_vta, Convert.ToInt32(item.IdBodega_nt), Convert.ToInt32(item.IdNota_nt));
                                        }
                                        if (item.TipoDoc_vta == "FACT")
                                        {
                                            BusDetCob.EliminarDetalleCobro_x_Conciliacion(Convert.ToInt32(item.IdEmpresa_cbr), Convert.ToInt32(item.IdSucursal_cbr), Convert.ToDecimal(item.IdCobro), item.TipoDoc_vta, Convert.ToInt32(item.IdBodega_fa), Convert.ToInt32(item.IdCbteVta_fa));
                                        }
                                    }
                                }
                                string smensaje = string.Format("{0} # {1} se anuló con éxito.", "La conciliación ", SETINFO_.IdConciliacion);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //MessageBox.Show("Anulado con éxito la conciliación # : " + SETINFO_.IdConciliacion);

                                lblAnulado.Visible = true;
                                ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                                ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                            }
                            else MessageBox.Show("No se pudo anular la conciliación #: " + SETINFO_.IdConciliacion, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular la conciliación #: " + SETINFO_.IdConciliacion, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        decimal Id = 0;
        public Boolean Insertar_Conciliacion()
        {
            try
            {
                ct_Cbtecble_Bus cbteBus = new ct_Cbtecble_Bus();
                cxc_conciliacion_det_Bus detalle = new cxc_conciliacion_det_Bus();
                cxc_cobros_Pendientes_de_deposito_Info InfoDep = new cxc_cobros_Pendientes_de_deposito_Info();
                cxc_cobros_Pendientes_de_deposito_Bus BusDep = new cxc_cobros_Pendientes_de_deposito_Bus();
                string msg = "";
                Boolean resultGuardar = true;
                string mensaje = "";
                GetCabecera();
                getCbtecble();

                if (Cl_Enumeradores.TipoConciliacion.ANT_CLI == IdTipoConciliacion || Cl_Enumeradores.TipoConciliacion.ANT_CLIF == IdTipoConciliacion)
                {
                    //VALIDA QUE EL DIARIO CONTABLE ESTE CORRECTAMENTE ARMADO
                    if (!cbteBus.ValidarObjeto(CbteCbleInfo, ref msg))
                    {
                        MessageBox.Show(msg, "Sistemas");
                        return false;
                    }
                }

                //J.A Validar si el cobro no tiene depósito no debe guardar porque se actualiza el estado en la tabla cxc_cobro_x_EstadoCobro
                //y no va aparecer en la pantalla mantenimiento y cbro de cheque, solo debe actualizar si el cobro tiene depódito.
                if (TabControl.SelectedTab.Name == "TabAntiCli_Pendientes_De_Diario")
                {
                    string mens = "";
                    if (DataSource_Anticipo.Count() > 0)
                    {
                        foreach (var item in DataSource_Anticipo)
                        {
                            InfoDep = BusDep.Get_Info_cobros_Pendientes_de_deposito(item.IdEmpresa_Cobro, item.IdSucursal_cobro, Convert.ToInt32(item.IdCobro_cobro), ref mens);
                            if (InfoDep.IdCobro > 0)
                            {
                                if (InfoDep.Deposito_IdCbteCble == null)
                                {
                                    MessageBox.Show("La conciliación no se realizará el cobro # " + item.IdCobro_cobro + ", No se ha depositado,  debe realizar primero el depósito y después realice la conciliación", "Mensaje de sistema");
                                    return false;
                                }
                            }
                        }
                    }
                }

                if (Bus_Conciliacion.GuardarDB(cab, CbteCbleInfo, IdTipoConciliacion, ref Id, ref mensaje))
                {

                    if (TabControl.SelectedTab.Name == "TabAntiCli_Pendientes_De_Diario")
                    {
                        cxc_cobro_x_EstadoCobro_Bus busest = new cxc_cobro_x_EstadoCobro_Bus();
                        cxc_cobro_x_EstadoCobro_Info Infest = new cxc_cobro_x_EstadoCobro_Info();
                        List<cxc_cobro_x_EstadoCobro_Info> Listest = new List<cxc_cobro_x_EstadoCobro_Info>();
                        cxc_cobro_x_EstadoCobro_Info InfEstado = new cxc_cobro_x_EstadoCobro_Info();
                        Boolean estado = false;

                        Listest = busest.Get_List_cobro_x_EstadoCobro_Concil(InfoDep.IdEmpresa, InfoDep.IdSucursal, Convert.ToInt32(InfoDep.IdCobro));

                        if (Listest.Count == 1)
                        {
                            foreach (var est in Listest)
                            {
                                InfEstado = est;
                            }

                            if (InfEstado.IdCobro_tipo == "CHQV")
                            {
                            }
                            else
                            {
                                estado = busest.ModificarEstadoCobro_Concil(Listest);
                                if (estado == true)
                                {
                                    foreach (var item in DataSource_Anticipo)
                                    {
                                        Infest.IdEmpresa = item.IdEmpresa;
                                        Infest.IdSucursal = item.IdSucursal;
                                        Infest.IdCobro = item.IdCobro_cobro;
                                        Infest.IdEstadoCobro = "COBR";
                                        Infest.IdCobro_tipo = item.IdCobro_tipo;
                                        Infest.Fecha = DateTime.Now.Date;
                                        Infest.IdBanco = 6;
                                        Infest.IdCbte_vta_nota = 0;
                                    }

                                    busest.GuardarDB_(Infest);
                                }
                            }
                        }
                        else if (Listest.Count > 1)
                        {
                            estado = busest.ModificarEstadoCobro_Concil(Listest);
                            if (estado == true)
                            {
                                foreach (var item in DataSource_Anticipo)
                                {
                                    Infest.IdEmpresa = item.IdEmpresa;
                                    Infest.IdSucursal = item.IdSucursal;
                                    Infest.IdCobro = item.IdCobro_cobro;
                                    Infest.IdEstadoCobro = "COBR";
                                    Infest.IdCobro_tipo = item.IdCobro_tipo;
                                    Infest.Fecha = DateTime.Now.Date;
                                    Infest.IdBanco = 6;
                                    Infest.IdCbte_vta_nota = 0;
                                }
                                busest.GuardarDB_(Infest);
                            }
                        }
                    }


                    string smensaje = string.Format("{0} # {1} se guardó con éxito.", "La conciliación", Id);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Se ha guardado con éxito la conciliación #: " + Id);

                    this.txtNumConcilia.Text = Convert.ToString(Id);
                    //ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                    ucGe_Menu.Enabled_btnImprimirSoporte = true;


                    if (MessageBox.Show("¿Desea Imprimir la Conciliacion # " + this.txtNumConcilia.Text + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ucGe_Menu_event_btnImprimirSoporte_Click(null, null);
                    }

                    resultGuardar = true;
                    LimpiarDatos();
                }
                else
                {
                    resultGuardar = false;
                    MessageBox.Show(mensaje, "Sistemas");
                }
                return resultGuardar;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Carga_Grid_CreDebSaldo_Facturas()
        {
            try
            {
                Click_TabControl();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int contador;
        void checkTodosFalse()
        {
            try
            {
                foreach (var item in DataSource_CreDeb)
                {
                    item.check_cds = false;
                    contador++;
                }
                gridControlCreDebSaldo.RefreshDataSource();
                //gridControlAnticipoClientes.RefreshDataSource();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        double SaldoPendiente = 0;
        private void gridViewFacturas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                e.HitInfo.Column.FieldName = gridViewFacturas.FocusedColumn.FieldName;
                if (e.HitInfo.Column.FieldName == "check_cartera")
                {
                    if ((Boolean)gridViewFacturas.GetFocusedRowCellValue(colcheck_cartera))
                    {
                        gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, false);
                        gridViewFacturas.SetFocusedRowCellValue(colSaldo, gridViewFacturas.GetFocusedRowCellValue(colSaldoAUX));
                        if ((Boolean)gridViewFacturas.GetFocusedRowCellValue(colcheck_cartera) == false)
                        {
                            var asd = gridViewFacturas.GetRow(gridViewFacturas.FocusedRowHandle);
                        }
                        //suma check false
                        gridViewFacturas.SetFocusedRowCellValue(colSaldo, (double)gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar) + (double)gridViewFacturas.GetFocusedRowCellValue(colSaldoAUX));

                        if (Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldo)) == 0 || Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldo)) > Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldoAUX)))
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colSaldo, gridViewFacturas.GetFocusedRowCellValue(colSaldoAUX));
                        }

                        gridViewFacturas.SetFocusedRowCellValue(colvalor_aplicar, 0);
                        return;
                    }
                    else
                    {
                        var vt_total = gridViewFacturas.GetFocusedRowCellValue(colvt_total);

                        if (Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvt_total)) != 0)
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, true);    // aqui validar 
                        }


                        if (SaldoPendiente == 0)
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, false);
                            MessageBox.Show("No hay Saldo para Asignar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        var a2 = gridViewFacturas.GetFocusedRowCellValue(colSaldo);

                        if ((double)gridViewFacturas.GetFocusedRowCellValue(colSaldo) < 0)
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Calculo_Saldo_Pendiente_ColumnasGrid()
        {
            try
            {
                if (Convert.ToBoolean(gridViewFacturas.GetFocusedRowCellValue(colcheck_cartera)))
                {

                    if (Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldo)) < SaldoPendiente)
                    {

                        if (Convert.ToDecimal(gridViewFacturas.GetFocusedRowCellValue(colSaldo)) > 0)
                        {
                            if ((double)gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar) == 0)
                            {
                                gridViewFacturas.SetFocusedRowCellValue(colvalor_aplicar, gridViewFacturas.GetFocusedRowCellValue(colSaldo));

                                gridViewFacturas.SetFocusedRowCellValue(colSaldo, 0);

                            }
                        }
                        if (SaldoPendiente < Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)))
                        {
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                        if (SaldoPendiente < Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)))
                        {
                        }
                        else
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colvalor_aplicar, SaldoPendiente);
                        }

                        SaldoPendiente = 0;
                    }
                }

                if ((double)gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar) == 0)
                {
                    gridViewFacturas.SetFocusedRowCellValue(colSaldo, (double)gridViewFacturas.GetFocusedRowCellValue(colSaldoAUX) - (double)gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Calculo_Saldo_Pendiente()
        {
            try
            {
                double sum = 0;

                BindingList<vwcxc_cartera_x_cobrar_Info> z = new BindingList<vwcxc_cartera_x_cobrar_Info>();

                z = (BindingList<vwcxc_cartera_x_cobrar_Info>)gridViewFacturas.DataSource;

                foreach (var item in z)
                {
                    if (cmbSaldo.SelectedIndex == 0)
                    {
                        item.valor_aplicar = (item.SaldoAUX < item.valor_aplicar) ? 0 : item.valor_aplicar;
                        item.Saldo = item.SaldoAUX - item.valor_aplicar;
                    }
                    else
                    {
                        item.valor_aplicar = (item.SaldoAUX > item.valor_aplicar) ? 0 : item.valor_aplicar;
                        item.Saldo = item.SaldoAUX + item.valor_aplicar;
                    }

                }

                gridControlFacturas.DataSource = z;

                var s = from x in (BindingList<vwcxc_cartera_x_cobrar_Info>)gridViewFacturas.DataSource
                        where x.check_cartera == true
                        select x;
                List<vwcxc_cartera_x_cobrar_Info> LstChek = new List<vwcxc_cartera_x_cobrar_Info>();

                foreach (var item in s)
                {
                    sum += (double)item.valor_aplicar;
                }

                double saldoAux = 0;

                if (TabControl.SelectedTab.Name == "TabDebCre")
                {
                    foreach (var item in DataSource_CreDeb)
                    {
                        vwcxc_cobros_Pendientes_x_conciliar_Info info = new vwcxc_cobros_Pendientes_x_conciliar_Info();

                        info.check_cds = item.check_cds;
                        info.Saldo = item.Saldo;
                        info.saldoAUX_CreDeb = item.saldoAUX_CreDeb;

                        if (info.check_cds == true)
                        {
                            if (TabControl.SelectedTab.Name == "TabDebCre")
                            {
                                var saldoAUX_CreDeb = gridViewCreDebSaldo.GetFocusedRowCellValue(colsaldoAUX_CreDeb);

                                saldoAux = Convert.ToDouble(gridViewCreDebSaldo.GetFocusedRowCellValue(colsaldoAUX_CreDeb));
                                if (cmbSaldo.SelectedIndex == 0)
                                {
                                    SaldoPendiente = saldoAux - sum;
                                }
                                else
                                {
                                    SaldoPendiente = sum - saldoAux;
                                    if (sum > saldoAux) { SaldoPendiente = 0; item.Saldo = 0; info.Saldo = item.Saldo; }
                                }

                                gridViewCreDebSaldo.SetFocusedRowCellValue(colSaldo1, SaldoPendiente);
                            }
                        }
                    }
                }

                if (TabControl.SelectedTab.Name == "TabAntiCli")
                {
                    foreach (var item in DataSource_Anticipo)
                    {
                        vwcxc_anticipos_x_cruzar_Info info = new vwcxc_anticipos_x_cruzar_Info();

                        info.check_cds = item.check_cds;
                        info.Saldo_Pendiente = item.Saldo_Pendiente;
                        info.SaldoAUX = item.SaldoAUX;

                        if (info.check_cds == true)
                        {
                            var saldoAUX_CreDeb = gridViewAnticipo.GetFocusedRowCellValue(col_SaldoAUX_Ant);

                            saldoAux = Convert.ToDouble(gridViewAnticipo.GetFocusedRowCellValue(col_SaldoAUX_Ant));
                            SaldoPendiente = saldoAux - sum;
                            gridViewAnticipo.SetFocusedRowCellValue(col_SaldoAnticipo, SaldoPendiente);
                        }
                    }
                }

                if (TabControl.SelectedTab.Name == "TabAntiCli_Pendientes_De_Diario")
                {
                    foreach (var item in DataSource_Anticipo)
                    {
                        vwcxc_anticipos_x_cruzar_Info info = new vwcxc_anticipos_x_cruzar_Info();

                        info.check_cds = item.check_cds;
                        info.Saldo_Pendiente = item.Saldo_Pendiente;
                        info.SaldoAUX = item.SaldoAUX;

                        if (info.check_cds == true)
                        {
                            var saldoAUX_CreDeb = this.gridViewAnticipoPendienteDiario.GetFocusedRowCellValue(col_SaldoAUX_Ant);

                            saldoAux = Convert.ToDouble(gridViewAnticipoPendienteDiario.GetFocusedRowCellValue(col_SaldoAUX_Ant));
                            SaldoPendiente = saldoAux - sum;
                            gridViewAnticipoPendienteDiario.SetFocusedRowCellValue(col_SaldoAnticipo, SaldoPendiente);
                        }
                    }
                }
                // txtSaldoPendiente.EditValue = Convert.ToDecimal(txtValor.EditValue) - sum;                     
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewFacturas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                var a1 = gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar);
                var saldo = gridViewFacturas.GetFocusedRowCellValue(colSaldo);

                if (e.Column.Name == "colvalor_aplicar" && Convert.ToDecimal(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)) > 0)
                {
                    if (cmbSaldo.SelectedIndex == 0)
                    {
                        if (Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)) > SaldoPendiente || Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)) > Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldo))
                       )
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, false);
                            gridViewFacturas.SetFocusedRowCellValue(colvalor_aplicar, 0);
                        }
                        else
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, true);
                        }
                    }
                    else
                    {
                        if (Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)) < SaldoPendiente || Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)) < Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldo))
                        )
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, false);
                            gridViewFacturas.SetFocusedRowCellValue(colvalor_aplicar, 0);
                        }
                        else
                        {
                            gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, true);
                        }
                    }

                    GeneraDiarioAnticipo();
                }


                Calculo_Saldo_Pendiente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucfA_Cliente_Facturacion1_Event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                IdCliente = Convert.ToDecimal(ucfA_Cliente_Facturacion1.cmb_cliente.EditValue);
                IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);


                Carga_Grid_CreDebSaldo_Facturas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbSaldo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);

                if (ucfA_Cliente_Facturacion1.cmb_cliente.EditValue == "<" || IdSucursal == 0)
                {

                    return;
                }
                else
                {
                    IdCliente = Convert.ToDecimal(ucfA_Cliente_Facturacion1.cmb_cliente.EditValue);

                    Carga_Grid_CreDebSaldo_Facturas();
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucIn_Sucursal_Bodega1_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdCliente = Convert.ToDecimal(ucfA_Cliente_Facturacion1.cmb_cliente.EditValue);
                IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);

                if (ucfA_Cliente_Facturacion1.cmb_cliente.EditValue == "<")
                {
                    return;
                }

                Carga_Grid_CreDebSaldo_Facturas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmcxc_Conciliacion_cxc_event_frmcxc_Conciliacion_cxc_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmcxc_Conciliacion_cxc_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmcxc_Conciliacion_cxc_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewCreDebSaldo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                e.HitInfo.Column.FieldName = gridViewCreDebSaldo.FocusedColumn.FieldName;
                if (e.HitInfo.Column.FieldName == "check_cds")
                {
                    if ((bool)gridViewCreDebSaldo.GetFocusedRowCellValue(colcheck_cds))
                    {
                        gridViewCreDebSaldo.SetFocusedRowCellValue(colcheck_cds, false);
                        Refresh_Grid();
                    }

                    else
                    {

                        checkTodosFalse();
                        gridViewCreDebSaldo.SetFocusedRowCellValue(colcheck_cds, true);

                        for (int i = 0; i < gridViewCreDebSaldo.RowCount; i++)
                        {
                            if ((bool)gridViewCreDebSaldo.GetRowCellValue(i, colcheck_cds) == false)
                            {
                                gridViewCreDebSaldo.SetRowCellValue(i, colSaldo1, gridViewCreDebSaldo.GetRowCellValue(i, colsaldoAUX_CreDeb));
                            }
                        }

                        list_Saldo = new List<vwcxc_cartera_x_cobrar_Info>();
                        foreach (var item in DataSource)
                        {
                            vwcxc_cartera_x_cobrar_Info info_Fact = new vwcxc_cartera_x_cobrar_Info();

                            info_Fact.IdEmpresa = item.IdEmpresa;
                            info_Fact.IdSucursal = item.IdSucursal;
                            info_Fact.IdBodega = item.IdBodega;
                            info_Fact.vt_tipoDoc = item.vt_tipoDoc;
                            info_Fact.vt_NunDocumento = item.vt_NunDocumento;
                            info_Fact.Referencia = item.Referencia;
                            info_Fact.IdComprobante = item.IdComprobante;
                            info_Fact.CodComprobante = item.CodComprobante;
                            info_Fact.Su_Descripcion = item.Su_Descripcion;
                            info_Fact.IdCliente = item.IdCliente;
                            info_Fact.vt_fecha = item.vt_fecha;
                            info_Fact.vt_total = item.vt_total;
                            info_Fact.TotalxCobrado = item.TotalxCobrado;
                            info_Fact.Bodega = item.Bodega;
                            info_Fact.vt_Subtotal = item.vt_Subtotal;
                            info_Fact.vt_iva = item.vt_iva;
                            info_Fact.vt_fech_venc = item.vt_fech_venc;
                            info_Fact.NomCliente = item.NomCliente;
                            info_Fact.pe_nombreCompleto = "[" + info_Fact.IdCliente + "] : " + item.pe_nombreCompleto;
                            info_Fact.SaldoAUX = item.SaldoAUX;
                            info_Fact.Saldo = item.SaldoAUX;

                            list_Saldo.Add(info_Fact);
                        }
                        DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>(list_Saldo);
                        this.gridControlFacturas.DataSource = DataSource;
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewFacturas_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //ojo
            try
            {
                var valor_aplicar = gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar);
                var Saldo = gridViewFacturas.GetFocusedRowCellValue(colSaldo);


                ////  if (Convert.ToDecimal(txtSaldoPendiente.EditValue) == 0 || Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)) > Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldo)))
                if (SaldoPendiente == 0 || Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colvalor_aplicar)) > Convert.ToDouble(gridViewFacturas.GetFocusedRowCellValue(colSaldo)))
                {
                    gridViewFacturas.SetFocusedRowCellValue(colvalor_aplicar, 0);
                }
                else
                {

                    var vt_total = gridViewFacturas.GetFocusedRowCellValue(colvt_total);

                    if (Convert.ToString(gridViewFacturas.GetFocusedRowCellValue(colvt_total)) != "")
                    {
                        gridViewFacturas.SetFocusedRowCellValue(colcheck_cartera, true);
                    }
                }
                //var s = from x in (List<vwcxc_cartera_x_cobrar_Info>)gridControlFacturas.DataSource
                var s = from x in (BindingList<vwcxc_cartera_x_cobrar_Info>)gridControlFacturas.DataSource
                        where x.check_cartera == true
                        select x;
                Calculo_Saldo_Pendiente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void Refresh_Grid()
        {
            try
            {
                if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                {
                    list_Saldo = new List<vwcxc_cartera_x_cobrar_Info>();
                    foreach (var item in DataSource)
                    {
                        vwcxc_cartera_x_cobrar_Info info_Fact = new vwcxc_cartera_x_cobrar_Info();

                        info_Fact.IdEmpresa = item.IdEmpresa;
                        info_Fact.IdSucursal = item.IdSucursal;
                        info_Fact.IdBodega = item.IdBodega;
                        info_Fact.vt_tipoDoc = item.vt_tipoDoc;
                        info_Fact.vt_NunDocumento = item.vt_NunDocumento;
                        info_Fact.Referencia = item.Referencia;
                        info_Fact.IdComprobante = item.IdComprobante;
                        info_Fact.CodComprobante = item.CodComprobante;
                        info_Fact.Su_Descripcion = item.Su_Descripcion;
                        info_Fact.IdCliente = item.IdCliente;
                        info_Fact.vt_fecha = item.vt_fecha;
                        info_Fact.vt_total = item.vt_total;
                        info_Fact.TotalxCobrado = item.TotalxCobrado;
                        info_Fact.Bodega = item.Bodega;
                        info_Fact.vt_Subtotal = item.vt_Subtotal;
                        info_Fact.vt_iva = item.vt_iva;
                        info_Fact.vt_fech_venc = item.vt_fech_venc;
                        info_Fact.NomCliente = item.NomCliente;
                        info_Fact.pe_nombreCompleto = "[" + info_Fact.IdCliente + "] : " + item.pe_nombreCompleto;
                        info_Fact.SaldoAUX = item.SaldoAUX;
                        info_Fact.Saldo = item.SaldoAUX;

                        list_Saldo.Add(info_Fact);

                    }
                    DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>(list_Saldo);
                    this.gridControlFacturas.DataSource = DataSource;


                    List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();

                    foreach (var item in DataSource_CreDeb)
                    {
                        vwcxc_cobros_Pendientes_x_conciliar_Info info_CreDeb = new vwcxc_cobros_Pendientes_x_conciliar_Info();

                        info_CreDeb.IdEmpresa = item.IdEmpresa;
                        info_CreDeb.IdSucursal = item.IdSucursal;
                        info_CreDeb.IdBodega = item.IdBodega;
                        info_CreDeb.Tipo = item.Tipo;
                        info_CreDeb.IdNota = item.IdNota;
                        info_CreDeb.CreDeb = item.CreDeb;
                        info_CreDeb.Serie1 = item.Serie1;
                        info_CreDeb.Serie2 = item.Serie2;
                        info_CreDeb.NumNota_Impresa = item.NumNota_Impresa;
                        info_CreDeb.IdCliente = item.IdCliente;
                        info_CreDeb.NomSucursal = item.NomSucursal;
                        info_CreDeb.Nom_Bodega = item.Nom_Bodega;
                        info_CreDeb.no_fecha = item.no_fecha;
                        info_CreDeb.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                        info_CreDeb.sc_observacion = item.sc_observacion;
                        info_CreDeb.Nom_Cliente = item.Nom_Cliente;
                        info_CreDeb.Motivo_Nota = item.Motivo_Nota;
                        info_CreDeb.Referencia = item.Referencia;
                        info_CreDeb.sc_total = Convert.ToDouble(item.sc_total);
                        info_CreDeb.Saldo = item.saldoAUX_CreDeb;
                        info_CreDeb.saldoAUX_CreDeb = item.saldoAUX_CreDeb;

                        info_CreDeb.IdTipoConciliacion = item.IdTipoConciliacion;

                        info_CreDeb.IdCobro_Tipo = item.IdCobro_Tipo;
                        info_CreDeb.IdTipoNota = item.IdTipoNota;
                        info_CreDeb.NombreCompleto = item.NombreCompleto;

                        info_CreDeb.IdCaja = item.IdCaja;
                        info_CreDeb.IdCtaCble_Anti = item.IdCtaCble_Anti;
                        info_CreDeb.IdCtaCble_cxc = item.IdCtaCble_cxc;
                        List_CreDeb.Add(info_CreDeb);

                    }

                    DataSource_CreDeb = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>(List_CreDeb);
                    this.gridControlCreDebSaldo.DataSource = DataSource_CreDeb;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewCreDebSaldo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCreDebSaldo.GetRow(e.RowHandle) as vwfa_creditos_debitos_con_saldo_Info;
                if (data == null)
                    return;
                if (data.check_cds == true)
                {
                    e.Appearance.BackColor = System.Drawing.Color.Beige;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Carga_Facturas_Clientes()
        {
            try
            {
                lst = new List<vwcxc_cartera_x_cobrar_Info>();
                lst = cartera_B.Get_List_cartera_x_cobrar(param.IdEmpresa, IdSucursal, IdCliente);
                list_Saldo = new List<vwcxc_cartera_x_cobrar_Info>();

                if (cmbSaldo.SelectedIndex == 0)
                {
                    list_Saldo = lst.FindAll(c => c.Saldo > 0);
                    DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>(list_Saldo);
                    this.gridControlFacturas.DataSource = DataSource;
                }

                else
                {
                    list_Saldo = lst.FindAll(c => c.Saldo <= 0);
                    DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>(list_Saldo);
                    this.gridControlFacturas.DataSource = DataSource;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Click_TabControl()
        {
            try
            {
                IdCliente = Convert.ToDecimal(ucfA_Cliente_Facturacion1.cmb_cliente.EditValue);
                IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);

                if (TabControl.SelectedTab == TabAntiCli)
                {
                    IdTipoConciliacion = Cl_Enumeradores.TipoConciliacion.ANT_CLI;

                    List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                    string mensaje = "";

                    vwcxc_anticipos_x_cruzar_Info Info = new vwcxc_anticipos_x_cruzar_Info();
                    Info.IdEmpresa = param.IdEmpresa;
                    Info.IdCliente = IdCliente;

                    List_Anticipo = Bus_Anticipo.Get_List_anticipos_x_cruzar(Info);
                    DataSource_Anticipo = new BindingList<vwcxc_anticipos_x_cruzar_Info>(List_Anticipo);

                    //List_CreDeb = Bus_CreDeb.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(param.IdEmpresa, IdSucursal, IdCliente, IdTipoConciliacion, ref mensaje);
                    //DataSource_CreDeb = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>(List_CreDeb);

                    this.gridControlAnticipoClientes.DataSource = DataSource_Anticipo;

                    Carga_Facturas_Clientes();
                }

                if (TabControl.SelectedTab == TabAntiCli_Pendientes_De_Diario)
                {
                    IdTipoConciliacion = Cl_Enumeradores.TipoConciliacion.ANT_CLI;

                    List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                    string mensaje = "";

                    vwcxc_anticipos_x_cruzar_Info Info = new vwcxc_anticipos_x_cruzar_Info();
                    Info.IdEmpresa = param.IdEmpresa;
                    Info.IdCliente = IdCliente;

                    List_Anticipo = Bus_Anticipo.Get_List_anticipos_x_cruzar_Pendientes_de_Diario(Info);
                    DataSource_Anticipo = new BindingList<vwcxc_anticipos_x_cruzar_Info>(List_Anticipo);

                    this.gridControlAnticipoClientesPendientesDiario.DataSource = DataSource_Anticipo;

                    Carga_Facturas_Clientes();
                }

                if (TabControl.SelectedTab == TabDebCre)
                {
                    IdTipoConciliacion = Cl_Enumeradores.TipoConciliacion.NT_CR_DB;
                    List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                    List<vwcxc_cobros_Pendientes_x_conciliar_Info> List_CreDeb_Nuevo = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                    string mensaje = "";

                    List_CreDeb = Bus_CreDeb.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(param.IdEmpresa, IdSucursal, IdCliente, IdTipoConciliacion, ref mensaje);

                    fa_notaCreDeb_Info estadoDoc = new fa_notaCreDeb_Info();

                    foreach (var item in List_CreDeb)
                    {
                        estadoDoc = Bus_NCreDeb.Get_Info_notaCreDeb_x_ND_Tipo(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdNota, item.CreDeb);
                        if (estadoDoc.Estado == "A")
                        {
                            vwcxc_cobros_Pendientes_x_conciliar_Info inf = new vwcxc_cobros_Pendientes_x_conciliar_Info();

                            inf.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                            inf.IdSucursal = Convert.ToInt32(item.IdSucursal);
                            inf.IdBodega = Convert.ToInt32(item.IdBodega);
                            inf.Tipo = item.Tipo;
                            inf.IdNota = Convert.ToDecimal(item.IdNota);
                            inf.CreDeb = item.CreDeb;
                            inf.Serie1 = item.Serie1;
                            inf.Serie2 = item.Serie2;
                            inf.NumNota_Impresa = item.NumNota_Impresa;
                            inf.IdCliente = item.IdCliente;
                            inf.NomSucursal = item.NomSucursal;
                            inf.Nom_Bodega = item.Nom_Bodega;
                            inf.no_fecha = Convert.ToDateTime(item.no_fecha);
                            inf.no_fecha_venc = Convert.ToDateTime(item.no_fecha_venc);
                            inf.sc_observacion = item.sc_observacion;
                            inf.Nom_Cliente = item.Nom_Cliente;
                            inf.Motivo_Nota = item.Motivo_Nota;
                            inf.Referencia = item.Referencia;
                            inf.sc_total = Convert.ToDouble(item.sc_total);
                            inf.Saldo = Convert.ToDouble(item.Saldo);
                            inf.saldoAUX_CreDeb = Convert.ToDouble(item.Saldo);
                            inf.IdTipoConciliacion = item.IdTipoConciliacion;
                            inf.IdCobro = Convert.ToDecimal(item.IdCobro);
                            inf.IdCobro_Tipo = item.IdCobro_Tipo;
                            inf.IdTipoNota = Convert.ToInt32(item.IdTipoNota);
                            inf.IdCaja = Convert.ToInt32(item.IdCaja);
                            inf.NombreCompleto = "[" + item.IdCliente + "] -" + "[" + item.Nom_Cliente + "]";
                            inf.IdCtaCble_cxc = item.IdCtaCble_cxc;
                            inf.IdCtaCble_Anti = item.IdCtaCble_Anti;
                            List_CreDeb_Nuevo.Add(inf);
                        }
                    }
                    List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>();
                    List_CreDeb = new List<vwcxc_cobros_Pendientes_x_conciliar_Info>(List_CreDeb_Nuevo);

                    DataSource_CreDeb = new BindingList<vwcxc_cobros_Pendientes_x_conciliar_Info>(List_CreDeb);
                    this.gridControlCreDebSaldo.DataSource = DataSource_CreDeb;

                    Carga_Facturas_Clientes();
                }

                if (TabControl.SelectedTab.Name == "TabPendienteCruzar")
                {

                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TabControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                    Click_TabControl();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAnticipo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                e.HitInfo.Column.FieldName = gridViewAnticipo.FocusedColumn.FieldName;
                if (e.HitInfo.Column.FieldName == "check_cds")
                {
                    if ((bool)gridViewAnticipo.GetFocusedRowCellValue(colcheck_cds))
                    {
                        gridViewAnticipo.SetFocusedRowCellValue(colcheck_cds, false);
                        Refresh_Grid();
                        ucCon_GridDiario.LimpiarGrid();
                    }

                    else
                    {
                        checkTodosFalse();
                        gridViewAnticipo.SetFocusedRowCellValue(colcheck_cds, true);

                        for (int i = 0; i < gridViewAnticipo.RowCount; i++)
                        {
                            if ((bool)gridViewAnticipo.GetRowCellValue(i, colcheck_cds) == false)
                            {
                                gridViewAnticipo.SetRowCellValue(i, colSaldo1, gridViewAnticipo.GetRowCellValue(i, colsaldoAUX_CreDeb));
                            }
                        }

                        list_Saldo = new List<vwcxc_cartera_x_cobrar_Info>();
                        foreach (var item in DataSource)
                        {
                            vwcxc_cartera_x_cobrar_Info info_Fact = new vwcxc_cartera_x_cobrar_Info();

                            info_Fact.IdEmpresa = item.IdEmpresa;
                            info_Fact.IdSucursal = item.IdSucursal;
                            info_Fact.IdBodega = item.IdBodega;
                            info_Fact.vt_tipoDoc = item.vt_tipoDoc;
                            info_Fact.vt_NunDocumento = item.vt_NunDocumento;
                            info_Fact.Referencia = item.Referencia;
                            info_Fact.IdComprobante = item.IdComprobante;
                            info_Fact.CodComprobante = item.CodComprobante;
                            info_Fact.Su_Descripcion = item.Su_Descripcion;
                            info_Fact.IdCliente = item.IdCliente;
                            info_Fact.vt_fecha = item.vt_fecha;
                            info_Fact.vt_total = item.vt_total;
                            info_Fact.TotalxCobrado = item.TotalxCobrado;
                            info_Fact.Bodega = item.Bodega;
                            info_Fact.vt_Subtotal = item.vt_Subtotal;
                            info_Fact.vt_iva = item.vt_iva;
                            info_Fact.vt_fech_venc = item.vt_fech_venc;
                            info_Fact.NomCliente = item.NomCliente;
                            info_Fact.pe_nombreCompleto = "[" + info_Fact.IdCliente + "] : " + item.pe_nombreCompleto;
                            info_Fact.SaldoAUX = item.SaldoAUX;
                            info_Fact.Saldo = item.SaldoAUX;

                            list_Saldo.Add(info_Fact);
                        }
                        DataSource = new BindingList<vwcxc_cartera_x_cobrar_Info>(list_Saldo);
                        this.gridControlFacturas.DataSource = DataSource;
                        GeneraDiarioAnticipo();
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}