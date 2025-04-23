using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Compras;
using Bizu.Domain.Compras;
using Bizu.Domain.General;
using Bizu.Application.General;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;


namespace Bizu.Application.Compras
{
    public class com_ordencompra_local_Bus
    {
        #region declaracion de variable
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_ordencompra_local_Data BusOC = new com_ordencompra_local_Data();
        com_ordencompra_local_det_Data BusOC_det = new com_ordencompra_local_det_Data();
        com_Catalogo_Bus CatCom = new com_Catalogo_Bus();
        com_TerminoPago_Bus BusTerPago = new com_TerminoPago_Bus();
        com_ordencompra_local_det_Bus BusDetOC = new com_ordencompra_local_det_Bus();
        List<com_ordencompra_local_det_Info> templst = new List<com_ordencompra_local_det_Info>();
        #endregion

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa)
        {
            try
            {
                string msg = "";
                return BusOC.Get_List_ordencompra_local(IdEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public com_ordencompra_local_Info Get_Info_ordencompra_local(int IdEmpresa, int IdSucursal, decimal IdOrdencompra)
        {
            try
            {
                return BusOC.Get_Info_ordencompra_local(IdEmpresa, IdSucursal, IdOrdencompra);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_ordencompra_local", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };

            }

        }
        
        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_x_Solicitud(IdEmpresa, IdSucursal, IdSolicitudCompra);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_x_Solicitud", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string EstadoAprob, string Estado)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local(IdEmpresa, FechaIni, FechaFin, EstadoAprob, Estado);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Cerrar(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string EstadoAprob)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_x_Cerrar(IdEmpresa, FechaIni, FechaFin, EstadoAprob);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_x_Proveedor(IdEmpresa, IdProveedor);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_x_Proveedor", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }


        }

        public Boolean Validar_objeto(com_ordencompra_local_Info Info, ref string msg)
        {

            try
            {
                if (Info.IdEmpresa == 0 || Info.IdSucursal == 0 || Info.IdProveedor == 0 || Info.IdDepartamento == 0)
                {
                    msg = "las variables estan en cero... Info.IdEmpresa == 0 || Info.IdSucursal == 0 || Info.IdProveedor == 0 || Info.IdDepartamento == 0 ";
                    return false;
                }
                /*
                if (Info.IdMotivo == null || Info.IdMotivo == 0)
                {
                    msg = "Ingrese el motivo de la Compra";
                    com_Catalogo_Bus bUS = new com_Catalogo_Bus();
                    List<com_Catalogo_Info> listc = new List<com_Catalogo_Info>(bUS.Get_List_Catalogo());
                    return false;

                }*/

                if (Info.listDetalle.Count == 0)
                {
                    msg = "la OC no tiene items q grabar";
                    return false;
                }

                int c = 0;

                foreach (var item in Info.listDetalle)
                {
                    if (item.do_Cantidad == 0)
                    {
                        msg = "Ingrese la cantidad al item : " + item.codproducto + "  ";
                        return false;
                    }

                    if (item.do_precioCompra == 0)
                    {
                        msg = "Ingrese el costo al item : " + item.codproducto + "  ";
                        return false;
                    }

                    if (item.IdUnidadMedida == "" || item.IdUnidadMedida == null)
                    {
                        in_producto_Bus BusProducto = new in_producto_Bus();
                        in_Producto_Info InfoProducto = new in_Producto_Info();
                        InfoProducto = BusProducto.Get_info_Product(item.IdEmpresa, item.IdProducto);
                        item.IdUnidadMedida = InfoProducto.IdUnidadMedida;
                    }


                    if (item.IdCentroCosto == "")
                    {
                        item.IdCentroCosto = null;
                    }

                    if (item.IdCentroCosto_sub_centro_costo == "")
                    {
                        item.IdCentroCosto_sub_centro_costo = null;
                    }

                    if (item.IdCod_Impuesto == "" || item.IdCod_Impuesto == null) // Arreglando si no viene iva y codigo de iva
                    {
                        tb_sis_impuesto_Bus BusImpuestoIva = new tb_sis_impuesto_Bus();
                        List<tb_sis_impuesto_Info> ListInfo_Impuesto = new List<tb_sis_impuesto_Info>();
                        tb_sis_impuesto_Info Info_Impuesto = new tb_sis_impuesto_Info();
                        ListInfo_Impuesto = BusImpuestoIva.Get_List_impuesto_para_Compras("IVA");

                        Info_Impuesto = ListInfo_Impuesto.FirstOrDefault();
                        item.IdCod_Impuesto = Info_Impuesto.IdCod_Impuesto;
                        item.Por_Iva = Info_Impuesto.porcentaje;
                    }


                    //item.do_ManejaIva = (item.do_iva == 0) ? false : true;
                    c = c + 1;
                    item.Secuencia = c;


                    item.IdEmpresa = Info.IdEmpresa;
                    item.IdSucursal = Info.IdSucursal;
                    item.IdOrdenCompra = Info.IdOrdenCompra;

                }

                if (Info.IdMotivo == 0 && Info.IdMotivo == null)
                {
                    //consulta motivo compra
                    com_Motivo_Orden_Compra_Data odataMoti = new com_Motivo_Orden_Compra_Data();
                    List<com_Motivo_Orden_Compra_Info> listMoti = new List<com_Motivo_Orden_Compra_Info>();

                    listMoti = odataMoti.Get_List_Motivo_Orden_Compra(Info.IdEmpresa);
                    var itemMoti = listMoti.FirstOrDefault(q => q.IdMotivo == Info.IdMotivo);
                    Info.IdMotivo = itemMoti.IdMotivo;
                }


                if (Info.IdEstadoAprobacion_cat == "" || Info.IdEstadoAprobacion_cat == null)
                {
                    List<com_Catalogo_Info> listEstadoAproba = new List<com_Catalogo_Info>();
                    listEstadoAproba = CatCom.Get_ListEstadoAprobacion();
                    com_Catalogo_Info resEstadoApro = new com_Catalogo_Info();
                    resEstadoApro = listEstadoAproba.FirstOrDefault();
                    Info.IdEstadoAprobacion_cat = resEstadoApro.IdCatalogocompra;
                }

                if (Info.IdEstadoRecepcion_cat == "" || Info.IdEstadoRecepcion_cat == null)
                {
                    List<com_Catalogo_Info> listEstadoRecep = new List<com_Catalogo_Info>();
                    com_Catalogo_Info resEstadoRece = new com_Catalogo_Info();
                    listEstadoRecep = CatCom.Get_ListEstadoRecepcion();
                    resEstadoRece = listEstadoRecep.First();
                    Info.IdEstadoRecepcion_cat = resEstadoRece.IdCatalogocompra;
                }


                if (Info.IdTerminoPago == "" || Info.IdTerminoPago == null)
                {
                    List<com_TerminoPago_Info> listTerminoPago = new List<com_TerminoPago_Info>();
                    listTerminoPago = BusTerPago.Get_List_TerminoPago();
                    com_TerminoPago_Info TerminoPago = new com_TerminoPago_Info();
                    TerminoPago = listTerminoPago.FirstOrDefault();
                    Info.IdTerminoPago = TerminoPago.IdTerminoPago;
                }


                if (Info.IdEstado_cierre == null || Info.IdEstado_cierre == "")
                {
                    com_estado_cierre_Bus busEstCierre = new com_estado_cierre_Bus();
                    com_parametro_Bus paraBus = new com_parametro_Bus();
                    string idestadoCierrexDefault = "";
                    idestadoCierrexDefault = paraBus.Get_List_parametro(Info.IdEmpresa).FirstOrDefault().IdEstado_cierre;
                    Info.IdEstado_cierre = busEstCierre.Get_List_estado_cierre().FirstOrDefault(v => v.IdEstado_cierre == idestadoCierrexDefault).IdEstado_cierre;
                }

                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Validar_objeto", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public Boolean GuardarDB(com_ordencompra_local_Info Info, ref decimal id, ref string msg)
        {
            try
            {
                Boolean res = true;
                bool flag = true;

                if (!this.Validar_objeto(Info, ref msg))
                {
                    return false;
                }

                flag = this.BusOC.GuardarDB(Info, ref id);
                foreach (com_ordencompra_local_det_Info info in Info.listDetalle)
                {
                    info.IdEmpresa = Info.IdEmpresa;
                    info.IdSucursal = Info.IdSucursal;
                    info.IdOrdenCompra = id;

                    switch (info.IdCod_Impuesto)
                    {
                        case "IVA0":
                            info.Por_Iva = 0.0;
                            break;
                        case "IVA12":
                            info.Por_Iva = 12.0;
                            break;
                        case "IVA14":
                            info.Por_Iva = 14.0;
                            break;
                        case "IVA15":
                            info.Por_Iva = 15.0;
                            break;
                    }
                }
                flag = this.BusOC_det.GuardarDB(Info.listDetalle, ref msg);

                //GRABAMOS ORDEN DE COMPRA POR SOLICITUD
                if (Info.lista_OC_x_Solicitud.Count > 0)
                {
                    foreach (var item in Info.lista_OC_x_Solicitud)
                    {
                        item.IdEmpresa_oc = Info.IdEmpresa;
                        item.IdSucursal_oc = Info.IdSucursal;
                        item.IdOrdenCompra_oc = Info.IdOrdenCompra;
                    }

                    com_ordencompra_local_x_com_solicitud_compra_Bus Bus_com_ordencompra_local_x_com_solicitud_compra = new com_ordencompra_local_x_com_solicitud_compra_Bus();
                    Bus_com_ordencompra_local_x_com_solicitud_compra.Grabar(Info.lista_OC_x_Solicitud, ref mensaje);

                    foreach (var item in Info.listDetalle)
                    {
                        if (item.List_com_solicitud_compra_det != null)
                        {
                            foreach (com_solicitud_compra_det_Info info4 in item.List_com_solicitud_compra_det)
                            {
                                com_ordencompra_local_det_x_com_solicitud_compra_det_Info Info_oc_x_sc_det = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info
                                {
                                    ocd_IdEmpresa = item.IdEmpresa,
                                    ocd_IdSucursal = item.IdSucursal,
                                    ocd_IdOrdenCompra = item.IdOrdenCompra,
                                    ocd_Secuencia = item.Secuencia,
                                    scd_IdEmpresa = info4.IdEmpresa,
                                    scd_IdSucursal = info4.IdSucursal,
                                    scd_IdSolicitudCompra = Convert.ToDecimal(info4.IdSolicitudCompra),
                                    scd_Secuencia = info4.Secuencia
                                };
                                Info.lista_OC_x_Solicitud_det.Add(Info_oc_x_sc_det);
                            }
                        }
                    }

                    com_ordencompra_local_det_x_com_solicitud_compra_det_Bus Bus_com_ordencompra_local_det_x_com_solicitud_compra_det = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
                    Bus_com_ordencompra_local_det_x_com_solicitud_compra_det.GrabarDB(Info.lista_OC_x_Solicitud_det, ref mensaje);
                }

                if (Info.listDetSoliciComp.Count() != 0)
                {
                    // consulto detalle orden compra
                    com_ordencompra_local_det_Data odata = new com_ordencompra_local_det_Data();
                    List<com_ordencompra_local_det_Info> listDetComp = new List<com_ordencompra_local_det_Info>();
                    listDetComp = odata.Get_List_ordencompra_local_det(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra);

                    List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listDetCompra = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
                    List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listDetSoliCompra = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

                    foreach (var item in listDetComp)
                    {
                        com_ordencompra_local_det_x_com_solicitud_compra_det_Info info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();
                        info.ocd_IdEmpresa = item.IdEmpresa;
                        info.ocd_IdSucursal = item.IdSucursal;
                        info.ocd_IdOrdenCompra = item.IdOrdenCompra;
                        info.ocd_Secuencia = item.Secuencia;
                        listDetCompra.Add(info);
                    }

                    foreach (var item in Info.listDetSoliciComp)
                    {
                        com_ordencompra_local_det_x_com_solicitud_compra_det_Info info = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info();
                        info.scd_IdEmpresa = item.IdEmpresa;
                        info.scd_IdSucursal = item.IdSucursal;
                        info.scd_IdSolicitudCompra = item.IdSolicitudCompra;
                        info.scd_Secuencia = item.Secuencia;
                        listDetSoliCompra.Add(info);
                    }

                    foreach (var item in listDetCompra)
                    {
                        var items = listDetSoliCompra.First(v => v.ocd_IdEmpresa == 0 && v.ocd_IdSucursal == 0 && v.ocd_IdOrdenCompra == 0 && v.ocd_Secuencia == 0);
                        item.scd_IdEmpresa = items.scd_IdEmpresa;
                        item.scd_IdSucursal = items.scd_IdSucursal;
                        item.scd_IdSolicitudCompra = items.scd_IdSolicitudCompra;
                        item.scd_Secuencia = items.scd_Secuencia;
                        listDetSoliCompra.Remove(items);
                    }

                    com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Inter = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
                    if (bus_Inter.GrabarDB(listDetCompra, ref mensaje))
                    {
                    }
                    
                
                }
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }

            return true;
        }

        public Boolean ModificarDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                Boolean resp1 = true;


                if (Validar_objeto(Info, ref msg))
                {
                    resp1 = BusOC.ModificarDB(Info, ref msg);

                    List<com_ordencompra_local_det_Info> generados = new List<com_ordencompra_local_det_Info>();
                    List<com_ordencompra_local_det_Info> agregados = new List<com_ordencompra_local_det_Info>();
                    in_Guia_x_traspaso_bodega_det_Info info_guia = new in_Guia_x_traspaso_bodega_det_Info();
                    in_Guia_x_traspaso_bodega_det_Bus bus_guia = new in_Guia_x_traspaso_bodega_det_Bus();
                    com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Inter = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
                    com_ordencompra_local_x_com_solicitud_compra_Bus bus_OC_x_Solicitud = new com_ordencompra_local_x_com_solicitud_compra_Bus();

                    string sGuias = "";
                    if (!bus_guia.Existe_OC_en_guia(Info, ref sGuias))
                    {
                        //ELIMINAMOS LA TABLA INTERMEDIA ENTRE ORDEN DE COMPRA Y SOLICITUD DE COMPRA
                        if (bus_OC_x_Solicitud.Eliminar(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra))
                        {
                            if (bus_Inter.Eliminar_Detalle_OCDxSCD(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra, ref msg))
                            {

                            }
                        }

                        if (BusDetOC.EliminarDetalle_OC(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra, ref msg))
                        {
                            resp1 = BusOC_det.GuardarDB(Info.listDetalle, ref msg);


                            //GRABAMOS ORDEN DE COMPRA POR SOLICITUD
                            if (Info.lista_OC_x_Solicitud.Count > 0)
                            {
                                foreach (var item in Info.lista_OC_x_Solicitud)
                                {
                                    item.IdEmpresa_oc = Info.IdEmpresa;
                                    item.IdSucursal_oc = Info.IdSucursal;
                                    item.IdOrdenCompra_oc = Info.IdOrdenCompra;
                                }

                                com_ordencompra_local_x_com_solicitud_compra_Bus Bus_com_ordencompra_local_x_com_solicitud_compra = new com_ordencompra_local_x_com_solicitud_compra_Bus();
                                Bus_com_ordencompra_local_x_com_solicitud_compra.Grabar(Info.lista_OC_x_Solicitud, ref mensaje);

                                foreach (var info3 in Info.listDetalle)
                                {
                                    if (info3.List_com_solicitud_compra_det != null)
                                    {
                                        foreach (com_solicitud_compra_det_Info info4 in info3.List_com_solicitud_compra_det)
                                        {
                                            com_ordencompra_local_det_x_com_solicitud_compra_det_Info item = new com_ordencompra_local_det_x_com_solicitud_compra_det_Info
                                            {
                                                ocd_IdEmpresa = info3.IdEmpresa,
                                                ocd_IdSucursal = info3.IdSucursal,
                                                ocd_IdOrdenCompra = info3.IdOrdenCompra,
                                                ocd_Secuencia = info3.Secuencia,
                                                scd_IdEmpresa = info4.IdEmpresa,
                                                scd_IdSucursal = info4.IdSucursal,
                                                scd_IdSolicitudCompra = Convert.ToDecimal(info4.IdSolicitudCompra),
                                                scd_Secuencia = info4.Secuencia
                                            };
                                            Info.lista_OC_x_Solicitud_det.Add(item);
                                        }
                                    }
                                }

                                com_ordencompra_local_det_x_com_solicitud_compra_det_Bus Bus_com_ordencompra_local_det_x_com_solicitud_compra_det = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
                                Bus_com_ordencompra_local_det_x_com_solicitud_compra_det.GrabarDB(Info.lista_OC_x_Solicitud_det, ref mensaje);
                            }
                        }
                        else
                        {
                            // aqui existe guias con esta OC verifico q los registro sean los mismos para poder modificar la OC sino NO
                            com_ordencompra_local_Info InfoVali = new com_ordencompra_local_Info();
                            //InfoVali = BusOC.Get_Info_ordencompra_local_x_Total_RegOC_vs_Total_RegGuia(Info.IdEmpresa, Info.IdSucursal, Info.IdOrdenCompra);

                            resp1 = BusDetOC.ModificarDB(Info.listDetalle, ref msg);
                        }
                    }
                    else
                    { //

                        resp1 = false;

                    }
                }
                return resp1;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }
        
        public Boolean Modificar_Estado_Aprob(com_ordencompra_local_Info Info, ref  string msg)
        {

            try
            {
                return BusOC.Modificar_Estado_Aprob(Info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar_Estado_Aprob", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public Boolean Modificar_Estado_Recep(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                return BusOC.Modificar_Estado_Recep(Info, ref msg);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar_Estado_Recep", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }

        }

        public Boolean Modificar_Estado_Cierre(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, string Estado_cierre)
        {
            try
            {
                return BusOC.Modificar_Estado_Cierre(IdEmpresa, IdSucursal, IdOrdenCompra, Estado_cierre);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar_Estado_Cierre", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }


        }

        public Boolean AnularDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                Info.FechaHoraAnul = DateTime.Now;
                if (Info.IdUsuarioUltAnu == null)
                    Info.IdUsuarioUltAnu = "";
                return BusOC.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }

        }

        public Boolean VerificarCodigo(string NumDoc, int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return BusOC.VerificarCodigo(NumDoc, IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_devolver(int IdEmpresa, decimal IdProveedor, ref string msg)
        {
            try
            {
                return BusOC.Get_List_ordencompra_local_x_devolver(IdEmpresa, IdProveedor, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ordencompra_local_x_devolver", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }
        }

        public decimal GetId(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return BusOC.GetId(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(com_ordencompra_local_Bus) };
            }


        }

        public com_ordencompra_local_Bus()
        {

        }

    }
}