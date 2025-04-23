using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt036_Bus
    {
        XCXP_Rpt036_Data odata = new XCXP_Rpt036_Data();
        string mensaje = "";
        
        public List<XCXP_Rpt036_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return odata.consultar_data(IdEmpresa, FechaIni, FechaFin, ref  mensaje);
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt036_Info>();
            }

        }

    }
}
