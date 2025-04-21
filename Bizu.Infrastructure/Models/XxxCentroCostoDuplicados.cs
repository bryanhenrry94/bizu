using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("xxx_CentroCosto_Duplicados")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class XxxCentroCostoDuplicados
{
    public int IdEmpresa { get; set; }

    public int IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }
}
