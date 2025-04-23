using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Contabilidad
{
   public class XCONTA_Rpt024_Info
    {
       public XCONTA_Rpt024_Info()
       {
       }

        public int IdEmpresa { get; set; }
        public string Tipo { get; set; }
        public decimal NumDiario { get; set; }
        public string IdCtaCble { get; set; }
        public string Cuenta { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime cb_FechaTransac { get; set; }
        public double Debe { get; set; }
        public double Haber { get; set; }
        public string Observacion { get; set; }
        public string IdUsuario { get; set; }
        public string IdCentroCosto { get; set; }
    }
}
