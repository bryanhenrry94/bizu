using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCtaCble")]
[Table("tbCONTA_Rpt012")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbContaRpt012
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(50)]
    public string IdCtaCble { get; set; } = null!;

    [Column("IdPeriodo_0")]
    public int IdPeriodo0 { get; set; }

    [Column("nom_Periodo_0")]
    [StringLength(50)]
    public string NomPeriodo0 { get; set; } = null!;

    [Column("Saldo_Periodo_0")]
    public double SaldoPeriodo0 { get; set; }

    [Column("IdPeriodo_1")]
    public int IdPeriodo1 { get; set; }

    [Column("nom_Periodo_1")]
    [StringLength(50)]
    public string NomPeriodo1 { get; set; } = null!;

    [Column("Saldo_Periodo_1")]
    public double SaldoPeriodo1 { get; set; }

    [Column("IdPeriodo_2")]
    public int IdPeriodo2 { get; set; }

    [Column("nom_Periodo_2")]
    [StringLength(50)]
    public string NomPeriodo2 { get; set; } = null!;

    [Column("Saldo_Periodo_2")]
    public double SaldoPeriodo2 { get; set; }

    [Column("IdPeriodo_3")]
    public int IdPeriodo3 { get; set; }

    [Column("nom_Periodo_3")]
    [StringLength(50)]
    public string NomPeriodo3 { get; set; } = null!;

    [Column("Saldo_Periodo_3")]
    public double SaldoPeriodo3 { get; set; }

    [Column("IdPeriodo_4")]
    public int IdPeriodo4 { get; set; }

    [Column("nom_Periodo_4")]
    [StringLength(50)]
    public string NomPeriodo4 { get; set; } = null!;

    [Column("Saldo_Periodo_4")]
    public double SaldoPeriodo4 { get; set; }

    [Column("IdPeriodo_5")]
    public int IdPeriodo5 { get; set; }

    [Column("nom_Periodo_5")]
    [StringLength(50)]
    public string NomPeriodo5 { get; set; } = null!;

    [Column("Saldo_Periodo_5")]
    public double SaldoPeriodo5 { get; set; }

    [Column("IdPeriodo_6")]
    public int IdPeriodo6 { get; set; }

    [Column("nom_Periodo_6")]
    [StringLength(50)]
    public string NomPeriodo6 { get; set; } = null!;

    [Column("Saldo_Periodo_6")]
    public double SaldoPeriodo6 { get; set; }

    [Column("IdPeriodo_7")]
    public int IdPeriodo7 { get; set; }

    [Column("nom_Periodo_7")]
    [StringLength(50)]
    public string NomPeriodo7 { get; set; } = null!;

    [Column("Saldo_Periodo_7")]
    public double SaldoPeriodo7 { get; set; }

    [Column("IdPeriodo_8")]
    public int IdPeriodo8 { get; set; }

    [Column("nom_Periodo_8")]
    [StringLength(50)]
    public string NomPeriodo8 { get; set; } = null!;

    [Column("Saldo_Periodo_8")]
    public double SaldoPeriodo8 { get; set; }

    [Column("IdPeriodo_9")]
    public int IdPeriodo9 { get; set; }

    [Column("nom_Periodo_9")]
    [StringLength(50)]
    public string NomPeriodo9 { get; set; } = null!;

    [Column("Saldo_Periodo_9")]
    public double SaldoPeriodo9 { get; set; }

    [Column("IdPeriodo_10")]
    public int IdPeriodo10 { get; set; }

    [Column("nom_Periodo_10")]
    [StringLength(50)]
    public string NomPeriodo10 { get; set; } = null!;

    [Column("Saldo_Periodo_10")]
    public double SaldoPeriodo10 { get; set; }

    [Column("IdPeriodo_11")]
    public int IdPeriodo11 { get; set; }

    [Column("nom_Periodo_11")]
    [StringLength(50)]
    public string NomPeriodo11 { get; set; } = null!;

    [Column("Saldo_Periodo_11")]
    public double SaldoPeriodo11 { get; set; }

    [Column("IdPeriodo_12")]
    public int IdPeriodo12 { get; set; }

    [Column("nom_Periodo_12")]
    [StringLength(50)]
    public string NomPeriodo12 { get; set; } = null!;

    [Column("Saldo_Periodo_12")]
    public double SaldoPeriodo12 { get; set; }
}
