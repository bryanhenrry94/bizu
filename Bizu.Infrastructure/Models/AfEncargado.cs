using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdEncargado")]
[Table("Af_Encargado")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfEncargado
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdEncargado { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("nom_encargado")]
    [StringLength(100)]
    public string? NomEncargado { get; set; }

    [InverseProperty("AfEncargado")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();
}
