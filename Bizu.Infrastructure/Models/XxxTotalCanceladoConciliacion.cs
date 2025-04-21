using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("xxx_total_cancelado_conciliacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class XxxTotalCanceladoConciliacion
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

    public double? MontoAplicado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }
}
