using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpConciliacionCaja
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public int IdCaja { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCierre { get; set; } = null!;

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("IdEmpresa_op")]
    public int? IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_op")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [Column("Valor_pagado")]
    public double? ValorPagado { get; set; }

    [Column("nom_Caja")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCaja { get; set; } = null!;

    [Column("nom_Estado")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomEstado { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("Saldo_cont_al_periodo")]
    public double SaldoContAlPeriodo { get; set; }

    public double Ingresos { get; set; }

    [Column("Total_Ing")]
    public double TotalIng { get; set; }

    [Column("Total_fact_vale")]
    public double TotalFactVale { get; set; }

    [Column("Total_fondo")]
    public double TotalFondo { get; set; }

    [Column("Dif_x_pagar_o_cobrar")]
    public double DifXPagarOCobrar { get; set; }

    public int IdPeriodo { get; set; }

    [Column("Fecha_ini")]
    [MaxLength(6)]
    public DateTime? FechaIni { get; set; }

    [Column("Fecha_fin")]
    [MaxLength(6)]
    public DateTime? FechaFin { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("IdEmpresa_mov_caj")]
    public int? IdEmpresaMovCaj { get; set; }

    [Column("IdTipoCbte_mov_caj")]
    public int? IdTipoCbteMovCaj { get; set; }

    [Column("IdCbteCble_mov_caj")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleMovCaj { get; set; }
}
