using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.IO;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Reports;
using DevExpress.XtraPivotGrid;

namespace Bizu.Reports.Contabilidad
{
    public partial class XCONTA_Rpt023_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        
        public XCONTA_Rpt023_rpt()
        {
            InitializeComponent();
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XCONTA_Rpt023_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            
        }

    }
}
