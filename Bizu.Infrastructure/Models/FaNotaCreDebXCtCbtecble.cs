using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("NoIdEmpresa", "NoIdSucursal", "NoIdBodega", "NoIdNota", "CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble")]
[Table("fa_notaCreDeb_x_ct_cbtecble")]
[Index("CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble", Name = "FK_fa_notaCreDeb_x_ct_cbtecble_ct_cbtecble1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaNotaCreDebXCtCbtecble
{
    [Key]
    [Column("no_IdEmpresa")]
    public int NoIdEmpresa { get; set; }

    [Key]
    [Column("no_IdSucursal")]
    public int NoIdSucursal { get; set; }

    [Key]
    [Column("no_IdBodega")]
    public int NoIdBodega { get; set; }

    [Key]
    [Column("no_IdNota")]
    [Precision(18, 0)]
    public decimal NoIdNota { get; set; }

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
    [InverseProperty("FaNotaCreDebXCtCbtecble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("NoIdEmpresa, NoIdSucursal, NoIdBodega, NoIdNota")]
    [InverseProperty("FaNotaCreDebXCtCbtecble")]
    public virtual FaNotaCreDeb FaNotaCreDeb { get; set; } = null!;
}
