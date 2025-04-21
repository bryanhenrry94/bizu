using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt030_Info_Resumen
    {
        public string Descripcion { get; set; }
        public Double co_subtotal_iva { get; set; }
        public Double co_subtotal_siniva { get; set; }
        public Double co_valoriva { get; set; }
        public Double co_total { get; set; }
    }
}
