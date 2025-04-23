using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.Inventario
{
    public class in_OrdenCompraLocalEstado_Info
    {
        public string IdEstadoAprobacion { get; set; }

        public string EstadoAprobacion { get; set; }
        public string Estado { get; set; }
        public int? Orden { get; set; }
        public Byte[] Imagen { get; set; }

        public in_OrdenCompraLocalEstado_Info() { }

    }
}
