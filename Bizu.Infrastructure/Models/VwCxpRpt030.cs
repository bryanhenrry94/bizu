using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt030
{
    public int IdEmpresa { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [StringLength(61)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaEmision { get; set; }

    [MaxLength(6)]
    public DateTime FechaRegistro { get; set; }

    [Column("co_Por_iva")]
    public double CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_vaCoa")]
    [StringLength(32)]
    public string CoVaCoa { get; set; } = null!;

    [Column("IdIden_credito")]
    public int? IdIdenCredito { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Codigo { get; set; } = null!;

    [Column("codigoSRI")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodigoSri { get; set; } = null!;

    [Column("co_descripcion")]
    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoDescripcion { get; set; } = null!;

    [StringLength(18)]
    public string TipoServicio { get; set; } = null!;

    [Column("co_FechaContabilizacion")]
    [MaxLength(6)]
    public DateTime? CoFechaContabilizacion { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;
}
