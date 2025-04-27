using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.General;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.General
{
    public class tb_Bodega_Data
    {
        string mensaje = "";

        public List<tb_Bodega_Info> Get_List_Bodega(int IdEmpresa, int IdSucursal)
        {
            try
            {
                List<tb_Bodega_Info> lM = new List<tb_Bodega_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_bodega
                                where A.idempresa==IdEmpresa && A.idsucursal==IdSucursal
                                      select A;
                
                foreach (var item in select_pv)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.IdEmpresa = item.idempresa;
                    info.IdBodega = item.idbodega;
                    info.IdSucursal = item.idsucursal;
                    info.cod_bodega = item.cod_bodega;
                    info.bo_Descripcion = item.bo_descripcion.Trim();
                    info.bo_Descripcion2 = "[" + item.idbodega + "]-" + item.bo_descripcion.Trim();
                    info.IdCentroCosto = item.idcentrocosto;
                    info.cod_punto_emision = item.cod_punto_emision;
                    info.bo_esBodega = item.bo_esbodega;
                    info.bo_manejaFacturacion = item.bo_manejafacturacion;
                    info.Estado = (item.estado == "A") ? true : false;
                    info.IdEstadoAproba_x_Ing_Egr_Inven = item.idestadoaproba_x_ing_egr_inven;
                    info.IdCtaCtble_Inve = item.idctactble_inve;
                    info.IdCtaCtble_Costo = item.idctactble_costo;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_Bodega_Info> Get_List_Bodega(int idempresa, Cl_Enumeradores.eTipoFiltro TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal)
        {

            try
            {
                List<tb_Bodega_Info> lM = new List<tb_Bodega_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_bodega
                                join B in OEGeneral.tb_sucursal
                                on new { A.idempresa, A.idsucursal } equals new { B.idempresa, B.idsucursal }
                                where A.idempresa == idempresa
                                
                                select new
                                {
                                    A.idempresa,
                                    A.idbodega,
                                    A.idsucursal,
                                    A.cod_bodega,
                                    A.bo_descripcion,
                                    A.cod_punto_emision,
                                    A.bo_esbodega,
                                    A.bo_manejafacturacion,
                                    A.idcentrocosto,
                                    A.estado,
                                    B.su_descripcion,
                                    A.idctactble_costo,
                                    A.idctactble_inve
                                };
                if (TipoCarga == Cl_Enumeradores.eTipoFiltro.todos)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.bo_Descripcion = "Todas";
                    info.bo_Descripcion2 = "Todas";
                    info.IdBodega = 0;
                    lM.Add(info);
                }
                foreach (var item in select_pv)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.IdEmpresa = item.idempresa;
                    info.IdBodega = item.idbodega;
                    info.IdSucursal = item.idsucursal;
                    info.cod_bodega = item.cod_bodega;
                    info.bo_Descripcion = item.bo_descripcion.Trim();
                    info.cod_punto_emision = item.cod_punto_emision;
                    info.bo_esBodega = item.bo_esbodega;
                    info.bo_manejaFacturacion = item.bo_manejafacturacion;
                    info.IdCentroCosto = item.idcentrocosto;
                    info.Estado = (item.estado == "A") ? true : false;
                    info.NomSucursal = item.su_descripcion.Trim();
                    info.IdCtaCtble_Inve = item.idctactble_inve;
                    info.IdCtaCtble_Costo = item.idctactble_costo;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_Bodega_Info> Get_List_Bodegas_x_CentroCosto(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                List<tb_Bodega_Info> lM = new List<tb_Bodega_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var select_pv = from A in OEGeneral.tb_bodega
                                join B in OEGeneral.tb_sucursal
                                on new { A.idempresa, A.idsucursal } equals new { B.idempresa, B.idsucursal }
                                where A.idempresa == IdEmpresa && A.idcentrocosto == IdCentroCosto
                                select new
                                {
                                    A.idempresa,
                                    A.idbodega,
                                    A.idsucursal,
                                    A.cod_bodega,
                                    A.bo_descripcion,
                                    A.cod_punto_emision,
                                    A.bo_esbodega,
                                    A.bo_manejafacturacion,
                                    A.estado,
                                    A.idcentrocosto,
                                    B.su_descripcion,
                                    A.idctactble_inve,
                                    A.idctactble_costo
                                };

                foreach (var item in select_pv)
                {
                    tb_Bodega_Info info = new tb_Bodega_Info();
                    info.IdEmpresa = item.idempresa;
                    info.IdBodega = item.idbodega;
                    info.IdSucursal = item.idsucursal;
                    info.cod_bodega = item.cod_bodega;
                    info.bo_Descripcion = item.bo_descripcion.Trim();
                    info.cod_punto_emision = item.cod_punto_emision;
                    info.bo_esBodega = item.bo_esbodega;
                    info.bo_manejaFacturacion = item.bo_manejafacturacion;
                    info.Estado = (item.estado == "A") ? true : false;
                    info.NomSucursal = item.su_descripcion.Trim();
                    info.IdCentroCosto = item.idcentrocosto;
                    info.IdCtaCtble_Inve = item.idctactble_inve;
                    info.IdCtaCtble_Costo = item.idctactble_costo;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Bodega_Info Get_Info_Bodega(int IdEmpresa, int IdSucursal, int IdBodega)
        {

            try
            {
                tb_Bodega_Info bodega = new tb_Bodega_Info();
                EntitiesGeneral Oenti = new EntitiesGeneral();

                var bodegas = from bo in Oenti.tb_bodega
                              join su in Oenti.tb_sucursal
                              on new { bo.idempresa, bo.idsucursal } equals new { su.idempresa, su.idsucursal }
                              where bo.idempresa == IdEmpresa
                              && bo.idsucursal == IdSucursal
                              && bo.idbodega == IdBodega
                              select new
                              {
                                  bo.idempresa,
                                  bo.idbodega,
                                  bo.idsucursal,
                                  bo.cod_bodega,
                                  bo.bo_descripcion,
                                  su.su_descripcion,
                                  bo.cod_punto_emision,
                                  bo.idctactble_inve,
                                  bo.idctactble_costo
                              };
                foreach (var bod in bodegas)
                {
                    bodega.IdEmpresa = bod.idempresa;
                    bodega.IdBodega = bod.idbodega;
                    bodega.IdSucursal = bod.idsucursal;
                    bodega.cod_bodega = bod.cod_bodega;
                    bodega.bo_Descripcion = bod.bo_descripcion;
                    bodega.NomSucursal = bod.su_descripcion;
                    bodega.cod_punto_emision = bod.cod_punto_emision;
                    bodega.IdCtaCtble_Inve = bod.idctactble_inve;
                    bodega.IdCtaCtble_Costo = bod.idctactble_costo;
                }
                return bodega;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public string Get_cod_pto_emision_x_Bodega(int IdEmpresa, int IdSucursal, int IdBodega)
        {

            try
            {
                string cod_pto_emision = "";

                EntitiesGeneral Oenti = new EntitiesGeneral();

                var bodegas = from bo in Oenti.tb_bodega
                              where bo.idempresa == IdEmpresa
                              && bo.idsucursal == IdSucursal
                              && bo.idbodega == IdBodega
                              select bo;

                              
                foreach (var bod in bodegas)
                {
                    cod_pto_emision = bod.cod_punto_emision;
                }
                return cod_pto_emision;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_Bodega_Info info, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {

                    var selecte = context.tb_bodega.Count(q => q.idempresa == info.IdEmpresa && q.idsucursal == info.IdSucursal && q.idbodega==info.IdBodega);

                    if (selecte == 0)
                    {

                        tb_Sucursal_Data odata = new tb_Sucursal_Data();
                        List<tb_Sucursal_Info> listaSu = new List<tb_Sucursal_Info>();
                        listaSu = odata.Get_List_Sucursal(info.IdEmpresa);

                        tb_Sucursal_Info infoSu = new tb_Sucursal_Info();
                        infoSu = listaSu.FirstOrDefault(q=> q.IdEmpresa==info.IdEmpresa && q.IdSucursal==info.IdSucursal);

                        msg = "La Sucursal : " + infoSu.Su_Descripcion + " no tiene bodega creada";
                        return false;
                    }

                    else
                    {
                        
                        var contact = context.tb_bodega.First(obj => obj.idempresa == info.IdEmpresa && obj.idsucursal == info.IdSucursal && obj.idbodega == info.IdBodega);
                        if (info.Estado == false)
                        {
                            if (VerificarSiBodegaTieneMovimientos(info, ref msg))
                            {
                                return false;
                            }
                        }

                        contact.bo_descripcion = info.bo_Descripcion;
                        contact.cod_punto_emision = info.cod_punto_emision;
                        contact.bo_esbodega = info.bo_esBodega;
                        contact.bo_manejafacturacion = info.bo_manejaFacturacion;
                        contact.idusuarioultmod = info.IdUsuarioUltMod;
                        contact.fecha_ultmod = info.Fecha_UltMod;
                        contact.idcentrocosto = info.IdCentroCosto;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.estado = (info.Estado == true) ? "A" : "I";
                        contact.idestadoaproba_x_ing_egr_inven = info.IdEstadoAproba_x_Ing_Egr_Inven;
                        contact.idctactble_inve = (info.IdCtaCtble_Inve == "") ? null : info.IdCtaCtble_Inve;
                        contact.idctactble_costo = (info.IdCtaCtble_Costo == "") ? null : info.IdCtaCtble_Costo;

                        context.SaveChanges();
                        msg = "Se ha procedido actualizar el registro de la Bodega #: " + info.IdBodega.ToString() + " exitosamente";

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
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public int getId(int idempresa,int idsucursal )
        {
            int Id=0;
            try
            {
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var select = from q in OEGeneral.tb_bodega
                             where q.idempresa ==idempresa 
                             && q.idsucursal ==idsucursal 
                             select q;

                if (select.ToList().Count <1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OEGeneral.tb_bodega
                                     where q.idempresa == idempresa
                                     select q.idbodega).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Grabar_Lista(List<tb_Bodega_Info> lista_nueva, List<tb_Bodega_Info> lista_antigua, ref string msg)
        {
            try
            {
                //eliminamos la lista antigua de los puntos de ventas
                foreach (var item in lista_antigua)
                {
                    //EliminarDB(
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
                mensaje = ex.ToString() + " " + ex.Message;
                 msg = "Se ha producido el siguiente error: " + ex.Message;
                 throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(tb_Bodega_Info info, ref int id, ref string msg)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {

                    var address = new tb_bodega();
                    int idpv = getId(info.IdEmpresa,info.IdSucursal );
                    id = idpv;
                    address.idempresa = info.IdEmpresa;
                    address.idsucursal = info.IdSucursal; 
                    address.idbodega = idpv;
                    address.bo_descripcion = info.bo_Descripcion;
                    address.cod_punto_emision = info.cod_punto_emision;
                    address.idcentrocosto = info.IdCentroCosto;
                    address.bo_esbodega = "S";
                    address.bo_manejafacturacion=info.bo_manejaFacturacion;
                    address.idusuario=info.IdUsuario;
                    address.fecha_transac=info.Fecha_Transac;
                    address.nom_pc=info.nom_pc;
                    address.ip=info.ip;
                    address.estado = "A";
                    address.idestadoaproba_x_ing_egr_inven = info.IdEstadoAproba_x_Ing_Egr_Inven;
                    address.idctactble_inve = (info.IdCtaCtble_Inve == "") ? null : info.IdCtaCtble_Inve;
                    address.idctactble_costo = (info.IdCtaCtble_Costo == "") ? null : info.IdCtaCtble_Costo;

                    context.tb_bodega.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro de la Bodega #: " + id.ToString() + " exitosamente.";
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
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificarSiBodegaTieneMovimientos(tb_Bodega_Info info, ref  string msg) 
        {
            try
            {
                using (EntitiesInventario entitie = new EntitiesInventario())
                    {
                        int cantidad = entitie.in_movi_inve.Count(v => v.IdEmpresa == info.IdEmpresa && v.IdSucursal == info.IdSucursal && v.IdBodega == info.IdBodega);
                        if (cantidad != 0)
                        {
                            msg = "No se puede anular bodega debido a que tiene movimientos";
                            return true;
                        }
                        else
                        {
                            {
                                return false;
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
               string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(tb_Bodega_Info info, ref  string msg)
        {
            try
            {
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                if(VerificarSiBodegaTieneMovimientos(info, ref msg))
                {
                    
                    return false;
                }
              
                var select = from q in OEGeneral.tb_bodega
                             where q.idempresa == info.IdEmpresa && q.idsucursal == info.IdSucursal && q.idbodega==info.IdBodega
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesGeneral context = new EntitiesGeneral())
                    {
                        var contact = context.tb_bodega.First(obj => obj.idempresa == info.IdEmpresa && obj.idsucursal == info.IdSucursal && obj.idbodega == info.IdBodega);
                        contact.idusuarioultanu = info.IdUsuarioUltAnu;
                        contact.fecha_ultanu = info.Fecha_UltAnu;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        contact.estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro de la Bodega #: " + info.IdBodega.ToString() + " exitosamente";
                    }

                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Punto de Venta #: " + info.IdBodega.ToString() + " debido a que ya se encuentra anulado.";
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
                mensaje = ex.ToString() + " " + ex.Message;

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_Bodega_Data() { }
    }
}
