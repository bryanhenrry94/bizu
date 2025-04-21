using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcajCajCajaMovimiento
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipocbte { get; set; }

    [Column("cm_Signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmSigno { get; set; } = null!;

    [Column("cm_beneficiario")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmBeneficiario { get; set; } = null!;

    [Column("cm_valor")]
    public double CmValor { get; set; }

    public int IdTipoMovi { get; set; }

    [Column("cm_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    public int IdCaja { get; set; }

    public int IdPeriodo { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("IdUsuario_Anu")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [Column("IdUsuario_Aprueba")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [Column("NTipoMov")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NtipoMov { get; set; } = null!;

    [Column("IdCbteCble_Anu")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnu { get; set; }

    [Column("IdTipocbte_Anu")]
    public int? IdTipocbteAnu { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodMoviCaja { get; set; } = null!;

    [Column("ca_Descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaDescripcion { get; set; } = null!;

    [StringLength(0)]
    public string ResponsableCaja { get; set; } = null!;

    public int? IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("nom_tipoFlujo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoFlujo { get; set; }

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [Column("nom_Beneficiario")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBeneficiario { get; set; }

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

    public int? IdPuntoVta { get; set; }

    [Precision(18, 0)]
    public decimal? IdRecibo { get; set; }
}
