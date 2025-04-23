using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Domain.ActivoFijo;
using Bizu.Application.ActivoFijo;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Presentation.ActivoFijo
{
    public partial class frmAF_Catalogo : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de varibles
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Af_CatalogoTipo_Bus CatalogoTipoBus = new Af_CatalogoTipo_Bus();
        Af_Catalogo_Bus CatalogoBus = new Af_Catalogo_Bus();
        BindingList<Af_Catalogo_Info> CatalogoInfo = new BindingList<Af_Catalogo_Info>();
        List<Af_CatalogoTipo_Info> CatalogoTipoInfo = new List<Af_CatalogoTipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();

        #endregion
        
        public frmAF_Catalogo()
        {
            try
            {
                InitializeComponent();
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo ();
                CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdTipoCatalogo + "] - " + var.Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (Af_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmAF_Catalogo_Mantenimiento frmCataMant = new frmAF_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_frmAF_Catalogo_Mantenimiento_FormClosing += new frmAF_Catalogo_Mantenimiento.delegate_Event_frmAF_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmAF_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info1 = (Af_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info1.Estado == "I")
                    MessageBox.Show("El Catálogo # : " + Info1.IdCatalogo + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    frmAF_Catalogo_Mantenimiento frmCataMant = new frmAF_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_frmAF_Catalogo_Mantenimiento_FormClosing += new frmAF_Catalogo_Mantenimiento.delegate_Event_frmAF_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmAF_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info1 = (Af_Catalogo_Info)this.gridViewCatalogo.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    frmAF_Catalogo_Mantenimiento frmCataMant = new frmAF_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                    frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                    frmCataMant.setInfo = Info1;
                    frmCataMant.Event_frmAF_Catalogo_Mantenimiento_FormClosing += new frmAF_Catalogo_Mantenimiento.delegate_Event_frmAF_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmAF_Catalogo_Mantenimiento_FormClosing);
                    frmCataMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmAF_Catalogo_Mantenimiento frmCataMant = new frmAF_Catalogo_Mantenimiento((string)lstbox_TipoCatalogo.SelectedValue);
                frmCataMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataMant.Event_frmAF_Catalogo_Mantenimiento_FormClosing += new frmAF_Catalogo_Mantenimiento.delegate_Event_frmAF_Catalogo_Mantenimiento_FormClosing(frmCataMant_Event_frmAF_Catalogo_Mantenimiento_FormClosing);
                frmCataMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstbox_TipoCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CatalogoInfo = new BindingList<Af_Catalogo_Info>(CatalogoBus.Get_List_Catalogo(Convert.ToString(lstbox_TipoCatalogo.SelectedValue)));
                gridControlCatalogo.DataSource = CatalogoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridViewCatalogo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCatalogo.GetRow(e.RowHandle) as Af_Catalogo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCataMant_Event_frmAF_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlCatalogo.DataSource = CatalogoBus.Get_List_Catalogo(Convert.ToString(lstbox_TipoCatalogo.SelectedValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void frmCataMant_Event_frmAF_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CatalogoTipoInfo = CatalogoTipoBus.Get_List_CatalogoTipo();
                CatalogoTipoInfo.ForEach(var => var.Descripcion = "[" + var.IdTipoCatalogo + "] - " + var.Descripcion);
                lstbox_TipoCatalogo.DataSource = CatalogoTipoInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_NuevoTipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                frmAF_CatalogoTipo_Mantenimiento frmCataTipoMant = new frmAF_CatalogoTipo_Mantenimiento();
                frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frmCataTipoMant.Event_frmAF_CatalogoTipo_Mantenimiento_FormClosing += new frmAF_CatalogoTipo_Mantenimiento.delegate_frmAF_CatalogoTipo_Mantenimiento_FormClosing(frmCataMant_Event_frmAF_CatalogoTipo_Mantenimiento_FormClosing);
                frmCataTipoMant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ModificarTipoCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = (string)this.lstbox_TipoCatalogo.SelectedValue;
                Af_CatalogoTipo_Info Info = (Af_CatalogoTipo_Info)CatalogoTipoBus.Get_Info_CatalogoTipo(cod);

                if (Info == null)
                    MessageBox.Show("No Exite el Tipo de Catalogo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmAF_CatalogoTipo_Mantenimiento frmCataTipoMant = new frmAF_CatalogoTipo_Mantenimiento();
                    frmCataTipoMant.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmCataTipoMant._SetInfo = Info;
                    frmCataTipoMant.Event_frmAF_CatalogoTipo_Mantenimiento_FormClosing += new frmAF_CatalogoTipo_Mantenimiento.delegate_frmAF_CatalogoTipo_Mantenimiento_FormClosing(frmCataMant_Event_frmAF_CatalogoTipo_Mantenimiento_FormClosing);
                    frmCataTipoMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarGrid()
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load_1(object sender, EventArgs e)
        {

        }

        private void frmAF_Catalogo_Load(object sender, EventArgs e)
        {
            //Control de Usuario
            Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "ActivoFijo.frmAF_Catalogo");
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
        }


    }
}
