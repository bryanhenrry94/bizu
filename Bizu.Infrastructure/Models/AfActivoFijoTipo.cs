using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdActijoFijoTipo")]
[Table("Af_Activo_fijo_tipo")]
[Index("IdEmpresa", "IdCtaCbleActivo", Name = "FK_Af_Activo_fijo_tipo_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleDepAcum", Name = "FK_Af_Activo_fijo_tipo_ct_plancta1")]
[Index("IdEmpresa", "IdCtaCbleGastosDepre", Name = "FK_Af_Activo_fijo_tipo_ct_plancta2")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfActivoFijoTipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdActijoFijoTipo { get; set; }

    [StringLength(50)]
    public string CodActivoFijo { get; set; } = null!;

    [Column("Af_Descripcion")]
    [StringLength(150)]
    public string AfDescripcion { get; set; } = null!;

    [Column("Af_Porcentaje_depre")]
    public double AfPorcentajeDepre { get; set; }

    [Column("Af_anio_depreciacion")]
    public int AfAnioDepreciacion { get; set; }

    [Column("IdCtaCble_Activo")]
    [StringLength(20)]
    public string? IdCtaCbleActivo { get; set; }

    [Column("IdCtaCble_Dep_Acum")]
    [StringLength(20)]
    public string? IdCtaCbleDepAcum { get; set; }

    [Column("IdCtaCble_Gastos_Depre")]
    [StringLength(20)]
    public string? IdCtaCbleGastosDepre { get; set; }

    [Column("IdCentroCosto_Activo")]
    [StringLength(20)]
    public string? IdCentroCostoActivo { get; set; }

    [Column("IdCentroCosto_Dep_Acum")]
    [StringLength(20)]
    public string? IdCentroCostoDepAcum { get; set; }

    [Column("IdCentroCosto_Gasto_Depre")]
    [StringLength(20)]
    public string? IdCentroCostoGastoDepre { get; set; }

    [Column("Se_Deprecia")]
    public bool? SeDeprecia { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(100)]
    public string? MotiAnula { get; set; }

    [InverseProperty("AfActivoFijoTipo")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("AfActivoFijoTipo")]
    public virtual ICollection<AfActivoFijoCategoria> AfActivoFijoCategoria { get; set; } = new List<AfActivoFijoCategoria>();

    [ForeignKey("IdEmpresa, IdCtaCbleActivo")]
    [InverseProperty("AfActivoFijoTipoCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleGastosDepre")]
    [InverseProperty("AfActivoFijoTipoCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleDepAcum")]
    [InverseProperty("AfActivoFijoTipoCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }
}
