using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpConciliacionPoli
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public DateOnly Fecha { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("ip")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Precision(18, 0)]
    public decimal? IdCancelacion { get; set; }

    [Column("Tipo_detalle")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoDetalle { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Tipo { get; set; }

    [Column("IdEmpresa_cbtecble")]
    public int? IdEmpresaCbtecble { get; set; }

    [Column("IdTipoCbte_cbtecble")]
    public int? IdTipoCbteCbtecble { get; set; }

    [Column("IdCbteCble_cbtecble")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCbtecble { get; set; }

    public double? MontoAplicado { get; set; }

    public double? SaldoAnterior { get; set; }

    public double? SaldoActual { get; set; }
}
