using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_Info
    {
        public int no_IdEmpresa { get; set; }
        public int no_IdSucursal { get; set; }
        public int no_IdBodega { get; set; }
        public decimal no_IdNota { get; set; }
        public int no_Secuencia { get; set; }
        public int in_IdEmpresa { get; set; }
        public int in_IdSucursal { get; set; }
        public int in_IdMovi_inven_tipo { get; set; }
        public decimal in_IdNumMovi { get; set; }
        public int in_Secuencia { get; set; }

        public decimal IdProducto { get; set; }
        public double dm_cantidad_sinConversion { get; set; }
        public double dm_cantidad { get; set; }
        public double mv_costo_sinConversion { get; set; }
        public double mv_costo { get; set; }
        public string dm_observacion { get; set; }        
        public int IdPunto_cargo { get; set; }
        public int IdRegistro { get; set; }
        public string IdUnidadMedida { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdPunto_cargo_grupo { get; set; }

        public string cod_producto { get; set; }
        public string pr_descripcion { get; set; }


        public fa_notaCreDeb_det_Info fa_notaCreDeb_det { get; set; }
    }
}
