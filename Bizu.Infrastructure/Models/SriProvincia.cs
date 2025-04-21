using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("sri_provincia")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SriProvincia
{
    [Key]
    [StringLength(20)]
    public string IdProvincia { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string? Estado { get; set; }

    [Column("Cod_Telefonico")]
    [StringLength(5)]
    public string? CodTelefonico { get; set; }
}
