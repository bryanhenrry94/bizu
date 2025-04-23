using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using Bizu.Domain.General;
using System.Collections.Generic;

namespace Bizu.Reports.Compras
{
    public partial class XCOMP_Rpt012_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XCOMP_Rpt012_Rpt()
        {
            InitializeComponent();
        }

        public void loadData(List<XCOMP_Rpt012_Info> data)
        {
            try
            {
                DataSource = data;
            }
            catch (Exception ex)
            {
            }
        }

        private void Credito_No_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}