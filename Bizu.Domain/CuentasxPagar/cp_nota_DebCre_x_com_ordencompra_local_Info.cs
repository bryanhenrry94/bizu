using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.CuentasxPagar
{
    public class cp_nota_DebCre_x_com_ordencompra_local_Info
    {
        public int ndc_IdEmpresa { get; set; }
        public decimal ndc_IdCbteCble_Nota { get; set; }
        public int ndc_IdTipoCbte_Nota { get; set; }
        public int com_IdEmpresa { get; set; }
        public int com_IdSucursal { get; set; }
        public decimal com_IdOrdenCompraLocal { get; set; }
        public string og_Observacion { get; set; }

        public cp_nota_DebCre_Info cp_nota_DebCre { get; set; }
    }
}
