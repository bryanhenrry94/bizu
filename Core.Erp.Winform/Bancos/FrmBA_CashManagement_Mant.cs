using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Reportes.Bancos;
using Core.Erp.Winform.CuentasxPagar;
using System.IO;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_CashManagement_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region declaracion de variables
                
        List<tb_banco_Info> List_Banco = new List<tb_banco_Info>();               
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> List_CbteBan_x_CbteCble_Tipo = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        List<ct_Cbtecble_det_Info> List_CbteCble_det = new List<ct_Cbtecble_det_Info>();        
        List<cp_orden_pago_cancelaciones_Info> List_OrdenPago_Cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
        BindingList<vwba_Banco_Movimiento_det_cancelado_Info> BindingList_Movimiento_det_cancelado = new BindingList<vwba_Banco_Movimiento_det_cancelado_Info>();
        BindingList<vwcp_orden_pago_con_cancelacion_Info> BindingList_OrdenPapo_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();        
        
        cp_proveedor_Info Info_Proveedor = new cp_proveedor_Info();        
        tb_banco_procesos_bancarios_x_empresa_Info Info_ProcesoBancario = new tb_banco_procesos_bancarios_x_empresa_Info();        
        ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();
        ct_Cbtecble_Info Info_CbteCble = new ct_Cbtecble_Info();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info Info_Param_Banco = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();        
        ba_Cbte_Ban_Info Info_CbteBan = new ba_Cbte_Ban_Info();
        ba_Banco_Cuenta_Info Info_BancoCuenta = new ba_Banco_Cuenta_Info();        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwtb_persona_beneficiario_Info Info_Beneficiario = new vwtb_persona_beneficiario_Info();        

        cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();        
        ba_parametros_Bus Bus_Paramentros = new ba_parametros_Bus();
        ba_Banco_Cuenta_Bus Bus_BancoCuenta = new ba_Banco_Cuenta_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus Bus_CbteBan_x_CbteCble_tipo = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_Bus Bus_CbteBan = new ba_Cbte_Ban_Bus();                
        ct_Periodo_Bus Bus_Periodo = new ct_Periodo_Bus();        
        ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();                
        vwcp_orden_pago_con_cancelacion_Bus Bus_vwOrden_Pago_con_cancelacion = new vwcp_orden_pago_con_cancelacion_Bus();
        cp_orden_pago_cancelaciones_Bus Bus_Orden_Pago_con_cancelacion = new cp_orden_pago_cancelaciones_Bus();        
        tb_banco_Bus Bus_Banco = new tb_banco_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private Cl_Enumeradores.eTipo_action _Accion;

        OpenFileDialog ofdDoc;
        SaveFileDialog sfdDoc;
        byte[] readBuffer;

        string Observacion_diario = "";
        string Observacion_cbte_bancario = "";
        int IdBanco = 0;                
        string MensajeError = "";
        string referencia = "";
        decimal idCbteCble = 0;
        string cod_CbteCble = "";
        string motiAnulacion, msg2;
        int _IdTipoCbte = 0;
        int IdTipoCbteRev = 0;
        decimal IdCbteCbleRev;
        decimal IdProveedor = 0;
        int c = 0;
        string msj;        

        public delegate void delegate_frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmBA_ChequesMantenimiento_FormClosing event_frmBA_ChequesMantenimiento_FormClosing;

        #endregion

        public FrmBA_CashManagement_Mant()
        {

            try
            {
                InitializeComponent();
                event_frmBA_ChequesMantenimiento_FormClosing += FrmBA_CashManagement_Mant_event_frmBA_ChequesMantenimiento_FormClosing;

                ucBa_Proceso_x_Banco.cmb_Banco.EditValueChanged += cmb_Banco_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cmb_Banco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Info_BancoCuenta = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
                UC_DiarioContPago.IdCtaCble_x_Banco = Info_BancoCuenta.IdCtaCble;            
                tb_banco_Info info_banco = new tb_banco_Info();
                IdBanco = Info_BancoCuenta.IdBanco;
                generaDiario();
                Armar_observaciones();
            }
            catch (Exception ex)
            {
            }
        }

        void FrmBA_CashManagement_Mant_event_frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }       

        private void BloquearDatos()
        {
            try
            {
                ucBa_TipoFlujo.ReadOnly(true);                                             
            }
            catch(Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Limpiar()
        {
            try
            {
                List_OrdenPago_Cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                tb_persona_bus busPersona = new tb_persona_bus();
                Info_Periodo = Bus_Periodo.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);
                dt_fechaCbte.Value = DateTime.Now;
                txt_Ncomprobante.Text = "0";
                ucGe_Beneficiario.Enabled = true;
                UCMenu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                UCMenu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                UC_DiarioContPago.setAccion(Cl_Enumeradores.eTipo_action.grabar);                
                ucGe_Beneficiario.Inicializar_Beneficiario();

                _Accion = Cl_Enumeradores.eTipo_action.grabar;

                BindingList_OrdenPapo_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                this.gridAprobacionOrdenPago.DataSource = BindingList_OrdenPapo_con_cancelacion;

                Info_CbteCble = new ct_Cbtecble_Info();
                Info_CbteBan = new ba_Cbte_Ban_Info();                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_accion_controles()
        {
            try
            {

                UCMenu.Enabled_btnGuardar = false;
                UCMenu.Enabled_bntGuardar_y_Salir = false;
                UCMenu.Enabled_bntAnular = false;
                UCMenu.Enabled_btn_Imprimir_Cbte = false;
                UCMenu.Enabled_btn_Imprimir_Cheq = false;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        UCMenu.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
                        UCMenu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        //cmbCiudad.Text = Bus_Paramentros.Get_List_parametros(param.IdEmpresa).CiudadDefaultParaCrearCheques;

                        UCMenu.Enabled_btnGuardar = true;
                        UCMenu.Enabled_bntGuardar_y_Salir = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        UCMenu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        UCMenu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        UCMenu.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;
                        UCMenu.Enabled_btnGuardar = true;
                        UCMenu.Enabled_bntGuardar_y_Salir = true;
                        UCMenu.Enabled_btn_Imprimir_Cbte = false;
                        UCMenu.Enabled_btn_Imprimir_Cheq = false;

                        set_Info_CbteBan();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        UCMenu.Enabled_bntAnular = true;
                        UCMenu.Enabled_btn_Imprimir_Cbte = false;
                        UCMenu.Enabled_btn_Imprimir_Cheq = false;

                        set_Info_CbteBan();

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        UCMenu.Enabled_btn_Imprimir_Cbte = true;
                        UCMenu.Enabled_btn_Imprimir_Cheq = true;
                        set_Info_CbteBan();
                        break;

                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }

        }

        private void frmBA_ChequesMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                
                cargar_combo();

                Info_Param_Banco = List_CbteBan_x_CbteCble_Tipo.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "TRANS"; });
                if (Info_Param_Banco == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco.. \nIngréselos desde la pantalla de parámetros de banco, o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UCMenu.Enabled_btnGuardar = false;
                    UCMenu.Enabled_bntGuardar_y_Salir = false;
                    UCMenu.Enabled_bntAnular = false;
                    this.Close();
                }
                else
                {
                    if (Info_Param_Banco.IdTipoCbteCble <= 0 || Info_Param_Banco.IdTipoCbteCble_Anu <= 0)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. \nIngréselos desde la pantalla de parámetros de banco, o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        UCMenu.Enabled_btnGuardar = false;
                        UCMenu.Enabled_bntGuardar_y_Salir = false;
                        UCMenu.Enabled_bntAnular = false;
                        this.Close();
                    }
                }

                _IdTipoCbte = Info_Param_Banco.IdTipoCbteCble;
                IdTipoCbteRev = Info_Param_Banco.IdTipoCbteCble_Anu;

                set_accion_controles();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cargar_combo()
        {
            try
            {                
                List_CbteBan_x_CbteCble_Tipo = Bus_CbteBan_x_CbteCble_tipo.Get_List_Banco_Parametros(param.IdEmpresa);
                
                List<cp_catalogo_Info> catalogoInfoList = new List<cp_catalogo_Info>();
                cp_catalogo_Bus catalogoBus = new cp_catalogo_Bus();

                catalogoInfoList = catalogoBus.Get_List_catalogo("T_TIP_CTA_ACRE");
                
                // Cargando combo Bancos
                List_Banco = Bus_Banco.Get_List_Banco();                               
               
                //cargar combo grid
                cmb_Banco_acredicacion.DataSource = List_Banco;
                cmb_TipoCta_acreditacion.DataSource = catalogoInfoList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmBA_ChequesMantenimiento_event_frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Validar()
        {
            try
            {
                Boolean estado = true;

                Info_Periodo = Bus_Periodo.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

                if (Info_Periodo == null)
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo no se encuentra ingresado ", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    estado = false;
                    return estado;
                }

                if (Info_Periodo.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado = false;
                    return estado;
                }

                if (string.IsNullOrEmpty(txt_Concepto.Text))
                {
                    MessageBox.Show("Ingrese concepto!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Concepto.Focus();
                    estado = false;
                    return estado;
                }

                //if (ucGe_Beneficiario.Get_Persona_beneficiario_Info() == null)
                //{
                //    MessageBox.Show("Ingrese beneficiario!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    ucGe_Beneficiario.Focus();
                //    estado = false;
                //    return estado;
                //}

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (BindingList_OrdenPapo_con_cancelacion.Where(q => q.Check == true).Count() == 0)
                    {
                        if (MessageBox.Show("No ha seleccionado ordenes de pago para aplicar a este cheque.... desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        {
                            estado = false;
                            return estado;
                        }
                    }
                }
                
                // no validar para cuando anule el cheque pues sale con la fecha de hoy y el diaria a hoy
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.BAN, Convert.ToDateTime(dt_fechaCbte.Value)))
                        return false;
                }

                               
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void txt_NCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        UCMenu.Enabled_bntAnular = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        //cmbCiudad.Enabled = false;
                        //dataT_fecha.Enabled = false;
                        //txtValor.Enabled = false;
                        //txt_NCheque.Enabled = false;
                        //// txt_giracheque.Enabled = false;
                        //ucBa_TextBox_Girar_a.Inhabilitar_Beneficiario(true);
                        colCheck.OptionsColumn.AllowEdit = false;
                        //chkPostFechado.Enabled = false;
                        ucGe_Beneficiario.Enabled = false;
                        UCMenu.Enabled_bntLimpiar = false;
                        UCMenu.Enabled_bntAnular = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        UCMenu.Enabled_bntLimpiar = false;
                        UCMenu.Enabled_btnGuardar = false;
                        UCMenu.Enabled_bntGuardar_y_Salir = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        BloquearDatos();
                        UCMenu.Enabled_btnGuardar = false;
                        UCMenu.Enabled_bntGuardar_y_Salir = false;
                        UCMenu.Enabled_bntLimpiar = false;
                        UCMenu.Enabled_bntAnular = false;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Info_CbteBan(ba_Cbte_Ban_Info _infoP)
        {
            try
            {
                Info_CbteBan = _infoP;
            }
            catch (Exception ex)
            {

            }
        }

        private void set_Info_CbteBan()
        {
            try
            {
                BindingList_OrdenPapo_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();

                BindingList_Movimiento_det_cancelado = new BindingList<vwba_Banco_Movimiento_det_cancelado_Info>
                (Bus_CbteBan.Get_List_Cancelada(param.IdEmpresa, Info_CbteBan.IdCbteCble, Info_CbteBan.IdTipocbte, ref MensajeError));

                this.gridAprobacionOrdenPago.DataSource = BindingList_Movimiento_det_cancelado;
                this.txt_Ncomprobante.Text = Info_CbteBan.IdCbteCble.ToString();
                dt_fechaCbte.Value = Info_CbteBan.cb_Fecha;
                ucGe_Beneficiario.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.PROVEE, Convert.ToDecimal(Info_CbteBan.IdProveedor));                              
                txt_Concepto.Text = Info_CbteBan.cb_Observacion;
                ucBa_Proceso_x_Banco.cmb_Banco.EditValue = Info_CbteBan.IdBanco;
                ucBa_TipoFlujo.set_TipoFlujoInfo(Convert.ToDecimal(Info_CbteBan.IdTipoFlujo));                
                lblCbt_TipoAnulacion.Visible = (Info_CbteBan.Estado == "I") ? true : false;
                lblCbt_TipoAnulacion.Text = "**ANULADO**   Cbt.Cble. de Anu.: " + Info_CbteBan.IdCbteCble_Anulacion.ToString() + " Tipo Cbt.Cble de Anu.: " + Info_CbteBan.IdTipoCbte_Anulacion.ToString();
                UC_DiarioContPago.setInfo(Info_CbteBan.IdEmpresa, Info_CbteBan.IdTipocbte, Info_CbteBan.IdCbteCble);
                UC_DiarioContPago.HabilitarGrid(false);                
                Info_CbteCble = UC_DiarioContPago.Get_Info_CbteCble();                
                UCSucursal.set_SucursalInfo(Info_CbteBan.IdSucursal);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void GetDetalle_Grid()
        {
            try
            {
                int contador = 1;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    List_OrdenPago_Cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                    foreach (var item in BindingList_OrdenPapo_con_cancelacion)
                    {
                        if (item.Check == true)
                        {
                            cp_orden_pago_cancelaciones_Info info_ordenCan = new cp_orden_pago_cancelaciones_Info();
                            // Orden de cancelación
                            info_ordenCan.IdEmpresa = param.IdEmpresa;
                            info_ordenCan.IdEmpresa_op = item.IdEmpresa;
                            info_ordenCan.IdOrdenPago_op = item.IdOrdenPago;
                            info_ordenCan.Secuencia_op = item.Secuencia_OP;
                            info_ordenCan.IdEmpresa_op_padre = null;
                            info_ordenCan.IdOrdenPago_op_padre = null;
                            info_ordenCan.Secuencia_op_padre = null;
                            info_ordenCan.IdEmpresa_cxp = item.IdEmpresa_cxp;
                            info_ordenCan.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                            info_ordenCan.IdCbteCble_cxp = item.IdCbteCble_cxp;
                            info_ordenCan.IdEmpresa_pago = param.IdEmpresa;
                            info_ordenCan.IdTipoCbte_pago = Info_CbteCble.IdTipoCbte;
                            info_ordenCan.IdCbteCble_pago = Convert.ToDecimal(txt_Ncomprobante.Text);
                            info_ordenCan.MontoAplicado = item.Valor_aplicado;
                            info_ordenCan.SaldoAnterior = 0;
                            info_ordenCan.SaldoActual = 0;
                            info_ordenCan.Observacion = txt_Concepto.Text;

                            List_OrdenPago_Cancelaciones.Add(info_ordenCan);

                            contador = contador + 1;
                        }
                    }
                }
                else
                {
                    List_OrdenPago_Cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                    foreach (var item in BindingList_Movimiento_det_cancelado)
                    {
                        cp_orden_pago_cancelaciones_Info info_ordenCan = new cp_orden_pago_cancelaciones_Info();
                        // Orden de cancelación
                        info_ordenCan.IdEmpresa = param.IdEmpresa;
                        info_ordenCan.IdEmpresa_op = item.IdEmpresa;
                        info_ordenCan.IdOrdenPago_op = item.IdOrdenPago;
                        info_ordenCan.Secuencia_op = item.Secuencia_OP;
                        info_ordenCan.IdEmpresa_op_padre = null;
                        info_ordenCan.IdOrdenPago_op_padre = null;
                        info_ordenCan.Secuencia_op_padre = null;
                        info_ordenCan.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info_ordenCan.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info_ordenCan.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info_ordenCan.IdEmpresa_pago = param.IdEmpresa;
                        info_ordenCan.IdTipoCbte_pago = _IdTipoCbte;
                        info_ordenCan.IdCbteCble_pago = Convert.ToDecimal(txt_Ncomprobante.Text);
                        info_ordenCan.MontoAplicado = item.Valor_estimado_a_pagar_OP;
                        info_ordenCan.SaldoAnterior = 0;
                        info_ordenCan.SaldoActual = 0;
                        info_ordenCan.Observacion = txt_Concepto.Text;
                        info_ordenCan.Idcancelacion = item.Idcancelacion;
                        info_ordenCan.Secuencia = item.Secuencia;
                        List_OrdenPago_Cancelaciones.Add(info_ordenCan);

                        contador = contador + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public ba_Cbte_Ban_Info get_CbteBan()
        {
            try
            {
                double dValor = 0;

                dValor = BindingList_OrdenPapo_con_cancelacion.Where(q => q.Check == true).Select(q => q.Valor_a_pagar).Sum();

                Info_CbteBan.IdEmpresa = param.IdEmpresa;
                Info_CbteBan.IdTipocbte = _IdTipoCbte;
                Info_CbteBan.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                Info_CbteBan.Cod_Cbtecble = (Info_CbteBan.Cod_Cbtecble == "" || Info_CbteBan.Cod_Cbtecble == null || Info_CbteBan.Cod_Cbtecble == "0") ? cod_CbteCble : Info_CbteBan.Cod_Cbtecble;
                Info_CbteBan.IdPeriodo = Info_Periodo.IdPeriodo;
                Info_CbteBan.cb_giradoA = "";
                Info_CbteBan.IdPersona_Girado_a = null;
                if (IdBanco == 0)
                    Info_CbteBan.IdBanco = ucBa_Proceso_x_Banco.get_BaCuentaInfo().IdBanco;
                else
                    Info_CbteBan.IdBanco = IdBanco;
                Info_CbteBan.cb_Fecha = dt_fechaCbte.Value;
                Info_CbteBan.cb_Observacion = "";
                Info_CbteBan.cb_secuencia = (Info_CbteBan.cb_secuencia == 0 || Info_CbteBan.cb_secuencia == null) ? 0 : Info_CbteBan.cb_secuencia;
                Info_CbteBan.cb_Valor = dValor;

                Funciones fun = new Funciones();
                Info_CbteBan.ValorEnLetras = fun.NumeroALetras(Convert.ToString(dValor));
                Info_CbteBan.cb_Cheque = null;                
                Info_CbteBan.cb_ChequeImpreso = "N";                
                Info_CbteBan.IdProveedor = null;
                Info_CbteBan.Estado = (lblCbt_TipoAnulacion.Visible == false) ? "A" : "I";
                Info_CbteBan.cb_ciudadChq = null;
                Info_CbteBan.cb_FechaCheque = null;
                Info_CbteBan.IdUsuario = param.IdUsuario;
                Info_CbteBan.IdUsuario_Anu = param.IdUsuario;
                Info_CbteBan.FechaAnulacion = param.Fecha_Transac;
                Info_CbteBan.Fecha_Transac = param.Fecha_Transac;
                Info_CbteBan.Fecha_UltMod = param.Fecha_Transac;
                Info_CbteBan.IdUsuarioUltMod = param.IdUsuario;
                Info_CbteBan.ip = param.ip;
                Info_CbteBan.nom_pc = param.nom_pc;
                if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                {
                    Info_CbteBan.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                }
                Info_CbteBan.Por_Anticipo = "N";
                Info_CbteBan.PosFechado = null;
                Info_CbteBan.IdSucursal = UCSucursal.Get_IdSucursal();

                return Info_CbteBan;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Cbte_Ban_Info();
            }
        }

        public ct_Cbtecble_Info get_Cbtecble()
        {
            try
            {
                Info_CbteCble.IdEmpresa = param.IdEmpresa;
                Info_CbteCble.IdTipoCbte = _IdTipoCbte;
                Info_CbteCble.IdPeriodo = Info_Periodo.IdPeriodo;
                Info_CbteCble.cb_Fecha = dt_fechaCbte.Value;                
                Info_CbteCble.cb_Valor = BindingList_OrdenPapo_con_cancelacion.Where(q => q.Check == true).Select(q => q.Valor_a_pagar).Sum();
                Info_CbteCble.cb_Observacion = "Pago Cash Managment " + txt_Concepto.Text;
                Info_CbteCble.Secuencia = 0;
                Info_CbteCble.Estado = "A";
                Info_CbteCble.Anio = dt_fechaCbte.Value.Year;
                Info_CbteCble.Mes = dt_fechaCbte.Value.Month;
                Info_CbteCble.IdUsuario = param.IdUsuario;
                Info_CbteCble.IdUsuarioUltModi = param.IdUsuario;
                Info_CbteCble.cb_FechaTransac = param.Fecha_Transac;
                Info_CbteCble.cb_FechaUltModi = param.Fecha_Transac;
                Info_CbteCble.Mayorizado = "N";
                Info_CbteCble.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                Info_CbteCble._cbteCble_det_lista_info = UC_DiarioContPago.Get_Info_CbteCble()._cbteCble_det_lista_info;

                 return Info_CbteCble;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Cbtecble_Info();
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det()
        {

            try
            {
                double valor;
                List_CbteCble_det.Clear();



                return List_CbteCble_det;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ct_Cbtecble_det_Info>();
            }
        }
     
        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;
                //txt_Memo.Focus();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = Actualizar();
                        break;

                    default:
                        break;
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean Grabar()
        {
            try
            {
                Boolean respuesta = true;
                decimal idCbteCble = 0;

                if (Validar())
                {
                    get_Cbtecble();
                    
                    string msg = "";
                    if (ucBa_Proceso_x_Banco.get_BaCuentaInfo().Estado == "A")
                    {
                        //if (ucGe_Beneficiario.Get_Persona_beneficiario_Info().Estado == "A")
                        //{
                            //grbado el diario 
                            respuesta = Bus_CbteCble.GrabarDB(Info_CbteCble, ref idCbteCble, ref MensajeError);

                            if (respuesta)
                            {
                                txt_Ncomprobante.Text = idCbteCble.ToString();

                                int idEmpresa = param.IdEmpresa;                                
                                
                                GetDetalle_Grid();
                                get_CbteBan();

                                //gradando el cbte bancario 
                                respuesta = Bus_CbteBan.GrabarDB(Info_CbteBan, ref MensajeError);

                                if (respuesta)
                                {
                                    respuesta = Bus_Orden_Pago_con_cancelacion.GuardarDB(List_OrdenPago_Cancelaciones, idEmpresa, ref MensajeError);

                                    MessageBox.Show("Se guardo correctamente con el Comprobante contable #: " + txt_Ncomprobante.Text);                                   
                                }
                                else
                                {

                                    Bus_CbteCble.Eliminar(Info_CbteCble, ref msg);                                    
                                    MessageBox.Show("No se pudo Grabar el Comprobante #: " + txt_Ncomprobante.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                                   
                                    respuesta = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Grabar el Comprobante #: " + txt_Ncomprobante.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                                   
                                respuesta = false;
                            }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("El beneficiario seleccionado esta anulado.\nSeleccione un beneficiario activo para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return false;
                        //}
                    }
                    else
                    {
                        MessageBox.Show("La cuenta bancaria seleccionada esta anulada.\nSeleccione una cuenta bancaria activa para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return respuesta;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void Impresion_Cheque()
        {
            try
            {
                if (MessageBox.Show("¿Desea Imprimir el Cheque?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Info_BancoCuenta = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                            if (MessageBox.Show("¿Desea Imprimir cheque voucher [SI] ó solo cheque [NO]?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                Info_BancoCuenta.Imprimir_Solo_el_cheque = false;
                            else
                                Info_BancoCuenta.Imprimir_Solo_el_cheque = true;
                            break;
                    }

                    if (Info_BancoCuenta.Imprimir_Solo_el_cheque == true)
                        Imprimir_Comprobante_Bancario();

                    FrmBA_Cheque_Imprimir frm = new FrmBA_Cheque_Imprimir();
                    //Info_CbteBan.cb_Cheque = txt_NCheque.Text;
                    frm.set_Banco_Cuenta(Info_BancoCuenta);
                    frm.set_CbteBan_I(Info_CbteBan);
                    frm.set_CbteCble(Info_CbteCble);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean Actualizar()
        {

            try
            {

                Boolean respuesta = true;

                if (Validar())
                {
                    get_Cbtecble();
                    //txt_Memo.Focus();

                    idCbteCble = Info_CbteBan.IdCbteCble;
                    get_CbteBan();

                    respuesta = Bus_CbteBan.ModificarDB(Info_CbteBan, ref MensajeError);
                    
                    if (respuesta)
                    {
                        //MessageBox.Show("Se Modifico el Cheque #: " + txt_NCheque.Text + " correctamente con el Comprobante contable #: " + txt_Ncomprobante.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el comprobante # " + this.txt_Ncomprobante.Text + " ( " + MensajeError + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        respuesta = false;
                    }

                }

                return respuesta;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean Anular()
        {

            try
            {
                Boolean respuesta = true;
                decimal idCbteCble = 0;
                string msg = "";
                string motiAnulacion = "";

                if (Validar())
                {                    
                    get_Cbtecble();
                    //txt_Memo.Focus();

                    idCbteCble = Info_CbteBan.IdCbteCble;
                    get_CbteBan();

                    respuesta = Bus_CbteBan.ModificarDB(Info_CbteBan, ref MensajeError);


                    idCbteCble = Info_CbteBan.IdCbteCble;
                    if (MessageBox.Show("¿Está seguro que desea anular Comprobante bancario #: " + Info_CbteBan.IdCbteCble + ", \n También se procederá con la liberación de los pagos de las órdenes de giro seleccionadas", "Anulación de Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DateTime fechaAnulacion = param.Fecha_Transac;

                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        motiAnulacion = fr.motivoAnulacion;

                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                                fechaAnulacion = fr.fechaAnul;

                                if (UC_DiarioContPago.Reverso_Edehsa(IdTipoCbteRev, ref IdCbteCbleRev, ref msg, motiAnulacion, fechaAnulacion))
                                {
                                    Info_CbteBan.MotivoAnulacion = motiAnulacion;
                                    Info_CbteBan.IdUsuario_Anu = param.IdUsuario;
                                    Info_CbteBan.FechaAnulacion = fechaAnulacion;
                                    Info_CbteBan.IdTipoCbte_Anulacion = IdTipoCbteRev;
                                    Info_CbteBan.IdCbteCble_Anulacion = IdCbteCbleRev;

                                    if (Bus_CbteBan.AnularDB(Info_CbteBan, ref MensajeError))
                                    {
                                        GetDetalle_Grid();
                                        if (Bus_Orden_Pago_con_cancelacion.ModificarDB(List_OrdenPago_Cancelaciones))
                                        {

                                            MessageBox.Show("Comprobante bancario #: " + Info_CbteBan.IdCbteCble + " Anulado correctamente, Con el Tipo de Comprobante de Anulacion #" + IdTipoCbteRev + " y el Comprobante de Anulacion #: " + IdCbteCbleRev);
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo Eliminar los pagos relacionados a esta Comprobante bancario...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            respuesta = false;
                                        }


                                        lblCbt_TipoAnulacion.Visible = true;
                                        lblCbt_TipoAnulacion.Text = "**ANULADO**   Cbt.Cble. de Anu.: " + IdCbteCbleRev.ToString() + " Tipo Cbt.Cble de Anu.: " + IdTipoCbteRev.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo Anular el Comprobante bancario " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        respuesta = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Reversar el Comprobante ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    respuesta = false;
                                }
                                break;

                            default:
                                if (UC_DiarioContPago.Reverso(IdTipoCbteRev, ref IdCbteCbleRev, ref msg, motiAnulacion))
                                {
                                    Info_CbteBan.MotivoAnulacion = motiAnulacion;
                                    Info_CbteBan.IdUsuario_Anu = param.IdUsuario;
                                    Info_CbteBan.FechaAnulacion = param.Fecha_Transac;
                                    Info_CbteBan.IdTipoCbte_Anulacion = IdTipoCbteRev;
                                    Info_CbteBan.IdCbteCble_Anulacion = IdCbteCbleRev;

                                    if (Bus_CbteBan.AnularDB(Info_CbteBan, ref MensajeError))
                                    {
                                        GetDetalle_Grid();
                                        if (Bus_Orden_Pago_con_cancelacion.ModificarDB(List_OrdenPago_Cancelaciones))
                                        {

                                            MessageBox.Show("Comprobante bancario #: " + Info_CbteBan.IdCbteCble + " Anulado correctamente, Con el Tipo de Comprobante de Anulacion #" + IdTipoCbteRev + " y el Comprobante de Anulacion #: " + IdCbteCbleRev);
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo Eliminar los pagos relacionados a esta Comprobante bancario...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            respuesta = false;
                                        }


                                        lblCbt_TipoAnulacion.Visible = true;
                                        lblCbt_TipoAnulacion.Text = "**ANULADO**   Cbt.Cble. de Anu.: " + IdCbteCbleRev.ToString() + " Tipo Cbt.Cble de Anu.: " + IdTipoCbteRev.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo Anular el Comprobante bancario " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        respuesta = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Reversar el Comprobante ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    respuesta = false;
                                }
                                break;
                        }
                    }
                }

                return respuesta;
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    Limpiar();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones f = new Funciones();
                e.Handled = f.Validanumero_decimal(e.KeyChar, e.KeyChar.ToString());
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info_CbteBan.IdCbteCble > 0)
                {
                    if (Info_CbteBan.Estado == "I")
                    {
                        MessageBox.Show("El Comprobante bancario #: " + Info_CbteBan.IdCbteCble + " ya esta anulado", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        _Accion = Cl_Enumeradores.eTipo_action.Anular;
                        Anular();

                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void dt_fechaCbte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //dataT_fecha.Value = dt_fechaCbte.Value;//dt_fechaCbte.Value.AddDays(1);

                Info_Periodo = Bus_Periodo.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_imprimirChe_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info_CbteBan.IdCbteCble > 0)
                {
                    FrmBA_Cheque_Imprimir frm = new FrmBA_Cheque_Imprimir();
                    frm.set_Banco_Cuenta(Info_BancoCuenta);
                    frm.set_CbteBan_I(Info_CbteBan);
                    frm.set_CbteCble(Info_CbteCble);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Antes de continuar debe Grabar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_NCheque_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ucBa_Proceso_x_Banco.get_BaCuentaInfo().IdBanco == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txt_NCheque.Text = "";
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    Close();
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmBA_ChequesMantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ultraCmbCtaBanco_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                generaDiario(); // haber -- el deber es el de la grilla la cta cte
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                vwcp_orden_pago_con_cancelacion_Info row = (vwcp_orden_pago_con_cancelacion_Info)gridViewOP_Pendientes.GetFocusedRow();

                if (row != null)
                    if (e.HitInfo.Column != null)
                        if (e.HitInfo.Column.FieldName == "Check")
                        {
                            if (row.Check == true)
                            {
                                gridViewOP_Pendientes.SetFocusedRowCellValue(colCheck, false);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Valor_a_Cancelar_OPGrid, 0);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Saldo_x_Pagar_OP, row.Saldo_x_Pagar2);
                            }
                            else
                            {
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Valor_a_Cancelar_OPGrid, row.Saldo_x_Pagar_OP);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Saldo_x_Pagar_OP, 0);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(colCheck, true);
                                ucBa_Proceso_x_Banco.cmb_Banco.EditValue = (row.IdBanco == null) ? 0 : Convert.ToInt32(row.IdBanco);
                            }

                            txt_Ncomprobante.Focus();
                            var a = BindingList_OrdenPapo_con_cancelacion.ToList();
                            double valort = 0;

                            var q = a.LastOrDefault(var => var.Check == true);

                            if (q != null)
                            {
                                valort = a.FindAll(var => var.Check == true).Sum(var => var.Valor_aplicado);

                                //cheque = a.Last(var => var.Check == true).Girar_Cheque_a;
                                //chequeID = a.FirstOrDefault(var => var.Check == true).IdPersona;
                                //referencia = a.Last(var => var.Check == true).Referencia;
                                //decimal idpersonaGira = chequeID;
                                //string beneficiario = cheque;
                            }
                        }
                generaDiario();
                Armar_observaciones();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void generaDiario()
        {
            try
            {
                double dValorTotal = 0;

                List_CbteCble_det = new List<ct_Cbtecble_det_Info>();
                string referencs = "";

                foreach (var item in BindingList_OrdenPapo_con_cancelacion)
                {
                    if (item.Check == true)
                    {
                        ct_Cbtecble_det_Info InfoDebe = new ct_Cbtecble_det_Info();
                        InfoDebe.IdEmpresa = param.IdEmpresa;
                        InfoDebe.IdTipoCbte = _IdTipoCbte;
                        InfoDebe.IdCtaCble = item.IdCtaCble;
                        InfoDebe.dc_Valor = Convert.ToDouble(item.Valor_aplicado);
                        dValorTotal += InfoDebe.dc_Valor;
                        InfoDebe.dc_Observacion = "";
                        referencs = referencs + " " + item.Referencia.Trim();
                        List_CbteCble_det.Add(InfoDebe);
                    }
                }
                ba_Banco_Cuenta_Info InfoCuentaBancos = ucBa_Proceso_x_Banco.get_BaCuentaInfo();

                // la cuenta de bancos siempre va al haber porq sale la plata de bancos con cheque 
                ct_Cbtecble_det_Info InfoHaber = new ct_Cbtecble_det_Info();
                InfoHaber.IdEmpresa = param.IdEmpresa;
                InfoHaber.IdTipoCbte = _IdTipoCbte;

                if (InfoCuentaBancos != null)
                {
                    InfoHaber.IdCtaCble = InfoCuentaBancos.IdCtaCble;
                }

                InfoHaber.dc_Valor = dValorTotal * -1;
                InfoHaber.dc_para_conciliar = true;

                InfoHaber.dc_Observacion = "";
                List_CbteCble_det.Add(InfoHaber);

                // la comtrapartida siempre a debe 
                UC_DiarioContPago.setDetalle(List_CbteCble_det);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void dataT_fecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dataT_fecha.Value > dt_fechaCbte.Value)
                //{
                //    chkPostFechado.Checked = true;
                //}
                //else
                //{
                //    chkPostFechado.Checked = false;
                //}
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }       

        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {
        }

        private void txt_NCheque_TextChanged(object sender, EventArgs e)
        {

        }

        private void Imprimir_Comprobante_Bancario()
        {
            try
            {
                if (MessageBox.Show("¿Desea Imprimir el Comprobante?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Info_BancoCuenta = ucBa_Proceso_x_Banco.get_BaCuentaInfo();

                    XBAN_Rpt018_Rpt reporte = new XBAN_Rpt018_Rpt();
                    reporte.RequestParameters = false;
                    ReportPrintTool pt = new ReportPrintTool(reporte);
                    pt.AutoShowParametersPanel = false;
                    reporte.PIdEmpresa.Value = Info_CbteBan.IdEmpresa;
                    reporte.PIdCbteCble.Value = Info_CbteBan.IdCbteCble;
                    reporte.PIdTipo_Cbte.Value = Info_CbteBan.IdTipocbte;
                    reporte.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCMenu_event_btn_Imprimir_Cbte_Click(object sender, EventArgs e)
        {
            Imprimir_Comprobante_Bancario();
        }

        private void UCMenu_event_btn_Imprimir_Cheq_Click(object sender, EventArgs e)
        {
            Impresion_Cheque();
        }

        private void ucGe_Beneficiario_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            refrescar_listado_op();
        }

        private void ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Info_BancoCuenta = ucBa_Proceso_x_Banco.get_BaCuentaInfo();

                UC_DiarioContPago.IdCtaCble_x_Banco = Info_BancoCuenta.IdCtaCble;

                string msg = "";

                ba_Talonario_cheques_x_banco_Bus busTalChe = new ba_Talonario_cheques_x_banco_Bus();
                ba_Talonario_cheques_x_banco_Info InfoCheq = new ba_Talonario_cheques_x_banco_Info();
                if (Info_BancoCuenta != null)
                {
                    InfoCheq = busTalChe.Get_Info_Ultimo_cheq_no_usuado(param.IdEmpresa, Info_BancoCuenta.IdBanco, ref msg);
                    if (InfoCheq.Num_cheque == null)
                    {
                        //txt_NCheque.Text = "";
                        MessageBox.Show("Talonario no tiene cheques, favor no olvide ingresarlos en el modulo de talonarios, puede continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //txt_NCheque.MaxLength = InfoCheq.Num_cheque.Length;
                        //txt_NCheque.Text = InfoCheq.Num_cheque;
                    }
                }
                IdBanco = Info_BancoCuenta.IdBanco;

                generaDiario();
                Armar_observaciones();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucBa_TextBox_Girar_a_Load(object sender, EventArgs e)
        {

        }

        private void chk_Seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Check_visibles();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Check_visibles()
        {
            try
            {
                if (chk_Seleccionar_visibles.Checked)
                {
                    for (int i = 0; i < gridViewOP_Pendientes.RowCount; i++)
                    {
                        vwcp_orden_pago_con_cancelacion_Info row = (vwcp_orden_pago_con_cancelacion_Info)gridViewOP_Pendientes.GetRow(i);
                        if (row != null)
                        {
                            if (!row.Check)
                            {
                                gridViewOP_Pendientes.SetRowCellValue(i, colCheck, true);
                                gridViewOP_Pendientes.SetRowCellValue(i, Valor_a_Cancelar_OPGrid, row.Saldo_x_Pagar_OP);
                                gridViewOP_Pendientes.SetRowCellValue(i, Saldo_x_Pagar_OP, 0);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < gridViewOP_Pendientes.RowCount; i++)
                    {
                        vwcp_orden_pago_con_cancelacion_Info row = (vwcp_orden_pago_con_cancelacion_Info)gridViewOP_Pendientes.GetRow(i);
                        if (row != null)
                        {
                            if (row.Check)
                            {
                                gridViewOP_Pendientes.SetRowCellValue(i, colCheck, false);
                                gridViewOP_Pendientes.SetRowCellValue(i, Valor_a_Cancelar_OPGrid, 0);
                                gridViewOP_Pendientes.SetRowCellValue(i, Saldo_x_Pagar_OP, row.Saldo_x_Pagar2);
                                
                            }
                        }
                    }
                }

                txt_Ncomprobante.Focus();
                var a = BindingList_OrdenPapo_con_cancelacion.ToList();
                double valort = 0;

                var q = a.LastOrDefault(var => var.Check == true);

                if (q != null)
                {
                    valort = a.FindAll(var => var.Check == true).Sum(var => var.Valor_aplicado);                   
                }

                generaDiario();
                Armar_observaciones();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Armar_observaciones()
        {
            try
            {
                if (ucGe_Beneficiario.Get_Persona_beneficiario_Info() != null)
                {
                    Observacion_diario = "Girado a:" + ucGe_Beneficiario.Get_Persona_beneficiario_Info().NombreCompleto + " Canc./";
                }
                else
                {
                    Observacion_diario = "Canc./";
                }
                
                Observacion_cbte_bancario = "Canc./ ";

                foreach (var item in BindingList_OrdenPapo_con_cancelacion.Where(q => q.Check == true).ToList())
                {
                    Observacion_diario += item.Referencia2 + "/";
                    Observacion_cbte_bancario += item.Referencia2 + "/";
                }

                txt_Concepto.Text = Observacion_cbte_bancario;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_imprimir_op_Click(object sender, EventArgs e)
        {
            gridAprobacionOrdenPago.ShowPrintPreview();
        }
      
        Boolean pu_Validar()
        {
            try
            {              
                if (this.gridViewOP_Pendientes.RowCount == 0)
                {
                    MessageBox.Show("No se han encontrado registros para procesar", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }


                if (ucBa_Proceso_x_Banco.get_BaCuentaInfo() == null)
                {
                    MessageBox.Show("Debe ingresar el Banco es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        Boolean pu_Validar_Archivo()
        {
            try
            {
                if (ucBa_Proceso_x_Banco.cmb_Banco.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucBa_Proceso_x_Banco.cmb_Banco.Focus();
                    return false;
                }

                if (ucBa_Proceso_x_Banco.cmbProceso.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Proceso Bancario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucBa_Proceso_x_Banco.cmbProceso.Focus();
                    return false;
                }

                if (BindingList_OrdenPapo_con_cancelacion.Count() == 0)
                {
                    MessageBox.Show("No hay Datos ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    if (BindingList_OrdenPapo_con_cancelacion.Where(v => v.Check == true).Count() == 0)
                    {
                        MessageBox.Show("No ha seleccionado ningun registro ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }

                foreach (var item in BindingList_OrdenPapo_con_cancelacion)
                {
                    if (string.IsNullOrEmpty(item.CedulaRuc))
                    {
                        MessageBox.Show("Campo identificación es obligatorio",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (string.IsNullOrEmpty(item.IdTipoCta_acreditacion_cat))
                    {
                        MessageBox.Show("Campo Tipo de Cuenta es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (string.IsNullOrEmpty(item.num_cta_acreditacion))
                    {
                        MessageBox.Show("Campo Número de Cuenta es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.Valor_a_pagar == 0)
                    {
                        MessageBox.Show("No se ha ingresado el valor a pagar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        void pu_CargarArchivo(string ruta)
        {
            try
            {
                Info_BancoCuenta = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
                Info_ProcesoBancario = ucBa_Proceso_x_Banco.get_Proceso_Info();

                if (File.Exists(ruta))
                {
                    File.Delete(ruta);
                }

                Generar_Archivo_Transferencia(ruta);

                try
                {
                    readBuffer = System.IO.File.ReadAllBytes(sfdDoc.FileName);
                }
                catch (Exception)
                {

                }

                if (readBuffer == null)
                    readBuffer = new byte[000];
                MessageBox.Show("El archivo se genero correctamente en: " + sfdDoc.FileName, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (MessageBox.Show("Desea ver el Archivo...?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(sfdDoc.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Generar_Archivo_Transferencia(string NombreArchivo)
        {
            try
            {                               
                Info_BancoCuenta = ucBa_Proceso_x_Banco.get_BaCuentaInfo();
                Info_ProcesoBancario = ucBa_Proceso_x_Banco.get_Proceso_Info();                

                foreach (var item in BindingList_OrdenPapo_con_cancelacion)
                {
                    item.Valor_a_pagar = Convert.ToDouble(item.Valor_a_pagar);

                    if (Info_BancoCuenta.CodigoLegal == "17")
                    {
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("Ñ", "N");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("Á", "A");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("É", "E");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("Í", "I");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("Ó", "O");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("Ú", "U");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("á", "a");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("é", "e");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("ó", "o");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("í", "i");
                        item.Nom_Beneficiario = item.Nom_Beneficiario.Replace("ú", "u");
                    }
                }                

                //bus_archivo.GrabarBD(_Info.ro_rol_detalle, Info_BancoCuenta, Info_ProcesoBancario, _Info.rutaArchivo, "", txtCodEmpresa.EditValue.ToString(), ref mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }       

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            refrescar_listado_op();
        }

        private void refrescar_listado_op()
        {
            try
            {
                Info_Beneficiario = ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {                    
                    Bus_vwOrden_Pago_con_cancelacion = new vwcp_orden_pago_con_cancelacion_Bus();

                    List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();

                    string beneficiario = Info_Beneficiario.IdBeneficiario;

                    if (String.IsNullOrEmpty(beneficiario))
                    {
                        list = Bus_vwOrden_Pago_con_cancelacion.Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago_FormaPago(param.IdEmpresa, "APRO", "CASH_MANAGMENT");

                        BindingList_OrdenPapo_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                        this.gridAprobacionOrdenPago.DataSource = BindingList_OrdenPapo_con_cancelacion;
                    }
                    else
                    {
                        list = Bus_vwOrden_Pago_con_cancelacion.Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago_FormaPago(param.IdEmpresa
                               , Info_Beneficiario.IdTipo_Persona, Info_Beneficiario.IdPersona
                               , Info_Beneficiario.IdEntidad, "APRO", "CASH_MANAGMENT");                       
                    }

                    if (list.Count != 0)
                    {
                        foreach (var item in list)
                        {
                            if (item.IdTipoPersona == Cl_Enumeradores.eTipoPersona.PROVEE.ToString())
                            {
                                Info_Proveedor = Bus_Proveedor.Get_Info_Proveedor(item.IdEmpresa, Convert.ToDecimal(item.IdEntidad));

                                if (Info_Proveedor != null)
                                {
                                    item.CedulaRuc = (Info_Proveedor.Persona_Info == null) ? "" : Info_Proveedor.Persona_Info.pe_cedulaRuc;
                                    item.IdBanco_acreditacion = Info_Proveedor.IdBanco_acreditacion;
                                    item.IdTipoCta_acreditacion_cat = Info_Proveedor.IdTipoCta_acreditacion_cat;
                                    item.num_cta_acreditacion = Info_Proveedor.num_cta_acreditacion;                                    
                                }
                            }
                        }
                                                                     
                        BindingList_OrdenPapo_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(list);
                        this.gridAprobacionOrdenPago.DataSource = BindingList_OrdenPapo_con_cancelacion;

                        //frmCP_Alerta_Anticipos_x_NotasCreditos ofrm = new frmCP_Alerta_Anticipos_x_NotasCreditos();
                        //ofrm.IdEmpresa = param.IdEmpresa;
                        //ofrm.IProveedor = Convert.ToDecimal(Info_Beneficiario.IdEntidad);
                        //ofrm.carga_Grid();

                        //if (ofrm.lista_AnticipoSaldo.Count != 0)
                        //{
                        //    ofrm.ShowDialog();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("No existen OP pendientes", "Sistemas");
                        BindingList_OrdenPapo_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                        this.gridAprobacionOrdenPago.DataSource = BindingList_OrdenPapo_con_cancelacion;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_generar_archivo_Click(object sender, EventArgs e)
        {
            try
            {               
                if (pu_Validar_Archivo())
                {
                    saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = @"C:\";
                    saveFileDialog1.RestoreDirectory = true;                    
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pu_CargarArchivo(saveFileDialog1.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
