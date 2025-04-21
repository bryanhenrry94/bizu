using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("RtIdEmpresa", "RtIdRetencion", "CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble")]
[Table("cp_retencion_x_ct_cbtecble")]
[Index("CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble", Name = "FK_cp_retencion_x_ct_cbtecble_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpRetencionXCtCbtecble
{
    [Key]
    [Column("rt_IdEmpresa")]
    public int RtIdEmpresa { get; set; }

    [Key]
    [Column("rt_IdRetencion")]
    [Precision(18, 0)]
    public decimal RtIdRetencion { get; set; }

    [Key]
    [Column("ct_IdEmpresa")]
    public int CtIdEmpresa { get; set; }

    [Key]
    [Column("ct_IdTipoCbte")]
    public int CtIdTipoCbte { get; set; }

    [Key]
    [Column("ct_IdCbteCble")]
    [Precision(18, 0)]
    public decimal CtIdCbteCble { get; set; }

    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("RtIdEmpresa, RtIdRetencion")]
    [InverseProperty("CpRetencionXCtCbtecble")]
    public virtual CpRetencion CpRetencion { get; set; } = null!;

    [ForeignKey("CtIdEmpresa, CtIdTipoCbte, CtIdCbteCble")]
    [InverseProperty("CpRetencionXCtCbtecble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;
}
