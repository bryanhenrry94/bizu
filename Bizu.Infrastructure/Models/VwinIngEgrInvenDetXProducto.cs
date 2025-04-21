using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinIngEgrInvenDetXProducto
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    public int Secuencia { get; set; }

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

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrDescripcion { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrCodigo { get; set; }

    [Column("IdEmpresa_oc")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_oc")]
    public int? IdSucursalOc { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Secuencia_oc")]
    public int? SecuenciaOc { get; set; }

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

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Column("Nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("Nom_SubCentroCosto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSubCentroCosto { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodProducto { get; set; }

    [Column("nom_producto_princ")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProductoPrinc { get; set; }

    [Column("pr_stock")]
    public double PrStock { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }
}
