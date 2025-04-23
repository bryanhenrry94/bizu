using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;

using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;
using System.IO;

namespace Bizu.Presentation.CuentasxPagar
{
    public partial class frmCP_RetencionConsulta : DevExpress.XtraEditors.XtraForm
    {
        
        #region DEclaración de variables
        //Bus      
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        cp_retencion_Bus BusReten = new cp_retencion_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //BindingList
        BindingList<cp_retencion_Info> BindinReten = new BindingList<cp_retencion_Info>();
        cp_retencion_Info Info = new cp_retencion_Info();        
        #endregion
                
        public frmCP_RetencionConsulta()
        {
            InitializeComponent();
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCP_RetencionMant frmMant = new frmCP_RetencionMant();
                frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                frmMant.Show();
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
                Info = (cp_retencion_Info)this.gridViewConsRet.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("No se pueden modificar Retenciones Inactivas", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmCP_RetencionMant frmMant = new frmCP_RetencionMant();
                    frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                    frmMant.Set_Info_Retencion(Info);
                    frmMant.Show();
                }
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
                Info = (cp_retencion_Info)this.gridViewConsRet.GetFocusedRow();
                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else                 
                {
                    frmCP_RetencionMant frmMant = new frmCP_RetencionMant();
                    frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                    frmMant.Set_Info_Retencion(Info);
                    frmMant.Show();
                }
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
                Info = (cp_retencion_Info)this.gridViewConsRet.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un Registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("La Retención # : " + Info.IdCbte_CXP + " ya fue Anulada", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmCP_RetencionMant frmMant = new frmCP_RetencionMant();
                    frmMant.Set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.event_frmCP_RetencionMant_FormClosing += frmMant_event_frmCP_RetencionMant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant.Set_Info_Retencion(Info);
                    frmMant.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void frmMant_event_frmCP_RetencionMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void cargaGrid()
        {
            try
            {
                DateTime FechaIni = ucGe_Menu.fecha_desde;
                DateTime FechaFin = ucGe_Menu.fecha_hasta;
                List<cp_retencion_Info> lista = new List<cp_retencion_Info>();
                lista = BusReten.Get_List_retencion(param.IdEmpresa, FechaIni, FechaFin);

                foreach (var item in lista)
                {
                    if (!string.IsNullOrEmpty(item.NAutorizacion))
                    {
                        item.Icono_pdf = (Bitmap)imageList1.Images[0];
                        item.Icono_xml = (Bitmap)imageList1.Images[1];
                    }                    
                }

                BindinReten = new BindingList<cp_retencion_Info>(lista);
                gridControlConsRet.DataSource = BindinReten;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                          
        }

        private void frmCP_RetencionConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "CuentasxPagar.frmCP_RetencionConsulta");
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
                
                cargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsRet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new cp_retencion_Info();
                Info = this.gridViewConsRet.GetFocusedRow() as cp_retencion_Info;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsRet_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsRet.GetRow(e.RowHandle) as cp_retencion_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                { e.Appearance.ForeColor = Color.Red; }

                if (data.Estado_Auto == "AUTORIZADA")
                { e.Appearance.ForeColor = Color.Blue; }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            cargaGrid();
        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlConsRet.ShowPrintPreview();
        }

        private void gridViewConsRet_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Info = gridViewConsRet.GetFocusedRow() as cp_retencion_Info;
                string mensaje_error = "";
                string IdComprobante = "";                

                if (e.Column == col_Icono_pdf)
                {
                    if (Info != null)
                    {
                        if (Info.Icono_pdf == null)
                        {
                            return;
                        }

                        byte[] result = BusReten.Get_Comprobante_Efirm_PDF(Info.IdEmpresa, Info.IdRetencion, ref IdComprobante, ref mensaje_error);

                        if (result != null)
                        {
                            //SI FUNCIONA                                                             
                            saveFileDialog1 = new SaveFileDialog();
                            saveFileDialog1.Filter = "Pdf Files|*.pdf";
                            saveFileDialog1.FilterIndex = 2;
                            saveFileDialog1.RestoreDirectory = true;
                            saveFileDialog1.FileName = IdComprobante + ".pdf";

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                System.IO.File.WriteAllBytes(saveFileDialog1.FileName, result);                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontro información para el comprobante #" + Info.IdRetencion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (e.Column == col_Icono_xml)
                {
                    if (Info != null)
                    {
                        if (Info.Icono_xml == null)
                        {
                            return;
                        }

                        string result = BusReten.Get_Comprobante_Efirm_XML(Info.IdEmpresa, Info.IdRetencion, ref IdComprobante, ref mensaje_error);

                        if (!string.IsNullOrEmpty(result))
                        {
                            saveFileDialog1 = new SaveFileDialog();
                            saveFileDialog1.Filter = "Xml Files|*.xml";
                            saveFileDialog1.FilterIndex = 2;
                            saveFileDialog1.RestoreDirectory = true;
                            saveFileDialog1.FileName = IdComprobante + ".xml";

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                System.IO.File.WriteAllText(saveFileDialog1.FileName, result);

                                if (MessageBox.Show("Desea abrir el archivo?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontro información para el comprobante #" + Info.IdRetencion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }                                              
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
