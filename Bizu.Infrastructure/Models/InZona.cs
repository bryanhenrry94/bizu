using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdZona")]
[Table("in_Zona")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InZona
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(10)]
    public string IdZona { get; set; } = null!;

    [StringLength(200)]
    public string? Zona { get; set; }

    [StringLength(10)]
    public string? IdTipoZona { get; set; }
}
