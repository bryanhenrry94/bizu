using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdAnticipo", "Secuencia")]
[Table("cxc_anticipo_facturado_det")]
[Index("IdEmpresaCt", "IdTipoCbteCt", "IdCbteCbleCt", Name = "FK_cxc_anticipo_facturado_det_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcAnticipoFacturadoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [StringLength(150)]
    public string? Detalle { get; set; }

    public DateOnly Fecha { get; set; }

    public double Valor { get; set; }

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    [Column("IdTipoCbte_ct")]
    public int? IdTipoCbteCt { get; set; }

    [Column("IdCbteCble_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCt { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [ForeignKey("IdEmpresaCt, IdTipoCbteCt, IdCbteCbleCt")]
    [InverseProperty("CxcAnticipoFacturadoDet")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdAnticipo")]
    [InverseProperty("CxcAnticipoFacturadoDet")]
    public virtual CxcAnticipoFacturado CxcAnticipoFacturado { get; set; } = null!;
}
