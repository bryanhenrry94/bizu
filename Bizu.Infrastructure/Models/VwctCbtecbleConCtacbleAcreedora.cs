using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctCbtecbleConCtacbleAcreedora
{
    public int IdEmpresa { get; set; }

    public int IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Column("IdCtaCble_Acreedora")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleAcreedora { get; set; }
}
