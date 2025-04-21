using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_tipo_ctacble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtTipoCtacble
{
    [Key]
    [StringLength(10)]
    public string IdTipoCtaCble { get; set; } = null!;

    [Column("nom_TipoCtaCble")]
    [StringLength(150)]
    public string? NomTipoCtaCble { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string? Estado { get; set; }

    [InverseProperty("IdTipoCtaCbleNavigation")]
    public virtual ICollection<CtPlancta> CtPlancta { get; set; } = new List<CtPlancta>();
}
