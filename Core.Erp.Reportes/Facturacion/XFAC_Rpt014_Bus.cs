using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt014_Bus
    {
        XFAC_Rpt014_Data data = new XFAC_Rpt014_Data();

        public List<XFAC_Rpt014_Info> Get_ListCostoProductoVendido(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string IdUsuario,
            List<Int32> List_IdCliente, List<Int32> List_IdMarca, bool bMostrarDetalle)
        {
            try
            {
                return data.Get_ListCostoProductoVendido(IdEmpresa, IdSucursal, FechaIni, FechaFin, IdUsuario, List_IdCliente, List_IdMarca, bMostrarDetalle);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt014_Info>();
            }
        }        
    }
}
