using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCble", "IdTipocbte", "IdOrdenPago")]
[Table("ba_Cbte_Ban_Edehsa")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBanEdehsa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int IdTipocbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }
}
