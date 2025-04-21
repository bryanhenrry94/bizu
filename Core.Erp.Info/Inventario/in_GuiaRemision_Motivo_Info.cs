using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_GuiaRemision_Motivo_Info
    {       
        public int IdEmpresa { get; set; }
        public int IdMotivo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public in_GuiaRemision_Motivo_Info()
        {
        }
    }
}
