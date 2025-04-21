using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt038_frm : Form
    {
        #region "Variables y  Propiedades"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion

        #region "Constructor"
        public XINV_Rpt038_frm()
        {
            InitializeComponent();
            ucInv_Menu.event_tnConsultar_ItemClick += ucInv_MenuReportes1_event_tnConsultar_ItemClick;
            ucInv_Menu.event_btnImprimir_ItemClick += ucInv_MenuReportes1_event_btnImprimir_ItemClick;
            ucInv_Menu.event_btnSalir_ItemClick += ucInv_MenuReportes1_event_btnSalir_ItemClick;
        }
        #endregion

        #region "Eventos"
        void ucInv_MenuReportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string TipoMov = string.Empty;
                XINV_Rpt038_Rpt rpt = new XINV_Rpt038_Rpt();
                rpt.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(rpt);
                pt.AutoShowParametersPanel = false;

                rpt.Parameters["IdSucursalIni"].Value = ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0 ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                rpt.Parameters["IdSucursalFin"].Value = ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0 ? 9999 : ucInv_Menu.cmbSucursal.EditValue;
                rpt.Parameters["IdBodegaIni"].Value = ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0 ? 0 : ucInv_Menu.cmbBodega.EditValue;
                rpt.Parameters["IdBodegaFin"].Value = ucInv_Menu.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbBodega.EditValue) == 0 ? 9999 : ucInv_Menu.cmbBodega.EditValue;
                rpt.Parameters["IdProductoIni"].Value = ucInv_Menu.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue) == 0 ? 0 : Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue);
                rpt.Parameters["IdProductoFin"].Value = ucInv_Menu.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue) == 0 ? 999999 : Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue);
                rpt.Parameters["FechaIni"].Value = ucInv_Menu.dtpDesde.Edit == null ? DateTime.Now : (DateTime)ucInv_Menu.dtpDesde.EditValue;
                rpt.Parameters["FechaFin"].Value = ucInv_Menu.dtpHasta.Edit == null ? DateTime.Now : (DateTime)ucInv_Menu.dtpHasta.EditValue;                                                             
                rpt.Parameters["IdCategoria"].Value = ucInv_Menu.bei_Categoria.EditValue == null || ucInv_Menu.bei_Categoria.EditValue == null ? "" : ucInv_Menu.bei_Categoria.EditValue;
                rpt.IdLinea_List = ucInv_Menu.Get_list_Linea_Cheked();
                rpt.Parameters["IdUsuario"].Value = param.IdUsuario;
  
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucInv_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void XINV_Rpt038_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
