using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.General
{
    public class tb_ComprobantesRecibidos_Info
    {
        public int Id { get; set; }
        public string RucEmisor { get; set; }
        public string RazonSocialEmisor { get; set; }
        public string TipoComprobante { get; set; }
        public string SerieComprobante { get; set; }
        public string ClaveAcceso { get; set; }
        public System.DateTime FechaAutorizacion { get; set; }
        public string NumeroAutorizacion { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string IdentificacionReceptor { get; set; }
        public Nullable<decimal> ValorSinImpuestos { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public Nullable<decimal> ImporteTotal { get; set; }
        public string NumeroDocumentoModificado { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }
        public string XML { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public bool Checked { get; set; }
    }
}
