using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdOrdenCompra", "Secuencia")]
[Table("com_ordencompra_local_det")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_com_ordencompra_local_det_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_com_ordencompra_local_det_ct_punto_cargo")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_com_ordencompra_local_det_ct_punto_cargo_grupo")]
[Index("IdEmpresa", "IdProducto", Name = "FK_com_ordencompra_local_det_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_com_ordencompra_local_det_in_UnidadMedida")]
[Index("IdEmpresa", "IdSucursal", "IdRubro", Name = "FK_com_ordencompra_local_det_obr_Rubro")]
[Index("IdCodImpuesto", Name = "FK_com_ordencompra_local_det_tb_sis_Impuesto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComOrdencompraLocalDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [Column("do_precioCompra")]
    public double DoPrecioCompra { get; set; }

    [Column("do_porc_des")]
    public double DoPorcDes { get; set; }

    [Column("do_descuento")]
    public double DoDescuento { get; set; }

    [Column("do_precioFinal")]
    public double DoPrecioFinal { get; set; }

    [Column("do_subtotal")]
    public double DoSubtotal { get; set; }

    [Column("do_iva")]
    public double DoIva { get; set; }

    [Column("do_total")]
    public double DoTotal { get; set; }

    [Column("do_ManejaIva")]
    public bool DoManejaIva { get; set; }

    [Column("do_Costeado")]
    [StringLength(1)]
    public string DoCosteado { get; set; } = null!;

    [Column("do_peso")]
    public double DoPeso { get; set; }

    [Column("do_observacion")]
    [StringLength(1000)]
    public string DoObservacion { get; set; } = null!;

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("Por_Iva")]
    public double PorIva { get; set; }

    [Column("IdCod_Impuesto")]
    [StringLength(25)]
    public string IdCodImpuesto { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdRubro { get; set; }

    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual ICollection<ComDevCompraDet> ComDevCompraDet { get; set; } = new List<ComDevCompraDet>();

    [ForeignKey("IdEmpresa, IdSucursal, IdOrdenCompra")]
    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual ComOrdencompraLocal ComOrdencompraLocal { get; set; } = null!;

    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual ICollection<ComOrdencompraLocalDetXComSolicitudCompraDet> ComOrdencompraLocalDetXComSolicitudCompraDet { get; set; } = new List<ComOrdencompraLocalDetXComSolicitudCompraDet>();

    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual ICollection<CpOrdenGiroXComOrdencompraLocalDet> CpOrdenGiroXComOrdencompraLocalDet { get; set; } = new List<CpOrdenGiroXComOrdencompraLocalDet>();

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }

    [ForeignKey("IdCodImpuesto")]
    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual TbSisImpuesto IdCodImpuestoNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;

    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual ICollection<InGuiaXTraspasoBodegaDet> InGuiaXTraspasoBodegaDet { get; set; } = new List<InGuiaXTraspasoBodegaDet>();

    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual ICollection<InMoviInveDetalleXComOrdencompraLocalDet> InMoviInveDetalleXComOrdencompraLocalDet { get; set; } = new List<InMoviInveDetalleXComOrdencompraLocalDet>();

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("ComOrdencompraLocalDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
