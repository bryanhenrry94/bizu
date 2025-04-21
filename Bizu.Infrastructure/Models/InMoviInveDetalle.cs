using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdNumMovi", "Secuencia")]
[Table("in_movi_inve_detalle")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_in_movi_inve_detalle_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_movi_inve_detalle_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_in_movi_inve_detalle_in_UnidadMedida")]
[Index("IdUnidadMedidaSinConversion", Name = "FK_in_movi_inve_detalle_in_UnidadMedida1")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto", Name = "vwin_producto_x_tb_bodega_Lote_Index4")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInveDetalle
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("mv_tipo_movi")]
    [StringLength(1)]
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
    public string DmObservacion { get; set; } = null!;

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [Column("dm_peso")]
    public double? DmPeso { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("dm_cantidad_sinConversion")]
    public double DmCantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    public string IdUnidadMedidaSinConversion { get; set; } = null!;

    [Column("mv_costo_sinConversion")]
    public double? MvCostoSinConversion { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    public bool? Costeado { get; set; }

    [Column("IdEmpresa_dev")]
    public int? IdEmpresaDev { get; set; }

    [Column("IdSucursal_dev")]
    public int? IdSucursalDev { get; set; }

    [Column("IdBodega_dev")]
    public int? IdBodegaDev { get; set; }

    [Column("IdMovi_inven_tipo_dev")]
    public int? IdMoviInvenTipoDev { get; set; }

    [Column("IdNumMovi_dev")]
    [Precision(18, 0)]
    public decimal? IdNumMoviDev { get; set; }

    [Column("Secuencia_dev")]
    public int? SecuenciaDev { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("InMoviInveDetalle")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("InMoviInveDetalle")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("InMoviInveDetalleIdUnidadMedidaNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedidaSinConversion")]
    [InverseProperty("InMoviInveDetalleIdUnidadMedidaSinConversionNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaSinConversionNavigation { get; set; } = null!;

    [InverseProperty("InMoviInveDetalle")]
    public virtual ICollection<InDevolucionInvenDet> InDevolucionInvenDet { get; set; } = new List<InDevolucionInvenDet>();

    [InverseProperty("InMoviInveDetalle")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdMoviInvenTipo, IdNumMovi")]
    [InverseProperty("InMoviInveDetalle")]
    public virtual InMoviInve InMoviInve { get; set; } = null!;

    [InverseProperty("InMoviInveDetalle")]
    public virtual ICollection<InMoviInveDetalleXComOrdencompraLocalDet> InMoviInveDetalleXComOrdencompraLocalDet { get; set; } = new List<InMoviInveDetalleXComOrdencompraLocalDet>();

    [InverseProperty("InMoviInveDetalle")]
    public virtual ICollection<InMoviInveDetalleXItem> InMoviInveDetalleXItem { get; set; } = new List<InMoviInveDetalleXItem>();

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InMoviInveDetalle")]
    public virtual InProducto InProducto { get; set; } = null!;
}
