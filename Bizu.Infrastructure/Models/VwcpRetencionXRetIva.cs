using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpRetencionXRetIva
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    [Column("serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("NAutorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nautorizacion { get; set; }

    [Column("re_tipoRet_RIVA")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTipoRetRiva { get; set; } = null!;

    [Column("re_baseRetencion_RIVA")]
    public double? ReBaseRetencionRiva { get; set; }

    [Column("re_Porcen_retencion_RIVA")]
    public double? RePorcenRetencionRiva { get; set; }

    [Column("re_valor_retencion_RIVA")]
    public double? ReValorRetencionRiva { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }
}
