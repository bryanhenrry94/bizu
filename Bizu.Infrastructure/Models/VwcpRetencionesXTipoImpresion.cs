using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpRetencionesXTipoImpresion
{
    public int IdEmpresa { get; set; }

    [StringLength(4)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Sucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(354)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Proveedor { get; set; }

    [Column("NumCbteCXP")]
    [Precision(18, 0)]
    public decimal NumCbteCxp { get; set; }

    [StringLength(67)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocumento { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime CoFechaFacturaVct { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Referencia { get; set; } = null!;

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    [Column("NAutorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nautorizacion { get; set; }

    [Column("FechaRT")]
    public DateOnly FechaRt { get; set; }

    [Column("sImpresion")]
    [StringLength(10)]
    public string? SImpresion { get; set; }

    [StringLength(17)]
    public string? TipoImpresion { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    [Column("serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }
}
