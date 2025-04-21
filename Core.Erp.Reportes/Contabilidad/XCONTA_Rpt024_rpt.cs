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
    public partial class XCONTA_Rpt024_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCONTA_Rpt024_rpt()
        {
            InitializeComponent();
        }

        private void XCONTA_Rpt024_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCONTA_Rpt024_Bus oReporteBus = new XCONTA_Rpt024_Bus();
                List<XCONTA_Rpt024_Info> oListado = new List<XCONTA_Rpt024_Info>();

                DateTime FechaDesde = Convert.ToDateTime(Parameters["pFechaDesde"].Value);
                DateTime FechaHasta = Convert.ToDateTime(Parameters["pFechaHasta"].Value);
                
                oListado = oReporteBus.consultar_data(param.IdEmpresa, FechaDesde, FechaHasta);
                this.DataSource = oListado;

                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lb_impresion.Text = DateTime.Now.ToString().Substring(0, 10);
                lbusuario.Text = param.IdUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
