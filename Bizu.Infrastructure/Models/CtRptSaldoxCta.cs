using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCtaCble")]
[Table("ct_rpt_SaldoxCta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtRptSaldoxCta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("sa_SaldoInicial")]
    public double SaSaldoInicial { get; set; }

    [Column("sa_Debitos")]
    public double SaDebitos { get; set; }

    [Column("sa_Creditos")]
    public double SaCreditos { get; set; }

    [Column("sa_SaldoFinal")]
    public double SaSaldoFinal { get; set; }
}
