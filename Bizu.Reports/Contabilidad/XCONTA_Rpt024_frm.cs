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
using Bizu.Reports.Contabilidad;

namespace Bizu.Reports.Contabilidad
{
    public partial class XCONTA_Rpt024_frm : Form
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_Rpt024_frm()
        {
            InitializeComponent();

            uCct_Menu.event_btnConsultar_ItemClick += UCct_Menu_event_btnConsultar_ItemClick;
            uCct_Menu.event_btnSalir_ItemClick += UCct_Menu_event_btnSalir_ItemClick;
        }

        private void UCct_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void UCct_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCONTA_Rpt024_rpt Reporte = new XCONTA_Rpt024_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["pFechaDesde"].Value = uCct_Menu.bei_Desde.EditValue == null ? DateTime.Now : uCct_Menu.bei_Desde.EditValue;
                Reporte.Parameters["pFechaHasta"].Value = uCct_Menu.bei_Hasta.EditValue == null ? DateTime.Now : uCct_Menu.bei_Hasta.EditValue;

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
     
        private void XCONTA_Rpt024_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
