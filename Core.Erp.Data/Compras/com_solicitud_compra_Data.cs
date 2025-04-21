using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Compras
{
    public class com_solicitud_compra_Data
    {
        private string mensaje = "";

        public bool AnularDB(com_solicitud_compra_Info info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_GE Context = new EntitiesCompras_GE())
                {
                    var _compra = Context.com_solicitud_compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa
                        && var.IdSucursal == info.IdSucursal && var.IdSolicitudCompra == info.IdSolicitudCompra);

                    if (_compra != null)
                    {
                        _compra.Estado = "I";
                        _compra.IdEstadoAprobacion = "ANU_SOL";
                        _compra.FechaHoraAnul = info.FechaHoraAnul;
                        _compra.IdUsuarioUltAnu = info.IdUsuarioUltAnu;

                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string arreglo = ToString();
                    mensaje = "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:" +
                      eve.Entry.Entity.GetType().Name.ToString() + eve.Entry.State.ToString();

                    foreach (var ve in eve.ValidationErrors)
                    {
                        mensaje = mensaje + "- Property: \"{0}\", Error: \"{1}\"" +
                            ve.PropertyName.ToString() + ve.ErrorMessage;
                    }
                }

                throw new Exception(ex.ToString());
            }
        }

        public List<com_solicitud_compra_Info> Get_List_Solicitud_Apro(int IdEmpresa, int IdSucursal, int IdSolicitud)
        {
            List<com_solicitud_compra_Info> Lst = new List<com_solicitud_compra_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {

                var Select = from q in OEComp.vwcom_solicitud_compra
                             where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdSolicitudCompra == IdSolicitud
                              && q.Estado == "A"
                             select q;

                foreach (var item in Select)
                {
                    com_solicitud_compra_Info Info = new com_solicitud_compra_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdSolicitudCompra = item.IdSolicitudCompra;
                    Info.NumDocumento = item.NumDocumento;
                    Info.IdSolicitante = item.IdPersona_Solicita;
                    Info.fecha = item.fecha;
                    Info.observacion = item.observacion;
                    Info.Estado = item.Estado;
                    Info.Sucursal = item.Sucursal;
                    Info.Solicitante = item.Solicitante;
                    Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Info.IdUsuarioAprobo = item.IdUsuarioAprobo;
                    Info.MotivoAprobacion = item.MotivoAprobacion;
                    Info.FechaHoraAprobacion = item.FechaHoraAprobacion;
                    Info.nom_EstadoAprobacion = item.nom_EstadoAprobacion;
                    Info.Mostrar_Icono_Buscar_OC = true;
                    Info.fecha_vtc = item.fecha_vtc;
                    Info.plazo = item.plazo;
                    Info.OrdenCompra = item.OrdenCompra;
                    Info.observacion2 = "[" + item.IdSolicitudCompra + "] " + item.observacion;

                    Lst.Add(Info);
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

        private decimal GetId(int IdEmpresa, int IdSucursal)
        {
            decimal Id = 0;

            try
            {
                EntitiesCompras_GE contex = new EntitiesCompras_GE();
                var selecte = contex.com_solicitud_compra.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.com_solicitud_compra
                                     where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                     select q.IdSolicitudCompra).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(com_solicitud_compra_Info info)
        {
            try
            {
                using (EntitiesCompras_GE Context = new EntitiesCompras_GE())
                {
                    var _compra = new com_solicitud_compra();
                    _compra.IdEmpresa = info.IdEmpresa;
                    _compra.IdSucursal = info.IdSucursal;
                    _compra.IdSolicitudCompra = info.IdSolicitudCompra = GetId(info.IdEmpresa, info.IdSucursal);
                    _compra.NumDocumento = info.NumDocumento;
                    _compra.IdSolicitante = info.IdSolicitante;
                    _compra.fecha = info.fecha;
                    _compra.plazo = info.plazo;
                    _compra.fecha_vtc = info.fecha_vtc;
                    _compra.observacion = info.observacion;
                    _compra.Estado = info.Estado;
                    _compra.Fecha_Transac = info.Fecha_Transac;
                    _compra.Fecha_UltMod = info.Fecha_UltMod;
                    _compra.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    _compra.FechaHoraAnul = info.FechaHoraAnul;
                    _compra.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    _compra.MotivoAnulacion = info.MotivoAnulacion;
                    _compra.IdEstadoAprobacion = info.IdEstadoAprobacion;
                    _compra.IdUsuarioAprobo = info.IdUsuarioAprobo;
                    _compra.MotivoAprobacion = info.MotivoAprobacion;
                    _compra.FechaHoraAprobacion = info.FechaHoraAprobacion;
                    Context.com_solicitud_compra.Add(_compra);
                    Context.SaveChanges();

                    com_solicitud_compra_det_Data odata = new com_solicitud_compra_det_Data();

                    foreach (var item in info.DetSolicitudCompra)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdSucursal = info.IdSucursal;
                        item.IdSolicitudCompra = info.IdSolicitudCompra;
                    }

                    odata.GuardarDB(info.DetSolicitudCompra);
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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarDB(com_solicitud_compra_Info info)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var _compra = context.com_solicitud_compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSucursal == info.IdSucursal && var.IdSolicitudCompra == info.IdSolicitudCompra);

                    if (_compra != null)
                    {
                        _compra.NumDocumento = info.NumDocumento;
                        _compra.IdSolicitante = info.IdSolicitante;
                        _compra.fecha = info.fecha;
                        _compra.plazo = info.plazo;
                        _compra.fecha_vtc = info.fecha_vtc;
                        _compra.observacion = info.observacion;
                        _compra.Estado = info.Estado;
                        _compra.Fecha_Transac = info.Fecha_Transac;
                        _compra.Fecha_UltMod = info.Fecha_UltMod;
                        _compra.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        _compra.FechaHoraAnul = info.FechaHoraAnul;
                        _compra.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        _compra.MotivoAnulacion = info.MotivoAnulacion;
                        _compra.IdEstadoAprobacion = info.IdEstadoAprobacion;
                        _compra.IdUsuarioAprobo = info.IdUsuarioAprobo;
                        _compra.MotivoAprobacion = info.MotivoAprobacion;
                        _compra.FechaHoraAprobacion = info.FechaHoraAprobacion;
                        context.SaveChanges();

                        // eliminar detalle solicitud                             
                        com_solicitud_compra_det_Data odata = new com_solicitud_compra_det_Data();
                        odata.EliminarDB(info);
                        odata.GuardarDB(info.DetSolicitudCompra);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_EstadoAprobacion(com_solicitud_compra_Info info)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var _compra = context.com_solicitud_compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdSucursal == info.IdSucursal && var.IdSolicitudCompra == info.IdSolicitudCompra);

                    if (_compra != null)
                    {

                        _compra.IdEstadoAprobacion = info.IdEstadoAprobacion;
                        _compra.IdUsuarioAprobo = (info.IdUsuarioAprobo == null) ? "" : Convert.ToString(info.IdUsuarioAprobo);
                        _compra.MotivoAprobacion = (info.MotivoAprobacion == null) ? "" : Convert.ToString(info.MotivoAprobacion);
                        _compra.FechaHoraAprobacion = info.FechaHoraAprobacion;
                        context.SaveChanges();
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<com_solicitud_compra_Info> Get_List_solicitud_compra_Aprobadas(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<com_solicitud_compra_Info> Lst = new List<com_solicitud_compra_Info>();
                EntitiesCompras_GE OEComp = new EntitiesCompras_GE();

                int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 9999999 : IdSucursal;

                var Select = from q in OEComp.vwcom_solicitud_compra
                             where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                              && q.IdEstadoAprobacion == "APR_SOL"
                             select q;

                foreach (var _compra in Select)
                {
                    com_solicitud_compra_Info item = new com_solicitud_compra_Info();
                    item.IdEmpresa = _compra.IdEmpresa;
                    item.IdSucursal = _compra.IdSucursal;
                    item.IdSolicitudCompra = _compra.IdSolicitudCompra;
                    item.NumDocumento = _compra.NumDocumento;
                    item.IdSolicitante = _compra.IdPersona_Solicita;
                    item.fecha = _compra.fecha;
                    item.plazo = _compra.plazo;
                    item.fecha_vtc = _compra.fecha_vtc;
                    item.observacion = _compra.observacion;
                    item.Estado = _compra.Estado;
                    item.Sucursal = _compra.Sucursal;
                    item.Solicitante = _compra.Solicitante;
                    item.IdEstadoAprobacion = _compra.IdEstadoAprobacion;
                    item.IdUsuarioAprobo = _compra.IdUsuarioAprobo;
                    item.MotivoAprobacion = _compra.MotivoAprobacion;
                    item.FechaHoraAprobacion = _compra.FechaHoraAprobacion;
                    item.nom_EstadoAprobacion = _compra.nom_EstadoAprobacion;
                    item.Mostrar_Icono_Buscar_OC = true;
                    item.OrdenCompra = _compra.OrdenCompra;
                    item.observacion2 = "[" + _compra.IdSolicitudCompra + "] " + _compra.observacion;

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

        public List<com_solicitud_compra_Info> Get_List_solicitud_compra(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string IdEstadoAprobacion)
        {
            List<com_solicitud_compra_Info> list = new List<com_solicitud_compra_Info>();

            com_ordencompra_local_det_x_com_solicitud_compra_det_Data datDetComp = new com_ordencompra_local_det_x_com_solicitud_compra_det_Data();
            List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> lstDetComp = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();

            List<string> IdOrdenCompra = new List<string>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();

            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                int IdSucursalIni = (IdSucursal == 0) ? 1 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 9999999 : IdSucursal;


                var Select = from q in OEComp.vwcom_solicitud_compra
                             where q.IdEmpresa == IdEmpresa
                              && q.fecha <= FechaFin
                              && q.fecha >= FechaIni
                              && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                              && q.IdEstadoAprobacion.Contains(IdEstadoAprobacion)
                             orderby q.IdSolicitudCompra ascending
                             select q;

                foreach (var _compra in Select)
                {
                    com_solicitud_compra_Info item = new com_solicitud_compra_Info();
                    item.IdEmpresa = _compra.IdEmpresa;
                    item.IdSucursal = _compra.IdSucursal;
                    item.IdSolicitudCompra = _compra.IdSolicitudCompra;
                    item.NumDocumento = _compra.NumDocumento;
                    item.IdSolicitante = _compra.IdPersona_Solicita;
                    item.fecha = _compra.fecha;
                    item.plazo = _compra.plazo;
                    item.fecha_vtc = _compra.fecha_vtc;
                    item.observacion = _compra.observacion;
                    item.Estado = _compra.Estado;
                    item.Sucursal = _compra.Sucursal;
                    item.Solicitante = _compra.Solicitante;
                    item.IdEstadoAprobacion = _compra.IdEstadoAprobacion;
                    item.IdUsuarioAprobo = _compra.IdUsuarioAprobo;
                    item.MotivoAprobacion = _compra.MotivoAprobacion;
                    item.FechaHoraAprobacion = _compra.FechaHoraAprobacion;
                    item.nom_EstadoAprobacion = _compra.nom_EstadoAprobacion;
                    item.Mostrar_Icono_Buscar_OC = true;
                    item.OrdenCompra = _compra.OrdenCompra;
                    item.observacion2 = "[" + _compra.IdSolicitudCompra + "] " + _compra.observacion;

                    list.Add(item);
                }
                return list;
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

        public List<com_solicitud_compra_Info> Get_List_Solicitud_x_OC(int IdEmpresa, int IdSucursal, string IdOrdenCompra)
        {
            List<com_solicitud_compra_Info> Lst = new List<com_solicitud_compra_Info>();
            EntitiesCompras_GE OEComp = new EntitiesCompras_GE();
            try
            {

                var Select = from q in OEComp.vwcom_ordencompra_local_det_x_com_solicitud_compra_det
                             where q.scd_IdEmpresa == IdEmpresa
                                   && q.scd_IdSucursal == IdSucursal
                                   && q.oc_NumDocumento == IdOrdenCompra
                             select q;

                foreach (var item in Select)
                {
                    com_solicitud_compra_Info SolicitudInfo = new com_solicitud_compra_Info();
                    SolicitudInfo.IdSolicitudCompra = item.scd_IdSolicitudCompra;

                    Lst.Add(SolicitudInfo);
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

    }
}