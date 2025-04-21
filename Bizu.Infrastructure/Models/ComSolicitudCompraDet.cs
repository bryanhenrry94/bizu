using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdSolicitudCompra", "Secuencia")]
[Table("com_solicitud_compra_det")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_com_solicitud_compra_det_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_com_solicitud_compra_det_ct_punto_cargo1")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_com_solicitud_compra_det_ct_punto_cargo_grupo")]
[Index("IdEmpresa", "IdProducto", Name = "FK_com_solicitud_compra_det_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_com_solicitud_compra_det_in_UnidadMedida")]
[Index("IdEmpresa", "IdSucursal", "IdProyecto", "IdOferta", "SecuenciaOferta", Name = "FK_com_solicitud_compra_det_obr_Oferta_det")]
[Index("IdEmpresa", "IdSucursal", "IdRubro", Name = "FK_com_solicitud_compra_det_obr_Rubro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComSolicitudCompraDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [StringLength(500)]
    public string? NomProducto { get; set; }

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
    public string? IdUnidadMedida { get; set; }

    [Column("do_observacion")]
    [StringLength(500)]
    public string? DoObservacion { get; set; }

    [Precision(18, 0)]
    public decimal? IdRubro { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdOferta { get; set; }

    [Column("Secuencia_Oferta")]
    public int? SecuenciaOferta { get; set; }

    [Column("IdEmpresa_obr_AsignacionPorcentual")]
    public int? IdEmpresaObrAsignacionPorcentual { get; set; }

    [Column("IdSucursal_obr_AsignacionPorcentual")]
    public int? IdSucursalObrAsignacionPorcentual { get; set; }

    [Column("IdProyecto_obr_AsignacionPorcentual")]
    public int? IdProyectoObrAsignacionPorcentual { get; set; }

    [Column("IdOferta_obr_AsignacionPorcentual")]
    public int? IdOfertaObrAsignacionPorcentual { get; set; }

    [Column("Secuencia_obr_AsignacionPorcentual")]
    public int? SecuenciaObrAsignacionPorcentual { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdSolicitudCompra")]
    [InverseProperty("ComSolicitudCompraDet")]
    public virtual ComSolicitudCompra ComSolicitudCompra { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("ComSolicitudCompraDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("ComSolicitudCompraDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("ComSolicitudCompraDet")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("ComSolicitudCompraDet")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("ComSolicitudCompraDet")]
    public virtual InUnidadMedida? IdUnidadMedidaNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("ComSolicitudCompraDet")]
    public virtual InProducto? InProducto { get; set; }
}
