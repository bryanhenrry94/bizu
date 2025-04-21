using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info
    {
        public int IdEmpresa_inv { get; set; }

        public int IdSucursal_inv { get; set; }

        public int IdMovi_inven_tipo_inv { get; set; }

        public decimal IdNumMovi_inv { get; set; }

        public int Secuencia_inv { get; set; }

        public int IdEmpresa_ot { get; set; }

        public int IdSucursal_ot { get; set; }

        public decimal IdOrdenTrabajo_ot { get; set; }

        public int Secuencia_ot { get; set; }
    }
}
