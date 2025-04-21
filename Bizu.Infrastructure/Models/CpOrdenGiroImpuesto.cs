using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCbleOgiro", "IdTipoCbteOgiro", "Codigo", "CodigoPorcentaje")]
[Table("cp_orden_giro_Impuesto")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class CpOrdenGiroImpuesto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Key]
    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Key]
    [StringLength(5)]
    public string Codigo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    public string CodigoPorcentaje { get; set; } = null!;

    [Precision(18, 2)]
    public decimal BaseImponible { get; set; }

    [Precision(18, 2)]
    public decimal Tarifa { get; set; }

    [Precision(18, 2)]
    public decimal Valor { get; set; }

    [ForeignKey("IdEmpresa, IdCbteCbleOgiro, IdTipoCbteOgiro")]
    [InverseProperty("CpOrdenGiroImpuesto")]
    public virtual CpOrdenGiro CpOrdenGiro { get; set; } = null!;
}
