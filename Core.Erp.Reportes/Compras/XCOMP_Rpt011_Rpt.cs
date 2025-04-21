using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;

using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt011_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCOMP_Rpt011_Bus repbus = new XCOMP_Rpt011_Bus();

        public XCOMP_Rpt011_Rpt()
        {
            InitializeComponent();
        }
       
        private void XCOMP_Rpt010_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                List<XCOMP_Rpt011_Info> ListDataRpt = new List<XCOMP_Rpt011_Info>();
                
                int IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                int IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                int IdProveedor = Convert.ToInt32(Parameters["IdProveedor"].Value);
                int IdOrdenCompra = Convert.ToInt32(Parameters["IdOrdenCompra"].Value);
                string IdCentroCosto = Convert.ToString(Parameters["IdCentroCosto"].Value);
                DateTime Fecha_Desde = Convert.ToDateTime(Parameters["Fecha_Desde"].Value);
                DateTime Fecha_Hasta = Convert.ToDateTime(Parameters["Fecha_Hasta"].Value);
                bool MostrarAnuladas = Convert.ToBoolean(Parameters["MostrarAnuladas"].Value);

                ListDataRpt = repbus.Cargar_data(param.IdEmpresa, IdSucursal, IdProveedor, IdCentroCosto, Fecha_Desde, Fecha_Hasta);

                if (IdOrdenCompra != 0)
                    ListDataRpt = ListDataRpt.FindAll(q => q.IdOrdenCompra == IdOrdenCompra);

                if (!MostrarAnuladas)
                    ListDataRpt = ListDataRpt.FindAll(q => q.Estado == "A");

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCOMP_Rpt010_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt011_Rpt) };
            }
        }
    }
}