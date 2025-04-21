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
    public partial class XINV_Rpt043_frm : Form
    {        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
     
        public XINV_Rpt043_frm()
        {
            InitializeComponent();
            ucInv_MenuReportes1.event_tnConsultar_ItemClick += ucInv_MenuReportes1_event_tnConsultar_ItemClick;
            ucInv_MenuReportes1.event_btnImprimir_ItemClick += ucInv_MenuReportes1_event_btnImprimir_ItemClick;
            ucInv_MenuReportes1.event_btnSalir_ItemClick += ucInv_MenuReportes1_event_btnSalir_ItemClick;
        }
     
        void ucInv_MenuReportes1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pivotGridControl1.ShowPrintPreview();
        }

        void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {            
                XINV_Rpt043_Bus BUS = new XINV_Rpt043_Bus();
                List<XINV_Rpt043_Info> ListDataRpt = new List<XINV_Rpt043_Info>();

                if(ucInv_MenuReportes1.barEditItemCentroCosto.EditValue == null || Convert.ToString(ucInv_MenuReportes1.barEditItemCentroCosto.EditValue) == "Todos")
                {
                    MessageBox.Show("Seleccione un Centro de Costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string IdCentro_costo = ucInv_MenuReportes1.barEditItemCentroCosto.EditValue == null ? "" : Convert.ToString(ucInv_MenuReportes1.barEditItemCentroCosto.EditValue);
                DateTime FechaIni = ucInv_MenuReportes1.dtpDesde.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpDesde.EditValue);
                DateTime FechaFin = ucInv_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucInv_MenuReportes1.dtpHasta.EditValue);

                ListDataRpt = BUS.Get_Kardex(param.IdEmpresa, param.IdSucursal, IdCentro_costo, FechaIni, FechaFin);
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

        private void XINV_Rpt043_frm_Load(object sender, EventArgs e)
        {
            pivotGridControl1.Cells.Selection = new Rectangle(0, 0, pivotGridControl1.Cells.ColumnCount, pivotGridControl1.Cells.RowCount);
        }
    }
}
