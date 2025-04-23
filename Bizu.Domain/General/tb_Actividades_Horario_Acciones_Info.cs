using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.General
{
    public class tb_Actividades_Horario_Acciones_Info
    {
        public string IdTransaccion { get; set; }
        public string IdAccion { get; set; }
        public string Descripcion { get; set; }
        public int TiempoEspera { get; set; }
        public int Secuencia_ejecucion { get; set; }
    }
}
