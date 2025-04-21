using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwContaRpt004
{
    public int IdEmpresa { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCblePadre { get; set; }

    [Column("pc_Naturaleza")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcNaturaleza { get; set; } = null!;

    public int IdNivelCta { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdGrupoCble { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoCtaCble { get; set; }

    [Column("pc_Estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcEstado { get; set; } = null!;

    [Column("pc_EsMovimiento")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcEsMovimiento { get; set; } = null!;

    [Column("pc_es_flujo_efectivo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcEsFlujoEfectivo { get; set; }

    [Column("pc_clave_corta")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcClaveCorta { get; set; }
}
