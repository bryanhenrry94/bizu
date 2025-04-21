using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwSysCbteRecursivo
{
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCblePadre { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    public double? Valor { get; set; }
}
