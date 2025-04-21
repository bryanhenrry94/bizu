using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobrosPendientesXConciliarEdehsa
{
    public int? IdEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Tipo { get; set; }

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Precision(18, 0)]
    public decimal? IdNota { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CreDeb { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Column("NumNota_Impresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumNotaImpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("Nom_Bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBodega { get; set; }

    [Column("no_fecha")]
    [MaxLength(6)]
    public DateTime? NoFecha { get; set; }

    [Column("no_fecha_venc")]
    [MaxLength(6)]
    public DateTime? NoFechaVenc { get; set; }

    [Column("sc_observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ScObservacion { get; set; }

    [Column("Nom_Cliente")]
    [StringLength(201)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCliente { get; set; } = null!;

    [Column("Motivo_Nota")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoNota { get; set; }

    [StringLength(220)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    [Column("sc_total")]
    public double? ScTotal { get; set; }

    public double? Saldo { get; set; }

    [StringLength(8)]
    public string IdTipoConciliacion { get; set; } = null!;

    [Column("IdCobro_Tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCobroTipo { get; set; }

    public int? IdTipoNota { get; set; }

    public int IdCaja { get; set; }

    [Column("IdCtaCble_cxc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCxc { get; set; }

    [Column("IdCtaCble_Anti")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleAnti { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }
}
