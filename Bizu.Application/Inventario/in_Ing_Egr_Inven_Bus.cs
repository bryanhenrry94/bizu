using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Inventario;
using Bizu.Domain.General;
using Bizu.Application.General;

using Bizu.Application;
using Bizu.Application.Compras;
using Bizu.Domain.Compras;
using Bizu.Infrastructure.Inventario;
using System.ComponentModel;

namespace Bizu.Application.Inventario
{
    public class in_Ing_Egr_Inven_Bus
    {
        public string accion = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_Ing_Egr_Inven_Data odata = new in_Ing_Egr_Inven_Data();
        in_UnidadMedida_Equiv_conversion_Bus busUni_Equiv = new in_UnidadMedida_Equiv_conversion_Bus();
        in_UnidadMedida_Equiv_conversion_Info InfoUni_Equiv = new in_UnidadMedida_Equiv_conversion_Info();
        com_ordencompra_local_Bus bus_oc = new com_ordencompra_local_Bus();
        string mensaje = "";
        in_Parametro_Bus busParam = new in_Parametro_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_Parametro_Info InfoParam = new in_Parametro_Info();
        string IdEstadoAproba_Param = "";
        double ValorEquiv = 0;

        public Boolean GuardarDB_x_OrdenProduccion(in_Ing_Egr_Inven_Info info, ref decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                Boolean res = true;

                InfoParam = busParam.Get_Info_Parametro(info.IdEmpresa);

                if (Validar_objeto_IngEgr(info, ref mensaje))
                {
                    foreach (var item in info.listIng_Egr)
                    {
                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProdu = BusProducto.Get_info_Product(info.IdEmpresa, item.IdProducto);
                        item.signo = info.signo;

                        if (item.IdEstadoAproba == null || item.IdEstadoAproba == "")
                        {
                            if (info.signo == "+")
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Ing;
                            else
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Egr;
                            item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa),
                                Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega),
                                IdEstadoAproba_Param);
                        }
                        if (item.IdUnidadMedida_sinConversion == null || item.IdUnidadMedida_sinConversion == "")
                        {
                            item.IdUnidadMedida = InfoProdu.IdUnidadMedida;
                            item.IdUnidadMedida_Consumo = InfoProdu.IdUnidadMedida_Consumo;
                            item.IdUnidadMedida_sinConversion = InfoProdu.IdUnidadMedida;
                        }
                        if ( /*item.mv_costo_sinConversion == 0 ||*/ item.signo == "-")
                        {
                            in_producto_x_tb_bodega_Costo_Historico_Bus BusProd_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                            in_producto_x_tb_bodega_Costo_Historico_Info Info_Produc_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();
                            Info_Produc_x_Costo = BusProd_x_Costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal,
                                Convert.ToInt32(item.IdBodega), item.IdProducto, info.cm_fecha);
                            item.mv_costo = Info_Produc_x_Costo.costo;
                            item.mv_costo_sinConversion = Info_Produc_x_Costo.costo;
                        }

                        #region Convierte costo y cantidad en la unidad de consumo

                        //ValorEquiv = 0;
                        //InfoUni_Equiv = busUni_Equiv.Get_Info_in_UnidadMedida_Equiv_conversion(item.IdUnidadMedida_sinConversion, InfoProdu.IdUnidadMedida_Consumo);
                        //ValorEquiv = InfoUni_Equiv.valor_equiv == 0 ? 1 : InfoUni_Equiv.valor_equiv;
                        //item.dm_cantidad = item.dm_cantidad_sinConversion * ValorEquiv;
                        item.mv_costo = item.signo == "-" ? item.mv_costo_sinConversion : (item.mv_costo_sinConversion * item.dm_cantidad_sinConversion) / item.dm_cantidad;
                        item.IdUnidadMedida = InfoProdu.IdUnidadMedida_Consumo;

                        #endregion

                    }
                    //GUARDA EL MOVIMIENTO
                    if (res = odata.GuardarDB(info, ref IdNumMovi, ref mensaje))
                    {
                        res = procesoGenerarMoviInve(info, IdNumMovi, ref mensaje);
                    }
                }
                else
                {
                    res = false;
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean GuardarDB(in_Ing_Egr_Inven_Info info, ref decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                Boolean res = true;

                InfoParam = busParam.Get_Info_Parametro(info.IdEmpresa);

                if (Validar_objeto_IngEgr(info, ref mensaje))
                {
                    foreach (var item in info.listIng_Egr)
                    {
                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProdu = BusProducto.Get_info_Product(info.IdEmpresa, item.IdProducto);
                        item.signo = info.signo;

                        if (item.IdEstadoAproba == null || item.IdEstadoAproba == "")
                        {
                            if (info.signo == "+")
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Ing;
                            else
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Egr;

                            item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa),
                                Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega),
                                IdEstadoAproba_Param);
                        }
                        if (item.IdUnidadMedida_sinConversion == null || item.IdUnidadMedida_sinConversion == "")
                        {
                            item.IdUnidadMedida = InfoProdu.IdUnidadMedida;
                            item.IdUnidadMedida_Consumo = InfoProdu.IdUnidadMedida_Consumo;
                            item.IdUnidadMedida_sinConversion = InfoProdu.IdUnidadMedida;
                        }
                        if (item.signo == "-")
                        {
                            in_producto_x_tb_bodega_Costo_Historico_Bus BusProd_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                            in_producto_x_tb_bodega_Costo_Historico_Info Info_Produc_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();
                            Info_Produc_x_Costo = BusProd_x_Costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal,
                                Convert.ToInt32(item.IdBodega), item.IdProducto, info.cm_fecha);
                            item.mv_costo = Info_Produc_x_Costo.costo;
                            item.mv_costo_sinConversion = Info_Produc_x_Costo.costo;
                        }

                        #region Convierte costo y cantidad en la unidad de consumo

                        ValorEquiv = 0;
                        InfoUni_Equiv = busUni_Equiv.Get_Info_in_UnidadMedida_Equiv_conversion(item.IdUnidadMedida_sinConversion, InfoProdu.IdUnidadMedida_Consumo);
                        ValorEquiv = InfoUni_Equiv.valor_equiv == 0 ? 1 : InfoUni_Equiv.valor_equiv;
                        item.dm_cantidad = item.dm_cantidad_sinConversion * ValorEquiv;
                        item.mv_costo = item.signo == "-" ? item.mv_costo_sinConversion : (item.mv_costo_sinConversion * item.dm_cantidad_sinConversion) / item.dm_cantidad;
                        item.IdUnidadMedida = InfoProdu.IdUnidadMedida_Consumo;

                        #endregion

                        #region Maneja numero de lote

                        if (Convert.ToBoolean(InfoParam.P_Maneja_Lote) && BusProducto.Producto_maneja_lote(param.IdEmpresa, item.IdProducto))
                        {
                            if (info.signo == "+")
                            {
                                if (string.IsNullOrEmpty(item.Lote))
                                {
                                    int anio;
                                    int mes;
                                    int dia;
                                    int hora;
                                    int minuto;
                                    int sec;

                                    anio = info.Fecha_Transac.Year;
                                    mes = info.Fecha_Transac.Month;
                                    dia = info.Fecha_Transac.Day;
                                    hora = info.Fecha_Transac.TimeOfDay.Hours;
                                    minuto = info.Fecha_Transac.TimeOfDay.Minutes;
                                    sec = info.Fecha_Transac.TimeOfDay.Seconds;

                                    item.Lote = anio.ToString("0000") + mes.ToString("00") + dia.ToString("00") + hora.ToString("00") + minuto.ToString("00") + sec.ToString("00") + param.InfoSucursal.codigo;
                                }
                            }                            
                        }

                        #endregion 
                    }
                    //GUARDA EL MOVIMIENTO
                    if (res = odata.GuardarDB(info, ref IdNumMovi, ref mensaje))
                        res = procesoGenerarMoviInve(info, IdNumMovi, ref mensaje);
                }
                else
                {
                    res = false;
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean GuardarDB_x_Ajuste(in_Ing_Egr_Inven_Info info, ref decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                Boolean res = true;

                InfoParam = busParam.Get_Info_Parametro(info.IdEmpresa);

                if (Validar_objeto_IngEgr(info, ref mensaje))
                {
                    foreach (var item in info.listIng_Egr)
                    {
                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProdu = BusProducto.Get_info_Product(info.IdEmpresa, item.IdProducto);
                        item.signo = info.signo;

                        if (item.IdEstadoAproba == null || item.IdEstadoAproba == "")
                        {
                            if (info.signo == "+")
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Ing;
                            else
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Egr;
                            item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa),
                                Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega),
                                IdEstadoAproba_Param);
                        }
                        if (item.IdUnidadMedida_sinConversion == null || item.IdUnidadMedida_sinConversion == "")
                        {
                            item.IdUnidadMedida = InfoProdu.IdUnidadMedida;
                            item.IdUnidadMedida_Consumo = InfoProdu.IdUnidadMedida_Consumo;
                            item.IdUnidadMedida_sinConversion = InfoProdu.IdUnidadMedida;
                        }

                        //SE COMENTO PARA CONSIDERAR EL COSTO QUE VIENE DEL INFO
                        //if ( /*item.mv_costo_sinConversion == 0 ||*/ item.signo == "-")
                        //{
                        //    in_producto_x_tb_bodega_Costo_Historico_Bus BusProd_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                        //    in_producto_x_tb_bodega_Costo_Historico_Info Info_Produc_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();
                        //    Info_Produc_x_Costo = BusProd_x_Costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal,
                        //        Convert.ToInt32(item.IdBodega), item.IdProducto, info.cm_fecha);
                        //    item.mv_costo = Info_Produc_x_Costo.costo;
                        //    item.mv_costo_sinConversion = Info_Produc_x_Costo.costo;
                        //}

                        #region Convierte costo y cantidad en la unidad de consumo

                        ValorEquiv = 0;
                        InfoUni_Equiv = busUni_Equiv.Get_Info_in_UnidadMedida_Equiv_conversion(item.IdUnidadMedida_sinConversion, InfoProdu.IdUnidadMedida_Consumo);
                        ValorEquiv = InfoUni_Equiv.valor_equiv == 0 ? 1 : InfoUni_Equiv.valor_equiv;
                        item.dm_cantidad = item.dm_cantidad_sinConversion * ValorEquiv;
                        item.mv_costo = item.signo == "-" ? item.mv_costo_sinConversion : (item.mv_costo_sinConversion * item.dm_cantidad_sinConversion) / item.dm_cantidad;
                        item.IdUnidadMedida = InfoProdu.IdUnidadMedida_Consumo;

                        #endregion

                    }
                    //GUARDA EL MOVIMIENTO
                    if (res = odata.GuardarDB(info, ref IdNumMovi, ref mensaje))
                    {
                        res = procesoGenerarMoviInve_x_Ajuste(info, IdNumMovi, ref mensaje);
                    }
                }
                else
                {
                    res = false;
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        private void ProcesoRecosteoInventario(in_Ing_Egr_Inven_Info info)
        {
            try
            {
                foreach (var item in info.listIng_Egr)
                {
                    in_producto_Bus BusProducto = new in_producto_Bus();
                    in_Producto_Info InfoProdu = BusProducto.Get_info_Product(info.IdEmpresa, item.IdProducto);
                    item.signo = info.signo;

                    if (item.mv_costo_sinConversion == 0 || item.signo == "-")
                    {
                        in_producto_x_tb_bodega_Costo_Historico_Bus BusProd_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                        in_producto_x_tb_bodega_Costo_Historico_Info Info_Produc_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();
                        Info_Produc_x_Costo = BusProd_x_Costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal, Convert.ToInt32(item.IdBodega), item.IdProducto, info.cm_fecha);
                        item.mv_costo = Info_Produc_x_Costo.costo;
                        item.mv_costo_sinConversion = Info_Produc_x_Costo.costo;
                    }
                    #region Convierte costo y cantidad en la unidad de consumo
                    ValorEquiv = 0;
                    InfoUni_Equiv = busUni_Equiv.Get_Info_in_UnidadMedida_Equiv_conversion(item.IdUnidadMedida_sinConversion, InfoProdu.IdUnidadMedida_Consumo);
                    ValorEquiv = InfoUni_Equiv.valor_equiv == 0 ? 1 : InfoUni_Equiv.valor_equiv;
                    item.dm_cantidad = item.dm_cantidad_sinConversion * ValorEquiv;
                    item.mv_costo = item.signo == "-" ? item.mv_costo_sinConversion : (item.mv_costo_sinConversion * item.dm_cantidad_sinConversion) / item.dm_cantidad;
                    item.IdUnidadMedida = InfoProdu.IdUnidadMedida_Consumo;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ProcesoRecosteoInventario", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean procesoGenerarMoviInve(in_Ing_Egr_Inven_Info info, decimal IdNumMovi, ref string mensajeError)
        {
            try
            {
                Boolean res = true;
                string IdEstadoAproba_Param = "";
                string IdEstadoAproba = "";
                in_Parametro_Bus busParam = new in_Parametro_Bus();
                in_Parametro_Info infoParam = new in_Parametro_Info();
                infoParam = busParam.Get_Info_Parametro(info.IdEmpresa);

                if (info.signo == "+")
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Ing;
                else
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Egr;

                //Recosteo
                ProcesoRecosteoInventario(info);

                var query = from bod in info.listIng_Egr
                            group bod by bod.IdBodega into grupoBodega
                            orderby grupoBodega.Key
                            select grupoBodega;

                if (query.Count() > 1)
                {
                    // Varias bodegas                                              
                    foreach (var grupoBodega in query)
                    {
                        // Detalle
                        List<in_Ing_Egr_Inven_det_Info> list_IngEgrDet = new List<in_Ing_Egr_Inven_det_Info>();
                        foreach (var bod in grupoBodega)
                        {
                            in_Ing_Egr_Inven_det_Info infoDet = new in_Ing_Egr_Inven_det_Info();
                            infoDet.IdEmpresa = bod.IdEmpresa;
                            infoDet.IdSucursal = bod.IdSucursal;
                            infoDet.IdNumMovi = bod.IdNumMovi;
                            infoDet.Secuencia = bod.Secuencia;                            
                            infoDet.IdBodega = bod.IdBodega;
                            infoDet.IdProducto = bod.IdProducto;
                            infoDet.dm_cantidad = bod.dm_cantidad;
                            infoDet.dm_stock_ante = bod.dm_stock_ante;
                            infoDet.dm_stock_actu = bod.dm_stock_actu;
                            infoDet.dm_observacion = bod.dm_observacion;
                            infoDet.dm_precio = bod.dm_precio;
                            infoDet.mv_costo = bod.mv_costo;
                            infoDet.dm_peso = bod.dm_peso;
                            infoDet.IdCentroCosto = bod.IdCentroCosto;
                            infoDet.IdCentroCosto_sub_centro_costo = bod.IdCentroCosto_sub_centro_costo;
                            infoDet.pr_descripcion = bod.pr_descripcion;
                            infoDet.IdPunto_cargo = bod.IdPunto_cargo;
                            infoDet.IdUnidadMedida = bod.IdUnidadMedida;
                            infoDet.IdPunto_cargo_grupo = bod.IdPunto_cargo_grupo;
                            infoDet.IdMotivo_Inv = bod.IdMotivo_Inv;
                            if (bod.IdEstadoAproba == null)
                                infoDet.IdEstadoAproba = Get_EstadoApro(bod.IdEmpresa, bod.IdSucursal, Convert.ToInt32(bod.IdBodega), IdEstadoAproba_Param);
                            else
                                infoDet.IdEstadoAproba = bod.IdEstadoAproba;
                            if (infoDet.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                                infoDet.Motivo_Aprobacion = null;
                            else
                                infoDet.Motivo_Aprobacion = (bod.Motivo_Aprobacion == null) ? "APROBADO POR SISTEMAS" : bod.Motivo_Aprobacion;
                            infoDet.IdUnidadMedida_sinConversion = bod.IdUnidadMedida_sinConversion;
                            infoDet.mv_costo_sinConversion = bod.mv_costo_sinConversion;
                            infoDet.dm_cantidad_sinConversion = bod.dm_cantidad_sinConversion;
                            list_IngEgrDet.Add(infoDet);
                        }

                        //cabecera
                        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
                        info_IngEgr.IdEmpresa = info.IdEmpresa;
                        info_IngEgr.IdNumMovi = info.IdNumMovi;
                        info_IngEgr.IdSucursal = info.IdSucursal;
                        info_IngEgr.IdBodega = info.IdBodega;
                        info_IngEgr.CodMoviInven = info.CodMoviInven;
                        info_IngEgr.cm_observacion = info.cm_observacion;
                        info_IngEgr.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                        info_IngEgr.cm_fecha = info.cm_fecha.Date;
                        info_IngEgr.IdUsuario = info.IdUsuario;
                        info_IngEgr.nom_pc = info.nom_pc;
                        info_IngEgr.ip = info.ip;
                        info_IngEgr.Fecha_Transac = info.Fecha_Transac;
                        info_IngEgr.signo = info.signo;
                        info_IngEgr.IdMotivo_Inv = info.IdMotivo_Inv;
                        info_IngEgr.listIng_Egr = list_IngEgrDet;//asignando el detalle

                        res = Genera_Inventario(info_IngEgr, ref IdNumMovi, ref mensaje);
                    }
                }
                else
                {
                    IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);

                    foreach (var item in info.listIng_Egr)
                    {
                        if (item.IdEstadoAproba == null)
                            item.IdEstadoAproba = IdEstadoAproba;

                        if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                            item.Motivo_Aprobacion = null;
                        else
                            item.Motivo_Aprobacion = (item.Motivo_Aprobacion == null) ? "APROBADO POR SISTEMAS" : item.Motivo_Aprobacion;
                    }

                    //una bodega
                    res = Genera_Inventario(info, ref IdNumMovi, ref mensaje);
                }
                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "procesoGenerarMoviInve", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };

            }
        }

        public Boolean procesoGenerarMoviInve_x_Ajuste(in_Ing_Egr_Inven_Info info, decimal IdNumMovi, ref string mensajeError)
        {
            try
            {
                Boolean res = true;
                string IdEstadoAproba_Param = "";
                string IdEstadoAproba = "";
                in_Parametro_Bus busParam = new in_Parametro_Bus();
                in_Parametro_Info infoParam = new in_Parametro_Info();
                infoParam = busParam.Get_Info_Parametro(info.IdEmpresa);

                if (info.signo == "+")
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Ing;
                else
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Egr;

                //Recosteo
                //ProcesoRecosteoInventario(info);

                var query = from bod in info.listIng_Egr
                            group bod by bod.IdBodega into grupoBodega
                            orderby grupoBodega.Key
                            select grupoBodega;

                if (query.Count() > 1)
                {
                    // Varias bodegas                                              
                    foreach (var grupoBodega in query)
                    {
                        // Detalle
                        List<in_Ing_Egr_Inven_det_Info> list_IngEgrDet = new List<in_Ing_Egr_Inven_det_Info>();
                        foreach (var bod in grupoBodega)
                        {
                            in_Ing_Egr_Inven_det_Info infoDet = new in_Ing_Egr_Inven_det_Info();

                            //prueba
                            infoDet.IdEmpresa = bod.IdEmpresa;
                            infoDet.IdSucursal = bod.IdSucursal;
                            infoDet.IdNumMovi = bod.IdNumMovi;
                            infoDet.Secuencia = bod.Secuencia;
                            //prueba

                            infoDet.IdBodega = bod.IdBodega;
                            infoDet.IdProducto = bod.IdProducto;
                            infoDet.dm_cantidad = bod.dm_cantidad;
                            infoDet.dm_stock_ante = bod.dm_stock_ante;
                            infoDet.dm_stock_actu = bod.dm_stock_actu;
                            infoDet.dm_observacion = bod.dm_observacion;
                            infoDet.dm_precio = bod.dm_precio;
                            infoDet.mv_costo = bod.mv_costo;
                            infoDet.dm_peso = bod.dm_peso;
                            infoDet.IdCentroCosto = bod.IdCentroCosto;
                            infoDet.IdCentroCosto_sub_centro_costo = bod.IdCentroCosto_sub_centro_costo;
                            infoDet.pr_descripcion = bod.pr_descripcion;
                            infoDet.IdPunto_cargo = bod.IdPunto_cargo;
                            infoDet.IdUnidadMedida = bod.IdUnidadMedida;
                            infoDet.IdPunto_cargo_grupo = bod.IdPunto_cargo_grupo;
                            infoDet.IdMotivo_Inv = bod.IdMotivo_Inv;

                            if (bod.IdEstadoAproba == null)
                                infoDet.IdEstadoAproba = Get_EstadoApro(bod.IdEmpresa, bod.IdSucursal, Convert.ToInt32(bod.IdBodega), IdEstadoAproba_Param);
                            else
                                infoDet.IdEstadoAproba = bod.IdEstadoAproba;

                            if (infoDet.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                                infoDet.Motivo_Aprobacion = null;
                            else
                                infoDet.Motivo_Aprobacion = (bod.Motivo_Aprobacion == null) ? "APROBADO POR SISTEMAS" : bod.Motivo_Aprobacion;

                            infoDet.IdUnidadMedida_sinConversion = bod.IdUnidadMedida_sinConversion;
                            infoDet.mv_costo_sinConversion = bod.mv_costo_sinConversion;
                            infoDet.dm_cantidad_sinConversion = bod.dm_cantidad_sinConversion;

                            list_IngEgrDet.Add(infoDet);
                        }
                        //cabecera
                        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();

                        info_IngEgr.IdEmpresa = info.IdEmpresa;
                        info_IngEgr.IdNumMovi = info.IdNumMovi;
                        info_IngEgr.IdSucursal = info.IdSucursal;
                        info_IngEgr.IdBodega = info.IdBodega;
                        info_IngEgr.CodMoviInven = info.CodMoviInven;
                        info_IngEgr.cm_observacion = info.cm_observacion;
                        info_IngEgr.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                        info_IngEgr.cm_fecha = info.cm_fecha;
                        info_IngEgr.IdUsuario = info.IdUsuario;
                        info_IngEgr.nom_pc = info.nom_pc;
                        info_IngEgr.ip = info.ip;
                        info_IngEgr.Fecha_Transac = info.Fecha_Transac;
                        info_IngEgr.signo = info.signo;
                        info_IngEgr.IdMotivo_Inv = info.IdMotivo_Inv;
                        info_IngEgr.listIng_Egr = list_IngEgrDet;//asignando el detalle

                        res = Genera_Inventario(info_IngEgr, ref IdNumMovi, ref mensaje);
                    }
                }
                else
                {
                    IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);
                    foreach (var item in info.listIng_Egr)
                    {
                        if (item.IdEstadoAproba == null)
                            item.IdEstadoAproba = IdEstadoAproba;

                        if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                            item.Motivo_Aprobacion = null;
                        else
                            item.Motivo_Aprobacion = (item.Motivo_Aprobacion == null) ? "APROBADO POR SISTEMAS" : item.Motivo_Aprobacion;
                    }

                    //una bodega                       
                    res = Genera_Inventario(info, ref IdNumMovi, ref mensaje);
                }
                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "procesoGenerarMoviInve", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };

            }
        }

        string Get_EstadoApro(int IdEmpresa, int IdSucursal, int IdBodega, string IdEstadoAproba_Param)
        {
            try
            {
                string IdEstadoAproba = "";
                tb_Bodega_Bus busBode = new tb_Bodega_Bus();

                IdEstadoAproba = busBode.Get_Info_Bodega(IdEmpresa, IdSucursal, IdBodega).IdEstadoAproba_x_Ing_Egr_Inven;
                if (IdEstadoAproba == null || IdEstadoAproba == "")
                    IdEstadoAproba = IdEstadoAproba_Param;

                return IdEstadoAproba;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerEstadoApro", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        Boolean Genera_Inventario(in_Ing_Egr_Inven_Info info, ref decimal IdNumMovi, ref string mensaje)
        {
            string msg = "";

            try
            {
                Boolean res = true;
                
                //graba inventario
                info.IdNumMovi = IdNumMovi;
                List<in_Ing_Egr_Inven_det_Info> lstIngEgre_MoviInven = new List<in_Ing_Egr_Inven_det_Info>();
                in_Motivo_Inven_Bus BusMoti_Inv = new in_Motivo_Inven_Bus();
                in_Motivo_Inven_Info info_MotInv = new in_Motivo_Inven_Info();

                if (info.IdMotivo_Inv != 0)
                    info_MotInv = BusMoti_Inv.Get_Info_Motivo_Inven(info.IdEmpresa, Convert.ToInt32(info.IdMotivo_Inv));

                //aqui
                if (info_MotInv.Genera_Movi_Inven == "S")
                {
                    lstIngEgre_MoviInven = info.listIng_Egr.Where(q => q.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString()).ToList();
                    if (lstIngEgre_MoviInven.Count() > 0)
                    {
                        info.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                        info.listIng_Egr = lstIngEgre_MoviInven;
                        //graba inventario
                        res = Genera_Inventario_x_IngEgr_Inven(info, ref msg);
                    }
                }
                else
                    mensaje = "Se ha guardado la transacción de inventario, pero no se ha generado movimiento de inventario debido a que el motivo seleccionado no genera movimiento.";

                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Genera_Inventario", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean Validar_objeto_IngEgr(in_Ing_Egr_Inven_Info Info, ref string msg)
        {
            try
            {
                if (Info.IdEmpresa == 0)
                {
                    msg = "La variable IdEmpresa estan en cero... IdEmpresa == 0  ";
                    return false;
                }

                if (Info.IdMovi_inven_tipo == 0 || Info.IdMovi_inven_tipo == null)
                {
                    msg = "Ingrese el Tipo de Movimiento ";
                    return false;
                }

                if (Info.listIng_Egr.Count == 0 || Info.listIng_Egr.Count == null)
                {
                    msg = "No existen detalles a Grabar";
                    return false;
                }


                if (Info.listIng_Egr.Count != 0)
                {

                    foreach (var item in Info.listIng_Egr)
                    {
                        if (item.dm_cantidad_sinConversion == 0)
                        {
                            msg = "Ingrese la cantidad al producto: " + item.pr_descripcion;
                            return false;
                        }

                        if (Info.signo == "-") // si es egreso 
                        {
                            if (item.dm_cantidad_sinConversion > 0)
                                item.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion * -1;
                        }
                        if (Info.signo == "+")
                        {
                            if (item.dm_cantidad_sinConversion < 0)
                                item.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion * -1;
                        }

                        ////VALIDAR STOCK POR FECHA
                        //double stock_a_fecha = odata.Obtener_Stock_x_FechaMovimiento(Convert.ToInt32(Info.IdEmpresa), Convert.ToInt32(Info.IdSucursal), Convert.ToInt32(Info.IdBodega), Convert.ToDecimal(item.IdProducto), Info.cm_fecha);

                        //if (item.dm_cantidad < stock_a_fecha)
                        //{
                        //    msg = "Cantidad a Egresar es menor al stock: " + stock_a_fecha + " para la fecha " + Info.cm_fecha;
                        //    return false;
                        //}
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Validar_objeto_IngEgr", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        Boolean Genera_Inventario_x_IngEgr_Inven(in_Ing_Egr_Inven_Info info, ref string msg)
        {
            try
            {
                //graba inventario
                in_movi_inve_Info info_MoviInve = new in_movi_inve_Info();
                info_MoviInve.IdEmpresa = info.IdEmpresa;
                info_MoviInve.IdSucursal = info.IdSucursal;
                info_MoviInve.IdBodega = (info.IdBodega == null && info.listIng_Egr.Count != 0) ? Convert.ToInt32(info.listIng_Egr.FirstOrDefault().IdBodega) : Convert.ToInt32(info.IdBodega);
                info_MoviInve.IdMovi_inven_tipo = info.IdMovi_inven_tipo;

                in_movi_inven_tipo_Info Info_moviInvTipo = new in_movi_inven_tipo_Info();
                in_movi_inven_tipo_Bus bus_moviInvTipo = new in_movi_inven_tipo_Bus();

                Info_moviInvTipo = bus_moviInvTipo.Get_Info_movi_inven_tipo(info.IdEmpresa, info.IdMovi_inven_tipo);
                if (Info_moviInvTipo.Genera_Movi_Inven == true)
                {
                    if (Info_moviInvTipo == null)
                    {
                        msg = "No existen Tipos de Movimientos de Inventario";
                        return false;
                    }

                    info_MoviInve.IdMovi_inven_tipo = Info_moviInvTipo.IdMovi_inven_tipo;
                    info_MoviInve.CodMoviInven = Info_moviInvTipo.Codigo;
                    info_MoviInve.cm_tipo = Info_moviInvTipo.cm_tipo_movi;
                    info_MoviInve.cm_observacion = info.cm_observacion;
                    info_MoviInve.cm_fecha = info.cm_fecha.Date;
                    info_MoviInve.cm_anio = info.cm_fecha.Year;
                    info_MoviInve.cm_mes = info.cm_fecha.Month;
                    info_MoviInve.IdEmpresa_Ing_Egr = info.IdEmpresa;
                    info_MoviInve.IdSucursal_Ing_Egr = info.IdSucursal;
                    info_MoviInve.IdBodega_Ing_Egr = info.IdBodega;
                    info_MoviInve.IdMovi_inven_tipo_Ing_Egr = info.IdMovi_inven_tipo;
                    info_MoviInve.IdNumMovi_Ing_Egr = info.IdNumMovi;
                    info_MoviInve.IdMotivo_inv = info.IdMotivo_Inv;

                    //detalle
                    List<in_movi_inve_detalle_Info> list_inveDet = new List<in_movi_inve_detalle_Info>();

                    foreach (var item in info.listIng_Egr)
                    {
                        in_movi_inve_detalle_Info infoMovDet = new in_movi_inve_detalle_Info();
                        infoMovDet.IdProducto = item.IdProducto;
                        infoMovDet.dm_cantidad = item.dm_cantidad;
                        infoMovDet.dm_stock_ante = item.dm_stock_ante;
                        infoMovDet.dm_stock_actu = item.dm_stock_ante + item.dm_cantidad;
                        infoMovDet.dm_observacion = (item.dm_observacion == null) ? "" : item.dm_observacion;
                        infoMovDet.dm_precio = item.dm_precio;
                        infoMovDet.mv_costo = item.mv_costo;
                        infoMovDet.peso = item.dm_peso;
                        infoMovDet.IdCentroCosto = item.IdCentroCosto;
                        infoMovDet.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        infoMovDet.IdUnidadMedida = item.IdUnidadMedida;
                        infoMovDet.mv_costo_sinConversion = item.mv_costo_sinConversion;
                        infoMovDet.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                        infoMovDet.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                        infoMovDet.IdPunto_Cargo = item.IdPunto_cargo;
                        infoMovDet.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        infoMovDet.IdMotivo_Inv = item.IdMotivo_Inv;
                        //Campos para saber cual movimiento esta devolviendo este
                        infoMovDet.IdEmpresa_dev = item.IdEmpresa_dev;
                        infoMovDet.IdSucursal_dev = item.IdSucursal_dev;
                        infoMovDet.IdBodega_dev = item.IdBodega_dev;
                        infoMovDet.IdMovi_inven_tipo_dev = item.IdMovi_inven_tipo_dev;
                        infoMovDet.IdNumMovi_dev = item.IdNumMovi_dev;
                        infoMovDet.Secuencia_dev = item.Secuencia_dev;
                        infoMovDet.IdOrdenCompra = (item.IdOrdenCompra == null) ? 0 : Convert.ToDecimal(item.IdOrdenCompra);

                        list_inveDet.Add(infoMovDet);
                    }

                    info_MoviInve.listmovi_inve_detalle_Info = list_inveDet;

                    //detalle

                    in_movi_inve_Bus bus_MovInve = new in_movi_inve_Bus();
                    decimal idMoviInven;
                    idMoviInven = 0;
                    string mensaje_cbte_cble = "";

                    if (bus_MovInve.GrabarDB(info_MoviInve, ref idMoviInven, ref mensaje, ref mensaje_cbte_cble))
                    {
                        // actualizar item Movimientos en in_Ing_Egr_Inven_det  
                        foreach (var item in info_MoviInve.listmovi_inve_detalle_Info)
                        {
                            int conta = 0;
                            foreach (var item2 in info.listIng_Egr)
                            {
                                if (item2.IdEmpresa_inv == null && item2.IdSucursal_inv == null
                                    && item2.IdBodega_inv == null && item2.IdMovi_inven_tipo_inv == null
                                    && item2.IdNumMovi_inv == null && item2.secuencia_inv == null)
                                {
                                    item2.IdEmpresa_inv = item.IdEmpresa;
                                    item2.IdSucursal_inv = item.IdSucursal;
                                    item2.IdBodega_inv = item.IdBodega;
                                    item2.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo;
                                    item2.IdNumMovi_inv = idMoviInven;
                                    item2.secuencia_inv = item.Secuencia;

                                    conta = conta + 1;
                                    break;
                                }
                                if (conta > 0)
                                {
                                    item2.IdEmpresa_inv = null;
                                    item2.IdSucursal_inv = null;
                                    item2.IdBodega_inv = null;
                                    item2.IdMovi_inven_tipo_inv = null;
                                    item2.IdNumMovi_inv = null;
                                    item2.secuencia_inv = null;
                                    break;
                                }
                            }
                        }

                        string msgs = "";
                        // odata.ModificarCabecera_IdMovi_Inven_x_IngEgr(info, ref msgs);
                        in_Ing_Egr_Inven_det_Data odataDet = new in_Ing_Egr_Inven_det_Data();
                        odataDet.ModificarDetalle_IdMovi_Inven_x_IngEgr(info.listIng_Egr, ref msgs);
                    }
                    else
                    {
                        msg = mensaje + "-" + mensaje_cbte_cble;
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Genera_Inventario_x_IngEgr_Inven", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean ModificarDB_proceso_cerrado(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                return odata.ModificarDB_proceso_cerrado(info, ref msgs);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB_proceso_cerrado", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean ModificarDB_x_Ajuste(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                in_Ing_Egr_Inven_det_Data dataDet = new in_Ing_Egr_Inven_det_Data();
                in_Parametro_Bus busParam = new in_Parametro_Bus();
                in_Parametro_Info infoParam = new in_Parametro_Info();
                string IdEstadoAproba_Param = "";
                infoParam = busParam.Get_Info_Parametro(info.IdEmpresa);
                if (info.signo == "+")
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Ing;
                else
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Egr;

                Boolean res = false;

                if (Validar_objeto_IngEgr(info, ref mensaje))
                {
                    //arreglando los id del detalle en caso q no venga sin id
                    foreach (var item in info.listIng_Egr)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdNumMovi = info.IdNumMovi;
                        item.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                        item.signo = info.signo;

                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProdu = BusProducto.Get_info_Product(info.IdEmpresa, item.IdProducto);

                        if (item.IdEstadoAproba == null || item.IdEstadoAproba == "")
                        {
                            if (info.signo == "+")
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Ing;
                            else
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Egr;
                            item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);
                        }
                        if (item.IdUnidadMedida_sinConversion == null || item.IdUnidadMedida_sinConversion == "" || item.IdUnidadMedida == null || item.IdUnidadMedida == "")
                        {
                            item.IdUnidadMedida = InfoProdu.IdUnidadMedida;
                            item.IdUnidadMedida_Consumo = InfoProdu.IdUnidadMedida_Consumo;
                            item.IdUnidadMedida_sinConversion = InfoProdu.IdUnidadMedida;
                        }

                        #region Convierte costo y cantidad en la unidad de consumo
                        ValorEquiv = 0;
                        InfoUni_Equiv = busUni_Equiv.Get_Info_in_UnidadMedida_Equiv_conversion(item.IdUnidadMedida_sinConversion, InfoProdu.IdUnidadMedida_Consumo);
                        ValorEquiv = InfoUni_Equiv.valor_equiv == 0 ? 1 : InfoUni_Equiv.valor_equiv;
                        item.dm_cantidad = item.dm_cantidad_sinConversion * ValorEquiv;
                        item.mv_costo = item.mv_costo_sinConversion / ValorEquiv;
                        item.IdUnidadMedida = InfoProdu.IdUnidadMedida_Consumo;
                        #endregion
                    }

                    if (dataDet.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega == null ? 0 : (int)info.IdBodega, info.IdNumMovi, info.IdMovi_inven_tipo, ref msgs))
                    {
                        info.IdUsuarioUltModi = param.IdUsuario;

                        if (odata.ModificarDB(info, ref msgs))
                        {
                            foreach (var item in info.listIng_Egr)
                            {
                                item.Secuencia = 0;

                                item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);

                                if (item.IdEmpresa == null || item.IdEmpresa == 0)
                                    item.IdEmpresa = Convert.ToInt32(info.IdEmpresa);

                                if (item.IdSucursal == null || item.IdSucursal == 0)
                                    item.IdSucursal = Convert.ToInt32(info.IdSucursal);

                                if (item.IdBodega == null || item.IdBodega == 0)
                                    item.IdBodega = Convert.ToInt32(info.IdBodega);

                                if (item.IdMovi_inven_tipo == null || item.IdMovi_inven_tipo == 0)
                                    item.IdMovi_inven_tipo = Convert.ToInt32(info.IdMovi_inven_tipo);

                                if (item.IdNumMovi == null || item.IdNumMovi == 0)
                                    item.IdNumMovi = Convert.ToInt32(info.IdNumMovi);
                            }
                            //Guarda en la tabla in_Ing_Egr_Inven_det
                            if (dataDet.GuardarDB(info.listIng_Egr))
                            {
                                res = true;
                                res = procesoGenerarMoviInve(info, info.IdNumMovi, ref mensaje);
                            }
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean ModificarDB(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                in_Ing_Egr_Inven_det_Data dataDet = new in_Ing_Egr_Inven_det_Data();
                in_Parametro_Bus busParam = new in_Parametro_Bus();
                in_Parametro_Info infoParam = new in_Parametro_Info();

                string IdEstadoAproba_Param = "";

                infoParam = busParam.Get_Info_Parametro(info.IdEmpresa);
                if (info.signo == "+")
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Ing;
                else
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Egr;

                Boolean res = false;

                if (Validar_objeto_IngEgr(info, ref mensaje))
                {
                    //arreglando los id del detalle en caso q no venga sin id
                    foreach (var item in info.listIng_Egr)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdNumMovi = info.IdNumMovi;
                        item.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                        item.signo = info.signo;

                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProdu = BusProducto.Get_info_Product(info.IdEmpresa, item.IdProducto);

                        if (item.IdEstadoAproba == null || item.IdEstadoAproba == "")
                        {
                            if (info.signo == "+")
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Ing;
                            else
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Egr;
                            item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);
                        }
                        if (item.IdUnidadMedida_sinConversion == null || item.IdUnidadMedida_sinConversion == "" || item.IdUnidadMedida == null || item.IdUnidadMedida == "")
                        {
                            item.IdUnidadMedida = InfoProdu.IdUnidadMedida;
                            item.IdUnidadMedida_Consumo = InfoProdu.IdUnidadMedida_Consumo;
                            item.IdUnidadMedida_sinConversion = InfoProdu.IdUnidadMedida;
                        }
                        if (item.mv_costo_sinConversion == 0 || item.signo == "-")
                        {
                            in_producto_x_tb_bodega_Costo_Historico_Bus BusProd_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                            in_producto_x_tb_bodega_Costo_Historico_Info Info_Produc_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();
                            Info_Produc_x_Costo = BusProd_x_Costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal, Convert.ToInt32(item.IdBodega), item.IdProducto, info.cm_fecha);
                            item.mv_costo = Info_Produc_x_Costo.costo;
                            item.mv_costo_sinConversion = Info_Produc_x_Costo.costo;
                        }

                        #region Convierte costo y cantidad en la unidad de consumo
                        ValorEquiv = 0;
                        InfoUni_Equiv = busUni_Equiv.Get_Info_in_UnidadMedida_Equiv_conversion(item.IdUnidadMedida_sinConversion, InfoProdu.IdUnidadMedida_Consumo);
                        ValorEquiv = InfoUni_Equiv.valor_equiv == 0 ? 1 : InfoUni_Equiv.valor_equiv;
                        item.dm_cantidad = item.dm_cantidad_sinConversion * ValorEquiv;
                        item.mv_costo = item.mv_costo_sinConversion / ValorEquiv;
                        item.IdUnidadMedida = InfoProdu.IdUnidadMedida_Consumo;
                        #endregion

                        #region Maneja numero de lote

                        if (Convert.ToBoolean(InfoParam.P_Maneja_Lote) && BusProducto.Producto_maneja_lote(param.IdEmpresa, item.IdProducto))
                        {
                            if (info.signo == "+")
                            {
                                if (string.IsNullOrEmpty(item.Lote))
                                {
                                    int anio;
                                    int mes;
                                    int dia;
                                    int hora;
                                    int minuto;
                                    int sec;

                                    anio = info.Fecha_Transac.Year;
                                    mes = info.Fecha_Transac.Month;
                                    dia = info.Fecha_Transac.Day;
                                    hora = info.Fecha_Transac.TimeOfDay.Hours;
                                    minuto = info.Fecha_Transac.TimeOfDay.Minutes;
                                    sec = info.Fecha_Transac.TimeOfDay.Seconds;

                                    item.Lote = anio.ToString("0000") + mes.ToString("00") + dia.ToString("00") + hora.ToString("00") + minuto.ToString("00") + sec.ToString("00") + param.InfoSucursal.codigo;
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(item.Lote))
                                {
                                    //obtener numero de lote automatico de existencia en inventario
                                }
                            }
                        }

                        #endregion 
                    }

                    if (dataDet.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega == null ? 0 : (int)info.IdBodega, info.IdNumMovi, info.IdMovi_inven_tipo, ref msgs))
                    {
                        info.IdUsuarioUltModi = param.IdUsuario;

                        if (odata.ModificarDB(info, ref msgs))
                        {
                            foreach (var item in info.listIng_Egr)
                            {
                                //item.Secuencia = 0;

                                string IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);

                                if (item.IdEstadoAproba == null)
                                    item.IdEstadoAproba = IdEstadoAproba;

                                if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                                    item.Motivo_Aprobacion = null;
                                else
                                    item.Motivo_Aprobacion = (item.Motivo_Aprobacion == null) ? "APROBADO POR SISTEMAS" : item.Motivo_Aprobacion;

                                if (item.IdEmpresa == null || item.IdEmpresa == 0)
                                    item.IdEmpresa = Convert.ToInt32(info.IdEmpresa);

                                if (item.IdSucursal == null || item.IdSucursal == 0)
                                    item.IdSucursal = Convert.ToInt32(info.IdSucursal);

                                if (item.IdBodega == null || item.IdBodega == 0)
                                    item.IdBodega = Convert.ToInt32(info.IdBodega);

                                if (item.IdMovi_inven_tipo == null || item.IdMovi_inven_tipo == 0)
                                    item.IdMovi_inven_tipo = Convert.ToInt32(info.IdMovi_inven_tipo);

                                if (item.IdNumMovi == null || item.IdNumMovi == 0)
                                    item.IdNumMovi = Convert.ToInt32(info.IdNumMovi);
                            }
                            //Guarda en la tabla in_Ing_Egr_Inven_det
                            if (dataDet.GuardarDB(info.listIng_Egr))
                            {
                                res = true;
                                res = procesoGenerarMoviInve(info, info.IdNumMovi, ref mensaje);
                            }
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean ModificarDB_x_OrdenProduccion(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                in_Ing_Egr_Inven_det_Data dataDet = new in_Ing_Egr_Inven_det_Data();
                in_Parametro_Bus busParam = new in_Parametro_Bus();
                in_Parametro_Info infoParam = new in_Parametro_Info();
                string IdEstadoAproba_Param = "";

                infoParam = busParam.Get_Info_Parametro(info.IdEmpresa);

                if (info.signo == "+")
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Ing;
                else
                    IdEstadoAproba_Param = infoParam.IdEstadoAproba_x_Egr;

                Boolean res = false;

                if (Validar_objeto_IngEgr(info, ref mensaje))
                {
                    //arreglando los id del detalle en caso q no venga sin id
                    foreach (var item in info.listIng_Egr)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdNumMovi = info.IdNumMovi;
                        item.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                        item.signo = info.signo;

                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProdu = BusProducto.Get_info_Product(info.IdEmpresa, item.IdProducto);

                        if (item.IdEstadoAproba == null || item.IdEstadoAproba == "")
                        {
                            if (info.signo == "+")
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Ing;
                            else
                                IdEstadoAproba_Param = InfoParam.IdEstadoAproba_x_Egr;
                            item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);
                        }
                        if (item.IdUnidadMedida_sinConversion == null || item.IdUnidadMedida_sinConversion == "" || item.IdUnidadMedida == null || item.IdUnidadMedida == "")
                        {
                            item.IdUnidadMedida = InfoProdu.IdUnidadMedida;
                            item.IdUnidadMedida_Consumo = InfoProdu.IdUnidadMedida_Consumo;
                            item.IdUnidadMedida_sinConversion = InfoProdu.IdUnidadMedida;
                        }
                        if (item.mv_costo_sinConversion == 0 || item.signo == "-")
                        {
                            in_producto_x_tb_bodega_Costo_Historico_Bus BusProd_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                            in_producto_x_tb_bodega_Costo_Historico_Info Info_Produc_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();
                            Info_Produc_x_Costo = BusProd_x_Costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, item.IdSucursal, Convert.ToInt32(item.IdBodega), item.IdProducto, info.cm_fecha);
                            item.mv_costo = Info_Produc_x_Costo.costo;
                            item.mv_costo_sinConversion = Info_Produc_x_Costo.costo;
                        }

                        #region Convierte costo y cantidad en la unidad de consumo
                        //ValorEquiv = 0;
                        //InfoUni_Equiv = busUni_Equiv.Get_Info_in_UnidadMedida_Equiv_conversion(item.IdUnidadMedida_sinConversion, InfoProdu.IdUnidadMedida_Consumo);
                        //ValorEquiv = InfoUni_Equiv.valor_equiv == 0 ? 1 : InfoUni_Equiv.valor_equiv;
                        //item.dm_cantidad = item.dm_cantidad_sinConversion * ValorEquiv;
                        //item.mv_costo = item.mv_costo_sinConversion / ValorEquiv;

                        item.mv_costo = item.mv_costo_sinConversion / 1;
                        item.IdUnidadMedida = InfoProdu.IdUnidadMedida_Consumo;
                        #endregion
                    }

                    if (dataDet.EliminarDB(info.IdEmpresa, info.IdSucursal, info.IdBodega == null ? 0 : (int)info.IdBodega, info.IdNumMovi, info.IdMovi_inven_tipo, ref msgs))
                    {
                        info.IdUsuarioUltModi = param.IdUsuario;

                        if (odata.ModificarDB(info, ref msgs))
                        {
                            foreach (var item in info.listIng_Egr)
                            {
                                item.Secuencia = 0;

                                item.IdEstadoAproba = Get_EstadoApro(Convert.ToInt32(info.IdEmpresa), Convert.ToInt32(info.IdSucursal), Convert.ToInt32(info.IdBodega), IdEstadoAproba_Param);

                                if (item.IdEmpresa == null || item.IdEmpresa == 0)
                                    item.IdEmpresa = Convert.ToInt32(info.IdEmpresa);

                                if (item.IdSucursal == null || item.IdSucursal == 0)
                                    item.IdSucursal = Convert.ToInt32(info.IdSucursal);

                                if (item.IdBodega == null || item.IdBodega == 0)
                                    item.IdBodega = Convert.ToInt32(info.IdBodega);

                                if (item.IdMovi_inven_tipo == null || item.IdMovi_inven_tipo == 0)
                                    item.IdMovi_inven_tipo = Convert.ToInt32(info.IdMovi_inven_tipo);

                                if (item.IdNumMovi == null || item.IdNumMovi == 0)
                                    item.IdNumMovi = Convert.ToInt32(info.IdNumMovi);
                            }
                            //Guarda en la tabla in_Ing_Egr_Inven_det
                            if (dataDet.GuardarDB(info.listIng_Egr))
                            {
                                res = true;
                                res = procesoGenerarMoviInve(info, info.IdNumMovi, ref mensaje);
                            }
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean ModificarCabecera_IdMovi_Inven_x_IngEgr(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                return odata.ModificarCabecera_IdMovi_Inven_x_IngEgr(info, ref msgs);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarCabecera_IdMovi_Inven_x_IngEgr", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean AnularDB(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                in_Ing_Egr_Inven_det_Bus BusDeta_Ing_Egr_Inven = new in_Ing_Egr_Inven_det_Bus();
                List<in_Ing_Egr_Inven_det_Info> ListDet_Ing_Egr_Inven_det = new List<in_Ing_Egr_Inven_det_Info>();
                Boolean Respuesta_anulacion = false;
                Boolean Respuesta_anulacion_Inventario = false;

                in_movi_inven_tipo_Info info_movi_inven_tipo = new in_movi_inven_tipo_Info();
                in_movi_inven_tipo_Bus bus_movi_inven_tipo = new in_movi_inven_tipo_Bus();
                info_movi_inven_tipo = bus_movi_inven_tipo.Get_Info_movi_inven_tipo(info.IdEmpresa, info.IdMovi_inven_tipo);

                in_Motivo_Inven_Info info_motivo_inven = new in_Motivo_Inven_Info();
                in_Motivo_Inven_Bus bus_motivo_inven = new in_Motivo_Inven_Bus();
                info_motivo_inven = bus_motivo_inven.Get_Info_Motivo_Inven(info.IdEmpresa, info.IdMotivo_Inv == null ? 0 : Convert.ToInt32(info.IdMotivo_Inv));

                string genero_movi = info_movi_inven_tipo.Genera_Movi_Inven == true && info_motivo_inven.Genera_Movi_Inven == "S" ? "S" : "N";

                if (info.IdEstadoAproba == "APRO")
                    odata.Reversar_Aprobacion(info.IdEmpresa, info.IdSucursal, info.IdMovi_inven_tipo, info.IdNumMovi, genero_movi);

                Respuesta_anulacion = odata.AnularDB(info, ref msgs);

                if (Respuesta_anulacion)
                {
                    ListDet_Ing_Egr_Inven_det = BusDeta_Ing_Egr_Inven.Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(info.IdEmpresa, info.IdSucursal, info.IdMovi_inven_tipo, info.IdNumMovi);

                    in_movi_inve_Bus BusMovi_Inven = new in_movi_inve_Bus();
                    in_movi_inve_Info Info_movi_inve_a_Anular = new in_movi_inve_Info();

                    //EJEMPLO DE AGRUPAR
                    var select_ListDet_Ing_Egr_Inven_det = from T in ListDet_Ing_Egr_Inven_det
                                                           group T by new
                                                           {
                                                               T.IdEmpresa_inv,
                                                               T.IdSucursal_inv,
                                                               T.IdBodega_inv,
                                                               T.IdMovi_inven_tipo_inv,
                                                               T.IdNumMovi_inv
                                                           }
                                      into grouping
                                                           select new { grouping.Key };

                    foreach (var item in select_ListDet_Ing_Egr_Inven_det)
                    {
                        if (item.Key.IdNumMovi_inv != null)
                        {
                            Info_movi_inve_a_Anular = new in_movi_inve_Info();

                            Info_movi_inve_a_Anular = BusMovi_Inven.Get_Info_Movi_inven(Convert.ToInt32(item.Key.IdEmpresa_inv), Convert.ToInt32(item.Key.IdSucursal_inv), Convert.ToInt32(item.Key.IdBodega_inv), Convert.ToInt32(item.Key.IdMovi_inven_tipo_inv), Convert.ToDecimal(item.Key.IdNumMovi_inv));
                            if (Info_movi_inve_a_Anular != null)
                            {
                                if (Info_movi_inve_a_Anular.IdEmpresa != 0)
                                {
                                    Respuesta_anulacion_Inventario = BusMovi_Inven.AnularDB(Info_movi_inve_a_Anular, info.Fecha_UltAnu, ref msgs);
                                }
                                else
                                {
                                    Respuesta_anulacion_Inventario = true;//por que puede q no haya movi invent
                                }
                            }
                        }
                        else
                            Respuesta_anulacion_Inventario = true;
                    }
                }

                //Agrupo lista de ordenes de compra
                var lst_oc = (from q in ListDet_Ing_Egr_Inven_det
                              where q.IdOrdenCompra != null
                              group q by new { q.IdEmpresa_oc, q.IdSucursal_oc, q.IdOrdenCompra }
                                  into grouping
                              select new { grouping.Key.IdEmpresa_oc, grouping.Key.IdSucursal_oc, grouping.Key.IdOrdenCompra }
                          ).ToList();

                BusDeta_Ing_Egr_Inven.Modificar_Enserar_Campos_OC(ListDet_Ing_Egr_Inven_det);

                foreach (var item in lst_oc)
                {
                    bus_oc.Modificar_Estado_Cierre(Convert.ToInt32(item.IdEmpresa_oc), Convert.ToInt32(item.IdSucursal_oc), Convert.ToInt32(item.IdOrdenCompra), "ABI");
                }

                return Respuesta_anulacion && Respuesta_anulacion_Inventario;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean Existe_NumGuia(int IdEmpresa, string numGuia, ref string msgs)
        {
            try
            {
                in_Ing_Egr_Inven_Data Data = new in_Ing_Egr_Inven_Data();

                if (Data.Existe_NumGuia(IdEmpresa, numGuia, ref mensaje))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_multi_bodega(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven_multi_bodega(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaIni, FechaFin, Tipo_ing_egr);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_Inven_multi_bodega", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr = "")
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, FechaIni, FechaFin, Tipo_ing_egr);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_x_Requerimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr = "")
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, FechaIni, FechaFin, Tipo_ing_egr);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin, int IdMovi_inven_tipo)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, FechaIni, FechaFin, IdMovi_inven_tipo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_x_in_movi_inve(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven_x_in_movi_inve(IdEmpresa, IdSucursal, FechaIni, FechaFin, Tipo_ing_egr);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public in_Ing_Egr_Inven_Info Get_Info_Ing_Egr_Inven_x_in_movi_inve(int IdEmpresa, int IdSucursal, int IdMovi_inve_tipo, decimal IdNumMovi)
        {
            try
            {
                return odata.Get_Info_Ing_Egr_Inven_x_in_movi_inve(IdEmpresa, IdSucursal, IdMovi_inve_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean Reversar_Aprobacion(int IdEmpresa, int IdSucursal, int IdMovi_inve_tipo, decimal IdNumMovi, string Genera_movi_inven)
        {
            try
            {
                return odata.Reversar_Aprobacion(IdEmpresa, IdSucursal, IdMovi_inve_tipo, IdNumMovi, Genera_movi_inven);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursal, int IdBodega, int IdTipoMovi, string Tipo_ing_egr)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven(IdEmpresa, IdSucursal, IdBodega, IdTipoMovi, Tipo_ing_egr);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_Inven", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public in_Ing_Egr_Inven_Info Get_Info_Ing_Egr_Inven(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                return odata.Get_Info_Ing_Egr_Inven(IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultarInfo", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean ModificarDB_desde_transferencia(in_Ing_Egr_Inven_Info info)
        {
            try
            {
                return odata.ModificarDB_desde_transferencia(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB_desde_transferencia", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_para_devolucion(int IdEmpresa, int IdSucursal, int IdTipoMovi, string signo, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return odata.Get_List_Ing_Egr_Inven_para_devolucion(IdEmpresa, IdSucursal, IdTipoMovi, signo, Fecha_ini, Fecha_fin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB_desde_transferencia", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public Boolean EliminarDB(in_Ing_Egr_Inven_Info info, ref string mensaje)
        {
            try
            {
                return odata.EliminarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public string Validar_Stock(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, double dCantidad)
        {
            try
            {
                return odata.Validar_Stock(IdEmpresa, IdSucursal, IdBodega, IdProducto, dCantidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public double Obtener_Stock_x_FechaMovimiento(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime FechaMovimiento)
        {            
            try
            {
                return odata.Obtener_Stock_x_FechaMovimiento(IdEmpresa, IdSucursal, IdBodega, IdProducto, FechaMovimiento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}