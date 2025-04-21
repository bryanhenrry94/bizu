using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctSaldosxCuentas
{
    public int IdEmpresa { get; set; }

    public int IdAnioF { get; set; }

    public int IdPeriodo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(173)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    [Column("pc_Naturaleza")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcNaturaleza { get; set; }

    public long IdNivel { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCblePadre { get; set; }

    [Column("sc_saldo_anterior")]
    public double ScSaldoAnterior { get; set; }

    [Column("sc_debito_mes")]
    public double ScDebitoMes { get; set; }

    [Column("sc_credito_mes")]
    public double ScCreditoMes { get; set; }

    [Column("sc_saldoPeriodo")]
    public double ScSaldoPeriodo { get; set; }

    [Column("sc_debito_acum")]
    public long ScDebitoAcum { get; set; }

    [Column("sc_credito_acum")]
    public long ScCreditoAcum { get; set; }

    [Column("sc_saldo_acum")]
    public double ScSaldoAcum { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdGrupoCble { get; set; } = null!;

    [Column("gc_GrupoCble")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string GcGrupoCble { get; set; } = null!;

    [Column("gc_Orden")]
    public long GcOrden { get; set; }

    [Column("gc_estado_financiero")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string GcEstadoFinanciero { get; set; } = null!;

    [Column("SIdPeriodo")]
    [StringLength(25)]
    public string SidPeriodo { get; set; } = null!;
}
