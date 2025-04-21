using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwContaEdehsaRpt004
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

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

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DcObservacion { get; set; }

    public double Debe { get; set; }

    public double Haber { get; set; }

    public int IdNivelCta { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdGrupoCble { get; set; } = null!;

    [Column("gc_estado_financiero")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string GcEstadoFinanciero { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;
}
