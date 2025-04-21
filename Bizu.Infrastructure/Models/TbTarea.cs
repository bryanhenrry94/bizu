using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTarea")]
[Table("tb_tarea")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbTarea
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTarea { get; set; }

    [StringLength(100)]
    public string Titulo { get; set; } = null!;

    [StringLength(250)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIni { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaFin { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAsignacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltAsignacion { get; set; }

    [StringLength(25)]
    public string EstadoTarea { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(25)]
    public string Prioridad { get; set; } = null!;

    [StringLength(50)]
    public string IdUsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(50)]
    public string? MotivoAnu { get; set; }
}
