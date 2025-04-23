using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt039_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public decimal IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public double co_subtotal { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public string fac_estado { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<System.DateTime> oc_fecha { get; set; }
        public string oc_estado { get; set; }
        public Nullable<double> oc_subtot { get; set; }
        public Nullable<double> oc_iva { get; set; }
        public Nullable<double> oc_total { get; set; }
    }
}
