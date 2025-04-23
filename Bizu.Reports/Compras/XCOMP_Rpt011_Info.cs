using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt011_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public Nullable<System.DateTime> oc_fechaVencimiento { get; set; }
        public decimal IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public decimal IdComprador { get; set; }
        public string Nom_Comprador { get; set; }
        public string oc_observacion { get; set; }
        public string Estado { get; set; }
        public string nom_EstadoCerrado { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public string ap_descripcion { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public Nullable<System.DateTime> co_fecha_aprobacion { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double do_precioFinal { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<decimal> ID { get; set; }
        public Nullable<decimal> ParentID { get; set; }
        public int IdEmpresa_Oferta { get; set; }
        public int IdSucursal_Oferta { get; set; }
        public int IdOferta { get; set; }
        public int Secuencia_Oferta { get; set; }
        public string Rubro { get; set; }
        public Nullable<double> Subtotal_Rubro { get; set; }
        public Nullable<int> IdProyecto { get; set; }
        public string nom_proyecto { get; set; }
    }
}
