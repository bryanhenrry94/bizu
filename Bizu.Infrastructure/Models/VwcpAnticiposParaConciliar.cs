using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpAnticiposParaConciliar
{
    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("referencia")]
    [StringLength(0)]
    public string Referencia { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TcTipoCbte { get; set; }

    [Column("Valor_cbte")]
    public double ValorCbte { get; set; }

    [Column("Valor_cancelado")]
    public double ValorCancelado { get; set; }

    [Column("valor_saldo_cbte")]
    public double ValorSaldoCbte { get; set; }

    [Column("tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Tipo { get; set; } = null!;

    [Column("IdEmpresaOP")]
    public int IdEmpresaOp { get; set; }

    [Column("IdOrdenPagoOP")]
    [Precision(18, 0)]
    public decimal IdOrdenPagoOp { get; set; }

    [Column("SecuenciaOP")]
    public int SecuenciaOp { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [Column("IdCtaCble_Anticipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleAnticipo { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Beneficiario { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }
}
