using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Compras
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