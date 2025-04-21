using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Collections.Generic;
using System.Linq;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt001_Rpt_Conversion : DevExpress.XtraReports.UI.XtraReport
    {
        public XCOMP_Rpt001_Rpt_Conversion()
        {
            //InitializeComponent();
        }

        public void loadData(List<XCOMP_Rpt001_Info> data)
        {
            try
            {
                //label_totales.Visible = true;
                //xrTableCell22.Visible = true;
                //xrTableCell23.Visible = true;

                //foreach (var item in data)
                //{
                //    if (item.IdUnidadMedida != "UNI_401")
                //    {
                //        label_totales.Visible = false;

                //        //xrTableCell22.Visible = false;
                //        xrTableCell22.WidthF = 0;
                //        //xrTableCell23.Visible = false;
                //        xrTableCell23.WidthF = 0;

                //        xrTableCell8.WidthF = (float)217.94;
                //        xrTableCell9.WidthF = (float)217.94;

                //        //217.94
                //        //57.94
                //        continue;
                //    }
                //}

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