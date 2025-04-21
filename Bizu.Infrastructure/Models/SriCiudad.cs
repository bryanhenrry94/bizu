using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdCiudad", "IdPais")]
[Table("sri_ciudad")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SriCiudad
{
    [Key]
    [StringLength(20)]
    public string IdCiudad { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string IdPais { get; set; } = null!;

    [StringLength(150)]
    public string Descripcion { get; set; } = null!;

    [Column("estado")]
    [StringLength(10)]
    public string Estado { get; set; } = null!;
}
