using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;
using Bizu.Application.General;



namespace Bizu.Reports.Bancos
{
    public partial class XBAN_Rpt015_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt015_rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt015_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XBAN_Rpt015_Bus OBusRpt = new XBAN_Rpt015_Bus();
                List<XBAN_Rpt015_Info> lista = new List<XBAN_Rpt015_Info>();
                string MensajeError = "";


                int PIdEmpresa = Convert.ToInt32(Parameters["PIdEmpresa"].Value);
                int PIdTipoCbte = Convert.ToInt32(Parameters["PIdTipoCbte"].Value);
                decimal PIdCbteCble = Convert.ToInt32(Parameters["PIdCbteCble"].Value);

                lista = OBusRpt.Get_Data_Reporte(PIdEmpresa, PIdTipoCbte, PIdCbteCble, ref MensajeError);
                this.DataSource = lista.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XBAN_Rpt015_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt015_rpt) };   

            }
            
        }

    }
}
