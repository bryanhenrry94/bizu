using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt038_Info
    {
        public string SucuOrigen { get; set; }
        public string BodegaORIG { get; set; }
        public string SucuDEST { get; set; }
        public string BodegDest { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int IdSucursalDest { get; set; }
        public int IdBodegaDest { get; set; }
        public string tr_Observacion { get; set; }
        public System.DateTime tr_fecha { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Origen { get; set; }
        public Nullable<int> IdMovi_inven_tipo_SucuOrig { get; set; }
        public string TipoMovimiento_Origen { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Origen { get; set; }
        public decimal IdProducto_Egr { get; set; }
        public string pr_codigo_Egr { get; set; }
        public string pr_descripcion_Egr { get; set; }
        public double Cantidad_Egr { get; set; }
        public Nullable<int> IdEmpresa_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<int> IdSucursal_Ing_Egr_Inven_Destino { get; set; }
        public Nullable<int> IdMovi_inven_tipo_SucuDest { get; set; }
        public string TipoMovimiento_Destino { get; set; }
        public Nullable<decimal> IdNumMovi_Ing_Egr_Inven_Destino { get; set; }
        public decimal IdProducto_Ing { get; set; }
        public string pr_codigo_Ing { get; set; }
        public string pr_descripcion_Ing { get; set; }
        public double Cantidad_Ing { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public string EstadoAprobacion_cat { get; set; }
        public string IdEstadoAproba_ing { get; set; }
        public string IdEstadoAproba_egr { get; set; }
        public int dt_secuencia { get; set; }
        public string IdUnidadMedida { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }
        public int IdGrupo { get; set; }
        public int IdSubGrupo { get; set; }
        public Nullable<int> IdTipoCbte_Origen_ct { get; set; }
        public Nullable<decimal> IdCbteCble_Origen_ct { get; set; }
        public Nullable<int> IdTipoCbte_Destino_ct { get; set; }
        public Nullable<decimal> IdCbteCble_Destino_ct { get; set; }
        public double Costo_Egr { get; set; }
        public double Costo_Ing { get; set; }
    }
}
