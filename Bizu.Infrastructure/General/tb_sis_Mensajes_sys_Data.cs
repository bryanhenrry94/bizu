using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_sis_Mensajes_sys_Data
    {
        string mensaje = "";

        public string getId()
        {
            try
            {
                string Id = "";

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

        public List<tb_sis_Mensajes_sys_Info> Get_List_Mensajes_sys()
        {
            try
            {
                List<tb_sis_Mensajes_sys_Info> lst = new List<tb_sis_Mensajes_sys_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var tarjetas = from q in oEnti.tb_sis_mensajes_sys
                               select q;

                foreach (var item in tarjetas)
                {
                    tb_sis_Mensajes_sys_Info info = new tb_sis_Mensajes_sys_Info();
                    info.IdMensaje = item.idmensaje;
                    info.Mensaje_Esp = item.mensaje_esp;
                    info.Mensaje_Englesh = item.mensaje_englesh;
                    info.Estado = item.estado;
                    lst.Add(info);
                }
                return lst;
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


        public Boolean Guardar(tb_sis_Mensajes_sys_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var sms = new tb_sis_mensajes_sys();

                sms.idmensaje = Info.IdMensaje;
                sms.mensaje_esp = Info.Mensaje_Esp;
                sms.mensaje_englesh = Info.Mensaje_Englesh;
                sms.estado = Info.Estado;
                context.tb_sis_mensajes_sys.Add(sms);
                context.SaveChanges();

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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar(tb_sis_Mensajes_sys_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var sms = context.tb_sis_mensajes_sys.FirstOrDefault(var => var.idmensaje == Info.IdMensaje);
                if (sms != null)
                {
                    sms.mensaje_esp = Info.Mensaje_Esp;
                    sms.mensaje_englesh = Info.Mensaje_Englesh;
                    sms.estado = Info.Estado;
                    context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                var Existe = from q in context.tb_sis_mensajes_sys
                             where q.idmensaje == Cod
                             select q;
                if (Existe.ToList().Count() > 0)
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public Boolean Anular(string IdMensaje)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var tarjeta = context.tb_sis_mensajes_sys.FirstOrDefault(var => var.idmensaje == IdMensaje);
                if (tarjeta != null)
                {
                    tarjeta.estado = "I";
                    context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarMensaje(string IdMensaje, string Mensaje_Esp)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {

                    var Existe = from q in context.tb_sis_mensajes_sys
                                 where q.mensaje_esp == Mensaje_Esp && q.idmensaje == IdMensaje
                                 select q;
                    if (Existe.ToList().Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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
    }
}