using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Reports;
using System.Collections.Generic;
using System.IO;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt032_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_Rpt032_Rpt()
        {
            InitializeComponent();
            lblUsuario1.Text = param.IdUsuario;
        }

        private void XCXP_Rpt032_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                string msg = "";
                XCXP_Rpt032_Bus Bus = new XCXP_Rpt032_Bus();
                List<XCXP_Rpt032_Info> lista = new List<XCXP_Rpt032_Info>();

                int IdEmpresa = 0;
                decimal IdConciliacion_Caja = 0;

                IdEmpresa = Convert.ToInt32(this.P_IdEmpresa.Value);
                IdConciliacion_Caja = Convert.ToDecimal(this.P_IdConciliacion_Caja.Value);

                lista = Bus.Get_List_Data(IdEmpresa, IdConciliacion_Caja, ref msg);

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXP_Rpt032_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt032_Rpt) };
            }
        }
    }
}
