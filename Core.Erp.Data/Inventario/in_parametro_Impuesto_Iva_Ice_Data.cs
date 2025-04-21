using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
    public class in_parametro_Impuesto_Iva_Ice_Data
    {
        string mensaje = "";

        public List<in_parametro_Impuesto_Iva_Ice_Info> Get_List_Impuesto_Iva_Ice(int IdEmpresa)
        {
            List<in_parametro_Impuesto_Iva_Ice_Info> lista = new List<in_parametro_Impuesto_Iva_Ice_Info>();
            EntitiesInventario oEnt = new EntitiesInventario();
            try
            {
                var select = from q in oEnt.in_parametro_Impuesto_Iva_Ice
                             where q.Idempresa == IdEmpresa
                             select q;

                foreach (var item in select)
                {
                    in_parametro_Impuesto_Iva_Ice_Info info = new in_parametro_Impuesto_Iva_Ice_Info();


                    info.Idempresa = item.Idempresa;
                    info.IdPresentacion = item.IdPresentacion;
                    info.IdCodImpuesIva = item.IdCodImpuesIva;
                    info.IdCodImpuesIce = item.IdCodImpuesIce;

                    lista.Add(info);
                }


                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public in_parametro_Impuesto_Iva_Ice_Info Get_Info_Impuesto_Iva_Ice(int IdEmpresa)
        {
            in_parametro_Impuesto_Iva_Ice_Info info = new in_parametro_Impuesto_Iva_Ice_Info();

            try
            {
                EntitiesInventario oEnt = new EntitiesInventario();

                var select = from q in oEnt.in_parametro_Impuesto_Iva_Ice
                             where q.Idempresa == IdEmpresa
                             select q;

                foreach (var item in select)
                {
                    info.Idempresa = item.Idempresa;
                    info.IdPresentacion = item.IdPresentacion;
                    info.IdCodImpuesIva = item.IdCodImpuesIva;
                    info.IdCodImpuesIce = item.IdCodImpuesIce;
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(in_parametro_Impuesto_Iva_Ice_Info info, ref string Mensaje)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var Q = from Imp in context.in_parametro_Impuesto_Iva_Ice
                            where Imp.Idempresa == info.Idempresa
                            select Imp;

                    if (Q.ToList().Count == 0)
                    {
                        if (info.IdCodImpuesIva != "" || info.IdCodImpuesIce != "" || info.IdPresentacion != "")
                        {
                           var addressG = new in_parametro_Impuesto_Iva_Ice();

                           addressG.Idempresa = info.Idempresa;
                           addressG.IdCodImpuesIva = info.IdCodImpuesIva;
                           addressG.IdCodImpuesIce = info.IdCodImpuesIce;
                           addressG.IdPresentacion = info.IdPresentacion;

                           context.in_parametro_Impuesto_Iva_Ice.Add(addressG);
                           context.SaveChanges();
                           Mensaje = "Registro Ingresado Correctamente";
                        }
                    }
                    else 
                    {
                        ModificarDB(info);
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

        public Boolean ModificarDB(in_parametro_Impuesto_Iva_Ice_Info info)
        {
            try
            {
                using (EntitiesInventario oEnti = new EntitiesInventario())
                {
                    var registro = oEnti.in_parametro_Impuesto_Iva_Ice.FirstOrDefault(inp => inp.Idempresa == info.Idempresa);
                    if (registro != null)
                    {
                        registro.IdCodImpuesIva = info.IdCodImpuesIva;
                        registro.IdCodImpuesIce = info.IdCodImpuesIce;
                        registro.IdPresentacion = info.IdPresentacion;
                        oEnti.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal Id;
                EntitiesInventario OECbtecble = new EntitiesInventario();
                var q = from A in OECbtecble.in_parametro_Impuesto_Iva_Ice
                        where A.Idempresa == IdEmpresa
                        select A;

                if (q.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    OECbtecble = new EntitiesInventario();
                    var selectCbtecble = (from CbtCble in OECbtecble.in_presentacion
                                          where CbtCble.IdEmpresa == IdEmpresa
                                          select CbtCble.IdEmpresa).Count();

                    Id = Convert.ToDecimal(selectCbtecble.ToString()) + 1;
                }
                return Id;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
