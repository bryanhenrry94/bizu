using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Guia_Remision_Cons : DevExpress.XtraEditors.XtraForm
    {
        public FrmIn_Guia_Remision_Cons()
        {
            try
            {
                InitializeComponent();
                Ofrm.Event_frmIn_Guia_Remision_Mant_FormClosing += new FrmIn_Guia_Remision_Mant.Delegate_frmIn_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmIn_Guia_Remision_Mant_FormClosing);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
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
                Close();
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
                ultrGuiaRemision1.ShowRibbonPrintPreview();
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

                Ofrm = new FrmIn_Guia_Remision_Mant();
                Ofrm.Event_frmIn_Guia_Remision_Mant_FormClosing += new FrmIn_Guia_Remision_Mant.Delegate_frmIn_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmIn_Guia_Remision_Mant_FormClosing);
                Ofrm.Set_Info(RowSelected);
                Ofrm.Set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
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
                Ofrm = new FrmIn_Guia_Remision_Mant();
                Ofrm.Event_frmIn_Guia_Remision_Mant_FormClosing += new FrmIn_Guia_Remision_Mant.Delegate_frmIn_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmIn_Guia_Remision_Mant_FormClosing);

                if (RowSelected != null)
                {
                    if (!string.IsNullOrEmpty(RowSelected.NumAutorizacion))
                    {
                        MessageBox.Show("El documento se encuentra Autorizado");
                        return;
                    }
                }

                Ofrm.Set_Info(RowSelected);
                Ofrm.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
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
                Ofrm = new FrmIn_Guia_Remision_Mant();
                Ofrm.Event_frmIn_Guia_Remision_Mant_FormClosing += new FrmIn_Guia_Remision_Mant.Delegate_frmIn_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmIn_Guia_Remision_Mant_FormClosing);
                Ofrm.Set_Info(RowSelected);
                Ofrm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
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
                Ofrm = new FrmIn_Guia_Remision_Mant();
                Ofrm.Event_frmIn_Guia_Remision_Mant_FormClosing += new FrmIn_Guia_Remision_Mant.Delegate_frmIn_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmIn_Guia_Remision_Mant_FormClosing);
                Ofrm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void Ofrm_Event_frmIn_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        FrmIn_Guia_Remision_Mant Ofrm = new FrmIn_Guia_Remision_Mant();

        #region Declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Sucursal_Bodega ctrl_SucBod = new UCIn_Sucursal_Bodega();
        tb_Sucursal_Info _SucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfo = new tb_Bodega_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_GuiaRemision_Bus oBus = new in_GuiaRemision_Bus();
        in_GuiaRemision_Info RowSelected = new in_GuiaRemision_Info();
        #endregion

        #region Eventos

        private void frmFA_Guia_Remision_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewGuiaRemision_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewGuiaRemision.GetRow(e.RowHandle) as in_GuiaRemision_Info;
                if (data == null)
                    return;

                if (data.NumAutorizacion != null)
                { e.Appearance.ForeColor = Color.Blue; }

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void gridViewGuiaRemision_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                RowSelected = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        #endregion

        #region Funciones

        public void CargarGrid()
        {
            try
            {
                List<in_GuiaRemision_Info> lst = new List<in_GuiaRemision_Info>();

                lst = oBus.Get_List_Lite(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

                var order = from q in lst
                            orderby q.IdGuiaRemision descending
                            select q;

                foreach (var item in lst)
                {
                    if (!string.IsNullOrEmpty(item.NumAutorizacion))
                    {
                        item.Icono_pdf = (Bitmap)imageCollection1.Images[0];
                        item.Icono_xml = (Bitmap)imageCollection1.Images[1];
                    }
                }

                ultrGuiaRemision1.DataSource = order.ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private in_GuiaRemision_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (in_GuiaRemision_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_GuiaRemision_Info();
            }
        }

        #endregion

        private void gridViewGuiaRemision_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                // Setear en la propiedad RowSelected la fila selecciona del gridview
                RowSelected = gridViewGuiaRemision.GetFocusedRow() as in_GuiaRemision_Info;

                string mensaje_error = "";
                string IdComprobante = "";

                if (e.Column == col_pdf)
                {
                    // col_pdf.Caption = "Ride";

                    if (RowSelected != null)
                    {
                        if (RowSelected.Icono_pdf == null)
                        {
                            return;
                        }

                        byte[] result = oBus.Get_Comprobante_Efirm_PDF(RowSelected.IdEmpresa, RowSelected.IdSucursal, RowSelected.IdGuiaRemision, ref IdComprobante, ref mensaje_error);

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

                                if(MessageBox.Show("Desea abrir el archivo?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontro información para el comprobante #" + RowSelected.IdGuiaRemision, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (e.Column == col_xml)
                {
                    if (RowSelected != null)
                    {
                        if (RowSelected.Icono_xml == null)
                        {
                            return;
                        }

                        string result = oBus.Get_Comprobante_Efirm_XML(RowSelected.IdEmpresa, RowSelected.IdSucursal, RowSelected.IdGuiaRemision, ref IdComprobante, ref mensaje_error);

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
                            MessageBox.Show("No se encontro información para el comprobante #" + RowSelected.IdGuiaRemision, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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