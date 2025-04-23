using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;

namespace Bizu.Reports.ActivoFijo
{
    public partial class XACTF_Rpt009_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<XACTF_Rpt009_Info> infoRpt { get; set; }

        public XACTF_Rpt009_rpt()
        {
            InitializeComponent();
        }


        private void XACTF_Rpt009_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                DataSource = infoRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XACTF_Rpt009_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt009_rpt) };
            }
        }

    }
}
