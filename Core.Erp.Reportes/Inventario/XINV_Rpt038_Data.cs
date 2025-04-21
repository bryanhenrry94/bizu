using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt038_Data
    {
        public List<XINV_Rpt038_Info> Get_Data(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, int IdProductoIni, int IdProductoFin, DateTime FechaIni, DateTime FechaFin, string IdCategoria, List<int?> IdLinea_List)
        {
            try
            {                         
                List<XINV_Rpt038_Info> lista = new List<XINV_Rpt038_Info>();
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    var querry = from q in conexion.vwINV_Rpt038
                                 where q.IdEmpresa == IdEmpresa 
                                 && q.IdSucursalOrigen >= IdSucursalIni && q.IdSucursalOrigen <= IdSucursalFin
                                 && q.IdBodegaOrigen >= IdBodegaIni && q.IdBodegaOrigen <= IdBodegaFin
                                 && q.IdProducto_Egr >= IdProductoIni && q.IdProducto_Egr <= IdProductoFin
                                 && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin
                                 select q;

                    if (IdCategoria != "")
                    {
                        if (IdLinea_List.Count() > 0)
                        {
                            querry = querry.Where(q => q.IdCategoria == IdCategoria && IdLinea_List.Contains(q.IdLinea));
                        }
                        else
                        {
                            querry = querry.Where(q => q.IdCategoria == IdCategoria);
                        }                        
                    }

                    foreach (var item in querry)
                    {

                        XINV_Rpt038_Info itemInfo = new XINV_Rpt038_Info();

                        itemInfo.SucuOrigen = item.SucuOrigen;
                        itemInfo.BodegaORIG = item.BodegaORIG;
                        itemInfo.SucuDEST = item.SucuDEST;
                        itemInfo.BodegDest = item.BodegDest;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursalOrigen = item.IdSucursalOrigen;
                        itemInfo.IdBodegaOrigen = item.IdBodegaOrigen;
                        itemInfo.IdTransferencia = item.IdTransferencia;
                        itemInfo.IdSucursalDest = item.IdSucursalDest;
                        itemInfo.IdBodegaDest = item.IdBodegaDest;
                        itemInfo.tr_Observacion = item.tr_Observacion;
                        itemInfo.tr_fecha = item.tr_fecha;
                        itemInfo.Estado = item.Estado;
                        itemInfo.IdUsuario = item.IdUsuario;
                        itemInfo.IdEmpresa_Ing_Egr_Inven_Origen = item.IdEmpresa_Ing_Egr_Inven_Origen;
                        itemInfo.IdSucursal_Ing_Egr_Inven_Origen = item.IdSucursal_Ing_Egr_Inven_Origen;
                        itemInfo.IdMovi_inven_tipo_SucuOrig = item.IdMovi_inven_tipo_SucuOrig;
                        itemInfo.TipoMovimiento_Origen = item.TipoMovimiento_Origen;
                        itemInfo.IdNumMovi_Ing_Egr_Inven_Origen = item.IdNumMovi_Ing_Egr_Inven_Origen;
                        itemInfo.IdProducto_Egr = item.IdProducto_Egr;
                        itemInfo.pr_codigo_Egr = item.pr_codigo_Egr;
                        itemInfo.pr_descripcion_Egr = item.pr_descripcion_Egr;
                        itemInfo.Cantidad_Egr = item.Cantidad_Egr;
                        itemInfo.IdEmpresa_Ing_Egr_Inven_Destino = item.IdEmpresa_Ing_Egr_Inven_Destino;
                        itemInfo.IdSucursal_Ing_Egr_Inven_Destino = item.IdSucursal_Ing_Egr_Inven_Destino;
                        itemInfo.IdMovi_inven_tipo_SucuDest = item.IdMovi_inven_tipo_SucuDest;
                        itemInfo.TipoMovimiento_Destino = item.TipoMovimiento_Destino;
                        itemInfo.IdNumMovi_Ing_Egr_Inven_Destino = item.IdNumMovi_Ing_Egr_Inven_Destino;
                        itemInfo.IdProducto_Ing = item.IdProducto_Ing;
                        itemInfo.pr_codigo_Ing = item.pr_codigo_Ing;
                        itemInfo.pr_descripcion_Ing = item.pr_descripcion_Ing;
                        itemInfo.Cantidad_Ing = item.Cantidad_Ing;
                        itemInfo.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                        itemInfo.EstadoAprobacion_cat = item.EstadoAprobacion_cat;
                        itemInfo.IdEstadoAproba_ing = item.IdEstadoAproba_ing;
                        itemInfo.IdEstadoAproba_egr = item.IdEstadoAproba_egr;
                        itemInfo.dt_secuencia = item.dt_secuencia;
                        itemInfo.IdUnidadMedida = item.IdUnidadMedida;
                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.IdCategoria = item.IdCategoria;
                        itemInfo.ca_Categoria = item.ca_Categoria;
                        itemInfo.IdLinea = item.IdLinea;
                        itemInfo.nom_linea = item.nom_linea;
                        itemInfo.IdGrupo = item.IdGrupo;
                        itemInfo.IdSubGrupo = item.IdSubGrupo;
                        itemInfo.IdTipoCbte_Origen_ct = item.IdTipoCbte_Origen_ct;
                        itemInfo.IdCbteCble_Origen_ct = item.IdCbteCble_Origen_ct;
                        itemInfo.IdTipoCbte_Destino_ct = item.IdTipoCbte_Destino_ct;
                        itemInfo.IdCbteCble_Destino_ct = item.IdCbteCble_Destino_ct;
                        itemInfo.Costo_Egr = item.Costo_Egr;
                        itemInfo.Costo_Ing = item.Costo_Ing;

                        lista.Add(itemInfo);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {                
                return new List<XINV_Rpt038_Info>();
            }
        }
    }
}
