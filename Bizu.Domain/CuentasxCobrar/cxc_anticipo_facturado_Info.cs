using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Bizu.Domain.Contabilidad;

namespace Bizu.Domain.CuentasxCobrar
{
    public class cxc_anticipo_facturado_Info
    {
        public cxc_anticipo_facturado_Info()
        {
            this.cxc_anticipo_facturado_det = new List<cxc_anticipo_facturado_det_Info>();
        }

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdAnticipo { get; set; }
        public decimal IdCliente { get; set; }
        public string nom_cliente { get; set; } //CAMPO DE LA VISTA
        public int IdProyecto { get; set; }
        public int IdOferta { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_centroCosto { get; set; } //CAMPO DE LA VISTA
        public double Valor { get; set; }
        public Nullable<double> MontoAplicado { get; set; } //CAMPO DE LA VISTA
        public Nullable<double> Saldo { get; set; } //CAMPO DE LA VISTA
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte_ct { get; set; }
        public Nullable<decimal> IdCbteCble_ct { get; set; }
        public Nullable<int> IdEmpresa_CbteVta { get; set; }
        public Nullable<int> IdSucursal_CbteVta { get; set; }
        public Nullable<int> IdBodega_CbteVta { get; set; }
        public Nullable<decimal> IdCbteVta { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
 
        public ct_Cbtecble_Info Info_CbteCble { get; set; }
        public List<cxc_anticipo_facturado_det_Info> cxc_anticipo_facturado_det { get; set; }
    }
}