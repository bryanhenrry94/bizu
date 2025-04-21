using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_liquidacion_compra_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacionCompra { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double PorDescUnitario { get; set; }
        public double DescUnitario { get; set; }
        public double PrecioFinal { get; set; }
        public double Subtotal { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public double Iva { get; set; }
        public double por_iva { get; set; }
        public double Total { get; set; }

        public cp_liquidacion_compra_Info cp_liquidacion_compra { get; set; }      
    }
}
