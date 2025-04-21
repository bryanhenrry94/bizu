using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbteOgiro", "IdCbteCbleOgiro", "Secuencia")]
[Table("cp_BaseImponible_x_CentroCosto_Edehsa")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpBaseImponibleXCentroCostoEdehsa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Key]
    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [StringLength(50)]
    public string? IdCentroCosto { get; set; }

    public double BaseImponible { get; set; }

    [Column("IdTipoCbte_ct")]
    public int? IdTipoCbteCt { get; set; }

    [Column("IdCbteCble_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCt { get; set; }

    [Column("Secuencia_ct")]
    public int? SecuenciaCt { get; set; }
}
