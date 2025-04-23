using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Bizu.Application.General;

namespace Bizu.Reports.Facturacion
{
    public partial class XFAC_Rpt011_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public List<XFAC_Rpt011_Info> lstRpt { get; set; }

        public XFAC_Rpt011_rpt()
        {
            InitializeComponent();
        }


        public XFAC_Rpt011_rpt(string IdUsuario )
        {
            InitializeComponent();
            lblIdUsuario.Text = IdUsuario;
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XFAC_Rpt011_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XFAC_Rpt011_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_Rpt011_rpt) };
            }
        }

    }
}
