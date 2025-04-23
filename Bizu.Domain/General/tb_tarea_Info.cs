using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.General
{
    public class tb_tarea_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTarea { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaIni { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string IdUsuarioUltAsignacion { get; set; }
        public Nullable<System.DateTime> FechaUltAsignacion { get; set; }
        public string EstadoTarea { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public int IdPrioridad { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaUltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> FechaUltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public List<tb_tarea_equipo_Info> List_Tarea_Equipo { get; set; }

        public tb_tarea_Info()
        {
            List_Tarea_Equipo = new List<tb_tarea_equipo_Info>();
        }
    }
}
