using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursalSc", "IdSolicitudCompra", "SecuenciaSc")]
[Table("com_solicitud_compra_det_aprobacion")]
[Index("IdEstadoAprobacion", Name = "FK_com_solicitud_compra_det_aprobacion_com_catalogo")]
[Index("IdEstadoPreAprobacion", Name = "FK_com_solicitud_compra_det_aprobacion_com_catalogo1")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_com_solicitud_compra_det_aprobacion_ct_centro_costo_sub_cen26")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_com_solicitud_compra_det_aprobacion_ct_punto_cargo1")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_com_solicitud_compra_det_aprobacion_ct_punto_cargo_grupo")]
[Index("IdUnidadMedida", Name = "FK_com_solicitud_compra_det_aprobacion_in_UnidadMedida")]
[Index("IdCodImpuestoIva", Name = "FK_com_solicitud_compra_det_aprobacion_tb_sis_Impuesto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComSolicitudCompraDetAprobacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdSucursal_SC")]
    public int IdSucursalSc { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [Key]
    [Column("Secuencia_SC")]
    public int SecuenciaSc { get; set; }

    [Column("IdProducto_SC")]
    [Precision(18, 0)]
    public decimal? IdProductoSc { get; set; }

    [Column("NomProducto_SC")]
    [StringLength(500)]
    public string? NomProductoSc { get; set; }

    [Column("Cantidad_aprobada")]
    public double CantidadAprobada { get; set; }

    [StringLength(25)]
    public string IdEstadoAprobacion { get; set; } = null!;

    [Column("IdProveedor_SC")]
    [Precision(18, 0)]
    public decimal? IdProveedorSc { get; set; }

    [StringLength(25)]
    public string? IdUsuarioAprueba { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAprobacion { get; set; }

    [Column("observacion")]
    [StringLength(200)]
    public string? Observacion { get; set; }

    [StringLength(25)]
    public string? IdUnidadMedida { get; set; }

    [Column("do_precioCompra")]
    public double? DoPrecioCompra { get; set; }

    [Column("do_porc_des")]
    public double? DoPorcDes { get; set; }

    [Column("do_descuento")]
    public double? DoDescuento { get; set; }

    [Column("do_subtotal")]
    public double? DoSubtotal { get; set; }

    [Column("do_iva")]
    public double? DoIva { get; set; }

    [Column("do_total")]
    public double? DoTotal { get; set; }

    [Column("do_ManejaIva")]
    public bool? DoManejaIva { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("do_observacion")]
    [StringLength(550)]
    public string? DoObservacion { get; set; }

    [StringLength(25)]
    public string? IdEstadoPreAprobacion { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    public string? IdCodImpuestoIva { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("ComSolicitudCompraDetAprobacion")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("ComSolicitudCompraDetAprobacion")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("ComSolicitudCompraDetAprobacion")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("ComSolicitudCompraDetAprobacion")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }

    [ForeignKey("IdCodImpuestoIva")]
    [InverseProperty("ComSolicitudCompraDetAprobacion")]
    public virtual TbSisImpuesto? IdCodImpuestoIvaNavigation { get; set; }

    [ForeignKey("IdEstadoAprobacion")]
    [InverseProperty("ComSolicitudCompraDetAprobacionIdEstadoAprobacionNavigation")]
    public virtual ComCatalogo IdEstadoAprobacionNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoPreAprobacion")]
    [InverseProperty("ComSolicitudCompraDetAprobacionIdEstadoPreAprobacionNavigation")]
    public virtual ComCatalogo? IdEstadoPreAprobacionNavigation { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("ComSolicitudCompraDetAprobacion")]
    public virtual InUnidadMedida? IdUnidadMedidaNavigation { get; set; }
}
