using System;
using System.Windows.Forms;
using Bizu.Reports.CuentasxPagar;
using System.IO;
using System.Xml;
using Bizu.Domain.General;
using Bizu.Application.General;


namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt015_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        static string result = Path.GetTempPath();
        String RootReporte = result + @"Comprobante de Retencion.repx";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_Rpt015_frm()
        {
            InitializeComponent();
        }


        public XCXP_Rpt015_frm(vwtb_sis_Documento_Tipo_x_Disenio_Report_Info Info)
        {
            InitializeComponent();
            commandBarItem31.PerformClick();
            XCXP_Rpt015_rpt reporte = new XCXP_Rpt015_rpt();

            xrDesignDockManager1.XRDesignPanel.OpenReport(reporte);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string reportruta = result + "save.repx";
                xrDesignDockManager1.XRDesignPanel.SaveReport(reportruta);

                Byte[] data;
                using (System.IO.FileStream FL = new System.IO.FileStream(reportruta, System.IO.FileMode.Open))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        FL.CopyTo(ms);
                        data = ms.ToArray();
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}