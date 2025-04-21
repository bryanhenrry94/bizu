using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaConciliacionDetIngEgr
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipocbte { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoCbte { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodTipoCbteBan { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    public int IdPeriodo { get; set; }

    public int? IdBanco { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("cb_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CbObservacion { get; set; } = null!;

    [Column("cb_Cheque")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbCheque { get; set; }

    [Column("cb_FechaCheque")]
    public DateOnly? CbFechaCheque { get; set; }

    [Column("ba_descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaDescripcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    public int SecuenciaCbteCble { get; set; }

    [StringLength(73)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ReferenciaCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public int SecuenciaConciliacion { get; set; }

    [Column("tipo_IngEgr")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoIngEgr { get; set; } = null!;
}
