using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdUsuario", "IdEmpresa", "IdCtaCble")]
[Table("ct_saldoxCuentas_Movi_x_RangoFecha")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtSaldoxCuentasMoviXRangoFecha
{
    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(20)]
    public string IdCtaCblePadre { get; set; } = null!;

    [Column("sc_saldo_anterior")]
    public double ScSaldoAnterior { get; set; }

    [Column("sc_deTINYINT(1)o_mes")]
    public double ScDeTinyint1OMes { get; set; }

    [Column("sc_credito_mes")]
    public double ScCreditoMes { get; set; }

    [Column("sc_deTINYINT(1)o_acum")]
    public double ScDeTinyint1OAcum { get; set; }

    [Column("sc_credito_acum")]
    public double ScCreditoAcum { get; set; }

    [Column("sc_saldo_mes")]
    public double ScSaldoMes { get; set; }

    [Column("sc_saldo_acum")]
    public double ScSaldoAcum { get; set; }

    [MaxLength(6)]
    public DateTime FechaIni { get; set; }

    [MaxLength(6)]
    public DateTime FechaFin { get; set; }
}
