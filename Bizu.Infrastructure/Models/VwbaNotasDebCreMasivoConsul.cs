using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaNotasDebCreMasivoConsul
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdTransaccion { get; set; }

    [Column("tm_fecha")]
    [MaxLength(6)]
    public DateTime TmFecha { get; set; }

    [Column("tm_observacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TmObservacion { get; set; }

    [Column("tm_tipo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmTipo { get; set; } = null!;

    [Column("tm_IdUsuario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmIdUsuario { get; set; } = null!;

    public long TotalTransacciones { get; set; }
}
