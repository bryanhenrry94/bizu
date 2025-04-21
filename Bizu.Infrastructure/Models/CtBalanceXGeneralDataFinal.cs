using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("ct_Balance_x_General_Data_Final")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtBalanceXGeneralDataFinal
{
    public int IdEmpresa { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("nom_cuenta")]
    [StringLength(250)]
    public string? NomCuenta { get; set; }

    public int IdNivelCta { get; set; }

    [StringLength(50)]
    public string GrupoCble { get; set; } = null!;

    public int? OrderGrupoCble { get; set; }

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

    [Column("pc_EsMovimiento")]
    [StringLength(1)]
    public string PcEsMovimiento { get; set; } = null!;

    [Column("gc_signo_operacion")]
    public int? GcSignoOperacion { get; set; }

    public bool? CtaUtilidad { get; set; }

    [Column("Saldo_inicial_x_Movi")]
    public double? SaldoInicialXMovi { get; set; }

    [Column("Debito_Mes_x_Movi")]
    public double? DebitoMesXMovi { get; set; }

    [Column("Credito_Mes_x_Movi")]
    public double? CreditoMesXMovi { get; set; }

    [Column("Saldo_x_Movi")]
    public double? SaldoXMovi { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("nom_centro_costo")]
    [StringLength(250)]
    public string? NomCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("nom_punto_cargo_grupo")]
    [StringLength(50)]
    public string? NomPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(50)]
    public string? NomPuntoCargo { get; set; }

    [Column("nom_empresa")]
    [StringLength(50)]
    public string NomEmpresa { get; set; } = null!;

    [Column("IdGrupo_Mayor")]
    [StringLength(50)]
    public string? IdGrupoMayor { get; set; }

    [Column("nom_grupo_mayor")]
    [StringLength(150)]
    public string? NomGrupoMayor { get; set; }

    [Column("order_grupo_mayor")]
    public int? OrderGrupoMayor { get; set; }

    [Column("orden_fila")]
    public int OrdenFila { get; set; }

    [Column("Reg_x_CC")]
    public bool? RegXCc { get; set; }

    [Column("Saldo_Inicial_deudor")]
    public double? SaldoInicialDeudor { get; set; }

    [Column("Saldo_Inicial_acreedor")]
    public double? SaldoInicialAcreedor { get; set; }

    [Column("Saldo_fin_deudor")]
    public double? SaldoFinDeudor { get; set; }

    [Column("Saldo_fin_acreedor")]
    public double? SaldoFinAcreedor { get; set; }

    [Column("pc_clave_corta")]
    [StringLength(20)]
    public string? PcClaveCorta { get; set; }

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [StringLength(40)]
    public string? CodCentroCosto { get; set; }
}
