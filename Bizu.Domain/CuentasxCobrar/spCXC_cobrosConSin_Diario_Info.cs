using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.CuentasxCobrar
{
    public class spCXC_cobrosConSin_Diario_Info
    {
        public Nullable<int> IdEmpresaCbte { get; set; }
        public Nullable<int> IdSucursalCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public Nullable<System.DateTime> cb_FechaCbte { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<double> dc_Valor { get; set; }
        public Nullable<decimal> IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public Nullable<double> dc_ValorPago { get; set; }
        public string cb_Observacion { get; set; }
        public Nullable<int> IdEmpresa_cb { get; set; }
        public Nullable<int> IdSucursal_cb { get; set; }
        public Nullable<decimal> IdCobro_cb { get; set; }
        public Nullable<int> secuencial_cb { get; set; }
        public Nullable<int> IdEmpresaCobro { get; set; }
        public Nullable<int> IdSucursalCobro { get; set; }
        public Nullable<decimal> IdCobroCobro { get; set; }
        public string IdCobro_tipoCobro { get; set; }
        public Nullable<System.DateTime> cr_fechaCobro { get; set; }
        public Nullable<int> secuencialCobroDet { get; set; }
        public Nullable<double> dc_ValorPagoCobroDet { get; set; }
        public string Novedad { get; set; }
        public string Novedad1 { get; set; }
    }
}
