using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.CuentasxPagar
{
    public class cp_nota_DebCre_Impuesto_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Nota { get; set; }
        public int IdTipoCbte_Nota { get; set; }
        public string Codigo { get; set; }
        public string CodigoPorcentaje { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal Tarifa { get; set; }
        public decimal Valor { get; set; }
        public cp_nota_DebCre_Info cp_nota_DebCre { get; set; }
    }
}
