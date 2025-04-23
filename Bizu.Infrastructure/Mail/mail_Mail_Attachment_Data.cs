using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Mail;

namespace Bizu.Infrastructure.Mail
{
    public class mail_Mail_Attachment_Data
    {
        public bool GrabarBD(List<mail_Mail_Attachment_Info> List)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                foreach(var Info in List)
                {
                    var Addres = new mail_Mail_Attachment();
                    Addres.IdEmpresa = Info.IdEmpresa;
                    Addres.IdSucursal = Info.IdSucursal;
                    Addres.IdMail = Info.IdMail;
                    Addres.Secuencia = Info.Secuencia = getSecuencia(Info);
                    Addres.nombre = Info.nombre;
                    Addres.archivo = Info.archivo;

                    context.mail_Mail_Attachment.Add(Addres);
                    context.SaveChanges();
                }
                      
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, int IdSucursal, int IdMail)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                string SQL = $"DELETE FROM mail_Mail_Attachment WHERE IdEmpresa = {IdEmpresa} AND IdSucursal = {IdSucursal} AND IdMail = {IdMail};";

                int filasAfectadas = context.Database.ExecuteSqlCommand(SQL);
                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<mail_Mail_Attachment_Info> Get_List(int IdEmpresa, int IdSucursal, int IdMail)
        {
            List<mail_Mail_Attachment_Info> lista = new List<mail_Mail_Attachment_Info>();

            try
            {
                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Mail_Attachment
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdMail == IdMail
                            select q;

                foreach(var item in query)
                {
                    mail_Mail_Attachment_Info Info = new mail_Mail_Attachment_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdMail = item.IdMail;
                    Info.Secuencia = item.Secuencia;
                    Info.nombre = item.nombre;
                    Info.archivo = item.archivo;
                    lista.Add(Info);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        private int getSecuencia(mail_Mail_Attachment_Info Info)
        {
            int Secuencia = 0;

            try
            {
                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Mail_Attachment
                            where q.IdEmpresa == Info.IdEmpresa
                            && q.IdSucursal == Info.IdSucursal
                            && q.IdMail == Info.IdMail
                            select q;

                if (query.Count() <= 0)
                {
                    Secuencia = 1;
                }
                else
                {
                    Secuencia = (from q in context.mail_Mail_Attachment
                                 where q.IdEmpresa == Info.IdEmpresa
                                 && q.IdSucursal == Info.IdSucursal
                                 && q.IdMail == Info.IdMail
                                 select q.Secuencia).Max() + 1;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Secuencia;
        }
    }
}
