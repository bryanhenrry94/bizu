using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCajRpt007
{
    public int IdEmpresa { get; set; }

    public int IdCaja { get; set; }

    public int IdCustodio { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCustodio { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PeriodoDesde { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodoHasta { get; set; }

    [Precision(10, 2)]
    public decimal? FondoAsignado { get; set; }

    [Precision(10, 2)]
    public decimal? TotalCompra { get; set; }

    [Precision(10, 2)]
    public decimal? SaldoCompra { get; set; }

    [Precision(10, 2)]
    public decimal? TotalAprobado { get; set; }

    [Column("Total_a_Pagar")]
    [Precision(10, 2)]
    public decimal? TotalAPagar { get; set; }

    [Column("Saldo_a_Pagar")]
    [Precision(10, 2)]
    public decimal? SaldoAPagar { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? EstadoAprob { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? Observacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? IdUsuarioRevision { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltRevision { get; set; }

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    [Column("IdTipoCbte_ct")]
    public int? IdTipoCbteCt { get; set; }

    [Column("IdCbteCble_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCt { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? Estado { get; set; }

    public int IdSecuencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    public int? IdRubro { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodigoRubro { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreRubro { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? IdCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? IdTipoDocumento { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? NumeroDocumento { get; set; }

    [Precision(10, 2)]
    public decimal? Subtotal { get; set; }

    [Column("IdCod_Impuesto")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? IdCodImpuesto { get; set; }

    [Precision(10, 2)]
    public decimal? Iva { get; set; }

    [Precision(10, 2)]
    public decimal? Total { get; set; }

    [Precision(10, 2)]
    public decimal? Aprobado { get; set; }

    public bool? Check { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? IdCtaCble { get; set; }
}
