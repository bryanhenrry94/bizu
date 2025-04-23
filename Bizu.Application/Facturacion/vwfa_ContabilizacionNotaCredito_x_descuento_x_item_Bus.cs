using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;

namespace Bizu.Application.Facturacion
{
    public class vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Bus
    {
        private vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Data Data = new vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Data();

        public List<vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return Data.get_list(IdEmpresa, IdSucursal, IdBodega, IdNota);                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
