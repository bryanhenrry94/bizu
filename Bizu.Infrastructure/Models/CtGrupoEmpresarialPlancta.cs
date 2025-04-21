using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_GrupoEmpresarial_plancta")]
[Index("IdGrupoCbleGr", Name = "FK_ct_GrupoEmpresarial_plancta_ct_GrupoEmpresarial_grupocble")]
[Index("IdCuentaPadreGr", Name = "FK_ct_GrupoEmpresarial_plancta_ct_GrupoEmpresarial_plancta")]
[Index("IdNivelCtaGr", Name = "FK_ct_GrupoEmpresarial_plancta_ct_GrupoEmpresarial_plancta_nivel")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupoEmpresarialPlancta
{
    [Key]
    [Column("IdCuenta_gr")]
    [StringLength(20)]
    public string IdCuentaGr { get; set; } = null!;

    [Column("pc_Cuenta_gr")]
    [StringLength(150)]
    public string PcCuentaGr { get; set; } = null!;

    [Column("IdCuentaPadre_gr")]
    [StringLength(20)]
    public string? IdCuentaPadreGr { get; set; }

    [Column("pc_Naturaleza")]
    [StringLength(1)]
    public string PcNaturaleza { get; set; } = null!;

    [Column("IdNivelCta_gr")]
    public int IdNivelCtaGr { get; set; }

    [Column("IdGrupoCble_gr")]
    [StringLength(5)]
    public string IdGrupoCbleGr { get; set; } = null!;

    [Column("pc_EsMovimiento")]
    [StringLength(1)]
    public string PcEsMovimiento { get; set; } = null!;

    [Column("pc_Estado")]
    [StringLength(1)]
    public string PcEstado { get; set; } = null!;

    [InverseProperty("IdCuentaGrNavigation")]
    public virtual ICollection<CtGrupoEmpresarialPlanctaXCtPlancta> CtGrupoEmpresarialPlanctaXCtPlancta { get; set; } = new List<CtGrupoEmpresarialPlanctaXCtPlancta>();

    [ForeignKey("IdCuentaPadreGr")]
    [InverseProperty("InverseIdCuentaPadreGrNavigation")]
    public virtual CtGrupoEmpresarialPlancta? IdCuentaPadreGrNavigation { get; set; }

    [ForeignKey("IdGrupoCbleGr")]
    [InverseProperty("CtGrupoEmpresarialPlancta")]
    public virtual CtGrupoEmpresarialGrupocble IdGrupoCbleGrNavigation { get; set; } = null!;

    [ForeignKey("IdNivelCtaGr")]
    [InverseProperty("CtGrupoEmpresarialPlancta")]
    public virtual CtGrupoEmpresarialPlanctaNivel IdNivelCtaGrNavigation { get; set; } = null!;

    [InverseProperty("IdCuentaPadreGrNavigation")]
    public virtual ICollection<CtGrupoEmpresarialPlancta> InverseIdCuentaPadreGrNavigation { get; set; } = new List<CtGrupoEmpresarialPlancta>();
}
