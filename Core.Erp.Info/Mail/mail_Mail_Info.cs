using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Core.Erp.Info.Mail
{
    public class mail_Mail_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMail { get; set; }
        public string IdUsuario { get; set; }
        public string Origen { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public Nullable<bool> IsBodyHtml { get; set; }
        public List<string> To { get; set; }
        public List<string> CC { get; set; }
        public string MensajeError { get; set; }
        public List<mail_Mail_Attachment_Info> mail_Mail_Attachment { get; set; }

        public mail_Mail_Info()
        {
            To = new List<string>();
            CC = new List<string>();
            mail_Mail_Attachment = new List<mail_Mail_Attachment_Info>();
        }
    }
}