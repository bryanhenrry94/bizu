using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;
using Bizu.Application.ActivoFijo;
using Bizu.Domain.ActivoFijo;

namespace Bizu.Reports.ActivoFijo
{
    public partial class XACTF_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XACTF_Rpt016_Rpt()
        {
            InitializeComponent();
        }

        private void XACTF_Rpt016_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XACTF_Rpt016_Bus busRpt = new XACTF_Rpt016_Bus();
                List<XACTF_Rpt016_Info> lstInfo = new List<XACTF_Rpt016_Info>();

                int IdEmpresa = Convert.ToInt32(this.pIdEmpresa.Value);
                int IdActivoFijo = Convert.ToInt32(this.pIdActivoFijo.Value);
                
                lstInfo = busRpt.Consultar_Data(IdEmpresa, IdActivoFijo);

                foreach (var item in lstInfo)
                {
                    xrBarCode1.Text = item.Af_Codigo_Barra;
                    xrBarCode1.ShowText = true;
                }

                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XACTF_Rpt016_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt016_Rpt) };
            }
        }
    }
}