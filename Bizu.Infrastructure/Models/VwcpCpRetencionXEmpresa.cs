using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpCpRetencionXEmpresa
{
    public int IdEmpresa { get; set; }

    [Column("em_ruc")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmRuc { get; set; } = null!;

    [Column("serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }
}
