using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("sysdiagrams")]
[Index("PrincipalId", "Name", Name = "UK_principal_name", IsUnique = true)]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class Sysdiagrams
{
    [Column("name")]
    [StringLength(160)]
    public string Name { get; set; } = null!;

    [Column("principal_id")]
    public int PrincipalId { get; set; }

    [Key]
    [Column("diagram_id")]
    public int DiagramId { get; set; }

    [Column("version")]
    public int? Version { get; set; }

    [Column("definition")]
    public byte[]? Definition { get; set; }
}
