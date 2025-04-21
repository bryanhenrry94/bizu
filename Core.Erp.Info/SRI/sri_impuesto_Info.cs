using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.SRI
{
    public class sri_impuesto_Info
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Porcentaje { get; set; }
        public bool Estado { get; set; }

        public sri_impuesto_Info(string Codigo, string Descripcion, double Porcentaje, bool Estado)
        {
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Porcentaje = Porcentaje;
            this.Estado = Estado;
        }
    }
}
