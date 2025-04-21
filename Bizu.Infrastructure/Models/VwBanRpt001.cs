using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt001
{
    public int IdEmpresa { get; set; }

    [Column("Tipo_Cbte")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoCbte { get; set; } = null!;

    [Column("Num_Cbte")]
    [Precision(18, 0)]
    public decimal NumCbte { get; set; }

    public int IdBanco { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Banco { get; set; } = null!;

    [Column("Fch_Cbte")]
    public DateOnly FchCbte { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    public double Valor { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Cheque { get; set; }

    [Column("Chq_Girado_A")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ChqGiradoA { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("Tipo_Flujo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoFlujo { get; set; }

    public int? IdTipoNota { get; set; }

    [Column("Tipo_Nota")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoNota { get; set; }

    [Column("Fch_PostFechado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? FchPostFechado { get; set; }

    [Column("Es_Chq_Impreso")]
    [StringLength(10)]
    public string EsChqImpreso { get; set; } = null!;

    [Column("Fch_Chq")]
    public DateOnly? FchChq { get; set; }

    [Column("Cta_Cble_Banco")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CtaCbleBanco { get; set; } = null!;

    public int IdCalendario { get; set; }

    public int? AnioFiscal { get; set; }

    [StringLength(8)]
    [MySqlCollation("utf8mb4_bin")]
    public string? NombreMes { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCortoFecha { get; set; } = null!;

    public int? IdMes { get; set; }

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcCuenta { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
