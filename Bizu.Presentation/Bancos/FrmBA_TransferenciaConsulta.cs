using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.Bancos;
using Bizu.Domain.Bancos;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Presentation.Bancos
{
    public partial class FrmBA_TransferenciaConsulta : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        ba_transferencia_Bus transf_B = new ba_transferencia_Bus();
        ba_transferencia_Info transf_I = new ba_transferencia_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //FrmBA_Transferencia frm = new FrmBA_Transferencia();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #endregion

        public FrmBA_TransferenciaConsulta()
        {
            try
            {

              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControl_Transf.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info = (ba_transferencia_Info)UltraGrid_Transf.GetFocusedRow();
                if (Info == null)

                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info.tr_estado == "I")
                    MessageBox.Show("El registro #:" + Info.IdTransferencia + " . \r  Ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    PrepararFrm(Cl_Enumeradores.eTipo_action.Anular, Info);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ba_transferencia_Info)UltraGrid_Transf.GetFocusedRow();
                if (Info == null)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararFrm(Cl_Enumeradores.eTipo_action.actualizar, Info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var transf_I = (ba_transferencia_Info)UltraGrid_Transf.GetFocusedRow();
                if (transf_I == null)
                {
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PrepararFrm(Cl_Enumeradores.eTipo_action.consultar, transf_I);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PrepararFrm(Cl_Enumeradores.eTipo_action.grabar, transf_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void load_data()
        {
            try 
	        {
                this.gridControl_Transf.DataSource  = transf_B.Get_List_transferencia(param.IdEmpresa);
	        }
	        catch (Exception ex)
	        {
                Log_Error_bus.Log_Error(ex.ToString());
	        }
            
        }

        private void PrepararFrm(Cl_Enumeradores.eTipo_action Accion, ba_transferencia_Info Info)
        {
            try

            {
                FrmBA_Transferencia frm; 
                frm = new FrmBA_Transferencia();
                frm.event_FrmBA_Transferencia_FormClosing += new FrmBA_Transferencia.delegate_FrmBA_Transferencia_FormClosing(frm_event_FrmBA_Transferencia_FormClosing);
                frm.set_Accion(Accion);
                frm.MdiParent = this.MdiParent;
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_transferencia(Info);
                }
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_event_FrmBA_Transferencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void FrmBA_TransferenciaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "Bancos.FrmBA_TransferenciaConsulta");
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
                load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private ba_transferencia_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (ba_transferencia_Info)view.GetRow(view.FocusedRowHandle);
             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new ba_transferencia_Info();
            }
        }

        private void UltraGrid_Transf_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGrid_Transf.GetRow(e.RowHandle) as ba_transferencia_Info;
                if (data == null)
                    return;
                if (data.tr_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
    }
}
