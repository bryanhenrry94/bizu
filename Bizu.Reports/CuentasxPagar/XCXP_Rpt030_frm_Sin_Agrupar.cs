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
using Bizu.Domain.General;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt030_frm_Sin_Agrupar : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt030_frm_Sin_Agrupar()
        {
            InitializeComponent();
        }

        private void btnGenerarRpt_Click(object sender, EventArgs e)
        {

            try
            {

                   XCXP_Rpt030_Rpt_Sin_Agrupar Reporte_SA = new XCXP_Rpt030_Rpt_Sin_Agrupar();

                   Reporte_SA.RequestParameters = false;
                   ReportPrintTool pt_SA = new ReportPrintTool(Reporte_SA);
                   pt_SA.AutoShowParametersPanel = false;

                   Reporte_SA.PIdEmpresa.Value = param.IdEmpresa;
                   Reporte_SA.p_FechaIni.Value = Convert.ToDateTime(dtpDesde.Value).ToShortDateString();
                   Reporte_SA.p_FechaFin.Value = Convert.ToDateTime(dtpHasta.Value).ToShortDateString();
                   Reporte_SA.P_X_Fecha_Emision.Value = rb_x_fecha_emision.Checked;

                   printControl.PrintingSystem = Reporte_SA.PrintingSystem;
                   Reporte_SA.CreateDocument();

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

    }
}
