using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveDetalle
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    public int Secuencia { get; set; }

    [Column("mv_tipo_movi")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MvTipoMovi { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("dm_stock_ante")]
    public double DmStockAnte { get; set; }

    [Column("dm_stock_actu")]
    public double DmStockActu { get; set; }

    [Column("dm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DmObservacion { get; set; } = null!;

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SuDescripcion { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BoDescripcion { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    public int? IdMarca { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCategoria { get; set; }

    [Column("ca_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CaCategoria { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? RutaPadre { get; set; }

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CmObservacion { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime? CmFecha { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodMoviInven { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodTipoMoviInven { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoMoviInvent { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Column("IdEmpresa_ing_egr")]
    public int? IdEmpresaIngEgr { get; set; }

    [Column("IdSucursal_ing_egr")]
    public int? IdSucursalIngEgr { get; set; }

    [Column("IdMovi_inven_tipo_ing_egr")]
    public int? IdMoviInvenTipoIngEgr { get; set; }

    [Column("IdNumMovi_ing_egr")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIngEgr { get; set; }

    [Column("Secuencia_ing_egr")]
    public int? SecuenciaIngEgr { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("dm_cantidad_sinConversion")]
    public double DmCantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaSinConversion { get; set; } = null!;

    [Column("mv_costo_sinConversion")]
    public double? MvCostoSinConversion { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }
}
