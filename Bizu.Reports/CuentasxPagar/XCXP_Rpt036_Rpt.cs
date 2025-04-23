using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt036_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt036_Rpt()
        {
            InitializeComponent();
            lblUsuario1.Text = param.IdUsuario;
        }

        private void XCXP_Rpt036_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XCXP_Rpt036_Bus repbus = new XCXP_Rpt036_Bus();

                List<XCXP_Rpt036_Info> ListDataRpt = new List<XCXP_Rpt036_Info>();

                int IdEmpresa = 0;

                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;

                String mensaje = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);                
                FechaIni = Convert.ToDateTime(Parameters["fechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["fechaFin"].Value);

                ListDataRpt = repbus.consultar_data(IdEmpresa, FechaIni, FechaFin, ref  mensaje);

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXP_Rpt011_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt011_rpt) };
            }
        }

    }
}
