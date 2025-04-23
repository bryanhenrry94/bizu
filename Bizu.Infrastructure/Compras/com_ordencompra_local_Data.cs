using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Compras;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.Compras
{
    public class com_ordencompra_local_Data
    {
        string mensaje = "";

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa, ref string msg)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {
                var Select = from q in OEComp.com_ordencompra_local
                             where q.IdEmpresa == IdEmpresa
                             select q;
                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.IdProveedor;
                    OrdCompInfo.oc_NumDocumento = item.oc_NumDocumento;
                    OrdCompInfo.Tipo = item.Tipo;
                    OrdCompInfo.IdTerminoPago = item.IdTerminoPago;
                    OrdCompInfo.oc_plazo = item.oc_plazo;
                    OrdCompInfo.oc_fecha = item.oc_fecha;
                    OrdCompInfo.oc_flete = item.oc_flete;
                    OrdCompInfo.oc_observacion = item.oc_observacion;                    
                    OrdCompInfo.Estado = item.Estado;
                    OrdCompInfo.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                    OrdCompInfo.co_fecha_aprobacion = item.co_fecha_aprobacion;
                    OrdCompInfo.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    OrdCompInfo.IdUsuario_Reprue = item.IdUsuario_Reprue;
                    OrdCompInfo.co_fechaReproba = item.co_fechaReproba;
                    OrdCompInfo.Fecha_Transac = item.Fecha_Transac;
                    OrdCompInfo.Fecha_UltMod = item.Fecha_UltMod;
                    OrdCompInfo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    OrdCompInfo.FechaHoraAnul = item.FechaHoraAnul;
                    OrdCompInfo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    OrdCompInfo.IdEstadoRecepcion_cat = item.IdEstadoRecepcion_cat;
                    OrdCompInfo.AfectaCosto = item.AfectaCosto;
                    OrdCompInfo.MotivoReprobacion = item.MotivoReprobacion;
                    OrdCompInfo.Solicitante = item.Solicitante;
                    OrdCompInfo.oc_fechaVencimiento = Convert.ToDateTime(item.oc_fechaVencimiento);
                    OrdCompInfo.IdEstado_cierre = item.IdEstado_cierre;

                    Lst.Add(OrdCompInfo);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                msg = mensaje;
                throw new Exception(ex.ToString());
            }
        }
        
        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_devolver(int IdEmpresa, decimal IdProveedor, ref string msg)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {
                var Select = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                             where q.IdEmpresa == IdEmpresa
                             && q.IdProveedor == IdProveedor
                             && q.SaldoxDevolver > 0
                             group q by new { q.IdEmpresa, q.IdSucursal, q.IdOrdenCompra, q.oc_fecha, q.do_observacion, q.IdProveedor, q.pr_nombre, q.Su_Descripcion }
                                 into grouping
                             let count = grouping.Count()
                             select new { grouping.Key };

                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.Key.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.Key.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.Key.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.Key.IdProveedor;
                    OrdCompInfo.oc_fecha = item.Key.oc_fecha;
                    OrdCompInfo.oc_observacion = item.Key.do_observacion;

                    var Selectdet = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                                    where q.IdEmpresa == item.Key.IdEmpresa
                                 && q.IdProveedor == IdProveedor
                                 && q.IdSucursal == item.Key.IdSucursal
                                 && q.IdOrdenCompra == item.Key.IdOrdenCompra
                                 && q.SaldoxDevolver > 0
                                    select q;

                    foreach (var item_d in Selectdet)
                    {

                        com_ordencompra_local_det_Info det_info_OC = new com_ordencompra_local_det_Info();

                        det_info_OC.IdEmpresa = item.Key.IdEmpresa;
                        det_info_OC.IdSucursal = item.Key.IdSucursal;
                        det_info_OC.IdOrdenCompra = item.Key.IdOrdenCompra;
                        det_info_OC.Secuencia = item_d.Secuencia;
                        det_info_OC.IdProducto = item_d.IdProducto;
                        det_info_OC.do_Cantidad = item_d.do_Cantidad;
                        det_info_OC.do_precioCompra = item_d.do_precioCompra;
                        det_info_OC.do_porc_des = item_d.do_porc_des;
                        det_info_OC.do_descuento = item_d.do_descuento;
                        det_info_OC.do_subtotal = item_d.do_subtotal;
                        det_info_OC.do_iva = item_d.do_iva;
                        det_info_OC.do_total = item_d.do_total;
                        //det_info_OC.do_ManejaIva = item_d.do_ManejaIva;
                        det_info_OC.do_Costeado = item_d.do_Costeado;
                        det_info_OC.do_peso = item_d.do_peso;
                        det_info_OC.do_observacion = item_d.oc_observacion;
                        det_info_OC.cant_devuelta = item_d.cant_devuelta;
                        det_info_OC.saldo_x_devolver = item_d.SaldoxDevolver;

                        OrdCompInfo.listDetalle.Add(det_info_OC);
                    }
                    Lst.Add(OrdCompInfo);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                msg = mensaje;
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {
                var Select = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                             where q.IdEmpresa == IdEmpresa
                             && q.IdProveedor == IdProveedor

                             && q.SaldoxDevolver > 0
                             group q by new { q.IdEmpresa, q.IdSucursal, q.IdOrdenCompra, q.oc_fecha, q.do_observacion, q.IdProveedor, q.pr_nombre, q.Su_Descripcion }
                                 into grouping
                             let count = grouping.Count()
                             select new { grouping.Key };

                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.Key.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.Key.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.Key.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.Key.IdProveedor;
                    OrdCompInfo.oc_fecha = item.Key.oc_fecha;
                    OrdCompInfo.oc_observacion = item.Key.do_observacion;

                    var Selectdet = from q in OEComp.vwcom_ordencompra_local_con_cant_devolver
                                    where q.IdEmpresa == item.Key.IdEmpresa
                                 && q.IdSucursal == item.Key.IdSucursal
                                 && q.IdOrdenCompra == item.Key.IdOrdenCompra
                                 && q.IdProveedor == IdProveedor
                                    select q;

                    foreach (var item_d in Selectdet)
                    {
                        com_ordencompra_local_det_Info det_info_OC = new com_ordencompra_local_det_Info();

                        det_info_OC.IdEmpresa = item.Key.IdEmpresa;
                        det_info_OC.IdSucursal = item.Key.IdSucursal;
                        det_info_OC.IdOrdenCompra = item.Key.IdOrdenCompra;
                        det_info_OC.Secuencia = item_d.Secuencia;
                        det_info_OC.IdProducto = item_d.IdProducto;
                        det_info_OC.do_Cantidad = item_d.do_Cantidad;
                        det_info_OC.do_precioCompra = item_d.do_precioCompra;
                        det_info_OC.do_porc_des = item_d.do_porc_des;
                        det_info_OC.do_descuento = item_d.do_descuento;
                        det_info_OC.do_subtotal = item_d.do_subtotal;
                        det_info_OC.do_iva = item_d.do_iva;
                        det_info_OC.do_total = item_d.do_total;
                        //det_info_OC.do_ManejaIva = item_d.do_ManejaIva;
                        det_info_OC.do_Costeado = item_d.do_Costeado;
                        det_info_OC.do_peso = item_d.do_peso;
                        det_info_OC.do_observacion = item_d.oc_observacion;
                        det_info_OC.cant_devuelta = item_d.cant_devuelta;
                        det_info_OC.saldo_x_devolver = item_d.SaldoxDevolver;
                        OrdCompInfo.listDetalle.Add(det_info_OC);
                    }
                    Lst.Add(OrdCompInfo);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string EstadoAprob, string Estado)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                string Aprob_Estado = (EstadoAprob == "TODOS") ? "" : EstadoAprob;

                var Select = from q in OEComp.com_ordencompra_local
                             where q.IdEmpresa == IdEmpresa
                             && q.oc_fecha <= FechaFin
                             && q.oc_fecha >= FechaIni
                             && q.Estado.Contains(Estado)
                             && q.IdEstadoAprobacion_cat.StartsWith(EstadoAprob)
                             select q;

                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.IdProveedor;
                    OrdCompInfo.oc_NumDocumento = item.oc_NumDocumento;
                    OrdCompInfo.Tipo = item.Tipo;
                    OrdCompInfo.IdTerminoPago = item.IdTerminoPago;
                    OrdCompInfo.oc_plazo = item.oc_plazo;
                    OrdCompInfo.oc_fecha = item.oc_fecha;
                    OrdCompInfo.oc_flete = item.oc_flete;
                    OrdCompInfo.oc_observacion = item.oc_observacion;
                    OrdCompInfo.Estado = item.Estado;
                    OrdCompInfo.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                    OrdCompInfo.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion_cat;
                    OrdCompInfo.co_fecha_aprobacion = item.co_fecha_aprobacion;
                    OrdCompInfo.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    OrdCompInfo.IdUsuario_Reprue = item.IdUsuario_Reprue;
                    OrdCompInfo.co_fechaReproba = item.co_fechaReproba;
                    OrdCompInfo.Fecha_Transac = item.Fecha_Transac;
                    OrdCompInfo.Fecha_UltMod = item.Fecha_UltMod;
                    OrdCompInfo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    OrdCompInfo.FechaHoraAnul = item.FechaHoraAnul;
                    OrdCompInfo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    OrdCompInfo.IdEstadoRecepcion_cat = item.IdEstadoRecepcion_cat;
                    OrdCompInfo.AfectaCosto = item.AfectaCosto;
                    OrdCompInfo.MotivoReprobacion = item.MotivoReprobacion;
                    OrdCompInfo.Solicitante = item.Solicitante;
                    OrdCompInfo.IdDepartamento = item.IdDepartamento;
                    OrdCompInfo.IdComprador = item.IdComprador;
                    OrdCompInfo.IdSolicitante = item.IdSolicitante;
                    OrdCompInfo.IdMotivo = item.IdMotivo;
                    OrdCompInfo.oc_fechaVencimiento = Convert.ToDateTime(item.oc_fechaVencimiento);
                    OrdCompInfo.IdEstado_cierre = item.IdEstado_cierre;
                    OrdCompInfo.IdEstado_cierre_aux = item.IdEstado_cierre;
                    OrdCompInfo.Mostrar_Solicitud = true;
                    OrdCompInfo.IdSolicitud = item.IdSolicitud;

                    Lst.Add(OrdCompInfo);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Cerrar(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string EstadoAprob)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                string Aprob_Estado = (EstadoAprob == "TODOS") ? "" : EstadoAprob;

                var Select = from q in OEComp.com_ordencompra_local
                             where q.IdEmpresa == IdEmpresa
                             && q.oc_fecha <= FechaFin
                             && q.oc_fecha >= FechaIni
                             && q.IdEstado_cierre != "CERR"
                             && q.IdEstadoAprobacion_cat.StartsWith(EstadoAprob)
                             select q;

                foreach (var item in Select)
                {
                    com_ordencompra_local_Info OrdCompInfo = new com_ordencompra_local_Info();
                    OrdCompInfo.IdEmpresa = item.IdEmpresa;
                    OrdCompInfo.IdSucursal = item.IdSucursal;
                    OrdCompInfo.IdOrdenCompra = item.IdOrdenCompra;
                    OrdCompInfo.IdProveedor = item.IdProveedor;
                    OrdCompInfo.oc_NumDocumento = item.oc_NumDocumento;
                    OrdCompInfo.Tipo = item.Tipo;
                    OrdCompInfo.IdTerminoPago = item.IdTerminoPago;
                    OrdCompInfo.oc_plazo = item.oc_plazo;
                    OrdCompInfo.oc_fecha = item.oc_fecha;
                    OrdCompInfo.oc_flete = item.oc_flete;
                    OrdCompInfo.oc_observacion = item.oc_observacion;                    
                    OrdCompInfo.Estado = item.Estado;
                    OrdCompInfo.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                    OrdCompInfo.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion_cat;
                    OrdCompInfo.co_fecha_aprobacion = item.co_fecha_aprobacion;
                    OrdCompInfo.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    OrdCompInfo.IdUsuario_Reprue = item.IdUsuario_Reprue;
                    OrdCompInfo.co_fechaReproba = item.co_fechaReproba;
                    OrdCompInfo.Fecha_Transac = item.Fecha_Transac;
                    OrdCompInfo.Fecha_UltMod = item.Fecha_UltMod;
                    OrdCompInfo.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    OrdCompInfo.FechaHoraAnul = item.FechaHoraAnul;
                    OrdCompInfo.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    OrdCompInfo.IdEstadoRecepcion_cat = item.IdEstadoRecepcion_cat;
                    OrdCompInfo.AfectaCosto = item.AfectaCosto;
                    OrdCompInfo.MotivoReprobacion = item.MotivoReprobacion;
                    OrdCompInfo.Solicitante = item.Solicitante;
                    OrdCompInfo.IdDepartamento = item.IdDepartamento;
                    OrdCompInfo.IdComprador = item.IdComprador;
                    OrdCompInfo.IdSolicitante = item.IdSolicitante;
                    OrdCompInfo.IdMotivo = item.IdMotivo;
                    OrdCompInfo.oc_fechaVencimiento = Convert.ToDateTime(item.oc_fechaVencimiento);
                    OrdCompInfo.IdEstado_cierre = item.IdEstado_cierre;
                    OrdCompInfo.IdEstado_cierre_aux = item.IdEstado_cierre;
                    OrdCompInfo.Mostrar_Solicitud = true;

                    OrdCompInfo.IdSolicitud = item.IdSolicitud;

                    Lst.Add(OrdCompInfo);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public List<com_ordencompra_local_Info> Get_List_ordencompra_local_x_Solicitud(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
        {
            List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {

                var Select = from q in OEComp.vwcom_ordencompra_local_det_x_com_solicitud_compra_det
                             where q.scd_IdEmpresa == IdEmpresa
                                   && q.scd_IdSucursal == IdSucursal
                                   && q.scd_IdSolicitudCompra == IdSolicitudCompra
                             select q;

                foreach (var _det in Select)
                {
                    com_ordencompra_local_Info item = new com_ordencompra_local_Info();
                    item.IdEmpresa = _det.IdEmpresa;
                    item.IdSucursal = _det.IdSucursal;
                    item.IdOrdenCompra = _det.IdOrdenCompra;
                    item.IdProveedor = _det.IdProveedor;
                    item.oc_NumDocumento = _det.oc_NumDocumento;
                    item.Tipo = _det.Tipo;
                    item.IdTerminoPago = _det.IdTerminoPago;
                    item.oc_plazo = _det.oc_plazo;
                    item.oc_fecha = _det.oc_fecha;
                    item.oc_flete = _det.oc_flete;
                    item.oc_observacion = _det.oc_observacion;
                    item.Estado = _det.Estado;
                    item.IdEstadoAprobacion_cat = _det.IdEstadoAprobacion_cat;
                    item.IdEstadoAprobacion_AUX = _det.IdEstadoAprobacion_cat;
                    item.co_fecha_aprobacion = _det.co_fecha_aprobacion;
                    item.IdUsuario_Aprueba = _det.IdUsuario_Aprueba;
                    item.IdUsuario_Reprue = _det.IdUsuario_Reprue;
                    item.co_fechaReproba = _det.co_fechaReproba;
                    item.Fecha_Transac = _det.Fecha_Transac;
                    item.Fecha_UltMod = _det.Fecha_UltMod;
                    item.IdUsuarioUltMod = _det.IdUsuarioUltMod;
                    item.FechaHoraAnul = _det.FechaHoraAnul;
                    item.IdUsuarioUltAnu = _det.IdUsuarioUltAnu;
                    item.IdEstadoRecepcion_cat = _det.IdEstadoRecepcion_cat;
                    item.AfectaCosto = _det.AfectaCosto;
                    item.MotivoReprobacion = _det.MotivoReprobacion;
                    item.Solicitante = _det.Solicitante;
                    item.IdDepartamento = _det.IdDepartamento;
                    item.IdComprador = _det.IdComprador;
                    item.IdSolicitante = _det.IdSolicitante;
                    item.IdMotivo = _det.IdMotivo;
                    item.oc_fechaVencimiento = Convert.ToDateTime(_det.oc_fechaVencimiento);
                    item.IdEstado_cierre = _det.IdEstado_cierre;
                    Lst.Add(item);
                }

                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(com_ordencompra_local_Info Info, ref decimal id)
        {
            try
            {
                List<com_ordencompra_local_Info> Lst = new List<com_ordencompra_local_Info>();
                using (EntitiesCompras_GE Context = new EntitiesCompras_GE())
                {

                    var Address = new com_ordencompra_local();
                    decimal idoc = GetId(Info.IdEmpresa, Info.IdSucursal);
                    id = idoc;

                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Info.IdOrdenCompra = idoc;
                    Address.IdOrdenCompra = idoc;

                    if (Info.oc_NumDocumento == null || Info.oc_NumDocumento == "")
                    {
                        Info.oc_NumDocumento = "OC" + idoc;
                    }

                    Address.oc_NumDocumento = Info.oc_NumDocumento;
                    Address.Tipo = Info.Tipo == null ? "" : Info.Tipo;
                    Address.IdTerminoPago = Info.IdTerminoPago;
                    Address.oc_plazo = Info.oc_plazo;
                    Address.oc_fecha = (DateTime)Info.oc_fecha;
                    Address.Fecha_Transac = (Info.Fecha_Transac == null) ? DateTime.Now : Info.Fecha_Transac;
                    Address.oc_flete = Info.oc_flete;
                    Address.oc_observacion = Info.oc_observacion;
                    Address.IdProyecto = Info.IdProyecto;
                    Address.Estado = "A";
                    Address.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    Address.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                    Address.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                    Address.IdEstadoRecepcion_cat = Info.IdEstadoRecepcion_cat;
                    Address.AfectaCosto = (Info.AfectaCosto == null) ? "S" : Info.AfectaCosto;
                    Address.IdProveedor = Info.IdProveedor;
                    Address.IdComprador = Info.IdComprador;
                    Address.IdSolicitante = Info.IdSolicitante;
                    Address.IdDepartamento = Info.IdDepartamento;
                    Address.IdUsuario = Info.IdUsuario;
                    Address.oc_fechaVencimiento = Info.oc_fechaVencimiento;
                    Address.IdEstado_cierre = Info.IdEstado_cierre;
                    Address.IdMotivo = Info.IdMotivo;
                    Address.Solicitante = Info.Solicitante == null ? null : Info.Solicitante.Trim();
                    Address.IdSolicitud = Info.IdSolicitud;

                    Context.com_ordencompra_local.Add(Address);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public com_ordencompra_local_Info Get_Info_ordencompra_local(int IdEmpresa, int idsucursal, decimal idordencompra)
        {
            EntitiesCompras_GE oEnti = new EntitiesCompras_GE();
            com_ordencompra_local_Info Info = new com_ordencompra_local_Info();
            try
            {
                var Objeto = oEnti.vwcom_ordencompra_local.FirstOrDefault(
                 var => var.IdEmpresa == IdEmpresa && var.IdSucursal == idsucursal
                     && var.IdOrdenCompra == idordencompra);

                if (Objeto != null)
                {

                    Info.IdEmpresa = Objeto.IdEmpresa;
                    Info.IdSucursal = Objeto.IdSucursal;
                    Info.IdOrdenCompra = Objeto.IdOrdenCompra;
                    Info.IdProveedor = Objeto.IdProveedor;
                    Info.oc_NumDocumento = Objeto.oc_NumDocumento;
                    Info.Tipo = Objeto.Tipo;
                    Info.IdTerminoPago = Objeto.IdTerminoPago;
                    Info.oc_plazo = Objeto.oc_plazo;
                    Info.oc_fecha = Objeto.oc_fecha;
                    Info.oc_flete = Objeto.oc_flete;
                    Info.oc_observacion = Objeto.oc_observacion;
                    Info.Estado = Objeto.Estado;
                    Info.IdEstadoAprobacion_cat = Objeto.IdEstadoAprobacion_cat;
                    Info.co_fecha_aprobacion = Objeto.co_fecha_aprobacion;
                    Info.IdUsuario_Aprueba = Objeto.IdUsuario_Aprueba;
                    Info.IdUsuario_Reprue = Objeto.IdUsuario_Reprue;
                    Info.co_fechaReproba = Objeto.co_fechaReproba;
                    Info.Fecha_Transac = Objeto.Fecha_Transac;
                    Info.Fecha_UltMod = Objeto.Fecha_UltMod;
                    Info.IdUsuarioUltMod = Objeto.IdUsuarioUltMod;
                    Info.FechaHoraAnul = Objeto.FechaHoraAnul;
                    Info.IdUsuarioUltAnu = Objeto.IdUsuarioUltAnu;
                    Info.IdEstadoRecepcion_cat = Objeto.IdEstadoRecepcion_cat;
                    Info.AfectaCosto = Objeto.AfectaCosto;
                    Info.Solicitante = Objeto.Solicitante;
                    Info.IdDepartamento = Objeto.IdDepartamento;
                    Info.IdComprador = Objeto.IdComprador;
                    Info.IdSolicitante = Objeto.IdSolicitante;
                    Info.oc_fechaVencimiento = Convert.ToDateTime(Objeto.oc_fechaVencimiento);
                    Info.IdEstado_cierre = Objeto.IdEstado_cierre;
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificarDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.IdProveedor = Info.IdProveedor;
                        contact.oc_NumDocumento = Info.oc_NumDocumento;
                        contact.Tipo = (Info.Tipo == null) ? "" : Info.Tipo;
                        contact.IdTerminoPago = Info.IdTerminoPago;
                        contact.oc_plazo = Info.oc_plazo;
                        contact.oc_fecha = (DateTime)Info.oc_fecha;
                        contact.oc_flete = Info.oc_flete;
                        contact.oc_observacion = Info.oc_observacion;
                        contact.IdProyecto = Info.IdProyecto;
                        contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                        contact.co_fecha_aprobacion = Info.co_fecha_aprobacion;
                        contact.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                        contact.IdUsuario_Reprue = Info.IdUsuario_Reprue;
                        contact.co_fechaReproba = Info.co_fechaReproba;
                        contact.Fecha_UltMod = Info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.IdEstadoRecepcion_cat = Info.IdEstadoRecepcion_cat;
                        contact.AfectaCosto = Info.AfectaCosto;
                        contact.MotivoReprobacion = Info.MotivoReprobacion;
                        contact.Solicitante = Info.Solicitante;
                        contact.IdDepartamento = Info.IdDepartamento;
                        contact.IdComprador = Info.IdComprador;
                        contact.IdSolicitante = Info.IdSolicitante;
                        contact.oc_fechaVencimiento = Info.oc_fechaVencimiento;
                        contact.IdMotivo = Info.IdMotivo;
                        contact.IdEstado_cierre = Info.IdEstado_cierre;

                        context.SaveChanges();
                        msg = "Se ha procedido a modificar el registro de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);

                msg = "Se ha producido el siguiente error: " + mensaje;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_Aprob(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {

                        switch (Info.IdEstadoAprobacion_cat)
                        {

                            case "xAPRO":
                                contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;

                                break;

                            case "APRO":

                                contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                                contact.MotivoReprobacion = Info.MotivoReprobacion;
                                contact.co_fecha_aprobacion = Info.co_fecha_aprobacion;
                                contact.IdUsuario_Aprueba = Info.IdUsuario_Aprueba;
                                break;

                            case "REP":

                                contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                                contact.MotivoReprobacion = Info.MotivoReprobacion;
                                contact.co_fechaReproba = Info.co_fechaReproba;
                                contact.IdUsuario_Reprue = Info.IdUsuario_Reprue;
                                break;

                            default:
                                break;

                        }

                        context.SaveChanges();
                        msg = "Se ha procedido a modificar el registro de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";

                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_Recep(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_ordencompra_local.First(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    contact.IdEstadoRecepcion_cat = Info.IdEstadoRecepcion_cat;

                    context.SaveChanges();
                    msg = "Se ha procedido a actualizar el estado de recepción de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";

                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_Cierre(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, string Estado_cierre)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == IdOrdenCompra &&
                         obj.IdSucursal == IdSucursal && obj.IdEmpresa == IdEmpresa);

                    if (contact != null)
                    {
                        contact.IdEstado_cierre = Estado_cierre;
                        context.SaveChanges();
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;

                // msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(com_ordencompra_local_Info Info, ref  string msg)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdEstadoAprobacion_cat = Info.IdEstadoAprobacion_cat;
                        contact.FechaHoraAnul = Info.FechaHoraAnul;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.MotivoAnulacion = Info.MotivoAnulacion;
                        contact.oc_observacion = Info.oc_observacion;

                        context.SaveChanges();

                        msg = "Se ha procedido a anular el registro de Orden Compra #: " + Info.IdOrdenCompra.ToString() + " exitosamente";

                        ModificarDB_Liberar_Solicitud(Info);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int idempresa, int idsucursal)
        {
            try
            {
                int Id;
                EntitiesCompras_GE OECompras = new EntitiesCompras_GE();
                var select = from q in OECompras.com_ordencompra_local
                             where q.IdEmpresa == idempresa &&
                                     q.IdSucursal == idsucursal
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 2276;
                }
                else
                {
                    var select_pv = (from q in OECompras.com_ordencompra_local
                                     where q.IdEmpresa == idempresa &&
                                         q.IdSucursal == idsucursal
                                     select q.IdOrdenCompra).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                    Id = (Id == 0) ? 1 : Id;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean VerificarCodigo(string NumDoc, int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                EntitiesCompras_GE oen = new EntitiesCompras_GE();
                var select = from q in oen.com_ordencompra_local
                             where q.oc_NumDocumento == NumDoc

                             && q.IdEmpresa != IdEmpresa
                             && q.IdSucursal != IdSucursal
                             && q.IdOrdenCompra != IdOrdenCompra
                             select q;

                if (select.ToList().Count() >= 1)
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_Liberar_Solicitud(com_ordencompra_local_Info Info)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_ordencompra_local.FirstOrDefault(obj => obj.IdOrdenCompra == Info.IdOrdenCompra &&
                         obj.IdSucursal == Info.IdSucursal && obj.IdEmpresa == Info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.IdSolicitud = null;
                        context.SaveChanges();
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                //msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}