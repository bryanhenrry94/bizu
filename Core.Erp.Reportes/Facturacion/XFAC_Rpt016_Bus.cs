using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt016_Bus
    {
        XFAC_Rpt016_Data data = new XFAC_Rpt016_Data();

        public List<XFAC_Rpt016_Info> Get_ListCostoProductoVendido_Detalle(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string IdUsuario,
            List<Int32> List_IdCliente, List<Int32> List_IdMarca)
        {
            try
            {
                return data.Get_ListCostoProductoVendido_Detalle(IdEmpresa, IdSucursal, FechaIni, FechaFin, IdUsuario, List_IdCliente, List_IdMarca);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt016_Info>();
            }
        }
    }
}
