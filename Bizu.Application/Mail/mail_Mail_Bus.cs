using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using Bizu.Infrastructure.Mail;
using Bizu.Domain.Mail;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace Bizu.Application.Mail
{
    public class mail_Mail_Bus
    {
        mail_Mail_Data Data = new mail_Mail_Data();

        public Boolean GrabarBD(mail_Mail_Info Info_Mail, ref string mensaje)
        {
            try
            {
                if (Data.GrabarBD(Info_Mail, ref mensaje))
                {
                    if (Info_Mail.mail_Mail_Attachment.Count() > 0)
                    {
                        mail_Mail_Attachment_Bus bus_mail_Attachment = new mail_Mail_Attachment_Bus();

                        int iSecuencia = 0;
                        foreach (var item in Info_Mail.mail_Mail_Attachment)
                        {
                            item.IdEmpresa = Info_Mail.IdEmpresa;
                            item.IdSucursal = Info_Mail.IdSucursal;
                            item.IdMail = Info_Mail.IdMail;
                            item.Secuencia = iSecuencia++;
                        }

                        bus_mail_Attachment.GrabarBD(Info_Mail.mail_Mail_Attachment);
                    }

                    return true;
                }
                else
                {
                    return false;
                }
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
                return Data.Get_List(IdEmpresa, IdSucursal, IdUsuario, NumeroRegistros);
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
                return Data.Get_List(IdEmpresa, IdSucursal, IdUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string GenerateMessageId(string domain)
        {
            // Generar un GUID y formatearlo según el estándar de Message-ID
            return $"<{Guid.NewGuid()}@{domain}>";
        }

        public void Emviar_Mail(mail_Mail_Info Info_Mail, ref string mensaje)
        {
            try
            {
                if (Info_Mail.IdEmpresa == null || Info_Mail.IdEmpresa == 0)
                {
                    throw new Exception("El campo IdEmpresa es obligatorio para el envio de correo, por favor verifique los valores enviados por parametro");
                }

                if (String.IsNullOrEmpty(Info_Mail.Asunto))
                {
                    throw new Exception("El campo Asunto es obligatorio para el envio de correo, por favor verifique los valores enviados por parametro");
                }

                if (String.IsNullOrEmpty(Info_Mail.Mensaje))
                {
                    throw new Exception("El campo Mensaje es obligatorio para el envio de correo, por favor verifique los valores enviados por parametro");
                }

                if (Info_Mail.To.Count() <= 0)
                {
                    throw new Exception("Ingrese por lo menos un destinatario para el envio de correo!");
                }

                mail_Cuenta_Correo_Bus Bus_Cuenta_Correo = new mail_Cuenta_Correo_Bus();
                mail_Cuenta_Correo_Info Info_Cuenta_Correo = new mail_Cuenta_Correo_Info();

                string IdCuenta = Bus_Cuenta_Correo.Get_IdCuenta_Predeterminada(Info_Mail.IdEmpresa);

                if (string.IsNullOrEmpty(IdCuenta))
                {
                    throw new Exception("Por favor verifique en la configuración de Empresas que exista una cuenta de correo predeterminada para el envio de Notificaciones!");
                }

                Info_Cuenta_Correo = Bus_Cuenta_Correo.Get_Info(Info_Mail.IdEmpresa, IdCuenta);

                SmtpClient smtpClient = new SmtpClient(Info_Cuenta_Correo.Servidor_Correo, Info_Cuenta_Correo.Puerto);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(Info_Cuenta_Correo.Usuario, Info_Cuenta_Correo.Contrasena);

                switch (Info_Cuenta_Correo.Tipo_Conexion)
                {
                    case "SSL":
                        smtpClient.EnableSsl = true;
                        break;

                    case "TLS":
                        smtpClient.EnableSsl = false;
                        break;

                    case "NA":
                        smtpClient.EnableSsl = false;
                        break;
                }

                MailMessage mm = new MailMessage();
                mm.From = new MailAddress(Info_Cuenta_Correo.Direccion_Correo, "\'Notificaciones vSynergy\'");
                mm.Subject = Info_Mail.Asunto;
                mm.IsBodyHtml = true;
                mm.Body = Info_Mail.Mensaje;
                

                // Obtener las propiedades globales de la red
                IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();

                // Obtener el nombre del host
                string hostname = properties.HostName;

                // Obtener el sufijo DNS primario
                string primaryDnsSuffix = properties.DomainName;

                // Si no hay un valor en DomainName, intentar obtenerlo desde las interfaces de red
                if (string.IsNullOrEmpty(primaryDnsSuffix))
                {
                    foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                    {
                        IPInterfaceProperties ipProperties = ni.GetIPProperties();
                        if (!string.IsNullOrEmpty(ipProperties.DnsSuffix))
                        {
                            primaryDnsSuffix = ipProperties.DnsSuffix;
                            break;
                        }
                    }
                }

                string messageId = GenerateMessageId($"{hostname}.{primaryDnsSuffix}");
                //string messageId = GenerateMessageId(hostname);
               

                mm.Headers.Add("Message-ID", messageId);

                foreach (var correo in Info_Mail.To)
                {
                    //if (Email_Valido(correo))
                    //    mm.To.Add(correo);
                    //else
                    //    throw new Exception("La cuenta de correo [" + correo + "] no es valida");
                    mm.To.Add(correo);
                }

                foreach (var correo in Info_Mail.CC)
                {
                    //if (Email_Valido(correo))
                    //    mm.CC.Add(correo);
                    mm.CC.Add(correo);
                }

                if (Info_Cuenta_Correo.Enviar_copia_correo_oculta)
                {
                    //if (!string.IsNullOrEmpty(Info_Cuenta_Correo.Cuenta_Correo_Copia))
                    //    if (Email_Valido(Info_Cuenta_Correo.Cuenta_Correo_Copia))
                    //        mm.Bcc.Add(Info_Cuenta_Correo.Cuenta_Correo_Copia);

                    if (!string.IsNullOrEmpty(Info_Cuenta_Correo.Cuenta_Correo_Copia))
                    {
                        //if (Email_Valido(Info_Cuenta_Correo.Cuenta_Correo_Copia))
                        mm.Bcc.Add(Info_Cuenta_Correo.Cuenta_Correo_Copia);
                    }
                }

                mail_Mail_Attachment_Bus BusMailAttachment = new mail_Mail_Attachment_Bus();
                Info_Mail.mail_Mail_Attachment = BusMailAttachment.Get_List(Info_Mail.IdEmpresa, Info_Mail.IdSucursal, Info_Mail.IdMail);
                
                foreach (var item in Info_Mail.mail_Mail_Attachment)
                {
                    if (item.archivo != null)
                    {
                        mm.Attachments.Add(new Attachment(new System.IO.MemoryStream(item.archivo), item.nombre));
                    }
                }
                
                try
                {
                    smtpClient.Send(mm);

                    mensaje = "Notificación realizada con éxito!";

                    // ELIMINO LOS ADJUNTOS
                    mail_Mail_Attachment_Data DataMailAttachment = new mail_Mail_Attachment_Data();
                    DataMailAttachment.EliminarBD(Info_Mail.IdEmpresa, Info_Mail.IdSucursal, Info_Mail.IdMail);

                    // ELIMINO EL CORREO
                    Data.EliminarBD(Info_Mail, ref  mensaje);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;

                    Info_Mail.MensajeError = mensaje;
                    Data.Grabar_MensajeError(Info_Mail, ref mensaje);
                }

                mm.Dispose();
                smtpClient.Dispose();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

                Info_Mail.MensajeError = mensaje;
                Data.Grabar_MensajeError(Info_Mail, ref mensaje);
            }
        }

        public Boolean EliminarBD(mail_Mail_Info Info_Mail, ref string mensaje)
        {
            try
            {
                return Data.EliminarBD(Info_Mail, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Email_Valido(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}