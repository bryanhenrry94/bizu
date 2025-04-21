using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpConciliacionCajaDetXValeCaja
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public int IdCaja { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCierre { get; set; } = null!;

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("IdEmpresa_op")]
    public int? IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_op")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    public int Secuencia { get; set; }

    [Column("IdEmpresa_movcaja")]
    public int IdEmpresaMovcaja { get; set; }

    [Column("IdCbteCble_movcaja")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMovcaja { get; set; }

    [Column("IdTipocbte_movcaja")]
    public int IdTipocbteMovcaja { get; set; }

    [Column("cm_Signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmSigno { get; set; } = null!;

    [Column("cm_beneficiario")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmBeneficiario { get; set; } = null!;

    public int IdTipoMovi { get; set; }

    [Column("cm_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("IdUsuario_Aprueba")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [Column("Secuencia_DetcajMovi")]
    public int SecuenciaDetcajMovi { get; set; }

    [Column("cr_Valor")]
    public double CrValor { get; set; }

    [Column("nom_TipoMovi")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoMovi { get; set; } = null!;

    [Column("nom_Caja")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCaja { get; set; } = null!;

    [Column("nom_EstadoCierre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoCierre { get; set; } = null!;

    [Column("IdCtaCble_ValeCaja")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCbleValeCaja { get; set; } = null!;

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [StringLength(47)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdBeneficiario { get; set; } = null!;
}
