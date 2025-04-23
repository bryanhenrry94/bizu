using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;

namespace Bizu.Application.Facturacion
{
    public class Fa_Factura_X_NotaPedido_Bus
    {
        fa_factura_X_NotaPedido_Data pedidoDetallesData = new fa_factura_X_NotaPedido_Data();

        public List<fa_pedido_det_Info> GetListaPedidoDetalles_X_Cliente(int IdEmpresa, int IdSucursal, int IdBodega, int IdCliente, ref string mensaje)
        {
            try
            {
                return pedidoDetallesData.GetListaPedidoDetalles_X_Cliente(IdEmpresa, IdSucursal, IdBodega, IdCliente, ref mensaje);
            }
            catch (Exception e)
            {
                mensaje = e.ToString();
                throw;
            }
        }
    }
}