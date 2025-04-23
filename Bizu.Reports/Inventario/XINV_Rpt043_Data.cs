using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt043_Data
    {
        public List<XINV_Rpt043_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, int IdMov_inven_tipoIni, int IdMov_inven_tipoFin, string TipoMov, DateTime FechaIni, DateTime FechaFin, string IdCategoria, Int32 IdLinea)
        {
            try
            {
                Int32 IdLineaIni = (IdLinea != 0) ? IdLinea : 0;
                Int32 IdLineaFin = (IdLinea != 0) ? IdLinea : 99999999;

                List<XINV_Rpt043_Info> lista = new List<XINV_Rpt043_Info>();

                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    //double Subtotal = 0;                   
                    var querry = from q in conexion.vwINV_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                    && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                    && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                    && q.IdCentro_costo.Contains(IdCentroCosto)
                                    && q.IdSubcentro_costo.Contains(IdSubCentroCosto)
                                    && q.IdMovi_inven_tipo >= IdMov_inven_tipoIni && q.IdMovi_inven_tipo <= IdMov_inven_tipoFin
                                    && q.IdProducto >= IdProductoIni && q.IdProducto <= IdProductoFin
                                    && q.cm_tipo.Contains(TipoMov)
                                    && q.cm_fecha >= FechaIni && q.cm_fecha <= FechaFin
                                 //&& q.IdCategoria.Contains(IdCategoria)
                                 //&& q.IdLinea >= IdLineaIni && q.IdLinea <= IdLineaFin
                                 group q by new
                                 {
                                     q.IdEmpresa,
                                     q.nom_empresa,
                                     q.ruc_empresa,
                                     q.IdSucursal,
                                     q.nom_sucursal,
                                     q.IdBodega,
                                     q.nom_bodega,
                                     q.IdMovi_inven_tipo,
                                     q.IdNumMovi,
                                     q.CodMoviInven,
                                     q.cm_tipo,
                                     q.mv_costo,
                                     q.dm_cantidad,
                                     q.cm_fecha,
                                     q.Secuencia,
                                     q.IdProducto,
                                     q.cod_producto,
                                     q.nom_producto,
                                     q.dm_observacion,
                                     q.nom_tipo_inven,
                                     q.nom_centro_costo,
                                     q.nom_subcentro_costo,
                                     q.IdCentro_costo,
                                     q.IdSubcentro_costo,
                                     q.Id_ing_egr,
                                     q.IdProveedor,
                                     q.nom_proveedor,
                                     q.IdOrdenCompra,
                                     q.IdMotivo_Inv,
                                     q.Desc_mov_inv,
                                     q.IdCategoria,
                                     q.nom_categoria,
                                     q.IdLinea,
                                     q.nom_linea,
                                     q.IdGuiaRemision,
                                     q.numGuia
                                 }
                                     into grouping
                                 select new
                                 {
                                     grouping.Key
                                 };

                    if (IdCentroCosto != "")
                    {
                        querry = querry.Where(q => q.Key.IdCentro_costo == IdCentroCosto);
                    }

                    if (IdCategoria != "")
                    {
                        querry = querry.Where(q => q.Key.IdCategoria == IdCategoria);
                        querry = querry.Where(q => q.Key.IdLinea >= IdLineaIni && q.Key.IdLinea <= IdLineaFin);
                    }

                    foreach (var item in querry)
                    {
                        XINV_Rpt043_Info itemInfo = new XINV_Rpt043_Info();
                        itemInfo.IdEmpresa = item.Key.IdEmpresa;
                        itemInfo.nom_empresa = item.Key.nom_empresa;
                        itemInfo.ruc_empresa = item.Key.ruc_empresa;
                        itemInfo.IdSucursal = item.Key.IdSucursal;
                        itemInfo.nom_sucursal = item.Key.nom_sucursal;
                        itemInfo.IdBodega = item.Key.IdBodega;
                        itemInfo.nom_bodega = item.Key.nom_bodega;
                        itemInfo.IdMovi_inven_tipo = item.Key.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.Key.IdNumMovi;
                        itemInfo.CodMoviInven = item.Key.CodMoviInven;
                        itemInfo.cm_tipo = item.Key.cm_tipo;
                        itemInfo.mv_costo = item.Key.mv_costo;
                        itemInfo.dm_cantidad = item.Key.dm_cantidad;
                        itemInfo.SubTotal = item.Key.dm_cantidad * item.Key.mv_costo;
                        itemInfo.cm_fecha = Convert.ToDateTime(item.Key.cm_fecha);
                        itemInfo.Secuencia = item.Key.Secuencia;
                        itemInfo.IdProducto = item.Key.IdProducto;
                        itemInfo.cod_producto = item.Key.cod_producto;
                        itemInfo.nom_producto = item.Key.nom_producto;
                        itemInfo.dm_observacion = item.Key.dm_observacion;
                        itemInfo.nom_tipo_inven = item.Key.nom_tipo_inven;
                        itemInfo.nom_centro_costo = (item.Key.IdCentro_costo != "") ? "[" + item.Key.IdCentro_costo + "] - " + item.Key.nom_centro_costo : "";
                        itemInfo.nom_subcentro_costo = item.Key.nom_subcentro_costo;
                        itemInfo.IdCentro_costo = item.Key.IdCentro_costo;
                        itemInfo.IdSubcentro_costo = item.Key.IdSubcentro_costo;
                        itemInfo.Id_ing_egr = item.Key.Id_ing_egr;
                        itemInfo.IdProveedor = item.Key.IdProveedor;
                        itemInfo.nom_proveedor = item.Key.nom_proveedor;
                        itemInfo.IdOrdenCompra = item.Key.IdOrdenCompra;
                        itemInfo.IdMotivo_Inv = item.Key.IdMotivo_Inv;
                        itemInfo.Desc_mov_inv = item.Key.Desc_mov_inv;
                        itemInfo.IdCategoria = item.Key.IdCategoria;
                        itemInfo.nom_categoria = (item.Key.IdCategoria != "") ? "[" + item.Key.IdCategoria + "] - " + item.Key.nom_categoria : "";
                        itemInfo.IdLinea = item.Key.IdLinea;
                        itemInfo.nom_linea = (item.Key.IdLinea != 0) ? "[" + item.Key.IdLinea + "] - " + item.Key.nom_linea : "";
                        itemInfo.IdGuiaRemision = item.Key.IdGuiaRemision;
                        itemInfo.numGuia = Convert.ToString(item.Key.numGuia);
                        itemInfo.CostoTotal = Math.Round(itemInfo.dm_cantidad * itemInfo.mv_costo, 2);

                        lista.Add(itemInfo);
                    }
                }

                return lista.OrderBy(q => q.IdNumMovi).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<XINV_Rpt043_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, int IdMov_inven_tipoIni, int IdMov_inven_tipoFin, string TipoMov, DateTime FechaIni, DateTime FechaFin, string IdCategoria, List<Int32?> IdLineaList, Boolean Considerar_saldo_inicial)
        {
            try
            {
                List<XINV_Rpt043_Info> lista = new List<XINV_Rpt043_Info>();
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    conexion.SetCommandTimeOut(30000); //3 minutos

                    //double Subtotal = 0;
                    var querry = from q in conexion.spINV_Rpt030(IdEmpresa, IdSucursalIni, IdSucursalFin,
                                     IdBodegaIni, IdBodegaFin, IdCentroCosto, IdSubCentroCosto, IdMov_inven_tipoIni,
                                     IdMov_inven_tipoFin, IdProductoIni, IdProductoFin, TipoMov, FechaIni, FechaFin, Considerar_saldo_inicial)
                                 group q by new
                                 {
                                     q.IdEmpresa,
                                     q.nom_empresa,
                                     q.ruc_empresa,
                                     q.IdSucursal,
                                     q.nom_sucursal,
                                     q.IdBodega,
                                     q.nom_bodega,
                                     q.IdMovi_inven_tipo,
                                     q.IdNumMovi,
                                     q.CodMoviInven,
                                     q.cm_tipo,
                                     q.mv_costo,
                                     q.dm_cantidad,
                                     q.SubTotal,
                                     q.cm_fecha,
                                     q.Secuencia,
                                     q.IdProducto,
                                     q.cod_producto,
                                     q.nom_producto,
                                     q.dm_observacion,
                                     q.nom_tipo_inven,
                                     q.nom_centro_costo,
                                     q.nom_subcentro_costo,
                                     q.IdCentro_costo,
                                     q.IdSubcentro_costo,
                                     q.Id_ing_egr,
                                     q.IdProveedor,
                                     q.nom_proveedor,
                                     q.IdOrdenCompra,
                                     q.IdMotivo_Inv,
                                     q.Desc_mov_inv,
                                     q.IdCategoria,
                                     q.nom_categoria,
                                     q.IdLinea,
                                     q.nom_linea,
                                     q.IdGuiaRemision,
                                     q.numGuia
                                 }
                                     into grouping
                                 select new
                                 {
                                     grouping.Key
                                 };

                    if (IdCentroCosto != "")
                    {
                        querry = querry.Where(q => q.Key.IdCentro_costo == IdCentroCosto);
                    }

                    if (IdCategoria != "")
                    {
                        querry = querry.Where(q => q.Key.IdCategoria == IdCategoria);

                        if (IdLineaList.Count > 0)
                        {
                            querry = querry.Where(q => IdLineaList.Contains(q.Key.IdLinea));
                        }
                    }


                    foreach (var item in querry)
                    {
                        XINV_Rpt043_Info itemInfo = new XINV_Rpt043_Info();
                        itemInfo.IdEmpresa = item.Key.IdEmpresa;
                        itemInfo.nom_empresa = item.Key.nom_empresa;
                        itemInfo.ruc_empresa = item.Key.ruc_empresa;
                        itemInfo.IdSucursal = item.Key.IdSucursal;
                        itemInfo.nom_sucursal = item.Key.nom_sucursal;
                        itemInfo.IdBodega = item.Key.IdBodega;
                        itemInfo.nom_bodega = item.Key.nom_bodega;
                        itemInfo.IdMovi_inven_tipo = item.Key.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.Key.IdNumMovi;
                        itemInfo.CodMoviInven = item.Key.CodMoviInven;
                        itemInfo.cm_tipo = item.Key.cm_tipo;
                        itemInfo.mv_costo = item.Key.mv_costo;
                        itemInfo.dm_cantidad = item.Key.dm_cantidad;
                        itemInfo.SubTotal = item.Key.SubTotal;
                        itemInfo.cm_fecha = item.Key.cm_fecha;
                        itemInfo.Secuencia = item.Key.Secuencia;
                        itemInfo.IdProducto = item.Key.IdProducto;
                        itemInfo.cod_producto = item.Key.cod_producto;
                        itemInfo.nom_producto = item.Key.nom_producto;
                        itemInfo.dm_observacion = item.Key.dm_observacion;
                        itemInfo.nom_tipo_inven = item.Key.nom_tipo_inven;
                        itemInfo.nom_centro_costo = (item.Key.IdCentro_costo != "") ? "[" + item.Key.IdCentro_costo + "] - " + item.Key.nom_centro_costo : "";
                        itemInfo.nom_subcentro_costo = item.Key.nom_subcentro_costo;
                        itemInfo.IdCentro_costo = item.Key.IdCentro_costo;
                        itemInfo.IdSubcentro_costo = item.Key.IdSubcentro_costo;
                        itemInfo.Id_ing_egr = item.Key.Id_ing_egr;
                        itemInfo.IdProveedor = item.Key.IdProveedor;
                        itemInfo.nom_proveedor = item.Key.nom_proveedor;
                        itemInfo.IdOrdenCompra = item.Key.IdOrdenCompra;
                        itemInfo.IdMotivo_Inv = item.Key.IdMotivo_Inv;
                        itemInfo.Desc_mov_inv = item.Key.Desc_mov_inv;
                        itemInfo.IdCategoria = item.Key.IdCategoria;
                        itemInfo.nom_categoria = (item.Key.IdCategoria != "") ? "[" + item.Key.IdCategoria + "] - " + item.Key.nom_categoria : "";
                        itemInfo.IdLinea = item.Key.IdLinea;
                        itemInfo.nom_linea = (item.Key.IdLinea != 0) ? "[" + item.Key.IdLinea + "] - " + item.Key.nom_linea : "";
                        itemInfo.IdGuiaRemision = item.Key.IdGuiaRemision;
                        itemInfo.numGuia = item.Key.numGuia;
                        itemInfo.CostoTotal = Math.Round(itemInfo.dm_cantidad * itemInfo.mv_costo, 2);

                        lista.Add(itemInfo);
                    }
                }

                return lista.OrderBy(q => q.IdNumMovi).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<XINV_Rpt043_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, List<Int32?> IdMov_inven_tipo_list, string TipoMov, DateTime FechaIni, DateTime FechaFin, string IdCategoria, List<Int32?> IdLineaList, Boolean Considerar_saldo_inicial)
        {
            try
            {
                List<XINV_Rpt043_Info> lista = new List<XINV_Rpt043_Info>();
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {

                    conexion.SetCommandTimeOut(30000); //3 minutos

                    int IdMov_inven_tipoIni = 0;
                    int IdMov_inven_tipoFin = 9999;

                    //double Subtotal = 0;
                    var querry = from q in conexion.spINV_Rpt030(IdEmpresa, IdSucursalIni, IdSucursalFin,
                                     IdBodegaIni, IdBodegaFin, IdCentroCosto, IdSubCentroCosto, IdMov_inven_tipoIni,
                                     IdMov_inven_tipoFin, IdProductoIni, IdProductoFin, TipoMov, FechaIni, FechaFin, Considerar_saldo_inicial)
                                 group q by new
                                 {
                                     q.IdEmpresa,
                                     q.nom_empresa,
                                     q.ruc_empresa,
                                     q.IdSucursal,
                                     q.nom_sucursal,
                                     q.IdBodega,
                                     q.nom_bodega,
                                     q.IdMovi_inven_tipo,
                                     q.IdNumMovi,
                                     q.CodMoviInven,
                                     q.cm_tipo,
                                     q.mv_costo,
                                     q.dm_cantidad,
                                     q.SubTotal,
                                     q.cm_fecha,
                                     q.Secuencia,
                                     q.IdProducto,
                                     q.cod_producto,
                                     q.nom_producto,
                                     q.dm_observacion,
                                     q.nom_tipo_inven,
                                     q.nom_centro_costo,
                                     q.nom_subcentro_costo,
                                     q.IdCentro_costo,
                                     q.IdSubcentro_costo,
                                     q.Id_ing_egr,
                                     q.IdProveedor,
                                     q.nom_proveedor,
                                     q.IdOrdenCompra,
                                     q.IdMotivo_Inv,
                                     q.Desc_mov_inv,
                                     q.IdCategoria,
                                     q.nom_categoria,
                                     q.IdLinea,
                                     q.nom_linea,
                                     q.IdGuiaRemision,
                                     q.numGuia
                                 }
                                     into grouping
                                 select new
                                 {
                                     grouping.Key
                                 };

                    if (IdCentroCosto != "")
                    {
                        querry = querry.Where(q => q.Key.IdCentro_costo == IdCentroCosto);
                    }

                    if (IdCategoria != "")
                    {
                        querry = querry.Where(q => q.Key.IdCategoria == IdCategoria);

                        if (IdLineaList.Count > 0)
                        {
                            querry = querry.Where(q => IdLineaList.Contains(q.Key.IdLinea));
                        }
                    }

                    if (IdMov_inven_tipo_list.Count() > 0)
                    {
                        querry = querry.Where(q => IdMov_inven_tipo_list.Contains(q.Key.IdMovi_inven_tipo));
                    }

                    foreach (var item in querry)
                    {
                        XINV_Rpt043_Info itemInfo = new XINV_Rpt043_Info();
                        itemInfo.IdEmpresa = item.Key.IdEmpresa;
                        itemInfo.nom_empresa = item.Key.nom_empresa;
                        itemInfo.ruc_empresa = item.Key.ruc_empresa;
                        itemInfo.IdSucursal = item.Key.IdSucursal;
                        itemInfo.nom_sucursal = item.Key.nom_sucursal;
                        itemInfo.IdBodega = item.Key.IdBodega;
                        itemInfo.nom_bodega = item.Key.nom_bodega;
                        itemInfo.IdMovi_inven_tipo = item.Key.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.Key.IdNumMovi;
                        itemInfo.CodMoviInven = item.Key.CodMoviInven;
                        itemInfo.cm_tipo = item.Key.cm_tipo;
                        itemInfo.mv_costo = item.Key.mv_costo;
                        itemInfo.dm_cantidad = item.Key.dm_cantidad;
                        itemInfo.SubTotal = item.Key.SubTotal;
                        itemInfo.cm_fecha = item.Key.cm_fecha;
                        itemInfo.Secuencia = item.Key.Secuencia;
                        itemInfo.IdProducto = item.Key.IdProducto;
                        itemInfo.cod_producto = item.Key.cod_producto;
                        itemInfo.nom_producto = item.Key.nom_producto;
                        itemInfo.dm_observacion = item.Key.dm_observacion;
                        itemInfo.nom_tipo_inven = item.Key.nom_tipo_inven;
                        itemInfo.nom_centro_costo = (item.Key.IdCentro_costo != "") ? "[" + item.Key.IdCentro_costo + "] - " + item.Key.nom_centro_costo : "";
                        itemInfo.nom_subcentro_costo = item.Key.nom_subcentro_costo;
                        itemInfo.IdCentro_costo = item.Key.IdCentro_costo;
                        itemInfo.IdSubcentro_costo = item.Key.IdSubcentro_costo;
                        itemInfo.Id_ing_egr = item.Key.Id_ing_egr;
                        itemInfo.IdProveedor = item.Key.IdProveedor;
                        itemInfo.nom_proveedor = item.Key.nom_proveedor;
                        itemInfo.IdOrdenCompra = item.Key.IdOrdenCompra;
                        itemInfo.IdMotivo_Inv = item.Key.IdMotivo_Inv;
                        itemInfo.Desc_mov_inv = item.Key.Desc_mov_inv;
                        itemInfo.IdCategoria = item.Key.IdCategoria;
                        itemInfo.nom_categoria = (item.Key.IdCategoria != "") ? "[" + item.Key.IdCategoria + "] - " + item.Key.nom_categoria : "";
                        itemInfo.IdLinea = item.Key.IdLinea;
                        itemInfo.nom_linea = (item.Key.IdLinea != 0) ? "[" + item.Key.IdLinea + "] - " + item.Key.nom_linea : "";
                        itemInfo.IdGuiaRemision = item.Key.IdGuiaRemision;
                        itemInfo.numGuia = item.Key.numGuia;
                        itemInfo.CostoTotal = Math.Round(itemInfo.dm_cantidad * itemInfo.mv_costo, 2);

                        lista.Add(itemInfo);
                    }
                }

                return lista.OrderBy(q => q.IdNumMovi).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<XINV_Rpt043_Info> Get_Kardex(int IdEmpresa, int IdSucursal, string IdCentroCosto, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XINV_Rpt043_Info> lista = new List<XINV_Rpt043_Info>();
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    conexion.SetCommandTimeOut(30000); //3 minutos

                    //double Subtotal = 0;
                    var querry = from q in conexion.vwINV_Rpt030
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal == IdSucursal
                                 && q.IdCentro_costo == IdCentroCosto
                                 && q.cm_fecha >= FechaIni
                                 && q.cm_fecha <= FechaFin
                                 select q;

                    foreach (var item in querry)
                    {
                        XINV_Rpt043_Info itemInfo = new XINV_Rpt043_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.nom_empresa = item.nom_empresa;
                        itemInfo.ruc_empresa = item.ruc_empresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.CodMoviInven = item.CodMoviInven;
                        itemInfo.cm_tipo = item.cm_tipo;
                        itemInfo.mv_costo = item.mv_costo;
                        itemInfo.dm_cantidad = item.dm_cantidad;
                        itemInfo.cm_fecha = item.cm_fecha;
                        itemInfo.Secuencia = item.Secuencia;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.cod_producto = item.cod_producto;
                        itemInfo.nom_producto = item.nom_producto;
                        itemInfo.dm_observacion = item.dm_observacion;
                        itemInfo.nom_tipo_inven = item.nom_tipo_inven;
                        itemInfo.nom_centro_costo = (item.IdCentro_costo != "") ? "[" + item.IdCentro_costo + "] - " + item.nom_centro_costo : "";
                        itemInfo.nom_subcentro_costo = item.nom_subcentro_costo;
                        itemInfo.IdCentro_costo = item.IdCentro_costo;
                        itemInfo.IdSubcentro_costo = item.IdSubcentro_costo;
                        itemInfo.Id_ing_egr = item.Id_ing_egr;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.nom_proveedor = item.nom_proveedor;
                        itemInfo.IdOrdenCompra = item.IdOrdenCompra;
                        itemInfo.IdMotivo_Inv = item.IdMotivo_Inv;
                        itemInfo.Desc_mov_inv = item.Desc_mov_inv;
                        itemInfo.IdCategoria = item.IdCategoria;
                        itemInfo.nom_categoria = (item.IdCategoria != "") ? "[" + item.IdCategoria + "] - " + item.nom_categoria : "";
                        itemInfo.IdLinea = item.IdLinea;
                        itemInfo.nom_linea = (item.IdLinea != 0) ? "[" + item.IdLinea + "] - " + item.nom_linea : "";
                        itemInfo.IdGuiaRemision = item.IdGuiaRemision;
                        itemInfo.CostoTotal = Math.Round(itemInfo.dm_cantidad * itemInfo.mv_costo, 2);

                        lista.Add(itemInfo);
                    }
                }

                return lista.OrderBy(q => q.IdNumMovi).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}