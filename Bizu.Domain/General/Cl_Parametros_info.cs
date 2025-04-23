using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.General
{
    


    public class Cl_Parametros_info
    {

        public int IdEmpresa { get; set; }
        public String NEmpresa { get; set; }
        public String IdUsuario { get; set; }
        public String NUsuario { get; set; }
        public float PorIva { get; set; }

        public Cl_Parametros_info() { }
    }
}
