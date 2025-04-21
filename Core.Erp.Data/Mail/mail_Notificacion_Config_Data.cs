using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Mail;

namespace Core.Erp.Data.Mail
{
    public class mail_Notificacion_Config_Data
    {
        public List<mail_Notificacion_Config_Info> Get_List(int IdEmpresa, string IdUsuario)
        {
            List<mail_Notificacion_Config_Info> lista = new List<mail_Notificacion_Config_Info>();

            try {
                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Notificacion_Config
                            where q.IdEmpresa == IdEmpresa
                            && q.IdUsuario == IdUsuario
                            select q;

                foreach(var item in query)
                {
                    mail_Notificacion_Config_Info Info = new mail_Notificacion_Config_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdUsuario = item.IdUsuario;
                    Info.HostName = item.HostName;
                    Info.EmiteNotificacion = item.EmiteNotificacion;

                    lista.Add(Info);
                }
            }catch(Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        public mail_Notificacion_Config_Info Get_Info(int IdEmpresa, string IdUsuario, string HostName)
        {
            mail_Notificacion_Config_Info Info = new mail_Notificacion_Config_Info();

            try
            {
                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Notificacion_Config
                            where q.IdEmpresa == IdEmpresa
                            && q.IdUsuario == IdUsuario
                            && q.HostName == HostName
                            select q;

                foreach (var item in query)
                {                    
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdUsuario = item.IdUsuario;
                    Info.HostName = item.HostName;
                    Info.EmiteNotificacion = item.EmiteNotificacion;                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Info;
        }

        public bool ExisteBD(int IdEmpresa, string IdUsuario, string HostName)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Notificacion_Config
                            where q.IdEmpresa == IdEmpresa
                            && q.IdUsuario == IdUsuario
                            && q.HostName == HostName
                            select q;

                if (query.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public bool GrabarBD(mail_Notificacion_Config_Info Info)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                mail_Notificacion_Config objInfo = new mail_Notificacion_Config();
                objInfo.IdEmpresa = Info.IdEmpresa;
                objInfo.IdUsuario = Info.IdUsuario;
                objInfo.HostName = Info.HostName;
                objInfo.EmiteNotificacion = Info.EmiteNotificacion;

                context.mail_Notificacion_Config.Add(objInfo);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
