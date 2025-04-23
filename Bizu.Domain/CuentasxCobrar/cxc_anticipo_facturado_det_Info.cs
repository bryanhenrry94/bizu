using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bizu.Domain.CuentasxCobrar
{
    public class cxc_anticipo_facturado_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdAnticipo { get; set; }
        public int Secuencia { get; set; }
        public string Detalle { get; set; }
        public System.DateTime Fecha { get; set; }
        public double Valor { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte_ct { get; set; }
        public Nullable<decimal> IdCbteCble_ct { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCtaCble { get; set; }

        public Bitmap Icono { get; set; } //campo de vista

        public cxc_anticipo_facturado_Info cxc_anticipo_facturado { get; set; }
    }
}