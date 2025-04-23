using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Bancos
{
   public class ba_Cbte_Ban_Datos_Entrega_cheq_Info
   {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NotaEntrega { get; set; }
        public System.DateTime FechaTransac { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public byte[] Foto { get; set; }
    }
}
