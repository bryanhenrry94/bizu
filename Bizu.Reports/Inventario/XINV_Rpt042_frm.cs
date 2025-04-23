using Bizu.Application.General;
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

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt042_frm : Form
    {
        #region "Variables y  Propiedades"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion

        #region "Constructor"
        public XINV_Rpt042_frm()
        {
            InitializeComponent();
            ucInv_MenuReportes1.event_tnConsultar_ItemClick += ucInv_MenuReportes1_event_tnConsultar_ItemClick;
            ucInv_MenuReportes1.event_btnImprimir_ItemClick += ucInv_MenuReportes1_event_btnImprimir_ItemClick;
            ucInv_MenuReportes1.event_btnSalir_ItemClick += ucInv_MenuReportes1_event_btnSalir_ItemClick;
        }
        #endregion

        #region "Eventos"
        void ucInv_MenuReportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }

        void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string TipoMov = string.Empty;                

                int IdSucursalIni;
                int IdSucursalFin;
                int IdBodegaIni;
                int IdBodegaFin;
                decimal IdProductoIni;
                decimal IdProductoFin;
                DateTime FechaIni;
                DateTime FechaFin;
                string IdCentro_costo;
                string IdSubcentro_costo;
                int IdMovi_inven_tipoIni;
                int IdMovi_inven_tipoFin;
                string IdCategoria;
                int IdLinea;
                bool Considerar_saldo_inicial;
                List<int?> IdLinea_List = new List<int?>();
                List<int?> IdTipoMovi_Inven_List = new List<int?>();

                IdSucursalIni = ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt16(ucInv_MenuReportes1.cmbSucursal.EditValue) == 0 ? 0 : Convert.ToInt16(ucInv_MenuReportes1.cmbSucursal.EditValue);
                IdSucursalFin = ucInv_MenuReportes1.cmbSucursal.EditValue == null || Convert.ToInt16(ucInv_MenuReportes1.cmbSucursal.EditValue) == 0 ? 9999 : Convert.ToInt16(ucInv_MenuReportes1.cmbSucursal.EditValue);

                IdBodegaIni = ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0 ? 0 : Convert.ToInt16(ucInv_MenuReportes1.cmbBodega.EditValue);
                IdBodegaFin = ucInv_MenuReportes1.cmbBodega.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue) == 0 ? 9999 : Convert.ToInt16(ucInv_MenuReportes1.cmbBodega.EditValue);

                IdProductoIni = ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue) == 0 ? 0 : Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue);
                IdProductoFin = ucInv_MenuReportes1.cmbProducto.EditValue == null || Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue) == 0 ? 999999 : Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue);

                FechaIni = ucInv_MenuReportes1.dtpDesde.Edit == null ? DateTime.Now : (DateTime)ucInv_MenuReportes1.dtpDesde.EditValue;
                FechaFin = ucInv_MenuReportes1.dtpHasta.Edit == null ? DateTime.Now : (DateTime)ucInv_MenuReportes1.dtpHasta.EditValue;

                IdCentro_costo = (ucInv_MenuReportes1.barEditItemCentroCosto.EditValue == null) || (ucInv_MenuReportes1.barEditItemCentroCosto.EditValue == "Todos") ? "" : ucInv_MenuReportes1.barEditItemCentroCosto.EditValue.ToString();
                IdSubcentro_costo = (ucInv_MenuReportes1.barEditItemSubCentroCosto.EditValue == null) || (ucInv_MenuReportes1.barEditItemSubCentroCosto.EditValue == "Todos") ? "" : ucInv_MenuReportes1.barEditItemSubCentroCosto.EditValue.ToString();

                IdMovi_inven_tipoIni = ucInv_MenuReportes1.cmbTipoMovInve.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue) == 0 ? 0 : Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue);
                IdMovi_inven_tipoFin = ucInv_MenuReportes1.cmbTipoMovInve.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue) == 0 ? 9999 : Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue);                
                
                TipoMov = ucInv_MenuReportes1.barEditItemTipoMovimiento.Edit.GetDisplayText(ucInv_MenuReportes1.barEditItemTipoMovimiento.EditValue);
                
                switch (TipoMov)
                {
                    case "(+)Ingresos": TipoMov = "+";
                        break;
                    case "(-)Egresos": TipoMov = "-";
                        break;
                    case "Todos": TipoMov = "";
                        break;
                    default:
                        break;
                }

                IdCategoria = (ucInv_MenuReportes1.bei_Categoria.EditValue == null || ucInv_MenuReportes1.bei_Categoria.EditValue == null) ? "" : Convert.ToString(ucInv_MenuReportes1.bei_Categoria.EditValue);
                IdLinea = ucInv_MenuReportes1.beiLinea.EditValue == null || Convert.ToInt32(ucInv_MenuReportes1.beiLinea.EditValue) == 0 ? 0 : Convert.ToInt32(ucInv_MenuReportes1.beiLinea.EditValue);
                Considerar_saldo_inicial = false; // ucInv_MenuReportes1.chk_checked_item_1.Checked;
                
                IdLinea_List = ucInv_MenuReportes1.Get_list_Linea_Cheked();
                IdTipoMovi_Inven_List = ucInv_MenuReportes1.Get_list_TipoMoviInven_Cheked();

                XINV_Rpt042_Bus BUS = new XINV_Rpt042_Bus();
                List<XINV_Rpt042_Info> ListDataRpt = new List<XINV_Rpt042_Info>();

                ListDataRpt = BUS.Get_Kardes_Movimiento(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, IdCentro_costo, IdSubcentro_costo, IdTipoMovi_Inven_List, TipoMov, FechaIni, FechaFin, IdCategoria, IdLinea_List, Considerar_saldo_inicial);
                xINVRpt042InfoBindingSource.DataSource = ListDataRpt;

                pivotGridControl1.Cells.Selection = new Rectangle(0, 0, pivotGridControl1.Cells.ColumnCount, pivotGridControl1.Cells.RowCount);
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

        private void XINV_Rpt042_frm_Load(object sender, EventArgs e)
        {
            pivotGridControl1.Cells.Selection = new Rectangle(0, 0, pivotGridControl1.Cells.ColumnCount, pivotGridControl1.Cells.RowCount);
        }
    }
}
