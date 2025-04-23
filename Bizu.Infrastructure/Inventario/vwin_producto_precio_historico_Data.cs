using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Inventario;
using Bizu.Domain.Facturacion;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.Inventario
{
    public class vwin_producto_precio_historico_Data
    {
        string mensaje = "";

        public List<vwin_producto_precio_historico_Info> Get_List_Producto_Precio_Historico(int IdEmpresa, int IdBodega_Inicio, int IdBodega_Fin,
            int IdMarca, int IdLinea, string IdCategoria, decimal IdProductoIni, decimal IdProductoFin)
        {
            try
            {
                List<vwin_producto_precio_historico_Info> list = new List<vwin_producto_precio_historico_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                IdProductoIni = (IdProductoIni == 0 ? 1 : IdProductoIni);
                IdProductoFin = (IdProductoFin == 0 ? 9999 : IdProductoFin);

                var sql = (from A in OEInventario.vwin_producto_precio_historico
                           where A.IdEmpresa == IdEmpresa
                           && A.IdBodega >= IdBodega_Inicio && A.IdBodega <= IdBodega_Fin
                           && A.IdProducto >= IdProductoIni && A.IdProducto <= IdProductoFin
                           select A);

                if (IdMarca != 0)
                    sql = sql.Where(q => q.IdMarca == IdMarca);

                if (IdCategoria != "")
                    sql = sql.Where(q => q.IdCategoria == IdCategoria);

                if (IdLinea != 0)
                    sql = sql.Where(q => q.IdLinea == IdLinea);

                foreach (var _historico in sql.ToList())
                {
                    vwin_producto_precio_historico_Info item = new vwin_producto_precio_historico_Info();
                    item.IdEmpresa = _historico.IdEmpresa;
                    item.IdProducto = _historico.IdProducto;
                    item.IdBodega = _historico.IdBodega;
                    item.pr_codigo = _historico.pr_codigo;
                    item.pr_descripcion = _historico.pr_descripcion;
                    item.pr_peso = _historico.pr_peso;
                    item.pr_ManejaIva = _historico.pr_ManejaIva;
                    item.pr_ManejaSeries = _historico.pr_ManejaSeries;
                    item.bo_Descripcion = _historico.bo_Descripcion;
                    item.IdSucursal = _historico.IdSucursal;
                    item.Su_Descripcion = _historico.Su_Descripcion;
                    item.IdMarca = _historico.IdMarca;
                    item.IdProductoTipo = _historico.IdProductoTipo;
                    item.IdPresentacion = _historico.IdPresentacion;
                    item.IdCtaCble_Inven = _historico.IdCtaCble_Inven;
                    item.IdCtaCble_Costo = _historico.IdCtaCble_Costo;
                    item.ManejaKardex = _historico.ManejaKardex;
                    item.IdNaturaleza = _historico.IdNaturaleza;
                    item.IdCtaCble_Inventario = _historico.IdCtaCble_Inventario;
                    item.IdCentro_Costo_Inventario = _historico.IdCentro_Costo_Inventario;
                    item.IdCentro_Costo_Costo = _historico.IdCentro_Costo_Costo;
                    item.IdCtaCble_Gasto_x_cxp = _historico.IdCtaCble_Gasto_x_cxp;
                    item.IdCentroCosto_x_Gasto_x_cxp = _historico.IdCentroCosto_x_Gasto_x_cxp;
                    item.IdCentroCosto_sub_centro_costo_inv = _historico.IdCentroCosto_sub_centro_costo_inv;
                    item.IdCentroCosto_sub_centro_costo_cost = _historico.IdCentroCosto_sub_centro_costo_cost;
                    item.IdCentroCosto_sub_centro_costo_cxp = _historico.IdCentroCosto_sub_centro_costo_cxp;
                    item.IdCtaCble_CosBaseIva = _historico.IdCtaCble_CosBaseIva;
                    item.IdCtaCble_CosBase0 = _historico.IdCtaCble_CosBase0;
                    item.IdCtaCble_VenIva = _historico.IdCtaCble_VenIva;
                    item.IdCtaCble_Ven0 = _historico.IdCtaCble_Ven0;
                    item.IdCtaCble_DesIva = _historico.IdCtaCble_DesIva;
                    item.IdCtaCble_Des0 = _historico.IdCtaCble_Des0;
                    item.IdCtaCble_DevIva = _historico.IdCtaCble_DevIva;
                    item.IdCtaCble_Dev0 = _historico.IdCtaCble_Dev0;
                    item.IdCtaCble_Vta = _historico.IdCtaCble_Vta;
                    item.pr_stock_minimo = _historico.pr_stock_minimo;
                    item.IdCod_Impuesto_Iva = _historico.IdCod_Impuesto_Iva;
                    item.IdCod_Impuesto_Ice = _historico.IdCod_Impuesto_Ice;
                    item.Aparece_modu_Ventas = _historico.Aparece_modu_Ventas;
                    item.Aparece_modu_Compras = _historico.Aparece_modu_Compras;
                    item.Aparece_modu_Inventario = _historico.Aparece_modu_Inventario;
                    item.Aparece_modu_Activo_F = _historico.Aparece_modu_Activo_F;
                    item.IdCategoria = _historico.IdCategoria;
                    item.nom_Categoria = _historico.nom_Categoria;
                    item.IdLinea = _historico.IdLinea;
                    item.nom_linea = _historico.nom_linea;
                    item.pr_codigo_barra = _historico.pr_codigo_barra;
                    item.pr_precio_publico = Convert.ToDouble(_historico.pr_precio_publico);
                    item.pr_precio_mayor = Convert.ToDouble(_historico.pr_precio_mayor);
                    item.pr_precio_minimo = Convert.ToDouble(_historico.pr_precio_minimo);
                    item.pr_precio_publico_nuevo = Convert.ToDouble(_historico.pr_precio_publico);
                    item.pr_precio_mayor_nuevo = Convert.ToDouble(_historico.pr_precio_mayor);
                    item.pr_precio_minimo_nuevo = Convert.ToDouble(_historico.pr_precio_minimo);
                    item.Fecha = _historico.Fecha;
                    item.IdUsuario = _historico.IdUsuario;
                    item.Secuencia = _historico.Secuencia;
                    list.Add(item);
                }

                return list;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}