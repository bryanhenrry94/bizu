using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dazzsoft.ERP.Infrastructure.Model.General
{
    public class TbEmpresa
    {
        public int IdEmpresa { get; set; }
        public string Codigo { get; set; }
        public string EmNombre { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoALlevarConta { get; set; }
        public string EmRuc { get; set; }
        public string EmGerente { get; set; }
        public string EmContador { get; set; }
        public string EmRucContador { get; set; }
        public string EmTelefonos { get; set; }
        public string EmFax { get; set; }
        public int? EmNotificacion { get; set; }
        public string EmDireccion { get; set; }
        public string EmTelInt { get; set; }
        public byte[] EmLogo { get; set; }
        public byte[] EmFondo { get; set; }
        public DateTime EmFechaInicioContable { get; set; }
        public string Estado { get; set; }
        public DateTime? EmFechaInicioActividad { get; set; }
        public string CodEntidadDinardap { get; set; }
        public string EmEmail { get; set; }
        public string EmEmailContacto { get; set; }
        public string SitioWeb { get; set; }
        public string Trial228 { get; set; }
    }

}
