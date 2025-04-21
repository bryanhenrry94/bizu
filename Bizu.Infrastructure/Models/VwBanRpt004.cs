using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt004
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

    [Column("debe")]
    public double? Debe { get; set; }

    [Column("haber")]
    public double? Haber { get; set; }

    [Column("saldo")]
    public double Saldo { get; set; }

    public double Valor { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Cheque { get; set; }

    [Column("Chq_Girado_A")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ChqGiradoA { get; set; }

    [Column("IdPersona_Girado_a")]
    [Precision(18, 0)]
    public decimal? IdPersonaGiradoA { get; set; }

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

    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreMes { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCortoFecha { get; set; } = null!;

    public int? IdMes { get; set; }

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcCuenta { get; set; }

    public double MontoAplicado { get; set; }

    [Column("IdOrdenPago_op")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [Column("Secuencia_op")]
    public int? SecuenciaOp { get; set; }

    [Column(TypeName = "mediumtext")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    [Column("Fecha_Venc_Fac_Prov")]
    [MaxLength(6)]
    public DateTime? FechaVencFacProv { get; set; }

    [Column("Observacion_FP")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ObservacionFp { get; set; }

    [StringLength(9)]
    public string TipoRegistro { get; set; } = null!;

    public long IdReg { get; set; }
}
