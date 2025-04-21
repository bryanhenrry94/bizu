using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpConciliacionXCbteCble
{
    public int? IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    public int? IdTipocbte { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("cb_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CbObservacion { get; set; } = null!;

    [Column("referencia")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TcTipoCbte { get; set; }

    [Column("Valor_cbte")]
    public double? ValorCbte { get; set; }

    [Column("Valor_cancelado_cbte")]
    public double ValorCanceladoCbte { get; set; }

    [Column("valor_Saldo_cbte")]
    public double? ValorSaldoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }
}
