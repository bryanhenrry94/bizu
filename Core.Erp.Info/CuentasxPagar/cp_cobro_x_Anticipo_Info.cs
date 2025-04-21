using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_cobro_x_Anticipo_Info
    {


        public int idempresa { get; set; }
        public decimal IdOrdenPago { get; set; }
        public string pr_nombre { get; set; }
        public string Observacion { get; set; }
        public string IdTipo_op { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
        public string IdFormaPago { get; set; }
        public double Valor_a_pagar { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public string Factura { get; set; }
        public double Total_Pagado_Fact { get; set; }

        public cp_cobro_x_Anticipo_Info()
        {
        }


    }
}
