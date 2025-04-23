using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Facturacion
{
    public class XFAC_Rpt015_Bus
    {
        XFAC_Rpt015_Data data = new XFAC_Rpt015_Data();

        public List<XFAC_Rpt015_Info> Get_Data(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni,
          int IdBodegaFin, int IdVendedorIni, int IdVendedorFin, DateTime FechaIni, DateTime FechaFin, int IdClienteIni, int IdClienteFin)
        {
            try
            {                
                return data.Get_Data(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni,IdBodegaFin, IdVendedorIni, IdVendedorFin, FechaIni, 
                                    FechaFin, IdClienteIni, IdClienteFin);
            }
            catch (Exception)
            {
                return new List<XFAC_Rpt015_Info>();
            }
        }
    }
}
