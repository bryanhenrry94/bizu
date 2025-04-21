using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt003
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Column("signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Signo { get; set; } = null!;

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodMoviInven { get; set; } = null!;

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("IdEmpresa_inv")]
    public int? IdEmpresaInv { get; set; }

    [Column("IdSucursal_inv")]
    public int? IdSucursalInv { get; set; }

    [Column("IdBodega_inv")]
    public int? IdBodegaInv { get; set; }

    [Column("IdMovi_inven_tipo_inv")]
    public int? IdMoviInvenTipoInv { get; set; }

    [Column("IdNumMovi_inv")]
    [Precision(18, 0)]
    public decimal? IdNumMoviInv { get; set; }

    [Column("IdMotivo_oc")]
    public int? IdMotivoOc { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    public int Secuencia { get; set; }

    public int IdBodega { get; set; }

    [Column("bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Bodega { get; set; } = null!;

    [Column("sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("dm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DmObservacion { get; set; } = null!;

    [Column("dm_precio")]
    public double DmPrecio { get; set; }

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAproba { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [Column("IdSubCentro_Costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdSubCentroCosto { get; set; }

    [Column("SubCentro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SubCentroCosto { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PuntoCargo { get; set; }

    [Column("Nom_Unidad_Medida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomUnidadMedida { get; set; }

    [Column("Tipo_Movi_Inven")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoMoviInven { get; set; } = null!;

    [Column("IdMotivo_Inv")]
    public int IdMotivoInv { get; set; }

    [Column("Nom_Motivo_Inv")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomMotivoInv { get; set; } = null!;

    [Column("Nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("dm_stock_ante")]
    public double DmStockAnte { get; set; }

    [Column("dm_stock_actu")]
    public double DmStockActu { get; set; }

    [Column("dm_cantidad_sinConversion")]
    public double DmCantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaSinConversion { get; set; } = null!;

    [Column("mv_costo_sinConversion")]
    public double? MvCostoSinConversion { get; set; }

    [Column("nom_unidad_medida_sinConversion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomUnidadMedidaSinConversion { get; set; } = null!;
}
