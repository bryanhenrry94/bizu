using Core.Erp.Business.Bancos;
using Core.Erp.Business.Compras;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.Compras;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Reportes.Contabilidad;

using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_OrdenGiroMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        BindingList<cp_orden_giro_x_com_ordencompra_local_det_Info> BindList_OG_x_detOC;
        Boolean resp = true;
        Boolean resp_2 = true;
        Boolean res = true;
        Boolean Ejecutar_Evento = true;
        Boolean Diario_generado = false;
        string IdCtaCble_Proveedor = "";
        string nomProveedor = "";
        Nullable<int> IdPunto_cargo = null;
        Nullable<int> IdPunto_cargo_grupo = null;
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Plancta_Bus _PlanCta_bus = new ct_Plancta_Bus();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        cp_orden_giro_Bus ordenGiro_B = new cp_orden_giro_Bus();

        cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
        cp_retencion_Bus ret_B = new cp_retencion_Bus();
        ct_Centro_costo_Bus _CentroCostoBus = new ct_Centro_costo_Bus();
        cp_parametros_Bus paramCP_B = new cp_parametros_Bus();
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();
        cp_reembolso_Bus Reem_B = new cp_reembolso_Bus();
        cp_orden_giro_x_com_ordencompra_local_Bus OC_B = new cp_orden_giro_x_com_ordencompra_local_Bus();
        cp_orden_giro_pagos_sri_Bus pagoSRI_B = new cp_orden_giro_pagos_sri_Bus();
        cp_proveedor_Autorizacion_Bus Autori_bus = new cp_proveedor_Autorizacion_Bus();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
        //Listas
        List<cp_TipoDocumento_Info> LstTipDoc = new List<cp_TipoDocumento_Info>();
        List<cp_retencion_det_Info> _ListaRetencionOld = new List<cp_retencion_det_Info>();
        List<cp_retencion_det_Info> _ListaRetencion = new List<cp_retencion_det_Info>();
        List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
        //  List<ct_Centro_costo_Info> _CentroCostoListaInfo = new List<ct_Centro_costo_Info>();
        List<cp_codigo_SRI_Info> ListCodigoSRI = new List<cp_codigo_SRI_Info>();
        List<cp_reembolso_Info> lst_reembolso = new List<cp_reembolso_Info>();
        List<cp_orden_giro_x_com_ordencompra_local_Info> LstImportacionOC = new List<cp_orden_giro_x_com_ordencompra_local_Info>();
        List<cp_orden_giro_pagos_sri_Info> lst_formasPagoSRI = new List<cp_orden_giro_pagos_sri_Info>();
        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();

        //Infos
        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();

        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();

        cp_parametros_Info paramCP_I = new cp_parametros_Info();
        cp_orden_giro_x_com_ordencompra_local_Info OC_I = new cp_orden_giro_x_com_ordencompra_local_Info();
        cp_retencion_Info Info_Retencion = new cp_retencion_Info();
        ct_Cbtecble_Info Info_CbteCble_x_Ret = new ct_Cbtecble_Info();

        //BindingList
        BindingList<cp_reembolso_Info> BindingList_Reembolso;
        BindingList<cp_orden_giro_pagos_sri_Info> BindingList_pagosSRI;

        List<cp_pais_sri_Info> List_pais_sri = new List<cp_pais_sri_Info>();
        cp_pais_sri_Bus Bus_Pais_SRI = new cp_pais_sri_Bus();

        // Nuevos
        BindingList<cp_orden_giro_det_Info> BindingListOrdenGiroDet = new BindingList<cp_orden_giro_det_Info>();
        List<ct_Plancta_Info> ListCuentas = new List<ct_Plancta_Info>();
        tb_sis_impuesto_Bus BusImpuesto = new tb_sis_impuesto_Bus();
        List<tb_sis_impuesto_Info> ListImpuesto = new List<tb_sis_impuesto_Info>();

        //Delegados       

        public delegate void delegate_frmCP_MantOrdenGiro_FormClosing(object sender, FormClosingEventArgs e, cp_orden_giro_Info _Info_Orgen_Giro);
        public event delegate_frmCP_MantOrdenGiro_FormClosing event_frmCP_MantOrdenGiro_FormClosing;


        decimal idCbteCble = 0;
        int _IdTipoCbte = 0;
        int IdTipoCbteRev = 0;
        decimal IdCbteCbleRev;
        string motiAnulacion = "";
        decimal Vtotal = 0, VvalorApagar = 0, Vsaldo = 0;
        decimal AnteriorDebe = 0, AnteriorHaber = 0;
        decimal valorApagar, total;
        string msg = "";
        string msg2 = "";
        string MensajeError = "";
        string Imp_ReImp = "";
        string NumAutoriza = "";
        string Establecimiento = "";
        string Pto_Emision = "";
        decimal NumDoc = 0;


        private Cl_Enumeradores.eTipo_action _Accion;
        frmCP_ImprimirRetencion fr = new frmCP_ImprimirRetencion();
        //talonarios
        tb_sis_Documento_Tipo_Talonario_Info talonario_Info = new tb_sis_Documento_Tipo_Talonario_Info();
        tb_sis_Documento_Tipo_Talonario_Bus Bus_Talonario = new tb_sis_Documento_Tipo_Talonario_Bus();

        void frmCP_MantOrdenGiro_event_frmCP_MantOrdenGiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public frmCP_OrdenGiroMantenimiento()
        {
            try
            {
                InitializeComponent();

                ucCp_Retencion1.event_gridView_SRI_CellValueChanged += ucCp_Retencion1_event_gridView_SRI_CellValueChanged;
                ucCp_Retencion1.event_gridView_SRI_KeyDown += ucCp_Retencion1_event_gridView_SRI_KeyDown;

                event_frmCP_MantOrdenGiro_FormClosing += frmCP_OrdenGiroMantenimiento_event_frmCP_MantOrdenGiro_FormClosing;

                uCMenu.event_btnImprimir_Click += uCMenu_event_btnImprimir_Click;
                uCMenu.event_btnGuardar_Click += UCMenu_event_btnGuardar_Click;
                uCMenu.event_btnGuardar_y_Salir_Click += UCMenu_event_btnGuardar_y_Salir_Click;
                uCMenu.event_btnlimpiar_Click += UCMenu_event_btnlimpiar_Click;
                uCMenu.event_btnSalir_Click += UCMenu_event_btnSalir_Click;
                uCMenu.event_btnAnular_Click += UCMenu_event_btnAnular_Click;
                uCMenu.event_btnImpRep_Click += UCMenu_event_btnImpRep_Click;
                uCMenu.event_btnImprimir_Click += UCMenu_event_btnImprimir_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCMenu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirComprobantee();
        }

        private void UCMenu_event_btnImpRep_Click(object sender, EventArgs e)
        {
            Imprimir_Retencion();
        }

        private void UCMenu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info_OrdenGiro.Estado == "I")
                {
                    MessageBox.Show("El registro ya está anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    _Accion = Cl_Enumeradores.eTipo_action.Anular;
                    Anular();
                    set_accion_controles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCMenu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UCMenu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void UCMenu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCMenu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    LimpiarDatos();
                    set_accion_controles();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_OrdenGiroMantenimiento_event_frmCP_MantOrdenGiro_FormClosing(object sender, FormClosingEventArgs e, cp_orden_giro_Info _Info_Orgen_Giro)
        {

        }

        private void Imprimir_factura_x_poveedor()
        {
            try
            {
                XCXP_Rpt021_Rpt rpt = new XCXP_Rpt021_Rpt();
                rpt.set_parametros(param.IdEmpresa, Convert.ToDecimal(txt_NOrdeG.Text), Info_OrdenGiro.IdTipoCbte_Ogiro);
                rpt.RequestParameters = true;
                ReportPrintTool pt2 = new ReportPrintTool(rpt);
                pt2.AutoShowParametersPanel = false;
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uCMenu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir_factura_x_poveedor();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCp_Retencion1_event_gridView_SRI_KeyDown(object sender, EventArgs e)
        {
            try
            {
                ucCp_Retencion1.set_Accion(_Accion);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCp_Retencion1_event_gridView_SRI_CellValueChanged(object sender, EventArgs e)
        {
            try
            {
                ucCp_Retencion1.set_Valores(Convert.ToDouble(Math.Round(Convert.ToDecimal(txtIVA5.EditValue), 2)), Convert.ToDouble(Math.Round(Convert.ToDecimal(txtIVA15.EditValue), 2, MidpointRounding.AwayFromZero)));
                ucCp_Retencion1.set_Datos_Proveedor(InfoProveedor.IdCtaCble_CXP, InfoProveedor.pr_nombre, Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion));
                // ucCp_Retencion1.carga_codigoSRI_x_Proveedor(param.IdEmpresa, InfoProveedor.IdProveedor); 
                CalculoRetencion();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCp_Proveedor1_event_cmb_proveedor_Validated(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular || _Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    return;
                }

                txeSerie.EditValue = "";
                UC_Diario_x_cxp.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucCp_Proveedor1_event_cmb_proveedor_Validating(object sender, EventArgs e)
        {
            try
            {
                InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();

                if (InfoProveedor == null)
                {
                    InfoProveedor = new cp_proveedor_Info();
                    txt_plazo.Text = "";
                }
                txt_plazo.Text = InfoProveedor.pr_plazo.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    if (chk_TieneRetencion.Checked == true)
                    {

                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                            {
                                if (ucCp_Proveedor1.get_ProveedorInfo().pr_contribuyenteEspecial == "S")
                                {
                                    MessageBox.Show("El Proveedor: " + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre + " es Contribuyente Especial", param.Nombre_sistema);
                                }
                            }
                        }
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular || _Accion == Cl_Enumeradores.eTipo_action.consultar)
                    {
                        return;
                    }
                    if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                    {
                        frmCP_Alerta_Anticipos_x_NotasCreditos ofrm = new frmCP_Alerta_Anticipos_x_NotasCreditos();
                        ofrm.IdEmpresa = param.IdEmpresa;
                        ofrm.IProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;

                        ofrm.carga_Grid();
                        if (ofrm.lista_AnticipoSaldo.Count != 0)
                        {
                            ofrm.ShowDialog();
                        }
                    }


                    UC_Diario_x_cxp.LimpiarGrid();
                    Diario_generado = false;
                    deshabilitarCamposRet();

                    txeIdNumAutoriza.EditValue = null;
                    InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();

                    if (InfoProveedor != null)
                    {
                        IdCtaCble_Proveedor = InfoProveedor.IdCtaCble_CXP;
                        nomProveedor = InfoProveedor.pr_nombre;
                        IdPunto_cargo_grupo = InfoProveedor.IdPunto_cargo_grupo;
                        IdPunto_cargo = InfoProveedor.IdPunto_cargo;

                        if (InfoProveedor.idCredito_Predeter != null)
                        {
                            cmb_idtCredito.EditValue = InfoProveedor.idCredito_Predeter;
                            cmb_idtCredito_EditValueChanged(new object(), new EventArgs());
                        }
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (chk_TieneRetencion.Checked == true)
                        {
                            if (InfoProveedor != null)
                            {
                                ucCp_Retencion1.set_Valores(Convert.ToDouble(txtIVA5.EditValue), Convert.ToDouble(txtIVA15.EditValue));
                                ucCp_Retencion1.set_Datos_Proveedor(InfoProveedor.IdCtaCble_CXP, InfoProveedor.pr_nombre, Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion));
                                ucCp_Retencion1.carga_codigoSRI_x_Proveedor(param.IdEmpresa, InfoProveedor.IdProveedor);
                            }
                        }
                    }

                    cmbTipoDocu.EditValue = null;
                    CalculaTotales();
                }
                catch (Exception ex)
                {

                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_OrdenGiro_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);
                if (paramCP_I.pa_TipoCbte_OG == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Genera la Factura Proveedor.. " +
                        "\nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else if (paramCP_I.pa_ctacble_iva == null || paramCP_I.pa_ctacble_iva == "")
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar la Cuenta IVA para Generár la Factura Proveedor.. " +
                        "\nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else if (!ValidarTipComp_x_Empresa())
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Genera las Retenciones.." +
                        " \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                _IdTipoCbte = paramCP_I.pa_TipoCbte_OG;
                IdTipoCbteRev = paramCP_I.pa_TipoCbte_OG_anulacion;

                Cargar_Combos();


                set_accion_controles();
                deshabilitarCamposRet();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Inhabilta_Controles()
        {
            try
            {
                ucCp_Proveedor1.Perfil_Lectura();
                cmb_idtCredito.Properties.ReadOnly = true;
                dtp_fechaFactura.Enabled = false;
                dtp_fecha_contabilizacion.Enabled = false;
                dtp_fechaOG.Enabled = false;
                cmb_tipoOG.Enabled = false;
                txtSubtotalIVA15.Properties.ReadOnly = true;
                txtSubtotalIVA0.Properties.ReadOnly = true;
                txeIdNumAutoriza.Properties.ReadOnly = true;
                txtIVA5.Properties.ReadOnly = true;
                txtValorAPagar.Properties.ReadOnly = true;
                txtSaldo.Properties.ReadOnly = true;
                UC_Diario_x_cxp.HabilitarGrid(false);
                chk_coa.Enabled = false;
                gridView_formasPagoSRI.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_controles()
        {
            try
            {
                ucCp_Retencion1.Visible_GridRetencion(false);
                chk_TieneRetencion.Visible = true;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        uCMenu.Enabled_bntAnular = false;
                        uCMenu.Enabled_bntGuardar_y_Salir = true;
                        uCMenu.Enabled_bntLimpiar = true;
                        uCMenu.Enabled_btnGuardar = true;
                        uCMenu.Enabled_bntImprimir = false;
                        lblanulado.Visible = false;
                        cmb_tipoOG.SelectedIndex = 0;
                        cmb_Local_Exterios.SelectedIndex = 0;
                        chk_coa.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        uCMenu.Enabled_bntAnular = false;
                        uCMenu.Enabled_bntGuardar_y_Salir = true;
                        uCMenu.Enabled_bntLimpiar = false;
                        uCMenu.Enabled_btnGuardar = false;
                        uCMenu.Enabled_bntImprimir = true;
                        set_Info_OrdenGiro_Controles();
                        ucCp_Proveedor1.Perfil_Lectura();
                        btn_Importar_XML.Enabled = false;
                        ListCodigoSRI.FindAll(c => c.co_estado == "A" && (c.IdTipoSRI == "COD_RET_FUE" || c.IdTipoSRI == "COD_RET_IVA"));
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        uCMenu.Enabled_bntAnular = true;
                        uCMenu.Enabled_bntGuardar_y_Salir = false;
                        uCMenu.Enabled_bntLimpiar = false;
                        uCMenu.Enabled_btnGuardar = false;
                        uCMenu.Enabled_bntImprimir = true;
                        set_Info_OrdenGiro_Controles();
                        cmbTipoDocu.Properties.ReadOnly = true;
                        txeNumDocum.Properties.ReadOnly = true;
                        Inhabilta_Controles();
                        txeSerie.Properties.ReadOnly = true;
                        chk_TieneRetencion.Enabled = false;
                        btn_Importar_XML.Enabled = false;
                        btn_Autoriza.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        uCMenu.Enabled_bntAnular = false;
                        uCMenu.Enabled_bntGuardar_y_Salir = false;
                        uCMenu.Enabled_bntLimpiar = false;
                        uCMenu.Enabled_btnGuardar = false;
                        uCMenu.Enabled_bntImprimir = true;
                        set_Info_OrdenGiro_Controles();
                        chk_TieneRetencion.Enabled = false;
                        btn_Importar_XML.Enabled = false;
                        btn_Autoriza.Enabled = false;
                        Inhabilta_Controles();
                        txeNumDocum.Properties.ReadOnly = true;
                        cmbTipoDocu.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado:
                        uCMenu.Enabled_bntAnular = false;
                        uCMenu.Enabled_bntGuardar_y_Salir = true;
                        uCMenu.Enabled_bntLimpiar = false;
                        uCMenu.Enabled_btnGuardar = true;
                        uCMenu.Enabled_bntImprimir = true;
                        set_Info_OrdenGiro_Controles();
                        chk_TieneRetencion.Enabled = false;
                        btn_Importar_XML.Enabled = false;
                        btn_Autoriza.Enabled = false;
                        txeNumDocum.Properties.ReadOnly = true;
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

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cargar_Combos()
        {
            try
            {
                string msg = "";

                ListCodigoSRI = dat_ti.Get_List_codigo_SRI_(param.IdEmpresa);
                cmb_idtCredito.Properties.DataSource = ListCodigoSRI.FindAll(c => c.co_estado == "A" && c.IdTipoSRI == "COD_IDCREDITO").OrderBy(C => C.codigoSRI).ToList();
                cmb_idtCredito.Properties.DisplayMember = "descriConcate";
                cmb_idtCredito.Properties.ValueMember = "IdCodigo_SRI";

                cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
                List<cp_TipoDocumento_Info> ListTipDoc_Modi = new List<cp_TipoDocumento_Info>();
                LstTipDoc = TipDoc_B.Get_List_TipoDocumento().FindAll(c => c.CodSRI != "04");
                ListTipDoc_Modi = TipDoc_B.Get_List_TipoDocumento().FindAll(c => c.CodSRI != "04");

                LstTipDoc.ForEach(c => c.Descripcion = "[" + c.CodSRI + "] - " + c.Descripcion);
                cmbTipoDocu.Properties.DataSource = LstTipDoc;
                cmbTipoDocu.Properties.DisplayMember = "Descripcion";
                cmbTipoDocu.Properties.ValueMember = "CodTipoDocumento";

                ba_TipoFlujo_Bus b = new ba_TipoFlujo_Bus();
                var a = b.Get_List_TipoFlujo(param.IdEmpresa);

                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>();
                cp_orden_giro_pagos_sri_Bus BusPagosSri = new cp_orden_giro_pagos_sri_Bus();
                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>(BusPagosSri.Get_List_orden_giro_pagos_sri(0, 0, 0));
                gridControl_formasPagoSRI.DataSource = BindingList_pagosSRI;

                cmbTipoDocu_a_modificar.Properties.DataSource = ListTipDoc_Modi.FindAll(c => c.Estado == "A");
                cmbTipoDocu_a_modificar.Properties.DisplayMember = "Descripcion";
                cmbTipoDocu_a_modificar.Properties.ValueMember = "CodTipoDocumento";

                cmbTipoDocu.Properties.DisplayMember = "Descripcion";
                cmbTipoDocu.Properties.ValueMember = "CodTipoDocumento";

                cmbPais.Properties.DataSource = Bus_Pais_SRI.Get_List_Pais_SRI(ref msg);
                cmbPais.Properties.DisplayMember = "Codigo";
                cmbPais.Properties.ValueMember = "Pais";

                BindingListOrdenGiroDet = new BindingList<cp_orden_giro_det_Info>();
                gridControlOrdenGiroCuentas.DataSource = BindingListOrdenGiroDet;

                ListCuentas = _PlanCta_bus.Get_List_Plancta(param.IdEmpresa, ref MensajeError);
                repItemCuenta.DataSource = ListCuentas;

                ListImpuesto = BusImpuesto.Get_List_impuesto();

                repItemImpuestoIVA.DataSource = ListImpuesto.Where(q => q.IdTipoImpuesto == "IVA");
                repItemImpuestoICE.DataSource = ListImpuesto.Where(q => q.IdTipoImpuesto == "ICE");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculaTotales()
        {
            try
            {
                total = Convert.ToDecimal(txtSubtotalIVA15.EditValue)
                    + Convert.ToDecimal(txtSubtotalIVA5.EditValue)
                    + Convert.ToDecimal(txtSubtotalIVA0.EditValue)
                    - Convert.ToDecimal(txtDescuento.EditValue)
                    + Convert.ToDecimal(txtIVA15.EditValue)
                    + Convert.ToDecimal(txtIVA5.EditValue)
                    + Convert.ToDecimal(txtICE.EditValue);

                txtTotal.EditValue = total;
                txtBaseImponible.EditValue = Math.Round((Convert.ToDouble(txtSubtotalIVA15.EditValue) + Convert.ToDouble(txtSubtotalIVA0.EditValue)), 2);

                AplicaCalculoRetencion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CalculoRetencion()
        {
            try
            {
                valorApagar = Convert.ToDecimal(txtTotal.EditValue) - Convert.ToDecimal(ucCp_Retencion1.calcula_MontoRetencion());

                txtValorAPagar.EditValue = valorApagar;
                Vsaldo = valorApagar;
                txtSaldo.EditValue = Vsaldo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GeneraDiario()
        {
            try
            {
                UC_Diario_x_cxp.LimpiarGrid();

                InfoProveedor = new cp_proveedor_Info();

                if (ucCp_Proveedor1.cmb_proveedor.EditValue == null) return;
          
                InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();

                if (InfoProveedor == null)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar el Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToDouble(txtBaseImponible.EditValue) <= 0)
                {
                    MessageBox.Show("Para generar el diario la Base Imponible debe ser mayor a 0, Por favor ingrese los valores de la Factura", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridViewOrdenGiroCuentas.Focus();
                    return;
                }

                List<ct_Cbtecble_det_Info> ListDetalle = new List<ct_Cbtecble_det_Info>();

                //PROVEEDOR LOCAL
                ct_Cbtecble_det_Info prov = new ct_Cbtecble_det_Info();
                prov.IdEmpresa = param.IdEmpresa;

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    ucCp_Proveedor1.set_ProveedorInfo(InfoProveedor.IdProveedor);
                    prov.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                }
                else
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                    {
                        ucCp_Proveedor1.set_ProveedorInfo(InfoProveedor.IdProveedor);
                        prov.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                    }
                    else
                    {
                        prov.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                    }
                }
                prov.IdCentroCosto = ucCp_Proveedor1.get_ProveedorInfo().IdCentroCosoto;
                prov.IdCentroCosto_sub_centro_costo = ucCp_Proveedor1.get_ProveedorInfo().IdSubCentroCosoto;
                prov.IdPunto_cargo = ucCp_Proveedor1.get_ProveedorInfo().IdPunto_cargo;
                prov.IdPunto_cargo_grupo = ucCp_Proveedor1.get_ProveedorInfo().IdPunto_cargo_grupo;
                prov.dc_Valor = (Convert.ToDecimal(txtTotal.EditValue) > 0) ? (Convert.ToDouble(txtTotal.EditValue) * -1) : 0;
                ListDetalle.Add(prov);

                // IVA POR PAGAR
                ct_Cbtecble_det_Info iva = new ct_Cbtecble_det_Info();
                double valorIVA = Convert.ToDouble(txtIVA15.EditValue) + Convert.ToDouble(txtIVA5.EditValue);

                if (valorIVA > 0)
                {
                    iva.IdEmpresa = param.IdEmpresa;

                    if (!String.IsNullOrEmpty(paramCP_I.pa_ctacble_iva))
                    {
                        iva.IdCtaCble = paramCP_I.pa_ctacble_iva.Trim();
                    }
                    else
                    {
                        iva.IdCtaCble = null;
                    }

                    iva.tipo = "IVA";
                    iva.dc_Valor = Math.Round(valorIVA, 2, MidpointRounding.AwayFromZero);

                    ListDetalle.Add(iva);
                }

                foreach (var item in BindingListOrdenGiroDet)
                {
                    // CTA GASTO
                    ct_Cbtecble_det_Info gto = new ct_Cbtecble_det_Info();
                    gto.IdEmpresa = param.IdEmpresa;
                    gto.IdCtaCble = item.IdCtaCble;

                    // Si la cuenta esta vacia toma la cuenta de la ficha del proveedor
                    if (gto.IdCtaCble == null)
                    {
                        gto.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_Gasto;
                    }
                    // Si la cuenta esta vacia toma del parametro
                    if (gto.IdCtaCble == null)
                    {
                        gto.IdCtaCble = paramCP_I.pa_ctacble_deudora;
                    }

                    gto.dc_Valor = Convert.ToDouble(item.Subtotal);
                    ListDetalle.Add(gto);
                }

                UC_Diario_x_cxp.setDetalle(ListDetalle);
                Diario_generado = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void deshabilitarCamposRet()
        {
            try
            {
                CalculaTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar(ref string msg)
        {
            try
            {

                Boolean estado = true;
                Boolean todasFilas_porc_0 = false;

                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dtp_fecha_contabilizacion.Value, ref MensajeError);

                if (Per_I == null)
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo no se encuentra ingresado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (Per_I.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                if (String.IsNullOrEmpty(Convert.ToString(txeIdNumAutoriza.EditValue)))
                {
                    MessageBox.Show("Ingrese el Número de Autorización del Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeIdNumAutoriza.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(Convert.ToString(txeSerie.EditValue)))
                {
                    MessageBox.Show("Ingrese la serie del Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeSerie.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    MessageBox.Show("Ingrese el Número del Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeNumDocum.Focus();
                    return false;
                }


                if (Convert.ToDateTime(dtp_fechaFactura.Value.ToShortDateString()) > Convert.ToDateTime(dtp_FechaVcto.Value.ToShortDateString()))
                {
                    MessageBox.Show("La Fecha Documento no puede ser mayor a la Fecha Vencimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }

                if (Convert.ToDateTime(dtp_FechaVcto.Value.ToShortDateString()) < Convert.ToDateTime(dtp_fechaFactura.Value.ToShortDateString()))
                {
                    MessageBox.Show("La Fecha Vencimiento no puede ser menor a la Fecha Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }

                InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();
                if (InfoProveedor == null && _Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                if (cmbTipoDocu.EditValue == null || cmbTipoDocu.EditValue == "")
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Tipo de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoDocu.Focus();
                    return false;
                }


                if (txeNumDocum.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar ingrese #Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (param.IdSucursal == 0)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (String.IsNullOrEmpty(Convert.ToString(cmb_idtCredito.EditValue)))
                {
                    MessageBox.Show("Antes de continuar debe seleccionar la Identificación de sustento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Convert.ToDouble(txtIVA5.EditValue) == 0)
                {
                    MessageBox.Show("Base imponible no puede ser 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Convert.ToDateTime(dtp_fechaFactura.Value.ToShortDateString()) > Convert.ToDateTime(dtp_FechaVcto.Value.ToShortDateString()))
                {
                    MessageBox.Show("La Fecha Documento no puede ser mayor a la Fecha Vencimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Convert.ToDateTime(dtp_FechaVcto.Value.ToShortDateString()) < Convert.ToDateTime(dtp_fechaFactura.Value.ToShortDateString()))
                {
                    MessageBox.Show("La Fecha Vencimiento no puede ser menor a la Fecha Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (UC_Diario_x_cxp.ValidarAsientosContables() == false)
                {
                    return false;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (Convert.ToDecimal(txtSaldo.EditValue) < Convert.ToDecimal(txtValorAPagar.EditValue))
                    {
                        if (Vtotal != Convert.ToDecimal(txtTotal.EditValue) || VvalorApagar != Convert.ToDecimal(txtValorAPagar.EditValue))
                        {
                            MessageBox.Show("Los valores anteriores de Total : " + Vtotal.ToString() + " y Valor a Pagar: " + VvalorApagar.ToString() + " No se puede Actualizar con Total: " + txtTotal.EditValue + " Valor a Pagar: " + txtValorAPagar.EditValue + "Porque ya se han realizado pagos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
        
                if (chk_TieneRetencion.Checked == true)
                {
                    if (ucCp_Retencion1.Get_BindingList().Count > 0)
                    {
                        double b_iva = 0;
                        double b_rtf = 0;

                        foreach (var item in ucCp_Retencion1.Get_BindingList())
                        {

                            if (item.co_porRetencion != 0)
                            {
                                todasFilas_porc_0 = true;
                            }


                            if (item.Tipo == "IVA")
                            {
                                b_iva = b_iva + item.BaseImponible;
                                if (item.BaseImponible == 0)
                                {
                                    MessageBox.Show("En Datos Retención Se están realizando retenciones del IVA, sin haber ingresado la base del IVA ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                b_rtf = b_rtf + item.BaseImponible;
                            }

                            if (item.BaseImponible == 0)
                            {
                                MessageBox.Show("La Base Imponible no puede ser 0. En el Detalle de Retención");
                                return false;
                            }
                        }

                        if (todasFilas_porc_0 == true)
                        {
                            if (ucCp_Retencion1.Get_BindList_ct_Cbtecble_det_Retencion().Count != 0)
                            {

                                if (!ucCp_Retencion1.valida_ct_Cbtecble_det_Retencion())
                                {
                                    MessageBox.Show("No existe cuenta contable en el Diario de Retención");
                                    return false;
                                }
                            }
                        }

                        b_iva = Math.Round(b_iva, 2);
                        b_rtf = Math.Round(b_rtf, 2);

                        if (b_iva > 0 && b_iva != Math.Round(Convert.ToDouble(txtIVA15.EditValue), 2, MidpointRounding.AwayFromZero))
                        {
                            MessageBox.Show("En Datos Retención se están realizando retenciones del IVA que no concuerdan con el total del IVA de la Factura Proveedor ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        if (b_rtf > 0 && b_rtf != Math.Round(Convert.ToDouble(txtIVA5.EditValue), 2, MidpointRounding.AwayFromZero))
                        {
                            DialogResult Respuesta;
                            Respuesta = MessageBox.Show("En Datos Retención se están realizando retenciones de a la fuente que no concuerdan con la base imponible de la Factura Proveedor  ¿Esta Realmente seguro de guardar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Respuesta == System.Windows.Forms.DialogResult.No)
                            { return false; }

                        }

                    }

                }

                if (cmb_Local_Exterios.SelectedIndex == 1 && (cmbPais.EditValue == null || cmbPais.EditValue == ""))
                {
                    MessageBox.Show("En información de Pago debe seleccionar El País al que se efectua el pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                var List_pagosSRI_chequados = this.BindingList_pagosSRI.ToList().Count(c => c.check == true);

                if (Convert.ToDouble(txtTotal.Text) <= 1000)
                {
                    if (Convert.ToDecimal(List_pagosSRI_chequados) > 0)
                    {
                        MessageBox.Show("No es necesario que aplique las formas de Pago cuando su base imponible es menor o igual a 1000\n Se procederá a deschequear todas las Formas de pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var c = pagoSRI_B.Get_List_orden_giro_pagos_sri();
                        BindingList_pagosSRI.Clear();
                        foreach (var item in c)
                        {
                            BindingList_pagosSRI.Add(item);
                        }
                    }
                }
                else// es mayor a 1000 se pide la forma de pago
                {

                    if (Convert.ToDecimal(List_pagosSRI_chequados) == 0) // no tiene forma de pago
                    {
                        MessageBox.Show("la factura es mayor a 1000 debe escoger al menos una forma de Pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                }

                if (!String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar && ordenGiro_B.ExisteFacturaPorProveedor(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, txeSerie.Text, Convert.ToString(txeNumDocum.EditValue)))
                    {
                        MessageBox.Show("El número de documento ya fue ingresado verifique ", param.Nombre_sistema);
                        return false;
                    }

                }

                string mensaje = "";

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    if (!chk_TieneRetencion.Checked == false)
                    {

                        if (!ucCp_Retencion1.valida())
                        {
                            return false;
                        }
                    }
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtp_fecha_contabilizacion.Value)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtp_fecha_contabilizacion.Value)))
                    return false;

                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                msg = "Error ocurrido al grabar..  " + ex.Message + ex.InnerException;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private Boolean ValidarTipComp_x_Empresa()
        {
            Boolean res = true;

            return res;
        }

        private Boolean getDiarioRetencion()
        {
            Boolean res = true;
            try
            {

                Info_CbteCble_x_Ret = ucCp_Retencion1.Get_Info_CbteCble_Retencion();

                if (Info_CbteCble_x_Ret._cbteCble_det_lista_info.Count != 0)
                {
                    double total = 0;
                    string Tipo = ""; string Porc = ""; string Prove = ""; string TipDoc = ""; string Ndoc = "";
                    int c = 0; int i = 0;

                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (Info_OrdenGiro.InfoProveedor.pr_nombre == null)
                            Prove = "";
                        else

                            Prove = Info_OrdenGiro.InfoProveedor.pr_nombre;
                    }
                    else
                    {
                        Prove = ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                    }

                    TipDoc = cmbTipoDocu.Text;
                    Ndoc = Convert.ToString(txeNumDocum.EditValue);

                    foreach (var item in Info_CbteCble_x_Ret._cbteCble_det_lista_info)
                    {
                        if (c == 0)
                        {
                            try
                            {
                                Tipo = item.tipo;
                            }
                            catch (Exception ex)
                            {
                                Log_Error_bus.Log_Error(ex.ToString());
                            }

                            i++;
                        }
                        else
                            c = 0;
                        item.IdEmpresa = param.IdEmpresa;

                        item.dc_Observacion = "Ret " + Tipo + "/" + Porc + "% al Prov:"
                            + Prove.Trim() + " " + TipDoc + " Doc#" + txeNumDocum.EditValue + " "
                            + item.dc_Observacion;

                        if (item.dc_Valor > 0)
                            total = item.dc_Valor + total;
                    }

                    Info_CbteCble_x_Ret.IdEmpresa = param.IdEmpresa;
                    Info_CbteCble_x_Ret.IdTipoCbte = Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion);
                    Info_CbteCble_x_Ret.CodCbteCble = "";
                    Info_CbteCble_x_Ret.IdPeriodo = Per_I.IdPeriodo;
                    Info_CbteCble_x_Ret.cb_Fecha = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value;

                    Info_CbteCble_x_Ret.cb_Valor = total;
                    Info_CbteCble_x_Ret.cb_Observacion = "Diario x Cbte Ret del Prov:"
                                + Prove + " " + TipDoc + " Doc#" + txeNumDocum.EditValue;
                    Info_CbteCble_x_Ret.Secuencia = 0;
                    Info_CbteCble_x_Ret.Estado = "A";
                    Info_CbteCble_x_Ret.Anio = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value.Year;
                    Info_CbteCble_x_Ret.Mes = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value.Month;

                    Info_CbteCble_x_Ret.IdUsuario = param.IdUsuario;
                    Info_CbteCble_x_Ret.IdUsuarioUltModi = param.IdUsuario;
                    Info_CbteCble_x_Ret.cb_FechaTransac = param.Fecha_Transac;
                    Info_CbteCble_x_Ret.cb_FechaUltModi = param.Fecha_Transac;
                    Info_CbteCble_x_Ret.Mayorizado = "N";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }
        public ct_Cbtecble_Info get_Cbtecble()
        {
            try
            {
                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = _IdTipoCbte;
                CbteCble_I.CodCbteCble = "";
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = dtp_fecha_contabilizacion.Value;
                CbteCble_I.cb_Valor = UC_Diario_x_cxp.Get_ValorCbteCble();
                CbteCble_I.cb_Observacion = txt_observacion.Text.Trim() + "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = dtp_fecha_contabilizacion.Value.Year;
                CbteCble_I.Mes = dtp_fecha_contabilizacion.Value.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble = (txt_NOrdeG.Text == "") ? 0 : Convert.ToDecimal(txt_NOrdeG.Text);

                return CbteCble_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_Info();
            }
        }
        public void get_ordenGiro()
        {
            try
            {
                Info_OrdenGiro.IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                Info_OrdenGiro.IdSucursal = param.IdSucursal;
                Info_OrdenGiro.IdCbteCble_Ogiro = (txt_NOrdeG.Text == "") ? 0 : Convert.ToDecimal(txt_NOrdeG.Text);
                Info_OrdenGiro.IdTipoCbte_Ogiro = _IdTipoCbte;                
                Info_OrdenGiro.co_baseImponible = Convert.ToDouble(txtIVA5.EditValue);
                Info_OrdenGiro.co_BaseSeguro = 0;
                Info_OrdenGiro.co_factura = Convert.ToString(txeNumDocum.EditValue);
                Info_OrdenGiro.co_FechaFactura = dtp_fechaFactura.Value;
                Info_OrdenGiro.co_FechaFactura_vct = this.dtp_FechaVcto.Value;
                Info_OrdenGiro.co_FechaContabilizacion = dtp_fecha_contabilizacion.Value;
                Info_OrdenGiro.co_fechaOg = Convert.ToDateTime(dtp_fechaOG.Value.ToShortDateString());
                Info_OrdenGiro.co_Ice_base = 0;
                Info_OrdenGiro.co_Ice_por = 0;
                Info_OrdenGiro.co_Ice_valor = Convert.ToDouble(txtICE.EditValue);

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    Info_OrdenGiro.co_observacion = txt_observacion.Text.Trim() + "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                else
                    Info_OrdenGiro.co_observacion = txt_observacion.Text.Trim();

                Info_OrdenGiro.co_OtroValor_a_descontar = 0;
                Info_OrdenGiro.co_OtroValor_a_Sumar = 0;
                Info_OrdenGiro.co_plazo = String.IsNullOrEmpty(txt_plazo.Text) ? 0 : Convert.ToInt32(txt_plazo.Text.Trim());
                Info_OrdenGiro.co_Por_iva = 0;
                Info_OrdenGiro.co_serie = Convert.ToString(txeSerie.EditValue).Trim();
                Info_OrdenGiro.co_Serv_por = 0;
                Info_OrdenGiro.co_Serv_valor = 0;
                Info_OrdenGiro.co_subtotal_iva = Convert.ToDouble(txtSubtotalIVA15.EditValue);
                Info_OrdenGiro.co_subtotal_siniva = Convert.ToDouble(Math.Round(Convert.ToDecimal(txtSubtotalIVA0.EditValue), 2));
                Info_OrdenGiro.co_total = Convert.ToDouble(Math.Round(Convert.ToDecimal(txtTotal.EditValue), 2));
                Info_OrdenGiro.co_vaCoa = (chk_coa.Checked == true) ? "S" : "N";
                Info_OrdenGiro.co_valoriva = Convert.ToDouble(Math.Round(Convert.ToDecimal(txtIVA15.EditValue), 2, MidpointRounding.AwayFromZero));
                Info_OrdenGiro.co_valorpagar = Convert.ToDouble(Math.Round(Convert.ToDecimal(txtValorAPagar.EditValue), 2));
                Info_OrdenGiro.Estado = (Info_OrdenGiro.Estado == "I") ? Info_OrdenGiro.Estado : "A";
                Info_OrdenGiro.Fecha_Transac = param.Fecha_Transac;
                Info_OrdenGiro.Fecha_UltMod = param.Fecha_Transac;
                Info_OrdenGiro.Num_Autorizacion = Convert.ToString(txeIdNumAutoriza.EditValue);
                Info_OrdenGiro.fecha_autorizacion = DateTime.Now;
                Info_OrdenGiro.Num_Autorizacion_Imprenta = "";
                Info_OrdenGiro.IdOrden_giro_Tipo = Convert.ToString(cmbTipoDocu.EditValue);
                Info_OrdenGiro.IdCod_101 = null;
                Info_OrdenGiro.IdTipoMovi = null;
                Info_OrdenGiro.IdIden_credito = Convert.ToInt32(cmb_idtCredito.EditValue);

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_OrdenGiro.IdProveedor = InfoProveedor.IdProveedor;
                }
                
                Info_OrdenGiro.IdTipoServicio = cmb_tipoOG.Text;
                Info_OrdenGiro.IdUsuario = param.IdUsuario;
                Info_OrdenGiro.IdUsuarioUltAnu = param.IdUsuario;
                Info_OrdenGiro.IdUsuarioUltMod = param.IdUsuario;
                Info_OrdenGiro.ip = param.ip;
                Info_OrdenGiro.MotivoAnu = "";
                Info_OrdenGiro.nom_pc = param.nom_pc;

                var detalle = UC_Diario_x_cxp.Get_Info_CbteCble()._cbteCble_det_lista_info;
                foreach (var item in detalle)
                {
                    if (item.tipo == "IVA")
                    {
                        if (!String.IsNullOrEmpty(item.IdCtaCble.Trim()))
                        {
                            Info_OrdenGiro.IdCtaCble_IVA = item.IdCtaCble;
                        }
                        else
                        { Info_OrdenGiro.IdCtaCble_IVA = null; }
                    }
                }

                Info_OrdenGiro.IdTipoFlujo = null;
                Info_OrdenGiro.co_retencionManual = "N";
                Info_OrdenGiro.Fecha_UltAnu = param.Fecha_Transac;
                Info_OrdenGiro.PagoLocExt = (cmb_Local_Exterios.SelectedIndex == 0) ? "LOC" : "EXT";
                Info_OrdenGiro.PaisPago = Convert.ToString(cmbPais.EditValue);
                Info_OrdenGiro.ConvenioTributacion = (rb_aplicConvDobTribSI.Checked == true) ? "SI" : (rb_aplicConvDobTribNO.Checked == true) ? "NO" : "NA";
                Info_OrdenGiro.PagoSujetoRetencion = (rb_pagExtSujRetNorLegSI.Checked == true) ? "SI" : (rb_pagExtSujRetNorLegNO.Checked == true) ? "NO" : "NA";

                Info_OrdenGiro.cp_es_comprobante_electronico = chk_Cbte_Electronico.Checked;

                if (String.IsNullOrWhiteSpace(txt_serie_a_modificar.Text) == false)
                {
                    Info_OrdenGiro.Tipodoc_a_Modificar = cmbTipoDocu_a_modificar.EditValue.ToString();
                    Info_OrdenGiro.estable_a_Modificar = txt_serie_a_modificar.Text.Substring(0, 3);
                    Info_OrdenGiro.ptoEmi_a_Modificar = txt_serie_a_modificar.Text.Substring(4, 3);
                    Info_OrdenGiro.num_docu_Modificar = txt_num_doc_a_modificar.Text;
                    Info_OrdenGiro.aut_doc_Modificar = txt_num_auto_a_modificar.Text;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<ct_Cbtecble_det_Info> get_CbteCble_det()
        {
            try
            {
                var detalle = UC_Diario_x_cxp.Get_Info_CbteCble()._cbteCble_det_lista_info;
                int i = 1;
                foreach (var dte in detalle)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = (txt_NOrdeG.Text == "") ? 0 : Convert.ToDecimal(txt_NOrdeG.Text);
                    dte.IdTipoCbte = _IdTipoCbte;

                    if (String.IsNullOrEmpty(dte.dc_Observacion))
                    {
                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            dte.dc_Observacion = String.IsNullOrEmpty(txt_observacion.Text) ? "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre : txt_observacion.Text.Trim() + "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                        }
                        else
                        {
                            dte.dc_Observacion = String.IsNullOrEmpty(txt_observacion.Text) ? "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre : txt_observacion.Text.Trim(); ;
                        }
                    }

                    dte.secuencia = i++;
                }
                CbteCble_I._cbteCble_det_lista_info = detalle;

                return detalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
            }
        }
        public void get_reembolso_y_formasPago()
        {
        }

        public cp_retencion_Info get_lisRetencion()
        {
            try
            {
                cp_retencion_Info info = new cp_retencion_Info();

                if (ucCp_Retencion1.Get_BindingList().Count != 0)
                {

                    //se realiza al crear nueva retencion
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar || (Info_Retencion == null || Info_Retencion == new cp_retencion_Info()) || Info_Retencion.IdRetencion == 0)
                    {

                        info.CodDocumentoTipo = ucCp_Retencion1.Get_Info_Talonario().CodDocumentoTipo;
                        info.NumRetencion = ucCp_Retencion1.Get_Info_Talonario().NumDocumento;
                        info.serie1 = ucCp_Retencion1.Get_Info_Talonario().Establecimiento;
                        info.serie2 = ucCp_Retencion1.Get_Info_Talonario().PuntoEmision;
                        info.EsDocumentoElectronico = Convert.ToBoolean(ucCp_Retencion1.Get_Info_Talonario().es_Documento_electronico);
                        info.IdRetencion = 0;
                        info.Estado = "A";
                        info.IdUsuario = param.IdUsuario;
                        info.Fecha_Transac = param.Fecha_Transac;
                        info.nom_pc = param.nom_pc;
                        info.ip = param.ip;
                        info.re_Tiene_RTiva = "N";
                        info.re_Tiene_RFuente = "N";
                        info.re_EstaImpresa = "S";
                        info.observacion = "Ret. x prove:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre + "";
                    }
                    else
                        info = Info_Retencion;
                    info.NumRetencion = ucCp_Retencion1.Get_Info_Talonario().NumDocumento;
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdCbteCble_Ogiro = Convert.ToDecimal((txt_NOrdeG.Text == "") ? "0" : txt_NOrdeG.Text);
                    info.IdTipoCbte_Ogiro = _IdTipoCbte;
                    info.fecha = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value;
                    info.re_EstaImpresa = "S";
                    info.IdUsuarioUltMod = param.IdUsuario;
                    info.Fecha_UltMod = param.Fecha_Transac;
                    info.Fecha_Transac = param.Fecha_Transac;
                    info.IdUsuario = param.IdUsuario;
                    _ListaRetencion = new List<cp_retencion_det_Info>();


                    foreach (var item in ucCp_Retencion1.Get_BindingList())
                    {
                        cp_retencion_det_Info ret_I = new cp_retencion_det_Info();
                        ret_I.IdEmpresa = param.IdEmpresa;
                        ret_I.IdRetencion = 0;
                        ret_I.Idsecuencia = 0;
                        // ret_I.re_fecha = ucCp_Retencion1.dtp_fechaEmisionRetencion.Value;

                        string re_Tiene_RTiva = (item.Tipo == "IVA") ? "S" : "N";
                        string re_Tiene_RFuente = (item.Tipo == "RTF") ? "S" : "N";
                        if (re_Tiene_RFuente == "S")
                        { info.re_Tiene_RFuente = "S"; }
                        if (re_Tiene_RTiva == "S")
                        { info.re_Tiene_RTiva = "S"; }
                        ret_I.re_tipoRet = item.Tipo;
                        ret_I.re_baseRetencion = item.BaseImponible;
                        ret_I.IdCodigo_SRI = Convert.ToInt32(Convert.ToString(item.IdCodigo_SRI) == "" ? "0" : Convert.ToString(item.IdCodigo_SRI));
                        ret_I.re_Codigo_impuesto = item.codigoSRI == null ? "" : Convert.ToString(item.codigoSRI);
                        ret_I.re_Porcen_retencion = Convert.ToDouble(Convert.ToString(item.co_porRetencion) == "" ? "0" : Convert.ToString(item.co_porRetencion));
                        ret_I.re_valor_retencion = Convert.ToDouble((Convert.ToString(item.MontoRetencion) == "") ? "0" : Convert.ToString(item.MontoRetencion));

                        ret_I.IdCtaCble = item.IdCtaCble;
                        ret_I.re_estado = "";
                        ret_I.IdUsuario = param.IdUsuario;
                        ret_I.Fecha_Transac = param.Fecha_Transac;
                        ret_I.IdUsuarioUltMod = param.IdUsuario;
                        ret_I.Fecha_UltMod = param.Fecha_Transac;
                        ret_I.IdUsuarioUltAnu = param.IdUsuario;
                        ret_I.Fecha_UltAnu = param.Fecha_Transac;
                        ret_I.nom_pc = param.nom_pc;
                        ret_I.ip = param.ip;

                        _ListaRetencion.Add(ret_I);


                    }

                    info.ListDetalle = _ListaRetencion;

                }
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cp_retencion_Info();
            }
        }
        private void set_Info_OrdenGiro_Controles()
        {
            try
            {
                #region campos normales
                ///seteando campos normales
                ///
                cp_proveedor_Autorizacion_Bus bus_autorizacion = new cp_proveedor_Autorizacion_Bus();
                cp_proveedor_Autorizacion_Info info_autorizacion = new cp_proveedor_Autorizacion_Info();

                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    string s1 = Info_OrdenGiro.co_serie.Substring(0, 3);
                    string s2 = Info_OrdenGiro.co_serie.Substring(4, 3);
                    if (Info_OrdenGiro.Num_Autorizacion != "11111")
                    {
                        info_autorizacion = bus_autorizacion.Get_Info_proveedor_Autorizacion(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdProveedor, s1, s2, info_autorizacion.Serie2);
                        txeIdNumAutoriza.EditValue = info_autorizacion.nAutorizacion;
                    }
                }

                Ejecutar_Evento = false;

                dtp_FechaVcto.Value = Info_OrdenGiro.co_FechaFactura_vct;
                dtp_fechaFactura.Value = Info_OrdenGiro.co_FechaFactura;
                dtp_fechaOG.Value = Info_OrdenGiro.co_fechaOg;
                dtp_fecha_contabilizacion.Value = Convert.ToDateTime(Info_OrdenGiro.co_FechaContabilizacion);

                Ejecutar_Evento = true;

                txt_NOrdeG.Text = Info_OrdenGiro.IdCbteCble_Ogiro.ToString();
                txtIVA5.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_baseImponible);

                txeNumDocum.EditValue = Info_OrdenGiro.co_factura;

                txeSerie.EditValue = Info_OrdenGiro.co_serie;
                txtSubtotalIVA15.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_subtotal_iva);
                txtSubtotalIVA0.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_subtotal_siniva);
                chk_coa.Checked = (Info_OrdenGiro.co_vaCoa == "S") ? true : false;
                txtIVA15.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_valoriva);
                txt_observacion.Text = Info_OrdenGiro.co_observacion;
                txt_plazo.Text = Info_OrdenGiro.co_plazo.ToString();
                lblanulado.Visible = (Info_OrdenGiro.Estado == "I") ? true : false;
                lblanulado.Text = "*ANULADO* TipCbt:" + Info_OrdenGiro.IdTipoCbte_Anulacion + "-#CbtCble:" + Info_OrdenGiro.IdCbteCble_Anulacion;
                ucCp_Proveedor1.set_ProveedorInfo(Info_OrdenGiro.IdProveedor);
                IdCtaCble_Proveedor = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;

                nomProveedor = Info_OrdenGiro.InfoProveedor.pr_nombre;

                _IdTipoCbte = Info_OrdenGiro.IdTipoCbte_Ogiro;
                cmb_tipoOG.Text = Info_OrdenGiro.IdTipoServicio;
                cmb_idtCredito.EditValue = Convert.ToInt32(Info_OrdenGiro.IdIden_credito);
                cmbTipoDocu.EditValue = Info_OrdenGiro.IdOrden_giro_Tipo;
                txeIdNumAutoriza.EditValue = Info_OrdenGiro.Num_Autorizacion;
                Vtotal = Convert.ToDecimal(Info_OrdenGiro.co_total);
                VvalorApagar = Convert.ToDecimal(Info_OrdenGiro.co_valorpagar);
                Vsaldo = Convert.ToDecimal(Info_OrdenGiro.saldo);
                txtTotal.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_total);
                txtValorAPagar.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_valorpagar);
                txtSaldo.EditValue = Convert.ToDecimal(Info_OrdenGiro.saldo);

                chk_Cbte_Electronico.Checked = Info_OrdenGiro.cp_es_comprobante_electronico == null ? false : Convert.ToBoolean(Info_OrdenGiro.cp_es_comprobante_electronico);

                if (String.IsNullOrWhiteSpace(Info_OrdenGiro.num_docu_Modificar) == false)
                {
                    string serie_doc_modi = "";
                    serie_doc_modi = Info_OrdenGiro.estable_a_Modificar + "-" + Info_OrdenGiro.ptoEmi_a_Modificar;

                    cmbTipoDocu_a_modificar.EditValue = Info_OrdenGiro.Tipodoc_a_Modificar;
                    txt_serie_a_modificar.Text = serie_doc_modi;
                    txt_num_doc_a_modificar.Text = Info_OrdenGiro.num_docu_Modificar;
                    txt_num_auto_a_modificar.Text = Info_OrdenGiro.aut_doc_Modificar;
                }

                #region Cargar Retención

                cp_retencion_Info Info_OrdenGiro_Retencion = new cp_retencion_Info();
                Info_OrdenGiro_Retencion = ret_B.Get_Info_retencion(param.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro);

                _ListaRetencionOld = Info_OrdenGiro_Retencion.ListDetalle;

                if (_ListaRetencionOld != null)
                {
                    if (_ListaRetencionOld.Count > 0)
                    {
                        chk_TieneRetencion.Checked = true;

                        ucCp_Retencion1.Visible_GridRetencion(true);

                        cp_retencion_Bus busretencion = new cp_retencion_Bus();
                        cp_retencion_x_ct_cbtecble_Info ti = busretencion.Get_Info_retencion_x_ct_cbtecble(Info_OrdenGiro_Retencion.IdEmpresa, Info_OrdenGiro_Retencion.IdRetencion);

                        ucCp_Retencion1.setInfo_DiarioRetencion(ti.rt_IdEmpresa, ti.ct_IdTipoCbte, ti.ct_IdCbteCble);
                        ucCp_Retencion1.set_Valores_Documento(Info_OrdenGiro_Retencion.serie1, Info_OrdenGiro_Retencion.serie2, Info_OrdenGiro_Retencion.NumRetencion);
                        setRetencion(Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro);
                    }
                }

                #endregion

                #endregion



                ///se esta seteando el valor a la variable local ordenGiro_I 
                ///para posterior uso de los datos del comprobante por pagar (Orden de Giro)

                /// se obtiene los asientos contables y se los setea al grid 
                set_CbteCbleInfo();
                Diario_generado = true;
                #region obtiene si hay compras locales OC

                //OC -- incomplit
                List<com_ordencompra_local_Info> lstCom = new List<com_ordencompra_local_Info>();
                List<com_ordencompra_local_Info> lstCom2 = new List<com_ordencompra_local_Info>();
                lstCom = OC_B.Get_List_ordencompra_local(param.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro);
                decimal NOC = 0;

                foreach (var item in lstCom)
                {
                    NOC = item.IdOrdenCompra;
                }

                lstCom2 = OC_B.Get_List_ordencompra_local(param.IdEmpresa);

                cmb_Local_Exterios.SelectedIndex = (Info_OrdenGiro.PagoLocExt == "LOC") ? 0 : 1;
                #endregion

                cmbPais.EditValue = Info_OrdenGiro.PaisPago;

                if (Info_OrdenGiro.ConvenioTributacion == "SI")
                    rb_aplicConvDobTribSI.Checked = true;
                else if (Info_OrdenGiro.ConvenioTributacion == "NO")
                    rb_aplicConvDobTribNO.Checked = true;

                if (Info_OrdenGiro.PagoSujetoRetencion == "SI")
                    rb_pagExtSujRetNorLegSI.Checked = true;
                else if (Info_OrdenGiro.PagoSujetoRetencion == "NO")
                    rb_pagExtSujRetNorLegNO.Checked = true;

                #region ///obtiene comprobantes de reembolso y pagos de SRI
                var c = Reem_B.Get_List_reembolso(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro);

                foreach (var item in c)
                {
                    BindingList_Reembolso.Add(item);
                }




                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>();
                cp_orden_giro_pagos_sri_Bus BusPagosSri = new cp_orden_giro_pagos_sri_Bus();
                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>(BusPagosSri.Get_List_orden_giro_pagos_sri(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro));
                gridControl_formasPagoSRI.DataSource = BindingList_pagosSRI;



                #endregion
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_ordenGiro(cp_orden_giro_Info info)
        {
            try
            {

                Info_OrdenGiro = info;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void setRetencion(decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {

            try
            {
                Info_Retencion = ret_B.Get_Info_retencion(param.IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);

                ucCp_Retencion1.dtp_fechaEmisionRetencion.Value = Info_Retencion.fecha;


                cp_retencion_det_Bus bus_reten = new cp_retencion_det_Bus();
                List<cp_retencion_det_Info> listaDetReten = new List<cp_retencion_det_Info>();
                listaDetReten = bus_reten.Get_ListDetRetencion(param.IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);

                List<cp_codigo_SRI_Info> listaCodSRI = new List<cp_codigo_SRI_Info>();
                if (listaDetReten.Count != 0)
                {
                    foreach (var item in listaDetReten)
                    {
                        cp_codigo_SRI_Info info = new cp_codigo_SRI_Info();

                        info.IdCodigo_SRI = item.IdCodigo_SRI;
                        info.Tipo = item.re_tipoRet;
                        info.co_porRetencion = item.re_Porcen_retencion;
                        info.BaseImponible = item.re_baseRetencion;
                        info.MontoRetencion = Convert.ToDouble(item.re_valor_retencion);
                        // info.IdCtaCble = item.IdCtaCble;
                        info.IdCtaCble = ListCodigoSRI.FirstOrDefault(q => q.IdCodigo_SRI == item.IdCodigo_SRI).IdCtaCble;
                        info.codigoSRI = item.re_Codigo_impuesto;

                        listaCodSRI.Add(info);
                    }
                }

                if (Info_Retencion.NumRetencion != null && Info_Retencion.serie1 != null && Info_Retencion.serie2 != null)
                {


                    talonario_Info = Bus_Talonario.Verificar_DocumentoElectronico(Info_Retencion.IdEmpresa, Info_Retencion.CodDocumentoTipo, Info_Retencion.serie1, Info_Retencion.serie2, Info_Retencion.NumRetencion, talonario_Info, ref MensajeError);
                    ucCp_Retencion1.UC_numRetencion.rbt_doc_Electronico.Checked = (bool)talonario_Info.es_Documento_electronico;
                    ucCp_Retencion1.UC_numRetencion.Set_Serie_Num_Documento(talonario_Info.Establecimiento, talonario_Info.PuntoEmision, talonario_Info.NumDocumento);
                    Info_Retencion.EsDocumentoElectronico = talonario_Info.es_Documento_electronico;
                }
                else
                {
                    ucCp_Retencion1.Get_Ult_Documento_no_usado(param.IdEmpresa, "001", "001");
                }

                ucCp_Retencion1.set_ListaCodigoSRI(listaCodSRI);
                ucCp_Retencion1.set_Info_Retencion(Info_Retencion);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void set_CbteCbleInfo()
        {
            try
            {
                if (Info_OrdenGiro.IdCbteCble_Ogiro != 0)
                {
                    ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                    List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                    string MensajeError = "";
                    UC_Diario_x_cxp.LimpiarGrid();
                    lm = _CbteCbleBus.Get_list_Cbtecble_det(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro, ref MensajeError);
                    _ListaCbteCbleDetAnt = lm;
                    UC_Diario_x_cxp.setDetalle(lm);

                    AnteriorDebe = Convert.ToDecimal(UC_Diario_x_cxp.Get_ValorCbteCble());
                    AnteriorHaber = Convert.ToDecimal(UC_Diario_x_cxp.Get_ValorCbteCble());

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Grabar()
        {
            Boolean res = false;
            try
            {
                res = Validar(ref msg);

                if (res)
                {
                    get_Cbtecble();
                    get_CbteCble_det();
                    get_ordenGiro();
                    get_reembolso_y_formasPago();

                    if (!chk_TieneRetencion.Checked == false)
                    {
                        Info_Retencion = get_lisRetencion();
                        getDiarioRetencion();
                    }

                    // Graba Comprobante Contable, la Factura Proveedor, Listado Reembolso, Listado Forma Pago, Retención, CbteCble Retención, Listados de Importacion con 
                    // su Tab Intermedia

                    Info_OrdenGiro.Info_CbteCble_x_OG = CbteCble_I;
                    Info_OrdenGiro.lst_reembolso = lst_reembolso;
                    Info_OrdenGiro.lst_formasPagoSRI = lst_formasPagoSRI;
                    Info_OrdenGiro.Info_Retencion = Info_Retencion;
                    Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT = Info_CbteCble_x_Ret;
                    Info_OrdenGiro.LstImportacionOC = LstImportacionOC;

                    //se graba la cabecera y la retencion
                    if (ordenGiro_B.GrabarDB(Info_OrdenGiro, ref idCbteCble, ref msg))
                    {
                        txt_NOrdeG.Text = idCbteCble.ToString();
                        // grabar tabla intermedia cp_orden_giro_x_com_ordencompra_local_det                         
                        foreach (var item in BindList_OG_x_detOC)
                        {
                            cp_orden_giro_x_com_ordencompra_local_det_Info info = new cp_orden_giro_x_com_ordencompra_local_det_Info();
                            info.IdEmpresa_Ogiro = Info_OrdenGiro.IdEmpresa;
                            info.IdCbteCble_Ogiro = idCbteCble;
                            info.IdTipoCbte_Ogiro = Info_OrdenGiro.IdTipoCbte_Ogiro;
                            info.IdEmpresa_OC = item.IdEmpresa_OC;
                            info.IdSucursal_OC = item.IdSucursal_OC;
                            info.IdOrdenCompra = item.IdOrdenCompra;
                            info.Secuencia_OC = item.Secuencia_OC;
                            info.Observacion = item.Observacion;

                            cp_orden_giro_x_com_ordencompra_local_det_Bus bus = new cp_orden_giro_x_com_ordencompra_local_det_Bus();
                            if (bus.GrabarDB(info, ref msg))
                            { }
                        }
                        // CbteCble_I.IdCbteCble +
                        string smensaje = string.Format("{0} # {1} se guardó con éxito.", "Factura Proveedor: ", Info_OrdenGiro.co_serie + "-" + Info_OrdenGiro.co_factura + "/" + CbteCble_I.IdCbteCble);
                        MessageBox.Show(smensaje, param.Nombre_sistema);


                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                //A NATURISA NO
                                break;
                            default:
                                if (MessageBox.Show("Desea Imprimir la Factura Proveedor ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    uCMenu_event_btnImprimir_Click(new object(), new EventArgs());
                                }
                                break;
                        }


                        if (MessageBox.Show("Desea Imprimir el Comprobante de Diario Factura Proveedor", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            XCONTA_Rpt003_rpt reporte1 = new XCONTA_Rpt003_rpt();
                            reporte1.set_parametros(param.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro);
                            reporte1.RequestParameters = true;
                            reporte1.ShowPreviewDialog();
                        }

                        if (chk_TieneRetencion.Checked == true)
                        {

                            if (MessageBox.Show("Desea Imprimir la Retención Proveedor ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                Imprimir_Retencion();
                            }

                            if (MessageBox.Show("Desea Generar el XMl por Retencion en la fuente.. ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                cp_retencion_Bus BusRetencion = new cp_retencion_Bus();
                                if (BusRetencion.Generacion_xml_SRI(Info_Retencion.IdEmpresa, Info_Retencion.IdRetencion, ref msg))
                                {
                                    MessageBox.Show("Generacion de XML Ok.", param.Nombre_sistema, MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("No se Genero el XML " + msg, param.Nombre_sistema, MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Ingresar la Factura Proveedor ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        res = false;
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private Boolean Modificar_proceso_cerrado()
        {
            Boolean res = true;
            try
            {
                res = Validar(ref msg);

                if (res)
                {
                    get_ordenGiro();
                    get_reembolso_y_formasPago();

                    if (res = ordenGiro_B.ModificarDB_proceso_cerrado(Info_OrdenGiro, ref msg))
                    {
                        MessageBox.Show("Actualización realizada existosamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                break;
                            default:
                                if (MessageBox.Show("¿Desea Imprimir la Factura Proveedor ?", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    btn_imprimirChe_Click(new object(), new EventArgs());
                                }
                                break;
                        }


                        if (MessageBox.Show("¿Desea Imprimir el Comprobante de Diario Factura Proveedor?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            XCONTA_Rpt003_rpt reporte1 = new XCONTA_Rpt003_rpt();
                            reporte1.set_parametros(param.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro);
                            reporte1.RequestParameters = true;
                            reporte1.ShowPreviewDialog();
                        }

                        if (chk_TieneRetencion.Checked == true)
                        {
                            if (MessageBox.Show("Desea Imprimir la Retención Proveedor ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                Imprimir_Retencion();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar la Factura Proveedor ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        res = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private Boolean Modificar()
        {
            Boolean res = true;
            try
            {
                res = Validar(ref msg);

                if (res)
                {
                    get_Cbtecble();
                    get_CbteCble_det();
                    get_ordenGiro();
                    get_reembolso_y_formasPago();

                    #region obtiene retencion si hay, sino setea null a retencion y CbteCble_R

                    if (!chk_TieneRetencion.Checked == false)
                    {
                        Info_Retencion = get_lisRetencion();
                        getDiarioRetencion();

                    }

                    #endregion


                    Info_OrdenGiro.Info_CbteCble_x_OG = CbteCble_I;
                    Info_OrdenGiro.lst_reembolso = lst_reembolso;
                    Info_OrdenGiro.lst_formasPagoSRI = lst_formasPagoSRI;
                    Info_OrdenGiro.Info_Retencion = Info_Retencion;
                    Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT = Info_CbteCble_x_Ret;
                    Info_OrdenGiro.LstImportacionOC = LstImportacionOC;

                    if (res = ordenGiro_B.ModificarDB(Info_OrdenGiro, ref msg))
                    {
                        cp_orden_giro_x_com_ordencompra_local_det_Bus bus = new cp_orden_giro_x_com_ordencompra_local_det_Bus();

                        foreach (var item in BindList_OG_x_detOC)
                        {
                            if (!bus.VerificarRegistro(item.IdEmpresa_OC, item.IdSucursal_OC, item.IdOrdenCompra, item.Secuencia_OC))
                            {
                                //no existe
                                //grabo en base
                                cp_orden_giro_x_com_ordencompra_local_det_Info info = new cp_orden_giro_x_com_ordencompra_local_det_Info();
                                info.IdEmpresa_Ogiro = Info_OrdenGiro.IdEmpresa;
                                info.IdCbteCble_Ogiro = Info_OrdenGiro.IdCbteCble_Ogiro;
                                info.IdTipoCbte_Ogiro = Info_OrdenGiro.IdTipoCbte_Ogiro;
                                info.IdEmpresa_OC = item.IdEmpresa_OC;
                                info.IdSucursal_OC = item.IdSucursal_OC;
                                info.IdOrdenCompra = item.IdOrdenCompra;
                                info.Secuencia_OC = item.Secuencia_OC;
                                info.Observacion = item.Observacion;

                                if (bus.GrabarDB(info, ref msg))
                                { }
                            }
                        }

                        if (!chk_TieneRetencion.Checked == false)
                        {
                            if (this.ucCp_Retencion1.Get_BindingList().Count != 0)
                            {
                                // Actualizar_Retencion_y_Documento_Talonario();
                            }
                        }

                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                break;
                            default:
                                if (MessageBox.Show("¿Desea Imprimir la Factura Proveedor ?", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    btn_imprimirChe_Click(new object(), new EventArgs());
                                }
                                break;
                        }


                        if (MessageBox.Show("¿Desea Imprimir el Comprobante de Diario Factura Proveedor?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            XCONTA_Rpt003_rpt reporte1 = new XCONTA_Rpt003_rpt();
                            reporte1.set_parametros(param.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro);
                            reporte1.RequestParameters = true;
                            reporte1.ShowPreviewDialog();
                        }

                        if (chk_TieneRetencion.Checked == true)
                        {
                            if (MessageBox.Show("Desea Imprimir la Retención Proveedor ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                Imprimir_Retencion();
                            }

                            if (Info_Retencion != null && Info_Retencion.IdRetencion != 0)
                            {

                                if (MessageBox.Show("Desea Generar el XMl por Retencion en la fuente.. ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    cp_retencion_Bus BusRetencion = new cp_retencion_Bus();
                                    if (BusRetencion.Generacion_xml_SRI(Info_Retencion.IdEmpresa, Info_Retencion.IdRetencion, ref msg))
                                    {
                                        MessageBox.Show("Generacion de XML Ok.", param.Nombre_sistema, MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se Genero el XML " + msg, param.Nombre_sistema, MessageBoxButtons.OK);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                        MessageBox.Show("No se pudo Modificar la Factura Proveedor ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        res = false;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;
                txt_observacion.Focus();

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    respuesta = Grabar();
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    respuesta = Modificar();
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado)
                {
                    respuesta = Modificar_proceso_cerrado();
                }
                return respuesta;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }

        void Anular_Retencion()
        {
            try
            {

                if (MessageBox.Show("¿Está seguro que desea anular la Factura # " + Info_OrdenGiro.IdCbteCble_Ogiro + " ?", "Anulación de Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                    motiAnulacion = fr.motivoAnulacion;
                }


                Info_OrdenGiro.MotivoAnu = motiAnulacion;
                Info_OrdenGiro.IdTipoCbte_Anulacion = IdTipoCbteRev;
                Info_OrdenGiro.IdUsuarioUltAnu = param.IdUsuario;
                Info_OrdenGiro.Fecha_UltAnu = param.Fecha_Transac;


                if (ordenGiro_B.AnularFacturaProveedor(Info_OrdenGiro, LstImportacionOC, ref IdCbteCbleRev, ref msg2))
                {
                    string smensaje = string.Format("{0} # {1} se anuló con éxito.", "Factura Proveedor", txt_NOrdeG.Text);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    lblanulado.Visible = true;
                    lblanulado.Text = "*ANULADO* Con TipCbt:" + IdTipoCbteRev + " y #CbtCble:" + IdCbteCbleRev;
                    Info_OrdenGiro.Estado = "I";

                    uCMenu.Enabled_bntAnular = false;
                }
                else
                {
                    MessageBox.Show("No se pudo Anular la Factura Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    res = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Anular()
        {

            try
            {
                if (Info_OrdenGiro.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular la Factura Proveedor " + Info_OrdenGiro.IdCbteCble_Ogiro + " ?", "Anulación Factura Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cp_parametros_Info parametro = new cp_parametros_Info(); cp_parametros_Bus busParam = new cp_parametros_Bus();

                        parametro = busParam.Get_Info_parametros(Info_OrdenGiro.IdEmpresa);
                        if (parametro == null || parametro.pa_IdTipoCbte_x_Anu_Retencion == null)
                        {
                            MessageBox.Show("Verifique que el tipo de comprobante de anulación de retención este parametrizado.",
                                param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                        }
                        else
                        {

                            cp_retencion_Bus bus_Retencio = new cp_retencion_Bus();
                            cp_retencion_Info Info_Retencion = new cp_retencion_Info();
                            Info_Retencion = bus_Retencio.Get_Info_retencion(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro);

                            string sSerieRT = "";
                            sSerieRT = Info_Retencion.serie1 + "-" + Info_Retencion.serie2;

                            if ((sSerieRT != null /*|| Info_Retencion.serie != ""*/) && (/*Info_Retencion.NumRetencion != "" || */Info_Retencion.NumRetencion != null))
                            {

                                if (MessageBox.Show("¿Está realmente seguro que desea anular la Factura Proveedor " + Info_OrdenGiro.IdCbteCble_Ogiro + " ?. Ya que Dicha Orden tiene una Retención que afectaría los registos contables", "Anulación Factura Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    Anular_Retencion();
                                    return true;
                                }
                            }

                            Anular_Retencion();
                        }
                    }
                    else
                    { MessageBox.Show("No se pudo Reversar el Comprobante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); res = false; }
                }
                else
                { MessageBox.Show("Esta Factura Proveedor ya esta Anulada...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); res = false; }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private Boolean Guardar()
        {
            Boolean res = true;
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Anular();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }
        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar(ref msg))
                {
                    Guardar();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar(ref msg))
                {
                    if (Guardar())
                        this.Close();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (paramCP_I.pa_TipoCbte_OG_anulacion == null || paramCP_I.pa_TipoCbte_OG_anulacion == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Anula la Factura Proveedor.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    Guardar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_imprimirChe_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirComprobantee()
        {
            try
            {
                // luis yanza comentado porq este reporte no esta echo en formato nuevo
                //XRpt_cp_OrdenGiro reprtOG = new XRpt_cp_OrdenGiro(param.IdUsuario);
                Parameter reprtOG_Parametro = new Parameter();
                cp_orden_giro_Bus ob = new cp_orden_giro_Bus();
                List<cp_orden_giro_Info> lOg = new List<cp_orden_giro_Info>();
                lOg = ob.Get_List_orden_giro(param.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro);

                Imprimir_factura_x_poveedor();


                int IdEmpresa = 0;
                decimal IdProveedor = 0;
                decimal IdCbteCble_Ogiro = 0;

                IdEmpresa = param.IdEmpresa;


                InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();
                if (InfoProveedor != null)
                {

                    IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;

                }
                else
                {
                    IdProveedor = Info_OrdenGiro.IdProveedor;

                }

                IdCbteCble_Ogiro = Convert.ToDecimal(txt_NOrdeG.Text);

                if (MessageBox.Show("Desea Imprimir el Comprobante de Diario Factura Proveedor", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XCONTA_Rpt003_rpt reporte1 = new XCONTA_Rpt003_rpt();
                    reporte1.set_parametros(IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro);
                    reporte1.RequestParameters = true;
                    reporte1.ShowPreviewDialog();
                }

                if (ucCp_Retencion1.Get_BindingList().Count != 0)
                {
                    if (MessageBox.Show("Desea Imprimir el Comprobante de Diario de Retención", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //ingreso deuda
                        XCXP_Rpt004_Rpt reporte = new XCXP_Rpt004_Rpt();

                        reporte.set_parametros(IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, IdCbteCble_Ogiro);
                        reporte.RequestParameters = true;

                        reporte.ShowPreviewDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir_Retencion()
        {
            try
            {
                cp_orden_giro_Bus ob = new cp_orden_giro_Bus();
                List<cp_orden_giro_Info> lOg = new List<cp_orden_giro_Info>();
                lOg = ob.Get_List_orden_giro(param.IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro);
                fr = new frmCP_ImprimirRetencion();

                fr.set_numRetencion(Convert.ToString(ucCp_Retencion1.Get_Info_Talonario().Establecimiento + "-" + ucCp_Retencion1.Get_Info_Talonario().PuntoEmision), ucCp_Retencion1.Get_Info_Talonario().NumDocumento,
                    lOg.ToArray(),
               Info_Retencion.IdRetencion, paramCP_I.pa_TipoCbte_OG, ucCp_Retencion1.Get_Info_Talonario().CodDocumentoTipo);


                fr.ShowDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_plazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, txt_plazo.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_observacion_TextChanged(object sender, EventArgs e)
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

        private void dtp_fechaOG_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtp_fecha_contabilizacion.Value = dtp_fechaOG.Value;

                if (Ejecutar_Evento == true)
                {
                    ucCp_Retencion1.dtp_fechaEmisionRetencion.Value = dtp_fechaOG.Value;

                    //dtp_fechaFactura.Value = dtp_fechaOG.Value;
                    //dtp_FechaVcto.Value = dtp_fechaOG.Value;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_retManual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ucCp_Retencion1.dtp_fechaEmisionRetencion.Value = dtp_fechaOG.Value;

                if (chk_TieneRetencion.Checked == true)
                {

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                        {
                            if (ucCp_Proveedor1.get_ProveedorInfo().pr_contribuyenteEspecial == "S")
                            {
                                MessageBox.Show("El Proveedor: " + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre + " es Contribuyente Especial", param.Nombre_sistema);
                            }
                        }

                    }

                    ucCp_Retencion1.Visible_GridRetencion(true);

                    tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
                    info_sucursal = lst_sucursal.FirstOrDefault(q => q.IdSucursal == param.IdSucursal);
                    ucCp_Retencion1.Get_Primer_Documento_no_usado(param.IdEmpresa, info_sucursal.Su_CodigoEstablecimiento, "001");

                    ucCp_Retencion1.set_Valores(Convert.ToDouble(Math.Round(Convert.ToDecimal(txtIVA5.EditValue), 2)), Convert.ToDouble(Math.Round(Convert.ToDecimal(txtIVA15.EditValue), 2, MidpointRounding.AwayFromZero)));

                    InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();

                    if (InfoProveedor != null)
                    {
                        ucCp_Retencion1.set_Datos_Proveedor(InfoProveedor.IdCtaCble_CXP, InfoProveedor.pr_nombre, Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion));
                        ucCp_Retencion1.carga_codigoSRI_x_Proveedor(param.IdEmpresa, InfoProveedor.IdProveedor);
                    }

                    CalculoRetencion();
                }
                else
                {
                    ucCp_Retencion1.LimpiarGrid_Retencion();
                    ucCp_Retencion1.Visible_GridRetencion(false);

                    CalculoRetencion();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_MantOrdenGiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmCP_MantOrdenGiro_FormClosing(sender, e, Info_OrdenGiro);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        decimal reembolso_IdProveedor;

        private void cmb_Local_Exterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Local_Exterios.SelectedIndex == 0)
                {
                    label49.Visible = false;

                    cmbPais.Visible = false;
                    grupo_convenioDobleTributacion.Visible = false;
                    grupo_PagoSujetoRetencion.Visible = false;
                }
                else
                {
                    label49.Visible = true;

                    cmbPais.Visible = true;
                    grupo_convenioDobleTributacion.Visible = true;
                    grupo_PagoSujetoRetencion.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_fechaFactura_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Ejecutar_Evento == true)
                {

                    if (resp == true)
                    {
                        {
                            if (txt_plazo.Text != "")
                            {
                                int dias = Convert.ToInt32(txt_plazo.Text);
                                resp_2 = false;
                                dtp_FechaVcto.Value = Convert.ToDateTime(dtp_fechaOG.Value).Date.AddDays(dias);
                                resp_2 = true;

                            }
                        }

                    }
                    else
                    { return; }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbTipoDocu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    cp_TipoDocumento_Info item = new cp_TipoDocumento_Info();

                    item = (cp_TipoDocumento_Info)cmbTipoDocu.Properties.View.GetFocusedRow();

                    if (item != null)
                    {

                        txeNumDocum.EditValue = "";

                        if (item.DeclaraSRI == "N")
                        {

                            txeNumDocum.EditValue = ordenGiro_B.GetNDocumentoXTipo(item.CodTipoDocumento, param.IdEmpresa).ToString();
                        }

                        //PARA VALIDAR RETENCION SI GENERA O NO
                        if (item.GeneraRetencion != "S")
                        {
                            //chk_retManual.Checked = false;
                            deshabilitarCamposRet();
                            CalculaTotales();
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


        private void txeNumDocum_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txeNumDocum.Text == "")
                {
                    return;
                }

                NumDoc = Convert.ToDecimal(txeNumDocum.Text);
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    if (cmbTipoDocu.EditValue == null || cmbTipoDocu.EditValue == "")
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar Tipo de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txeNumDocum.EditValue = "";
                        cmbTipoDocu.Focus();
                        return;
                    }


                    if (InfoProveedor == null)
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txeNumDocum.EditValue = "";

                        return;
                    }

                    string msg = "";


                    if (ordenGiro_B.VericarNumDocumento(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, Convert.ToString(cmbTipoDocu.EditValue), txeSerie.Text, Convert.ToString(txeNumDocum.EditValue), ref msg) == true)
                    {
                        MessageBox.Show("Ya existe dicho #Documento registrado en la Factura Proveedor #: " + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txeNumDocum.Focus();
                    }
                    if (chk_Cbte_Electronico.Checked == false)
                    {
                        if (Autori_bus.Get_List_proveedor_Autorizacion(param.IdEmpresa, InfoProveedor.IdProveedor, NumAutoriza, Establecimiento, Pto_Emision, NumDoc).Count() == 0)
                        {
                            MessageBox.Show("El documento ingresado no pertenece a esa autorización" + msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txeIdNumAutoriza.Text = "0000000000";
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

        private void dtp_FechaVcto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Ejecutar_Evento == true)
                {

                    if (resp == true)
                    {
                        //No necesita un evento
                    }

                    else
                    { return; }

                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_plazo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (resp_2 == false)
                {
                    return;
                }
                else
                {
                    if (txt_plazo.Text != "")
                    {
                        resp = false;
                        dtp_FechaVcto.Value = dtp_fechaFactura.Value.AddDays(Convert.ToInt32(txt_plazo.Text));
                        resp = true;
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_idtCredito_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular || _Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    return;
                }

                cmbTipoDocu.EditValue = null;
                if (InfoProveedor != null)
                {
                    if (InfoProveedor.Persona_Info.IdTipoDocumento != null)
                    {
                        if (!String.IsNullOrEmpty(Convert.ToString(cmb_idtCredito.EditValue)))
                        {


                            cp_codigo_SRI_Info info = ListCodigoSRI.FirstOrDefault(v => v.IdCodigo_SRI == Convert.ToInt32(cmb_idtCredito.EditValue));

                            List<cp_TipoDocumento_Info> lst = new List<cp_TipoDocumento_Info>();

                            if (info != null)
                                if (info.codigoSRI != null)
                                    foreach (var item in LstTipDoc)
                                    {
                                        if (item.CodSRI == "03")
                                        {
                                            item.CodSRI = item.CodSRI;
                                        }

                                        if (item.Sustento_Tributario != null)
                                        {
                                            string[] arreglo = item.Sustento_Tributario.Split(',');

                                            for (int i = 0; i < arreglo.Length; i++)
                                            {
                                                arreglo[i] = arreglo[i].Trim();

                                                if (arreglo[i] == info.codigoSRI)
                                                {


                                                    string secuencial = "";
                                                    if (InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "RUC")
                                                        secuencial = "01";
                                                    else if (InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "CED")
                                                        secuencial = "02";
                                                    else
                                                        secuencial = "03";

                                                    string[] arregloSecuenci = item.Codigo_Secuenciales_Transaccion.Split(',');
                                                    for (int ise = 0; ise < arregloSecuenci.Length; ise++)
                                                    {
                                                        arregloSecuenci[ise] = arregloSecuenci[ise].Trim();
                                                        if (arregloSecuenci[ise] == secuencial)
                                                        {
                                                            lst.Add(item);
                                                            ise = arregloSecuenci.Length;
                                                            i = arreglo.Length;
                                                        }
                                                    }

                                                }
                                            }
                                        }

                                    }

                            cmbTipoDocu.Properties.DataSource = lst;
                        }
                    }
                    else

                        MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else

                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_idtCredito_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(Convert.ToString(cmb_idtCredito.EditValue)))
                    cmb_idtCredito.EditValue = "";
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txeNumDocum_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //validar secuencial factura
                string secuencia_aux = "";
                string secuencia = "";

                if (!String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    if (Convert.ToString(txeNumDocum.EditValue).Length < 9)
                    {
                        int conta = Convert.ToString(txeNumDocum.EditValue).Length;
                        int diferencia = 9 - conta;

                        secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                        secuencia = secuencia_aux + txeNumDocum.EditValue;

                        txeNumDocum.EditValue = secuencia;
                    }

                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Autoriza_Click(object sender, EventArgs e)
        {
            try
            {

                if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                {
                    frmCP_AutorizacionProveedor ofrm = new frmCP_AutorizacionProveedor(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);

                    ofrm.ShowDialog();

                    cp_proveedor_Autorizacion_Info autori_I = new cp_proveedor_Autorizacion_Info();

                    autori_I = ofrm.OtroFrm_Aut_I;

                    if (autori_I != null)
                    {
                        NumAutoriza = autori_I.nAutorizacion;
                        Establecimiento = autori_I.Serie1;
                        Pto_Emision = autori_I.Serie2;

                        txeIdNumAutoriza.EditValue = autori_I.nAutorizacion;
                        txeSerie.EditValue = autori_I.Serie1 + "-" + autori_I.Serie2;
                        //txt_valido_hasta.Text = autori_I.Valido_Hasta.ToShortDateString();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Proveedor", param.Nombre_sistema);

                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Importar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                chk_Cbte_Electronico.Checked = true;
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {

                        string path = "";
                        path = openFileDialog1.FileName;

                        factura InfoFactura_SRI = new factura();

                        string numAutoriza = "";
                        DateTime fechAutoriza = new DateTime();

                        tb_Proceso_SRI_Bus bus_proSri = new tb_Proceso_SRI_Bus();
                        string mensaje = "";
                        InfoFactura_SRI = bus_proSri.Deserializar_factura_SRI(path, ref numAutoriza, ref fechAutoriza, ref mensaje);

                        if (InfoFactura_SRI != null)
                        {

                            //llenado de campos

                            if (InfoFactura_SRI.infoTributaria != null)
                            {





                                string Ruc_Proveedor = InfoFactura_SRI.infoTributaria.ruc;
                                cp_proveedor_Bus BusProvee = new cp_proveedor_Bus();
                                cp_proveedor_Info ProveeInfo_ = new cp_proveedor_Info();
                                ProveeInfo_ = BusProvee.Get_Info_Proveedor(param.IdEmpresa, Ruc_Proveedor);

                                if (ProveeInfo_ != null)
                                {
                                    if (ProveeInfo_.IdProveedor != 0)
                                    {
                                        ucCp_Proveedor1.set_ProveedorInfo(ProveeInfo_.IdProveedor);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No existe un proveedor con este RUC q se encuentra en el xml Subido .. verifique \n\n" + "[" + Ruc_Proveedor + "]" + InfoFactura_SRI.infoTributaria.razonSocial, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No existe un proveedor con este RUC q se encuentra en el xml Subido .. verifique \n\n" + "[" + Ruc_Proveedor + "]" + InfoFactura_SRI.infoTributaria.razonSocial, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                cmbTipoDocu.EditValue = InfoFactura_SRI.infoFactura.tipoIdentificacionComprador;



                                decimal sum_base_12 = 0;
                                decimal sum_base_0 = 0;

                                decimal sum_base_2 = 0;
                                decimal sum_base = 0;

                                decimal sum_base_12_tot = 0;
                                decimal sum_base_0_tot = 0;

                                decimal sum_valor_iva_12 = 0;


                                foreach (var item in InfoFactura_SRI.detalles)
                                {
                                    decimal base_12 = 0;
                                    decimal base_0 = 0;
                                    decimal valor_ice = 0;

                                    int conta12 = 0;
                                    int conta0 = 0;

                                    foreach (var item2 in item.impuestos)
                                    {

                                        if (item2.codigo.Trim() == "2")
                                        {
                                            //  base_12 = 0;
                                            if (item2.codigoPorcentaje.Trim() == "2" || item2.codigoPorcentaje.Trim() == "3" || item2.codigoPorcentaje.Trim() == "4")  // IVA12, IVA14, IVA15
                                            {
                                                sum_valor_iva_12 = sum_valor_iva_12 + item2.valor;
                                            }
                                        }

                                        int cod_3 = item.impuestos.Count(q => q.codigo == "3");

                                        if (cod_3 >= 1)
                                        {
                                            //impuesto iva 2
                                            if (item2.codigo == "2")
                                            {
                                                //  base_12 = 0;
                                                if (item2.codigoPorcentaje == "2")  // IVA12
                                                {
                                                    base_12 = item2.baseImponible;
                                                    conta12 = 1;
                                                    sum_base_2 = sum_base_2 + base_12;
                                                }
                                                //  base_0 = 0;
                                                if (item2.codigoPorcentaje == "0") // IVA0 
                                                {
                                                    base_0 = item2.baseImponible;
                                                    conta0 = 1;
                                                    sum_base = sum_base + base_0;

                                                    //  valor_ice_0 = item2.valor;
                                                }
                                                if (item2.codigoPorcentaje == "3")  // IVA14
                                                {
                                                    base_12 = item2.baseImponible;
                                                    conta12 = 1;
                                                    sum_base_2 = sum_base_2 + base_12;
                                                }
                                                if (item2.codigoPorcentaje == "4")  // IVA15
                                                {
                                                    base_12 = item2.baseImponible;
                                                    conta12 = 1;
                                                    sum_base_2 = sum_base_2 + base_12;
                                                }
                                            }

                                        }
                                        else
                                        {
                                            //impuesto iva 2
                                            if (item2.codigo.Trim() == "2")
                                            {
                                                //  base_12 = 0;
                                                if (item2.codigoPorcentaje.Trim() == "2" || item2.codigoPorcentaje.Trim() == "3" || item2.codigoPorcentaje.Trim() == "4")  // IVA12, IVA14, IVA15
                                                {
                                                    base_12 = item2.baseImponible;
                                                    sum_base_2 = sum_base_2 + base_12;
                                                }
                                                //  base_0 = 0;
                                                if (item2.codigoPorcentaje.Trim() == "0") // iva 0%
                                                {
                                                    base_0 = item2.baseImponible;
                                                    sum_base = sum_base + base_0;
                                                }
                                            }
                                        }
                                    }

                                    sum_base_12_tot = sum_base_12 + sum_base_2;
                                    sum_base_0_tot = sum_base_0 + sum_base;

                                }     // for detalle

                                txtSubtotalIVA15.EditValue = sum_base_12_tot;
                                txtSubtotalIVA0.EditValue = sum_base_0_tot;
                                txtIVA15.EditValue = sum_valor_iva_12;

                                decimal sum_base_3 = 0;
                                decimal sum_valor_3 = 0;
                                decimal sum_cod_5 = 0;

                                foreach (var item in InfoFactura_SRI.infoFactura.totalConImpuestos)
                                {
                                    if (item.codigo.Trim() == "3")
                                    {
                                        sum_base_3 = sum_base_3 + item.baseImponible;
                                        sum_valor_3 = sum_valor_3 + item.valor;
                                    }

                                    if (item.codigo.Trim() == "5")
                                    {
                                        sum_cod_5 = sum_cod_5 + item.valor;
                                    }
                                }

                                txtIVA5.EditValue = InfoFactura_SRI.infoFactura.totalSinImpuestos;
                                txtValorAPagar.EditValue = InfoFactura_SRI.infoFactura.importeTotal;
                                txeSerie.EditValue = InfoFactura_SRI.infoTributaria.estab + "-" + InfoFactura_SRI.infoTributaria.ptoEmi;
                                txeNumDocum.EditValue = InfoFactura_SRI.infoTributaria.secuencial;
                                dtp_fechaFactura.Value = Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision).Date;
                                dtp_FechaVcto.Value = Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision).Date;
                                dtp_fecha_contabilizacion.Value = Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision).Date;
                                txt_plazo.Text = "0";

                                dtp_fechaOG.Value = Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision).Date;
                                txeIdNumAutoriza.EditValue = numAutoriza;

                                GeneraDiario();

                                MessageBox.Show("XML Importado Satisfactoriamente");
                            }
                            else
                            {
                                MessageBox.Show("Error al Importar XML Error de Formato o Estructura .........\n\n\n " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al Importar XML : " + mensaje);
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

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion(_Accion);
                txt_NOrdeG.Text = "";
                UC_Diario_x_cxp.LimpiarGrid();
                dtp_fechaOG.Value = DateTime.Now;
                cmb_idtCredito.EditValue = null;
                cmbTipoDocu.EditValue = null;
                txt_observacion.Text = "";
                dtp_fechaFactura.Value = DateTime.Now;
                dtp_FechaVcto.Value = DateTime.Now;
                txeIdNumAutoriza.EditValue = null;
                txeSerie.EditValue = null;
                txeSerie.EditValue = null;
                txt_plazo.Text = "0";
                chk_coa.Checked = false;
                txtSubtotalIVA15.EditValue = null;
                txtIVA15.EditValue = null;
                txtSubtotalIVA0.EditValue = null;
                ucCp_Proveedor1.set_ProveedorInfo(0);
                txtValorAPagar.EditValue = null;
                txtSaldo.EditValue = null;
                txeNumDocum.EditValue = null;
                ucCp_Retencion1.LimpiarGrid_Retencion();

                Info_OrdenGiro = new cp_orden_giro_Info();
                CbteCble_I = new ct_Cbtecble_Info();
                _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
                lst_reembolso = new List<cp_reembolso_Info>();
                Info_Retencion = new cp_retencion_Info();
                Info_CbteCble_x_Ret = new ct_Cbtecble_Info();
                _ListaRetencionOld = new List<cp_retencion_det_Info>();
                LstImportacionOC = new List<cp_orden_giro_x_com_ordencompra_local_Info>();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCMenu_event_btn_Imprimir_Cbte_Click(object sender, EventArgs e)
        {
            try
            {
                btn_imprimirChe_Click(sender, e);
            }
            catch (Exception ex)
            {


            }
        }

        private void uCMenu_event_btn_Imprimir_Reten_Click(object sender, EventArgs e)
        {

        }

        private void uCMenu_event_btnImprimir_Click_1(object sender, EventArgs e)
        {

        }

        private void AplicaCalculoRetencion()
        {
            try
            {
                if (ucCp_Proveedor1.cmb_proveedor.EditValue == null) return;

                if (chk_TieneRetencion.Checked == true)
                {
                    ucCp_Retencion1.set_Datos_Proveedor(InfoProveedor.IdCtaCble_CXP, InfoProveedor.pr_nombre, Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion));
                    ucCp_Retencion1.set_Valores(Convert.ToDouble(txtIVA5.EditValue), Convert.ToDouble(txtIVA15.EditValue));

                    cp_proveedor_Info info_Proveedor = new cp_proveedor_Info();
                    info_Proveedor = ucCp_Proveedor1.get_ProveedorInfo();

                    if (info_Proveedor != null)
                    {
                        ucCp_Retencion1.carga_codigoSRI_x_Proveedor(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                    }

                    CalculoRetencion();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_fecha_contabilizacion_ValueChanged(object sender, EventArgs e)
        {
            if (Ejecutar_Evento == true)
            {
                if (resp == true)
                {
                    ucCp_Retencion1.dtp_fechaEmisionRetencion.Value = dtp_fecha_contabilizacion.Value;
                }
                else
                    return; 

            }
        }

        private bool _isCalculating = false;

        private void gridViewOrdenGiroCuentas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (_isCalculating) return;

            try
            {
                cp_orden_giro_det_Info row = gridViewOrdenGiroCuentas.GetFocusedRow() as cp_orden_giro_det_Info;
                if (row == null) return;

                if (e.Column == colOGCantidad || e.Column == colOGValorUnit ||
                    e.Column == colOGICE || e.Column == colOGPorcDesc)
                {
                    _isCalculating = true;

                    decimal cantidad = row.Cantidad;
                    decimal valorUnit = row.ValorUnit;
                    decimal porcDescuento = row.PorcDescuento;

                    var impuestoIVA = ListImpuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto_IVA);
                    var impuestoICE = ListImpuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto_ICE);

                    decimal porcentajeIVA = impuestoIVA != null ? Convert.ToDecimal(impuestoIVA.porcentaje) : 0;
                    decimal porcentajeICE = impuestoICE != null ? Convert.ToDecimal(impuestoICE.porcentaje) : 0;

                    decimal subtotalSinImpuesto = cantidad * valorUnit;
                    decimal valorDescuento = subtotalSinImpuesto * (porcDescuento / 100m);
                    decimal baseImponible = subtotalSinImpuesto - valorDescuento;

                    decimal valorIVA = baseImponible * (porcentajeIVA / 100m);
                    decimal valorICE = baseImponible * (porcentajeICE / 100m);
                    decimal subtotal = baseImponible + valorIVA + valorICE;

                    // Actualizar valores en el grid
                    gridViewOrdenGiroCuentas.SetFocusedRowCellValue(colOGDescuento, valorDescuento);
                    gridViewOrdenGiroCuentas.SetFocusedRowCellValue(colOGSubtotal, subtotal);

                    CalcularTotalesGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isCalculating = false;
            }
        }

        private void CalcularTotalesGrid()
        {
            try
            {
                decimal SubtotalIVA15 = 0;
                decimal SubtotalIVA5 = 0;
                decimal SubtotalIVA0 = 0;
                decimal TotalIVA15 = 0;
                decimal TotalIVA5 = 0;
                decimal TotalIVA0 = 0;
                decimal TotalICE = 0;
                decimal TotalDescuento = 0;

                foreach (var item in BindingListOrdenGiroDet)
                {
                    decimal cantidad = item.Cantidad;
                    decimal valorUnit = item.ValorUnit;
                    decimal porcDescuento = item.PorcDescuento;

                    var impuestoIVA = ListImpuesto.FirstOrDefault(q => q.IdCod_Impuesto == item.IdCod_Impuesto_IVA);
                    var impuestoICE = ListImpuesto.FirstOrDefault(q => q.IdCod_Impuesto == item.IdCod_Impuesto_ICE);

                    decimal porcentajeIVA = impuestoIVA != null ? Convert.ToDecimal(impuestoIVA.porcentaje) : 0;
                    decimal porcentajeICE = impuestoICE != null ? Convert.ToDecimal(impuestoICE.porcentaje) : 0;

                    decimal subtotalSinImpuesto = cantidad * valorUnit;
                    decimal valorDescuento = subtotalSinImpuesto * (porcDescuento / 100m);
                    decimal baseImponible = subtotalSinImpuesto - valorDescuento;

                    decimal valorIVA = baseImponible * (porcentajeIVA / 100m);
                    decimal valorICE = baseImponible * (porcentajeICE / 100m);
                    decimal subtotal = baseImponible + valorIVA + valorICE;

                    switch (impuestoIVA?.porcentaje)
                    {
                        case 15:
                            TotalIVA15 += valorIVA;
                            SubtotalIVA15 += subtotal;
                            break;
                        case 5:
                            TotalIVA5 += valorIVA;
                            SubtotalIVA5 += subtotal;
                            break;
                        case 0:
                            TotalIVA0 += valorIVA;
                            SubtotalIVA0 += subtotal;
                            break;
                        default:

                            break;
                    }

                    TotalICE += valorICE;
                    TotalDescuento += valorDescuento;
                }

                txtSubtotalIVA15.EditValue = SubtotalIVA15;
                txtSubtotalIVA5.EditValue = SubtotalIVA5;
                txtSubtotalIVA0.EditValue = SubtotalIVA0;
                txtDescuento.EditValue = TotalDescuento;
                txtIVA15.EditValue = TotalIVA15;
                txtIVA5.EditValue = TotalIVA5;
                txtICE.EditValue = TotalICE;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenGiroCuentas_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            // Establecer valores por defecto en la nueva fila
            //view.SetRowCellValue(e.RowHandle, colOGCantidad, 1);
            //view.SetRowCellValue(e.RowHandle, colOGValorUnit, 0m);
            //view.SetRowCellValue(e.RowHandle, colOGPorcDesc, 0m);
            //view.SetRowCellValue(e.RowHandle, colOGICE, 0m);
            //view.SetRowCellValue(e.RowHandle, colOGSubtotal, 0m);
            //view.SetRowCellValue(e.RowHandle, colOGDescuento, 0m);

            // Si tienes objetos por defecto como tipo de impuesto:
            view.SetRowCellValue(e.RowHandle, "IdCod_Impuesto_IVA", "IVA15");
            view.SetRowCellValue(e.RowHandle, "IdCod_Impuesto_ICE", "ICE0");
        }

        private void txtTotal_EditValueChanged(object sender, EventArgs e)
        {
            if (Diario_generado)
            {
                if (MessageBox.Show("Un valor ha sido modificado, ¿Desea generar el diario de la transacción nuevamente?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            
            GeneraDiario();
            CalculoRetencion();
        }


        private void ucCp_Retencion1_event_delegate_gridView_SRI_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                CalculoRetencion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtSubtotalIVA15_EditValueChanged(object sender, EventArgs e)
        {
            CalculaTotales();
        }

        private void txtSubtotalIVA5_EditValueChanged(object sender, EventArgs e)
        {
            CalculaTotales();
        }


        private void txE_SubTotal0_EditValueChanged(object sender, EventArgs e)
        {
            CalculaTotales();
        }

        private void txtDescuento_EditValueChanged(object sender, EventArgs e)
        {
            CalculaTotales();
        }

        private void txtIVA15_EditValueChanged(object sender, EventArgs e)
        {
            CalculaTotales();
        }

        private void txtIVA5_EditValueChanged(object sender, EventArgs e)
        {
            CalculaTotales();
        }

        private void txtICE_EditValueChanged(object sender, EventArgs e)
        {
            CalculaTotales();
        }
    }
}