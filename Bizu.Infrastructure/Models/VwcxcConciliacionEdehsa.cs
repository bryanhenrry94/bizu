using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcConciliacionEdehsa
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public DateOnly Fecha { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime FechaTransaccion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [Column("nom_pc")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPc { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Ip { get; set; } = null!;

    [Column("IdEmpresa_cbte_cble")]
    public int? IdEmpresaCbteCble { get; set; }

    [Column("IdTipoCbte_cbte_cble")]
    public int? IdTipoCbteCbteCble { get; set; }

    [Column("IdCbteCble_cbte_cble")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCbteCble { get; set; }

    [Column("Valor_Aplicado")]
    public double? ValorAplicado { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }
}
