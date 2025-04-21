using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt007_Info
    {
        public int IdEmpresa { get; set; }
        public int IdCaja { get; set; }
        public int IdCustodio { get; set; }
        public string NombreCustodio { get; set; }
        public Nullable<System.DateTime> PeriodoDesde { get; set; }
        public Nullable<System.DateTime> PeriodoHasta { get; set; }
        public Nullable<decimal> FondoAsignado { get; set; }
        public Nullable<decimal> TotalCompra { get; set; }
        public Nullable<decimal> SaldoCompra { get; set; }
        public Nullable<decimal> TotalAprobado { get; set; }
        public Nullable<decimal> Total_a_Pagar { get; set; }
        public Nullable<decimal> Saldo_a_Pagar { get; set; }
        public string EstadoAprob { get; set; }
        public string Observacion { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaUltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> FechaUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string IdUsuarioRevision { get; set; }
        public Nullable<System.DateTime> FechaUltRevision { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte_ct { get; set; }
        public Nullable<decimal> IdCbteCble_ct { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public string Estado { get; set; }
        public int IdSecuencia { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdRubro { get; set; }
        public string CodigoRubro { get; set; }
        public string NombreRubro { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public string IdCod_Impuesto { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Aprobado { get; set; }
        public Nullable<bool> Check { get; set; }
        public string IdCtaCble { get; set; }
    }
}
