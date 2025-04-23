using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Mail
{
    public class mail_Cuenta_Correo_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCuenta { get; set; }
        public string Nombre { get; set; }
        public string Direccion_Correo { get; set; }
        public bool Enviar_copia_correo_oculta { get; set; }
        public string Cuenta_Correo_Copia { get; set; }
        public string Servidor_Correo { get; set; }
        public string Tipo_Conexion { get; set; }
        public int Puerto { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool Cuenta_Predeterminada { get; set; }
        public string Estado { get; set; }
    }
}
