using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaNotasDebCreMasivo
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdTransaccion { get; set; }

    [Column("tm_tipo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmTipo { get; set; } = null!;

    [Column("tm_IdBanco")]
    public int TmIdBanco { get; set; }

    [Column("tm_fecha")]
    [MaxLength(6)]
    public DateTime TmFecha { get; set; }

    [Column("tm_observacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TmObservacion { get; set; }

    [Column("tm_IdUsuario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmIdUsuario { get; set; } = null!;

    [Column("cb_Valor")]
    public double CbValor { get; set; }

    [Column("cb_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CbObservacion { get; set; } = null!;

    [Column("cb_Fecha")]
    public DateOnly CbFecha { get; set; }

    [Column("cb_IdCbteCble")]
    [Precision(18, 0)]
    public decimal CbIdCbteCble { get; set; }

    [Column("cb_IdTipoCte")]
    public int CbIdTipoCte { get; set; }

    public int IdTipoNota { get; set; }

    [Column("tn_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TnDescripcion { get; set; } = null!;

    [Column("tn_tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TnTipo { get; set; } = null!;

    [Column("tn_IdCtaCble")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TnIdCtaCble { get; set; }

    [Column("tn_IdCentroCosto")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TnIdCentroCosto { get; set; }
}
