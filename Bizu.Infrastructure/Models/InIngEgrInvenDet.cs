using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdMoviInvenTipo", "IdNumMovi", "Secuencia")]
[Table("in_Ing_Egr_Inven_det")]
[Index("IdEmpresaOc", "IdSucursalOc", "IdOrdenCompra", "SecuenciaOc", Name = "FK_in_Ing_Egr_Inven_det_com_ordencompra_local_det")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_in_Ing_Egr_Inven_det_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_in_Ing_Egr_Inven_det_ct_punto_cargo")]
[Index("IdEmpresaGr", "IdSucursalGr", "IdGuiaRemision", "SecuenciaGr", Name = "FK_in_Ing_Egr_Inven_det_in_GuiaRemision_Det")]
[Index("IdEstadoAproba", Name = "FK_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven_estado_apro")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_Ing_Egr_Inven_det_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_in_Ing_Egr_Inven_det_in_UnidadMedida2")]
[Index("IdUnidadMedidaSinConversion", Name = "FK_in_Ing_Egr_Inven_det_in_UnidadMedida3")]
[Index("IdEmpresa", "IdSucursal", "IdOrdenTaller", Name = "FK_in_Ing_Egr_Inven_det_prd_OrdenTaller")]
[Index("IdEmpresa", "IdSucursal", "IdProducto", Name = "in_Ing_Egr_Inven_det_Index_Dashboard")]
[Index("IdEmpresaInv", "IdSucursalInv", "IdBodegaInv", "IdMoviInvenTipoInv", "IdNumMoviInv", "SecuenciaInv", Name = "in_Ing_Egr_Inven_det_index")]
[Index("IdEmpresaInv", "IdSucursalInv", "IdBodegaInv", "IdEmpresa", "IdSucursal", "IdMoviInvenTipo", "IdNumMovi", "IdBodega", "IdMoviInvenTipoInv", "IdNumMoviInv", "SecuenciaInv", "Lote", Name = "vwin_producto_x_tb_bodega_Lote_Index")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", "IdEstadoAproba", "IdMoviInvenTipo", "IdNumMovi", "IdProducto", "DmCantidad", "IdEmpresaInv", "IdMoviInvenTipoInv", "IdNumMoviInv", "SecuenciaInv", Name = "vwin_producto_x_tb_bodega_Lote_Index2")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", "IdEstadoAproba", "IdMoviInvenTipo", "IdNumMovi", "IdProducto", "DmCantidad", "IdEmpresaInv", "IdSucursalInv", "IdBodegaInv", "IdMoviInvenTipoInv", "IdNumMoviInv", "SecuenciaInv", Name = "vwin_producto_x_tb_bodega_Lote_Index5")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InIngEgrInvenDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
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
    public string DmObservacion { get; set; } = null!;

    [Column("dm_precio")]
    public double DmPrecio { get; set; }

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [Column("dm_peso")]
    public double? DmPeso { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(15)]
    public string? IdEstadoAproba { get; set; }

    [StringLength(25)]
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

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

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
    public string? MotivoAprobacion { get; set; }

    [Column("dm_cantidad_sinConversion")]
    public double DmCantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    public string IdUnidadMedidaSinConversion { get; set; } = null!;

    [Column("mv_costo_sinConversion")]
    public double? MvCostoSinConversion { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenTaller { get; set; }

    [StringLength(50)]
    public string? Lote { get; set; }

    [Precision(18, 0)]
    public decimal? IdResponsable { get; set; }

    [Precision(18, 0)]
    public decimal? IdContratista { get; set; }

    [ForeignKey("IdEmpresaOc, IdSucursalOc, IdOrdenCompra, SecuenciaOc")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual ComOrdencompraLocalDet? ComOrdencompraLocalDet { get; set; }

    [InverseProperty("InIngEgrInvenDet")]
    public virtual ICollection<CpAprobacionIngBodXOcDet> CpAprobacionIngBodXOcDet { get; set; } = new List<CpAprobacionIngBodXOcDet>();

    [InverseProperty("InIngEgrInvenDet")]
    public virtual ICollection<CpNotaDebCreAprobacionIngBodXOcDet> CpNotaDebCreAprobacionIngBodXOcDet { get; set; } = new List<CpNotaDebCreAprobacionIngBodXOcDet>();

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEstadoAproba")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual InIngEgrInvenEstadoApro? IdEstadoAprobaNavigation { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("InIngEgrInvenDetIdUnidadMedidaNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedidaSinConversion")]
    [InverseProperty("InIngEgrInvenDetIdUnidadMedidaSinConversionNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaSinConversionNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresaGr, IdSucursalGr, IdGuiaRemision, SecuenciaGr")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual InGuiaRemisionDet? InGuiaRemisionDet { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdMoviInvenTipo, IdNumMovi")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual InIngEgrInven InIngEgrInven { get; set; } = null!;

    [ForeignKey("IdEmpresaInv, IdSucursalInv, IdBodegaInv, IdMoviInvenTipoInv, IdNumMoviInv, SecuenciaInv")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual InMoviInveDetalle? InMoviInveDetalle { get; set; }

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual InProducto InProducto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual TbBodega TbBodega { get; set; } = null!;

    [ForeignKey("InIdEmpresa, InIdSucursal, InIdMoviInvenTipo, InIdNumMovi, InSecuencia")]
    [InverseProperty("InIngEgrInvenDet")]
    public virtual ICollection<FaNotaCreDebDet> FaNotaCreDebDet { get; set; } = new List<FaNotaCreDebDet>();

    [ForeignKey("InIdEmpresa, InIdSucursal, InIdMoviInvenTipo, InIdNumMovi, InSecuencia")]
    [InverseProperty("InIngEgrInvenDetNavigation")]
    public virtual ICollection<FaNotaCreDebDet> FaNotaCreDebDetNavigation { get; set; } = new List<FaNotaCreDebDet>();
}
