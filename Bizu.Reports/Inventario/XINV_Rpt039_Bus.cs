using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt039_Bus
    {
        XINV_Rpt039_Data data = new XINV_Rpt039_Data();

        public List<XINV_Rpt039_Info> Get_Data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMov_inven_tipo, int IdNumMovi, decimal IdProducto)
        {
            try
            {
                return data.Get_Data(IdEmpresa, IdSucursal, IdBodega, IdMov_inven_tipo, IdNumMovi, IdProducto);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt039_Info>();
            }
        }
        
    }
}
