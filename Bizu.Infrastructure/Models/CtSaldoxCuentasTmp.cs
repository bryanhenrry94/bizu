using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAnioF", "IdPeriodo", "IdCtaCble")]
[Table("ct_saldoxCuentas_TMP")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtSaldoxCuentasTmp
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdAnioF { get; set; }

    [Key]
    public int IdPeriodo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    public byte IdNivel { get; set; }

    [Column("sc_saldo_anterior")]
    public double ScSaldoAnterior { get; set; }

    [Column("sc_debito_mes")]
    public double ScDebitoMes { get; set; }

    [Column("sc_credito_mes")]
    public double ScCreditoMes { get; set; }

    [Column("sc_saldo_mes")]
    public double ScSaldoMes { get; set; }

    [Column("sc_saldo_acum")]
    public double ScSaldoAcum { get; set; }

    [StringLength(50)]
    public string? IdCentroCosto { get; set; }
}
