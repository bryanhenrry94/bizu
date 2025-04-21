using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ba_Cbte_Ban_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBanTipo
{
    [Key]
    [StringLength(20)]
    public string CodTipoCbteBan { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Signo { get; set; } = null!;

    [Column("orden")]
    public int Orden { get; set; }

    [InverseProperty("CodTipoCbteBanNavigation")]
    public virtual ICollection<BaCbteBanTipoXCodBancoExterno> BaCbteBanTipoXCodBancoExterno { get; set; } = new List<BaCbteBanTipoXCodBancoExterno>();

    [InverseProperty("CodTipoCbteBanNavigation")]
    public virtual ICollection<BaCbteBanTipoXCtCbteCbleTipo> BaCbteBanTipoXCtCbteCbleTipo { get; set; } = new List<BaCbteBanTipoXCtCbteCbleTipo>();
}
