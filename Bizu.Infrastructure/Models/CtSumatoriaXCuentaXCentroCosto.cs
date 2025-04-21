using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("ct_Sumatoria_x_Cuenta_x_Centro_Costo")]
[Index("IdEmpresa", "Idusuario", "IdCtaCble", "IdCtaCblePadre", "SaldoInicial", "DcSaldoDeudor", "DcSaldoAcreedor", "DcSaldo", "IdCentroCosto", "SaldoInicialDeudor", "SaldoInicialAcreedor", "SaldoFinDeudor", "SaldoFinAcreedor", Name = "ct_Sumatoria_x_Cuenta_X_Centro_Costo_Index")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtSumatoriaXCuentaXCentroCosto
{
    public int IdEmpresa { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCblePadre { get; set; }

    [Column("Saldo_Inicial")]
    public double SaldoInicial { get; set; }

    [Column("dc_Saldo_deudor")]
    public double DcSaldoDeudor { get; set; }

    [Column("dc_Saldo_Acreedor")]
    public double DcSaldoAcreedor { get; set; }

    [Column("dc_Saldo")]
    public double DcSaldo { get; set; }

    [Column("idusuario")]
    [StringLength(50)]
    public string? Idusuario { get; set; }

    [Column("pc")]
    [StringLength(50)]
    public string? Pc { get; set; }

    [Column("es_movimento")]
    [StringLength(1)]
    public string? EsMovimento { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("Saldo_Inicial_deudor")]
    public double? SaldoInicialDeudor { get; set; }

    [Column("Saldo_Inicial_acreedor")]
    public double? SaldoInicialAcreedor { get; set; }

    [Column("Saldo_fin_deudor")]
    public double? SaldoFinDeudor { get; set; }

    [Column("Saldo_fin_acreedor")]
    public double? SaldoFinAcreedor { get; set; }
}
