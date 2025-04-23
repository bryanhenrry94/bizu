using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Reports.CuentasxCobrar
{
    public partial class XCXC_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<XCXC_Rpt003_Info> lstRpt { get; set; }

        public XCXC_Rpt003_rpt()
        {
            InitializeComponent();

            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
        }

        public XCXC_Rpt003_rpt(string IdUsuario)
        {
            InitializeComponent();
            lblIdUsuario.Text = IdUsuario;
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXC_Rpt003_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXC_Rpt003_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt003_rpt) };
            }
        }



    }
}
