using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxCobrar
{
    public class XCXC_Rpt019_Info
    {
        public int IdEmpresa { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int IdSucursal { get; set; }
        public string CodCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public decimal vt_plazo { get; set; }
        public Nullable<System.DateTime> vt_fech_venc { get; set; }
        public string vt_tipo_venta { get; set; }
        public string vt_Observacion { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public Nullable<int> vt_anio { get; set; }
        public Nullable<int> vt_mes { get; set; }
        public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
        public string Estado { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string Ve_Vendedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_total { get; set; }
        public double CobroTotal { get; set; }
        public Nullable<System.DateTime> fechaCobro { get; set; }
        public Nullable<decimal> diasCobro { get; set; }
        public string IdCiudad { get; set; }
        public string ciudadNom { get; set; }
        public string IdProvincia { get; set; }
        public string provinciaNom { get; set; }
        public Nullable<double> Saldo { get; set; }

        public XCXC_Rpt019_Info ()
	    {

	    }
    }
}
