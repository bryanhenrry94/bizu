using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.Facturacion
{
    public class fa_TerminoPago_Info
    {
        public string IdTerminoPago { get; set; }
        public string nom_TerminoPago { get; set; }
        public int Num_Cuotas { get; set; }
        public int Dias_Vct { get; set;}

        public fa_TerminoPago_Info() { }

    }
}
