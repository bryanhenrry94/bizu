using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Domain.Inventario;
using Bizu.Application.Inventario;
using Bizu.Domain.General;
using Bizu.Application.General;
using Bizu.Presentation.General;
using Bizu.Domain.Contabilidad;
using Bizu.Application.Contabilidad;
using Bizu.Domain.Compras;
using Bizu.Application.Compras;
using Bizu.Reports.Inventario;
using Bizu.Presentation.Contabilidad;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using Bizu.Presentation.Inventario;
using DevExpress.XtraReports.UI;

namespace Bizu.Presentation.Inventario
{
    public partial class FrmIn_Egresos_Varios_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Producto;        
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        in_Ing_Egr_Inven_det_Bus bus_IngEgrDet;
        in_Ing_Egr_Inven_Bus bus_IngEgr;
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();        

        string MensajeError = "";        

        //Listas
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        List<in_movi_inven_tipo_Info> listInMovTip = new List<in_movi_inven_tipo_Info>();

        List<ct_Centro_costo_Info> list_centro_costo = new List<ct_Centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();        
        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        in_Producto_Info Info_validar_cantidades = new in_Producto_Info();

        //Variables PRINCIPALES DE LA PANTALLA
        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
        BindingList<in_Ing_Egr_Inven_det_Info> List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_det_Info InfoDet = new in_Ing_Egr_Inven_det_Info();

        public delegate void delegate_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Egreso_varios_Mant_FormClosing event_FrmIn_Egreso_varios_Mant_FormClosing;

        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();

        Cl_Enumeradores.eTipo_action Accion;
        int RowHandle = 0;
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        List<ct_punto_cargo_Info> list_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_grupo_Info info_grupo_punto_cargo = new ct_punto_cargo_grupo_Info();
        List<ct_punto_cargo_grupo_Info> list_grupo_punto_cargo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo_punto_cargo = new ct_punto_cargo_grupo_Bus();
        List<in_Motivo_Inven_Info> list_MotivoInv = new List<in_Motivo_Inven_Info>();
        in_Motivo_Inven_Info info_MotivoInv = new in_Motivo_Inven_Info();
        in_Motivo_Inven_Bus bus_MotivoInv = new in_Motivo_Inven_Bus();
        in_Parametro_Info info_parametros = new in_Parametro_Info();
        in_Parametro_Bus bus_parametros = new in_Parametro_Bus();
        in_Producto_Info Item = new in_Producto_Info();
        List<in_UnidadMedida_Info> lst_unidad_medida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_unidad_medida = new in_UnidadMedida_Bus();
        List<in_UnidadMedida_Info> lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Info info_unidad_medida = new in_UnidadMedida_Info();
        List<in_UnidadMedida_Equiv_conversion_Info> lst_unidad_equiv = new List<in_UnidadMedida_Equiv_conversion_Info>();
        in_UnidadMedida_Equiv_conversion_Bus bus_unidad_equiv = new in_UnidadMedida_Equiv_conversion_Bus();
        in_UnidadMedida_Equiv_conversion_Info info_unidad_equiv = new in_UnidadMedida_Equiv_conversion_Info();

        private in_Producto_Info Info_Producto_Selected_View;

        #endregion

        public FrmIn_Egresos_Varios_Mant()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;

            event_FrmIn_Egreso_varios_Mant_FormClosing += FrmIn_Egresos_Varios_Mant_event_FrmIn_Egreso_varios_Mant_FormClosing;
            gridViewProductos.CellValueChanging += gridViewProductos_CellValueChanging;

            ucIn_Sucursal_Bodega1.Event_cmb_bodega1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged;
            ucIn_Sucursal_Bodega1.Event_cmb_sucursal1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged;

            gridview_producto_grid.RowClick += gridview_producto_grid_RowClick;
        }

        void gridview_producto_grid_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Info_Producto_Selected_View = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRow() as in_Producto_Info;
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {

        }

        void ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Habilita columna Centro Costo
                colIdCentroCosto_grid.OptionsColumn.AllowEdit = true;

                tb_Bodega_Info Info_Bodega = ucIn_Sucursal_Bodega1.get_bodega();

                if (Info_Bodega != null)
                {                    
                    cmbTipoMovi.cargar_TipoMotivo(Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), "-", "");

                    // Si el campo bodega tiene asignado un centro de costo
                    if (Info_Bodega.IdCentroCosto != null)
                    {
                        // Bloquea columna Centro Costo
                        colIdCentroCosto_grid.OptionsColumn.AllowEdit = false;

                        // Setea por default a todas las filas 
                        foreach (var item in List_Bind_IngEgrDet)
                        {
                            item.IdCentroCosto = Info_Bodega.IdCentroCosto;
                        }
                    }                    
                }
                else
                {
                    cmbTipoMovi.Inicializar_Catalogos();                    
                }

                CargarProducto();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Egresos_Varios_Mant_event_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void gridViewProductos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Egresos_Varios_Mant_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmIn_Egresos_Varios_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                info_parametros = bus_parametros.Get_Info_Parametro(param.IdEmpresa);

                dtpFecha.EditValue = DateTime.Now;

                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = List_Bind_IngEgrDet;

                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }

                carga_Combos();

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        colMotivo_inv.Visible = false;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        col_grupo_pto_cargo.Visible = true;
                        colIdPunto_cargo.Visible = true;
                        break;

                    case Cl_Enumeradores.eCliente_Vzen.TRANSGANDIA:
                        col_grupo_pto_cargo.Visible = true;
                        colIdPunto_cargo.Visible = true;
                        break;

                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        colIdPunto_cargo.Visible = false;
                        colIdRegistro_subcentro.Visible = false;
                        colMotivo_inv.Visible = false;
                        break;

                    default:
                        break;
                }

                set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void motivo()
        {
            ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = info_IngEgr.IdSucursal;
            ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = info_IngEgr.IdBodega;
            gridControlProductos.DataSource = List_Bind_IngEgrDet;

            cmbTipoMovi.set_TipoMoviInvInfo(info_IngEgr.IdMovi_inven_tipo);
            ucIn_MotivoInvCmb1.set_MotivoInvInfo((int)info_IngEgr.IdMotivo_Inv);
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void Anular()
        {
            try
            {
                //if (ValidarDatos()) --Ricardo me dijo que elimine esto. --PS--
                //{
                if (ValidarAnulacion_x_Estado())
                {
                    Get();

                    string mensaje = "";
                    if (MessageBox.Show("Esta seguro que desea eliminar la transaccion ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    { return; }
                    Bizu.Presentation.General.FrmGe_MotivoAnulacion ofrm = new General.FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();
                    info_IngEgr.MotivoAnulacion = ofrm.motivoAnulacion;
                    info_IngEgr.IdusuarioUltAnu = param.IdUsuario;
                    info_IngEgr.Fecha_UltAnu = ofrm.fechaAnul;
                    bus_IngEgr = new in_Ing_Egr_Inven_Bus();

                    if (bus_IngEgr.AnularDB(info_IngEgr, ref mensaje))
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema);
                        lblAnulado.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al anular el registro: " + mensaje, param.Nombre_sistema);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean ValidarAnulacion_x_Estado()
        {
            try
            {
                foreach (var item in List_Bind_IngEgrDet)
                {
                    //if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    //{
                    //    MessageBox.Show("No Se Puede Anular por que hay Registros Aprobados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return false;
                    //}
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

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XINV_Rpt002_Rpt Reporte_ = new XINV_Rpt002_Rpt();
                Reporte_.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte_.Parameters["IdSucursal"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                Reporte_.Parameters["IdBodega"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                Reporte_.Parameters["IdMovi_inven_tipo"].Value = Convert.ToInt32(cmbTipoMovi.cmbCatalogo.EditValue);
                Reporte_.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);
                Reporte_.RequestParameters = false;
                DevExpress.XtraReports.UI.ReportPrintTool pt_ = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte_);
                pt_.AutoShowParametersPanel = false;
                Reporte_.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_Combos()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        //
                        break;

                    default:
                        CargarProducto();
                        break;
                }

                list_centro_costo = new List<ct_Centro_costo_Info>();
                list_centro_costo = bus_centro_costo.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmbCentroCosto_grid.DataSource = list_centro_costo;
                cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
                cmbCentroCosto_grid.ValueMember = "IdCentroCosto";
                //subcentro de costo
                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_subcentrocosto.DataSource = list_subcentro_combo;

                bus_punto_cargo = new ct_punto_cargo_Bus();
                list_punto_cargo = new List<ct_punto_cargo_Info>();
                list_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmbPuntoCargo_grid.DataSource = list_punto_cargo;
                cmbPuntoCargo_grid.DisplayMember = "nom_punto_cargo";
                cmbPuntoCargo_grid.ValueMember = "IdPunto_cargo";
                list_grupo_punto_cargo = bus_grupo_punto_cargo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Punto_cargo_grupo.DataSource = list_grupo_punto_cargo;
                list_MotivoInv = bus_MotivoInv.Get_List_Motivo_Inven(param.IdEmpresa);
                cmb_Motivo_Inv.DataSource = list_MotivoInv;
                cmb_Motivo_Inv.ValueMember = "IdMotivo_Inv";

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = lst_unidad_medida;
                cmb_unidad_medida_convertida.DataSource = lst_unidad_medida;               
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarProducto()
        {
            try
            {
                Bus_Producto = new in_producto_Bus();
                listProducto = new List<in_Producto_Info>();

                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null && ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue != null)
                {
                    ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = (ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == "") ? 0 : ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue;
                    ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == "") ? 0 : ucIn_Sucursal_Bodega1.cmb_bodega.EditValue;

                    if (Convert.ToBoolean(this.info_parametros.P_Maneja_Lote))
                    {
                        listProducto = Bus_Producto.Get_list_Producto_modulo_x_inventario_Lote(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue));
                    }
                    else
                    {
                        listProducto = Bus_Producto.Get_list_Producto_modulo_x_inventario(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue));
                    }
                }

                cmbProducto_grid.DataSource = listProducto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {

                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_Accion_in_controls()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        dtpFecha.Enabled = false;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.TALME:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        lbl_responsable.Visible = true;
                        ucIn_Responsable1.Visible = true;
                        colIdRegistro_subcentro.Visible = false;
                        col_IdCentroCosto_sub_centro_costo.Visible = false;
                        col_grupo_pto_cargo.Visible = true;
                        colIdPunto_cargo.Visible = true;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        break;
                    default:
                        break;
                }
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        this.txtNumIngreso.ReadOnly = true;
                        if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT)
                        {
                            dtpFecha.Enabled = false;
                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        setInfo_in_controls();

                        foreach (var item in List_Bind_IngEgrDet)
                        {
                            if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, item.IdProducto))
                                Info_validar_cantidades = listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto && q.Lote == item.Lote);
                            else
                                Info_validar_cantidades = listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto);


                            if (Info_validar_cantidades != null)
                            {
                                if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, item.IdProducto))
                                    listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto && q.Lote == item.Lote).pr_Pedidos_inv = Info_validar_cantidades.pr_Pedidos_inv - (Math.Abs(item.dm_cantidad) * -1);
                                else
                                    listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto).pr_Pedidos_inv = Info_validar_cantidades.pr_Pedidos_inv - (Math.Abs(item.dm_cantidad) * -1);
                            }
                        }

                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        Inhabilita_Controles();
                        dtpFecha.Enabled = true;
                        txtObservacion.Enabled = true;
                        if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT)
                        {
                            dtpFecha.Enabled = false;
                            txtObservacion.ReadOnly = false;
                        }


                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        setInfo_in_controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        Inhabilita_Controles();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        setInfo_in_controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        Inhabilita_Controles();
                        ucIn_MotivoInvCmb1.set_MotivoInvInfo((int)info_IngEgr.IdMotivo_Inv);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inhabilita_Controles()
        {
            try
            {
                txtNumIngreso.ReadOnly = true;

                dtpFecha.Enabled = false;

                cmbTipoMovi.Enabled = false;

                txtObservacion.ReadOnly = true;

                ucIn_Sucursal_Bodega1.cmb_sucursal.Enabled = false;
                ucIn_Sucursal_Bodega1.cmb_bodega.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                carga_Combos();
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtNumIngreso.Text = "";
                txtCodigo.Text = "";
                txtObservacion.Text = "";
                dtpFecha.EditValue = DateTime.Now;
                info_IngEgr = new in_Ing_Egr_Inven_Info();
                info_IngEgr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = List_Bind_IngEgrDet;

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get()
        {
            try
            {
                //info_IngEgr = new in_Ing_Egr_Inven_Info();               
                info_IngEgr.IdEmpresa = param.IdEmpresa;
                info_IngEgr.IdNumMovi = Convert.ToDecimal((txtNumIngreso.Text == "") ? "0" : txtNumIngreso.Text);
                info_IngEgr.IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                info_IngEgr.IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                info_IngEgr.CodMoviInven = txtCodigo.Text;
                info_IngEgr.cm_observacion = txtObservacion.Text;
                info_IngEgr.IdMovi_inven_tipo = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info_IngEgr.cm_fecha = Convert.ToDateTime(dtpFecha.EditValue);
                info_IngEgr.IdUsuario = param.IdUsuario;
                info_IngEgr.nom_pc = param.nom_pc;
                info_IngEgr.ip = param.ip;
                info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                info_IngEgr.signo = "-";
                info_IngEgr.IdMotivo_Inv = ucIn_MotivoInvCmb1.get_MotivoInvInfo().IdMotivo_Inv;
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        info_IngEgr.IdResponsable = ucIn_Responsable1.get_Info_Responsable().IdResponsable;
                        break;
                    default:
                        info_IngEgr.IdResponsable = null;
                        break;
                }

                info_IngEgr.listIng_Egr = GetDetalle();
                foreach (var item in info_IngEgr.listIng_Egr)
                {
                    item.IdEmpresa = info_IngEgr.IdEmpresa;
                    item.IdNumMovi = info_IngEgr.IdNumMovi;
                    item.IdSucursal = info_IngEgr.IdSucursal;
                    item.IdBodega = info_IngEgr.IdBodega;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<in_Ing_Egr_Inven_det_Info> GetDetalle()
        {
            try
            {
                return new List<in_Ing_Egr_Inven_det_Info>(List_Bind_IngEgrDet);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<in_Ing_Egr_Inven_det_Info>();
            }
        }

        public void setInfo_(in_Ing_Egr_Inven_Info info_IngEgr_)
        {
            info_IngEgr = info_IngEgr_;
        }

        private void setInfo_in_controls()
        {
            try
            {
                if (info_IngEgr == null)
                { return; }

                txtNumIngreso.Text = Convert.ToString(info_IngEgr.IdNumMovi);
                ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = info_IngEgr.IdSucursal;
                ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = info_IngEgr.IdBodega;
                dtpFecha.EditValue = info_IngEgr.cm_fecha;
                cmbTipoMovi.set_TipoMoviInvInfo(info_IngEgr.IdMovi_inven_tipo);
                txtObservacion.Text = info_IngEgr.cm_observacion;
                txtCodigo.Text = info_IngEgr.CodMoviInven;

                //ucIn_MotivoInvCmb1.get_MotivoInvInfo((int)info_IngEgr.IdMotivo_Inv);

                lblAnulado.Visible = info_IngEgr.Estado == "I" ? true : false;
                ucIn_Responsable1.set_Info_Responsable((info_IngEgr.IdResponsable == null) ? 0 : Convert.ToDecimal(info_IngEgr.IdResponsable));
                bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();
                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>(bus_IngEgrDet.Get_List_Ing_Egr_Inven_det(param.IdEmpresa, info_IngEgr.IdSucursal, info_IngEgr.IdMovi_inven_tipo, info_IngEgr.IdNumMovi));
                foreach (var item in List_Bind_IngEgrDet)
                {
                    item.dm_cantidad = item.dm_cantidad < 0 ? item.dm_cantidad * -1 : item.dm_cantidad;
                    item.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion < 0 ? item.dm_cantidad_sinConversion * -1 : item.dm_cantidad_sinConversion;
                }
                ucIn_MotivoInvCmb1.set_MotivoInvInfo((int)info_IngEgr.IdMotivo_Inv);

                gridControlProductos.DataSource = List_Bind_IngEgrDet;

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean grabar()
        {
            try
            {
                txtNumIngreso.Focus();
                if (!ValidarDatos())
                    return false;

                Get();
                string mensaje = "";
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        foreach (var item in info_IngEgr.listIng_Egr)
                        {
                            in_Producto_Info Info_Prod_msg = new in_Producto_Info();
                            Info_Prod_msg = listProducto.First(q => q.IdProducto == item.IdProducto);

                            if (Info_Prod_msg.pr_stock_minimo <= (Info_Prod_msg.pr_Disponible - item.dm_cantidad_sinConversion))
                            {
                                MessageBox.Show("El item " + Info_Prod_msg.pr_descripcion + " están a punto de terminarse", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    default:
                        break;
                }

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        decimal IdNumMovi = 0;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (bus_IngEgr.GuardarDB(info_IngEgr, ref   IdNumMovi, ref mensaje))
                        {
                            txtNumIngreso.Text = Convert.ToString(IdNumMovi);
                            string smensaje = string.Format("{0} # {1} se guardó con éxito.", "El registro del egreso a Bodega ", IdNumMovi.ToString());
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se ha procedido a grabar el registro del Ingreso a Bodega #: " + IdNumMovi.ToString() + " exitosamente.", "Operación Exitosa");

                            // consulta grid contable                      
                            var item = info_IngEgr.listIng_Egr.FirstOrDefault();
                            ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));

                            if (MessageBox.Show("Desea Imprimir el Egreso", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(null, null);
                            }

                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al grabar el Ingreso a Bodega, " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        info_IngEgr.IdUsuarioUltModi = param.IdUsuario;
                        info_IngEgr.Fecha_UltMod = param.Fecha_Transac;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (bus_IngEgr.ModificarDB(info_IngEgr, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema);
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el registro: " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;
                    default:
                        break;
                }

                CargarProducto();

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridViewProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewProductos.DeleteSelectedRows();
                    }
                }

                // para pegar en las columnas en el mismo orden 
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!Agregar_fila_copiada(row))
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private Boolean Agregar_fila_copiada(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });


                //posicion de la ata pegada
                //codigo produc | unidad medida |cant |costo|observacion|

                in_Ing_Egr_Inven_det_Info newRow = new in_Ing_Egr_Inven_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {

                    string cod_producto = rowData[0];
                    in_Producto_Info Info_Producto;
                    var QProducto = listProducto.FirstOrDefault(v => v.pr_codigo == cod_producto);
                    if (QProducto != null)
                    { Info_Producto = listProducto.FirstOrDefault(v => v.pr_codigo == cod_producto); }
                    else { MessageBox.Show("el codigo de este producto:" + cod_producto + " no esta en la base"); return false; }



                    string IdUnidadMedida = Convert.ToString(rowData[2]) == "" ? Info_Producto.IdUnidadMedida_Consumo : Convert.ToString(rowData[2]);
                    double cantidad = Convert.ToDouble(rowData[3]);
                    double costo_unitario = Convert.ToDouble(rowData[4]);
                    string observacion = Convert.ToString(rowData[1]);


                    in_Ing_Egr_Inven_det_Info emp = new in_Ing_Egr_Inven_det_Info();
                    if (!string.IsNullOrWhiteSpace(cod_producto))
                    {

                        newRow.IdProducto = Info_Producto.IdProducto;
                        newRow.cod_producto = cod_producto;
                        newRow.dm_cantidad = cantidad;
                        newRow.dm_cantidad_sinConversion = cantidad;
                        newRow.IdUnidadMedida = IdUnidadMedida;
                        newRow.IdUnidadMedida_sinConversion = IdUnidadMedida;
                        newRow.mv_costo = costo_unitario;
                        newRow.mv_costo_sinConversion = costo_unitario;
                        newRow.dm_observacion = observacion;
                        newRow.nom_UnidadMedida = Info_Producto.nom_UnidadMedida;


                    }
                    else
                    {
                        MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
                        return false;
                    }

                    List_Bind_IngEgrDet.Add(newRow);
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "El formato debe ser el siguiente\n" + "|codigo Producto|nombre producto|unidad med.|cantidad|costo|observacion det|centros cos|", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void gridViewProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //InfoDet = new in_Ing_Egr_Inven_det_Info();
                InfoDet = (in_Ing_Egr_Inven_det_Info)this.gridViewProductos.GetFocusedRow();

                if (e.Column.Name == "colIdProducto")
                {
                    foreach (var item in List_Bind_IngEgrDet)
                    {
                        //var Info_Producto_Selected_View = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);                        

                        if (Info_Producto_Selected_View != null)
                        {
                            if (item.IdProducto == InfoDet.IdProducto)
                            {
                                double dCostoPromedio = Convert.ToDouble(Info_Producto_Selected_View.pr_costo_promedio);

                                item.cod_producto = Info_Producto_Selected_View.pr_codigo;
                                InfoDet.mv_costo = dCostoPromedio;
                                InfoDet.mv_costo_sinConversion = dCostoPromedio;
                                InfoDet.pr_descripcion = Info_Producto_Selected_View.pr_descripcion;
                                InfoDet.IdUnidadMedida = Info_Producto_Selected_View.IdUnidadMedida_Consumo;
                                InfoDet.IdUnidadMedida_sinConversion = Info_Producto_Selected_View.IdUnidadMedida_Consumo;
                                InfoDet.IdCategoria = Info_Producto_Selected_View.IdCategoria;

                                if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, InfoDet.IdProducto))
                                    InfoDet.Lote = Info_Producto_Selected_View.Lote;
                                else
                                    InfoDet.Lote = null;
                            }
                        }
                    }
                }

                if (e.Column == colIdCentroCosto_grid)
                {
                    if (!bus_centro_costo.Validar_CentroCosto_EstadoObra(param.IdEmpresa, Convert.ToString(InfoDet.IdCentroCosto), ref MensajeError))
                    {
                        MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridViewProductos.SetFocusedRowCellValue(colIdCentroCosto_grid, null);
                        return;
                    }
                }

                if (e.Column == coldm_cantidad_sin_conversion || e.Column == colIdProducto || e.Column == col_IdUnidadMedida)
                {
                    if (InfoDet.IdUnidadMedida_sinConversion != null)
                    {
                        if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, InfoDet.IdProducto))
                            Info_Producto_Selected_View = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto && p.Lote == InfoDet.Lote);
                        else
                            Info_Producto_Selected_View = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);

                        if (Info_Producto_Selected_View != null)
                        {
                            info_unidad_equiv = bus_unidad_equiv.Get_Info_in_UnidadMedida_Equiv_conversion(InfoDet.IdUnidadMedida_sinConversion, Info_Producto_Selected_View.IdUnidadMedida_Consumo);
                            if (info_unidad_equiv != null)
                            {
                                InfoDet.dm_cantidad = InfoDet.dm_cantidad_sinConversion * info_unidad_equiv.valor_equiv;
                            }
                            else
                                MessageBox.Show("No existe una conversión de " + InfoDet.IdUnidadMedida_sinConversion + " a " + Info_Producto_Selected_View.IdUnidadMedida_Consumo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                if (e.Column == coldm_cantidad_sin_conversion)
                {
                    if (info_parametros.Maneja_Stock_Negativo == "N")
                    {
                        if (InfoDet.IdProducto > 0)
                        {                            
                            in_Producto_Info ItemProd_Busc = new in_Producto_Info();

                            // Consultar Stock del producto por Fecha de movimiento
                            bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                            double stock_a_fecha = bus_IngEgr.Obtener_Stock_x_FechaMovimiento(param.IdEmpresa, param.IdSucursal, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), InfoDet.IdProducto, Convert.ToDateTime(dtpFecha.EditValue));

                            if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, InfoDet.IdProducto))
                                ItemProd_Busc = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto && p.Lote == InfoDet.Lote);
                            else
                                ItemProd_Busc = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);

                            if (InfoDet.dm_cantidad_sinConversion > stock_a_fecha)
                            {
                                MessageBox.Show("Item: " + ItemProd_Busc.pr_descripcion + " no puede ser mayor al stock " + stock_a_fecha + " con fecha " + Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                                InfoDet.dm_cantidad_sinConversion = stock_a_fecha;
                                InfoDet.dm_cantidad = stock_a_fecha;
                                return;
                            }

                            if (InfoDet.dm_cantidad_sinConversion < 0)
                            {
                                InfoDet.dm_cantidad_sinConversion = InfoDet.dm_cantidad_sinConversion * -1;
                                InfoDet.dm_cantidad = InfoDet.dm_cantidad_sinConversion;
                            }
                        }
                    }
                }

                // Obtiene objeto bodega seleccionado
                tb_Bodega_Info Info_Bodega = ucIn_Sucursal_Bodega1.get_bodega();

                // Si no es vacio y tiene asignado un centro de costo
                if (Info_Bodega != null && Info_Bodega.IdCentroCosto != null)
                {
                    // Asigna a la fila actual el centro de costo asociado a la bodega
                    InfoDet.IdCentroCosto = Info_Bodega.IdCentroCosto;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Egresos_Varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Egreso_varios_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean ValidarDatos()
        {
            try
            {

                txtObservacion.Focus();
                if (ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == null || ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == null || ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbTipoMovi.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_MotivoInvCmb1.get_MotivoInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el motivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese la Observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (dtpFecha.EditValue == null)
                {
                    MessageBox.Show("Ingrese la Fecha de la Transacción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (List_Bind_IngEgrDet.Count() <= 0)
                {
                    MessageBox.Show("Ingrese al menos un Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        List<string> grupo_mp = new List<string>();
                        grupo_mp.Add("1"); // Materia Prima
                        grupo_mp.Add("2"); // Suministros

                        // Obtengo el total de items con costo 0
                        int iTotalItemsCostoCero = List_Bind_IngEgrDet.Where(q => q.mv_costo == 0 || q.mv_costo_sinConversion == 0).Count();
                        int iTotalItemsGrupoMP = List_Bind_IngEgrDet.Where(q => grupo_mp.Contains(q.IdCategoria)).Count();

                        // Si el resultado de items con costo 0 es mayor a 0 y es diferente al numero de elementos de mi lista. 
                        if (iTotalItemsCostoCero > 0 && iTotalItemsCostoCero != List_Bind_IngEgrDet.Count())
                        {
                            MessageBox.Show("¡Cuidado! No se pueden mezclar items con costo $0 con items que tienen costo. Por favor, asegúrate de combinar elementos que tengan costo para evitar problemas en el sistema.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        if (iTotalItemsGrupoMP > 0 && iTotalItemsGrupoMP != List_Bind_IngEgrDet.Count())
                        {
                            MessageBox.Show("¡Atención! No se pueden mezclar items que no sean de Materia Prima o Suministros. Por favor, verifica los elementos que estás intentando combinar.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        break;
                }

                foreach (var item in List_Bind_IngEgrDet)
                {
                    if (item.IdUnidadMedida_sinConversion == "" || item.IdUnidadMedida_sinConversion == null)
                    {
                        MessageBox.Show("Seleccione la Unidad de Medida para el Producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    // info_parametros.
                    //if (item.IdCentroCosto == "" || item.IdCentroCosto == null)
                    //{
                    //    MessageBox.Show("Seleccione un centro de costo para el Producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return false;
                    //}
                    if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    {
                        MessageBox.Show("Existen items aprobados en este egreso de bodega y no se puede modificar " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (info_parametros.Maneja_Stock_Negativo == "N")
                    {
                        if (item.IdProducto > 0)
                        {
                            in_Producto_Info ItemProd_Busc = new in_Producto_Info();

                            // Consultar Stock del producto por Fecha de movimiento
                            bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                            double stock_a_fecha = bus_IngEgr.Obtener_Stock_x_FechaMovimiento(param.IdEmpresa, param.IdSucursal, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), item.IdProducto, Convert.ToDateTime(dtpFecha.EditValue));

                            if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, InfoDet.IdProducto))
                                ItemProd_Busc = listProducto.FirstOrDefault(p => p.IdProducto == item.IdProducto && p.Lote == item.Lote);
                            else
                                ItemProd_Busc = listProducto.FirstOrDefault(p => p.IdProducto == item.IdProducto);

                            if (item.dm_cantidad_sinConversion > stock_a_fecha)
                            {
                                MessageBox.Show("Item: " + ItemProd_Busc.pr_descripcion + " no puede ser mayor al stock " + stock_a_fecha + " con fecha " + Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                                item.dm_cantidad_sinConversion = stock_a_fecha;
                                item.dm_cantidad = stock_a_fecha;
                                return false;
                            }

                            if (item.dm_cantidad_sinConversion < 0)
                            {
                                item.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion * -1;
                                item.dm_cantidad = item.dm_cantidad_sinConversion;
                            }
                        }
                    }

                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.CAH:
                            if (item.IdMotivo_Inv == null)
                            {
                                MessageBox.Show("Seleccione un motivo para el Producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                            break;
                        case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                            if (item.IdCentroCosto_sub_centro_costo == "" || item.IdCentroCosto_sub_centro_costo == null)
                            {
                                MessageBox.Show("Seleccione el subcentro de costo para el producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                            break;
                    }
                }


                if (info_parametros != null)
                {
                    if (info_parametros.Maneja_Stock_Negativo.Trim() == "N")
                    {
                        string Producto_no_contabilizado = "";
                        List<decimal> revisados = new List<decimal>();
                        int res = 0;
                        foreach (var item in List_Bind_IngEgrDet)
                        {

                            if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.FJ)
                            {
                                if (item.IdCentroCosto_sub_centro_costo == null)
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Subcentro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }

                            res = revisados.Where(q => q == item.IdProducto).Count();
                            if (res == 0)
                            {
                                double cantidad_pedida = Math.Round(List_Bind_IngEgrDet.Where(q => q.IdProducto == item.IdProducto).Sum(q => q.dm_cantidad), 2, MidpointRounding.AwayFromZero);
                                in_Producto_Info producto = Bus_Producto.Get_Producto_X_Bodega(param.IdEmpresa, ucIn_Sucursal_Bodega1.get_sucursal().IdSucursal, ucIn_Sucursal_Bodega1.get_bodega().IdBodega, item.IdProducto);
                                double cantidad_disponible = Convert.ToDouble(producto.pr_stock) - Math.Abs(Convert.ToDouble(producto.pr_Pedidos_inv));

                                if (cantidad_disponible < cantidad_pedida)
                                {
                                    MessageBox.Show("Producto: " + producto.pr_descripcion_2 + "\nStock actual en bodega: " + producto.pr_stock.ToString() + " " + producto.nom_UnidadMedida_Consumo + "\nCantidad pedida no aprobada :" + Math.Abs(Convert.ToDouble(producto.pr_Pedidos_inv)) + " " + producto.nom_UnidadMedida_Consumo + " \nCantidad pedida en este egreso: " + cantidad_pedida.ToString() + " " + producto.nom_UnidadMedida_Consumo + " \nCorrija las cantidades.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                                bool se_valida_paramatrizacion_contable_x_producto = info_parametros.P_se_valida_parametrizacion_x_producto == null ? false : (bool)info_parametros.P_se_valida_parametrizacion_x_producto;
                                if (se_valida_paramatrizacion_contable_x_producto)
                                {
                                    if (producto.IdCtaCble_Inventario == null || producto.IdCtaCble_Costo == null)
                                    {
                                        if (Producto_no_contabilizado == "") Producto_no_contabilizado = producto.pr_descripcion_2;
                                        else Producto_no_contabilizado += "\n" + producto.pr_descripcion_2;
                                    }
                                }
                                revisados.Add(item.IdProducto);
                            }
                        }

                        //J.A ACTUALIZADO 11-06-2018 
                        in_movi_inven_tipo_Bus BusMoti_InvTipo = new in_movi_inven_tipo_Bus();
                        in_movi_inven_tipo_Info info_MotInvTipo = new in_movi_inven_tipo_Info();

                        info_MotInvTipo = BusMoti_InvTipo.Get_Info_movi_inven_tipo(param.IdEmpresa, cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo);

                        if (info_MotInvTipo.Genera_Diario_Contable == true)
                        {
                            if (Producto_no_contabilizado != "")
                            {
                                MessageBox.Show("Los siguientes productos no estan parametrizados contablemente, por favor corrija:\n" + Producto_no_contabilizado, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }

                    }
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.EditValue)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridViewProductos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProductos.GetRow(e.RowHandle) as in_Ing_Egr_Inven_det_Info;
                if (data == null)
                    return;

                if (data.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    e.Appearance.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_diarios_Click(object sender, EventArgs e)
        {
            try
            {
                // consulta grid contable             
                var item = List_Bind_IngEgrDet.FirstOrDefault();
                if (item != null)
                    ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_punto_cargo_Click(object sender, EventArgs e)
        {
            try
            {
                in_Ing_Egr_Inven_det_Info row = (in_Ing_Egr_Inven_det_Info)gridViewProductos.GetFocusedRow();
                if (row != null)
                {
                    if (row.IdPunto_cargo_grupo != null)
                    {
                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                        GridViewInfo info = gridViewProductos.GetViewInfo() as GridViewInfo;
                        GridCellInfo info_cell = info.GetGridCellInfo(RowHandle, colIdPunto_cargo);

                        frm_cons.Cargar_grid_x_grupo((int)row.IdPunto_cargo_grupo);

                        //frm_cons.Location = new Point(this.Right, gridControlDiario.Top);                        

                        frm_cons.ShowDialog();
                        info_punto_cargo = frm_cons.Get_Info();
                        if (info_punto_cargo != null)
                        {
                            gridViewProductos.SetFocusedRowCellValue(colIdPunto_cargo, info_punto_cargo.IdPunto_cargo);
                        }
                        else
                            gridViewProductos.SetFocusedRowCellValue(colIdPunto_cargo, null);
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

        private void Llamar_pantalla_subcentro()
        {
            try
            {
                in_Ing_Egr_Inven_det_Info Row = (in_Ing_Egr_Inven_det_Info)gridViewProductos.GetRow(RowHandle);
                if (Row != null)
                {
                    if (Row.IdCentroCosto != null)
                    {
                        List<ct_centro_costo_sub_centro_costo_Info> Lista_subcentro_consulta = new List<ct_centro_costo_sub_centro_costo_Info>();
                        Lista_subcentro_consulta = list_subcentro_combo.Where(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto == Row.IdCentroCosto).ToList();
                        if (Lista_subcentro_consulta != null && Lista_subcentro_consulta.Count != 0)
                        {
                            frmCon_ct_centro_costo_sub_centro_costo_Cons frm_combo = new frmCon_ct_centro_costo_sub_centro_costo_Cons();
                            frm_combo.Set_config_combo(Lista_subcentro_consulta);
                            frm_combo.ShowDialog();
                            info_subcentro = frm_combo.Get_info_centro_sub_centro_costo();
                            gridViewProductos.SetRowCellValue(RowHandle, colIdRegistro_subcentro, info_subcentro == null ? null : info_subcentro.IdRegistro);
                            gridViewProductos.SetRowCellValue(RowHandle, col_IdCentroCosto_sub_centro_costo, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_subcentro_costo_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_pantalla_subcentro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_unidad_medida_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_pantalla_unidad_medida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Llamar_pantalla_unidad_medida()
        {
            try
            {
                lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
                decimal IdProducto = 0;
                if (RowHandle >= 0)
                {
                    IdProducto = Convert.ToDecimal(gridViewProductos.GetRowCellValue(RowHandle, colIdProducto));
                    Item = listProducto.FirstOrDefault(q => q.IdProducto == IdProducto);
                    if (Item != null)
                    {
                        lst_unidad_medida_para_combo = bus_unidad_medida.Get_list_UnidadMedida_equivalencia(Item.IdUnidadMedida);

                        FrmIn_Unidad_Medida_Consu frm_combo = new FrmIn_Unidad_Medida_Consu();
                        frm_combo.set_config_combo(lst_unidad_medida_para_combo);
                        frm_combo.ShowDialog();
                        info_unidad_medida = frm_combo.Get_info_unidad_medida();
                        gridViewProductos.SetRowCellValue(RowHandle, colIdUnidadMedida_sinConversion, info_unidad_medida == null ? null : info_unidad_medida.IdUnidadMedida);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void IdCentroCosto_sub_centro_costo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_subcentro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_subcentro_costo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_subcentro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_unidad_medida_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_unidad_medida();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewProductos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;

                if (RowHandle != 0)
                {
                    /* SE COMENTO PORQUE EN GRAFINPREN NI EN NATURISA SE USA ESTO, SUPONGO Q ES DE ALEMAN PERO HAY QUE REVISARLO PORQUE NO TE DEJA GRABAR
                    if (List_Bind_IngEgrDet.Count() != 0)
                    {
                        if (List_Bind_IngEgrDet.Last().IdProducto != 0 && List_Bind_IngEgrDet.Last().dm_cantidad != 0 && List_Bind_IngEgrDet.Last().IdUnidadMedida != null)
                        {
                            in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                            info.IdCentroCosto = InfoDet.IdCentroCosto;
                            info.IdPunto_cargo_grupo = InfoDet.IdPunto_cargo_grupo;
                            info.IdMotivo_Inv = InfoDet.IdMotivo_Inv;
                            info.IdPunto_cargo = InfoDet.IdPunto_cargo;
                            List_Bind_IngEgrDet.Add(info);
                        }

                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void lblPlantilla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string filePath = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_inventario);
                    MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_buscar_guia_Click(object sender, EventArgs e)
        {
        }

        private void gridViewProductos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == colNew.Name)
                {
                    llamarFormulario_Producto();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void llamarFormulario_Producto()
        {
            try
            {
                FrmIn_Producto_Mant frm = new FrmIn_Producto_Mant();

                if (gridViewProductos.GetFocusedRowCellValue(colIdProducto) != null)
                {
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    in_Producto_Info Into_Producto_Selected = listProducto.Find(q => q.IdEmpresa == param.IdEmpresa && q.IdProducto == Convert.ToDecimal(gridViewProductos.GetFocusedRowCellValue(colIdProducto)));

                    frm.set_Info_producto(Into_Producto_Selected);
                }

                frm.event_FrmIn_Producto_Mant_FormClosing += frm_event_FrmIn_Producto_Mant_FormClosing;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            CargarProducto();
        }
    }
}