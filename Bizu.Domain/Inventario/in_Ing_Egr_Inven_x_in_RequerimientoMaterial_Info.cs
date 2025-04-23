using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Inventario
{
    public class in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info
    {
        public in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info()
        {
            
        }

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public decimal Num_Requerimiento { get; set; }

        public in_Ing_Egr_Inven_Info in_Ing_Egr_Inven { get; set; }
    }
}
