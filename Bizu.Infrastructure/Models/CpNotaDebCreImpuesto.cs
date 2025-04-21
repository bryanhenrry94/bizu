using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCbleNota", "IdTipoCbteNota", "Codigo", "CodigoPorcentaje")]
[Table("cp_nota_DebCre_Impuesto")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class CpNotaDebCreImpuesto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal IdCbteCbleNota { get; set; }

    [Key]
    [Column("IdTipoCbte_Nota")]
    public int IdTipoCbteNota { get; set; }

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

    [ForeignKey("IdEmpresa, IdCbteCbleNota, IdTipoCbteNota")]
    [InverseProperty("CpNotaDebCreImpuesto")]
    public virtual CpNotaDebCre CpNotaDebCre { get; set; } = null!;
}
