using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinProductoPrecioHistorico
{
    [Column("id")]
    [Precision(21, 0)]
    public decimal Id { get; set; }

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    public int IdBodega { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_peso")]
    public double PrPeso { get; set; }

    [Column("pr_ManejaIva")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaIva { get; set; } = null!;

    [Column("pr_ManejaSeries")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaSeries { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int IdMarca { get; set; }

    public int IdProductoTipo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdPresentacion { get; set; }

    [Column("IdCtaCble_Inven")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInven { get; set; }

    [Column("IdCtaCble_Costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCosto { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ManejaKardex { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdNaturaleza { get; set; }

    [Column("IdCtaCble_Inventario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInventario { get; set; }

    [Column("IdCentro_Costo_Inventario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoInventario { get; set; }

    [Column("IdCentro_Costo_Costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoCosto { get; set; }

    [Column("IdCtaCble_Gasto_x_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleGastoXCxp { get; set; }

    [Column("IdCentroCosto_x_Gasto_x_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoXGastoXCxp { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_inv")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCostoInv { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cost")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCostoCost { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCostoCxp { get; set; }

    [Column("IdCtaCble_CosBaseIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCosBaseIva { get; set; }

    [Column("IdCtaCble_CosBase0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCosBase0 { get; set; }

    [Column("IdCtaCble_VenIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVenIva { get; set; }

    [Column("IdCtaCble_Ven0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVen0 { get; set; }

    [Column("IdCtaCble_DesIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDesIva { get; set; }

    [Column("IdCtaCble_Des0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDes0 { get; set; }

    [Column("IdCtaCble_DevIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDevIva { get; set; }

    [Column("IdCtaCble_Dev0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDev0 { get; set; }

    [Column("IdCtaCble_Vta")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVta { get; set; }

    [Column("pr_stock_minimo")]
    public double PrStockMinimo { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCodImpuestoIva { get; set; } = null!;

    [Column("IdCod_Impuesto_Ice")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCodImpuestoIce { get; set; } = null!;

    [Column("Aparece_modu_Ventas")]
    public bool ApareceModuVentas { get; set; }

    [Column("Aparece_modu_Compras")]
    public bool ApareceModuCompras { get; set; }

    [Column("Aparece_modu_Inventario")]
    public bool ApareceModuInventario { get; set; }

    [Column("Aparece_modu_Activo_F")]
    public bool ApareceModuActivoF { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [Column("nom_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomLinea { get; set; } = null!;

    [Column("pr_codigo_barra")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigoBarra { get; set; } = null!;

    [StringLength(0)]
    public string IdEstadoAprobacion { get; set; } = null!;

    [Column("pr_precio_publico")]
    public double PrPrecioPublico { get; set; }

    [Column("pr_precio_mayor")]
    public double PrPrecioMayor { get; set; }

    [Column("pr_precio_minimo")]
    public double PrPrecioMinimo { get; set; }

    [Column("pr_precio_publico_anterior")]
    public double? PrPrecioPublicoAnterior { get; set; }

    [Column("pr_precio_mayor_anterior")]
    public double? PrPrecioMayorAnterior { get; set; }

    [Column("pr_precio_minimo_anterior")]
    public double? PrPrecioMinimoAnterior { get; set; }

    public DateOnly Fecha { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    public int Secuencia { get; set; }
}
