using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Inventario
{
    public class in_GuiaRemision_Exportacion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public string EmbarqueTipo { get; set; }
        public string Ruta { get; set; }
        public string Contenedor { get; set; }
        public string Sello { get; set; }
        public string Vapor { get; set; }
        public string Embalaje { get; set; }
        public double PesoNeto { get; set; }
        public double PesoBruto { get; set; }
        public string Exportador_nombre { get; set; }
        public string Exportador_direccion { get; set; }
        public string Exportador_correo { get; set; }
        public string Exportador_telefono { get; set; }
        public string Exportador_fax { get; set; }
        public string Comprador_nombre { get; set; }
        public string Comprador_direccion { get; set; }
        public string Comprador_correo { get; set; }
        public string Comprador_telefono { get; set; }
        public string Comprador_fax { get; set; }

        public in_GuiaRemision_Info in_GuiaRemision { get; set; }

        public in_GuiaRemision_Exportacion_Info()
        {
            in_GuiaRemision = new in_GuiaRemision_Info();
        }
    }
}
