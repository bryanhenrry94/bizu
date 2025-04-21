using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctCbtecbleConSaldoCxpNota
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal IdCbteCbleNota { get; set; }

    [Column("IdTipoCbte_Nota")]
    public int IdTipoCbteNota { get; set; }

    [Column("cn_fecha")]
    public DateOnly CnFecha { get; set; }

    [Column("cn_observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CnObservacion { get; set; } = null!;

    [Column("referncia")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Referncia { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;

    [Column("Valor_Cbte")]
    [Precision(18, 2)]
    public decimal ValorCbte { get; set; }

    [Column("Valor_Cancelado_cbte")]
    public double ValorCanceladoCbte { get; set; }

    [Column("Valor_saldo_cbte")]
    public double ValorSaldoCbte { get; set; }

    [StringLength(9)]
    public string Tipo { get; set; } = null!;

    [Column("IdEmpresaOP")]
    [MaxLength(0)]
    public byte[]? IdEmpresaOp { get; set; }

    [Column("IdOrdenPagoOP")]
    [MaxLength(0)]
    public byte[]? IdOrdenPagoOp { get; set; }

    [Column("SecuenciaOP")]
    [MaxLength(0)]
    public byte[]? SecuenciaOp { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaAnticipo { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Beneficiario { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }
}
