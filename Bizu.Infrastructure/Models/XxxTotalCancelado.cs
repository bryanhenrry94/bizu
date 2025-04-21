using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("xxx_total_cancelado")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class XxxTotalCancelado
{
    [Key]
    public int Id { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("Total_Cancelado")]
    public double? TotalCancelado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }
}
