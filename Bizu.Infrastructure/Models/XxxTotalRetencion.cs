using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("xxx_total_retencion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class XxxTotalRetencion
{
    [Key]
    public int Id { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("Total_Retencion")]
    public double? TotalRetencion { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }
}
