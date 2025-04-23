using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.Facturacion
{
    public class fa_factura_TerminoPago_Info
    {
        public string IdTipoFormaPago { get; set; }
        public string Descripcion { get; set; }
        public int Num_Cuotas { get; set; }
        public int Dias_Vct { get; set;}

        public fa_factura_TerminoPago_Info() { }

    }
}
