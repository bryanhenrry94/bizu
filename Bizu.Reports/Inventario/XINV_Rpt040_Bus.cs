using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt040_Bus
    {
        XINV_Rpt040_Data Data = new XINV_Rpt040_Data();
        public List<XINV_Rpt040_Info> consultar_data(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                return Data.consultar_data(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi,  ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt040_Info>();
            }
        }
        public XINV_Rpt040_Bus()
        {

        }

    }
}
