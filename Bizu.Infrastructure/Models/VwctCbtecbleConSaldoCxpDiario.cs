using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctCbtecbleConSaldoCxpDiario
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipoCbte { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("cb_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CbObservacion { get; set; } = null!;

    [Column("referencia")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Referencia { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;

    [Column("Valor_Cbte")]
    public double? ValorCbte { get; set; }

    [Column("Valor_Cancelado_cbte")]
    public double ValorCanceladoCbte { get; set; }

    [Column("Valor_saldo_cbte")]
    public double? ValorSaldoCbte { get; set; }

    [StringLength(6)]
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

    [MaxLength(0)]
    public byte[]? IdCtaCble { get; set; }

    [Column("IdCtaCble_Anticipo")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleAnticipo { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Beneficiario { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }
}
