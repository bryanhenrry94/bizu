using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.IO;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;
using DevExpress.XtraPivotGrid;

namespace Core.Erp.Reportes.Contabilidad
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
