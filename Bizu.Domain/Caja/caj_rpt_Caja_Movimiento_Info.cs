using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Caja;
using Bizu.Domain.General;
using Bizu.Domain.Contabilidad;


namespace Bizu.Domain.Caja
{
    public class caj_rpt_Caja_Movimiento_Info
    {
        public caj_Caja_Movimiento_Info MovimientoCaja { get; set; }
        public tb_Empresa_Info Empresa { get; set; }
        public List<ct_Cbtecble_det_Info> diario { get; set; }

        public caj_rpt_Caja_Movimiento_Info(){}
    }
}
