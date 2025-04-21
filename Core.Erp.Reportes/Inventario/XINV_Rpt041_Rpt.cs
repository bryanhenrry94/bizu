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
namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt041_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_Rpt041_Rpt()
        {
            InitializeComponent();
        }

        private void XINV_Rpt041_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                              
                XINV_Rpt041_Bus repbus = new XINV_Rpt041_Bus();
                List<XINV_Rpt041_Info> ListDataRpt = new List<XINV_Rpt041_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                int IdSucursal = 0;                
                decimal IdGuiaRemision = 0;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                IdGuiaRemision = Convert.ToInt32(Parameters["IdGuiaRemision"].Value);                

                ListDataRpt = repbus.consultar_data(IdEmpresa, IdSucursal, IdGuiaRemision, ref mensaje);

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt041_Rpt", ex.Message), ex) { EntityType = typeof(XINV_Rpt041_Rpt) };
            }        
        }
    }
}
