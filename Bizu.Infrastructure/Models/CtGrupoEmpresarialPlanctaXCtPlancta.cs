using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdGrupoEmpresarial", "IdCuentaGr", "IdEmpresa", "IdCtaCble")]
[Table("ct_GrupoEmpresarial_plancta_x_ct_plancta")]
[Index("IdCuentaGr", Name = "FK_ct_GrupoEmpresarial_plancta_x_ct_plancta_ct_GrupoEmpresaria23")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_GrupoEmpresarial_plancta_x_ct_plancta_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupoEmpresarialPlanctaXCtPlancta
{
    [Key]
    [StringLength(15)]
    public string IdGrupoEmpresarial { get; set; } = null!;

    [Key]
    [Column("IdCuenta_gr")]
    [StringLength(20)]
    public string IdCuentaGr { get; set; } = null!;

    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtGrupoEmpresarialPlanctaXCtPlancta")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdCuentaGr")]
    [InverseProperty("CtGrupoEmpresarialPlanctaXCtPlancta")]
    public virtual CtGrupoEmpresarialPlancta IdCuentaGrNavigation { get; set; } = null!;

    [ForeignKey("IdGrupoEmpresarial")]
    [InverseProperty("CtGrupoEmpresarialPlanctaXCtPlancta")]
    public virtual CtGrupoEmpresarial IdGrupoEmpresarialNavigation { get; set; } = null!;
}
