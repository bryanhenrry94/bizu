using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCancelacionIntercompany
{
    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCancelacion { get; set; }

    [Column("IdBanco_Deposito")]
    public int? IdBancoDeposito { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PapeletaDeposito { get; set; }

    [Column("cbteban_IdEmpresa")]
    public int? CbtebanIdEmpresa { get; set; }

    [Column("cbteban_IdCbteCble")]
    [Precision(18, 0)]
    public decimal? CbtebanIdCbteCble { get; set; }

    [Column("cbteban_IdTipocbte")]
    public int? CbtebanIdTipocbte { get; set; }

    [Column("cr_TotalCobro")]
    public double? CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    public DateOnly? CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    public DateOnly? CrFechaDocu { get; set; }

    [Column("cr_observacion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrObservacion { get; set; }

    [Column("cr_fechaCobro")]
    public DateOnly? CrFechaCobro { get; set; }

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

    [Column("cr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrEstado { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string GeneraDeps { get; set; } = null!;

    [Column("tc_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int IdCaja { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoNotaCredito { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    public int IdEmpresa { get; set; }
}
