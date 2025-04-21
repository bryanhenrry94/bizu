using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinInProductoXTbBodegaXUnidadMedida
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_codigo_barra")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigoBarra { get; set; } = null!;

    public int IdProductoTipo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdPresentacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrObservacion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("pr_precio_publico")]
    public double PrPrecioPublico { get; set; }

    [Column("pr_precio_mayor")]
    public double PrPrecioMayor { get; set; }

    [Column("pr_precio_minimo")]
    public double PrPrecioMinimo { get; set; }

    [Column("pr_precio_puerta")]
    public double PrPrecioPuerta { get; set; }

    [Column("pr_pedidos")]
    public int PrPedidos { get; set; }

    [Column("pr_ManejaIva")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaIva { get; set; } = null!;

    [Column("pr_ManejaSeries")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaSeries { get; set; } = null!;

    [Column("pr_costo_fob")]
    public double PrCostoFob { get; set; }

    [Column("pr_costo_CIF")]
    public double PrCostoCif { get; set; }

    [Column("pr_costo_promedio")]
    public double PrCostoPromedio { get; set; }

    public int IdMarca { get; set; }

    [Column("pr_DiasMaritimo")]
    public int PrDiasMaritimo { get; set; }

    [Column("pr_DiasAereo")]
    public int PrDiasAereo { get; set; }

    [Column("pr_DiasTerrestre")]
    public int PrDiasTerrestre { get; set; }

    [Column("pr_largo")]
    public double PrLargo { get; set; }

    [Column("pr_alto")]
    public double PrAlto { get; set; }

    [Column("pr_profundidad")]
    public double PrProfundidad { get; set; }

    [Column("pr_peso")]
    public double PrPeso { get; set; }

    [Column("pr_imagenPeque")]
    public byte[]? PrImagenPeque { get; set; }

    [Column("pr_imagen_Grande")]
    public byte[]? PrImagenGrande { get; set; }

    [Column("pr_partidaArancel")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrPartidaArancel { get; set; } = null!;

    [Column("pr_porcentajeArancel")]
    [Precision(18, 2)]
    public decimal PrPorcentajeArancel { get; set; }

    [Column("pr_Por_descuento")]
    public double PrPorDescuento { get; set; }

    [Column("pr_stock_maximo")]
    public double PrStockMaximo { get; set; }

    [Column("pr_stock_minimo")]
    public double PrStockMinimo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuarioUltMod { get; set; } = null!;

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("pr_motivoAnulacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrMotivoAnulacion { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Ip { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("pr_descripcion_2")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrDescripcion2 { get; set; }

    public double? AnchoEspecifico { get; set; }

    public double? PesoEspecifico { get; set; }

    [Column("IdCtaCble_Inventario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInventario { get; set; }

    [Column("IdCtaCble_Costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCosto { get; set; }

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

    public int IdLinea { get; set; }

    public int IdGrupo { get; set; }

    public int IdSubGrupo { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ManejaKardex { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdNaturaleza { get; set; }

    [Column("IdMotivo_Vta")]
    public int? IdMotivoVta { get; set; }

    public int IdBodega { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("IdCtaCble_Inven")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInven { get; set; }

    [Column("pr_stock_Bodega")]
    public double PrStockBodega { get; set; }

    [Column("pr_costo_promedio_bodega")]
    public double PrCostoPromedioBodega { get; set; }

    [Column("Descripcion_UniMedida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionUniMedida { get; set; } = null!;

    [Column("Descripcion_TipoConsumo")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionTipoConsumo { get; set; } = null!;

    [Column("pr_stock")]
    public double PrStock { get; set; }

    [Column("IdUnidadMedida_Consumo")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaConsumo { get; set; } = null!;

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
}
