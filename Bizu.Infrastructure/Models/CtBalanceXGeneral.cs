using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCtaCble", "IdCentroCosto", "IdUsuario")]
[Table("ct_Balance_x_General")]
[Index("IdEmpresa", "IdUsuario", "IdCtaCble", "IdCentroCosto", "CreditoMes", Name = "ct_Balance_x_General_Index")]
[Index("IdEmpresa", "IdUsuario", "IdCtaCble", "IdCentroCosto", "SaldoInicial", "DebitoMes", "CreditoMes", Name = "ct_Balance_x_General_Index_2")]
[Index("IdEmpresa", "IdUsuario", "IdCtaCble", "IdCentroCosto", "Saldo", Name = "ct_Balance_x_General_Index_3")]
[Index("IdEmpresa", "IdUsuario", "IdCtaCble", "IdCentroCosto", "SaldoInicialXMovi", "CreditoMesXMovi", Name = "ct_Balance_x_General_Index_4")]
[Index("IdEmpresa", "IdUsuario", "IdCtaCble", "IdCentroCosto", "SaldoInicialXMovi", "DebitoMesXMovi", "CreditoMesXMovi", Name = "ct_Balance_x_General_Index_5")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtBalanceXGeneral
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("nom_cuenta")]
    [StringLength(189)]
    public string? NomCuenta { get; set; }

    public int IdNivelCta { get; set; }

    [StringLength(50)]
    public string GrupoCble { get; set; } = null!;

    public byte OrderGrupoCble { get; set; }

    [Column("gc_estado_financiero")]
    [StringLength(2)]
    public string GcEstadoFinanciero { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCblePadre { get; set; }

    [Column("Saldo_Inicial")]
    public double SaldoInicial { get; set; }

    [Column("Debito_Mes")]
    public double DebitoMes { get; set; }

    [Column("Credito_Mes")]
    public double CreditoMes { get; set; }

    public double Saldo { get; set; }

    public bool? CtaUtilidad { get; set; }

    [Column("Saldo_inicial_x_Movi")]
    public double? SaldoInicialXMovi { get; set; }

    [Column("Debito_Mes_x_Movi")]
    public double? DebitoMesXMovi { get; set; }

    [Column("Credito_Mes_x_Movi")]
    public double? CreditoMesXMovi { get; set; }

    [Column("Saldo_x_Movi")]
    public double? SaldoXMovi { get; set; }

    [Column("Saldo_Inicial_deudor")]
    public double? SaldoInicialDeudor { get; set; }

    [Column("Saldo_Inicial_acreedor")]
    public double? SaldoInicialAcreedor { get; set; }

    [Column("Saldo_fin_deudor")]
    public double? SaldoFinDeudor { get; set; }

    [Column("Saldo_fin_acreedor")]
    public double? SaldoFinAcreedor { get; set; }
}
