using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Facturacion
{
     public class fa_cliente_contactos_Info
    {
        public int IdEmpresa_cli { get; set; }
        public decimal IdCliente { get; set; }
        public int IdEmpresa_cont { get; set; }
        public decimal IdContacto { get; set; }
        public string observacion { get; set; }

        public tb_contacto_Info Contacto_Info { get; set; }
        public fa_Cliente_Info  Cliente_Info { get; set; }

        public int IdEmpresa { get; set; }
        public int Secuencia { get; set; }
        public string IdCodigoRuc { get; set; }
        public string ConNombre { get; set; }
        public string ConApellido { get; set; }
        public string ConTelefono { get; set; }
        public string ConDireccion { get; set; }


        public fa_cliente_contactos_Info()
        {
            Contacto_Info = new tb_contacto_Info();
            Cliente_Info = new fa_Cliente_Info();
        }
    }
}
