using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Application.General;
using DevExpress.XtraReports.UI;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt038_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt038_frm()
        {
            InitializeComponent();
        }

        private void ucCxp_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucCxp_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCXP_Rpt038_Rpt Reporte = new XCXP_Rpt038_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["em_nombre"].Value = param.NombreEmpresa;                
                Reporte.Parameters["fechaIni"].Value = Convert.ToDateTime(ucCxp_MenuReportes1.dtpDesde.EditValue).Date;
                Reporte.Parameters["fechaFin"].Value = Convert.ToDateTime(ucCxp_MenuReportes1.dtpHasta.EditValue).Date;
                Reporte.Parameters["IdProveedor"].Value = Convert.ToInt32(ucCxp_MenuReportes1.cmbProveedor.EditValue);
                Reporte.Parameters["nom_proveedor"].Value = (Convert.ToDouble(ucCxp_MenuReportes1.cmbProveedor.EditValue) != 0) ? Convert.ToString(ucCxp_MenuReportes1.cmbProveedor.EditValue) : "TODOS";
                
                printControl.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXP_Rpt036_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
