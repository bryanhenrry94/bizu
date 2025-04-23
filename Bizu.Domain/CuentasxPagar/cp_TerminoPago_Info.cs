using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.CuentasxPagar
{
    public class cp_TerminoPago_Info
    {
        public int IdEmpresa { get; set; }
        public string IdTerminoPago { get; set; }
        public string nom_TerminoPago { get; set; }
        public int Num_Coutas { get; set; }
        public int Dias_Vct { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaUltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }

        public cp_TerminoPago_Info() { }
    }
}
