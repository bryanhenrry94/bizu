using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_CobrosGenerales_Multiretenciones_Consulta : DevExpress.XtraEditors.XtraForm
    {
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        List<cxc_cobro_Info> ListaCobro = new List<cxc_cobro_Info>();


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Sucursal_Bodega UCSucursal = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cxc_cobro_Bus Bus = new cxc_cobro_Bus();
        cxc_cobro_Info info = new cxc_cobro_Info();
        private Cl_Enumeradores.eTipo_action _Accion;

        cxc_retencion_Multiple_Bus BusReten = new cxc_retencion_Multiple_Bus();

        public frmCxc_CobrosGenerales_Multiretenciones_Consulta()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControlCuentaxCobrar.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCxc_CobrosGenerales_Multiretenciones_Man frm = new frmCxc_CobrosGenerales_Multiretenciones_Man();
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdCobro == 0) { return; }
                frmCxc_CobrosGenerales_Multiretenciones_Mant frm = new frmCxc_CobrosGenerales_Multiretenciones_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.Set_info(Bus.Get_Info_cobro_x_cliente(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToDecimal(info.IdCobro), Convert.ToInt32(info.IdCliente)));
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmClose += new frmCxc_CobrosGenerales_Multiretenciones_Mant.Delegate_FrmClose(frm_event_FrmClose);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {              

                if (info.IdCobro == 0) { return; }
                frmCxc_CobrosGenerales_Multiretenciones_Mant frm = new frmCxc_CobrosGenerales_Multiretenciones_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                frm.MdiParent = this.MdiParent;
                frm.Set_info(Bus.Get_Info_cobro_x_cliente(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToDecimal(info.IdCobro), Convert.ToInt32(info.IdCliente)));
                frm.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (info.IdCobro == 0) { return; }

                ba_Cbte_Ban_Info InfoCbteBan_del_deposito = new ba_Cbte_Ban_Info();

                if (Bus.Valida_cobro_x_deposito(info, ref InfoCbteBan_del_deposito))
                {
                    MessageBox.Show("El cobro tiene depositos aplicados y no se puede anular.\n\n" + "Cbte Bancario#:" + InfoCbteBan_del_deposito.IdCbteCble + "\n"
                        + "Banco del Deposito:" + InfoCbteBan_del_deposito.Banco + "\n" + "Fecha del Deposito:" + InfoCbteBan_del_deposito.cb_Fecha.ToShortDateString()
                        , param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                frmCxc_CobrosGenerales_Multiretenciones_Mant frm = new frmCxc_CobrosGenerales_Multiretenciones_Mant();
                cxc_cobro_Info infoCobro = new cxc_cobro_Info();
                frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                infoCobro = Bus.Get_Info_cobro_x_cliente(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToDecimal(info.IdCobro), Convert.ToInt32(info.IdCliente));
                frm.Set_info(infoCobro);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmClose += new frmCxc_CobrosGenerales_Multiretenciones_Mant.Delegate_FrmClose(frm_event_FrmClose);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        void frm_event_FrmClose(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void cargarGrid()
        {
            try
            {
                ListaCobro = BusReten.Get_List_Cobros_para_Consulta_Retenciones(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

                ListaCobro = ListaCobro.OrderBy(p => p.IdMultir).OrderBy(p => p.IdCobro).ToList();  //Ordena descendentemente

                gridControlCuentaxCobrar.DataSource = ListaCobro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private cxc_cobro_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (cxc_cobro_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cxc_cobro_Info();
            }
        }
        private void frmCxc_CobrosGenerales_Multiretenciones_Consulta_Load(object sender, EventArgs e)
        {
            try
            {

                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "CuentasxCobrar.frmCxc_CobrosGenerales_Multiretenciones_Consulta");
                foreach (var item in Infoseg)
                {
                    if (item.Eliminacion == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario.btnAnular.Enabled = false;
                    }
                    if (item.Escritura == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario.btnModificar.Enabled = false;
                    }
                }
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void gridViewCuentaxCobrar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCuentaxCobrar_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCuentaxCobrar.GetRow(e.RowHandle) as cxc_cobro_Info;
                if (data == null)
                {
                    return;
                }
                    

                if (data.cr_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void gridViewCuentaxCobrar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            info = (cxc_cobro_Info)gridViewCuentaxCobrar.GetFocusedRow();
        }

    }
}
