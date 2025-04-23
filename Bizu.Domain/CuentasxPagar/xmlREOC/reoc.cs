using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar.xmlATS;

namespace Bizu.Domain.CuentasxPagar.xmlREOC
{
    public class reoc
    {

        public string numeroRuc { get; set; }
        public int anio { get; set; }
        public string mes { get; set; }
        public List<detalleCompras> compras { get; set; }
         public reoc(){ }

    }
}
