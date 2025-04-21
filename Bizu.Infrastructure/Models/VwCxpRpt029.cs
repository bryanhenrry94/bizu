using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt029
{
    public int IdEmpresa { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("pr_codigo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [StringLength(61)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Factura { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("co_Por_iva")]
    public double? CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double? CoValoriva { get; set; }

    [Column("co_subtotal_iva")]
    public double? CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double? CoSubtotalSiniva { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [Column("Base_Fuente")]
    public double? BaseFuente { get; set; }

    public double? Diferencia { get; set; }

    [Column("Tiene_retencion")]
    [StringLength(30)]
    public string TieneRetencion { get; set; } = null!;

    [Column("re_tipoRet")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ReTipoRet { get; set; }
}
