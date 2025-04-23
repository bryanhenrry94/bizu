using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt022_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt022_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_Rpt022_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XCXP_Rpt022_Bus busReporte = new XCXP_Rpt022_Bus();
                decimal idCbte_cxp = 0;
                int idTipoCbte_cxp = 0;
                int idEmpresa = 0;

                idCbte_cxp = Convert.ToDecimal(Parameters["idCbte_cxp"].Value);
                idEmpresa = Convert.ToInt32(Parameters["idEmpresa"].Value);
                idTipoCbte_cxp = Convert.ToInt32(this.idTipoCbte_cxp.Value);

                this.DataSource = busReporte.Get_Lista_Nota_Credito(idEmpresa,idTipoCbte_cxp, idCbte_cxp);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXP_Rpt022_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt021_Rpt) };
            }
        }

    }
}
