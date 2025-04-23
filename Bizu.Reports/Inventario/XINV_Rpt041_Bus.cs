using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt041_Bus
    {
        XINV_Rpt041_Data Data = new XINV_Rpt041_Data();
        
        public List<XINV_Rpt041_Info> consultar_data(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision, ref string mensaje)
        {
            try
            {
                return Data.consultar_data(IdEmpresa, IdSucursal, IdGuiaRemision,  ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt041_Info>();
            }
        }

        public XINV_Rpt041_Bus()
        {

        }

    }
}
