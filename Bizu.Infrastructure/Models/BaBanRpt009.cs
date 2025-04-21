using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCtaCble")]
[Table("ba_BAN_Rpt009")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaBanRpt009
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("Saldo_anterior")]
    public double SaldoAnterior { get; set; }

    public double Ingreso { get; set; }

    public double Egreso { get; set; }

    [Column("Saldo_final")]
    public double SaldoFinal { get; set; }

    [Column("fecha_ini")]
    [MaxLength(6)]
    public DateTime FechaIni { get; set; }

    [Column("fecha_fin")]
    [MaxLength(6)]
    public DateTime FechaFin { get; set; }

    [Column("nom_Banco")]
    [StringLength(200)]
    public string NomBanco { get; set; } = null!;
}
