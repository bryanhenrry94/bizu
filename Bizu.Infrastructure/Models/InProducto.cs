using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProducto")]
[Table("in_Producto")]
[Index("IdEmpresa", "IdMotivoVta", Name = "FK_in_Producto_fa_motivo_venta")]
[Index("IdEmpresa", "IdMarca", Name = "FK_in_Producto_in_Marca")]
[Index("IdEmpresa", "IdProductoTipo", Name = "FK_in_Producto_in_ProductoTipo")]
[Index("IdUnidadMedida", Name = "FK_in_Producto_in_UnidadMedida")]
[Index("IdUnidadMedidaConsumo", Name = "FK_in_Producto_in_UnidadMedida1")]
[Index("IdEmpresa", "IdPresentacion", Name = "FK_in_Producto_in_presentacion")]
[Index("IdEmpresa", "IdCategoria", "IdLinea", "IdGrupo", "IdSubGrupo", Name = "FK_in_Producto_in_subgrupo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProducto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_descripcion_2")]
    [StringLength(500)]
    public string? PrDescripcion2 { get; set; }

    public int IdProductoTipo { get; set; }

    public int IdMarca { get; set; }

    [StringLength(25)]
    public string? IdPresentacion { get; set; }

    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    public int IdGrupo { get; set; }

    public int IdSubGrupo { get; set; }

    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("IdUnidadMedida_Consumo")]
    [StringLength(25)]
    public string IdUnidadMedidaConsumo { get; set; } = null!;

    [StringLength(15)]
    public string? IdNaturaleza { get; set; }

    [Column("IdMotivo_Vta")]
    public int? IdMotivoVta { get; set; }

    [Column("pr_codigo_barra")]
    [StringLength(50)]
    public string PrCodigoBarra { get; set; } = null!;

    [Column("pr_observacion")]
    [StringLength(1000)]
    public string PrObservacion { get; set; } = null!;

    [Column("pr_precio_publico")]
    public double PrPrecioPublico { get; set; }

    [Column("pr_precio_mayor")]
    public double PrPrecioMayor { get; set; }

    [Column("pr_precio_minimo")]
    public double PrPrecioMinimo { get; set; }

    [Column("pr_precio_puerta")]
    public double PrPrecioPuerta { get; set; }

    [Column("pr_ManejaIva")]
    [StringLength(10)]
    public string PrManejaIva { get; set; } = null!;

    [Column("pr_ManejaSeries")]
    [StringLength(10)]
    public string PrManejaSeries { get; set; } = null!;

    [Column("pr_costo_fob")]
    public double PrCostoFob { get; set; }

    [Column("pr_costo_CIF")]
    public double PrCostoCif { get; set; }

    [Column("pr_costo_promedio")]
    public double PrCostoPromedio { get; set; }

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
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string IdUsuarioUltMod { get; set; } = null!;

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("pr_motivoAnulacion")]
    [StringLength(50)]
    public string? PrMotivoAnulacion { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    public double? AnchoEspecifico { get; set; }

    public double? PesoEspecifico { get; set; }

    [StringLength(1)]
    public string? ManejaKardex { get; set; }

    [StringLength(1)]
    public string? ManejaLote { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(50)]
    public string IdCodImpuestoIva { get; set; } = null!;

    [Column("IdCod_Impuesto_Ice")]
    [StringLength(50)]
    public string IdCodImpuestoIce { get; set; } = null!;

    [Column("Aparece_modu_Ventas")]
    public bool ApareceModuVentas { get; set; }

    [Column("Aparece_modu_Compras")]
    public bool ApareceModuCompras { get; set; }

    [Column("Aparece_modu_Inventario")]
    public bool ApareceModuInventario { get; set; }

    [Column("Aparece_modu_Activo_F")]
    public bool ApareceModuActivoF { get; set; }

    [InverseProperty("InProducto")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("InProducto")]
    public virtual ICollection<ComCotizacionCompraDet> ComCotizacionCompraDet { get; set; } = new List<ComCotizacionCompraDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<ComDevCompraDet> ComDevCompraDet { get; set; } = new List<ComDevCompraDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<ComListadoMaterialesDet> ComListadoMaterialesDet { get; set; } = new List<ComListadoMaterialesDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; } = new List<ComOrdencompraLocalDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; } = new List<ComSolicitudCompraDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<CpLiquidacionCompraDet> CpLiquidacionCompraDet { get; set; } = new List<CpLiquidacionCompraDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<CxcParametrosXCheqProtesto> CxcParametrosXCheqProtestoInProducto { get; set; } = new List<CxcParametrosXCheqProtesto>();

    [InverseProperty("InProductoNavigation")]
    public virtual ICollection<CxcParametrosXCheqProtesto> CxcParametrosXCheqProtestoInProductoNavigation { get; set; } = new List<CxcParametrosXCheqProtesto>();

    [InverseProperty("InProducto")]
    public virtual ICollection<FaCotizacionDet> FaCotizacionDet { get; set; } = new List<FaCotizacionDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<FaDevolVentaDet> FaDevolVentaDet { get; set; } = new List<FaDevolVentaDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<FaFacturaDet> FaFacturaDet { get; set; } = new List<FaFacturaDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<FaGuiaRemisionDet> FaGuiaRemisionDet { get; set; } = new List<FaGuiaRemisionDet>();

    [ForeignKey("IdEmpresa, IdMotivoVta")]
    [InverseProperty("InProducto")]
    public virtual FaMotivoVenta? FaMotivoVenta { get; set; }

    [InverseProperty("InProducto")]
    public virtual ICollection<FaOrdenDespDet> FaOrdenDespDet { get; set; } = new List<FaOrdenDespDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<FaPedidoDet> FaPedidoDet { get; set; } = new List<FaPedidoDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<FaVentaTelefonicaDet> FaVentaTelefonicaDet { get; set; } = new List<FaVentaTelefonicaDet>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("InProducto")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedidaConsumo")]
    [InverseProperty("InProductoIdUnidadMedidaConsumoNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaConsumoNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("InProductoIdUnidadMedidaNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;

    [InverseProperty("InProducto")]
    public virtual ICollection<InAjusteFisicoDetalle> InAjusteFisicoDetalle { get; set; } = new List<InAjusteFisicoDetalle>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InGuiaRemisionDet> InGuiaRemisionDet { get; set; } = new List<InGuiaRemisionDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InGuiaXTraspasoBodegaDetSinOc> InGuiaXTraspasoBodegaDetSinOc { get; set; } = new List<InGuiaXTraspasoBodegaDetSinOc>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InInvRpt026> InInvRpt026 { get; set; } = new List<InInvRpt026>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InKardexDet> InKardexDet { get; set; } = new List<InKardexDet>();

    [ForeignKey("IdEmpresa, IdMarca")]
    [InverseProperty("InProducto")]
    public virtual InMarca InMarca { get; set; } = null!;

    [InverseProperty("InProducto")]
    public virtual ICollection<InMoviInveDetalle> InMoviInveDetalle { get; set; } = new List<InMoviInveDetalle>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InPrecargaItemsOrdenCompraDet> InPrecargaItemsOrdenCompraDet { get; set; } = new List<InPrecargaItemsOrdenCompraDet>();

    [ForeignKey("IdEmpresa, IdPresentacion")]
    [InverseProperty("InProducto")]
    public virtual InPresentacion? InPresentacion { get; set; }

    [InverseProperty("InProducto")]
    public virtual ICollection<InPresupuestoDet> InPresupuestoDet { get; set; } = new List<InPresupuestoDet>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InProductoComposicion> InProductoComposicionInProducto { get; set; } = new List<InProductoComposicion>();

    [InverseProperty("InProductoNavigation")]
    public virtual ICollection<InProductoComposicion> InProductoComposicionInProductoNavigation { get; set; } = new List<InProductoComposicion>();

    [ForeignKey("IdEmpresa, IdProductoTipo")]
    [InverseProperty("InProducto")]
    public virtual InProductoTipo InProductoTipo { get; set; } = null!;

    [InverseProperty("InProducto")]
    public virtual ICollection<InProductoXCpProveedor> InProductoXCpProveedor { get; set; } = new List<InProductoXCpProveedor>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InProductoXInProducto> InProductoXInProductoInProducto { get; set; } = new List<InProductoXInProducto>();

    [InverseProperty("InProductoNavigation")]
    public virtual ICollection<InProductoXInProducto> InProductoXInProductoInProductoNavigation { get; set; } = new List<InProductoXInProducto>();

    [InverseProperty("InProducto")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodega { get; set; } = new List<InProductoXTbBodega>();

    [ForeignKey("IdEmpresa, IdCategoria, IdLinea, IdGrupo, IdSubGrupo")]
    [InverseProperty("InProducto")]
    public virtual InSubgrupo InSubgrupo { get; set; } = null!;

    [InverseProperty("InProducto")]
    public virtual ICollection<InTransferenciaDet> InTransferenciaDet { get; set; } = new List<InTransferenciaDet>();
}
