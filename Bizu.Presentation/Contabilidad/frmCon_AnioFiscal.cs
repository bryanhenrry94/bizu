using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Presentation.Controles;
using Bizu.Application.General;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.General;
using Bizu.Application.Contabilidad;
using Bizu.Presentation.Contabilidad;
using Bizu.Application;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;


namespace Bizu.Presentation.Contabilidad
{
    public partial class frmCon_AnioFiscal : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        public DataTable lm = new DataTable();
        ct_AnioFiscal_Info InfoAnio = new ct_AnioFiscal_Info();
        ct_AnioFiscal_Bus BusAnio = new ct_AnioFiscal_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmCon_AnioFiscal_Mant frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        #region " Constructor "
        public frmCon_AnioFiscal()
        {
            InitializeComponent();  
        }
        #endregion

        #region " Eventos "
        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmCon_AnioFiscal_Mant();
                frm.event_frmCon_AnioFiscal_Mant_FormClosing +=frm_event_frmCon_AnioFiscal_Mant_FormClosing;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                CargarGrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoAnio == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (InfoAnio.af_estado == "I")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular_registro) + " " + InfoAnio.IdanioFiscal + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        frm = new frmCon_AnioFiscal_Mant();
                        frm.event_frmCon_AnioFiscal_Mant_FormClosing +=frm_event_frmCon_AnioFiscal_Mant_FormClosing;
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Set_Info(InfoAnio);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoAnio == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frm = new frmCon_AnioFiscal_Mant();
                    frm.event_frmCon_AnioFiscal_Mant_FormClosing +=frm_event_frmCon_AnioFiscal_Mant_FormClosing;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Set_Info(InfoAnio);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoAnio == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (InfoAnio.af_estado == "I")
                    {
                        MessageBox.Show("El periodo seleccionado ya se encuentra anulado, favor seleccione otro registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        frm = new frmCon_AnioFiscal_Mant();
                        frm.event_frmCon_AnioFiscal_Mant_FormClosing +=frm_event_frmCon_AnioFiscal_Mant_FormClosing;
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                        frm.Set_Info(InfoAnio);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewAFiscal.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        #endregion

        #region " Cargar Grid "
        public void CargarGrid()
        {
            try
            {
                gridControlAFiscal.DataSource = BusAnio.Get_list_AnioFiscal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region " Evento Load "
        private void frmCon_AnioFiscal_Load(object sender, EventArgs e)
        {
            try
            {
                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "Contabilidad.frmCon_AnioFiscal");
                foreach (var item in Infoseg)
                {
                    if (item.Eliminacion == false)
                    {
                        ucGe_Menu.btnAnular.Enabled = false;
                    }
                    if (item.Escritura == false)
                    {
                        ucGe_Menu.btnModificar.Enabled = false;
                    }
                }
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region " Eventos Personalizados "
        private void gridViewAFiscal_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewAFiscal.GetRow(e.RowHandle) as ct_AnioFiscal_Info;
                if (data == null)
                    return;
                if (data.af_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCon_AnioFiscal_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAFiscal_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoAnio = (ct_AnioFiscal_Info)gridViewAFiscal.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ct_AnioFiscal_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (ct_AnioFiscal_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_AnioFiscal_Info();
            }
        }
        #endregion
    }
}
