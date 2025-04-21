using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt042_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public string TipoDoc { get; set; }
        public System.DateTime FechaDoc { get; set; }
        public string num_documento { get; set; }
        public string Codigo { get; set; }
        public string CodigoPorcentaje { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal Tarifa { get; set; }
        public decimal Valor { get; set; }
    }
}
