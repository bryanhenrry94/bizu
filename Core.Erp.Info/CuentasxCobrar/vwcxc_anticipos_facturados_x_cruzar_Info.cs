using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_anticipos_facturados_x_cruzar_Info
    {
        public Nullable<int> IdEmpresa_Cobro { get; set; }
        public Nullable<int> IdSucursal_cobro { get; set; }
        public Nullable<decimal> IdCobro_cobro { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdAnticipo { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCliente { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Observacion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string IdCobro_tipo { get; set; }
        public string cr_Banco { get; set; }
        public string cr_NumDocumento { get; set; }
        public int IdCaja { get; set; }
        public double cr_TotalCobro { get; set; }
        public double Saldo_Pendiente { get; set; }
        public double SaldoAUX { get; set; }
        public string IdCtaCble_cxc { get; set; }
        public string IdCtaCble_Anti { get; set; }
        public string IdCentroCosto { get; set; }

        public bool check_cds { get; set; } // CAMPO ADICIONAL
    }
}