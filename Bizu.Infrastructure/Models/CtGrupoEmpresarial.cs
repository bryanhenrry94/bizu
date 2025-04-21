using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_GrupoEmpresarial")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupoEmpresarial
{
    [Key]
    [StringLength(15)]
    public string IdGrupoEmpresarial { get; set; } = null!;

    [StringLength(200)]
    public string GrupoEmpresarial { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("IdGrupoEmpresarialNavigation")]
    public virtual ICollection<CtGrupoEmpresarialPlanctaXCtPlancta> CtGrupoEmpresarialPlanctaXCtPlancta { get; set; } = new List<CtGrupoEmpresarialPlanctaXCtPlancta>();
}
