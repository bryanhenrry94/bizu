using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt038_Info
    {
        public string TipoDoc { get; set; }
        public string Impuesto { get; set; }
        public int IdCodigo_SRI { get; set; }
        public Nullable<double> Base_IVA { get; set; }
        public Nullable<double> Base_IVA0 { get; set; }
        public Nullable<double> Base { get; set; }
        public string NumeroDocumento { get; set; }
        public System.DateTime fecha { get; set; }
        public string pr_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string detalle { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipoCbte { get; set; }
    }
}
