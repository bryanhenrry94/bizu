using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt041_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public System.DateTime FechaTrasladoIni { get; set; }
        public System.DateTime FechaTrasladoFin { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumDocumento { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdEntidad { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observacion { get; set; }
        public int IdMotivo { get; set; }
        public string Estado { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Detalle_x_Item { get; set; }
        public double Cantidad { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<double> Peso { get; set; }
        public Nullable<double> Cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public string IdCentroCosto { get; set; }
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

        public XINV_Rpt041_Info()
        {
        }
    }
}
