using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt041_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPago { get; set; }
        public string IdTipo_op { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
        public System.DateTime Fecha { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdFormaPago { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public string Estado { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<double> Total_OP { get; set; }
        public double Total_cancelado { get; set; }
        public Nullable<double> Saldo { get; set; }
        public string Observacion { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string nom_tipoFlujo { get; set; }
        public string EstadoCancelacion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Idcancelacion { get; set; }
        public Nullable<decimal> IdOrdenPago_op { get; set; }
        public Nullable<int> IdEmpresa_cxp { get; set; }
        public Nullable<int> IdTipoCbte_cxp { get; set; }
        public string TipoCbte_cxp { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public string Num_Documento { get; set; }
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public string TipoCbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        public Nullable<double> MontoAplicado { get; set; }
        public Nullable<double> SaldoActual { get; set; }
        public Nullable<double> SaldoAnterior { get; set; }
        public string Referencia { get; set; }
        public Nullable<System.DateTime> fechaTransaccion { get; set; }
    }
}