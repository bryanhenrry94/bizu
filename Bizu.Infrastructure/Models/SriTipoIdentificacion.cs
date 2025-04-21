using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("sri_tipoIdentificacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SriTipoIdentificacion
{
    [Key]
    [StringLength(5)]
    public string IdTipoIdenti { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }

    [StringLength(10)]
    public string? Estado { get; set; }

    [StringLength(5)]
    public string? IdCodigo2 { get; set; }
}
