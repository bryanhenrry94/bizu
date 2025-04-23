using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure;
using Bizu.Domain;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt043_Bus
    {
        private XCXP_Rpt043_Data data;

        public XCXP_Rpt043_Bus()
        {
            this.data = new XCXP_Rpt043_Data();
        }

        public List<XCXP_Rpt043_Info> GetData(int IdEmpresa, decimal IdProveedorIni, decimal IdProveedorFin, DateTime FechaIni, DateTime FechaFin, string IdUsuario)
        {
            try
            {
                return this.data.GetData(IdEmpresa, IdProveedorIni, IdProveedorFin, FechaIni, FechaFin, IdUsuario);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
