using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "CodTipoCbteBan")]
[Table("ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo")]
[Index("CodTipoCbteBan", Name = "FK_ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_ba_Cbte_Ban_tipo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBanTipoXCtCbteCbleTipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string CodTipoCbteBan { get; set; } = null!;

    public int IdTipoCbteCble { get; set; }

    [Column("IdTipoCbteCble_Anu")]
    public int IdTipoCbteCbleAnu { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [Column("Tipo_DebCred")]
    [StringLength(1)]
    public string? TipoDebCred { get; set; }

    [ForeignKey("CodTipoCbteBan")]
    [InverseProperty("BaCbteBanTipoXCtCbteCbleTipo")]
    public virtual BaCbteBanTipo CodTipoCbteBanNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("BaCbteBanTipoXCtCbteCbleTipo")]
    public virtual CtPlancta? CtPlancta { get; set; }
}
