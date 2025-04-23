using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Bancos;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.General;

namespace Bizu.Domain.Bancos
{
    public class ba_rpt_transferencia_Info
    {
        public ba_transferencia_Info Transf { get; set; }
        public List<ct_Cbtecble_det_Info> diario_NC { get; set; }
        public List<ct_Cbtecble_det_Info> diario_ND { get; set; }
        public tb_Empresa_Info Empresa { get; set; }

        public ba_rpt_transferencia_Info(){}
    }
}
