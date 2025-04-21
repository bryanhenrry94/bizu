using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAnioF", "IdPeriodo", "IdCtaCble")]
[Table("ct_saldoxCuentas")]
[Index("IdAnioF", Name = "FK_ct_saldoxCuentas_ct_anio_fiscal")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_ct_saldoxCuentas_ct_periodo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_saldoxCuentas_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtSaldoxCuentas
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

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("CtSaldoxCuentas")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtSaldoxCuentas")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdAnioF")]
    [InverseProperty("CtSaldoxCuentas")]
    public virtual CtAnioFiscal IdAnioFNavigation { get; set; } = null!;
}
