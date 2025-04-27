using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.Contabilidad
{
    public class ct_Grupocble_Data
    {
        string mensaje = "";
        public List<ct_Grupocble_Info> Get_list_Grupocble()
        {
            try
            {

                List<ct_Grupocble_Info> lM = new List<ct_Grupocble_Info>();
                EntitiesDBConta OEGrupocble_Info = new EntitiesDBConta();
                var selectGrupocble = from C in OEGrupocble_Info.ct_grupocble

                                      select C;

                foreach (var item in selectGrupocble)
                {
                    ct_Grupocble_Info Cbt = new ct_Grupocble_Info();
                    Cbt.IdGrupoCble = item.idgrupocble;
                    Cbt.gc_GrupoCble = item.gc_grupocble;
                    Cbt.gc_Orden = Convert.ToInt32(item.gc_orden);
                    Cbt.gc_estado_financiero = item.gc_estado_financiero;
                    Cbt.gc_signo_operacion = Convert.ToInt32(item.gc_signo_operacion);
                    Cbt.Estado = item.estado;
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }


        }

        public Boolean ModificarDB(ct_Grupocble_Info info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_grupocble.FirstOrDefault(dato => dato.idgrupocble == info.IdGrupoCble);
                    if (contact != null)
                    {
                        contact.idgrupocble = info.IdGrupoCble;
                        contact.gc_grupocble = info.gc_GrupoCble;
                        contact.gc_orden = Convert.ToByte(info.gc_Orden);
                        contact.gc_estado_financiero = info.gc_estado_financiero;
                        contact.gc_signo_operacion = info.gc_signo_operacion;
                        contact.estado = info.Estado;
                        context.SaveChanges();
                        res = true;
                    }
                    else
                    {
                        mensaje = "no se pudo modificar el grupo Cta Cble: " + info.IdGrupoCble;
                        return false;
                    }
                }
                return res;
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

        public Boolean GrabarDB(ct_Grupocble_Info info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var Q = from per in context.ct_grupocble
                            where per.idgrupocble == info.IdGrupoCble
                            select per;

                    if (Q.ToList().Count == 0)
                    {

                        var address = new ct_grupocble();
                        address.idgrupocble = info.IdGrupoCble;
                        address.gc_grupocble = info.gc_GrupoCble;
                        address.gc_orden = Convert.ToByte(info.gc_Orden);
                        address.gc_estado_financiero = info.gc_estado_financiero;
                        address.gc_signo_operacion = info.gc_signo_operacion;
                        address.estado = info.Estado;
                        context.ct_grupocble.Add(address);
                        context.SaveChanges();
                        res = true;
                    }
                    else
                    {

                        mensaje = "No se pudo guardar el Grupo Cta Cble: " + info.IdGrupoCble + " ,Por favor revise si ya se encuenta ingresado";
                        return false;
                    }
                }
                return res;
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

        public Boolean EliminarDB(ct_Grupocble_Info info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var contact = context.ct_grupocble.FirstOrDefault(dato => dato.idgrupocble == info.IdGrupoCble);
                    if (contact != null)
                    {
                        contact.estado = "I";
                        context.SaveChanges();
                        res = true;
                    }
                    else
                    {
                        mensaje = "no se pudo eleminar el grupo Cta Cble: " + info.IdGrupoCble;
                        return false;
                    }
                }
                return res;
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
