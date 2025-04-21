using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt041_Bus
    {
        XCXP_Rpt041_Data oData = new XCXP_Rpt041_Data();

        public List<XCXP_Rpt041_Info> Get_Lista_Reporte(int IdEmpresa, string IdTipo_Persona, int IdEntidad, DateTime Fecha_Desde, DateTime Fecha_Hasta)
        {
            try
            {
                return oData.Get_Lista_Reporte(IdEmpresa, IdTipo_Persona, IdEntidad, Fecha_Desde, Fecha_Hasta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
