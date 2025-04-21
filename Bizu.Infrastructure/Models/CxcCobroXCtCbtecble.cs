using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("CbrIdEmpresa", "CbrIdSucursal", "CbrIdCobro", "CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble")]
[Table("cxc_cobro_x_ct_cbtecble")]
[Index("CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble", Name = "FK_cxc_cobro_x_ct_cbtecble_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroXCtCbtecble
{
    [Key]
    [Column("cbr_IdEmpresa")]
    public int CbrIdEmpresa { get; set; }

    [Key]
    [Column("cbr_IdSucursal")]
    public int CbrIdSucursal { get; set; }

    [Key]
    [Column("cbr_IdCobro")]
    [Precision(18, 0)]
    public decimal CbrIdCobro { get; set; }

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

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("CtIdEmpresa, CtIdTipoCbte, CtIdCbteCble")]
    [InverseProperty("CxcCobroXCtCbtecble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("CbrIdEmpresa, CbrIdSucursal, CbrIdCobro")]
    [InverseProperty("CxcCobroXCtCbtecble")]
    public virtual CxcCobro CxcCobro { get; set; } = null!;
}
