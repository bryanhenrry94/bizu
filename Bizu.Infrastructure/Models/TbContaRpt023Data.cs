using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCtaCble", "IdCtaCblePadre", "IdCentroCosto", "IdUsuario")]
[Table("tbCONTA_Rpt023_Data")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbContaRpt023Data
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Key]
    [Column("IdCtaCble_Padre")]
    [StringLength(20)]
    public string IdCtaCblePadre { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Column("Saldo_Inicial")]
    public double SaldoInicial { get; set; }

    [Column("Saldo_Deudor")]
    public double SaldoDeudor { get; set; }

    [Column("Saldo_Acreedor")]
    public double SaldoAcreedor { get; set; }

    [Column("Saldo_Acumulado")]
    public double SaldoAcumulado { get; set; }
}
