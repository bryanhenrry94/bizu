using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Mail
{
    public class mail_Mail_Attachment_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMail { get; set; }
        public int Secuencia { get; set; }
        public string nombre { get; set; }
        public byte[] archivo { get; set; }

        public mail_Mail_Info mail_Mail { get; set; }
    }
}
