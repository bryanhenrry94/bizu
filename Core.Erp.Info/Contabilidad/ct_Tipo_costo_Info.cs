using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad
{
	
    public class ct_Tipo_costo_Info
    {

        public int IdEmpresa { get; set; }
        public int IdTipo_Costo { get; set; }
        public string nom_tipo_Costo { get; set; }
        public string nom_tipo_Costo2 { get; set; }
        public bool estado { get; set; }
        public Nullable<int> orden { get; set; }


        public ct_Tipo_costo_Info()
        {

        }
    }
}
