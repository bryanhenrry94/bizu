using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_Ing_Egr_Inven_x_in_GuiaRemision_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public decimal IdGuiaRemision { get; set; }

        public in_GuiaRemision_Info in_GuiaRemision { get; set; }
        public in_Ing_Egr_Inven_Info in_Ing_Egr_Inven { get; set; }
    }
}
