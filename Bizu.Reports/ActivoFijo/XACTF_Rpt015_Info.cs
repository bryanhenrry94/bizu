using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.ActivoFijo
{
    public class XACTF_Rpt015_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public string oc_NumDocumento { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public string Estado { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double do_descuento { get; set; }
        public double do_precioFinal { get; set; }
        public double do_subtotal { get; set; }
        public double Por_Iva { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public int IdBodega { get; set; }
        public string bo_Descripcion { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
    }
}
