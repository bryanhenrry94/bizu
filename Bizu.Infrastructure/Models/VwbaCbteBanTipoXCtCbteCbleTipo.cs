using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaCbteBanTipoXCtCbteCbleTipo
{
    public int IdEmpresa { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoCbteBan { get; set; } = null!;

    [Column("nom_TipoCbteBan")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoCbteBan { get; set; } = null!;

    public int? IdTipoCbteCble { get; set; }

    [Column("IdTipoCbteCble_Anu")]
    public int? IdTipoCbteCbleAnu { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [Column("Tipo_DebCred")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoDebCred { get; set; }
}
