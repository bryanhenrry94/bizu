using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt038
{
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SucuOrigen { get; set; } = null!;

    [Column("BodegaORIG")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BodegaOrig { get; set; } = null!;

    [Column("SucuDEST")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SucuDest { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BodegDest { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursalOrigen { get; set; }

    public int IdBodegaOrigen { get; set; }

    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    public int IdSucursalDest { get; set; }

    public int IdBodegaDest { get; set; }

    [Column("tr_Observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TrObservacion { get; set; } = null!;

    [Column("tr_fecha")]
    [MaxLength(6)]
    public DateTime TrFecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inven_Origen")]
    public int? IdEmpresaIngEgrInvenOrigen { get; set; }

    [Column("IdSucursal_Ing_Egr_Inven_Origen")]
    public int? IdSucursalIngEgrInvenOrigen { get; set; }

    [Column("IdMovi_inven_tipo_SucuOrig")]
    public int? IdMoviInvenTipoSucuOrig { get; set; }

    [Column("TipoMovimiento_Origen")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoMovimientoOrigen { get; set; } = null!;

    [Column("IdNumMovi_Ing_Egr_Inven_Origen")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIngEgrInvenOrigen { get; set; }

    [Column("IdProducto_Egr")]
    [Precision(18, 0)]
    public decimal IdProductoEgr { get; set; }

    [Column("pr_codigo_Egr")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigoEgr { get; set; } = null!;

    [Column("pr_descripcion_Egr")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcionEgr { get; set; } = null!;

    [Column("Cantidad_Egr")]
    public double CantidadEgr { get; set; }

    [Column("Costo_Egr")]
    public double CostoEgr { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inven_Destino")]
    public int? IdEmpresaIngEgrInvenDestino { get; set; }

    [Column("IdSucursal_Ing_Egr_Inven_Destino")]
    public int? IdSucursalIngEgrInvenDestino { get; set; }

    [Column("IdMovi_inven_tipo_SucuDest")]
    public int? IdMoviInvenTipoSucuDest { get; set; }

    [Column("TipoMovimiento_Destino")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoMovimientoDestino { get; set; } = null!;

    [Column("IdNumMovi_Ing_Egr_Inven_Destino")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIngEgrInvenDestino { get; set; }

    [Column("IdProducto_Ing")]
    [Precision(18, 0)]
    public decimal IdProductoIng { get; set; }

    [Column("pr_codigo_Ing")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigoIng { get; set; } = null!;

    [Column("pr_descripcion_Ing")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcionIng { get; set; } = null!;

    [Column("Cantidad_Ing")]
    public double CantidadIng { get; set; }

    [Column("Costo_Ing")]
    public double CostoIng { get; set; }

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacionCat { get; set; }

    [Column("EstadoAprobacion_cat")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EstadoAprobacionCat { get; set; } = null!;

    [Column("IdEstadoAproba_ing")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobaIng { get; set; }

    [Column("IdEstadoAproba_egr")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobaEgr { get; set; }

    [Column("dt_secuencia")]
    public int DtSecuencia { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [Column("ca_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomLinea { get; set; } = null!;

    public int IdGrupo { get; set; }

    public int IdSubGrupo { get; set; }

    [Column("IdTipoCbte_Origen_ct")]
    public int? IdTipoCbteOrigenCt { get; set; }

    [Column("IdCbteCble_Origen_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOrigenCt { get; set; }

    [Column("IdTipoCbte_Destino_ct")]
    public int? IdTipoCbteDestinoCt { get; set; }

    [Column("IdCbteCble_Destino_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleDestinoCt { get; set; }
}
