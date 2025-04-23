using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Bizu.Application.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.Compras;
using Bizu.Domain.Compras;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;
using Bizu.Application.Contabilidad;
using Bizu.Domain.Contabilidad;
using Bizu.Reports.Compras;
using Bizu.Reports.Inventario;
using Bizu.Presentation.General;
using Bizu.Presentation.Contabilidad;
using DevExpress.XtraReports.UI;
using System.Reflection;

namespace Bizu.Presentation.Inventario
{
    public partial class FrmIn_Ingreso_x_GuiaRemision_Mant : DevExpress.XtraEditors.XtraForm
    {
        public delegate void delegate_FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing event_FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing;

        #region Declaración de Variables
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int RowHandle = 0;

        //cp_proveedor_Bus bus_Proveedor;
        vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Bus bus_IngxGuia = new vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Bus();
        in_Ing_Egr_Inven_det_Bus Bus_IngEgrDet;
        in_Ing_Egr_Inven_Bus Bus_IngEgr;
        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        ct_punto_cargo_Bus bus_puntoCargo;
        in_UnidadMedida_Bus Bus_Uni_Med;
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        in_Parametro_Bus Bus_param_inv = new in_Parametro_Bus();
        in_Motivo_Inven_Bus bus_MotivoInv;
        in_Parametro_Bus parametros_B = new in_Parametro_Bus();
        ct_punto_cargo_grupo_Bus bus_grupo = new ct_punto_cargo_grupo_Bus();
        vwIn_UnidadMedida_Equivalencia_Bus busUniEqui = new vwIn_UnidadMedida_Equivalencia_Bus();

        //Listas
        List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info> list;
        List<ct_Centro_costo_Info> list_centroCosto;
        List<ct_punto_cargo_Info> listPuntoCargo = new List<ct_punto_cargo_Info>();
        List<in_UnidadMedida_Info> list_UniMe;
        List<in_Motivo_Inven_Info> list_MotivoInv;
        List<in_Ing_Egr_Inven_det_Info> lista_IngEgrInv;
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();
        List<ct_punto_cargo_grupo_Info> list_grupo = new List<ct_punto_cargo_grupo_Info>();
        BindingList<in_Ing_Egr_Inven_det_Info> ListaBind;
        BindingList<vwIn_UnidadMedida_Equivalencia_Info> BindListaUnidadMedida = new BindingList<vwIn_UnidadMedida_Equivalencia_Info>();
        List<in_Ing_Egr_Inven_det_Info> list_IngxComp;

        //Infos
        in_Parametro_Info Info_param_inv;
        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        public in_Ing_Egr_Inven_Info SETINFO_ { get; set; }
        in_Ing_Egr_Inven_det_Info Info;
        in_Ing_Egr_Inven_Info info_IngComp = new in_Ing_Egr_Inven_Info();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();

        //Variables
        string MensajeError = "";
        private Cl_Enumeradores.eTipo_action Accion;
        #endregion

        public FrmIn_Ingreso_x_GuiaRemision_Mant()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
                ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
                ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;

                ucIn_Sucursal_Bodega1.Event_cmb_bodega1_EditValueChanged += UcIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged;

                event_FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing += FrmIn_Ingreso_x_GuiaRemision_Mant_event_FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing;
                gridViewIngreso.CellValueChanging += gridViewIngreso_CellValueChanging;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UcIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbTipoMovi.cargar_TipoMotivo(Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), "+", "");
                cmbTipoMovi.cmbCatalogo.EditValue = Info_param_inv.IdMovi_Inven_tipo_x_Anulacion_GuiaRemision;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Validar())
                    return;

                this.grabar();
            }
            catch (Exception exception)
            {
                string str = MethodBase.GetCurrentMethod().Name + " " + base.Name;
                this.Log_Error_bus.Log_Error(str + " - " + exception.ToString());
                MessageBox.Show(str + " - " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Validar()) return;
                if (!this.grabar()) return;
                base.Close();
            }
            catch (Exception exception)
            {
                string str = MethodBase.GetCurrentMethod().Name + " " + base.Name;
                this.Log_Error_bus.Log_Error(str + " - " + exception.ToString());
                MessageBox.Show(str + " - " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Imprimir();
            }
            catch (Exception exception)
            {
                string str = MethodBase.GetCurrentMethod().Name + " " + base.Name;
                this.Log_Error_bus.Log_Error(str + " - " + exception.ToString());
                MessageBox.Show(str + " - " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                this.LimpiarDatos();
            }
            catch (Exception exception)
            {
                string str = MethodBase.GetCurrentMethod().Name + " " + base.Name;
                this.Log_Error_bus.Log_Error(str + " - " + exception.ToString());
                MessageBox.Show(str + " - " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                this.Get();
                string msgs = "";
                this.info_IngComp.IdusuarioUltAnu = this.param.IdUsuario;
                this.info_IngComp.Fecha_UltAnu = this.param.Fecha_Transac;
                if (MessageBox.Show("Esta Seguro que desea eliminar el Item", "Sistemas ERP", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    if (this.lblAnulado.Visible)
                    {
                        MessageBox.Show("No se puede Anular un item anulado");
                    }
                    else
                    {
                        FrmGe_MotivoAnulacion anulacion = new FrmGe_MotivoAnulacion();
                        anulacion.ShowDialog();
                        this.info_IngComp.MotivoAnulacion = anulacion.motivoAnulacion;
                        this.Bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (!this.Bus_IngEgr.AnularDB(this.info_IngComp, ref msgs))
                        {
                            MessageBox.Show("Registro anulado con éxito!", this.param.Nombre_sistema);
                        }
                        else
                        {
                            MessageBox.Show(msgs, "Sistemas");
                            this.lblAnulado.Visible = true;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                string str3 = MethodBase.GetCurrentMethod().Name + " " + base.Name;
                MessageBox.Show(str3 + " - " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Log_Error_bus.Log_Error(str3 + " - " + exception.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                base.Close();
            }
            catch (Exception exception)
            {
                string str = MethodBase.GetCurrentMethod().Name + " " + base.Name;
                this.Log_Error_bus.Log_Error(str + " - " + exception.ToString());
                MessageBox.Show(str + " - " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public Boolean ValidarParametros()
        {
            try
            {
                var itemparam = parametros_B.Get_Info_Parametro(param.IdEmpresa);

                if (string.IsNullOrEmpty(itemparam.ApruebaAjusteFisicoAuto))
                {
                    return false;
                }

                if (string.IsNullOrEmpty(itemparam.IdCtaCble_CostoInven))
                {
                    return false;
                }
                //if (string.IsNullOrEmpty(itemparam.IdCtaCble_Inven)) 
                //{
                //    return false;
                //}
                if (!itemparam.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_egresoAjuste.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_egresoBodegaOrigen.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_ingresoAjuste.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_inven_tipo_ingresoBodegaDestino.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_Inven_tipo_x_anu_Egr.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdMovi_Inven_tipo_x_anu_Ing.HasValue)
                {
                    return false;
                }
                if (itemparam.IdSucursalSuministro == 0)
                {
                    return false;
                }
                if (!itemparam.IdTipoCbte_CostoInven.HasValue)
                {
                    return false;
                }
                if (!itemparam.IdTipoCbte_CostoInven_Reverso.HasValue)
                {
                    return false;
                }
                if (string.IsNullOrEmpty(itemparam.Maneja_Stock_Negativo))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(itemparam.Mostrar_CentroCosto_en_transacciones))
                {
                    return false;
                }



                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        void gridViewIngreso_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void FrmIn_Ingreso_x_GuiaRemision_Mant_event_FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void Imprimir()
        {
            try
            {
                XINV_Rpt001_Rpt Reporte = new XINV_Rpt001_Rpt();
                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdSucursal"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                Reporte.Parameters["IdBodega"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                Reporte.Parameters["IdTipoMoviInv"].Value = Info_param_inv.IdMovi_Inven_tipo_x_Anulacion_GuiaRemision;
                Reporte.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);

                Reporte.RequestParameters = false;
                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_Combos()
        {
            try
            {
                //carga centro costo
                list_centroCosto = new List<ct_Centro_costo_Info>();
                list_centroCosto = Bus_CentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmbCentroCosto_grid.DataSource = list_centroCosto;

                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_sub_centro_costo.DataSource = list_subcentro_combo;

                bus_puntoCargo = new ct_punto_cargo_Bus();
                listPuntoCargo = new List<ct_punto_cargo_Info>();
                listPuntoCargo = bus_puntoCargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmbPuntoCargo_grid.DataSource = listPuntoCargo;

                list_grupo = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_grupo_punto_cargo.DataSource = list_grupo;



                Bus_Uni_Med = new in_UnidadMedida_Bus();
                list_UniMe = new List<in_UnidadMedida_Info>();
                list_UniMe = Bus_Uni_Med.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = list_UniMe;
                cmb_unidad_medida.DisplayMember = "Descripcion";
                cmb_unidad_medida.ValueMember = "IdUnidadMedida";

                //carga Motivo Inventario  
                bus_MotivoInv = new in_Motivo_Inven_Bus();
                list_MotivoInv = new List<in_Motivo_Inven_Info>();
                list_MotivoInv = bus_MotivoInv.Get_List_Motivo_Inven(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        this.txtNumIngreso.Enabled = false;
                        this.txtNumIngreso.BackColor = System.Drawing.Color.White;
                        this.txtNumIngreso.ForeColor = System.Drawing.Color.Black;

                        //dtpFecha.Enabled = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        Inhabilita_Controles();

                        checkTodos.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;

                        Inhabilita_Controles();

                        dtpFecha.Enabled = false;

                        txtObservacion.Enabled = false;
                        txtObservacion.BackColor = System.Drawing.Color.White;
                        txtObservacion.ForeColor = System.Drawing.Color.Black;

                        checkTodos.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        Inhabilita_Controles();

                        dtpFecha.Enabled = false;

                        txtObservacion.Enabled = false;
                        txtObservacion.BackColor = System.Drawing.Color.White;
                        txtObservacion.ForeColor = System.Drawing.Color.Black;

                        checkTodos.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inhabilita_Controles()
        {
            try
            {
                cmbMotivoInv.Enabled = false;
                cmbMotivoInv.BackColor = System.Drawing.Color.White;
                cmbMotivoInv.ForeColor = System.Drawing.Color.Black;
                ucIn_Sucursal_Bodega1.cmb_sucursal.Enabled = false;
                ucIn_Sucursal_Bodega1.cmb_bodega.Enabled = false;
                txtNumIngreso.Enabled = false;
                txtNumIngreso.BackColor = System.Drawing.Color.White;
                txtNumIngreso.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Ingreso_x_GuiaRemision_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Info_param_inv = Bus_param_inv.Get_Info_Parametro(param.IdEmpresa);

                if (Info_param_inv == null)
                {
                    MessageBox.Show("No se ha establecido los parametros de inventario, por favor asegurese de haber parametrizado el modulo de inventario!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Info_param_inv.IdMovi_Inven_tipo_x_Anulacion_GuiaRemision == null)
                {
                    MessageBox.Show("Antes de continuar por favor ingrese el tipo de movimiento para ingreso x devolucion en la pantalla de parámetros del modulo de inventario!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Info_param_inv.IdMotivo_Inv_x_Anulacion_GuiaRemision == null)
                {
                    MessageBox.Show("Antes de continuar por favor ingrese el motivo para ingreso x devolucion en la pantalla de parámetros del modulo de inventario!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                cmbMotivoInv.cmbMotivoInv.EditValue = Info_param_inv.IdMotivo_Inv_x_Anulacion_GuiaRemision;

                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlIngreso.DataSource = ListaBind;

                dtpFecha.Value = param.Fecha_Transac;

                carga_Combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        setInfo();
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        setInfo();
                        Inhabilita_Controles();
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Always;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        setInfo();
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtNumIngreso.Text = "";
                cmbMotivoInv.Inicializar_cmbMotivoInv();
                txtObservacion.Text = "";
                dtpFecha.Value = param.Fecha_Transac;
                info_IngComp = new in_Ing_Egr_Inven_Info();
                info_IngComp.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlIngreso.DataSource = ListaBind;
                ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(0, 0, 0, 0, 0);
                ucIn_Sucursal_Bodega1.InicializarBodega();
                ucIn_Sucursal_Bodega1.InicializarSucursal();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get()
        {
            try
            {
                info_IngComp.IdEmpresa = param.IdEmpresa;
                info_IngComp.IdNumMovi = Convert.ToDecimal((txtNumIngreso.Text == "") ? "0" : txtNumIngreso.Text);
                info_IngComp.IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                info_IngComp.IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                info_IngComp.CodMoviInven = "";
                info_IngComp.IdMotivo_Inv = cmbMotivoInv.get_MotivoInvInfo().IdMotivo_Inv;
                info_IngComp.cm_observacion = txtObservacion.Text;
                info_IngComp.cm_fecha = dtpFecha.Value;
                info_IngComp.signo = "+";
                info_IngComp.numGuia = txt_serie1.EditValue + "-" + txt_serie2.EditValue + "-" + txt_secuencia.EditValue;

                info_IngComp.IdMovi_inven_tipo = Convert.ToInt32(cmbTipoMovi.cmbCatalogo.EditValue);
                info_IngComp.Fecha_Transac = param.Fecha_Transac;
                info_IngComp.nom_pc = param.nom_pc;
                info_IngComp.ip = param.ip;
                info_IngComp.IdUsuario = param.IdUsuario;

                GetDetalle();

                info_IngComp.listIng_Egr = list_IngxComp;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetDetalle()
        {
            try
            {
                list_IngxComp = new List<in_Ing_Egr_Inven_det_Info>();

                int focus = gridViewIngreso.FocusedRowHandle;
                gridViewIngreso.FocusedRowHandle = focus + 1;

                foreach (var item in ListaBind)
                {
                    if (item.IdEstadoAproba == null || item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                    {
                        in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();

                        if (item.Checked == true)
                        {
                            info_IngComp.numGuia = item.NumGuia;

                            info.Checked = item.Checked;
                            //info.IdEmpresa_oc = item.IdEmpresa_oc;
                            //info.IdSucursal_oc = item.IdSucursal_oc;
                            //info.IdOrdenCompra = item.IdOrdenCompra;
                            //info.Secuencia_oc = item.Secuencia_oc;

                            info.IdEmpresa_gr = item.IdEmpresa_gr;
                            info.IdSucursal_gr = item.IdSucursal_gr;
                            info.IdGuiaRemision = item.IdGuiaRemision;
                            info.Secuencia_gr = item.Secuencia_gr;

                            info.IdProducto = item.IdProducto;
                            info.dm_stock_ante = item.dm_stock_ante;
                            info.dm_stock_actu = item.dm_stock_actu;
                            info.dm_observacion = item.dm_observacion;

                            info.dm_precio = item.dm_precio;
                            info.mv_costo_sinConversion = item.mv_costo;
                            info.mv_costo = item.mv_costo;

                            info.dm_peso = item.dm_peso;

                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = (item.IdCentroCosto_sub_centro_costo == null) ? null : list_subcentro_combo.FirstOrDefault(v => v.IdCentroCosto == item.IdCentroCosto && v.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).IdCentroCosto_sub_centro_costo;

                            info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                            info.IdPunto_cargo = item.IdPunto_cargo;
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdNumMovi = item.IdNumMovi;
                            info.Secuencia = item.Secuencia;
                            info.IdBodega = item.IdBodega;
                            info.pr_descripcion = item.pr_descripcion;

                            info.dm_cantidad_sinConversion = item.dm_cantidad;
                            info.IdUnidadMedida_sinConversion = item.IdUnidadMedida;

                            info.dm_cantidad = item.dm_cantidad;
                            info.IdUnidadMedida = item.IdUnidadMedida;
                            info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                            if (cmbMotivoInv.get_MotivoInvInfo() != null)
                                info.IdMotivo_Inv = cmbMotivoInv.get_MotivoInvInfo().IdMotivo_Inv;

                            list_IngxComp.Add(info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setInfo()
        {
            try
            {
                txtNumIngreso.Text = Convert.ToString(SETINFO_.IdNumMovi);
                ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = SETINFO_.IdSucursal;
                ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = SETINFO_.IdBodega;
                dtpFecha.Value = SETINFO_.cm_fecha;
                cmbMotivoInv.set_MotivoInvInfo(Convert.ToInt32(SETINFO_.IdMotivo_Inv));
                txtObservacion.Text = SETINFO_.cm_observacion;
                lblAnulado.Visible = SETINFO_.Estado == "I" ? true : false;

                //consulta detalle          
                Bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();
                lista_IngEgrInv = new List<in_Ing_Egr_Inven_det_Info>();
                lista_IngEgrInv = Bus_IngEgrDet.Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(param.IdEmpresa, SETINFO_.IdSucursal, SETINFO_.IdMovi_inven_tipo, SETINFO_.IdNumMovi);

                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>(lista_IngEgrInv);
                gridControlIngreso.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (ucIn_Sucursal_Bodega1.get_sucursal() == null || ucIn_Sucursal_Bodega1.get_sucursal().IdSucursal == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " una sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.get_bodega() == null || ucIn_Sucursal_Bodega1.get_bodega().IdBodega == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Info_param_inv == null)
                {
                    MessageBox.Show("No se ha establecido los parametros de inventario, por favor asegurese de haber parametrizado el modulo de inventario!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Info_param_inv.IdMovi_Inven_tipo_x_Anulacion_GuiaRemision == null)
                {
                    MessageBox.Show("Antes de continuar por favor ingrese el tipo de movimiento para ingreso de Obra en la pantalla de parámetros del modulo de inventario!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbMotivoInv.cmbMotivoInv.EditValue == null)
                {
                    MessageBox.Show("Por favor seleccione el motivo!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                tb_Sucursal_Info info_Sucursal = new tb_Sucursal_Info();
                info_Sucursal = ucIn_Sucursal_Bodega1.get_sucursal();

                tb_Bodega_Info info_Bodega = new tb_Bodega_Info();
                info_Bodega = ucIn_Sucursal_Bodega1.get_bodega();

                if (MessageBox.Show("¿Está seguro que desea generar el ingreso a la bodega [" + info_Bodega.IdBodega + "] " + info_Bodega.bo_Descripcion + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean grabar()
        {
            try
            {
                string mensaje = "";

                txtNumIngreso.Focus();
                Get();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        decimal IdIngreso_gr = 0;
                        Bus_IngEgr = new in_Ing_Egr_Inven_Bus();

                        if (Bus_IngEgr.GuardarDB(info_IngComp, ref IdIngreso_gr, ref mensaje))
                        {
                            txtNumIngreso.Text = Convert.ToString(IdIngreso_gr);
                            string smensaje = "";

                            if (mensaje == "")
                                smensaje = string.Format("{0} # {1} se guardó con éxito.", "El registro del Ingreso a Bodega ", IdIngreso_gr.ToString());
                            else
                                smensaje = mensaje;

                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //consulta detalle
                            var lista_mov = from T in info_IngComp.listIng_Egr group T by new { T.IdEmpresa_gr, T.IdSucursal_gr, T.IdGuiaRemision } into grouping
                                            let count = grouping.Count()
                                            select new { grouping.Key };

                            // actualizar estado cierre cabecera GR
                            Bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();

                            foreach (var item in lista_mov)
                            {
                                string Estado_cierre = "";

                                //consulta detalle GR
                                in_GuiaRemision_Det_Bus Bus_GuiaRemision_Det = new in_GuiaRemision_Det_Bus();
                                in_GuiaRemision_Bus Bus_GuiaRemision = new in_GuiaRemision_Bus();
                                
                                //OBTENGO LA CANTIDAD TOTAL INGRESADA AGRUPADA POR GUIA DE REMISION
                                List<in_Ing_Egr_Inven_det_Info> lista_agrupada_INV = Bus_IngEgrDet.Get_List_Ing_Egr_det_x_GR_Agrupado(Convert.ToInt32(item.Key.IdEmpresa_gr), Convert.ToInt32(item.Key.IdSucursal_gr), Convert.ToDecimal(item.Key.IdGuiaRemision));
                                var cantidadTotal_Ingresada = lista_agrupada_INV.FirstOrDefault().dm_cantidad;

                                //OBTENGO LA CANTIDAD TOTAL DE LA GUIA DE REMISION
                                List<in_GuiaRemision_Det_Info> Lista_GR = Bus_GuiaRemision_Det.Get_List(Convert.ToInt32(item.Key.IdEmpresa_gr), Convert.ToInt32(item.Key.IdSucursal_gr), Convert.ToDecimal(item.Key.IdGuiaRemision));

                                //GUIA REMISIOM DETALLE AGRUPADA PARA OBTENER LA CANTIDAD TOTAL DE LA GUIA
                                var lista_agrupada_GR = from T in Lista_GR
                                                        group T by new { T.IdEmpresa, T.IdSucursal, T.IdGuiaRemision } into grouping
                                                        let count = grouping.Count()
                                                        select new { grouping.Key, cantidadTotal_GuiaRemision = grouping.Sum(p => p.Cantidad_sinConversion) };

                                //OBTENGO EL PRIMER ELEMENTO DE LA LISTA AGRUPADA DE GR
                                var cantidadTotal_GuiaRemision = lista_agrupada_GR.FirstOrDefault(q => q.Key.IdEmpresa == item.Key.IdEmpresa_gr && q.Key.IdSucursal == item.Key.IdSucursal_gr && q.Key.IdGuiaRemision == item.Key.IdGuiaRemision).cantidadTotal_GuiaRemision;

                                if (cantidadTotal_Ingresada > 1 && cantidadTotal_Ingresada < cantidadTotal_GuiaRemision)
                                {
                                    Estado_cierre = "PEN";
                                    Bus_GuiaRemision.Modificar_Estado_Cierre(Convert.ToInt32(item.Key.IdEmpresa_gr), Convert.ToInt32(item.Key.IdSucursal_gr), Convert.ToDecimal(item.Key.IdGuiaRemision), Estado_cierre);
                                }
                                else
                                    if (cantidadTotal_Ingresada == cantidadTotal_GuiaRemision)
                                    {
                                        Estado_cierre = "CERR";
                                        Bus_GuiaRemision.Modificar_Estado_Cierre(Convert.ToInt32(item.Key.IdEmpresa_gr), Convert.ToInt32(item.Key.IdSucursal_gr), Convert.ToDecimal(item.Key.IdGuiaRemision), Estado_cierre);
                                    }

                                if (MessageBox.Show("¿Desea Imprimir el Ingreso a Bodega x G/R. # " + info_IngComp.numGuia + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Imprimir();
                                }
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

                        info_IngComp.IdUsuarioUltModi = param.IdUsuario;
                        info_IngComp.Fecha_UltMod = param.Fecha_Transac;
                        Bus_IngEgr = new in_Ing_Egr_Inven_Bus();

                        if (Bus_IngEgr.ModificarDB(info_IngComp, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el registro: ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridViewIngreso_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_det_Info)this.gridViewIngreso.GetRow(e.RowHandle);
                if (Info == null) return;

                Accion = Cl_Enumeradores.eTipo_action.grabar;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (e.HitInfo.Column != null)
                    {

                        e.HitInfo.Column.FieldName = gridViewIngreso.FocusedColumn.FieldName;

                        if (e.HitInfo.Column.FieldName == "Checked")
                        {
                            if ((Boolean)gridViewIngreso.GetFocusedRowCellValue(col_Checked))
                            {
                                gridViewIngreso.SetFocusedRowCellValue(col_Checked, false);
                            }
                            else
                            {
                                gridViewIngreso.SetFocusedRowCellValue(col_Checked, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngreso_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_det_Info)this.gridViewIngreso.GetRow(e.RowHandle);

                if (Info == null)
                    return;

                if (e.Column == col_Checked)
                {
                    if ((Boolean)gridViewIngreso.GetFocusedRowCellValue(col_Checked))
                    {
                        if (ListaBind.Where(q => q.Checked == true && q.IdGuiaRemision != Info.IdGuiaRemision).Count() > 0)
                        {
                            MessageBox.Show("El registro de ingreso a bodega de productos es por Guía de Remision, por favor verifique que pertenesca a la misma Guía!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            gridViewIngreso.SetFocusedRowCellValue(col_Checked, false);
                            return;
                        }

                        if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad)) == 0)
                        {
                            gridViewIngreso.SetFocusedRowCellValue(col_Saldo_GR_x_Ing, 0);
                            gridViewIngreso.SetFocusedRowCellValue(col_dm_cantidad, gridViewIngreso.GetFocusedRowCellValue(col_Saldo_GR_x_Ing_AUX));
                        }
                    }
                    else
                    {
                        gridViewIngreso.SetFocusedRowCellValue(col_Saldo_GR_x_Ing, gridViewIngreso.GetFocusedRowCellValue(col_Saldo_GR_x_Ing_AUX));

                        if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad)) != 0)
                            gridViewIngreso.SetFocusedRowCellValue(col_dm_cantidad, 0);

                        return;
                    }
                }

                if (e.Column == col_IdCentroCosto)
                {
                    if (!Bus_CentroCosto.Validar_CentroCosto_EstadoObra(param.IdEmpresa, Convert.ToString(Info.IdCentroCosto), ref MensajeError))
                    {
                        MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridViewIngreso.SetFocusedRowCellValue(col_IdCentroCosto, null);
                        return;
                    }
                }

                if (e.Column.Name == col_dm_cantidad.Name)
                {
                    double cantidad_ing_a_Inven = Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad));

                    if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad)) == 0)
                    {
                        gridViewIngreso.SetFocusedRowCellValue(col_Checked, false);
                        return;
                    }

                    if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad)) < 0)
                    {
                        gridViewIngreso.SetFocusedRowCellValue(col_Checked, false);
                        return;
                    }

                    if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad)) > Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_cantidad_sinConversion_GR)))
                    {
                        gridViewIngreso.SetFocusedRowCellValue(col_Checked, false);
                        return;
                    }

                    if (Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad)) <= Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_cantidad_sinConversion_GR)))
                    {
                        gridViewIngreso.SetFocusedRowCellValue(col_Saldo_GR_x_Ing, Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_Saldo_GR_x_Ing_AUX)) - Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_dm_cantidad)));

                        double resul = Convert.ToDouble(gridViewIngreso.GetFocusedRowCellValue(col_Saldo_GR_x_Ing));

                        if (resul < 0)
                        {
                            gridViewIngreso.SetFocusedRowCellValue(col_Checked, false);
                        }
                        else
                        {
                            if (!(Boolean)gridViewIngreso.GetFocusedRowCellValue(col_Checked))
                                gridViewIngreso.SetFocusedRowCellValue(col_Checked, true);
                        }
                    }
                }

                Armar_Obervacion();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Armar_Obervacion()
        {
            try
            {
                string sDescripcion_Marca = "";

                foreach (var item in ListaBind.Where(q => q.Checked))
                {
                    if (string.IsNullOrEmpty(sDescripcion_Marca))
                        sDescripcion_Marca = item.pr_codigo;
                    else
                        sDescripcion_Marca = sDescripcion_Marca + " | " + item.pr_codigo;
                }

                if (!string.IsNullOrEmpty(sDescripcion_Marca))
                    txtObservacion.Text = "ING X DEVOLUCION G/R [" + sDescripcion_Marca + "]";
                else
                    txtObservacion.Text = "ING X DEVOLUCION G/R ";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngreso_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var Item = (in_Ing_Egr_Inven_det_Info)gridViewIngreso.GetRow(e.FocusedRowHandle);
                RowHandle = e.FocusedRowHandle;
                if (Item != null)
                {
                    if (Item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    {
                        col_dm_cantidad.OptionsColumn.AllowEdit = false;
                        col_IdCentroCosto.OptionsColumn.AllowEdit = false;
                        col_IdProducto.OptionsColumn.AllowEdit = false;
                        col_dm_cantidad.OptionsColumn.AllowEdit = false;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        private void checkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                gridViewIngreso.MoveNext();

                for (int i = 0; i < gridViewIngreso.RowCount; i++)
                {
                    {
                        gridViewIngreso.SetRowCellValue(i, col_Checked, checkTodos.Checked);

                        if (checkTodos.Checked)
                        {
                            gridViewIngreso.SetRowCellValue(i, col_dm_cantidad, gridViewIngreso.GetRowCellValue(i, col_Saldo_GR_x_Ing_AUX));
                            gridViewIngreso.SetRowCellValue(i, col_Saldo_GR_x_Ing, 0);
                        }
                        else
                        {
                            gridViewIngreso.SetRowCellValue(i, col_Saldo_GR_x_Ing, gridViewIngreso.GetRowCellValue(i, col_dm_cantidad));
                            gridViewIngreso.SetRowCellValue(i, col_dm_cantidad, 0);
                        }
                    }
                }

                gridControlIngreso.DataSource = ListaBind;
                gridControlIngreso.RefreshDataSource();
                Armar_Obervacion();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {



                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewIngreso.DeleteSelectedRows();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Llamar_a_pantalla_subcentro()
        {
            try
            {
                in_Ing_Egr_Inven_det_Info Row = (in_Ing_Egr_Inven_det_Info)gridViewIngreso.GetRow(RowHandle);
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

        private void cmb_sub_centro_costo_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_a_pantalla_subcentro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbPuntoCargo_grid_Click(object sender, EventArgs e)
        {

        }

        private void cmb_sub_centro_costo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_a_pantalla_subcentro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            gridControlIngreso.ShowPrintPreview();
        }

        private void btn_cargar_datos_Click(object sender, EventArgs e)
        {
            try
            {
                in_GuiaRemision_Bus bus_guiaRemision = new in_GuiaRemision_Bus();
                in_GuiaRemision_Info info_guiaRemision = new in_GuiaRemision_Info();

                if (txt_IdGuiaRemision.EditValue == null)
                {
                    MessageBox.Show("Ingrese ID de la Guía de Remisión!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlIngreso.DataSource = ListaBind;

                info_guiaRemision = bus_guiaRemision.Get_GuiaRemision(param.IdEmpresa, param.IdSucursal, Convert.ToDecimal(txt_IdGuiaRemision.EditValue));

                if(info_guiaRemision!= null)
                {
                    txt_serie1.EditValue = info_guiaRemision.Serie1;
                    txt_serie2.EditValue = info_guiaRemision.Serie2;
                    txt_secuencia.EditValue = info_guiaRemision.NumDocumento;
                    ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = info_guiaRemision.IdSucursal;
                    ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = info_guiaRemision.IdBodega;
                }
                
                list = new List<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo_Info>();
                list = this.bus_IngxGuia.Get_List(param.IdEmpresa, param.IdSucursal, Convert.ToDecimal(txt_IdGuiaRemision.EditValue));

                if (list.Count() == 0)
                {
                    MessageBox.Show("No hay guías de remisión pendientes por ingresar", "Sistemas");
                    return;
                }

                //convertir
                List<in_Ing_Egr_Inven_det_Info> lista_AUX = new List<in_Ing_Egr_Inven_det_Info>();
                foreach (var item in list)
                {
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;

                    info.IdEmpresa_gr = item.IdEmpresa;
                    info.IdSucursal_gr = item.IdSucursal;
                    info.IdGuiaRemision = item.IdGuiaRemision;
                    info.Secuencia_gr = item.Secuencia;

                    info.NumDocumento = item.NumDocumento;
                    info.NumGuia = item.NumGuia;
                    info.Secuencia = item.Secuencia;
                    info.Fecha_registro = item.FechaEmision;
                    info.IdTipo_Persona = item.IdTipo_Persona;
                    info.IdEntidad = item.IdEntidad;
                    info.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.dm_observacion = item.Observacion;
                    info.pr_codigo = item.Codigo;
                    info.pr_descripcion = item.Descripcion;
                    info.IdProducto = Convert.ToDecimal(item.IdProducto);
                    info.IdProyecto = item.IdProyecto;
                    info.NomProyecto = item.NomProyecto;
                    info.dm_precio = 0;
                    info.mv_costo = 0;

                    info.cantidad_GR = item.cantidad_GR;
                    info.cantidad_sinConversion_GR = Convert.ToDouble(item.cantidad_sinConversion_GR);
                    info.cantidad_ing_a_Inven = Convert.ToDouble(item.cantidad_ing_a_Inven);
                    info.Saldo_GR_x_Ing = Convert.ToDouble(item.Saldo_GR_x_Ing);
                    info.Saldo_GR_x_Ing_AUX = Convert.ToDouble(item.Saldo_GR_x_Ing);
                    info.dm_stock_ante = 0;
                    info.dm_stock_actu = 0;
                    info.dm_peso = Convert.ToDouble(item.Peso);
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.Centro_costo = item.Centro_costo;
                    info.Centro_costo2 = item.Centro_costo2;
                    info.IdCentroCosto_sub_centro_costo = null;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.oc_NumDocumento = item.NumDocumento;
                    info.detalle_x_tiem = item.Detalle_x_Item;

                    lista_AUX.Add(info);
                }

                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>(lista_AUX);
                gridControlIngreso.DataSource = ListaBind;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}