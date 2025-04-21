using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_retencion_Multiple_Info
    {
        public int IdEmpresa { get; set; }
        public int IdMultir { get; set; }
        public int IdSucursal { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public System.DateTime FechaCobro { get; set; }
        public decimal IdCliente { get; set; }
        public int IdCaja { get; set; }
        public string NumRetencion { get; set; }
        public System.DateTime FechaRetencion { get; set; }
        public double TotalRetencion { get; set; }
        public string Estado { get; set; }
    }
}
