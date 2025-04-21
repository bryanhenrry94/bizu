using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_GrupoEmpresarial_plancta_nivel")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupoEmpresarialPlanctaNivel
{
    [Key]
    [Column("IdNivelCta_gr")]
    public int IdNivelCtaGr { get; set; }

    [Column("nv_NumDigitos_gr")]
    public int NvNumDigitosGr { get; set; }

    [Column("nv_Descripcion_gr")]
    [StringLength(50)]
    public string NvDescripcionGr { get; set; } = null!;

    [InverseProperty("IdNivelCtaGrNavigation")]
    public virtual ICollection<CtGrupoEmpresarialPlancta> CtGrupoEmpresarialPlancta { get; set; } = new List<CtGrupoEmpresarialPlancta>();
}
