using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt007
{
    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("Tipo_cbte_cxp")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoCbteCxp { get; set; } = null!;

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdEmpresa_pago")]
    public int IdEmpresaPago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int IdTipoCbtePago { get; set; }

    [Column("Tipo_cbte_pago")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoCbtePago { get; set; } = null!;

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal IdCbteCblePago { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoObservacion { get; set; }

    [Column("cb_Fecha")]
    public DateOnly CbFecha { get; set; }

    [Precision(18, 0)]
    public decimal IdTipoFlujo { get; set; }

    [Column("nom_tipo_flujo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoFlujo { get; set; } = null!;

    [Column("cod_flujo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodFlujo { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Tipo { get; set; }

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    public int IdBanco { get; set; }

    [Column("nom_banco")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBanco { get; set; } = null!;

    [Column("Tipo_movi")]
    [StringLength(8)]
    public string TipoMovi { get; set; } = null!;

    [Column("orden")]
    public long Orden { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeNombreCompleto { get; set; }

    [Column("en_conci")]
    public long EnConci { get; set; }
}
