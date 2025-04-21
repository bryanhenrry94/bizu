using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpRetencion
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbte_CXP")]
    [Precision(18, 0)]
    public decimal? IdCbteCxp { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("Factura_Prov")]
    [StringLength(65)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? FacturaProv { get; set; }

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime? CoFechaFactura { get; set; }

    [Column("NumeroRT")]
    [StringLength(31)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumeroRt { get; set; }

    [Column("Fecha_RT")]
    public DateOnly FechaRt { get; set; }

    [Column("AutorizacionRT")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AutorizacionRt { get; set; }

    [Column("EstadoRT")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EstadoRt { get; set; } = null!;

    [Column("ImpresaRT")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ImpresaRt { get; set; } = null!;

    [Column("observacionRT")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObservacionRt { get; set; } = null!;

    [Column("re_Tiene_RTiva")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTieneRtiva { get; set; } = null!;

    [Column("re_Tiene_RFuente")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTieneRfuente { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("Nombre_Prov")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreProv { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("Total_Retencion")]
    public double? TotalRetencion { get; set; }

    [Column("serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("Fecha_Autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodDocumentoTipo { get; set; }
}
