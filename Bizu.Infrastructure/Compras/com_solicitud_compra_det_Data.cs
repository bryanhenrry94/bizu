using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Compras;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.Compras
{
    public class com_solicitud_compra_det_Data
    {
        string mensaje = "";

        public Boolean GuardarDB(List<com_solicitud_compra_det_Info> LstInfo)
        {
            try
            {
                int sec = 0;

                foreach (var item in LstInfo)
                {
                    using (EntitiesCompras_GE Context = new EntitiesCompras_GE())
                    {
                        sec = sec + 1;

                        com_solicitud_compra_det Address = new com_solicitud_compra_det();
                        Address.IdEmpresa = item.IdEmpresa;
                        Address.IdSucursal = item.IdSucursal;
                        Address.IdSolicitudCompra = item.IdSolicitudCompra;
                        Address.Secuencia = item.Secuencia = sec;
                        Address.IdProducto = item.IdProducto == 0 ? null : item.IdProducto;
                        Address.do_Cantidad = item.do_Cantidad;
                        Address.NomProducto = item.NomProducto;
                        Address.IdCentroCosto = item.IdCentroCosto;
                        Address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        Address.IdPunto_cargo = item.IdPunto_cargo;
                        Address.IdUnidadMedida = item.IdUnidadMedida;
                        Address.IdRubro = item.IdRubro;
                        Address.do_observacion = item.do_observacion;
                        Address.IdProyecto = item.IdProyecto;
                        Address.IdOferta = item.IdOferta;
                        Address.Secuencia_Oferta = item.Secuencia_Oferta;
                        Address.IdEmpresa_obr_AsignacionPorcentual = item.IdEmpresa_obr_AsignacionPorcentual;
                        Address.IdSucursal_obr_AsignacionPorcentual = item.IdSucursal_obr_AsignacionPorcentual;
                        Address.IdProyecto_obr_AsignacionPorcentual = item.IdProyecto_obr_AsignacionPorcentual;
                        Address.IdOferta_obr_AsignacionPorcentual = item.IdOferta_obr_AsignacionPorcentual;
                        Address.Secuencia_obr_AsignacionPorcentual = item.Secuencia_obr_AsignacionPorcentual;

                        Context.com_solicitud_compra_det.Add(Address);
                        Context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(com_solicitud_compra_Info Info)
        {
            try
            {
                EntitiesCompras_GE Oent = new EntitiesCompras_GE();
                var Consulta = Oent.Database.ExecuteSqlCommand("delete from com_solicitud_compra_det where IdEmpresa = " + Info.IdEmpresa + " and IdSucursal =" + Info.IdSucursal + " and IdSolicitudCompra= " + Info.IdSolicitudCompra + "");
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, decimal idsolicitud)
        {
            List<com_solicitud_compra_det_Info> Lst = new List<com_solicitud_compra_det_Info>();
            EntitiesCompras_GE oEnti = new EntitiesCompras_GE();

            try
            {
                var Query = from q in oEnti.vwcom_solicitud_compra_det
                            where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.IdSolicitudCompra == idsolicitud
                            select q;
                foreach (var item in Query)
                {
                    com_solicitud_compra_det_Info Obj = new com_solicitud_compra_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.do_Cantidad = item.do_Cantidad;
                    Obj.NomProducto = item.NomProducto;
                    Obj.pr_descripcion = item.NomProducto;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.IdUnidadMedida = item.IdUnidadMedida;
                    Obj.nom_punto_cargo = item.nom_punto_cargo;
                    Obj.NomCentroCosto = item.Nom_Centro_costo;
                    Obj.Nomsub_centro_costo = item.Nom_SubCentroCosto;
                    Obj.cod_producto = item.cod_producto;
                    Obj.nom_producto_princ = item.nom_producto_princ;
                    Obj.pr_stock = Convert.ToDecimal(item.pr_stock);
                    Obj.do_observacion = item.do_observacion;
                    Obj.IdProyecto = item.IdProyecto;
                    Obj.Secuencia_Oferta = item.Secuencia_Oferta;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdEmpresa_obr_AsignacionPorcentual = item.IdEmpresa_obr_AsignacionPorcentual;
                    Obj.IdSucursal_obr_AsignacionPorcentual = item.IdSucursal_obr_AsignacionPorcentual;
                    Obj.IdProyecto_obr_AsignacionPorcentual = item.IdProyecto_obr_AsignacionPorcentual;
                    Obj.IdOferta_obr_AsignacionPorcentual = item.IdOferta_obr_AsignacionPorcentual;
                    Obj.Secuencia_obr_AsignacionPorcentual = item.Secuencia_obr_AsignacionPorcentual;

                    Lst.Add(Obj);
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

        public List<com_solicitud_compra_det_Info> Get_list_x_Proyecto(int IdEmpresa, int IdSucursal, int IdProyecto, int IdOferta)
        {
            List<com_solicitud_compra_det_Info> Lst = new List<com_solicitud_compra_det_Info>();
            EntitiesCompras_GE oEnti = new EntitiesCompras_GE();

            try
            {
                var Query = from q in oEnti.vwcom_solicitud_compra_det
                            where q.IdEmpresa == IdEmpresa 
                            && q.IdSucursal == IdSucursal 
                            && q.IdProyecto == IdProyecto
                            && q.IdOferta == IdOferta
                            select q;

                foreach (var item in Query)
                {
                    com_solicitud_compra_det_Info Obj = new com_solicitud_compra_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.do_Cantidad = item.do_Cantidad;
                    Obj.NomProducto = item.NomProducto;
                    Obj.pr_descripcion = item.NomProducto;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.IdUnidadMedida = item.IdUnidadMedida;
                    Obj.nom_punto_cargo = item.nom_punto_cargo;
                    Obj.NomCentroCosto = item.Nom_Centro_costo;
                    Obj.Nomsub_centro_costo = item.Nom_SubCentroCosto;
                    Obj.cod_producto = item.cod_producto;
                    Obj.nom_producto_princ = item.nom_producto_princ;
                    Obj.pr_stock = Convert.ToDecimal(item.pr_stock);
                    Obj.do_observacion = item.do_observacion;
                    Obj.IdProyecto = item.IdProyecto;
                    Obj.Secuencia_Oferta = item.Secuencia_Oferta;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdEmpresa_obr_AsignacionPorcentual = item.IdEmpresa_obr_AsignacionPorcentual;
                    Obj.IdSucursal_obr_AsignacionPorcentual = item.IdSucursal_obr_AsignacionPorcentual;
                    Obj.IdProyecto_obr_AsignacionPorcentual = item.IdProyecto_obr_AsignacionPorcentual;
                    Obj.IdOferta_obr_AsignacionPorcentual = item.IdOferta_obr_AsignacionPorcentual;
                    Obj.Secuencia_obr_AsignacionPorcentual = item.Secuencia_obr_AsignacionPorcentual;

                    Lst.Add(Obj);
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

        public com_solicitud_compra_det_Info Get_Info(int idempresa, int idsucursal, decimal idsolicitud, int Secuencia)
        {
            com_solicitud_compra_det_Info Obj = new com_solicitud_compra_det_Info();
            EntitiesCompras_GE oEnti = new EntitiesCompras_GE();

            try
            {
                var Query = from q in oEnti.vwcom_solicitud_compra_det
                            where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.IdSolicitudCompra == idsolicitud
                            && q.Secuencia == Secuencia
                            select q;

                foreach (var item in Query)
                {
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.do_Cantidad = item.do_Cantidad;
                    Obj.NomProducto = item.NomProducto;
                    Obj.pr_descripcion = item.NomProducto;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.IdUnidadMedida = item.IdUnidadMedida;
                    Obj.nom_punto_cargo = item.nom_punto_cargo;
                    Obj.NomCentroCosto = item.Nom_Centro_costo;
                    Obj.Nomsub_centro_costo = item.Nom_SubCentroCosto;
                    Obj.cod_producto = item.cod_producto;
                    Obj.nom_producto_princ = item.nom_producto_princ;
                    Obj.pr_stock = Convert.ToDecimal(item.pr_stock);
                    Obj.do_observacion = item.do_observacion;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdProyecto = item.IdProyecto;
                    Obj.IdOferta = item.IdOferta;
                    Obj.Secuencia_Oferta = item.Secuencia_Oferta;
                    Obj.IdEmpresa_obr_AsignacionPorcentual = item.IdEmpresa_obr_AsignacionPorcentual;
                    Obj.IdSucursal_obr_AsignacionPorcentual = item.IdSucursal_obr_AsignacionPorcentual;
                    Obj.IdProyecto_obr_AsignacionPorcentual = item.IdProyecto_obr_AsignacionPorcentual;
                    Obj.IdOferta_obr_AsignacionPorcentual = item.IdOferta_obr_AsignacionPorcentual;
                    Obj.Secuencia_obr_AsignacionPorcentual = item.Secuencia_obr_AsignacionPorcentual;
                }

                return Obj;
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

        public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, DateTime FechaIni, DateTime FechaFin, string IdEstadoAprobacion, ref string mensaje)
        {
            FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
            FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

            List<com_solicitud_compra_det_Info> Lst = new List<com_solicitud_compra_det_Info>();
            EntitiesCompras_GE oEnti = new EntitiesCompras_GE();

            try
            {
                var Query = from q in oEnti.vwcom_solicitud_compra_det
                            where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.fecha >= FechaIni && q.fecha <= FechaFin
                             && q.IdEstadoAprobacion.Contains(IdEstadoAprobacion)
                            select q;
                foreach (var item in Query)
                {
                    com_solicitud_compra_det_Info Obj = new com_solicitud_compra_det_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                    Obj.Secuencia = item.Secuencia;
                    Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                    Obj.do_Cantidad = item.do_Cantidad;
                    Obj.NomProducto = item.NomProducto;
                    Obj.pr_descripcion = item.NomProducto;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    Obj.IdPunto_cargo = item.IdPunto_cargo;
                    Obj.IdUnidadMedida = item.IdUnidadMedida;
                    Obj.nom_punto_cargo = item.nom_punto_cargo;
                    Obj.NomCentroCosto = item.Nom_Centro_costo;
                    Obj.Nomsub_centro_costo = item.Nom_SubCentroCosto;
                    Obj.cod_producto = item.cod_producto;
                    Obj.nom_producto_princ = item.nom_producto_princ;
                    Obj.pr_stock = Convert.ToDecimal(item.pr_stock);
                    Obj.nom_Sucursal = item.nom_Sucursal;
                    Obj.nom_Unidad = item.nom_Unidad;
                    Obj.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Obj.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion;
                    Obj.fecha = item.fecha;
                    Obj.do_observacion = item.do_observacion;
                    Obj.IdProyecto = item.IdProyecto;
                    Obj.Secuencia_Oferta = item.Secuencia_Oferta;
                    Obj.IdRubro = item.IdRubro;
                    Obj.IdEmpresa_obr_AsignacionPorcentual = item.IdEmpresa_obr_AsignacionPorcentual;
                    Obj.IdSucursal_obr_AsignacionPorcentual = item.IdSucursal_obr_AsignacionPorcentual;
                    Obj.IdProyecto_obr_AsignacionPorcentual = item.IdProyecto_obr_AsignacionPorcentual;
                    Obj.IdOferta_obr_AsignacionPorcentual = item.IdOferta_obr_AsignacionPorcentual;
                    Obj.Secuencia_obr_AsignacionPorcentual = item.Secuencia_obr_AsignacionPorcentual;

                    Lst.Add(Obj);
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

        public Boolean Actualizar_Producto_Creado(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto, string nom_producto, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_solicitud_compra_det.FirstOrDefault(VProdu => VProdu.IdEmpresa == IdEmpresa && VProdu.IdSolicitudCompra == IdSolicitudCompra && VProdu.IdSucursal == IdSucursal && VProdu.Secuencia == Secuencia);

                    if (contact != null)
                    {
                        contact.IdProducto = IdProducto;
                        contact.NomProducto = nom_producto;
                        context.SaveChanges();
                        mensaje = "Se ha procedido a Actualizar la Información Exitosamente...";
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarEstadoAproba_DetSolCom(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto, string IdEstadoAprobacion, ref string mensaje)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_solicitud_compra_det.FirstOrDefault(VProdu => VProdu.IdEmpresa == IdEmpresa
                        && VProdu.IdSolicitudCompra == IdSolicitudCompra
                        && VProdu.IdSucursal == IdSucursal
                        && VProdu.Secuencia == Secuencia);

                    if (contact != null)
                    {
                        context.SaveChanges();
                        mensaje = "Actualización ok...";
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

        public List<com_solicitud_compra_det_Info> GetList_SolicitudPendiente(int IdEmpresa)
        {
            List<com_solicitud_compra_det_Info> Lst = new List<com_solicitud_compra_det_Info>();
            EntitiesCompras_GE oEnti = new EntitiesCompras_GE();

            try
            {
                var Query = from q in oEnti.vwcom_SolicitudCompra_Det_SaldoPendiente
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var pendiente in Query)
                {
                    com_solicitud_compra_det_Info item = new com_solicitud_compra_det_Info();
                    item.IdEmpresa = pendiente.IdEmpresa;
                    item.IdSucursal = pendiente.IdSucursal;
                    item.nom_Sucursal = pendiente.Sucursal;
                    item.IdSolicitudCompra = pendiente.IdSolicitudCompra;
                    item.Secuencia = pendiente.Secuencia;
                    item.fecha = pendiente.fecha;
                    item.plazo = pendiente.plazo;
                    item.fecha_vtc = pendiente.fecha_vtc;
                    item.observacion = pendiente.observacion;                                        
                    item.IdSolicitante = pendiente.IdSolicitante;
                    item.nom_solicitante = pendiente.nom_solicitante;
                    item.IdProducto = Convert.ToDecimal(pendiente.IdProducto);
                    item.pr_descripcion = pendiente.pr_descripcion;
                    item.NomProducto = pendiente.pr_descripcion;
                    item.cod_producto = pendiente.pr_codigo;
                    item.do_observacion = pendiente.do_observacion;
                    item.IdUnidadMedida = pendiente.IdUnidadMedida;
                    item.nom_Unidad = pendiente.UnidadMedida;
                    item.nom_Unidad_Alterno = pendiente.UnidadMedida_Alterno;
                    item.do_CantidadSolicitud = pendiente.do_Cantidad;
                    item.do_CantidadPedida = Convert.ToDouble(pendiente.CantidadPedida);
                    item.do_Saldo = Convert.ToDouble(pendiente.Saldo);
                    item.IdCategoria = pendiente.IdCategoria;
                    item.ca_Categoria = pendiente.ca_Categoria;
                    item.IdLinea = pendiente.IdLinea;
                    item.nom_linea = pendiente.nom_linea;
                    item.IdCentroCosto = pendiente.IdCentroCosto;
                    item.IdCentroCosto_sub_centro_costo = pendiente.IdCentroCosto_sub_centro_costo;
                    item.IdPunto_cargo_grupo = pendiente.IdPunto_cargo_grupo;
                    item.IdPunto_cargo = pendiente.IdPunto_cargo;
                    item.do_observacion = pendiente.do_observacion;
                    item.Ref_Solicitud = pendiente.IdSolicitudCompra.ToString() + " - " + pendiente.observacion;
                    item.Checked = false;
                    item.Secuencia_Oferta = pendiente.Secuencia_Oferta;                    
                    item.IdEmpresa_obr_AsignacionPorcentual = pendiente.IdEmpresa_obr_AsignacionPorcentual;
                    item.IdSucursal_obr_AsignacionPorcentual = pendiente.IdSucursal_obr_AsignacionPorcentual;
                    item.IdProyecto_obr_AsignacionPorcentual = pendiente.IdProyecto_obr_AsignacionPorcentual;
                    item.IdOferta_obr_AsignacionPorcentual = pendiente.IdOferta_obr_AsignacionPorcentual;
                    item.Secuencia_obr_AsignacionPorcentual = pendiente.Secuencia_obr_AsignacionPorcentual;                    

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

        public bool ExisteRubro_SolicitudCompra(int IdEmpresa, int IdSucursal, int IdProyecto, int IdOferta, int Secuencia)
        {
            try
            {
                using(EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var query = from q in context.com_solicitud_compra_det
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSucursal == IdSucursal
                                && q.IdProyecto == IdProyecto
                                && q.IdOferta == IdOferta
                                && q.Secuencia_Oferta == Secuencia
                                select q;

                    if (query.Count() > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception exception)
            {
                string str = this.ToString();
                new Bizu.Infrastructure.General.tb_sis_Log_Error_Vzen_Data().Guardar_Log_Error(new tb_sis_Log_Error_Vzen_Info(exception.ToString(), "", str, "", "", "", "", "", DateTime.Now), ref this.mensaje);
                this.mensaje = exception.ToString();
                throw new Exception(exception.ToString());
            }
        }
    }
}