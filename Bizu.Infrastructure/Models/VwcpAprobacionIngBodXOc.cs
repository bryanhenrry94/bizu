using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpAprobacionIngBodXOc
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

    [Column("Fecha_aprobacion")]
    [MaxLength(6)]
    public DateTime FechaAprobacion { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("num_auto_Proveedor")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumAutoProveedor { get; set; } = null!;

    [Column("num_documento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocumento { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Serie { get; set; } = null!;

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("num_auto_Imprenta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumAutoImprenta { get; set; } = null!;

    [Column("Fecha_Factura")]
    [MaxLength(6)]
    public DateTime FechaFactura { get; set; }

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    public double Descuento { get; set; }

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_Por_iva")]
    public double CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [Column("IdIden_credito")]
    public int IdIdenCredito { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Serie2 { get; set; } = null!;

    [Column("co_plazo")]
    public int CoPlazo { get; set; }

    [Column("co_FechaVctoAutorizacion")]
    [MaxLength(6)]
    public DateTime? CoFechaVctoAutorizacion { get; set; }
}
