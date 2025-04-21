using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinZonaVsCtCentroCosto
{
    [Precision(18, 0)]
    public decimal IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CentroCosto { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdZona { get; set; } = null!;

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Zona { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdSubZona { get; set; } = null!;

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Subzona { get; set; }

    [Column("CodigoZN")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodigoZn { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleZona { get; set; }
}
