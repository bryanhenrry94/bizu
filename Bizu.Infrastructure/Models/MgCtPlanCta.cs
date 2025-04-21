using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("MG_ct_PlanCta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class MgCtPlanCta
{
    [Key]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(255)]
    public string? PcCuenta { get; set; }

    [StringLength(255)]
    public string? IdCtaCblePadre { get; set; }

    public double? IdNivelCta { get; set; }

    [Column("pc_EsMovimiento")]
    [StringLength(255)]
    public string? PcEsMovimiento { get; set; }

    [StringLength(255)]
    public string? IdGrupoCble { get; set; }

    [Column("pc_Naturaleza")]
    [StringLength(255)]
    public string? PcNaturaleza { get; set; }

    [Column("pc_Estado")]
    [StringLength(255)]
    public string? PcEstado { get; set; }
}
