using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto")]
[Table("in_producto_x_tb_bodega")]
[Index("IdEmpresa", "IdCtaCbleInven", Name = "FK_in_producto_x_tb_bodega_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleCosBaseIva", Name = "FK_in_producto_x_tb_bodega_ct_plancta1")]
[Index("IdEmpresa", "IdCtaCbleGastoXCxp", Name = "FK_in_producto_x_tb_bodega_ct_plancta10")]
[Index("IdEmpresa", "IdCtaCbleVta", Name = "FK_in_producto_x_tb_bodega_ct_plancta11")]
[Index("IdEmpresa", "IdCtaCbleCosBase0", Name = "FK_in_producto_x_tb_bodega_ct_plancta2")]
[Index("IdEmpresa", "IdCtaCbleVenIva", Name = "FK_in_producto_x_tb_bodega_ct_plancta3")]
[Index("IdEmpresa", "IdCtaCbleVen0", Name = "FK_in_producto_x_tb_bodega_ct_plancta4")]
[Index("IdEmpresa", "IdCtaCbleDes0", Name = "FK_in_producto_x_tb_bodega_ct_plancta6")]
[Index("IdEmpresa", "IdCtaCbleDevIva", Name = "FK_in_producto_x_tb_bodega_ct_plancta7")]
[Index("IdEmpresa", "IdCtaCbleDev0", Name = "FK_in_producto_x_tb_bodega_ct_plancta8")]
[Index("IdEmpresa", "IdCtaCbleCosto", Name = "FK_in_producto_x_tb_bodega_ct_plancta9")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_producto_x_tb_bodega_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoXTbBodega
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_precio_publico")]
    public double PrPrecioPublico { get; set; }

    [Column("pr_precio_mayor")]
    public double PrPrecioMayor { get; set; }

    [Column("pr_precio_puerta")]
    public double PrPrecioPuerta { get; set; }

    [Column("pr_precio_minimo")]
    public double PrPrecioMinimo { get; set; }

    [Column("pr_Por_descuento")]
    public double PrPorDescuento { get; set; }

    [Column("pr_stock_maximo")]
    public double PrStockMaximo { get; set; }

    [Column("pr_stock_minimo")]
    public double PrStockMinimo { get; set; }

    [Column("pr_costo_fob")]
    public double PrCostoFob { get; set; }

    [Column("pr_costo_CIF")]
    public double PrCostoCif { get; set; }

    [Column("pr_costo_promedio")]
    public double PrCostoPromedio { get; set; }

    [Column("IdCtaCble_Inven")]
    [StringLength(20)]
    public string? IdCtaCbleInven { get; set; }

    [Column("IdCtaCble_CosBaseIva")]
    [StringLength(20)]
    public string? IdCtaCbleCosBaseIva { get; set; }

    [Column("IdCtaCble_CosBase0")]
    [StringLength(20)]
    public string? IdCtaCbleCosBase0 { get; set; }

    [Column("IdCtaCble_VenIva")]
    [StringLength(20)]
    public string? IdCtaCbleVenIva { get; set; }

    [Column("IdCtaCble_Ven0")]
    [StringLength(20)]
    public string? IdCtaCbleVen0 { get; set; }

    [Column("IdCtaCble_DesIva")]
    [StringLength(20)]
    public string? IdCtaCbleDesIva { get; set; }

    [Column("IdCtaCble_Des0")]
    [StringLength(20)]
    public string? IdCtaCbleDes0 { get; set; }

    [Column("IdCtaCble_DevIva")]
    [StringLength(20)]
    public string? IdCtaCbleDevIva { get; set; }

    [Column("IdCtaCble_Dev0")]
    [StringLength(20)]
    public string? IdCtaCbleDev0 { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("IdCtaCble_Costo")]
    [StringLength(20)]
    public string? IdCtaCbleCosto { get; set; }

    [Column("IdCentro_Costo_Inventario")]
    [StringLength(20)]
    public string? IdCentroCostoInventario { get; set; }

    [Column("IdCentro_Costo_Costo")]
    [StringLength(20)]
    public string? IdCentroCostoCosto { get; set; }

    [Column("IdCtaCble_Gasto_x_cxp")]
    [StringLength(20)]
    public string? IdCtaCbleGastoXCxp { get; set; }

    [Column("IdCentroCosto_x_Gasto_x_cxp")]
    [StringLength(20)]
    public string? IdCentroCostoXGastoXCxp { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_inv")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCostoInv { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cost")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCostoCost { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cxp")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCostoCxp { get; set; }

    [Column("IdCtaCble_Vta")]
    [StringLength(20)]
    public string? IdCtaCbleVta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCosBase0")]
    [InverseProperty("InProductoXTbBodegaCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCosto")]
    [InverseProperty("InProductoXTbBodegaCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleDes0")]
    [InverseProperty("InProductoXTbBodegaCtPlancta2")]
    public virtual CtPlancta? CtPlancta2 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleDev0")]
    [InverseProperty("InProductoXTbBodegaCtPlancta3")]
    public virtual CtPlancta? CtPlancta3 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleDevIva")]
    [InverseProperty("InProductoXTbBodegaCtPlancta4")]
    public virtual CtPlancta? CtPlancta4 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleGastoXCxp")]
    [InverseProperty("InProductoXTbBodegaCtPlancta5")]
    public virtual CtPlancta? CtPlancta5 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleInven")]
    [InverseProperty("InProductoXTbBodegaCtPlancta6")]
    public virtual CtPlancta? CtPlancta6 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleVen0")]
    [InverseProperty("InProductoXTbBodegaCtPlancta7")]
    public virtual CtPlancta? CtPlancta7 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleVenIva")]
    [InverseProperty("InProductoXTbBodegaCtPlancta8")]
    public virtual CtPlancta? CtPlancta8 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleVta")]
    [InverseProperty("InProductoXTbBodegaCtPlancta9")]
    public virtual CtPlancta? CtPlancta9 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCosBaseIva")]
    [InverseProperty("InProductoXTbBodegaCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InProductoXTbBodega")]
    public virtual InProducto InProducto { get; set; } = null!;

    [InverseProperty("InProductoXTbBodega")]
    public virtual ICollection<InProductoXTbBodegaCostoHistorico> InProductoXTbBodegaCostoHistorico { get; set; } = new List<InProductoXTbBodegaCostoHistorico>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("InProductoXTbBodega")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
