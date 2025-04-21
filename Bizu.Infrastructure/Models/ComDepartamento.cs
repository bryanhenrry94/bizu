using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdDepartamento")]
[Table("com_departamento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComDepartamento
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdDepartamento { get; set; }

    [Column("nom_departamento")]
    [StringLength(50)]
    public string NomDepartamento { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(150)]
    public string? MotiAnula { get; set; }

    [InverseProperty("ComDepartamento")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();
}
