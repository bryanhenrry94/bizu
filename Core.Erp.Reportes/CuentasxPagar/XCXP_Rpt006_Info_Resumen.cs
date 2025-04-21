using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt006_Info_Resumen
    {
        public int IdOrdenPago { get; set; }
        public string IdFactura { get; set; }
        public string FacturaModificada { get; set; }
        public double Valor_Factura { get; set; }
    }
}
