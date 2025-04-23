using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxCobrar;

namespace Bizu.Domain.Bancos
{
    public class ba_rpt_ChequeComprobante_Info
    {
       public List<vwba_Cbte_Ban_detallePagos_Info> OG_Pagadas { get; set; }
       public List<ct_Cbtecble_det_Info> diario { get; set; }
       public List<ba_Cbte_Ban_Info> cbtBanco { get; set; }
       public tb_Empresa_Info Empresa { get; set; }
       public List<cxc_cobro_Info> CobrosDepositados { get; set; }

       public ba_rpt_ChequeComprobante_Info() { }
    }
}
