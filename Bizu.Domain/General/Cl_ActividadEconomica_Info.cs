using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.General
{
    public class Cl_ActividadEconomica_Info
    {
        public int id { get; set; }
        public string CodCatalogo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }

        public Cl_ActividadEconomica_Info() { }
    }
}
