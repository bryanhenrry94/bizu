using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte", "IdCbteCble", "IdEmpresaAnu", "IdTipoCbteAnu", "IdCbteCbleAnu")]
[Table("ct_cbtecble_Reversado")]
[Index("IdEmpresaAnu", "IdTipoCbteAnu", "IdCbteCbleAnu", Name = "FK_ct_cbtecble_Reversado_ct_cbtecble1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCbtecbleReversado
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    [Column("IdEmpresa_Anu")]
    public int IdEmpresaAnu { get; set; }

    [Key]
    [Column("IdTipoCbte_Anu")]
    public int IdTipoCbteAnu { get; set; }

    [Key]
    [Column("IdCbteCble_Anu")]
    [Precision(18, 0)]
    public decimal IdCbteCbleAnu { get; set; }

    [Column("ip")]
    [StringLength(1)]
    public string? Ip { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbte, IdCbteCble")]
    [InverseProperty("CtCbtecbleReversadoCtCbtecble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("IdEmpresaAnu, IdTipoCbteAnu, IdCbteCbleAnu")]
    [InverseProperty("CtCbtecbleReversadoCtCbtecbleNavigation")]
    public virtual CtCbtecble CtCbtecbleNavigation { get; set; } = null!;
}
