using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwContaRpt024
{
    public int IdEmpresa { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Tipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal NumDiario { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Cuenta { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("cb_FechaTransac")]
    [MaxLength(6)]
    public DateTime CbFechaTransac { get; set; }

    public double Debe { get; set; }

    public double Haber { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }
}
