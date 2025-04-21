using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt037_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt037_Rpt()
        {
            InitializeComponent();
            lblUsuario1.Text = param.IdUsuario;
        }

        private void XCXP_Rpt036_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XCXP_Rpt037_Bus repbus = new XCXP_Rpt037_Bus();

                List<XCXP_Rpt037_Info> ListDataRpt = new List<XCXP_Rpt037_Info>();

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
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_Rpt036_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt011_rpt) };
            }
        }

    }
}
