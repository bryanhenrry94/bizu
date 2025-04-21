using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt015_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public Nullable<double> cantidad { get; set; }
        public Nullable<double> descuento { get; set; }
        public Nullable<double> subtotal { get; set; }
        public Nullable<double> total_iva { get; set; }
        public Nullable<double> total { get; set; }
        public string NumeroFactura { get; set; }
        public System.DateTime fecha { get; set; }
        public string pe_nombreCompleto { get; set; }
        public int IdVendedor { get; set; }
        public string Ve_Vendedor { get; set; }
    }
}
