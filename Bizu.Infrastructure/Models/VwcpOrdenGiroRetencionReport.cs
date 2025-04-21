using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenGiroRetencionReport
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    public int Idsecuencia { get; set; }

    [Column("re_fecha")]
    public DateOnly ReFecha { get; set; }

    [StringLength(6)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SerieRetencion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("re_Tiene_RTiva")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTieneRtiva { get; set; } = null!;

    [Column("re_Tiene_RFuente")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTieneRfuente { get; set; } = null!;

    [Column("re_tipoRet")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTipoRet { get; set; } = null!;

    [Column("re_baseRetencion")]
    public double ReBaseRetencion { get; set; }

    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("re_Codigo_impuesto")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReCodigoImpuesto { get; set; } = null!;

    [Column("re_Porcen_retencion")]
    public double RePorcenRetencion { get; set; }

    [Column("re_valor_retencion")]
    public double ReValorRetencion { get; set; }

    [Column("re_EstaImpresa")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReEstaImpresa { get; set; } = null!;

    [Column("re_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReEstado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Column("nRetencionSRI")]
    [StringLength(403)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NRetencionSri { get; set; } = null!;

    [Column("FVigCoSRI")]
    [StringLength(23)]
    public string? FvigCoSri { get; set; }

    [Column("codigoSRI")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodigoSri { get; set; } = null!;

    [Column("NAutorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nautorizacion { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }
}
