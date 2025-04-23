using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Bizu.Application.General;

using System.Collections.Generic;

namespace Bizu.Reports.ActivoFijo
{
    public partial class XACTF_Rpt011_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XACTF_Rpt011_rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XACTF_Rpt011_rpt";
            xrL_fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XACTF_Rpt011_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                
                XACTF_Rpt011_Bus busRpt = new XACTF_Rpt011_Bus();
                List<XACTF_Rpt011_Info> lstInfo = new List<XACTF_Rpt011_Info>();

                xrL_Empresa.Text = param.InfoEmpresa.em_nombre;
         
                int IdEmpresa = 0;
                int IdPeriodo = 0;

                string mensaje="";
         
                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                IdPeriodo = Convert.ToInt32(this.IdPeriodo.Value);

                lstInfo = busRpt.consultar_data(IdEmpresa,IdPeriodo, ref mensaje);
                this.DataSource = lstInfo.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XACTF_Rpt011_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt011_rpt) };
                
            }
        }

    }
}
