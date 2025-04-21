using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data;
using Core.Erp.Info;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt042_Bus
    {
        private XCXP_Rpt042_Data data;

        public XCXP_Rpt042_Bus()
        {
            this.data = new XCXP_Rpt042_Data();
        }

        public List<XCXP_Rpt042_Info> GetData(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return this.data.GetData(IdEmpresa, FechaIni, FechaFin);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
