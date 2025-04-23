using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Compras
{
   public class cp_orden_giro_x_com_ordencompra_local_det_Info_Solicitud
    {
        public Nullable<decimal> IdSolicitud { get; set; }
        public Nullable<decimal> ID_Departamento { get; set; }
        public string Nom_Departamento { get; set; }
        public Nullable<decimal> ID_Solicitante { get; set; }
        public string Nom_Solicitante { get; set; }
    }
}
