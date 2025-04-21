using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdNumMovi", "IdTipoCbte", "IdCbteCble", "IdEmpresaCt")]
[Table("in_movi_inve_x_ct_cbteCble")]
[Index("IdEmpresaCt", "IdTipoCbte", "IdCbteCble", Name = "FK_in_movi_inve_x_ct_cbteCble_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInveXCtCbteCble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [Key]
    [Column("IdEmpresa_ct")]
    public int IdEmpresaCt { get; set; }

    [ForeignKey("IdEmpresaCt, IdTipoCbte, IdCbteCble")]
    [InverseProperty("InMoviInveXCtCbteCble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdMoviInvenTipo, IdNumMovi")]
    [InverseProperty("InMoviInveXCtCbteCble")]
    public virtual InMoviInve InMoviInve { get; set; } = null!;

    [InverseProperty("InMoviInveXCtCbteCble")]
    public virtual ICollection<InMoviInveDetalleXCtCbtecbleDet> InMoviInveDetalleXCtCbtecbleDet { get; set; } = new List<InMoviInveDetalleXCtCbtecbleDet>();
}
