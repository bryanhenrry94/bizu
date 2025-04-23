using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

using Bizu.Application.CuentasxPagar;
using Bizu.Application.General;
using Bizu.Application.Compras;
using Bizu.Application.Inventario;
using Bizu.Application.Contabilidad;

using Bizu.Domain.General;
using Bizu.Domain.Compras;
using Bizu.Domain.Inventario;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.SeguridadAcceso;
using Bizu.Presentation.General;
using Bizu.Presentation.Contabilidad;
using Bizu.Presentation.Inventario;
using Bizu.Reports.Compras;

using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;

namespace Bizu.Presentation.Compras
{
    public partial class FrmCom_SolicitudCompra_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region Declaracion de Variables

        int RowHandle = 0;
        string MensajeError = "";
        // Bus
        cp_proveedor_Bus Bus_Prove = new cp_proveedor_Bus();
        tb_persona_bus Bus_Perso = new tb_persona_bus();
        com_comprador_Bus Bus_Comprador = new com_comprador_Bus();
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Prod = new in_producto_Bus();
        com_solicitud_compra_det_Bus Bus_DetSolCom = new com_solicitud_compra_det_Bus();
        com_solicitud_compra_Bus Bus_SolicitudCompra = new com_solicitud_compra_Bus();
        com_parametro_Bus bus_parametro = new com_parametro_Bus();
        ct_punto_cargo_Bus bus_puntoCargo = new ct_punto_cargo_Bus();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Solicitud = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
        in_UnidadMedida_Bus bus_UniMedida = new in_UnidadMedida_Bus();
        com_comprador_Bus busCom = new com_comprador_Bus();
        com_ordencompra_local_det_Bus bus_oc_det = new com_ordencompra_local_det_Bus();

        // Listas
        List<ct_Centro_costo_Info> listCentroCosto;
        List<ct_centro_costo_sub_centro_costo_Info> List_SubCentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Info Info_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Info();
        List<tb_persona_Info> ListPersona;
        List<tb_persona_Info> ListPersonaActivo = new List<tb_persona_Info>();
        List<com_departamento_Info> ListDepartamento = new List<com_departamento_Info>();
        List<tb_Sucursal_Info> ListSucursalActivos = new List<tb_Sucursal_Info>();
        List<in_Producto_Info> ListProducto;
        List<in_Producto_Info> ListProductoActivo = new List<in_Producto_Info>();
        List<com_comprador_Info> listComprador = new List<com_comprador_Info>();
        List<com_comprador_Info> listCompradorActivos = new List<com_comprador_Info>();
        BindingList<com_solicitud_compra_det_Info> ListDetSolCom;

        List<ct_punto_cargo_Info> listPuntoCargo;
        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listSolicitud = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
        List<in_UnidadMedida_Info> listUniMedidad = new List<in_UnidadMedida_Info>();
        // Info
        com_solicitud_compra_Info Info = new com_solicitud_compra_Info();
        com_parametro_Info info = new com_parametro_Info();
        ct_Centro_costo_Bus BusCentroCosto;
        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
        ct_punto_cargo_Info Info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_grupo_Bus BusPunto_Cargo_grupo = new ct_punto_cargo_grupo_Bus();
        List<ct_punto_cargo_grupo_Info> listaPuntoCargo_grupo = new List<ct_punto_cargo_grupo_Info>();
        com_ordencompra_local_Info Info_OC_Copia;

        // Variables      

        string IdEstAprSolComp = "";
        BindingList<in_Producto_Info> listDetTabla;
        public com_solicitud_compra_Info _SetInfo { get; set; }
        in_Producto_Info Item;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        public delegate void delegate_FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_SolicitudCompraMantenimiento_FormClosing event_FrmCom_SolicitudCompraMantenimiento_FormClosing;

        List<com_ordencompra_local_Info> lstOrdenCompra = new List<com_ordencompra_local_Info>();
        com_ordencompra_local_Bus busOrdenCompra = new com_ordencompra_local_Bus();
        seg_usuario_info usuarioInfo = new seg_usuario_info();
       
        #endregion

        public FrmCom_SolicitudCompra_Mant()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;

            event_FrmCom_SolicitudCompraMantenimiento_FormClosing += FrmCom_SolicitudCompraMantenimiento_event_FrmCom_SolicitudCompraMantenimiento_FormClosing;

            if (enu == 0)
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
            }
        }
        
        public FrmCom_SolicitudCompra_Mant(Cl_Enumeradores.eTipo_action Numerador)
            : this()
        {
            try
            {
                enu = Numerador;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        Boolean Actualizar()
        {
            try
            {
                bool flag = true;
                this.Info.Fecha_UltMod = this.param.Fecha_Transac;
                this.Info.IdUsuarioUltMod = this.param.IdUsuario;
                if (!this.Bus_SolicitudCompra.ModificarDB(this.Info, ref this.MensajeError))
                {
                    flag = false;
                    MessageBox.Show("Error al modificar " + this.MensajeError, this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    flag = true;
                    MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Solicitud de Compra " + this.Info.IdSolicitudCompra.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.limpiar();
                }
                return flag;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void actualizar_fechaVencimiento()
        {
            this.dtp_fechaVencimiento.EditValue = Convert.ToDateTime(this.dtpFecha.EditValue).AddDays(Convert.ToDouble(this.txt_plazo.EditValue));
        }

        Boolean Anular()
        {
            try
            {
                bool flag = true;
                string msg = "";
                if (!(this.Info.IdSolicitudCompra != 0M))
                {
                    MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    flag = false;
                }
                else if (MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) + " Solicitud #: " + this.Info.IdSolicitudCompra.ToString() + " ?", this.param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion anulacion = new FrmGe_MotivoAnulacion();
                    anulacion.ShowDialog();
                    this.Info.IdUsuarioUltAnu = this.param.IdUsuario;
                    this.Info.FechaHoraAnul = DateTime.Now;
                    this.Info.MotivoAnulacion = anulacion.motivoAnulacion;
                    if (this.Info.Estado != "A")
                    {
                        flag = false;
                        MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " la solicitud: " + this.Info.IdSolicitudCompra.ToString() + this.param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (!this.Bus_SolicitudCompra.AnularDB(this.Info, ref msg))
                    {
                        flag = false;
                        MessageBox.Show("Error al Anular" + msg, this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        flag = true;
                        MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente) + " La Solicitud de Compra " + this.Info.IdSolicitudCompra.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.lblAnulado.Visible = true;
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        void Carga_Combos()
        {
            try
            {
                this.Cargar_Productos();
                this.listaPuntoCargo_grupo = this.BusPunto_Cargo_grupo.Get_List_punto_cargo_grupo(this.param.IdEmpresa, ref this.MensajeError);
                this.cmb_grupo_punto_cargo.DataSource = this.listaPuntoCargo_grupo;
                this.listPuntoCargo = new List<ct_punto_cargo_Info>();
                this.listPuntoCargo = this.bus_puntoCargo.Get_List_PuntoCargo(this.param.IdEmpresa);
                this.cmbPuntoCargo.DataSource = this.listPuntoCargo;
                this.cmb_punto_cargo_fj.DataSource = this.listPuntoCargo;
                this.listUniMedidad = new List<in_UnidadMedida_Info>();
                this.listUniMedidad = this.bus_UniMedida.Get_list_UnidadMedida();
                this.cmbUniMedida_grid.DataSource = this.listUniMedidad;
                this.cmbUniMedida_grid.DisplayMember = "Descripcion";
                this.cmbUniMedida_grid.ValueMember = "IdUnidadMedida";
                this.BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
                this.BusCentroCosto = new ct_Centro_costo_Bus();
                this.listCentroCosto = new List<ct_Centro_costo_Info>();
                this.listCentroCosto = this.BusCentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(this.param.IdEmpresa, ref this.MensajeError);
                this.listCentroCosto.Add(new ct_Centro_costo_Info(this.param.IdEmpresa, "-999", "***NUEVO REGISTRO**"));
                this.cmb_centro_costo.DataSource = this.listCentroCosto;
                this.List_SubCentro = this.Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(this.param.IdEmpresa);
                this.cmb_subcentroCosto.DataSource = this.List_SubCentro;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Cargar_Productos()
        {
            try
            {
                this.ListProducto = this.Bus_Prod.Get_list_Producto_modulo_x_compra(this.param.IdEmpresa, this.param.IdSucursal);
                this.cmbProducto.DataSource = this.ListProducto;
            }
            catch (Exception)
            {
            }
        }

        private void cmb_subcentroCosto_Click_1(object sender, EventArgs e)
        {
            try
            {
                com_solicitud_compra_det_Info row = new com_solicitud_compra_det_Info();
                row = (com_solicitud_compra_det_Info)this.gridViewSolicitudCompra.GetFocusedRow();
                if (row != null)
                {
                    List<ct_centro_costo_sub_centro_costo_Info> lista = new List<ct_centro_costo_sub_centro_costo_Info>();
                    lista = (from q in this.List_SubCentro
                             where (q.IdEmpresa == this.param.IdEmpresa) && (q.IdCentroCosto == row.IdCentroCosto)
                             select q).ToList<ct_centro_costo_sub_centro_costo_Info>();
                    if ((lista != null) && (lista.Count != 0))
                    {
                        frmCon_ct_centro_costo_sub_centro_costo_Cons cons = new frmCon_ct_centro_costo_sub_centro_costo_Cons();
                        cons.Set_config_combo(lista);
                        cons.ShowDialog();
                        this.Info_SubCentroCosto = cons.Get_info_centro_sub_centro_costo();
                        this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colIdCentroCosto_sub_centro_costo, this.Info_SubCentroCosto?.IdCentroCosto_sub_centro_costo);
                    }
                }
            }
            catch (Exception exception)
            {
                string name = MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(name + " - " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Log_Error_bus.Log_Error(name + " - " + exception.ToString());
            }
        }

        private void cmbPuntoCargo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCon_Punto_Cargo_Cons cons = new frmCon_Punto_Cargo_Cons();
                cons.Cargar_grid_x_grupo(Convert.ToInt32(this.gridViewSolicitudCompra.GetRowCellValue(this.RowHandle, this.colIdPunto_cargo_grupo)));
                cons.ShowDialog();
                this.Info_punto_cargo = cons.Get_Info();
                if (this.Info_punto_cargo != null)
                {
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colIdPunto_Cargo, this.Info_punto_cargo.IdPunto_cargo);
                }
                else
                {
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colIdPunto_Cargo, null);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Log_Error_bus.Log_Error(exception.ToString());
            }
        }

        private void cmbSolicitante_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbSolicitante_Load(object sender, EventArgs e)
        {

        }

        public void convertir_infotabla(List<com_solicitud_compra_det_Info> ListaDetOC)
        {
            try
            {
                this.listDetTabla = new BindingList<in_Producto_Info>();
                foreach (com_solicitud_compra_det_Info info in ListaDetOC)
                {
                    in_Producto_Info item = new in_Producto_Info
                    {
                        IdProducto = Convert.ToDecimal(info.IdProducto),
                        do_Cantidad = info.do_Cantidad,
                        pr_descripcion = info.pr_descripcion
                    };
                    if (!(info.do_Cantidad == 0.0))
                    {
                        this.listDetTabla.Add(item);
                    }
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dtpFecha_EditValueChanged(object sender, EventArgs e)
        {
            this.actualizar_fechaVencimiento();
        }

        void frm_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            this.Cargar_Productos();
        }

        private void frmCentroCosto_event_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.BusCentroCosto = new ct_Centro_costo_Bus();
                this.listCentroCosto = new List<ct_Centro_costo_Info>();
                this.listCentroCosto = this.BusCentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(this.param.IdEmpresa, ref this.MensajeError);
                this.listCentroCosto.Add(new ct_Centro_costo_Info(this.param.IdEmpresa, "-999", "***NUEVO REGISTRO**"));
                this.cmb_centro_costo.DataSource = this.listCentroCosto;
            }
            catch (Exception)
            {
            }
        }

        void FrmCom_SolicitudCompraMantenimiento_event_FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        
        private void FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_FrmCom_SolicitudCompraMantenimiento_FormClosing(sender, e);
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void FrmCom_SolicitudCompraMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                this.Carga_Combos();
                this.info = this.bus_parametro.Get_Info_parametro(this.param.IdEmpresa);
                this.IdEstAprSolComp = this.info.IdEstadoAprobacion_SolCompra;
                this.txt_plazo.EditValue = this.info.default_dias_plazo;
                this.dtpFecha.EditValue = this.param.Fecha_Transac;

                this.ListDetSolCom = new BindingList<com_solicitud_compra_det_Info>();
                this.gridControlSolicitudCompra.DataSource = this.ListDetSolCom;

                switch (this.enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = BarItemVisibility.Never;
                        this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = BarItemVisibility.Never;
                        this.txtIdSolicitud.Enabled = false;
                        this.txtIdSolicitud.BackColor = Color.White;
                        this.txtIdSolicitud.ForeColor = Color.Black;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (this.lblAnulado.Visible)
                        {
                            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = BarItemVisibility.Never;
                            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = BarItemVisibility.Never;
                            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = BarItemVisibility.Never;
                            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = BarItemVisibility.Never;
                            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = BarItemVisibility.Never;
                        }
                        else
                        {
                            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = BarItemVisibility.Never;
                            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = BarItemVisibility.Never;
                            this.txtIdSolicitud.Enabled = false;
                            this.txtIdSolicitud.BackColor = Color.White;
                            this.txtIdSolicitud.ForeColor = Color.Black;
                            this.ucGe_Sucursal_combo1.Enabled = false;
                            this.ucGe_Sucursal_combo1.BackColor = Color.White;
                            this.ucGe_Sucursal_combo1.ForeColor = Color.Black;
                        }
                        this.Set();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = BarItemVisibility.Never;
                        this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = BarItemVisibility.Never;
                        this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = BarItemVisibility.Never;
                        this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = BarItemVisibility.Never;
                        this.Inhabilita_Controles();
                        this.Set();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = BarItemVisibility.Never;
                        this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = BarItemVisibility.Never;
                        this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = BarItemVisibility.Never;
                        this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = BarItemVisibility.Never;
                        this.Inhabilita_Controles();
                        this.Set();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void Get()
        {
            try
            {
                this.Info.IdSolicitudCompra = Convert.ToDecimal((this.txtIdSolicitud.EditValue == "") ? "0" : this.txtIdSolicitud.EditValue);
                this.Info.IdEmpresa = this.param.IdEmpresa;
                this.Info.IdSucursal = this.ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                this.Info.NumDocumento = (Convert.ToString(this.txtNumDocumento.EditValue) == null) ? "" : Convert.ToString(this.txtNumDocumento.EditValue);
                this.Info.IdSolicitante = Convert.ToDecimal(this.cmbSolicitante.get_SolicitanteInfo().IdSolicitante);
                this.Info.fecha = Convert.ToDateTime(this.dtpFecha.EditValue);
                this.Info.plazo = Convert.ToInt32(this.txt_plazo.EditValue);
                this.Info.fecha_vtc = Convert.ToDateTime(this.dtp_fechaVencimiento.EditValue);
                this.Info.observacion = this.txtObservacion.Text;
                this.Info.IdEstadoAprobacion = this.IdEstAprSolComp;
                this.Info.Estado = "A";
               
                int focusedRowHandle = this.gridViewSolicitudCompra.FocusedRowHandle;
                this.gridViewSolicitudCompra.FocusedRowHandle = focusedRowHandle + 1;

                int num2 = 0;
                foreach (com_solicitud_compra_det_Info info2 in this.ListDetSolCom)
                {
                    info2.Secuencia = num2++;
                    info2.IdEmpresa = this.param.IdEmpresa;
                    info2.IdSucursal = this.Info.IdSucursal;
                    info2.IdSolicitudCompra = this.Info.IdSolicitudCompra;
                 
                    if(info2.Secuencia_obr_AsignacionPorcentual != null)
                    {
                        info2.IdEmpresa_obr_AsignacionPorcentual = param.IdEmpresa;
                        info2.IdSucursal_obr_AsignacionPorcentual = param.IdSucursal;
                    }
                }
                this.Info.DetSolicitudCompra = new List<com_solicitud_compra_det_Info>(this.ListDetSolCom);

                // SI EL CAMPO OC TIENE VALOR Y ESTA BLOQUEDO, QUIERE DECIR QUE SE HA IMPORTADO CORRECTAMENTE LOS DATOS
                if(txtIdOrdenCompra.EditValue != null && txtIdOrdenCompra.Enabled == false)
                {               
                    // SEGUNDA VALIDACION ANTES DE OBTENER LOS DATOS DE LA OC
                    if (this.Info_OC_Copia == null || this.Info_OC_Copia.IdOrdenCompra == 0)
                    {
                        MessageBox.Show("No se ha importado la OC", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // LLENAMOS LISTA DE OC X SOLICITUD
                    int iSec = 0;

                    foreach (var _item in this.Info.DetSolicitudCompra)
                    {
                        iSec++;
                        com_ordencompra_local_x_com_solicitud_compra_Info _Info = new com_ordencompra_local_x_com_solicitud_compra_Info();
                        _Info.IdEmpresa_oc = this.Info_OC_Copia.IdEmpresa;
                        _Info.IdSucursal_oc = this.Info_OC_Copia.IdSucursal;
                        _Info.IdOrdenCompra_oc = this.Info_OC_Copia.IdOrdenCompra;
                        _Info.IdEmpresa_sc = _item.IdEmpresa;
                        _Info.IdSucursal_sc = _item.IdSucursal;
                        _Info.IdSolicitudCompra_sc = _item.IdSolicitudCompra;
                        _Info.Secuencia_sc = iSec;
                        _Info.Cantidad = _item.do_Cantidad;

                        this.Info.list_compra_x_solicitud.Add(_Info);
                    }

                    // LLENAMOS LISTA DE OC_DET X SOLICITUD_DET
                    foreach(var _item in this.Info_OC_Copia.listDetalle)
                    {
                        com_ordencompra_local_det_x_com_solicitud_compra_det_Info _Info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();
                        _Info.ocd_IdEmpresa = _item.IdEmpresa;
                        _Info.ocd_IdSucursal = _item.IdSucursal;
                        _Info.ocd_IdOrdenCompra = _item.IdOrdenCompra;
                        _Info.ocd_Secuencia = _item.Secuencia;
                        _Info.scd_IdEmpresa = param.IdEmpresa;
                        _Info.scd_IdSucursal = param.IdSucursal;
                        _Info.scd_IdSolicitudCompra = Convert.ToDecimal(txtIdSolicitud.EditValue);
                        _Info.scd_Secuencia = _item.Secuencia; // LA SECUENCIA ES LA MISMA DE LA OC

                        this.Info.list_compra_det_x_solicitud_det.Add(_Info);
                    }
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        Boolean grabar()
        {
            try
            {
                bool flag = true;
                this.txtIdSolicitud.Focus();
                this.Get();
                switch (this.enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        flag = this.Guardar();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (!this.lblAnulado.Visible)
                        {
                            flag = this.Actualizar();
                        }
                        else
                        {
                            MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado) + ". No se podr\x00e1 efectuar cambios", this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            flag = true;
                        }
                        break;

                    default:
                        break;
                }
                return flag;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void gridViewOrdenCompra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                com_ordencompra_local_Info row = this.gridViewOrdenCompra.GetRow(e.RowHandle) as com_ordencompra_local_Info;
                if (!ReferenceEquals(row, null))
                {
                    if ((row.Estado == "I") || (row.IdEstadoAprobacion_cat == "REP"))
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                    if ((row.IdEstado_cierre == "ABI") && (row.IdEstadoAprobacion_cat == "APRO"))
                    {
                        e.Appearance.ForeColor = Color.Blue;
                    }
                    if (row.IdEstado_cierre == "CERR")
                    {
                        e.Appearance.ForeColor = Color.DarkGreen;
                    }
                    if (row.IdEstado_cierre == "PEN")
                    {
                        e.Appearance.ForeColor = Color.DarkOrange;
                    }
                }
            }
            catch (Exception exception)
            {
                string name = MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + exception.Message + " ", this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Log_Error_bus.Log_Error(name + " - " + exception.ToString());
            }
        }

        private void gridViewSolicitudCompra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_solicitud_compra_det_Info row = new com_solicitud_compra_det_Info();
                row = (com_solicitud_compra_det_Info)this.gridViewSolicitudCompra.GetFocusedRow();
                int num = 0;
                if ((row != null) && (!string.IsNullOrEmpty(Convert.ToString(row.IdPunto_cargo)) && !string.IsNullOrEmpty(Convert.ToString(row.IdCentroCosto))))
                {
                    num = (row.IdProducto != null) ? this.ListDetSolCom.Where<com_solicitud_compra_det_Info>(delegate (com_solicitud_compra_det_Info q) {
                        decimal? idProducto = q.IdProducto;
                        decimal? nullable2 = row.IdProducto;
                        if ((idProducto.GetValueOrDefault() == nullable2.GetValueOrDefault()) & ((idProducto != null) == (nullable2 != null)))
                        {
                            int? nullable3 = q.IdPunto_cargo;
                            int? nullable4 = row.IdPunto_cargo;
                            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()) & ((nullable3 != null) == (nullable4 != null)))
                            {
                                return (q.IdCentroCosto == row.IdCentroCosto);
                            }
                        }
                        return false;
                    }).Count<com_solicitud_compra_det_Info>() : this.ListDetSolCom.Where<com_solicitud_compra_det_Info>(delegate (com_solicitud_compra_det_Info q) {
                        if (q.NomProducto.Trim() == row.NomProducto.Trim())
                        {
                            int? nullable = q.IdPunto_cargo;
                            int? nullable2 = row.IdPunto_cargo;
                            if ((nullable.GetValueOrDefault() == nullable2.GetValueOrDefault()) & ((nullable != null) == (nullable2 != null)))
                            {
                                return (q.IdCentroCosto == row.IdCentroCosto);
                            }
                        }
                        return false;
                    }).Count<com_solicitud_compra_det_Info>();
                }
                if (num > 1)
                {
                    string text1;
                    object focusedRowCellValue = this.gridViewSolicitudCompra.GetFocusedRowCellValue(this.colpr_descripcion);
                    if (focusedRowCellValue != null)
                    {
                        text1 = focusedRowCellValue.ToString();
                    }
                    else
                    {
                        object local1 = focusedRowCellValue;
                        text1 = null;
                    }
                    MessageBox.Show("El registro : " + text1 + " ya se encuentra en el Detalle. Se proceder\x00e1 a Eliminar", this.param.Nombre_sistema);
                    this.gridViewSolicitudCompra.DeleteSelectedRows();
                }
                if (e.Column.Name == "colIdProducto")
                {
                    this.Item = this.ListProducto.First<in_Producto_Info>(v => v.IdProducto == Convert.ToDecimal(e.Value));
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.coldo_Cantidad, 0);
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colpr_descripcion, this.Item.pr_descripcion);
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colIdUnidadMedida, this.Item.IdUnidadMedida.Trim());
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colStock, this.Item.pr_stock);
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colIdCentroCosto, this.Item.IdCentroCosto);
                }
                else if (e.Column.Name != "coldo_Cantidad")
                {
                    if (e.Column.Name == "colpr_descripcion")
                    {
                    }
                }
                else if (Convert.ToDouble(this.gridViewSolicitudCompra.GetFocusedRowCellValue(this.coldo_Cantidad)) < 0.0)
                {
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.coldo_Cantidad, Convert.ToDouble(this.gridViewSolicitudCompra.GetFocusedRowCellValue(this.coldo_Cantidad)) * -1.0);
                }
                ct_centro_costo_sub_centro_costo_Bus bus = new ct_centro_costo_sub_centro_costo_Bus();
                if (ReferenceEquals(e.Column, this.colIdCentroCosto) && (Convert.ToString(e.Value) == "-999"))
                {
                    frmCon_CentroCostos_Man man = new frmCon_CentroCostos_Man();
                    man.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                    man.event_frmCon_CentroCostos_Man_FormClosing += new frmCon_CentroCostos_Man.delegate_frmCon_CentroCostos_Man_FormClosing(this.frmCentroCosto_event_frmCon_CentroCostos_Man_FormClosing);
                    man.ShowDialog();
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colIdCentroCosto, "");
                }
                if (ReferenceEquals(e.Column, this.colIdCentroCosto))
                {
                }
                if (ReferenceEquals(e.Column, this.col_IdPuntoCargo_FJ))
                {
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
        private void gridViewSolicitudCompra_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colIdProducto")
                {
                    this.Item = this.ListProducto.First<in_Producto_Info>(v => v.IdProducto == Convert.ToDecimal(e.Value));
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colpr_descripcion, this.Item.pr_descripcion);
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.coldo_Cantidad, 0);
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colIdUnidadMedida, this.Item.IdUnidadMedida.Trim());
                    this.gridViewSolicitudCompra.SetFocusedRowCellValue(this.colStock, this.Item.pr_stock);
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gridViewSolicitudCompra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.RowHandle = e.FocusedRowHandle;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gridViewSolicitudCompra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((((this.enu != Cl_Enumeradores.eTipo_action.consultar) && (this.enu != Cl_Enumeradores.eTipo_action.Anular)) && (e.KeyValue.ToString() == "46")) && (MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " registro", this.param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    this.gridViewSolicitudCompra.DeleteSelectedRows();
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gridViewSolicitudCompra_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == this.colNew.Name)
                {
                    this.llamarFormulario_Producto();
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gridViewSolicitudCompra_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if ((this.enu == Cl_Enumeradores.eTipo_action.actualizar) && (e.HitInfo.Column != null))
                {
                    e.HitInfo.Column.FieldName = this.gridViewSolicitudCompra.FocusedColumn.FieldName;
                    if ((((e.HitInfo.Column.FieldName == "IdProducto") || ((e.HitInfo.Column.FieldName == "NomProducto") || (e.HitInfo.Column.FieldName == "do_Cantidad"))) || (e.HitInfo.Column.FieldName == "IdPunto_cargo")) && (this.listSolicitud.Count<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>() != 0))
                    {
                        MessageBox.Show("La solicitud #: [" + this._SetInfo.IdSolicitudCompra.ToString() + "], tiene asociada una Orden de Compra. No se puede modificar el Detalle ", this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private bool Guardar()
        {
            try
            {
                bool flag = true;
                this.Info.Fecha_Transac = this.param.Fecha_Transac;

                if (!this.Bus_SolicitudCompra.GuardarDB(this.Info, ref this.MensajeError))
                {
                    flag = false;
                    MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos) + this.MensajeError, this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    flag = true;
                    MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Solicitud de Compra " + this.Info.IdSolicitudCompra.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtIdSolicitud.EditValue = this.Info.IdSolicitudCompra;
                    if (MessageBox.Show(this.param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), this.param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Imprimir();
                    }
                    this.limpiar();
                }
                return flag;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void Imprimir()
        {
            try
            {
                tb_Sucursal_Info info = this.ucGe_Sucursal_combo1.get_SucursalInfo();
                if (info == null)
                {
                    MessageBox.Show("No puede imprimir un registro en blanco", this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (info.IdSucursal != 0)
                {
                    XCOMP_Rpt002_Rpt report = new XCOMP_Rpt002_Rpt();
                    report.set_parametros(this.param.IdEmpresa, this.ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, Convert.ToDecimal(this.txtIdSolicitud.EditValue));
                    report.RequestParameters = true;
                    report.ShowPreviewDialog();
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Inhabilita_Controles()
        {
            try
            {
                this.txtIdSolicitud.Enabled = false;
                this.txtIdSolicitud.BackColor = Color.White;
                this.txtIdSolicitud.ForeColor = Color.Black;
                this.txtNumDocumento.Enabled = false;
                this.txtNumDocumento.BackColor = Color.White;
                this.txtNumDocumento.ForeColor = Color.Black;
                this.txtObservacion.Enabled = false;
                this.txtObservacion.BackColor = Color.White;
                this.txtObservacion.ForeColor = Color.Black;
                this.dtpFecha.Enabled = false;
                this.ucGe_Sucursal_combo1.Enabled = false;
                this.ucGe_Sucursal_combo1.BackColor = Color.White;
                this.ucGe_Sucursal_combo1.ForeColor = Color.Black;
                this.cmbSolicitante.Enabled = false;
                this.cmbSolicitante.BackColor = Color.White;
                this.cmbSolicitante.ForeColor = Color.Black;
                this.txt_plazo.Enabled = false;
                this.gridViewSolicitudCompra.OptionsBehavior.Editable = false;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
        private void limpiar()
        {
            try
            {
                this.txtIdSolicitud.EditValue = "";
                this.txtNumDocumento.EditValue = "";
                this.txtObservacion.Text = "";
                this.dtpFecha.EditValue = this.param.Fecha_Transac;
                this.txt_plazo.EditValue = 0;
                this.txtIdOrdenCompra.EditValue = null;
                this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = BarItemVisibility.Always;
                this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = BarItemVisibility.Always;
                this.ListDetSolCom = new BindingList<com_solicitud_compra_det_Info>();
                this.gridControlSolicitudCompra.DataSource = this.ListDetSolCom;
                this.lstOrdenCompra = new List<com_ordencompra_local_Info>();
                this.gridControlOrdenCompra.DataSource = this.lstOrdenCompra;

                this.habilitar_control_oc_importacion(true);
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void llamarFormulario_Producto()
        {
            try
            {
                FrmIn_Producto_Mant edehsa = new FrmIn_Producto_Mant();
                com_solicitud_compra_det_Info Row = this.gridViewSolicitudCompra.GetFocusedRow() as com_solicitud_compra_det_Info;

                if (Row != null)
                {
                    edehsa.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    edehsa.set_Info_producto(this.ListProducto.Find(delegate (in_Producto_Info q) {
                        bool flag1;
                        if (q.IdEmpresa != this.param.IdEmpresa)
                        {
                            flag1 = false;
                        }
                        else
                        {
                            decimal? idProducto = Row.IdProducto;
                            flag1 = (q.IdProducto == idProducto.GetValueOrDefault()) & (idProducto != null);
                        }
                        return flag1;
                    }));
                }
                edehsa.ShowDialog();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Set()
        {
            try
            {
                this.txtIdSolicitud.EditValue = this._SetInfo.IdSolicitudCompra;
                this.txtNumDocumento.EditValue = this._SetInfo.NumDocumento;
                this.txtObservacion.Text = this._SetInfo.observacion;
                this.dtpFecha.EditValue = this._SetInfo.fecha;
                this.txt_plazo.EditValue = this._SetInfo.plazo;
                this.dtp_fechaVencimiento.EditValue = this._SetInfo.fecha_vtc;
                this.ucGe_Sucursal_combo1.set_SucursalInfo(this._SetInfo.IdSucursal);
                this.cmbSolicitante.set_SolicitanteInfo(this._SetInfo.IdSolicitante);
                
                this.ListDetSolCom = new BindingList<com_solicitud_compra_det_Info>(this.Bus_DetSolCom.Get_list_DetalleLstSolicitudCompra(this.param.IdEmpresa, this._SetInfo.IdSucursal, this._SetInfo.IdSolicitudCompra));
                this.gridControlSolicitudCompra.DataSource = this.ListDetSolCom;
                this.lblAnulado.Visible = this._SetInfo.Estado.TrimEnd(new char[0]) == "I";
                this.listSolicitud = this.bus_Solicitud.ConsultaDetalleSolicitud_x_Solicitud(this._SetInfo.IdEmpresa, this._SetInfo.IdSucursal, this._SetInfo.IdSolicitudCompra);

                if (this.listSolicitud.Count<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>() != 0)
                    this.gridViewSolicitudCompra.OptionsBehavior.Editable = false;

                this.lstOrdenCompra = new List<com_ordencompra_local_Info>();
                this.lstOrdenCompra = this.busOrdenCompra.Get_List_ordencompra_local_x_Solicitud(this._SetInfo.IdEmpresa, this._SetInfo.IdSucursal, this._SetInfo.IdSolicitudCompra);
                this.gridControlOrdenCompra.DataSource = this.lstOrdenCompra;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
        private void txt_plazo_EditValueChanged(object sender, EventArgs e)
        {
            this.actualizar_fechaVencimiento();
        }
        
        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                this.Get();
                this.Anular();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validar())
                {
                    this.grabar();
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validar() && this.grabar())
                {
                    base.Close();
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Imprimir();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = BarItemVisibility.Always;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        
        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                base.Close();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), this.param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void UcObr_Proyecto_Oferta_cmb1_event_cmb_Oferta_EditValueChanged(object sender, EventArgs e)
        {
        }
        
        public Boolean Validar()
        {
            try
            {
                ucGe_Sucursal_combo1.Focus();

                if (String.IsNullOrEmpty(IdEstAprSolComp))
                {
                    MessageBox.Show("No Existe Estado Aprobación de Solicitud de Compras en Parámetros de Compras. Por favor verifique dicho Estado en Parámetros de Compras", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucGe_Sucursal_combo1.get_SucursalInfo() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_sucursal), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_Sucursal_combo1.Focus();
                    return false;
                }
                
                if (cmbSolicitante.get_SolicitanteInfo() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Solicitante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSolicitante.Focus();
                    return false;
                }
               
                if (ListDetSolCom.Count == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Detalle de la Solicitud", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                
                if (ListDetSolCom.Count != 0)
                {

                    if (ListDetSolCom.Where(v => v.IdProducto == null).Count() > 0)
                    {
                        //MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " producto: " + ListDetSolCom.First(c => c.do_Cantidad == 0).NomProducto, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show("Ingrese un Producto");
                        return false;
                    }

                    if (ListDetSolCom.Where(v => v.do_Cantidad == 0).Count() > 0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " cantidad del producto: " + ListDetSolCom.First(c => c.do_Cantidad == 0).NomProducto, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (ListDetSolCom.Where(v => v.IdUnidadMedida == null).Count() > 0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " unidad de medida del producto: " + ListDetSolCom.First(c => c.IdUnidadMedida == null).NomProducto, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (ListDetSolCom.Where(v => v.do_Cantidad != 0 && v.NomProducto == null).Count() > 0)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " producto para la cantidad " + ListDetSolCom.FirstOrDefault(c => c.do_Cantidad != 0).do_Cantidad, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void habilitar_control_oc_importacion(bool value)
        {
            txtIdOrdenCompra.Enabled = value;
            ucGe_Sucursal_combo1.Enabled = value;
            cmbSolicitante.Enabled = value;
            dtpFecha.Enabled = value;
            txt_plazo.Enabled = value;
            dtp_fechaVencimiento.Enabled = value;
            txtObservacion.Enabled = value;
            gridViewOrdenCompra.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            colIdProducto.OptionsColumn.AllowEdit = value;
            colpr_descripcion.OptionsColumn.AllowEdit = value;
            coldo_Cantidad.OptionsColumn.AllowEdit = value;
            colIdUnidadMedida.OptionsColumn.AllowEdit = value;
            colIdCentroCosto.OptionsColumn.AllowEdit = value;
            colIdCentroCosto_sub_centro_costo.OptionsColumn.AllowEdit = value;
            colStock.OptionsColumn.AllowEdit = value;
            colObservacion.OptionsColumn.AllowEdit = value;
            colNew.OptionsColumn.AllowEdit = value;
        }

        private void txtIdOrdenCompra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(Keys.Enter == e.KeyCode)
                {
                    // PREGUNTAMOS SI DESEA CONTINUAR EL PROCESO DE IMPORTACION DE OC
                    if (MessageBox.Show("Se procedera a importar los datos de la OC" + txtIdOrdenCompra.EditValue + ". Desea cotinuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                    // CONSULTAMOS EL CABECERA DE LA OC
                    this.Info_OC_Copia = busOrdenCompra.Get_Info_ordencompra_local(param.IdEmpresa, param.IdSucursal, Convert.ToDecimal(txtIdOrdenCompra.EditValue));

                    // VALIDAMOS QUE EXISTE EN LA BASE DE DATOS LA OC A IMPORTAR
                    if(this.Info_OC_Copia == null || this.Info_OC_Copia.IdOrdenCompra == 0) {
                        MessageBox.Show("No se encontro OC en la base de datos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // VERIFICAMOS QUE LA OC NO TENGA RELACION CON UNA SOLICITUD DE COMPRA
                    com_ordencompra_local_x_com_solicitud_compra_Bus bus_oc_x_solicitud = new com_ordencompra_local_x_com_solicitud_compra_Bus();
                    if(bus_oc_x_solicitud.ExisteOC(this.Info_OC_Copia.IdEmpresa, this.Info_OC_Copia.IdSucursal, this.Info_OC_Copia.IdOrdenCompra))
                    {
                        MessageBox.Show("La OC" + this.Info_OC_Copia.IdOrdenCompra + " ya tiene asociada una solicitud de compra", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // CONSULTAMOS EL DETALLE DE LA OC
                    this.Info_OC_Copia.listDetalle = this.bus_oc_det.Get_List_ordencompra_local_det(this.Info_OC_Copia.IdEmpresa, this.Info_OC_Copia.IdSucursal, this.Info_OC_Copia.IdOrdenCompra);

                    // VALIDAMOS QUE LA OC TENGA UNA LISTA DE PRODUCTOS
                    if(this.Info_OC_Copia.listDetalle.Count <= 0)
                    {
                        MessageBox.Show("La OC" + this.Info_OC_Copia.IdOrdenCompra + " no tiene detalle registrado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // PROCEDEMOS CON LA IMPORTACION DE LOS DATOS DE LA OC
                    this.habilitar_control_oc_importacion(false);
                    this.ucGe_Sucursal_combo1.cmbsucursal.EditValue = this.Info_OC_Copia.IdSucursal;
                    this.cmbSolicitante.cmb_Solicitante.EditValue = this.Info_OC_Copia.IdSolicitante;
                    this.dtpFecha.EditValue = this.Info_OC_Copia.oc_fecha;
                    this.txtObservacion.Text = this.Info_OC_Copia.oc_observacion;
                    
                    this.ListDetSolCom = new BindingList<com_solicitud_compra_det_Info>();
                    this.gridControlSolicitudCompra.DataSource = this.ListDetSolCom;

                    foreach(var _item in this.Info_OC_Copia.listDetalle)
                    {
                        com_solicitud_compra_det_Info _solicitud_det = new com_solicitud_compra_det_Info();
                        _solicitud_det.IdEmpresa = _item.IdEmpresa;
                        _solicitud_det.IdSucursal = _item.IdSucursal;
                        _solicitud_det.IdSolicitudCompra = Convert.ToDecimal(txtIdSolicitud.EditValue);
                        _solicitud_det.Secuencia = _item.Secuencia;
                        _solicitud_det.IdProducto = _item.IdProducto;
                        _solicitud_det.do_Cantidad = _item.do_Cantidad;
                        _solicitud_det.IdCentroCosto = _item.IdCentroCosto;
                        _solicitud_det.IdUnidadMedida = _item.IdUnidadMedida;

                        this.ListDetSolCom.Add(_solicitud_det);
                    }

                    this.gridControlSolicitudCompra.RefreshDataSource();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}