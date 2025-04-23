using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Compras;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Pedido_consu_Aprovacion_GE : Form
    {
        com_solicitud_compra_Bus SolComBus = new com_solicitud_compra_Bus();


        //BindingList<fa_pedido_Info> listSolCom = new BindingList<fa_pedido_Info>();

        //
        fa_pedido_Bus SolPedBus = new fa_pedido_Bus();
        BindingList<fa_pedido_Info> listSolPed = new BindingList<fa_pedido_Info>();
        List<fa_pedido_Info> listSolP = new List<fa_pedido_Info>();


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<fa_catalogo_Info> listEstadoAprobacion = new List<fa_catalogo_Info>();

        List<fa_pedido_estadoAprobacion_Info> Lista_Estado_Aprobacion = new List<fa_pedido_estadoAprobacion_Info>();



        
        
        public frmFa_Pedido_consu_Aprovacion_GE()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAprobar_Click += ucGe_Menu_event_btnAprobar_Click;
            ucGe_Menu.event_btnAprobarGuardarSalir_Click += ucGe_Menu_event_btnAprobarGuardarSalir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

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

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridView_solicitud_com.ShowPrintPreview();

                

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
                listSolPed = new BindingList<fa_pedido_Info>();  
                gridControl_solicitud_compra.DataSource = listSolPed;              

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void ucGe_Menu_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {

                if (guardar() )
                {
                    this.Close();
                    cargar_grilla();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        void ucGe_Menu_event_btnAprobar_Click(object sender, EventArgs e)
        {

            try
            {
                if (guardar())
                {
                    cargar_grilla();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        private Boolean guardar()
        {

            try
            {

                //fa_pedido_Info InfoSolCom= new fa_pedido_Info();
                //string msg = "";

                //foreach (var item in listSolCom)
                //{
                //    item.IdUsuarioAprobo = param.IdUsuario;
                //    item.IdUsuarioUltMod = param.IdUsuario;
                //    item.FechaHoraAprobacion = param.Fecha_Transac;
                //    item.Fecha_UltMod = param.Fecha_Transac;

                //}

                //var ListaRes=    listSolCom.ToList().FindAll(v => v.Checked);


                //SolComBus.ModificarDBEstadoAprobacion(ListaRes, ref msg);


                //MessageBox.Show("Actualizacion de Estado de Aprobacion ok...",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                //LimpiarDatos();

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
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



        private void EstadoAprobacion()
        {
            try
            {
                fa_parametro_Bus busParametro = new fa_parametro_Bus();
                fa_parametro_info info = new fa_parametro_info();

                info = busParametro.Get_Info_parametro(param.IdEmpresa);

                fa_pedido_estadoAprobacion_Bus bus_aprobacion = new fa_pedido_estadoAprobacion_Bus();
                Lista_Estado_Aprobacion = bus_aprobacion.Get_List_EstadoAprobacion();
                this.cmb_estado_aprobacion.DataSource = Lista_Estado_Aprobacion;
                this.cmb_estado_aprobacion.DisplayMember = "Descripcion";
                this.cmb_estado_aprobacion.ValueMember = "IdEstadoAprobacion";

                cmb_estado_aprobacion.SelectedValue = info.IdEstadoAprobacion;

                cmbEstadoAprobacion_grid.DataSource = Lista_Estado_Aprobacion;

                //info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                //info.Descripcion = item.Descripcion.Trim();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void cargar_grilla()
        {
            try
            {
                string sTitulo = "";
                string est = "";

                //listSolCom = new BindingList<fa_pedido_Info>(SolComBus.Get_List_solicitud_compra(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, dtpFecha_desde.Value, dtpFecha_Hasta.Value
                //    , cmbEstadoAprobacion.EditValue.ToString()));

                if (est == "")
                {
                    est = Convert.ToString(cmb_estado_aprobacion.SelectedValue);
                }

                listSolPed = new BindingList<fa_pedido_Info>(SolPedBus.Get_List_pedido_estado(param.IdEmpresa, dtpFecha_desde.Value, dtpFecha_Hasta.Value, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal
                     , est));

                gridControl_solicitud_compra.DataSource = listSolPed;

                sTitulo = "Sucursal:" + ucGe_Sucursal_combo1.cmbsucursal.Text + "    " + " Estado de Aprobacion:" + cmb_estado_aprobacion.Text
                    + " Desde:" + dtpFecha_desde.Value.ToShortDateString() + " Hasta:" + dtpFecha_Hasta.Value.ToShortDateString()   ;


                if (gridControl_solicitud_compra.MainView != null)
                {
                    gridControl_solicitud_compra.MainView.ViewCaption = sTitulo;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_grilla();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void frmFa_Pedido_consu_Aprovacion_GE_Load(object sender, EventArgs e)
        {
            try
            {
                EstadoAprobacion();

                dtpFecha_desde.Value = DateTime.Now.AddDays(-60);
                dtpFecha_Hasta.Value = DateTime.Now.AddDays(60);
                cargar_grilla();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void gridControl_solicitud_compra_Click(object sender, EventArgs e)
        {

        }

        private void gridView_solicitud_com_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView_solicitud_com_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                e.HitInfo.Column.FieldName = gridView_solicitud_com.FocusedColumn.FieldName;

                if (e.HitInfo.Column.FieldName == "Checked")
                {
                    if ((Boolean)gridView_solicitud_com.GetFocusedRowCellValue(colChecked)) //verdadero
                    {
                        gridView_solicitud_com.SetFocusedRowCellValue(colChecked, false);
                        return;
                    }
                    else //false
                    {
                        gridView_solicitud_com.SetFocusedRowCellValue(colChecked, true);
                        gridView_solicitud_com.SetFocusedRowCellValue(colIdEstadoAprobacion, "A");
                    }
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void gridView_solicitud_com_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridView_solicitud_com.GetRow(e.RowHandle) as fa_pedido_Info;
             
                if (data == null)
                    return;

                if (data.IdEstadoAprobacion == "A")
                    e.Appearance.ForeColor = Color.Blue;


                if (data.IdEstadoAprobacion == "R")
                    e.Appearance.ForeColor = Color.Red;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
