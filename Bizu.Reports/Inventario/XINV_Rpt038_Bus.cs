using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt038_Bus
    {
        XINV_Rpt038_Data data = new XINV_Rpt038_Data();

        public List<XINV_Rpt038_Info> Get_Data(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, int IdProductoIni, int IdProductoFin, DateTime FechaIni, DateTime FechaFin, string IdCategoria, List<int?> IdLinea_List)
        {
            try
            {
                return data.Get_Data(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, FechaIni, FechaFin, IdCategoria, IdLinea_List);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt038_Info>();
            }
        }
        
    }
}
