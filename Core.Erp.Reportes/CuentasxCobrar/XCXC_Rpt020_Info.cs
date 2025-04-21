using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt020_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public string cr_Codigo { get; set; }
        public string IdCobro_tipo { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string cr_estado { get; set; }
        public double cr_TotalCobro { get; set; }
        public System.DateTime cr_fecha { get; set; }
        public System.DateTime cr_fechaDocu { get; set; }
        public System.DateTime cr_fechaCobro { get; set; }
        public Nullable<System.DateTime> fecha_Transac { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public Nullable<double> cb_Valor { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public Nullable<System.DateTime> cb_Fecha { get; set; }
        public string cb_Estado { get; set; }
        public string cb_Observacion { get; set; }
    }
}
