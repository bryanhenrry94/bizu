using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt033
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    public int Secuencia { get; set; }

    [Column("IdEmpresa_movcaja")]
    public int IdEmpresaMovcaja { get; set; }

    [Column("IdCbteCble_movcaja")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMovcaja { get; set; }

    [Column("IdTipocbte_movcaja")]
    public int IdTipocbteMovcaja { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("cm_beneficiario")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmBeneficiario { get; set; } = null!;

    [Column("cm_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

    [Column("nom_persona")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPersona { get; set; }

    public int IdTipoMovi { get; set; }

    [Column("nom_TipoMovi")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoMovi { get; set; } = null!;

    [Column("cm_valor")]
    public double CmValor { get; set; }
}
