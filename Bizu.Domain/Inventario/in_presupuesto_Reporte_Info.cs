using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;

namespace Bizu.Domain.Inventario
{
    public class in_presupuesto_Reporte_Info
    {
        public in_presupuesto_Info Pres_CabeceraInfo { get; set; }
        public List<in_presupuestoDetalle_Info> Pres_DetalleInfo { get; set; }
        public tb_Empresa_Info Empresa { get; set; }

        public in_presupuesto_Reporte_Info() { }
    }
}
