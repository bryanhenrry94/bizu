using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt039
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoSerie { get; set; } = null!;

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoFactura { get; set; } = null!;

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_subtotal")]
    public double CoSubtotal { get; set; }

    [Column("co_Por_iva")]
    public double CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("fac_estado")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string FacEstado { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime? OcFecha { get; set; }

    [Column("oc_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? OcEstado { get; set; }

    [Column("oc_subtot")]
    public double? OcSubtot { get; set; }

    [Column("oc_iva")]
    public double? OcIva { get; set; }

    [Column("oc_total")]
    public double? OcTotal { get; set; }
}
