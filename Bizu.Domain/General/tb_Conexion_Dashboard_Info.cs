using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.General
{
    public class tb_Conexion_Dashboard_Info
    {
        public int Id { get; set; }
        public string Provider { get; set; }
        public string ServerName { get; set; }
        public string PortNumber { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string StringConnection { get; set; }
    }
}
