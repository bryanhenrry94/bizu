using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class Libro1
{
    public int? A { get; set; }

    public int? B { get; set; }

    public int? C { get; set; }

    public int? D { get; set; }

    public int? E { get; set; }

    [Column(TypeName = "text")]
    public string? F { get; set; }

    public int? G { get; set; }

    public long? H { get; set; }

    public long? I { get; set; }

    [MaxLength(1)]
    public byte[]? J { get; set; }

    [Column(TypeName = "text")]
    public string? K { get; set; }

    [Column(TypeName = "text")]
    public string? L { get; set; }
}
