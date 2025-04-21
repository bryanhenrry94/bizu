using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcRpt002
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

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

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_telefonoCasa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeTelefonoCasa { get; set; }

    [Column("pe_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeDireccion { get; set; } = null!;
}
