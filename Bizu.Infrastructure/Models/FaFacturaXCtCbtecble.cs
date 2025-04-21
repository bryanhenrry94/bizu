using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("VtIdEmpresa", "VtIdSucursal", "VtIdBodega", "VtIdCbteVta", "CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble")]
[Table("fa_factura_x_ct_cbtecble")]
[Index("CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble", Name = "FK_fa_factura_x_ct_cbtecble_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaXCtCbtecble
{
    [Key]
    [Column("vt_IdEmpresa")]
    public int VtIdEmpresa { get; set; }

    [Key]
    [Column("vt_IdSucursal")]
    public int VtIdSucursal { get; set; }

    [Key]
    [Column("vt_IdBodega")]
    public int VtIdBodega { get; set; }

    [Key]
    [Column("vt_IdCbteVta")]
    [Precision(18, 0)]
    public decimal VtIdCbteVta { get; set; }

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
    public string? Motivo { get; set; }

    [ForeignKey("CtIdEmpresa, CtIdTipoCbte, CtIdCbteCble")]
    [InverseProperty("FaFacturaXCtCbtecble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("VtIdEmpresa, VtIdSucursal, VtIdBodega, VtIdCbteVta")]
    [InverseProperty("FaFacturaXCtCbtecble")]
    public virtual FaFactura FaFactura { get; set; } = null!;
}
