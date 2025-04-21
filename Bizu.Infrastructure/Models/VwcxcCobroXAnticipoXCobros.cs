using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobroXAnticipoXCobros
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    public int Secuencia { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Column("IdEmpresa_Cobro")]
    public int? IdEmpresaCobro { get; set; }

    [Column("IdSucursal_cobro")]
    public int? IdSucursalCobro { get; set; }

    [Column("IdCobro_cobro")]
    [Precision(18, 0)]
    public decimal? IdCobroCobro { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime CrFechaDocu { get; set; }

    [Column("cr_fechaCobro")]
    [MaxLength(6)]
    public DateTime CrFechaCobro { get; set; }

    [Column("cr_observacion")]
    [StringLength(700)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CrObservacion { get; set; } = null!;

    [Column("cr_Banco")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrBanco { get; set; }

    [Column("cr_cuenta")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrCuenta { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrNumDocumento { get; set; }

    [Column("cr_Tarjeta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrTarjeta { get; set; }

    [Column("cr_propietarioCta")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrPropietarioCta { get; set; }

    [Column("mcj_IdEmpresa")]
    public int? McjIdEmpresa { get; set; }

    [Column("mcj_IdCbteCble")]
    [Precision(18, 0)]
    public decimal? McjIdCbteCble { get; set; }

    [Column("mcj_IdTipocbte")]
    public int? McjIdTipocbte { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    public int? IdBanco { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }
}
