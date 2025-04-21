using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class spCXC_cobrosConSin_Diario_Detalle_Info
    {
        public Nullable<int> IdEmpresaCobro { get; set; }
        public Nullable<int> IdSucursalCobro { get; set; }
        public Nullable<decimal> IdCobroCobro { get; set; }
        public string Novedad { get; set; }
        public string Novedad2 { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public System.DateTime cr_fecha { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public double dc_Valor { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public double Debe { get; set; }
        public double Haber { get; set; }
    }
}
