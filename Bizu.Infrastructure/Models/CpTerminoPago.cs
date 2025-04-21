using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTerminoPago")]
[Table("cp_TerminoPago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpTerminoPago
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdTerminoPago { get; set; } = null!;

    [Column("nom_TerminoPago")]
    [StringLength(50)]
    public string NomTerminoPago { get; set; } = null!;

    [Column("Num_Coutas")]
    public int NumCoutas { get; set; }

    [Column("Dias_Vct")]
    public int DiasVct { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(50)]
    public string? MotiAnula { get; set; }
}
