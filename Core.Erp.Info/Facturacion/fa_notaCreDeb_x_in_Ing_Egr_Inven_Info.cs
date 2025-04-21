using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Core.Erp.Info.Facturacion
{
    public class fa_notaCreDeb_x_in_Ing_Egr_Inven_Info
    {
        public int no_IdEmpresa { get; set; }
        public int no_IdSucursal { get; set; }
        public int no_IdBodega { get; set; }
        public decimal no_IdNota { get; set; }
        public int in_IdEmpresa { get; set; }
        public int in_IdSucursal { get; set; }
        public int in_IdMovi_inven_tipo { get; set; }
        public decimal in_IdNumMovi { get; set; }

        public fa_notaCreDeb_Info fa_notaCreDeb { get; set; }
    }
}
