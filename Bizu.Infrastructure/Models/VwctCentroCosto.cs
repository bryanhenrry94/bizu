using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctCentroCosto
{
    public int IdEmpresa { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCentroCosto { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodCentroCosto { get; set; } = null!;

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CentroCosto { get; set; } = null!;

    [Column("Centro_costoPadre")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCostoPadre { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoPadre { get; set; }

    [Precision(18, 0)]
    public decimal? IdCatalogo { get; set; }

    [Column("pc_EsMovimiento")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcEsMovimiento { get; set; } = null!;

    public int IdNivel { get; set; }

    [Column("pc_Estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcEstado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }
}
