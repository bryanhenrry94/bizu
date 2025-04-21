using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_Factura_sin_diario_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_NumFactura { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public Nullable<int> ct_IdEmpresa { get; set; }
        public Nullable<int> ct_IdTipoCbte { get; set; }
        public Nullable<decimal> ct_IdCbteCble { get; set; }
        public string Novedad { get; set; }
    }
}
