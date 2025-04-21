using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public System.DateTime FechaAprobacion { get; set; }
        public Nullable<int> IdEmpresa_Nota { get; set; }
        public Nullable<decimal> IdCbteCble_Nota { get; set; }
        public Nullable<int> IdTipoCbte_Nota { get; set; }
        public double Subtotal_iva { get; set; }
        public double Subtotal_siniva { get; set; }
        public double Descuento { get; set; }
        public double BaseImponible { get; set; }
        public double Por_iva { get; set; }
        public double Valor_iva { get; set; }
        public double Total { get; set; }
        public List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info> ListAprobacionDet { get; set; }

        public cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Info()
        {
            ListAprobacionDet = new List<cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det_Info>();
        }
    }
}
