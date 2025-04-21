using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinIngEgrInvenDet
{
    public int Secuencia { get; set; }

    public int IdBodega { get; set; }

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

    [Column("dm_precio")]
    public double DmPrecio { get; set; }

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [Column("dm_peso")]
    public double? DmPeso { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAproba { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("IdEmpresa_oc")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_oc")]
    public int? IdSucursalOc { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Secuencia_oc")]
    public int? SecuenciaOc { get; set; }

    [Column("IdEmpresa_gr")]
    public int? IdEmpresaGr { get; set; }

    [Column("IdSucursal_gr")]
    public int? IdSucursalGr { get; set; }

    [Precision(18, 0)]
    public decimal? IdGuiaRemision { get; set; }

    [Column("Secuencia_gr")]
    public int? SecuenciaGr { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("nom_medida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomMedida { get; set; } = null!;

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

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

    [Column("secuencia_inv")]
    public int? SecuenciaInv { get; set; }

    [Column("Motivo_Aprobacion")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAprobacion { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdNaturaleza { get; set; }

    [Column("dm_cantidad_sinConversion")]
    public double DmCantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaSinConversion { get; set; } = null!;

    [Column("nom_medida_sinConversion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMedidaSinConversion { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("do_descuento")]
    public double? DoDescuento { get; set; }

    [Column("do_subtotal")]
    public double? DoSubtotal { get; set; }

    [Column("do_iva")]
    public double? DoIva { get; set; }

    [Column("do_total")]
    public double? DoTotal { get; set; }

    [Column("signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Signo { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime? CmFecha { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSucursal { get; set; }

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBodega { get; set; }

    [Column("nom_motivo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMotivo { get; set; }

    [Column("nom_tipo_inv")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoInv { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int? IdMoviInvenTipo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("Fecha_registro")]
    [MaxLength(6)]
    public DateTime? FechaRegistro { get; set; }

    [Column("nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("nom_Centro_costo_sub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCostoSubCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCategoria { get; set; }

    public int? IdLinea { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdSubgrupo { get; set; }

    [Column("ca_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CaCategoria { get; set; }

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomLinea { get; set; }

    [Column("nom_grupo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomGrupo { get; set; }

    [Column("nom_subgrupo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSubgrupo { get; set; }

    [Column("mv_costo_sinConversion")]
    public double? MvCostoSinConversion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodMoviInven { get; set; }

    public int IdProductoTipo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Lote { get; set; }

    [Precision(18, 0)]
    public decimal? IdResponsable { get; set; }

    [Precision(18, 0)]
    public decimal? IdContratista { get; set; }
}
