using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Mail
{
    public class mail_Notificacion_Config_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public string HostName { get; set; }
        public bool EmiteNotificacion { get; set; }
    }
}
