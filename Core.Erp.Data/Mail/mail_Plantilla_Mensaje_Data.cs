using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Mail;

namespace Core.Erp.Data.Mail
{
    public class mail_Plantilla_Mensaje_Data
    {
        public Boolean GrabarBD(mail_Plantilla_Mensaje_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                mail_Plantilla_Mensaje Address = new mail_Plantilla_Mensaje();
                Address.IdEmpresa = Info.IdEmpresa;
                Address.IdMensaje = Info.IdMensaje;
                Address.Mensaje = Info.Mensaje;
                Address.Estado = Info.Estado;

                context.mail_Plantilla_Mensaje.Add(Address);
                context.SaveChanges();

                mensaje = "Plantilla registrada realizado con éxito!";

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public Boolean ModificarBD(mail_Plantilla_Mensaje_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                var Address = (from q in context.mail_Plantilla_Mensaje
                               where q.IdEmpresa == Info.IdEmpresa
                               && q.IdMensaje == Info.IdMensaje
                               select q).First();

                if (Address != null)
                {
                    Address.Mensaje = Info.Mensaje;
                    Address.Estado = Info.Estado;

                    context.SaveChanges();

                    mensaje = "Plantilla actualizado realizado con éxito!";
                }

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public List<mail_Plantilla_Mensaje_Info> Get_List(int IdEmpresa)
        {
            try
            {
                List<mail_Plantilla_Mensaje_Info> Lista = new List<mail_Plantilla_Mensaje_Info>();

                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Plantilla_Mensaje
                               where q.IdEmpresa == IdEmpresa
                               select q;

                foreach (var item in query)
                {
                    mail_Plantilla_Mensaje_Info Info = new mail_Plantilla_Mensaje_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdMensaje = item.IdMensaje;
                    Info.Mensaje = item.Mensaje;
                    Info.Estado = item.Estado;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public mail_Plantilla_Mensaje_Info Get_Info(int IdEmpresa, string IdMensaje)
        {
            try
            {
                mail_Plantilla_Mensaje_Info Info = new mail_Plantilla_Mensaje_Info();

                EntitiesMail context = new EntitiesMail();

                var Address = (from q in context.mail_Plantilla_Mensaje
                            where q.IdEmpresa == IdEmpresa
                            && q.IdMensaje == IdMensaje
                            select q).First();

                if (Address != null)
                {
                    Info.IdEmpresa = Address.IdEmpresa;
                    Info.IdMensaje = Address.IdMensaje;
                    Info.Mensaje = Address.Mensaje;
                    Info.Estado = Address.Estado;
                }

                return Info;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
