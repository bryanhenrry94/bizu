using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoria", "IdLinea", "IdGrupo", "IdSubgrupo", "IdCentroCosto", "IdSubCentroCosto")]
[Table("in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble")]
[Index("IdEmpresa", "IdCentroCosto", "IdSubCentroCosto", Name = "FK_in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_ct_cen7")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_ct_pla8")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InSubgrupoXCentroCostoXSubCentroCostoXCtaCble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Key]
    public int IdLinea { get; set; }

    [Key]
    public int IdGrupo { get; set; }

    [Key]
    public int IdSubgrupo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [Key]
    [Column("IdSub_centro_costo")]
    [StringLength(20)]
    public string IdSubCentroCosto { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdSubCentroCosto")]
    [InverseProperty("InSubgrupoXCentroCostoXSubCentroCostoXCtaCble")]
    public virtual CtCentroCostoSubCentroCosto CtCentroCostoSubCentroCosto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("InSubgrupoXCentroCostoXSubCentroCostoXCtaCble")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCategoria, IdLinea, IdGrupo, IdSubgrupo")]
    [InverseProperty("InSubgrupoXCentroCostoXSubCentroCostoXCtaCble")]
    public virtual InSubgrupo InSubgrupo { get; set; } = null!;
}
