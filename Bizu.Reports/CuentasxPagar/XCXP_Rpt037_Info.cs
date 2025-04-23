using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt037_Info
    {
        public string re_tipoRet { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string cod_Impuesto_SRI { get; set; }
        public string Impuesto { get; set; }
        public Nullable<double> Base_IVA { get; set; }
        public Nullable<double> Base_IVA0 { get; set; }
        public Nullable<double> Base { get; set; }
        public string NumRetencion { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<decimal> Valor_Retencion { get; set; }
        public string co_factura { get; set; }
        public string pr_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
    }
}
