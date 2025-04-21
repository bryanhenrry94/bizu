using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwContaRpt008
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [Column("Secuencia_op")]
    public int SecuenciaOp { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("secuencia_cxp")]
    public int SecuenciaCxp { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    [Column("pc_clave_corta")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcClaveCorta { get; set; }

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DcObservacion { get; set; } = null!;

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoCbte { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;
}
