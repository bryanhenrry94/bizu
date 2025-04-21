using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_giro_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public string IdTipoCbte_Ogiro { get; set; }
        public int Secuencia { get; set; }
        public decimal Cantidad { get; set; }
        public string IdCtaCble { get; set; }
        public decimal ValorUnit { get; set; }
        public string IdCod_Impuesto_IVA { get; set; }
        public string IdCod_Impuesto_ICE { get; set; }
        public decimal PorcICE { get; set; }
        public decimal PorcDescuento { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }
}