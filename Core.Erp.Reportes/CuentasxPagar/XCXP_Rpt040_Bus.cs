using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt040_Bus
    {
        XCXP_Rpt040_Data oData = new XCXP_Rpt040_Data();

        public List<XCXP_Rpt040_Info> Get_Lista_Reporte(int idEmpresa, string idCentroCosto, string idSubcentroCosto, DateTime fechaIni, DateTime FechaFin, Int32 IdProveedorIni, Int32 IdProveedorFin)
        {
            try
            {
                return oData.Get_Lista_Reporte(idEmpresa, idCentroCosto, idSubcentroCosto,fechaIni, FechaFin, IdProveedorIni, IdProveedorFin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
