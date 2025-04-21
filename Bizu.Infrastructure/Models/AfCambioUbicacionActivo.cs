using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCambioUbicacion")]
[Table("Af_CambioUbicacion_Activo")]
[Index("IdEmpresa", "IdActivoFijo", Name = "FK_Af_CambioUbicacion_Activo_Af_Activo_fijo")]
[Index("IdTipoCatalogoUbicacionActu", Name = "FK_Af_CambioUbicacion_Activo_Af_Catalogo")]
[Index("IdTipoCatalogoUbicacionAnt", Name = "FK_Af_CambioUbicacion_Activo_Af_Catalogo1")]
[Index("IdEmpresa", "IdDepartamentoActu", Name = "FK_Af_CambioUbicacion_Activo_Af_Departamento")]
[Index("IdEmpresa", "IdDepartamentoAnt", Name = "FK_Af_CambioUbicacion_Activo_Af_Departamento1")]
[Index("IdEmpresa", "IdCentroCostoActu", Name = "FK_Af_CambioUbicacion_Activo_ct_centro_costo")]
[Index("IdEmpresa", "IdCentroCostoAnt", Name = "FK_Af_CambioUbicacion_Activo_ct_centro_costo1")]
[Index("IdEmpresa", "IdSucursalActu", Name = "FK_Af_CambioUbicacion_Activo_tb_sucursal")]
[Index("IdEmpresa", "IdSucursalAnt", Name = "FK_Af_CambioUbicacion_Activo_tb_sucursal1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfCambioUbicacionActivo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdCambioUbicacion { get; set; }

    public int IdActivoFijo { get; set; }

    [Column("IdSucursal_Actu")]
    public int? IdSucursalActu { get; set; }

    [Column("IdDepartamento_Actu")]
    public int? IdDepartamentoActu { get; set; }

    [Column("IdCentroCosto_Actu")]
    [StringLength(20)]
    public string? IdCentroCostoActu { get; set; }

    [Column("IdTipoCatalogo_Ubicacion_Actu")]
    [StringLength(35)]
    public string? IdTipoCatalogoUbicacionActu { get; set; }

    [Column("IdSucursal_Ant")]
    public int? IdSucursalAnt { get; set; }

    [Column("IdDepartamento_Ant")]
    public int? IdDepartamentoAnt { get; set; }

    [Column("IdTipoCatalogo_Ubicacion_Ant")]
    [StringLength(35)]
    public string? IdTipoCatalogoUbicacionAnt { get; set; }

    [Column("IdCentroCosto_Ant")]
    [StringLength(20)]
    public string? IdCentroCostoAnt { get; set; }

    [MaxLength(6)]
    public DateTime FechaCambio { get; set; }

    [StringLength(500)]
    public string MotivoCambio { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("Af_ValorUnidad_Actu")]
    public double? AfValorUnidadActu { get; set; }

    [Column("IdUnidadFact_cat")]
    [StringLength(50)]
    public string? IdUnidadFactCat { get; set; }

    [Column("IdEncargado_Ant")]
    [Precision(18, 0)]
    public decimal? IdEncargadoAnt { get; set; }

    [Column("IdEncargado_Actu")]
    [Precision(18, 0)]
    public decimal? IdEncargadoActu { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_Actu")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCostoActu { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_Ant")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCostoAnt { get; set; }

    [ForeignKey("IdEmpresa, IdActivoFijo")]
    [InverseProperty("AfCambioUbicacionActivo")]
    public virtual AfActivoFijo AfActivoFijo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdDepartamentoActu")]
    [InverseProperty("AfCambioUbicacionActivoAfDepartamento")]
    public virtual AfDepartamento? AfDepartamento { get; set; }

    [ForeignKey("IdEmpresa, IdDepartamentoAnt")]
    [InverseProperty("AfCambioUbicacionActivoAfDepartamentoNavigation")]
    public virtual AfDepartamento? AfDepartamentoNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoActu")]
    [InverseProperty("AfCambioUbicacionActivoCtCentroCosto")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoAnt")]
    [InverseProperty("AfCambioUbicacionActivoCtCentroCostoNavigation")]
    public virtual CtCentroCosto? CtCentroCostoNavigation { get; set; }

    [ForeignKey("IdTipoCatalogoUbicacionActu")]
    [InverseProperty("AfCambioUbicacionActivoIdTipoCatalogoUbicacionActuNavigation")]
    public virtual AfCatalogo? IdTipoCatalogoUbicacionActuNavigation { get; set; }

    [ForeignKey("IdTipoCatalogoUbicacionAnt")]
    [InverseProperty("AfCambioUbicacionActivoIdTipoCatalogoUbicacionAntNavigation")]
    public virtual AfCatalogo? IdTipoCatalogoUbicacionAntNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdSucursalActu")]
    [InverseProperty("AfCambioUbicacionActivoTbSucursal")]
    public virtual TbSucursal? TbSucursal { get; set; }

    [ForeignKey("IdEmpresa, IdSucursalAnt")]
    [InverseProperty("AfCambioUbicacionActivoTbSucursalNavigation")]
    public virtual TbSucursal? TbSucursalNavigation { get; set; }
}
