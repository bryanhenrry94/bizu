using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;


namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_Centro_costo_Data
    {
        
        public ct_Centro_costo_Info _CentroCostoInfo = new ct_Centro_costo_Info();

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo(int IdEmpresa,ref string MensajeError)
        {
            try
            {
                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();
                EntitiesDBConta OECentroCost = new EntitiesDBConta();
                var selectCentroCost = from C in OECentroCost.vwct_centro_costo
                                          where C.idempresa == IdEmpresa
                                       select C;

                foreach (var item in selectCentroCost)
                {
                    ct_Centro_costo_Info Cbt = new ct_Centro_costo_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdCentroCosto = item.idcentrocosto.Trim();
                    Cbt.CodCentroCosto = item.codcentrocosto.Trim();
                    Cbt.Centro_costo = item.centro_costo;
                    Cbt.Centro_costo2 = "[" + item.idcentrocosto + "]" + item.centro_costo;
                    Cbt.IdCentroCostoPadre = item.idcentrocostopadre;// DEBE TRAER NULL SI NO TIENE PADRE
                    Cbt.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    Cbt.pc_EsMovimiento = item.pc_esmovimiento;
                    Cbt.IdNivel = item.idnivel;
                    Cbt.pc_Estado = item.pc_estado;
                    Cbt.Centro_costoPadre = item.centro_costopadre;
                    Cbt.IdCtaCble = (item.idctacble != null) ? item.idctacble.Trim() : "";
                    lM.Add(Cbt);
                }
                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<ct_Centro_costo_Info> Get_list_Centro_costo_x_IdCuentas_Padre(int IdEmpresa, string IdCuenta_Padre, ref string MensajeError)
        {
            try
            {

                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();
                EntitiesDBConta OECentroCost = new EntitiesDBConta();
                var selectCentroCost = from C in OECentroCost.ct_centro_costo
                                       where C.idempresa == IdEmpresa 
                                       && C.idcentrocostopadre == IdCuenta_Padre
                                       select C;

                foreach (var item in selectCentroCost)
                {
                    ct_Centro_costo_Info Cbt = new ct_Centro_costo_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdCentroCosto = item.idcentrocosto.Trim();
                    Cbt.CodCentroCosto = item.codcentrocosto;
                    Cbt.Centro_costo = item.centro_costo.Trim();
                    Cbt.Centro_costo2 = "[" + item.codcentrocosto.Trim() + "] - " + item.centro_costo.Trim();
                    Cbt.IdCentroCostoPadre = item.idcentrocostopadre;
                    Cbt.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    Cbt.pc_EsMovimiento = item.pc_esmovimiento;
                    Cbt.IdNivel = item.idnivel;
                    Cbt.pc_Estado = item.pc_estado;
                    Cbt.IdCtaCble = item.idctacble;
                    Cbt.CodCentroCosto = item.codcentrocosto;
                    lM.Add(Cbt);
                }

                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }


        }
        
        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_de_Movimiento(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();
                EntitiesDBConta OECentroCost = new EntitiesDBConta();
                var selectCentroCost = from C in OECentroCost.vwct_centro_costo
                                       where C.idempresa == IdEmpresa && C.pc_esmovimiento == "S"
                                       && C.pc_estado == "A"
                                       select C;

                foreach (var item in selectCentroCost)
                {
                    ct_Centro_costo_Info Cbt = new ct_Centro_costo_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdCentroCosto = item.idcentrocosto; //se quito el trim
                    Cbt.CodCentroCosto = item.codcentrocosto;
                    Cbt.Centro_costo2 = "[" + item.idcentrocosto.Trim() + "] - " + item.centro_costo.Trim();
                    Cbt.Centro_costo = item.centro_costo.Trim();
                    Cbt.IdCentroCostoPadre = item.idcentrocostopadre;
                    Cbt.IdCatalogo = Convert.ToDecimal(item.idcatalogo);
                    Cbt.pc_EsMovimiento = item.pc_esmovimiento;
                    Cbt.IdNivel = item.idnivel;
                    Cbt.IdCtaCble = item.idctacble;
                    Cbt.Centro_costoPadre = item.centro_costopadre;
                    Cbt.pc_Estado = item.pc_estado;
                    Cbt.Sestado = (item.pc_estado == "A") ? "ACTIVO" : "*ANULADO*"; 

                    lM.Add(Cbt);
                }
                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }


        }

        public List<ct_Centro_costo_Info> Get_list_Centro_Costo_cuentas_padre(int IdEmpresa, ref string MensajeError)
        {
         
            try
            {
                List<ct_Centro_costo_Info> lM = new List<ct_Centro_costo_Info>();
                EntitiesDBConta OECentroCost = new EntitiesDBConta();
                var selectCentroCost = from C in OECentroCost.vwct_centro_costo
                                       where C.idempresa == IdEmpresa 
                                       select C;

                foreach (var item in selectCentroCost)
                {
                    ct_Centro_costo_Info Cbt = new ct_Centro_costo_Info();
                    Cbt.IdEmpresa = item.idempresa;
                    Cbt.IdCentroCosto = item.idcentrocosto; //se quito el trim
                    Cbt.CodCentroCosto = item.codcentrocosto;
                    Cbt.Centro_costo2 = "[" + item.idcentrocosto.Trim() + "] - " + item.centro_costo.Trim();
                    Cbt.Centro_costo = item.centro_costo;
                    Cbt.IdCentroCostoPadre = item.idcentrocostopadre;
                    Cbt.pc_EsMovimiento = item.pc_esmovimiento;
                    Cbt.IdNivel = item.idnivel;
                    Cbt.IdCtaCble = item.idctacble;
                    Cbt.Centro_costoPadre = item.centro_costopadre;

                    lM.Add(Cbt);
                }
                return (lM);
            }

            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }        

        public string Get_IdCentroCosto_x_Raiz(int IdEmpresa, ref string MensajeError)
        {
            //try
            //{
            //    int Id;
            //    int Digito_x_Nivel1 = 0;
            //    string IdCentroCosto = "";
            //    EntitiesDBConta base_ = new EntitiesDBConta();

            //    var q1 = from C in base_.ct_centro_costo_nivel
            //            where C.IdEmpresa == IdEmpresa
            //            && C.IdNivel==1
            //            select C;

            //    foreach (var item in q1)
            //    {
            //        Digito_x_Nivel1 = item.ni_digitos;
            //    }

            //    if (Digito_x_Nivel1 > 0)
            //    {

            //        var q = from C in base_.ct_centro_costo
            //                where C.IdEmpresa == IdEmpresa
            //                select C;
            //        if (q.ToList().Count == 0)
            //        {
            //            IdCentroCosto = "1";
            //            IdCentroCosto = IdCentroCosto.PadLeft(Digito_x_Nivel1, '0');
            //        }

            //        else
            //        {

            //            var select_ = (from CbtCble in base_.ct_centro_costo
            //                           where CbtCble.IdEmpresa == IdEmpresa
            //                           && CbtCble.IdNivel==1
            //                           select CbtCble.IdCentroCosto).Count();
            //            Id = Convert.ToInt32(select_) + 1;

            //            IdCentroCosto = Id.ToString();
            //            IdCentroCosto = IdCentroCosto.PadLeft(Digito_x_Nivel1, '0');
            //            //IdCentroCosto.PadLeft(Digito_x_Nivel1, '0');

            //        }
            //    }

            //    return IdCentroCosto;

            //}
            //catch (Exception ex)
            //{
            //    string arreglo = ToString();
            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
            //                        "", "", "", "", DateTime.Now);
            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
            //    MensajeError = ex.ToString();
            //    throw new Exception(ex.ToString());
            //}

            return "";
        }
        
        public Boolean ModificarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo.FirstOrDefault(minfo => minfo.idcentrocosto == info.IdCentroCosto && minfo.idempresa == info.IdEmpresa);

                    if (contact != null)
                    {
                        contact.idempresa = info.IdEmpresa;
                        contact.idcentrocosto = info.IdCentroCosto;
                        contact.codcentrocosto = (info.CodCentroCosto == null) ? info.IdCentroCosto : info.CodCentroCosto.Trim();
                        contact.centro_costo = info.Centro_costo;
                        contact.idcentrocostopadre = (info.IdCentroCostoPadre == "") ? null : info.IdCentroCostoPadre;
                        contact.idcatalogo = info.IdCatalogo;
                        contact.idnivel = Convert.ToByte(info.IdNivel);
                        contact.pc_esmovimiento = (info.pc_EsMovimiento == "")? "S" : Convert.ToString(info.pc_EsMovimiento);
                        contact.idctacble = info.IdCtaCble;
                        contact.pc_estado = info.pc_Estado;
                        contact.idusuarioultmod = info.IdUsuarioUltMod;
                        contact.fecha_ultmod = info.Fecha_UltMod;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean GrabarDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    EntitiesDBConta EDB = new EntitiesDBConta();
                    var Q = from per in EDB.ct_centro_costo
                            where per.idcentrocosto.Trim() == info.IdCentroCosto.Trim() && per.idempresa == info.IdEmpresa
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        var address = new ct_centro_costo();
                        address.idempresa = info.IdEmpresa;
                        address.idcentrocosto = info.IdCentroCosto;
                        address.codcentrocosto = (info.CodCentroCosto == null) ? info.IdCentroCosto : info.CodCentroCosto.Trim();
                        address.centro_costo = info.Centro_costo;
                        address.idcentrocostopadre = (info.IdCentroCostoPadre == "") ? null : info.IdCentroCostoPadre;
                        address.idcatalogo = info.IdCatalogo;
                        address.pc_esmovimiento = info.pc_EsMovimiento;
                        address.idctacble = (info.IdCtaCble == null) ? "1" : info.IdCtaCble;
                        address.idnivel = (info.IdNivel == 0) ? 1 : info.IdNivel;
                        address.pc_estado = info.pc_Estado;
                        address.fecha_transac = info.Fecha_Transac;
                        address.idusuario = info.IdUsuario;
                        context.ct_centro_costo.Add(address);
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean AnularDB(ct_Centro_costo_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_centro_costo.FirstOrDefault(dinfo => dinfo.idempresa == info.IdEmpresa && dinfo.idcentrocosto == info.IdCentroCosto);

                    if (contact != null)
                    {
                        contact.pc_estado = "I";
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificaNivel(int IdNivel, int IdEmpresa, ref string MensajeError)
        {
            //try
            //{
            //    EntitiesDBConta tabla = new EntitiesDBConta();
            //    var q = (from reg in tabla.ct_centro_costo_nivel
            //             where reg.IdEmpresa == IdEmpresa
            //             select reg.IdNivel).Max();
            //    return (Convert.ToInt32(q.ToString()) == IdNivel) ? true : false;
            //}
            //catch (Exception ex)
            //{
            //    MensajeError = ex.Message;
            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", MensajeError, "",
            //                        "", "", "", "", DateTime.Now);
            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
            //    MensajeError = ex.ToString();
            //    throw new Exception(ex.ToString());
            //}

            return false;
        }
        
        public ct_Centro_costo_Data()
        {
            
        }
    }
}

