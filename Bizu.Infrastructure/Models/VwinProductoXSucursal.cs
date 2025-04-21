using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinProductoXSucursal
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_peso")]
    public double? PrPeso { get; set; }

    [Column("pr_ManejaIva")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaIva { get; set; } = null!;

    [Column("pr_ManejaSeries")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaSeries { get; set; } = null!;

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

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("pr_precio_minimo")]
    public double? PrPrecioMinimo { get; set; }

    [Column("pr_precio_publico")]
    public double? PrPrecioPublico { get; set; }

    [Column("pr_costo_promedio")]
    public double? PrCostoPromedio { get; set; }

    [Column("pr_pedidos")]
    public double? PrPedidos { get; set; }

    [Column("pr_stock")]
    public double? PrStock { get; set; }

    [Column("pr_disponible")]
    public double? PrDisponible { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ManejaKardex { get; set; }

    [Column("Descripcion_UniMedida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionUniMedida { get; set; } = null!;

    [Column("Descripcion_TipoConsumo")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionTipoConsumo { get; set; } = null!;

    [Column("IdUnidadMedida_Consumo")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaConsumo { get; set; } = null!;

    [Column("IdCtaCble_Inventario")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleInventario { get; set; }

    [Column("IdCtaCble_Gasto_x_cxp")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleGastoXCxp { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cost")]
    [MaxLength(0)]
    public byte[]? IdCentroCostoSubCentroCostoCost { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cxp")]
    [MaxLength(0)]
    public byte[]? IdCentroCostoSubCentroCostoCxp { get; set; }

    [Column("IdCtaCble_Costo")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleCosto { get; set; }

    [Column("IdCtaCble_CosBaseIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleCosBaseIva { get; set; }

    [Column("IdCtaCble_CosBase0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleCosBase0 { get; set; }

    [Column("IdCtaCble_VenIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleVenIva { get; set; }

    [Column("IdCtaCble_Ven0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleVen0 { get; set; }

    [Column("IdCtaCble_DesIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDesIva { get; set; }

    [Column("IdCtaCble_Des0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDes0 { get; set; }

    [Column("IdCtaCble_DevIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDevIva { get; set; }

    [Column("IdCtaCble_Dev0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDev0 { get; set; }

    [Column("IdCtaCble_Vta")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleVta { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_inv")]
    [MaxLength(0)]
    public byte[]? IdCentroCostoSubCentroCostoInv { get; set; }

    [Column("IdCentroCosto_x_Gasto_x_cxp")]
    [MaxLength(0)]
    public byte[]? IdCentroCostoXGastoXCxp { get; set; }

    [Column("IdCentro_Costo_Inventario")]
    [MaxLength(0)]
    public byte[]? IdCentroCostoInventario { get; set; }

    [Column("IdCentro_Costo_Costo")]
    [MaxLength(0)]
    public byte[]? IdCentroCostoCosto { get; set; }

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

    [Column("precio_minimo")]
    public double? PrecioMinimo { get; set; }
}
