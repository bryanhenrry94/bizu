using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_X_NotaPedido_Data
    {
        private EntitiesFacturacion db = new EntitiesFacturacion();

        public List<fa_pedido_det_Info> GetListaPedidoDetalles_X_Cliente(int IdEmpresa, int IdSucursal, int IdBodega, int IdCliente, ref string mensaje)
        {
            List<fa_pedido_det_Info> ListaDetallesPedido = new List<fa_pedido_det_Info>();

            if (IdCliente != null)
            {
                try
                {
                    var consulta = from c in db.vwfa_pedido_detalle
                                   where c.IdEmpresa == IdEmpresa && c.IdSucursal == IdSucursal && c.IdBodega == IdBodega
                                   select c;

                    ListaDetallesPedido = new List<fa_pedido_det_Info>();

                    foreach (var item in consulta)
                    {

                        fa_pedido_det_Info obj = new fa_pedido_det_Info();
                        obj.IdEmpresa = item.IdEmpresa;
                        obj.IdSucursal = item.IdSucursal;
                        obj.IdBodega = item.IdBodega;
                        obj.IdVendedor = item.IdVendedor;
                        obj.IdPedido = item.IdPedido;
                        obj.IdProducto = item.IdProducto;
                        obj.dp_precio = item.dp_precio;
                        obj.dp_PorDescuento = item.dp_PorDescuento;
                        // obj.cp_PrecioFinal = item.cp_PrecioFinal;
                        obj.dp_desUni = item.cp_desUni;
                        obj.dp_subtotal = item.dp_subtotal;
                        obj.dp_total = item.dp_total;
                        obj.dp_iva = item.dp_iva;
                        obj.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        obj.dp_por_iva = item.dp_por_iva;
                        obj.vt_cantidad = Convert.ToDecimal(item.dp_cantidad);
                        obj.vt_Precio = item.dp_precio;
                        obj.vt_PorDescUnitario = item.dp_PorDescuento;
                        obj.vt_Subtotal = item.dp_subtotal;
                        obj.vt_iva = item.dp_iva;
                        obj.vt_total = item.dp_total;
                        ListaDetallesPedido.Add(obj);

                    }
                }
                catch (DbEntityValidationException ex)
                {

                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                }
            }
            return ListaDetallesPedido;
        }
    }
}