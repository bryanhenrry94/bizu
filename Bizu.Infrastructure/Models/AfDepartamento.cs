using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdDepartamento")]
[Table("Af_Departamento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfDepartamento
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdDepartamento { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("nom_departamento")]
    [StringLength(100)]
    public string? NomDepartamento { get; set; }

    [InverseProperty("AfDepartamento")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("AfDepartamento")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoAfDepartamento { get; set; } = new List<AfCambioUbicacionActivo>();

    [InverseProperty("AfDepartamentoNavigation")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoAfDepartamentoNavigation { get; set; } = new List<AfCambioUbicacionActivo>();
}
