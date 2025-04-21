using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt043_Info
    {
        public decimal IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> IdEmpresa_cxp { get; set; }
        public Nullable<int> IdTipoCbte_cxp { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        public Nullable<int> IdEmpresaOP { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public string Documento { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> SaldoInicial { get; set; }
        public Nullable<decimal> Debe { get; set; }
        public Nullable<decimal> Haber { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<decimal> SaldoFinal { get; set; }
        public string Observacion { get; set; }
        public int Orden { get; set; }
        public string IdUsuario { get; set; }
    }
}