using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt009_Info
    {
        public int IdEmpresa { get; set; }

        public int IdSucursal { get; set; }

        public decimal IdSolicitudCompra { get; set; }

        public string Sucursal { get; set; }

        public DateTime fecha { get; set; }

        public int plazo { get; set; }

        public DateTime fecha_vtc { get; set; }

        public string observacion { get; set; }

        public string Estado { get; set; }

        public string IdEstadoAprobacion { get; set; }

        public string nom_EstadoAprobacion { get; set; }

        public decimal IdPersona_Solicita { get; set; }

        public string Solicitante { get; set; }

        public int? IdProyecto { get; set; }

        public string nom_proyecto { get; set; }

        public int Secuencia { get; set; }

        public decimal? IdProducto { get; set; }

        public string cod_producto { get; set; }

        public string NomProducto { get; set; }

        public double Cantidad_Solicitada { get; set; }

        public double Cantidad_Comprada { get; set; }

        public double Cantidad_Pendiente { get; set; }

        public string IdCentroCosto { get; set; }

        public string IdUnidadMedida { get; set; }

        public string nom_Unidad { get; set; }

        public string nom_Unidad_Alterno { get; set; }

        public string do_observacion { get; set; }

        public int? IdOferta { get; set; }

        public string Descripcion_Oferta { get; set; }

        public int? Secuencia_Oferta { get; set; }

        public string cod_rubro { get; set; }

        public string nom_rubro { get; set; }

        public string nom_rubro_2 { get; set; }
    }
}
