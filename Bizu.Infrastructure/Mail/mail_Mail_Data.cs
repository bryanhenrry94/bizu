using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Mail;

namespace Bizu.Infrastructure.Mail
{
    public class mail_Mail_Data
    {
        public Boolean GrabarBD(mail_Mail_Info Info_Mail, ref string mensaje)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                mail_Mail Address = new mail_Mail();
                Address.IdEmpresa = Info_Mail.IdEmpresa;
                Address.IdSucursal = Info_Mail.IdSucursal;
                Info_Mail.IdMail = Get_ID(Info_Mail.IdEmpresa, Info_Mail.IdSucursal);
                Address.IdMail = Info_Mail.IdMail;
                Address.IdUsuario = Info_Mail.IdUsuario;
                Address.Origen = Info_Mail.Origen;
                Address.Asunto = Info_Mail.Asunto;
                Address.Mensaje = Info_Mail.Mensaje;
                Address.IsBodyHtml = Info_Mail.IsBodyHtml;

                foreach (var item in Info_Mail.To)
                {
                    if (string.IsNullOrEmpty(Address.Para))
                        Address.Para = item;
                    else
                        Address.Para += "; " + item;
                }

                foreach (var item in Info_Mail.CC)
                {
                    if (string.IsNullOrEmpty(Address.CC))
                        Address.CC = item;
                    else
                        Address.CC += "; " + item;
                }

                Address.MensajeError = "";

                context.mail_Mail.Add(Address);
                context.SaveChanges();

                mensaje = "Mensaje registrado con éxito!";

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public Boolean Grabar_MensajeError(mail_Mail_Info Info_Mail, ref string mensaje)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                mail_Mail Address = new mail_Mail();

                Address = (from q in context.mail_Mail
                           where q.IdEmpresa == Info_Mail.IdEmpresa
                           && q.IdSucursal == Info_Mail.IdSucursal
                           && q.IdMail == Info_Mail.IdMail
                           select q).First();

                if (Address != null)
                {
                    Address.MensajeError = Info_Mail.MensajeError;

                    context.SaveChanges();

                    mensaje = "Mensaje de error registrado con éxito!";

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public List<mail_Mail_Info> Get_List(int IdEmpresa, int IdSucursal, string IdUsuario, int NumeroRegistros)
        {
            try
            {
                List<mail_Mail_Info> Lista = new List<mail_Mail_Info>();

                EntitiesMail context = new EntitiesMail();

                var query = (from q in context.mail_Mail
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdUsuario == IdUsuario
                            select q).Take(NumeroRegistros);

                foreach (var item in query)
                {
                    mail_Mail_Info Info = new mail_Mail_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMail = item.IdMail;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Origen = item.Origen;
                    Info.Asunto = item.Asunto;
                    Info.Mensaje = item.Mensaje;
                    Info.IsBodyHtml = item.IsBodyHtml;

                    if (!string.IsNullOrEmpty(item.Para))
                    {
                        foreach (var item2 in item.Para.Split(';'))
                        {
                            Info.To.Add(item2);
                        }
                    }

                    if (!string.IsNullOrEmpty(item.CC))
                    {
                        foreach (var item2 in item.CC.Split(';'))
                        {
                            Info.CC.Add(item2);
                        }
                    }

                    Info.MensajeError = item.MensajeError;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<mail_Mail_Info> Get_List(int IdEmpresa, int IdSucursal, string IdUsuario)
        {
            try
            {
                List<mail_Mail_Info> Lista = new List<mail_Mail_Info>();

                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Mail
                             where q.IdEmpresa == IdEmpresa
                             && q.IdSucursal == IdSucursal
                             && q.IdUsuario == IdUsuario
                            select q;

                foreach (var item in query)
                {
                    mail_Mail_Info Info = new mail_Mail_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMail = item.IdMail;
                    Info.IdUsuario = item.IdUsuario;
                    Info.Origen = item.Origen;
                    Info.Asunto = item.Asunto;
                    Info.Mensaje = item.Mensaje;
                    Info.IsBodyHtml = item.IsBodyHtml;

                    if (!string.IsNullOrEmpty(item.Para))
                    {
                        foreach (var item2 in item.Para.Split(';'))
                        {
                            Info.To.Add(item2);
                        }
                    }

                    if (!string.IsNullOrEmpty(item.CC))
                    {
                        foreach (var item2 in item.CC.Split(';'))
                        {
                            Info.CC.Add(item2);
                        }
                    }

                    Info.MensajeError = item.MensajeError;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarBD(mail_Mail_Info Info_Mail, ref string mensaje)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                int iFilasAfectadas = context.Database.ExecuteSqlCommand("DELETE FROM mail_Mail WHERE IdEmpresa = " + Info_Mail.IdEmpresa + " and IdSucursal = " + Info_Mail.IdSucursal + " and IdMail = " + Info_Mail.IdMail);

                mensaje = iFilasAfectadas + " registros afectados!";

                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public int Get_ID(int IdEmpresa, int IdSucursal)
        {
            try
            {
                int Id = 0;

                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Mail
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            select q;

                if (query.Count() > 0)
                {
                    Id = (from q in context.mail_Mail
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          select q.IdMail).Max() + 1;
                }
                else
                    Id = 1;

                return Id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}