using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Reportes.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt043_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_Rpt043_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt042_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXP_Rpt043_Bus bus = new XCXP_Rpt043_Bus();

                List<XCXP_Rpt043_Info> List = new List<XCXP_Rpt043_Info>();

                int IdEmpresa = Convert.ToInt32(this.pIdEmpresa.Value);
                decimal IdProveedor = Convert.ToDecimal(pIdProveedor.Value);
                DateTime FechaIni = Convert.ToDateTime(pFechaIni.Value);
                DateTime FechaFin = Convert.ToDateTime(pFechaFin.Value);
                                
                List = bus.GetData(IdEmpresa, IdProveedor, IdProveedor, FechaIni, FechaFin, param.IdUsuario);
 
                this.DataSource = List;

                this.lblEmpresa.Text = param.InfoEmpresa.RazonSocial;
                this.xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                this.lblFechaImpresion.Text = DateTime.Now.ToString();
                this.lblIdUsuario.Text = param.IdUsuario;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}