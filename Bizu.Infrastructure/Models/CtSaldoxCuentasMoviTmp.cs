using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAnioF", "IdPeriodo", "IdCtaCble")]
[Table("ct_saldoxCuentas_Movi_tmp")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtSaldoxCuentasMoviTmp
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

    [StringLength(20)]
    public string IdCtaCblePadre { get; set; } = null!;

    [Column("sc_saldo_anterior")]
    public double ScSaldoAnterior { get; set; }

    [Column("sc_debito_mes")]
    public double ScDebitoMes { get; set; }

    [Column("sc_credito_mes")]
    public double ScCreditoMes { get; set; }

    [Column("sc_debito_acum")]
    public double ScDebitoAcum { get; set; }

    [Column("sc_credito_acum")]
    public double ScCreditoAcum { get; set; }

    [Column("sc_saldo_acum")]
    public double ScSaldoAcum { get; set; }
}
