using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_liquidacion_compra_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacionCompra { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string serie1 { get; set; }
        public string serie2 { get; set; }
        public string NumDocumento { get; set; }
        public string NAutorizacion { get; set; }
        public Nullable<System.DateTime> Fecha_Autorizacion { get; set; }
        public System.DateTime fecha { get; set; }
        public string observacion { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
        public Nullable<int> ct_IdEmpresa_Anu { get; set; }
        public Nullable<int> ct_IdTipoCbte_Anu { get; set; }
        public Nullable<decimal> ct_IdCbteCble_Anu { get; set; }
        public string cp_EstaImpresa { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }

        public cp_orden_giro_Info cp_orden_giro { get; set; }
        public List<cp_liquidacion_compra_det_Info> cp_liquidacion_compra_det { get; set; }

        public cp_liquidacion_compra_Info()
        {
            this.cp_liquidacion_compra_det = new List<cp_liquidacion_compra_det_Info>();
        }
    }
}
