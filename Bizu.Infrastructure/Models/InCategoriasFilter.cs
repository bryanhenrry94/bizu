using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoria", "IdUsuario")]
[Table("in_categorias_filter")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InCategoriasFilter
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;
}
