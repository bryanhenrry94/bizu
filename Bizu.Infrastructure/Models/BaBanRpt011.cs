using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacion", "IdTipoCbte", "IdCbteCble", "Secuencia")]
[Table("ba_BAN_Rpt011")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaBanRpt011
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }
}
