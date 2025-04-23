using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Facturacion;
using Bizu.Domain.Inventario;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.Inventario
{
    public class in_Producto_data
    {
        string MensajeError = "";

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_producto
                                     where C.IdEmpresa == IdEmpresa
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_Producto_Info prd = new in_Producto_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.Fecha_UltMod = item.Fecha_UltMod;

                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.nom_Categoria = item.ca_Categoria;
                    prd.nom_Linea = item.nom_linea;
                    prd.nom_Grupo = item.nom_grupo;
                    prd.nom_SubGrupo = item.nom_subgrupo;
                    prd.nom_Marca = item.Descripcion;
                    prd.nom_Tipo_Producto = item.tp_descripcion;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.AnchoEspecifico;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.IdEmpresa = item.IdEmpresa;

                    prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                    prd.IdProducto = item.IdProducto;

                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                    prd.IdUsuario = item.IdUsuario.Trim();
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.ip = item.ip.Trim();
                    prd.nom_pc = item.nom_pc.Trim();
                    prd.pr_alto = item.pr_alto;
                    prd.pr_codigo = item.pr_codigo.Trim();
                    prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_descripcion = item.pr_descripcion.Trim();
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;

                    prd.pr_largo = item.pr_largo;

                    prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                    prd.pr_observacion = item.pr_observacion.Trim();
                    prd.pr_partidaArancel = item.pr_partidaArancel;
                    prd.pr_pedidos = item.pr_pedidos;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_profundidad = item.pr_profundidad;
                    prd.pr_stock = item.pr_stock;
                    prd.pr_descripcion_2 = "[" + item.pr_codigo + "]- " + item.pr_descripcion;
                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);



                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.ManejaKardex = item.ManejaKardex;
                    prd.ManejaLote = item.ManejaLote;

                    //prd.IdNaturaleza = item.IdNaturaleza;
                    prd.pr_ManejaIva = item.pr_ManejaIva.Trim();

                    prd.IdMotivo_Vta = Convert.ToInt32(item.IdMotivo_Vta);

                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    //30-05-2018 se agrega la marca
                    prd.marca = item.marca;

                    lM.Add(prd);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_cmb(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Producto
                                     where C.IdEmpresa == IdEmpresa
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_Producto_Info prd = new in_Producto_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdProducto = item.IdProducto;
                    prd.pr_codigo = item.pr_codigo;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;
                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.IdMarca = item.IdMarca;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.IdCategoria = item.IdCategoria;
                    prd.IdLinea = item.IdLinea;
                    prd.IdGrupo = item.IdGrupo;
                    prd.IdSubGrupo = item.IdSubGrupo;
                    prd.IdUnidadMedida = item.IdUnidadMedida;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    //prd.IdNaturaleza = item.IdNaturaleza;
                    //prd.IdMotivo_Vta = item.IdMotivo_Vta;
                    prd.pr_codigo_barra = item.pr_codigo_barra;
                    prd.pr_observacion = item.pr_observacion;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_puerta = item.pr_precio_puerta;
                    prd.pr_ManejaIva = item.pr_ManejaIva;
                    prd.pr_ManejaSeries = item.pr_ManejaSeries;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    prd.pr_largo = item.pr_largo;
                    prd.pr_alto = item.pr_alto;
                    prd.pr_profundidad = item.pr_profundidad;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_partidaArancel = item.pr_partidaArancel;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_Por_descuento = item.pr_Por_descuento;
                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.IdUsuario = item.IdUsuario;
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.Fecha_UltMod = item.Fecha_UltMod;
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.pr_motivoAnulacion = item.pr_motivoAnulacion;
                    prd.nom_pc = item.nom_pc;
                    prd.ip = item.ip;
                    prd.Estado = item.Estado;
                    prd.AnchoEspecifico = item.AnchoEspecifico;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.ManejaKardex = item.ManejaKardex;
                    prd.ManejaLote = item.ManejaLote;
                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lM.Add(prd);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Producto_maneja_inventario(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                bool res = false;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_producto
                              where q.IdEmpresa == IdEmpresa
                              && q.IdProducto == IdProducto
                              select q;

                    foreach (var item in lst)
                    {
                        res = item.tp_ManejaInven == "S" ? true : false;
                        if (res == false) return res;
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Producto_maneja_lote(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                bool res = false;

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_producto
                              where q.IdEmpresa == IdEmpresa
                              && q.IdProducto == IdProducto
                              select q;

                    foreach (var item in lst)
                    {
                        res = item.ManejaLote == "S" ? true : false;
                        if (res == false) return res;
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_ManejaSeries(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_producto
                                     where C.IdEmpresa == IdEmpresa
                                     && C.pr_ManejaSeries == "S"
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    in_Producto_Info prd = new in_Producto_Info();
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.Fecha_UltMod = item.Fecha_UltMod;
                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.nom_Categoria = item.ca_Categoria;
                    prd.nom_Marca = item.Descripcion;
                    prd.nom_Tipo_Producto = item.tp_descripcion;


                    prd.pr_descripcion_2 = item.pr_descripcion_2;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.PesoEspecifico;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;



                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                    prd.IdUsuario = item.IdUsuario.Trim();
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.ip = item.ip.Trim();
                    prd.nom_pc = item.nom_pc.Trim();
                    prd.pr_alto = item.pr_alto;
                    prd.pr_codigo = item.pr_codigo.Trim();
                    prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_descripcion = item.pr_descripcion.Trim();
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;

                    prd.pr_largo = item.pr_largo;
                    prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                    prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                    prd.pr_observacion = item.pr_observacion.Trim();
                    prd.pr_partidaArancel = item.pr_partidaArancel;
                    prd.pr_pedidos = item.pr_pedidos;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_profundidad = item.pr_profundidad;
                    prd.pr_stock = item.pr_stock;
                    //prd.Producto = "[" + item.pr_codigo + "]- " + item.pr_descripcion;
                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.ManejaKardex = item.ManejaKardex;
                    //prd.IdNaturaleza = item.IdNaturaleza;

                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);


                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lM.Add(prd);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Codigo_Producto(int IdEmpresa, decimal IdProducto)
        {
            string cod_producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    cod_producto = item.pr_codigo;
                }
                return cod_producto;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_Descripcion_Producto(int IdEmpresa, decimal IdProducto)
        {
            string Des_producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    Des_producto = item.pr_descripcion;
                }
                return Des_producto;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string DescripcionTot_Producto(int IdEmpresa, decimal IdProducto)
        {
            string producto = "";
            try
            {
                EntitiesInventario OEInventario = new EntitiesInventario();
                var q = from A in OEInventario.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdProducto == IdProducto
                        select A;
                foreach (var item in q)
                {
                    producto = "[" + item.IdProducto + "] [" + item.pr_codigo + "] [" + item.pr_descripcion + "]";
                }
                return producto;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdBodega == IdBodega && C.IdSucursal == IdSucursal
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.pr_descripcion_2 = "[" + item.pr_codigo.Trim() + "]" + item.pr_descripcion.Trim();
                    info.IdBodega = item.IdBodega;

                    info.pr_peso = item.pr_peso;

                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_pedidos = item.pr_Pedidos_inv;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.ManejaKardex = item.ManejaKardex;
                    info.pr_codigo = item.pr_codigo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;


                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Bodega = item.bo_Descripcion.Trim();
                    info.nom_Sucursal = item.Su_Descripcion;

                    info.nom_Categoria = item.nom_Categoria;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Tipo_Producto = item.nom_Tipo_Producto;

                    lM.Add(info);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_sucursal
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        select C;

                foreach (var _sucursal in select_Inventario)
                {
                    in_Producto_Info item = new in_Producto_Info();
                    item.pr_costo_promedio = _sucursal.pr_costo_promedio;
                    item.IdEmpresa = _sucursal.IdEmpresa;
                    item.IdProducto = _sucursal.IdProducto;
                    item.pr_codigo = _sucursal.pr_codigo.Trim();
                    item.pr_descripcion = _sucursal.pr_descripcion;
                    item.pr_descripcion_2 = "[" + _sucursal.pr_codigo + "] - " + _sucursal.pr_descripcion;
                    item.pr_peso = _sucursal.pr_peso;
                    item.pr_stock = _sucursal.pr_stock;
                    item.pr_pedidos = _sucursal.pr_pedidos;
                    item.pr_precio_publico = _sucursal.pr_precio_publico;
                    item.pr_precio_minimo = _sucursal.pr_precio_minimo;
                    item.pr_ManejaIva = _sucursal.pr_ManejaIva.Trim() == "S" ? "S" : _sucursal.pr_ManejaIva;
                    item.pr_ManejaSeries = _sucursal.pr_ManejaSeries.Trim() == "S" ? "S" : _sucursal.pr_ManejaSeries;
                    item.IdSucursal = _sucursal.IdSucursal;
                    item.ManejaKardex = _sucursal.ManejaKardex;
                    item.IdUnidadMedida = _sucursal.IdUnidadMedida;
                    item.IdUnidadMedida_Consumo = _sucursal.IdUnidadMedida_Consumo;
                    item.nom_UnidadMedida = _sucursal.Descripcion_UniMedida;
                    item.nom_Tipo_Producto = _sucursal.Descripcion_TipoConsumo;
                    item.IdCod_Impuesto_Iva = _sucursal.IdCod_Impuesto_Iva;
                    item.IdCod_Impuesto_Ice = _sucursal.IdCod_Impuesto_Ice;
                    item.Aparece_modu_Ventas = _sucursal.Aparece_modu_Ventas;
                    item.Aparece_modu_Compras = _sucursal.Aparece_modu_Compras;
                    item.Aparece_modu_Inventario = _sucursal.Aparece_modu_Inventario;
                    item.Aparece_modu_Activo_F = _sucursal.Aparece_modu_Activo_F;

                    lM.Add(item);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_compra(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                lM = (from C in OEInventario.vwin_producto_x_modulo
                      where C.IdEmpresa == IdEmpresa
                      && C.Aparece_modu_Compras == true
                      select new in_Producto_Info
                      {
                          IdEmpresa = C.IdEmpresa,
                          IdProducto = C.IdProducto,
                          pr_codigo = C.pr_codigo.Trim(),
                          pr_descripcion = C.pr_descripcion,
                          pr_descripcion_2 = "[" + C.pr_codigo + "] - " + C.pr_descripcion,
                          precio_minimo = C.pr_precio_minimo,
                          pr_peso = C.pr_peso,
                          pr_stock = C.pr_stock,
                          pr_pedidos = C.pr_pedidos,
                          pr_precio_publico = C.pr_precio_publico,
                          pr_precio_minimo = C.pr_precio_minimo,
                          pr_ManejaIva = C.pr_ManejaIva.Trim() == "S" ? "S" : C.pr_ManejaIva,
                          pr_ManejaSeries = C.pr_ManejaSeries.Trim() == "S" ? "S" : C.pr_ManejaSeries,
                          IdSucursal = C.IdSucursal,
                          ManejaKardex = C.ManejaKardex,
                          IdUnidadMedida = C.IdUnidadMedida,
                          IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                          nom_UnidadMedida = C.Descripcion_UniMedida, //
                          IdProductoTipo = C.IdProductoTipo,
                          nom_Tipo_Producto = C.nom_Tipo_Producto,
                          IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                          IdCod_Impuesto_Ice = C.IdCod_Impuesto_Ice,
                          Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                          Aparece_modu_Compras = C.Aparece_modu_Compras,
                          Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                          Aparece_modu_Activo_F = C.Aparece_modu_Activo_F
                      }).ToList();


                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_compra_lite(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                lM = (from C in OEInventario.vwin_producto_x_modulo_lite
                      where C.IdEmpresa == IdEmpresa
                      && C.Aparece_modu_Compras == true
                      select new in_Producto_Info
                      {
                          IdEmpresa = C.IdEmpresa,
                          IdProducto = C.IdProducto,
                          pr_codigo = C.pr_codigo.Trim(),
                          pr_descripcion = C.pr_descripcion,
                          pr_descripcion_2 = "[" + C.pr_codigo + "] - " + C.pr_descripcion,
                          precio_minimo = C.pr_precio_minimo,
                          pr_peso = C.pr_peso,
                          pr_stock = C.pr_stock,
                          pr_pedidos = C.pr_pedidos,
                          pr_precio_publico = C.pr_precio_publico,
                          pr_precio_minimo = C.pr_precio_minimo,
                          pr_ManejaIva = C.pr_ManejaIva.Trim() == "S" ? "S" : C.pr_ManejaIva,
                          pr_ManejaSeries = C.pr_ManejaSeries.Trim() == "S" ? "S" : C.pr_ManejaSeries,
                          IdSucursal = C.IdSucursal,
                          ManejaKardex = C.ManejaKardex,
                          IdUnidadMedida = C.IdUnidadMedida,
                          IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                          nom_UnidadMedida = C.Descripcion_UniMedida, //
                          IdProductoTipo = C.IdProductoTipo,
                          nom_Tipo_Producto = C.nom_Tipo_Producto,
                          IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                          IdCod_Impuesto_Ice = C.IdCod_Impuesto_Ice,
                          Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                          Aparece_modu_Compras = C.Aparece_modu_Compras,
                          Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                          Aparece_modu_Activo_F = C.Aparece_modu_Activo_F
                      }).ToList();

                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_compra_sin_Stock(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                lM = (from C in OEInventario.vwin_producto_x_modulo_sin_Stock
                      where C.IdEmpresa == IdEmpresa
                      && C.Aparece_modu_Compras == true
                      select new in_Producto_Info
                      {
                          IdEmpresa = C.IdEmpresa,
                          IdProducto = C.IdProducto,
                          pr_codigo = C.pr_codigo.Trim(),
                          pr_descripcion = C.pr_descripcion,
                          pr_descripcion_2 = "[" + C.pr_codigo + "] - " + C.pr_descripcion,
                          precio_minimo = C.pr_precio_minimo,
                          pr_peso = C.pr_peso,
                          pr_precio_publico = C.pr_precio_publico,
                          pr_precio_minimo = C.pr_precio_minimo,
                          pr_ManejaIva = C.pr_ManejaIva.Trim() == "S" ? "S" : C.pr_ManejaIva,
                          pr_ManejaSeries = C.pr_ManejaSeries.Trim() == "S" ? "S" : C.pr_ManejaSeries,
                          IdSucursal = C.IdSucursal,
                          ManejaKardex = C.ManejaKardex,
                          IdUnidadMedida = C.IdUnidadMedida,
                          IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                          nom_UnidadMedida = C.Descripcion_UniMedida, //
                          IdProductoTipo = C.IdProductoTipo,
                          nom_Tipo_Producto = C.nom_Tipo_Producto,
                          IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                          IdCod_Impuesto_Ice = C.IdCod_Impuesto_Ice,
                          Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                          Aparece_modu_Compras = C.Aparece_modu_Compras,
                          Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                          Aparece_modu_Activo_F = C.Aparece_modu_Activo_F
                      }).ToList();

                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_ventas(int IdEmpresa, int IdSucursal)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_sucursal
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        && C.Aparece_modu_Ventas == true
                                        select C;

                foreach (var _sucursal in select_Inventario)
                {
                    in_Producto_Info item = new in_Producto_Info();
                    item.pr_costo_promedio = _sucursal.pr_costo_promedio;
                    item.IdEmpresa = _sucursal.IdEmpresa;
                    item.IdProducto = _sucursal.IdProducto;
                    item.pr_codigo = _sucursal.pr_codigo.Trim();
                    item.pr_descripcion = _sucursal.pr_descripcion;
                    item.pr_descripcion_2 = "[" + _sucursal.pr_codigo + "] - " + _sucursal.pr_descripcion;
                    item.pr_peso = _sucursal.pr_peso;
                    item.pr_stock = _sucursal.pr_stock;
                    item.pr_pedidos = _sucursal.pr_pedidos;
                    item.pr_precio_publico = _sucursal.pr_precio_publico;
                    item.pr_precio_minimo = _sucursal.pr_precio_minimo;
                    item.pr_ManejaIva = _sucursal.pr_ManejaIva.Trim() == "S" ? "S" : _sucursal.pr_ManejaIva;
                    item.pr_ManejaSeries = _sucursal.pr_ManejaSeries.Trim() == "S" ? "S" : _sucursal.pr_ManejaSeries;
                    item.IdSucursal = _sucursal.IdSucursal;
                    item.ManejaKardex = _sucursal.ManejaKardex;
                    item.IdUnidadMedida = _sucursal.IdUnidadMedida;
                    item.IdUnidadMedida_Consumo = _sucursal.IdUnidadMedida_Consumo;
                    item.nom_UnidadMedida = _sucursal.Descripcion_UniMedida;
                    item.nom_Tipo_Producto = _sucursal.Descripcion_TipoConsumo;
                    item.IdCod_Impuesto_Iva = _sucursal.IdCod_Impuesto_Iva;
                    item.IdCod_Impuesto_Ice = _sucursal.IdCod_Impuesto_Ice;
                    item.Aparece_modu_Ventas = _sucursal.Aparece_modu_Ventas;
                    item.Aparece_modu_Compras = _sucursal.Aparece_modu_Compras;
                    item.Aparece_modu_Inventario = _sucursal.Aparece_modu_Inventario;
                    item.Aparece_modu_Activo_F = _sucursal.Aparece_modu_Activo_F;

                    lM.Add(item);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_ventas(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdSucursal == IdSucursal
                                        && C.IdBodega == IdBodega
                                        && C.Aparece_modu_Ventas == true
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdProductoTipo = item.IdProductoTipo;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;

                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                    //info.IdEstadoAprobacion = item.IdEstadoAprobacion;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;


                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;


                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_inventario(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                OEInventario.SetCommandTimeOut(60000);

                var query = from C in OEInventario.vwin_producto_x_tb_bodega
                            join P in OEInventario.in_Producto on new { C.IdEmpresa, C.IdProducto } equals new { P.IdEmpresa, P.IdProducto }
                            where C.IdEmpresa == IdEmpresa
                            && C.IdSucursal == IdSucursal
                            && IdBodega_ini <= C.IdBodega && C.IdBodega <= IdBodega_fin
                            && C.Aparece_modu_Inventario == true
                            orderby C.IdEmpresa, C.IdProducto
                            select new in_Producto_Info
                            {
                                pr_costo_promedio = C.pr_costo_promedio,
                                IdEmpresa = C.IdEmpresa,
                                IdSucursal = C.IdSucursal,
                                IdProducto = C.IdProducto,
                                IdBodega = C.IdBodega,
                                pr_codigo = C.pr_codigo,
                                pr_descripcion = C.pr_descripcion,
                                pr_peso = C.pr_peso,
                                PesoEspecifico = C.PesoEspecifico,
                                pr_stock = C.pr_stock,
                                pr_precio_publico = C.pr_precio_publico,
                                pr_Pedidos_inv = C.pr_Pedidos_inv,
                                pr_disponible = C.pr_Disponible,
                                pr_Disponible = C.pr_Disponible,
                                pr_Pedidos_fact = C.pr_Pedidos_fact,
                                pr_precio_minimo = C.pr_precio_minimo,
                                pr_precio_mayor = C.pr_precio_mayor,
                                pr_stock_minimo = C.pr_stock_minimo,
                                pr_ManejaIva = C.pr_ManejaIva,
                                pr_ManejaSeries = C.pr_ManejaSeries,
                                ManejaKardex = C.ManejaKardex,
                                IdUnidadMedida = C.IdUnidadMedida,
                                IdCategoria = P.IdCategoria,
                                IdLinea = P.IdLinea,
                                IdGrupo = P.IdGrupo,
                                IdSubGrupo = P.IdSubGrupo,
                                nom_Categoria = C.nom_Categoria,
                                nom_Linea = C.nom_linea,
                                IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                                nom_UnidadMedida = C.Descripcion_UniMedida,
                                nom_UnidadMedida_Consumo = C.Descripcion_TipoConsumo,
                                IdCtaCble_Inventario = C.IdCtaCble_Inventario,
                                IdCtaCble_Costo = C.IdCtaCble_Costo,
                                IdCtaCble_Vta = C.IdCtaCble_Vta,
                                IdCtaCble_Ven0 = C.IdCtaCble_Ven0,
                                IdCtaCble_VenIva = C.IdCtaCble_VenIva,
                                IdCtaCble_CosBase0 = C.IdCtaCble_CosBase0,
                                IdCtaCble_CosBaseIva = C.IdCtaCble_CosBaseIva,
                                IdCtaCble_Des0 = C.IdCtaCble_Des0,
                                IdCtaCble_DesIva = C.IdCtaCble_DesIva,
                                IdCtaCble_Dev0 = C.IdCtaCble_Dev0,
                                IdCtaCble_DevIva = C.IdCtaCble_DevIva,
                                IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                                IdCod_Impuesto_Ice = C.IdCod_Impuesto_Ice,
                                Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                                Aparece_modu_Compras = C.Aparece_modu_Compras,
                                Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                                Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,
                                pr_codigo_barra = C.pr_codigo_barra,
                                IdCentroCosto = C.IdCentro_Costo_Costo,
                            };

                lM = query.ToList();

                foreach (var item in lM)
                {
                    item.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;
                    item.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    item.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                }

                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_inventario_Lote(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                OEInventario.SetCommandTimeOut(60000);

                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega_Lote
                                        where C.IdEmpresa == IdEmpresa
                                        && C.IdSucursal == IdSucursal
                                        && IdBodega_ini <= C.IdBodega && C.IdBodega <= IdBodega_fin
                                        && C.Aparece_modu_Inventario == true
                                        //&& C.pr_stock > 0
                                        orderby C.IdEmpresa, C.IdProducto
                                        //orderby C.IdEmpresa,C.IdSucursal,C.IdBodega,C.nom_Categoria,C.nom_linea,C.IdProducto
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;

                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.PesoEspecifico = item.PesoEspecifico;
                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_disponible = item.pr_Disponible;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    //info.IdCategoria = item.IdCategoria;
                    //info.IdLinea = item.IdLinea;
                    //info.IdGrupo = item.IdGrupo;
                    //info.IdSubGrupo = item.IdSubGrupo;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Categoria = item.nom_Categoria;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_UnidadMedida_Consumo = item.Descripcion_TipoConsumo;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;


                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.pr_codigo_barra = item.pr_codigo_barra;
                    info.IdCentroCosto = item.IdCentro_Costo_Costo;

                    info.Lote = item.Lote;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto_modulo_x_inventario_lite(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                OEInventario.SetCommandTimeOut(60000);

                var query = from C in OEInventario.vwin_producto_x_tb_bodega_sin_Stock
                            join P in OEInventario.in_Producto on new { C.IdEmpresa, C.IdProducto } equals new { P.IdEmpresa, P.IdProducto }
                            where C.IdEmpresa == IdEmpresa
                            && C.IdSucursal == IdSucursal
                            && C.IdBodega == IdBodega
                            && C.Aparece_modu_Inventario == true
                            orderby C.IdEmpresa, C.IdProducto
                            select new in_Producto_Info
                            {
                                pr_costo_promedio = C.pr_costo_promedio,
                                IdEmpresa = C.IdEmpresa,
                                IdSucursal = C.IdSucursal,
                                IdProducto = C.IdProducto,
                                IdBodega = C.IdBodega,
                                pr_codigo = C.pr_codigo,
                                pr_descripcion = C.pr_descripcion,
                                pr_peso = C.pr_peso,
                                PesoEspecifico = C.PesoEspecifico,
                                pr_precio_publico = C.pr_precio_publico,
                                pr_precio_minimo = C.pr_precio_minimo,
                                pr_precio_mayor = C.pr_precio_mayor,
                                pr_stock_minimo = C.pr_stock_minimo,
                                pr_ManejaIva = C.pr_ManejaIva,
                                pr_ManejaSeries = C.pr_ManejaSeries,
                                ManejaKardex = C.ManejaKardex,
                                IdUnidadMedida = C.IdUnidadMedida,
                                IdCategoria = P.IdCategoria,
                                IdLinea = P.IdLinea,
                                IdGrupo = P.IdGrupo,
                                IdSubGrupo = P.IdSubGrupo,
                                nom_Categoria = C.nom_Categoria,
                                nom_Linea = C.nom_linea,
                                IdUnidadMedida_Consumo = C.IdUnidadMedida_Consumo,
                                nom_UnidadMedida = C.Descripcion_UniMedida,
                                nom_UnidadMedida_Consumo = C.Descripcion_TipoConsumo,
                                IdCtaCble_Inventario = C.IdCtaCble_Inventario,
                                IdCtaCble_Costo = C.IdCtaCble_Costo,
                                IdCtaCble_Vta = C.IdCtaCble_Vta,
                                IdCtaCble_Ven0 = C.IdCtaCble_Ven0,
                                IdCtaCble_VenIva = C.IdCtaCble_VenIva,
                                IdCtaCble_CosBase0 = C.IdCtaCble_CosBase0,
                                IdCtaCble_CosBaseIva = C.IdCtaCble_CosBaseIva,
                                IdCtaCble_Des0 = C.IdCtaCble_Des0,
                                IdCtaCble_DesIva = C.IdCtaCble_DesIva,
                                IdCtaCble_Dev0 = C.IdCtaCble_Dev0,
                                IdCtaCble_DevIva = C.IdCtaCble_DevIva,
                                IdCod_Impuesto_Iva = C.IdCod_Impuesto_Iva,
                                IdCod_Impuesto_Ice = C.IdCod_Impuesto_Ice,
                                Aparece_modu_Ventas = C.Aparece_modu_Ventas,
                                Aparece_modu_Compras = C.Aparece_modu_Compras,
                                Aparece_modu_Inventario = C.Aparece_modu_Inventario,
                                Aparece_modu_Activo_F = C.Aparece_modu_Activo_F,
                                pr_codigo_barra = C.pr_codigo_barra,
                                IdCentroCosto = C.IdCentro_Costo_Costo,
                            };

                lM = query.ToList();

                foreach (var item in lM)
                {                    
                    item.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;                                                            
                    item.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    item.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;                    
                }

                return lM;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_Producto_modulo_x_inventario(int IdEmpresa, int IdSucursal, int IdBodega, string codigo_barra)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                in_Producto_Info Info = new in_Producto_Info();
                EntitiesInventario OEInventario = new EntitiesInventario();

                OEInventario.SetCommandTimeOut(60000);

                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa
                                        && C.IdSucursal == IdSucursal
                                        && IdBodega_ini <= C.IdBodega && C.IdBodega <= IdBodega_fin
                                        && C.Aparece_modu_Inventario == true
                                        && C.pr_codigo_barra == codigo_barra
                                        select C;

                if (select_Inventario.Count() > 0)
                {
                    foreach (var item in select_Inventario)
                    {
                        Info.pr_costo_promedio = item.pr_costo_promedio;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdProducto = item.IdProducto;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdBodega = item.IdBodega;
                        Info.pr_codigo = item.pr_codigo.Trim();
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;
                        Info.pr_peso = item.pr_peso;
                        Info.PesoEspecifico = item.PesoEspecifico;
                        Info.pr_stock = item.pr_stock;
                        Info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                        Info.pr_disponible = item.pr_Disponible;
                        Info.pr_Disponible = item.pr_Disponible;
                        Info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                        Info.pr_precio_publico = item.pr_precio_publico;
                        Info.pr_precio_minimo = item.pr_precio_minimo;
                        Info.pr_precio_mayor = item.pr_precio_mayor;
                        Info.pr_stock_minimo = item.pr_stock_minimo;
                        Info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                        Info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                        Info.IdSucursal = item.IdSucursal;
                        Info.ManejaKardex = item.ManejaKardex;
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.nom_Linea = item.nom_linea;
                        Info.nom_Categoria = item.nom_Categoria;
                        Info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                        Info.nom_UnidadMedida = item.Descripcion_UniMedida;
                        Info.nom_UnidadMedida_Consumo = item.Descripcion_TipoConsumo;
                        Info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                        Info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                        Info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                        Info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                        Info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                        Info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                        Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                        Info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                        Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                        Info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                        Info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        Info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                        Info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        Info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        Info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        Info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                        Info.pr_codigo_barra = item.pr_codigo_barra;
                        Info.IdCentroCosto = item.IdCentro_Costo_Costo;
                    }
                }
                else
                {
                    return null;
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_Producto_modulo_x_inventario_sin_Stock(int IdEmpresa, int IdSucursal, int IdBodega, string codigo_barra)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                in_Producto_Info Info = new in_Producto_Info();
                EntitiesInventario OEInventario = new EntitiesInventario();

                OEInventario.SetCommandTimeOut(60000);

                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega_sin_Stock
                                        where C.IdEmpresa == IdEmpresa
                                        && C.IdSucursal == IdSucursal
                                        && IdBodega_ini <= C.IdBodega && C.IdBodega <= IdBodega_fin
                                        && C.Aparece_modu_Inventario == true
                                        && C.pr_codigo_barra == codigo_barra
                                        select C;

                if (select_Inventario.Count() > 0)
                {
                    foreach (var item in select_Inventario)
                    {
                        Info.pr_costo_promedio = item.pr_costo_promedio;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdProducto = item.IdProducto;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdBodega = item.IdBodega;
                        Info.pr_codigo = item.pr_codigo.Trim();
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;
                        Info.pr_peso = item.pr_peso;
                        Info.PesoEspecifico = item.PesoEspecifico;
                        //Info.pr_stock = item.pr_stock;
                        //Info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                        //Info.pr_disponible = item.pr_Disponible;
                        //Info.pr_Disponible = item.pr_Disponible;
                        //Info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                        Info.pr_precio_publico = item.pr_precio_publico;
                        Info.pr_precio_minimo = item.pr_precio_minimo;
                        Info.pr_precio_mayor = item.pr_precio_mayor;
                        Info.pr_stock_minimo = item.pr_stock_minimo;
                        Info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                        Info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                        Info.IdSucursal = item.IdSucursal;
                        Info.ManejaKardex = item.ManejaKardex;
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.nom_Linea = item.nom_linea;
                        Info.nom_Categoria = item.nom_Categoria;
                        Info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                        Info.nom_UnidadMedida = item.Descripcion_UniMedida;
                        Info.nom_UnidadMedida_Consumo = item.Descripcion_TipoConsumo;
                        Info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                        Info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                        Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                        Info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                        Info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                        Info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                        Info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                        Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                        Info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                        Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                        Info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                        Info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        Info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                        Info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        Info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        Info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        Info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                        Info.pr_codigo_barra = item.pr_codigo_barra;
                        Info.IdCentroCosto = item.IdCentro_Costo_Costo;
                        Info.IdProductoTipo = item.IdProductoTipo;
                    }
                }
                else
                {
                    return null;
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> get_listaProducto_X_Bodega(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;



                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                OEInventario.SetCommandTimeOut(60000);

                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa
                                        && C.IdSucursal == IdSucursal
                                              // && IdBodega_ini <= C.IdBodega && C.IdBodega <= IdBodega_fin
                                              && C.IdBodega == IdBodega
                                        && C.Aparece_modu_Inventario == true
                                        orderby C.IdEmpresa, C.IdProducto
                                        //orderby C.IdEmpresa,C.IdSucursal,C.IdBodega,C.nom_Categoria,C.nom_linea,C.IdProducto
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;

                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_disponible = item.pr_Disponible;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Categoria = item.nom_Categoria;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_UnidadMedida_Consumo = item.Descripcion_TipoConsumo;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;


                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.pr_codigo_barra = item.pr_codigo_barra;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Producto(int IdEmpresa, int IdSucursal, int IdBodega, List<in_Producto_Info> listProducto)
        {
            try
            {
                var QIdProductosAfind = from P in listProducto
                                        select P.IdProducto;

                List<in_Producto_Info> lM = new List<in_Producto_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa && C.IdBodega == IdBodega && C.IdSucursal == IdSucursal
                                        && QIdProductosAfind.Contains(C.IdProducto)
                                        select C;

                foreach (var item in select_Inventario)
                {
                    in_Producto_Info info = new in_Producto_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.IdBodega = item.IdBodega;
                    info.nom_Bodega = item.bo_Descripcion.Trim();
                    info.pr_peso = item.pr_peso;

                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_Disponible = item.pr_Disponible;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.ManejaKardex = item.ManejaKardex;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;


                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;


                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(in_Producto_Info prI, ref decimal IdProducto, ref string mensaje)
        {
            try
            {
                try
                {
                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        EntitiesInventario EDB = new EntitiesInventario();

                        if (prI.pr_codigo != "")
                        {
                            var existe = (from per in EDB.in_Producto
                                          where per.IdEmpresa == prI.IdEmpresa
                                          && per.pr_codigo == prI.pr_codigo
                                          && per.Estado == "A"
                                          select per).ToList().Count();
                            if (existe != 0)
                            {
                                mensaje = "El Código ingresado ya existe por favor ingresar uno distinto";
                                return false;
                            }
                        }

                        var Q = from per in EDB.in_Producto
                                where per.IdEmpresa == prI.IdEmpresa
                                && per.IdProducto == prI.IdProducto
                                select per;
                        var cantidad = Q.ToList().Count;
                        if (Q.ToList().Count == 0)
                        {
                            var address = new in_Producto();

                            address.IdEmpresa = prI.IdEmpresa;
                            IdProducto = GetIdProducto(prI.IdEmpresa);
                            prI.IdProducto = IdProducto;
                            address.IdProducto = IdProducto;

                            if (string.IsNullOrWhiteSpace(prI.pr_codigo))
                            {
                                address.pr_codigo = prI.pr_codigo = Convert.ToString(IdProducto);
                            }
                            else
                            {
                                address.pr_codigo = prI.pr_codigo.Trim();
                            }

                            address.pr_descripcion = prI.pr_descripcion.Trim();
                            address.pr_descripcion_2 = (prI.pr_descripcion_2 == null) ? "" : prI.pr_descripcion_2;
                            address.IdProductoTipo = prI.IdProductoTipo;
                            address.IdMarca = prI.IdMarca;
                            address.IdPresentacion = Convert.ToString(prI.IdPresentacion);
                            address.IdCategoria = prI.IdCategoria;
                            address.IdLinea = prI.IdLinea;
                            address.IdGrupo = prI.IdGrupo;
                            address.IdSubGrupo = prI.IdSubGrupo;
                            address.IdUnidadMedida = prI.IdUnidadMedida;
                            address.IdUnidadMedida_Consumo = prI.IdUnidadMedida_Consumo;
                            //Naturaleza
                            address.IdMotivo_Vta = prI.IdMotivo_Vta;
                            address.pr_codigo_barra = (string.IsNullOrEmpty(prI.pr_codigo_barra)) ? address.pr_codigo : prI.pr_codigo_barra;//27
                            address.pr_observacion = prI.pr_observacion == null ? "" : prI.pr_observacion;//39
                            address.pr_precio_mayor = prI.pr_precio_mayor;//44
                            address.pr_precio_minimo = prI.pr_precio_minimo == null ? 0 : (double)prI.pr_precio_minimo;//45
                            address.pr_precio_publico = prI.pr_precio_publico == null ? 0 : (double)prI.pr_precio_publico;//46
                            address.pr_precio_puerta = prI.pr_precio_puerta == null ? 0 : prI.pr_precio_puerta;//59
                            address.pr_ManejaIva = prI.pr_ManejaIva == null ? "N" : prI.pr_ManejaIva;//37
                            address.pr_ManejaSeries = prI.pr_ManejaSeries == null ? "N" : prI.pr_ManejaSeries;//38

                            address.pr_costo_CIF = prI.pr_costo_CIF;//28
                            address.pr_costo_fob = prI.pr_costo_fob;//29
                            address.pr_costo_promedio = prI.pr_costo_promedio == null ? 0 : (double)prI.pr_costo_promedio;//30

                            address.pr_DiasAereo = prI.pr_DiasAereo;//32
                            address.pr_DiasMaritimo = prI.pr_DiasMaritimo;//33
                            address.pr_DiasTerrestre = prI.pr_DiasTerrestre;//34
                            address.pr_largo = prI.pr_largo;//36                        
                            address.pr_alto = prI.pr_alto;
                            address.pr_profundidad = prI.pr_profundidad;
                            address.pr_peso = prI.pr_peso == null ? 0 : (double)prI.pr_peso;//42
                            address.pr_imagen_Grande = prI.pr_imagen_Grande;//10
                            address.pr_imagenPeque = prI.pr_imagenPeque;//11
                            address.pr_partidaArancel = prI.pr_partidaArancel == null ? "" : prI.pr_partidaArancel;//40
                            address.pr_porcentajeArancel = prI.pr_porcentajeArancel;//43
                            address.pr_Por_descuento = prI.pr_Por_descuento == null ? 0 : prI.pr_Por_descuento;//60
                            address.pr_stock_maximo = prI.pr_stock_maximo;//49
                            address.pr_stock_minimo = prI.pr_stock_minimo;//50
                            address.IdUsuario = (prI.IdUsuario == null) ? "" : prI.IdUsuario.Trim();//20
                            address.Fecha_Transac = DateTime.Now;//5
                            address.IdUsuarioUltMod = (prI.IdUsuarioUltMod == null) ? "" : prI.IdUsuarioUltMod.Trim();//22
                            address.Fecha_UltMod = DateTime.Now;//7

                            //address.IdUsuarioUltAnu = (prI.IdUsuarioUltAnu == null) ? "" : prI.IdUsuarioUltAnu.Trim();//21
                            //address.Fecha_UltAnu = DateTime.Now;//6
                            //pr_motivoAnulacion

                            address.ip = (prI.ip == null) ? "" : prI.ip;//23
                            address.nom_pc = (prI.nom_pc == null) ? "" : prI.nom_pc;//24
                            address.Estado = prI.Estado;//4
                            address.PesoEspecifico = prI.PesoEspecifico;//2
                            address.AnchoEspecifico = prI.AnchoEspecifico;//3
                            address.ManejaKardex = (prI.ManejaKardex == null) ? "N" : "S";//56
                            address.ManejaLote = (prI.ManejaLote == null) ? "N" : "S";

                            address.IdCod_Impuesto_Iva = (prI.IdCod_Impuesto_Iva == null) ? "IVA0" : prI.IdCod_Impuesto_Iva;
                            address.IdCod_Impuesto_Ice = (prI.IdCod_Impuesto_Ice == null) ? "ICE0" : prI.IdCod_Impuesto_Ice;


                            address.Aparece_modu_Ventas = prI.Aparece_modu_Ventas;
                            address.Aparece_modu_Compras = prI.Aparece_modu_Compras;
                            address.Aparece_modu_Inventario = prI.Aparece_modu_Inventario;
                            address.Aparece_modu_Activo_F = prI.Aparece_modu_Activo_F;

                            context.in_Producto.Add(address);
                            context.SaveChanges();

                            mensaje = "Grabacion ok..";

                        }
                        else
                            return false;
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        public Boolean ValidarNombreItem(int IdEmpresa, string NombreItem)
        {
            try
            {
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = (from q in listado.in_Producto
                                  where q.IdEmpresa == IdEmpresa
                                  && q.pr_descripcion.Trim() == NombreItem.Trim()
                                  select q).Count();

                    if (select == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarNombreItem_x_TipoProducto(int IdEmpresa, string NombreItem, int IdTipoProducto)
        {
            try
            {
                using (EntitiesInventario listado = new EntitiesInventario())
                {
                    var select = (from q in listado.in_Producto
                                  where q.IdEmpresa == IdEmpresa
                                  && q.pr_descripcion.Trim() == NombreItem.Trim()
                                  && q.IdProductoTipo == IdTipoProducto
                                  select q).Count();

                    if (select == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string strMensaje = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                strMensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref strMensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<fa_pedido_det_Info> lm, ref string mensaje)
        {
            try
            {
                //foreach (var item in lm)
                //{
                //    using (EntitiesInventario context = new EntitiesInventario())
                //    {
                //        var contact = context.in_Producto.FirstOrDefault(obj => obj.IdEmpresa == item.IdEmpresa && obj.IdProducto == item.IdProducto);
                //        if (contact != null)
                //        {
                //            //contact.pr_pedidos += item.dp_cantidad;
                //            context.SaveChanges();
                //            context.Dispose();
                //        }
                //    }
                //}
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(in_Producto_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdProducto == prI.IdProducto);

                    if (contact != null)
                    {
                        contact.pr_descripcion_2 = prI.pr_descripcion_2;//1
                        contact.PesoEspecifico = prI.PesoEspecifico;//2
                        contact.AnchoEspecifico = prI.AnchoEspecifico;//3
                        contact.Estado = prI.Estado;//4
                        contact.Fecha_UltMod = DateTime.Now;//7
                        contact.IdCategoria = prI.IdCategoria;//8
                        contact.pr_descripcion = prI.pr_descripcion;//9
                        contact.pr_imagen_Grande = prI.pr_imagen_Grande;//10
                        contact.pr_imagenPeque = prI.pr_imagenPeque;//11
                        contact.IdUnidadMedida_Consumo = prI.IdUnidadMedida_Consumo;//12
                        contact.IdEmpresa = prI.IdEmpresa;//13
                        contact.IdMarca = prI.IdMarca;//14
                        contact.IdPresentacion = Convert.ToString(prI.IdPresentacion);//15
                        contact.IdProductoTipo = prI.IdProductoTipo;//18
                        contact.IdUnidadMedida = prI.IdUnidadMedida;//19
                        contact.IdUsuarioUltMod = (prI.IdUsuarioUltMod == null) ? "" : prI.IdUsuarioUltMod.Trim();//22
                        contact.pr_alto = prI.pr_alto;//25
                        contact.pr_codigo = (prI.pr_codigo == null) ? Convert.ToString(contact.IdProducto) : prI.pr_codigo;//26
                        contact.pr_codigo_barra = prI.pr_codigo_barra == null ? "" : prI.pr_codigo_barra;//27
                        contact.pr_costo_CIF = prI.pr_costo_CIF;//28
                        contact.pr_costo_fob = prI.pr_costo_fob;//29
                        contact.pr_costo_promedio = prI.pr_costo_promedio == null ? 0 : (double)prI.pr_costo_promedio;//30
                        contact.pr_descripcion = prI.pr_descripcion;//31
                        contact.pr_DiasAereo = prI.pr_DiasAereo;//32
                        contact.pr_DiasMaritimo = prI.pr_DiasMaritimo;//33
                        contact.pr_DiasTerrestre = prI.pr_DiasTerrestre;//34
                        contact.pr_largo = prI.pr_largo;//36                        
                        contact.pr_ManejaIva = prI.pr_ManejaIva == null ? "N" : prI.pr_ManejaIva;//37
                        contact.pr_ManejaSeries = prI.pr_ManejaSeries == null ? "N" : prI.pr_ManejaSeries;//38
                        contact.pr_observacion = prI.pr_observacion == null ? "" : prI.pr_observacion;//39
                        contact.pr_partidaArancel = prI.pr_partidaArancel == null ? "" : prI.pr_partidaArancel;//40
                        contact.pr_peso = prI.pr_peso == null ? 0 : (double)prI.pr_peso;//42
                        contact.pr_porcentajeArancel = prI.pr_porcentajeArancel;//43
                        contact.pr_precio_mayor = prI.pr_precio_mayor;//44
                        contact.pr_precio_minimo = prI.pr_precio_minimo == null ? 0 : (double)prI.pr_precio_minimo;//45
                        contact.pr_precio_publico = prI.pr_precio_publico == null ? 0 : (double)prI.pr_precio_publico;//46
                        contact.pr_profundidad = prI.pr_profundidad;//47
                        contact.pr_stock_maximo = prI.pr_stock_maximo;//49
                        contact.pr_stock_minimo = prI.pr_stock_minimo;//50
                        contact.IdLinea = prI.IdLinea;//53
                        contact.IdGrupo = prI.IdGrupo;//54
                        contact.IdSubGrupo = prI.IdSubGrupo;//55
                        contact.ManejaKardex = (prI.ManejaKardex == null) ? "N" : "S";//56
                        contact.ManejaLote = (prI.ManejaLote == null) ? "N" : "S";
                        contact.IdMotivo_Vta = prI.IdMotivo_Vta;//58
                        contact.pr_precio_puerta = prI.pr_precio_puerta == null ? 0 : prI.pr_precio_puerta;//59
                        contact.pr_Por_descuento = prI.pr_Por_descuento == null ? 0 : prI.pr_Por_descuento;//60
                        contact.IdCod_Impuesto_Iva = prI.IdCod_Impuesto_Iva;
                        contact.IdCod_Impuesto_Ice = prI.IdCod_Impuesto_Ice;
                        contact.Aparece_modu_Ventas = prI.Aparece_modu_Ventas;
                        contact.Aparece_modu_Compras = prI.Aparece_modu_Compras;
                        contact.Aparece_modu_Inventario = prI.Aparece_modu_Inventario;
                        contact.Aparece_modu_Activo_F = prI.Aparece_modu_Activo_F;
                        contact.Fecha_UltMod = DateTime.Now;

                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
                    }
                }

                return true;
            }
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Precios(in_Producto_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdProducto == prI.IdProducto);
                    if (contact != null)
                    {
                        contact.pr_precio_mayor = prI.pr_precio_mayor == null ? 0 : (double)prI.pr_precio_mayor;//44
                        contact.pr_precio_minimo = prI.pr_precio_minimo == null ? 0 : (double)prI.pr_precio_minimo;//45
                        contact.pr_precio_publico = prI.pr_precio_publico == null ? 0 : (double)prI.pr_precio_publico;//46                      
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltMod = prI.IdUsuarioUltMod;

                        context.SaveChanges();
                        mensaje = "Grabacion ok...";
                    }
                }
                return true;
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

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }

        }

        public decimal GetIdProducto(int IdEmpresa)
        {
            try
            {
                decimal IdcbteCble;
                EntitiesInventario OECbtecble = new EntitiesInventario();
                var q = from A in OECbtecble.in_Producto
                        where A.IdEmpresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OECbtecble = new EntitiesInventario();
                    var selectCbtecble = (from CbtCble in OECbtecble.in_Producto
                                          where CbtCble.IdEmpresa == IdEmpresa
                                          select CbtCble.IdProducto).Max();

                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdcbteCble;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetIdProducto_x_Categoria(int IdEmpresa, string IdCategoria)
        {
            try
            {
                decimal IdcbteCble;
                EntitiesInventario OEPrd = new EntitiesInventario();
                var q = from A in OEPrd.in_Producto
                        where A.IdEmpresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    IdcbteCble = 1;
                }
                else
                {
                    OEPrd = new EntitiesInventario();
                    var selectCbtecble = (from PrdxCat in OEPrd.in_Producto
                                          where PrdxCat.IdEmpresa == IdEmpresa && PrdxCat.IdCategoria == IdCategoria
                                          select PrdxCat.IdProducto).Max();

                    IdcbteCble = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return IdcbteCble;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string GetCodProducto_x_Categoria(int IdEmpresa, string IdCategoria)
        {
            try
            {
                string CodPrdxCat;
                decimal iIdProducto_x_Categoria;

                EntitiesInventario OEPrd = new EntitiesInventario();
                var q = from A in OEPrd.in_Producto
                        where A.IdEmpresa == IdEmpresa && A.IdCategoria == IdCategoria
                        select A;

                if (q.ToList().Count < 1)
                {
                    CodPrdxCat = "1";
                }
                else
                {

                    iIdProducto_x_Categoria = this.GetIdProducto_x_Categoria(IdEmpresa, IdCategoria) - 1;

                    OEPrd = new EntitiesInventario();
                    var selectPrdxCat = (from PrdxCat in OEPrd.in_Producto
                                         where PrdxCat.IdEmpresa == IdEmpresa && PrdxCat.IdProducto == iIdProducto_x_Categoria
                                         select PrdxCat.pr_codigo).ToArray();

                    CodPrdxCat = selectPrdxCat[0];
                }
                return CodPrdxCat;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(in_Producto_Info ProductoInfo, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(prod1 => prod1.IdEmpresa == ProductoInfo.IdEmpresa && prod1.IdProducto == ProductoInfo.IdProducto);
                    if (contact != null)
                    {
                        //no elimino el registro solo cambia el estado de activo a inactivo

                        contact.Estado = "I"; //cambio el estado de activo por inactivo
                        contact.pr_observacion = " ***ANULADO***" + contact.pr_observacion;
                        contact.IdUsuarioUltAnu = ProductoInfo.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.IdUsuarioUltMod = ProductoInfo.IdUsuarioUltMod;
                        contact.pr_motivoAnulacion = ProductoInfo.pr_motivoAnulacion;
                        context.SaveChanges();

                        mensaje = "Anulacion Exitosa..";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Anular:  " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_Info_BuscarProducto(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Producto
                                     where C.IdEmpresa == IdEmpresa && C.IdProducto == IdProducto
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.Estado = item.Estado.Trim();
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.Fecha_UltMod = item.Fecha_UltMod;
                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.AnchoEspecifico;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;


                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;

                    prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                    prd.IdUsuario = item.IdUsuario.Trim();
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.ip = item.ip.Trim();
                    prd.nom_pc = item.nom_pc.Trim();
                    prd.pr_alto = item.pr_alto;
                    prd.pr_codigo = item.pr_codigo.Trim();
                    prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_descripcion = item.pr_descripcion.Trim();
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    prd.pr_largo = item.pr_largo;
                    prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                    prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                    prd.pr_observacion = item.pr_observacion.Trim();
                    prd.pr_partidaArancel = item.pr_partidaArancel;

                    prd.pr_peso = item.pr_peso;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_profundidad = item.pr_profundidad;

                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.ManejaKardex = item.ManejaKardex;
                    prd.ManejaLote = item.ManejaLote;

                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                }
                return (prd);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_info_Producto(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.in_Producto
                                     where C.IdEmpresa == IdEmpresa && C.IdProducto == IdProducto
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdProducto = item.IdProducto;
                    prd.pr_codigo = item.pr_codigo;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.pr_descripcion_2 = item.pr_descripcion_2;
                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.IdMarca = item.IdMarca;
                    prd.IdPresentacion = item.IdPresentacion;
                    prd.IdCategoria = item.IdCategoria.Trim();
                    prd.IdLinea = Convert.ToInt32(item.IdLinea);
                    prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);
                    prd.IdUnidadMedida = item.IdUnidadMedida;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.IdMotivo_Vta = Convert.ToInt16(item.IdMotivo_Vta);
                    prd.pr_codigo_barra = item.pr_codigo_barra;
                    prd.pr_observacion = item.pr_observacion;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_precio_mayor = item.pr_precio_mayor;
                    prd.pr_precio_minimo = item.pr_precio_minimo;
                    prd.pr_precio_puerta = item.pr_precio_puerta;
                    prd.pr_ManejaIva = item.pr_ManejaIva;
                    prd.pr_ManejaSeries = item.pr_ManejaSeries;
                    prd.pr_costo_fob = item.pr_costo_fob;
                    prd.pr_costo_CIF = item.pr_costo_CIF;
                    prd.pr_costo_promedio = item.pr_costo_promedio;
                    prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    prd.pr_DiasAereo = item.pr_DiasAereo;
                    prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    prd.pr_largo = item.pr_largo;
                    prd.pr_alto = item.pr_alto;
                    prd.pr_profundidad = item.pr_profundidad;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_imagenPeque = item.pr_imagenPeque;
                    prd.pr_imagen_Grande = item.pr_imagen_Grande;
                    prd.pr_partidaArancel = item.pr_partidaArancel;
                    prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    prd.pr_Por_descuento = item.pr_Por_descuento;
                    prd.pr_stock_maximo = item.pr_stock_maximo;
                    prd.pr_stock_minimo = item.pr_stock_minimo;
                    prd.IdUsuario = item.IdUsuario;
                    prd.Fecha_Transac = item.Fecha_Transac;
                    prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    prd.Fecha_UltMod = item.Fecha_UltMod;
                    prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    prd.Fecha_UltAnu = item.Fecha_UltAnu;
                    prd.pr_motivoAnulacion = item.pr_motivoAnulacion;
                    prd.nom_pc = item.nom_pc;
                    prd.ip = item.ip;
                    prd.Estado = item.Estado.Trim();
                    prd.AnchoEspecifico = item.AnchoEspecifico;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.ManejaKardex = item.ManejaKardex;
                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                }
                return (prd);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_Info_Producto_x_Bodega(int IdEmpresa, int IdBodega, decimal IdProducto)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_producto_x_tb_bodega
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdBodega == IdBodega
                                     && C.IdProducto == IdProducto
                                     select C;

                foreach (var item in selectCbtecble)
                {

                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.IdUnidadMedida = item.IdUnidadMedida;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_codigo = item.pr_codigo;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.PesoEspecifico;
                    prd.ManejaKardex = item.ManejaKardex;
                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    prd.IdCentroCosto = item.IdCentro_Costo_Costo;
                }
                return (prd);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_Info_Producto_x_Bodega(int IdEmpresa, int IdBodega, string codigo_barra)
        {
            try
            {
                in_Producto_Info prd = new in_Producto_Info();
                EntitiesInventario OECbtecble_Info = new EntitiesInventario();
                var selectCbtecble = from C in OECbtecble_Info.vwin_producto_x_tb_bodega
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdBodega == IdBodega
                                     && C.pr_codigo_barra == codigo_barra
                                     select C;

                foreach (var item in selectCbtecble)
                {

                    prd.IdEmpresa = item.IdEmpresa;
                    prd.IdProducto = item.IdProducto;
                    prd.IdProductoTipo = item.IdProductoTipo;
                    prd.CodBarra = item.pr_codigo_barra;
                    prd.pr_peso = item.pr_peso;
                    prd.pr_descripcion = item.pr_descripcion;
                    prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    prd.IdUnidadMedida = item.IdUnidadMedida;
                    prd.pr_precio_publico = item.pr_precio_publico;
                    prd.pr_codigo = item.pr_codigo;
                    prd.PesoEspecifico = item.PesoEspecifico;
                    prd.AnchoEspecifico = item.PesoEspecifico;
                    prd.ManejaKardex = item.ManejaKardex;
                    prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    prd.IdCentroCosto = item.IdCentro_Costo_Costo;
                }
                return (prd);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_MateriaPrima(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {

                    string Query = "select * from in_producto where IdEmpresa =" + IdEmpresa + " and IdProductoTipo =" +
                                                "(select IdProductoTipo from in_productotipo where IdEmpresa =" + IdEmpresa + " and EsMateriaPrima = 'S' )";
                    var Producto = Oentities.Database.SqlQuery<in_Producto_Info>(Query);

                    return Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_ProductosTerminados(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {
                    var selectCbtecble = from C in Oentities.in_Producto
                                         join t in Oentities.in_ProductoTipo
                                         on new { C.IdEmpresa, C.IdProductoTipo } equals new { t.IdEmpresa, t.IdProductoTipo }
                                         where C.IdEmpresa == IdEmpresa
                                         && t.EsProductoTerminado == "S"
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);
                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                        prd.pr_largo = item.pr_largo;
                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                        prd.pr_precio_mayor = item.pr_precio_mayor;
                        prd.pr_precio_minimo = item.pr_precio_minimo;
                        prd.pr_precio_publico = item.pr_precio_publico;
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);
                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;
                        //prd.IdNaturaleza = item.IdNaturaleza;
                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                        prd.SEstado = (item.Estado == "A") ? "Activo" : "Inactivo";



                        lista.Add(prd);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarProductExiste(string Nombre)
        {
            try
            {
                EntitiesInventario oen = new EntitiesInventario();
                var Prod = from q in oen.in_Producto
                           where q.pr_descripcion == Nombre
                           select q;
                if (Prod.ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public in_Producto_Info Get_Info_ProductoXNombre(int IdEmpresa, string Descripcion)
        {
            try
            {
                using (EntitiesInventario Oenti = new EntitiesInventario())
                {

                    in_Producto_Info Info = new in_Producto_Info();
                    string query = "select * from in_Producto where IdEmpresa = " + IdEmpresa + " and pr_descripcion like'" + Descripcion + "'";
                    var Consulta = Oenti.Database.SqlQuery<in_Producto_Info>(query);
                    Info = Consulta.First();

                    return Info;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_ProductosXModeloProduccion(int IdEmpresa, int IdModeloProduccion)
        {
            try
            {
                EntitiesInventario Oen = new EntitiesInventario();
                string Querty = "select * from in_Producto where IdProducto in"
                                + " (select  IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa = " + IdEmpresa + " and IdModeloProd =" + IdModeloProduccion + ") "
                                + " and IdEmpresa = " + IdEmpresa;
                return Oen.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_MateriaPrimaModulosdeProduccion(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario oent = new EntitiesInventario();
                string Querty = "select * from in_Producto where IdProductoTipo = "
                               + " (select  IdProductoTipo from in_ProductoTipo where IdEmpresa = " + IdEmpresa + " and EsMateriaPrima = 'S' ) and IdEmpresa =  " + IdEmpresa +
                                "    and IdProducto in(select IdProducto from in_producto_x_tb_bodega  where IdEmpresa = " + IdEmpresa + ")";

                return oent.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public List<in_Producto_Info> Get_list_ProductosMateriaPrima(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {



                    var selectCbtecble = from C in Oentities.in_Producto
                                         join t in Oentities.in_ProductoTipo
                                         on new { C.IdEmpresa, C.IdProductoTipo } equals new { t.IdEmpresa, t.IdProductoTipo }
                                         where C.IdEmpresa == IdEmpresa
                                         && t.EsMateriaPrima == "S"
                                         select C;

                    foreach (var item in selectCbtecble)
                    {
                        in_Producto_Info prd = new in_Producto_Info();
                        prd.IdEmpresa = item.IdEmpresa;
                        prd.Estado = item.Estado.Trim();
                        prd.Fecha_Transac = item.Fecha_Transac;
                        prd.Fecha_UltAnu = item.Fecha_UltAnu;
                        prd.Fecha_UltMod = item.Fecha_UltMod;
                        prd.IdCategoria = item.IdCategoria.Trim();
                        prd.pr_imagen_Grande = item.pr_imagen_Grande;
                        prd.pr_imagenPeque = item.pr_imagenPeque;
                        prd.IdPresentacion = item.IdPresentacion;
                        prd.pr_descripcion = item.pr_descripcion;
                        prd.PesoEspecifico = item.PesoEspecifico;
                        prd.AnchoEspecifico = item.AnchoEspecifico;
                        prd.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                        prd.IdEmpresa = item.IdEmpresa;
                        prd.IdMarca = (item.IdMarca == null) ? 0 : Convert.ToInt32(item.IdMarca);

                        prd.IdProducto = item.IdProducto;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdUnidadMedida = item.IdUnidadMedida.Trim();
                        prd.IdUsuario = item.IdUsuario.Trim();
                        prd.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        prd.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        prd.ip = item.ip.Trim();
                        prd.nom_pc = item.nom_pc.Trim();
                        prd.pr_alto = item.pr_alto;
                        prd.pr_codigo = item.pr_codigo.Trim();
                        prd.pr_codigo_barra = item.pr_codigo_barra.Trim();
                        prd.pr_costo_CIF = item.pr_costo_CIF;
                        prd.pr_costo_fob = item.pr_costo_fob;
                        prd.pr_costo_promedio = item.pr_costo_promedio;
                        prd.pr_descripcion = item.pr_descripcion.Trim();
                        prd.pr_DiasAereo = item.pr_DiasAereo;
                        prd.pr_DiasMaritimo = item.pr_DiasMaritimo;
                        prd.pr_DiasTerrestre = item.pr_DiasTerrestre;
                        prd.pr_largo = item.pr_largo;
                        prd.pr_ManejaIva = item.pr_ManejaIva.Trim();
                        prd.pr_ManejaSeries = item.pr_ManejaSeries.Trim();
                        prd.pr_observacion = item.pr_observacion.Trim();
                        prd.pr_partidaArancel = item.pr_partidaArancel;
                        prd.pr_peso = item.pr_peso;
                        prd.pr_porcentajeArancel = item.pr_porcentajeArancel;
                        prd.pr_precio_mayor = item.pr_precio_mayor;
                        prd.pr_precio_minimo = item.pr_precio_minimo;
                        prd.pr_precio_publico = item.pr_precio_publico;
                        prd.pr_profundidad = item.pr_profundidad;
                        prd.pr_stock_maximo = item.pr_stock_maximo;
                        prd.pr_stock_minimo = item.pr_stock_minimo;
                        prd.IdProductoTipo = item.IdProductoTipo;

                        prd.IdLinea = Convert.ToInt32(item.IdLinea);
                        prd.IdGrupo = Convert.ToInt32(item.IdGrupo);
                        prd.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);

                        prd.IdProductoTipo = item.IdProductoTipo;
                        prd.ManejaKardex = item.ManejaKardex;

                        //prd.IdNaturaleza = item.IdNaturaleza;

                        prd.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                        prd.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                        prd.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                        prd.Aparece_modu_Compras = item.Aparece_modu_Compras;
                        prd.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                        prd.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;




                        lista.Add(prd);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_MateriaPrima_X_ModeloDeProduccion(int IdEmpresa, int IdModeloProduccion)
        {
            try
            {
                EntitiesInventario oEn = new EntitiesInventario();
                string Querty = " DECLARE @iDEMPRESA INT =  " + IdEmpresa +
                                " select * from in_Producto where IdProductoTipo = " +
                                " (select  IdProductoTipo from in_ProductoTipo where IdEmpresa = @iDEMPRESA and EsMateriaPrima = 'S' ) and IdEmpresa = @iDEMPRESA " +
                                " and IdProducto in(select IdProducto from in_producto_x_tb_bodega  where IdEmpresa =@iDEMPRESA  )" +
                                " and IdProducto In(Select IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa =@iDEMPRESA and IdModeloProd =" + IdModeloProduccion + ")";

                return oEn.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_ProductosSucursalXBodegaXModulodeProduccion(int IdEmpresa, int IdModeloProduccion, int IdBodega, int IdSucursa)
        {
            try
            {
                EntitiesInventario oEn = new EntitiesInventario();
                string Querty = "DECLARE @iDEMPRESA INT = " + IdEmpresa +
                                  "  select a.*,b.Tipo from in_Producto a " +
                                  "  inner join prod_ModeloProduccion_x_Producto_CusTal b on a.IdEmpresa =b.IdEmpresa and a.IdProducto = b.IdProducto  " +
                                  " where  a.IdEmpresa = @iDEMPRESA  " +
                                  "  and a.IdProducto in(select IdProducto from in_producto_x_tb_bodega  where IdEmpresa =@iDEMPRESA and IdBodega =" + IdBodega + " and IdSucursal =" + IdSucursa + " ) " +
                                  "  and a.IdProducto In(Select IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa =@iDEMPRESA and IdModeloProd =" + IdModeloProduccion + ") ";

                return oEn.Database.SqlQuery<in_Producto_Info>(Querty).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Productos_X_Proveedor(int IdEmpresa, decimal IdProveedor, int IdEmpresa_x_Proveedor, string Esta = "")
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario Oen = new EntitiesInventario();
                string NomPro = "";
                string Descrip = "";

                if (Esta == "")
                {
                    NomPro = "  inner join in_producto_x_cp_proveedor D on A.IdProducto = D.IdProducto and A.IdEmpresa = D.IdEmpresa_prod" +
                                 "   and D.IdEmpresa_prov =" + IdEmpresa + " and D.IdProveedor =" + IdProveedor + " ";

                    Descrip = ", D.NomProducto_en_Proveedor as Producto ";
                }

                string Query = "   SELECT A.*, B.ca_Categoria, C.Descripcion as Marca " + Descrip +
                                   " FROM in_Producto AS A INNER JOIN " +
                                   " in_categorias AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdCategoria = B.IdCategoria INNER JOIN " +
                                   " in_Marca AS C ON A.IdEmpresa = C.IdEmpresa AND A.IdMarca = C.IdMarca " + NomPro +

                                   " where concat(A.IdEmpresa, A.IdProducto) " + Esta + " in  " +
                                   " ( " +
                                   " select concat(A.IdEmpresa_prod, A.IdProducto) " +
                                   " from in_producto_x_cp_proveedor A " +
                                   " where A.IdEmpresa_prov = " + IdEmpresa_x_Proveedor +
                                   " and A.IdProveedor = " + IdProveedor +
                                   " ) and A.IdEmpresa = " + IdEmpresa;

                lista = Oen.Database.SqlQuery<in_Producto_Info>(Query).ToList();

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Productos_x_Empresa(int IdEmpresa)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                EntitiesInventario Oen = new EntitiesInventario();

                var select = from q in Oen.vwin_in_Producto_x_tb_bodega_x_UnidadMedida
                             where q.IdEmpresa == IdEmpresa
                             select q;

                foreach (var item in select)
                {
                    in_Producto_Info Info = new in_Producto_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProducto = item.IdProducto;
                    Info.pr_codigo = item.pr_codigo;
                    Info.pr_descripcion = item.pr_descripcion;
                    Info.pr_codigo_barra = item.pr_codigo_barra;
                    Info.IdProductoTipo = item.IdProductoTipo;
                    Info.IdPresentacion = item.IdPresentacion;
                    Info.IdCategoria = item.IdCategoria;
                    Info.pr_observacion = item.pr_observacion;
                    Info.IdUnidadMedida = item.IdUnidadMedida;
                    Info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    Info.nom_Tipo_Producto = item.Descripcion_TipoConsumo;
                    Info.pr_ManejaIva = item.pr_ManejaIva;
                    Info.pr_costo_fob = item.pr_costo_fob;
                    Info.pr_ManejaSeries = item.pr_ManejaSeries;
                    Info.pr_costo_CIF = item.pr_costo_CIF;
                    Info.pr_costo_promedio = item.pr_costo_promedio_bodega;
                    Info.pr_peso = item.pr_peso;
                    Info.pr_stock_Bodega = item.pr_stock_Bodega;
                    Info.IdCtaCble_Inventario = item.IdCtaCble_Inven;
                    Info.pr_stock = item.pr_stock;
                    Info.pr_pedidos = item.pr_pedidos;
                    Info.pr_precio_publico = item.pr_precio_publico;
                    Info.pr_precio_minimo = item.pr_precio_minimo;
                    Info.IdLinea = Convert.ToInt32(item.IdLinea);
                    Info.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    Info.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);
                    Info.IdBodega = item.IdBodega;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMarca = item.IdMarca;
                    Info.pr_DiasMaritimo = item.pr_DiasMaritimo;
                    Info.pr_DiasAereo = item.pr_DiasAereo;
                    Info.pr_DiasTerrestre = item.pr_DiasTerrestre;
                    Info.pr_partidaArancel = item.pr_partidaArancel;
                    Info.pr_porcentajeArancel = item.pr_porcentajeArancel;
                    Info.nom_pc = item.nom_pc;
                    Info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    Info.Fecha_UltAnu = item.Fecha_UltAnu;
                    Info.Fecha_UltMod = item.Fecha_UltMod;
                    Info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    Info.Fecha_Transac = item.Fecha_Transac;
                    Info.IdUsuario = item.IdUsuario;
                    Info.pr_profundidad = item.pr_profundidad;
                    Info.pr_alto = item.pr_alto;
                    Info.pr_largo = item.pr_largo;
                    Info.pr_precio_mayor = item.pr_precio_mayor;


                    Info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    Info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    Info.IdCtaCble_Vta = item.IdCtaCble_Vta;
                    Info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    Info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    Info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    Info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    Info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    Info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;




                    Info.ip = item.ip;
                    Info.Estado = item.Estado;
                    Info.pr_imagenPeque = item.pr_imagenPeque;
                    Info.pr_imagen_Grande = item.pr_imagen_Grande;

                    Info.CodBarra = item.pr_codigo_barra;

                    Info.IdPresentacion = item.IdPresentacion;

                    Info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                    Info.AnchoEspecifico = item.AnchoEspecifico;
                    Info.pr_stock_maximo = item.pr_stock_maximo;
                    Info.PesoEspecifico = item.PesoEspecifico;
                    Info.ManejaKardex = item.ManejaKardex;
                    Info.pr_stock_minimo = item.pr_stock_minimo;
                    Info.pr_descripcion_2 = item.pr_descripcion_2;
                    Info.pr_motivoAnulacion = item.pr_motivoAnulacion;

                    Info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    Info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;


                    Info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    Info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    Info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    Info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;

                    lista.Add(Info);
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_ProductoTerminado_X_ModeloDeProduccion(int IdEmpresa, int IdTipoModelo)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
                using (EntitiesInventario Oen = new EntitiesInventario())
                {


                    string Query = "select * from in_Producto where IdProducto in (select IdProducto from prod_ModeloProduccion_x_Producto_CusTal where IdEmpresa =" + IdEmpresa + " and IdModeloProd=" + IdTipoModelo + "and Tipo='PRODTERMI') and IdEmpresa =" + IdEmpresa;

                    var Consulta = Oen.Database.SqlQuery<in_Producto_Info>(Query);
                    lista = Consulta.ToList();
                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool Delete_Todos_Producto(int IdEmpresa, ref string MensajeError)
        {

            try
            {
                using (EntitiesCompras_GE Entity = new EntitiesCompras_GE())
                {
                    int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete from in_producto where IdEmpresa = " + IdEmpresa);
                }
                MensajeError = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }


        }

        public in_Producto_Info GetProducto(int IdEmpresa, string CodBarra)
        {
            try
            {
                //prueba    
                EntitiesInventario OEInventario = new EntitiesInventario();
                var select_Inventario = from C in OEInventario.in_Producto
                                        where C.IdEmpresa == IdEmpresa && C.pr_codigo_barra == CodBarra

                                        select C;
                in_Producto_Info info = new in_Producto_Info();
                foreach (var item in select_Inventario)
                {
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProductoTipo = item.IdProductoTipo;
                    info.IdProducto = item.IdProducto;
                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_codigo_barra = item.pr_codigo_barra;
                    info.pr_descripcion = item.pr_descripcion.Trim();
                    info.pr_descripcion_2 = "[" + item.pr_codigo.Trim() + "]" + item.pr_descripcion.Trim();
                    info.pr_peso = item.pr_peso;
                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdCategoria = item.IdCategoria;
                    info.IdLinea = Convert.ToInt32(item.IdLinea);
                    info.IdGrupo = Convert.ToInt32(item.IdGrupo);
                    info.IdSubGrupo = Convert.ToInt32(item.IdSubGrupo);
                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Producto_Info> Get_list_Productos_not_exist_in_producto_x_bodega(int IdEmpresa, int Idsucursal, int idbodega)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();

                using (EntitiesInventario Oentities = new EntitiesInventario())
                {

                    string Query = " SELECT        Prod.IdEmpresa, Prod.IdProducto, Prod.pr_codigo, Prod.pr_descripcion, Prod.pr_descripcion_2, Prod.IdProductoTipo, Prod.IdMarca, Prod.IdPresentacion, Prod.IdCategoria, Prod.IdLinea, Prod.IdGrupo,  ";
                    Query = Query + " Prod.IdSubGrupo, Prod.IdUnidadMedida, Prod.IdUnidadMedida_Consumo, Prod.IdNaturaleza, Prod.IdMotivo_Vta, Prod.IdCod_Impuesto_Iva, Prod.IdCod_Impuesto_Ice, Prod.Aparece_modu_Ventas, ";
                    Query = Query + " Prod.Aparece_modu_Compras, Prod.Aparece_modu_Inventario, Prod.Aparece_modu_Activo_F, Prod.Estado, prodT.tp_descripcion AS nom_Tipo_Producto, cat.ca_Categoria AS nom_Categoria, ";
                    Query = Query + " L.nom_linea AS nom_Linea";
                    Query = Query + " FROM            in_linea AS L INNER JOIN ";
                    Query = Query + " in_categorias AS cat ON L.IdEmpresa = cat.IdEmpresa AND L.IdCategoria = cat.IdCategoria INNER JOIN ";
                    Query = Query + " in_Producto AS Prod INNER JOIN ";
                    Query = Query + " in_ProductoTipo AS prodT ON Prod.IdEmpresa = prodT.IdEmpresa AND Prod.IdProductoTipo = prodT.IdProductoTipo ON L.IdEmpresa = Prod.IdEmpresa AND L.IdCategoria = Prod.IdCategoria AND  ";
                    Query = Query + " L.IdLinea = Prod.IdLinea ";
                    Query = Query + " where  ";
                    Query = Query + " not exists( ";
                    Query = Query + " select A.IdProducto from  in_producto_x_tb_bodega A  ";
                    Query = Query + " where A.IdEmpresa = " + IdEmpresa;
                    Query = Query + " and A.IdBodega =  " + idbodega;
                    Query = Query + " and A.IdSucursal =  " + Idsucursal;
                    Query = Query + " and A.IdProducto = Prod.IdProducto ";
                    Query = Query + " and A.IdEmpresa=Prod.IdEmpresa ";
                    Query = Query + " )";
                    Query = Query + " and Prod.IdEmpresa=" + IdEmpresa;


                    var Producto = Oentities.Database.SqlQuery<in_Producto_Info>(Query);

                    return Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_codigo_barra(in_Producto_Info prI, ref string mensaje)
        {
            try
            {
                bool res = false;
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Producto.FirstOrDefault(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdProducto == prI.IdProducto);
                    if (contact != null)
                    {
                        contact.pr_codigo_barra = prI.pr_codigo_barra == null ? "" : prI.pr_codigo_barra;//27
                        contact.IdUsuarioUltMod = prI.IdUsuarioUltMod;
                        contact.Fecha_UltMod = DateTime.Now;
                        context.SaveChanges();
                        res = true;
                    }
                }
                return res;
            }
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public in_Producto_Info Get_Producto_X_Bodega(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            try
            {

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 99999 : IdBodega;

                in_Producto_Info info = new in_Producto_Info();
                EntitiesInventario OEInventario = new EntitiesInventario();

                OEInventario.SetCommandTimeOut(60000);

                var select_Inventario = from C in OEInventario.vwin_producto_x_tb_bodega
                                        where C.IdEmpresa == IdEmpresa
                                        && C.IdSucursal == IdSucursal
                                        && C.IdBodega == IdBodega
                                        && C.Aparece_modu_Inventario == true
                                        && C.IdProducto == IdProducto
                                        orderby C.IdEmpresa, C.IdProducto
                                        //orderby C.IdEmpresa,C.IdSucursal,C.IdBodega,C.nom_Categoria,C.nom_linea,C.IdProducto
                                        select C;

                foreach (var item in select_Inventario)
                {
                    info = new in_Producto_Info();
                    info.pr_costo_promedio = item.pr_costo_promedio;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;

                    info.pr_codigo = item.pr_codigo.Trim();
                    info.pr_descripcion = item.pr_descripcion;
                    info.pr_descripcion_2 = "[" + item.pr_codigo + "] - " + item.pr_descripcion;

                    info.pr_peso = item.pr_peso;
                    info.pr_stock = item.pr_stock;
                    info.pr_Pedidos_inv = item.pr_Pedidos_inv;
                    info.pr_disponible = item.pr_Disponible;
                    info.pr_Disponible = item.pr_Disponible;
                    info.pr_Pedidos_fact = item.pr_Pedidos_fact;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_stock_minimo = item.pr_stock_minimo;
                    info.pr_ManejaIva = item.pr_ManejaIva.Trim() == "S" ? "S" : item.pr_ManejaIva;
                    info.pr_ManejaSeries = item.pr_ManejaSeries.Trim() == "S" ? "S" : item.pr_ManejaSeries;
                    info.IdSucursal = item.IdSucursal;
                    info.ManejaKardex = item.ManejaKardex;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.nom_Linea = item.nom_linea;
                    info.nom_Categoria = item.nom_Categoria;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                    info.nom_UnidadMedida = item.Descripcion_UniMedida;
                    info.nom_UnidadMedida_Consumo = item.Descripcion_TipoConsumo;

                    info.IdCtaCble_Inventario = item.IdCtaCble_Inventario;
                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Vta = item.IdCtaCble_Vta;

                    info.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                    info.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                    info.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                    info.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                    info.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                    info.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                    info.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                    info.IdCtaCble_DevIva = item.IdCtaCble_DevIva;

                    info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    info.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;

                    info.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                    info.Aparece_modu_Compras = item.Aparece_modu_Compras;
                    info.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                    info.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                    info.pr_codigo_barra = item.pr_codigo_barra;
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_Producto_Info Get_Info_x_Descripcion(int IdEmpresa, string pr_descripcion)
        {
            try
            {
                try
                {
                    in_Producto_Info address = new in_Producto_Info();

                    using (EntitiesInventario context = new EntitiesInventario())
                    {
                        EntitiesInventario EDB = new EntitiesInventario();

                        var Q = from per in EDB.in_Producto
                                where per.IdEmpresa == IdEmpresa
                                && per.pr_descripcion == pr_descripcion
                                select per;

                        foreach (var item in Q)
                        {
                            address = new in_Producto_Info();
                            address.IdEmpresa = item.IdEmpresa;
                            address.IdProducto = item.IdProducto;
                            address.pr_codigo = item.pr_codigo;
                            address.pr_descripcion = item.pr_descripcion;
                            address.pr_descripcion_2 = item.pr_descripcion_2;
                            address.IdProductoTipo = item.IdProductoTipo;
                            address.IdMarca = item.IdMarca;
                            address.IdPresentacion = item.IdPresentacion;
                            address.IdCategoria = item.IdCategoria;
                            address.IdLinea = item.IdLinea;
                            address.IdGrupo = item.IdGrupo;
                            address.IdSubGrupo = item.IdSubGrupo;
                            address.IdUnidadMedida = item.IdUnidadMedida;
                            address.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                            address.pr_codigo_barra = item.pr_codigo_barra;
                            address.pr_observacion = item.pr_observacion;
                            address.pr_precio_mayor = item.pr_precio_mayor;
                            address.pr_precio_minimo = item.pr_precio_minimo;
                            address.pr_precio_publico = item.pr_precio_publico;
                            address.pr_precio_puerta = item.pr_precio_puerta;
                            address.pr_ManejaIva = item.pr_ManejaIva;
                            address.pr_ManejaSeries = item.pr_ManejaSeries;
                            address.pr_costo_CIF = item.pr_costo_CIF;
                            address.pr_costo_fob = item.pr_costo_fob;
                            address.pr_costo_promedio = item.pr_costo_promedio;
                            address.pr_DiasAereo = item.pr_DiasAereo;
                            address.pr_DiasMaritimo = item.pr_DiasMaritimo;
                            address.pr_DiasTerrestre = item.pr_DiasTerrestre;
                            address.pr_largo = item.pr_largo;
                            address.pr_alto = item.pr_alto;
                            address.pr_profundidad = item.pr_profundidad;
                            address.pr_peso = item.pr_peso;
                            address.pr_imagen_Grande = item.pr_imagen_Grande;
                            address.pr_imagenPeque = item.pr_imagenPeque;
                            address.pr_partidaArancel = item.pr_partidaArancel;
                            address.pr_porcentajeArancel = item.pr_porcentajeArancel;
                            address.pr_Por_descuento = item.pr_Por_descuento;
                            address.pr_stock_maximo = item.pr_stock_maximo;
                            address.pr_stock_minimo = item.pr_stock_minimo;
                            address.IdUsuario = item.IdUsuario;
                            address.Fecha_Transac = item.Fecha_Transac;
                            address.IdUsuarioUltMod = item.IdUsuarioUltMod;
                            address.Fecha_UltMod = item.Fecha_UltMod;
                            address.ip = item.ip;
                            address.nom_pc = item.nom_pc;
                            address.Estado = item.Estado;
                            address.PesoEspecifico = item.PesoEspecifico;
                            address.AnchoEspecifico = item.AnchoEspecifico;
                            address.ManejaKardex = item.ManejaKardex;
                            address.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                            address.IdCod_Impuesto_Ice = item.IdCod_Impuesto_Ice;
                            address.Aparece_modu_Ventas = item.Aparece_modu_Ventas;
                            address.Aparece_modu_Compras = item.Aparece_modu_Compras;
                            address.Aparece_modu_Inventario = item.Aparece_modu_Inventario;
                            address.Aparece_modu_Activo_F = item.Aparece_modu_Activo_F;
                        }
                    }

                    return address;
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

    }
}