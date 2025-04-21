using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_grupocble_Mayor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupocbleMayor
{
    [Key]
    [Column("IdGrupo_Mayor")]
    [StringLength(50)]
    public string IdGrupoMayor { get; set; } = null!;

    [Column("nom_grupo_mayor")]
    [StringLength(150)]
    public string NomGrupoMayor { get; set; } = null!;

    [Column("orden")]
    public int Orden { get; set; }

    [InverseProperty("IdGrupoMayorNavigation")]
    public virtual ICollection<CtGrupocble> CtGrupocble { get; set; } = new List<CtGrupocble>();
}
