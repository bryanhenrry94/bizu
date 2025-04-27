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
using Bizu.Application.Facturacion;
using Bizu.Domain.Facturacion;
using System.IO;
using Bizu.Domain.General;
using Bizu.Application.General;

namespace Bizu.Reports.Facturacion
{
    public partial class XFAC_Rpt008_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        static string result = Path.GetTempPath();
        String RootReporte = result + @"Factura.repx";

        public XFAC_Rpt008_frm()
        {
            InitializeComponent();
        }

        public XFAC_Rpt008_frm(vwtb_sis_Documento_Tipo_x_Disenio_Report_Info Info)
        {
            InitializeComponent();
            commandBarItem31.PerformClick();

            XFAC_Rpt008_rpt reporte = new XFAC_Rpt008_rpt();

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