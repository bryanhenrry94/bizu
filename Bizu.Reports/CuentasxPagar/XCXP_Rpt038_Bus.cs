using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt038_Bus
    {
        XCXP_Rpt038_Data odata = new XCXP_Rpt038_Data();
        string mensaje = "";

        public List<XCXP_Rpt038_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdProveedorIni, int IdProveedorFin, ref string mensaje)
        {
            try
            {
                return odata.consultar_data(IdEmpresa, FechaIni, FechaFin,IdProveedorIni,IdProveedorFin, ref  mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt038_Info>();
            }

        }

    }
}
