using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcAnticiposXCruzar
{
    [Column("IdEmpresa_Cobro")]
    public int? IdEmpresaCobro { get; set; }

    [Column("IdSucursal_cobro")]
    public int? IdSucursalCobro { get; set; }

    [Column("IdCobro_cobro")]
    [Precision(18, 0)]
    public decimal? IdCobroCobro { get; set; }

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Column("cr_Banco")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrBanco { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrNumDocumento { get; set; }

    public int IdCaja { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("Saldo_Pendiente")]
    public double SaldoPendiente { get; set; }

    [Column("IdCtaCble_cxc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCxc { get; set; }

    [Column("IdCtaCble_Anti")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleAnti { get; set; }
}
