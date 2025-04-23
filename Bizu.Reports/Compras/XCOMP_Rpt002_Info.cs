using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt002_Info
    {

        public decimal IdRow { get; set; }

        public int IdEmpresa { get; set; }

        public int IdSucursal { get; set; }

        public decimal IdSolicitudCompra { get; set; }

        public decimal IdPersona_Solicita { get; set; }

        public int? IdProyecto { get; set; }

        public string cod_proyecto { get; set; }

        public string nom_proyecto { get; set; }

        public int? IdOferta { get; set; }

        public string nom_oferta { get; set; }

        public string IdEstadoAprobacion { get; set; }

        public string nom_EstadoAprobacion { get; set; }

        public string nom_empresa { get; set; }

        public string nom_sucursal { get; set; }

        public DateTime fecha { get; set; }

        public string observacion { get; set; }

        public int Secuencia { get; set; }

        public int? Secuencia_Oferta { get; set; }

        public string cod_rubro { get; set; }

        public string nom_rubro { get; set; }

        public string nom_rubro_2 { get; set; }

        public decimal? IdProducto { get; set; }

        public string nom_producto { get; set; }

        public string do_observacion { get; set; }

        public double do_Cantidad { get; set; }

        public string em_ruc { get; set; }

        public string em_direccion { get; set; }

        public string em_telefonos { get; set; }

        public int? IdPunto_cargo { get; set; }

        public string nom_punto_cargo { get; set; }

        public string IdCentroCosto { get; set; }

        public string nom_Centro_Costo { get; set; }

        public string IdSubCentroCosto { get; set; }

        public string nom_SubCentroCosto { get; set; }

        public string IdUnidadMedida { get; set; }

        public string nom_unidad { get; set; }

        public string nom_unidad_alterno { get; set; }

        public string nom_personaSol { get; set; }

        public string pr_codigo { get; set; }

        public string IdUsuarioAprobo { get; set; }

        public string nom_usuario_aprob { get; set; }

        public XCOMP_Rpt002_Info()
       {

       }
    }
}
