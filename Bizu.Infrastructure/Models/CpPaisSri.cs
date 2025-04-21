using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_pais_sri")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpPaisSri
{
    [Key]
    [StringLength(5)]
    public string Codigo { get; set; } = null!;

    [StringLength(50)]
    public string? Pais { get; set; }

    [InverseProperty("PaisPagoNavigation")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiro { get; set; } = new List<CpOrdenGiro>();
}
