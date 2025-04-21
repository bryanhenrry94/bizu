using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_GuiaRemision_Det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Detalle_x_Item { get; set; }
        public Nullable<double> Peso { get; set; }
        public double Cantidad { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<double> Cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public string IdCentroCosto { get; set; }

        public double Costo { get; set; }
        public string IdCategoria { get; set; }

        public in_GuiaRemision_Info in_GuiaRemision { get; set; }
        public in_UnidadMedida_Info in_UnidadMedida { get; set; }

        public int IdAprobacion_PME { get; set; }

        public string Lote { get; set; }
      
    }
}
