using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("sri_tipo_Gasto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SriTipoGasto
{
    [Key]
    [StringLength(50)]
    public string IdTipoGasto { get; set; } = null!;

    [StringLength(150)]
    public string? Descripcion { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }
}
