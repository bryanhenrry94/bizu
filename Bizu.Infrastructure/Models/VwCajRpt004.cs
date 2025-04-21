using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCajRpt004
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    public int IdCaja { get; set; }

    [Column("Fecha_ini")]
    [MaxLength(6)]
    public DateTime? FechaIni { get; set; }

    [Column("Fecha_fin")]
    [MaxLength(6)]
    public DateTime? FechaFin { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCierre { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_clave_corta")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcClaveCorta { get; set; }

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    public double Debe { get; set; }

    public double? Haber { get; set; }

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DcObservacion { get; set; }

    [Column("IdEmpresa_cbte")]
    public int? IdEmpresaCbte { get; set; }

    [Column("nom_tipo_cbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoCbte { get; set; }

    public int? IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    [Column("nom_caja")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCaja { get; set; } = null!;

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime? CbFecha { get; set; }
}
