using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobros_Pendientes_de_deposito_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public string cr_Codigo { get; set; }
        public string IdCobro_tipo { get; set; }
        public decimal IdCliente { get; set; }
        public double cr_TotalCobro { get; set; }
        public string cr_fecha { get; set; }
        public string cr_fechaDocu { get; set; }
        public string cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string cr_estado { get; set; }
        public int CompCobro_IdTipoCbte { get; set; }
        public decimal CompCobro_IdCbteCble { get; set; }
        public string CompCobro_cb_Fecha { get; set; }
        public double CompCobro_Valor { get; set; }
        public Nullable<int> Deposito_IdTipocbte { get; set; }
        public Nullable<decimal> Deposito_IdCbteCble { get; set; }
    }
}
