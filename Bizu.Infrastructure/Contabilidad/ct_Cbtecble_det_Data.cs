using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_Cbtecble_det_Data
    {
        string mensaje = "";

         public List<ct_Cbtecble_det_Info> Get_list_Cbtecble_det(int IdEmpresa,ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> lM = new List<ct_Cbtecble_det_Info>();
                EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                var selectCbtecble_det = from C in OECbtecble_det.ct_cbtecble_det
                                         where C.idempresa == IdEmpresa 
                                       select C;

                foreach (ct_cbtecble_det item in selectCbtecble_det)
                {
                    ct_Cbtecble_det_Info Cbt = new ct_Cbtecble_det_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdTipoCbte = item.idtipocbte;
                    Cbt.IdCbteCble = item.idcbtecble;
                    Cbt.secuencia = item.secuencia;
                    Cbt.IdCtaCble = item.idctacble;
                    Cbt.IdCentroCosto = item.idcentrocosto;
                    Cbt.IdCentroCosto_sub_centro_costo = item.idcentrocosto_sub_centro_costo;
                    Cbt.dc_Valor = item.dc_valor;
                    Cbt.dc_Observacion = item.dc_observacion;
                    Cbt.IdPunto_cargo = item.idpunto_cargo;
                    Cbt.dc_para_conciliar = (item.dc_para_conciliar == null) ? false : Convert.ToBoolean(item.dc_para_conciliar);

                    lM.Add(Cbt);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);

                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }


        }

         public List<ct_Cbtecble_det_Info> Get_list_Cbtecble_det(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble,ref string MensajeError)
        {
            try
            {
                List<ct_Cbtecble_det_Info> lM = new List<ct_Cbtecble_det_Info>();
                EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                var selectCbtecble_det = from C in OECbtecble_det.ct_cbtecble_det
                                         join Cc in OECbtecble_det.ct_centro_costo on new { C.idempresa, C.idcentrocosto } equals new { Cc.idempresa, Cc.idcentrocosto } into cen
                                         from subquerry in cen.DefaultIfEmpty()
                                         join Ct in OECbtecble_det.ct_plancta on new { C.idempresa, C.idctacble } equals new { Ct.idempresa, Ct.idctacble }
                                         where C.idempresa == IdEmpresa && C.idcbtecble == IdCbteCble && C.idtipocbte == IdTipoCbte
                                         select new
                                         {
                                             C.idempresa,
                                             C.idtipocbte,
                                             C.idcbtecble,
                                             C.secuencia,
                                             C.idctacble,
                                             C.idcentrocosto,
                                             C.idcentrocosto_sub_centro_costo,
                                             C.dc_valor,
                                             C.dc_observacion,
                                             subquerry.centro_costo,
                                             Ct.pc_cuenta,
                                             C.idpunto_cargo,
                                             C.idpunto_cargo_grupo,
                                             C.dc_para_conciliar 

                                         };

                foreach (var item in selectCbtecble_det)
                {
                    ct_Cbtecble_det_Info Cbt = new ct_Cbtecble_det_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdTipoCbte = item.idtipocbte;
                    Cbt.IdCbteCble = item.idcbtecble;
                    Cbt.IdCentroCosto_sub_centro_costo = item.idcentrocosto_sub_centro_costo;
                    Cbt.IdCtaCble = item.idctacble;
                    Cbt.secuencia = item.secuencia;
                    Cbt.IdCentroCosto = item.idcentrocosto;
                    Cbt.dc_Valor = item.dc_valor;
                    Cbt.dc_Observacion = item.dc_observacion;
                    Cbt.NomCtaCble =item.pc_cuenta ;
                    Cbt.NomCentroCosto=(item.centro_costo!=null)? item.centro_costo : "" ;
                    Cbt.IdPunto_cargo = item.idpunto_cargo;
                    Cbt.IdPunto_cargo_grupo = item.idpunto_cargo_grupo;
                    Cbt.IdRegistro = item.idcentrocosto_sub_centro_costo == null ? null : item.idcentrocosto + "-" + item.idcentrocosto_sub_centro_costo;
                    Cbt.dc_para_conciliar = (item.dc_para_conciliar == null) ? false : Convert.ToBoolean(item.dc_para_conciliar);
                    lM.Add(Cbt);
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);

                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
            
        }
        
         public Boolean ModificarDB(ct_Cbtecble_det_Info _CbteCbleInfo,ref string MensajeError)
         {
             try
             {
                 bool respuesta = true;

                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     var contact = context.ct_cbtecble_det.FirstOrDefault(tbCbteCble => tbCbteCble.idempresa == _CbteCbleInfo.IdEmpresa 
                         && tbCbteCble.idtipocbte==_CbteCbleInfo.IdTipoCbte 
                         &&  tbCbteCble.idcbtecble == _CbteCbleInfo.IdCbteCble 
                         && tbCbteCble.secuencia==_CbteCbleInfo.secuencia);

                     if (contact != null)
                     {
                         contact.idcentrocosto = _CbteCbleInfo.IdCentroCosto;
                         contact.idcentrocosto_sub_centro_costo = _CbteCbleInfo.IdCentroCosto_sub_centro_costo;
                         contact.idpunto_cargo_grupo = _CbteCbleInfo.IdPunto_cargo_grupo;
                         contact.idpunto_cargo = _CbteCbleInfo.IdPunto_cargo;
                         contact.idctacble = _CbteCbleInfo.IdCtaCble;
                         contact.dc_observacion = _CbteCbleInfo.dc_Observacion;
                         contact.dc_para_conciliar = _CbteCbleInfo.dc_para_conciliar;
                         contact.dc_valor = _CbteCbleInfo.dc_Valor;
                         context.SaveChanges();
                     }
                     else
                     {
                         //GrabarDB(_CbteCbleInfo, ref mensaje);                         
                     }

                 }
                 return respuesta;
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

         public Boolean ModificarDB(List<ct_Cbtecble_det_Info> _CbteCbleInfo, ref string MensajeError)
         {
             try
             {
                 bool respuesta = true;

                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     foreach (ct_Cbtecble_det_Info item in _CbteCbleInfo)
                     {                         
                         var contact = context.ct_cbtecble_det.FirstOrDefault(tbCbteCble => tbCbteCble.idempresa == item.IdEmpresa
                             && tbCbteCble.idtipocbte == item.IdTipoCbte
                             && tbCbteCble.idcbtecble == item.IdCbteCble
                             && tbCbteCble.secuencia == item.secuencia);

                         if (contact != null)
                         {
                             contact.idcentrocosto = item.IdCentroCosto;
                             contact.idcentrocosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                             contact.idpunto_cargo_grupo = item.IdPunto_cargo_grupo;
                             contact.idpunto_cargo = item.IdPunto_cargo;
                             contact.idctacble = item.IdCtaCble;
                             contact.dc_observacion = item.dc_Observacion;
                             contact.dc_para_conciliar = item.dc_para_conciliar;
                             contact.dc_valor = item.dc_Valor;
                             context.SaveChanges();
                         }
                         else
                         {
                             //GrabarDB(_CbteCbleInfo, ref mensaje);                         
                         }
                     }                     
                 }
                 return respuesta;
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

         public Boolean ModificarDB_conciliado(ct_Cbtecble_det_Info _CbteCbleInfo, ref string MensajeError)
         {
             try
             {
                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     var contact = context.ct_cbtecble_det.FirstOrDefault(tbCbteCble => tbCbteCble.idempresa == _CbteCbleInfo.IdEmpresa
                         && tbCbteCble.idtipocbte == _CbteCbleInfo.IdTipoCbte
                         && tbCbteCble.idcbtecble == _CbteCbleInfo.IdCbteCble
                         && tbCbteCble.secuencia == _CbteCbleInfo.secuencia);

                     if (contact != null)
                     {
                         contact.idcentrocosto = _CbteCbleInfo.IdCentroCosto;
                         contact.idcentrocosto_sub_centro_costo = _CbteCbleInfo.IdCentroCosto_sub_centro_costo;
                         contact.idpunto_cargo_grupo = _CbteCbleInfo.IdPunto_cargo_grupo;
                         contact.idpunto_cargo = _CbteCbleInfo.IdPunto_cargo;
                         contact.dc_observacion = _CbteCbleInfo.dc_Observacion;
                         contact.dc_para_conciliar = _CbteCbleInfo.dc_para_conciliar;
                         contact.dc_valor = _CbteCbleInfo.dc_Valor;
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
                 throw new Exception(ex.ToString());
             }
         }
        
         public Boolean GrabarDB(ct_Cbtecble_det_Info _CbteCbleInfo,ref string MensajeError)
         {
             try
             {
                 using (EntitiesDBConta contexto = new EntitiesDBConta())
                 {
                     var lst = from q in contexto.ct_cbtecble_det
                               where q.idempresa == _CbteCbleInfo.IdEmpresa
                               && q.idtipocbte == _CbteCbleInfo.IdTipoCbte
                               && q.idcbtecble == _CbteCbleInfo.IdCbteCble
                               && q.secuencia == _CbteCbleInfo.secuencia
                               select q;

                     if (lst.Count()== 0)
                     {
                         var address_tabla = new ct_cbtecble_det();
                         address_tabla.idempresa = _CbteCbleInfo.IdEmpresa;
                         address_tabla.idtipocbte = _CbteCbleInfo.IdTipoCbte;
                         address_tabla.idcbtecble = _CbteCbleInfo.IdCbteCble;
                         address_tabla.idctacble = _CbteCbleInfo.IdCtaCble;
                         address_tabla.idcentrocosto = (String.IsNullOrEmpty(_CbteCbleInfo.IdCentroCosto)) ? null : _CbteCbleInfo.IdCentroCosto;
                         address_tabla.idcentrocosto_sub_centro_costo = (String.IsNullOrEmpty(_CbteCbleInfo.IdCentroCosto_sub_centro_costo)) ? null : _CbteCbleInfo.IdCentroCosto_sub_centro_costo;
                         address_tabla.secuencia = _CbteCbleInfo.secuencia;
                         address_tabla.dc_valor = _CbteCbleInfo.dc_Valor;
                         address_tabla.dc_observacion = (_CbteCbleInfo.dc_Observacion == null) ? "" : _CbteCbleInfo.dc_Observacion;
                         address_tabla.idpunto_cargo = _CbteCbleInfo.IdPunto_cargo;
                         address_tabla.idpunto_cargo_grupo = _CbteCbleInfo.IdPunto_cargo_grupo;
                         address_tabla.dc_para_conciliar = _CbteCbleInfo.dc_para_conciliar;

                         contexto.ct_cbtecble_det.Add(address_tabla);

                         contexto.SaveChanges();
                         contexto.Dispose();
                     }                     
                 }
                 return true;
             }
             catch (DbEntityValidationException ex)
             {
                 string arreglo = ToString();
                 
                 //VALIDACION PARA VER ERRORES DEL ENTITYFRAMEWORK						
                 foreach (var item in ex.EntityValidationErrors)
                 {
                     foreach (var item_validaciones in item.ValidationErrors)
                     {
                         mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                     }
                 }
                 tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                 tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                     "", "", "", "", DateTime.Now);
                 oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                 mensaje = ex.InnerException + " " + ex.Message;
                 throw new Exception(ex.InnerException.ToString());
             }
         }

         public Boolean GrabarDB(List<ct_Cbtecble_det_Info> lista,ref string MensajeError)
         {
             try
             {
                 foreach (var item in lista)
                 {
                     if (!GrabarDB(item, ref MensajeError)) 
                         return false;
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

         public Boolean EliminarDB(ct_Cbtecble_det_Info _CbteCbleInfo,ref string MensajeError)
         {
             try
             {
                 using (EntitiesDBConta context = new EntitiesDBConta())
                 {
                     var contact = context.ct_cbtecble_det.FirstOrDefault(tbCbteCble => tbCbteCble.idempresa == _CbteCbleInfo.IdEmpresa && tbCbteCble.idtipocbte==_CbteCbleInfo.IdTipoCbte && tbCbteCble.idcbtecble == _CbteCbleInfo.IdCbteCble);
                     if (contact != null)
                     {
                         context.ct_cbtecble_det.Remove(contact);
                         context.SaveChanges();
                         context.Dispose();
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
                 throw new Exception(ex.InnerException.ToString());
             }
         }

         public Boolean EliminarDB_cbte_en_conciliacion(List<ct_Cbtecble_det_Info> lm, ref string MensajeError)
         {
             try
             {
                 if (lm.Count == 0)
                     return true;


                 string comando = "DELETE FROM ct_cbtecble_det WHERE IdEmpresa = " + lm.First().IdEmpresa + " and Idtipocbte = " + lm.First().IdTipoCbte + " and idcbtecble = " + lm.First().IdCbteCble + " and secuencia not in ("+lm.First().secuencia;
                 int cont = 0;
                 foreach (var item in lm)
                 {
                     if (cont == 0)
                     {
                         comando += ","+item.secuencia.ToString();
                     }
                     cont++;
                 }
                 comando += ")";

                 using (EntitiesDBConta Contex = new EntitiesDBConta())
                 {
                     Contex.Database.ExecuteSqlCommand(comando);
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

         public Boolean EliminarDB(List<ct_Cbtecble_det_Info> lm, ref string MensajeError)
         {
             try
             {

                 foreach (var item in lm)
                 {
                     EliminarDB(item, ref MensajeError);
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

         public void Get_SaldoContableMesAnterior(int idempresa, string IdCtaCble, DateTime Fecha, ref decimal  Saldo,ref string MensajeError)
         {
             try
             {
                     EntitiesDBConta db = new EntitiesDBConta();
                     var select_ = from A in db.ct_cbtecble
                                   join B in db.ct_cbtecble_det on new { A.idempresa, A.idcbtecble, A.idtipocbte } equals new { B.idempresa, B.idcbtecble, B.idtipocbte }
                                   where
                                        A.idempresa == idempresa
                                        && B.idctacble == IdCtaCble
                                        && A.cb_fecha < Fecha
                                   group B by new  { B.idempresa}
                                   into grupvalor
                                   select new { grupvalor.Key, total = grupvalor.Sum(p => p.dc_valor ) };
                               

                     foreach (var item in select_)
                     {
                         Saldo=Convert.ToDecimal(item.total); 
                 
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

         public List<vwct_cbtecble_Con_Saldo_Info> Get_list_Cbtecble_Con_Saldo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,ref string MensajeError)
         {
             try
             {
                 List<vwct_cbtecble_Con_Saldo_Info> lM = new List<vwct_cbtecble_Con_Saldo_Info>();
                 EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                var select_ = from c in OECbtecble_det.vwct_cbtecble_con_saldo
                              join cc in OECbtecble_det.ct_cbtecble
                                        on new { c.idempresa, c.idcbtecble, c.idtipocbte } equals new { cc.idempresa, cc.idcbtecble, cc.idtipocbte }
                              join cte in OECbtecble_det.ct_cbtecble_tipo
                                        on new { c.idempresa, c.idtipocbte } equals new { cte.idempresa, cte.idtipocbte }
                              join ct in OECbtecble_det.ct_cbtecble_tipo
                                        on new { cte.idtipocbte } equals new { ct.idtipocbte }
                              where c.idempresa == IdEmpresa && c.saldodiario > 0 && cc.cb_fecha > FechaIni && cc.cb_fecha < FechaFin
                              select new
                              {
                                  c.idempresa,
                                  c.idtipocbte,
                                  c.idcbtecble,
                                  c.dc_valor,
                                  c.montoog,
                                  c.saldodiario,
                                  c.detalle,
                                  cc.cb_observacion,
                                  ct.tc_tipocbte,
                                  cc.cb_fecha
                              };

                 foreach (var item in select_)
                 {
                     vwct_cbtecble_Con_Saldo_Info dato = new vwct_cbtecble_Con_Saldo_Info();
                     dato.Detalle = item.detalle;
                     dato.IdCbteCble = item.idcbtecble;
                     dato.IdEmpresa = item.idempresa;
                     dato.IdTipoCbte = item.idtipocbte;
                     dato.MontoOG = item.montoog;
                     dato.Observacion = item.cb_observacion;
                     dato.SaldoDiario = item.saldodiario;
                     dato.TipoCbte = item.tc_tipocbte;
                     dato.ValorDiario = item.dc_valor;
                     dato.Fecha = item.cb_fecha;
                     dato.chek = false;
                     

                     lM.Add(dato);
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
                 mensaje = ex.ToString();
                 throw new Exception(ex.ToString());
             }
         }

        public List<vwct_cbtecble_Con_Saldo_Info> Get_list_ObtenerCbtecble_OG_otrosPagos(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte,ref string MensajeError)
         {
             List<vwct_cbtecble_Con_Saldo_Info> lM = new List<vwct_cbtecble_Con_Saldo_Info>();
             try
             {
                 
                 EntitiesDBConta OECbtecble_det = new EntitiesDBConta();
                 var select_ = from c in OECbtecble_det.vwct_cbtecble_con_saldo
                               join cc in OECbtecble_det.ct_cbtecble
                                         on new { c.idempresa, c.idcbtecble, c.idtipocbte } equals new { cc.idempresa, cc.idcbtecble, cc.idtipocbte }
                               join cte in OECbtecble_det.ct_cbtecble_tipo
                                         on new { c.idempresa, c.idtipocbte } equals new { cte.idempresa, cte.idtipocbte }
                               where c.idempresa == IdEmpresa && c.idtipocbte == IdTipoCbte && c.idcbtecble == IdCbteCble
                               select new
                               {
                                   c.idempresa,
                                   c.idtipocbte,
                                   c.idcbtecble,
                                   c.dc_valor,
                                   c.montoog,
                                   c.saldodiario,
                                   c.detalle,
                                   cc.cb_observacion,
                                   cte.tc_tipocbte,
                                   cc.cb_fecha
                               };

                 foreach (var item in select_)
                 {
                     vwct_cbtecble_Con_Saldo_Info dato = new vwct_cbtecble_Con_Saldo_Info();
                     dato.Detalle = item.detalle;
                     dato.IdCbteCble = item.idcbtecble;
                     dato.IdEmpresa = item.idempresa;
                     dato.IdTipoCbte = item.idtipocbte;
                     dato.MontoOG = item.montoog;
                     dato.Observacion = item.cb_observacion;
                     dato.SaldoDiario = item.saldodiario;
                     dato.TipoCbte = item.tc_tipocbte;
                     dato.ValorDiario = item.dc_valor;
                     dato.Fecha = item.cb_fecha;
                     dato.chek = true;

                     lM.Add(dato);
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
                 mensaje = ex.ToString();
                 lM = new List<vwct_cbtecble_Con_Saldo_Info>();
                 throw new Exception(ex.ToString());
             }
         }       
        
        public ct_Cbtecble_det_Data() 
         {
         
         }

        public List<ct_Cbtecble_det_Info> Get_list_CbteCble_x_cp_Conciliacion_caja(int IdEmpresa, decimal IdConciliacion_caja)
        {
            try
            {
                List<ct_Cbtecble_det_Info> Lista = new List<ct_Cbtecble_det_Info>();

                // PASAR EN PROCESO DE MIGRACION 2025-04-27
                //using (EntitiesDBConta Context = new EntitiesDBConta())
                //{
                //    var lst = from q in Context.vwct_cbtecble_x_cp_Conciliacion_caja
                //              where IdEmpresa == q.IdEmpresa && 
                //              IdConciliacion_caja == q.IdConciliacion_Caja
                //              select q;
                //    foreach (var item in lst)
                //    {
                //        ct_Cbtecble_det_Info info = new ct_Cbtecble_det_Info();
                //        info.IdEmpresa_conci = item.IdEmpresa;
                //        info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                //        info.tipo = item.tc_TipoCbte;
                //        info.IdEmpresa = item.IdEmpresa_cbte;
                //        info.IdTipoCbte = item.IdTipoCbte;
                //        info.IdCbteCble = item.IdCbteCble;
                //        info.secuencia = item.secuencia;
                //        info.IdCtaCble = item.IdCtaCble;
                //        info.NomCtaCble = item.nom_Cuenta;
                //        info.IdCentroCosto = item.IdCentroCosto;
                //        info.NomCentroCosto = item.nom_Centro_costo;
                //        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                //        info.NomSubCentroCosto = item.nom_Centro_costo_sub_centro_costo;
                //        info.dc_Valor_D = item.Debe;
                //        info.dc_Valor_H = item.Haber;
                //        info.dc_Observacion = item.dc_Observacion;
                //        info.IdPunto_cargo = item.IdPunto_cargo;
                //        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                //        info.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                //        info.nom_punto_cargo = item.nom_punto_cargo;                        
                //        Lista.Add(info);
                //    }
                //}

                return Lista;
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
