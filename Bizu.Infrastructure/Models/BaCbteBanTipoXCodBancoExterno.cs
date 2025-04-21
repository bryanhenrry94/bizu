using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("CodTipoCbteBan", "CodBanco")]
[Table("ba_Cbte_Ban_tipo_x_CodBancoExterno")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBanTipoXCodBancoExterno
{
    [Key]
    [StringLength(20)]
    public string CodTipoCbteBan { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string CodBanco { get; set; } = null!;

    [ForeignKey("CodTipoCbteBan")]
    [InverseProperty("BaCbteBanTipoXCodBancoExterno")]
    public virtual BaCbteBanTipo CodTipoCbteBanNavigation { get; set; } = null!;
}
