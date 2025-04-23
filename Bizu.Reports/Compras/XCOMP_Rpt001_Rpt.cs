using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using Bizu.Domain.General;
using System.Collections.Generic;
using System.Linq;

namespace Bizu.Reports.Compras
{
    public partial class XCOMP_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XCOMP_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        public void loadData(List<XCOMP_Rpt001_Info> data)
        {
            try
            {                
                foreach (var item in data)
                {
                    if (item.IdUnidadMedida != "UNI_401")
                    {                 
                        continue;
                    }
                }

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