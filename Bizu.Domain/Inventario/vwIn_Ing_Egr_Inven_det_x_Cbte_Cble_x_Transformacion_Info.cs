using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Inventario
{
    public class vwIn_Ing_Egr_Inven_det_x_Cbte_Cble_x_Transformacion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string Tipo_Movimiento { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string IdEstadoAproba { get; set; }
        public Nullable<int> IdEmpresa_inv { get; set; }
        public Nullable<int> IdSucursal_inv { get; set; }
        public Nullable<int> IdBodega_inv { get; set; }
        public Nullable<int> IdMovi_inven_tipo_inv { get; set; }
        public Nullable<decimal> IdNumMovi_inv { get; set; }
        public Nullable<int> secuencia_inv { get; set; }
        public int IdEmpresa_CbteCble { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipoCbte { get; set; }
        public string CodCbteCble { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public decimal IdTransformacion { get; set; }
    }
}
