using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVta")]
[Table("fa_factura_Edehsa")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_fa_factura_ct_centro_costo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaEdehsa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdOferta { get; set; }

    [Precision(18, 0)]
    public decimal? IdPlanilla { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }

    [StringLength(25)]
    public string? UsuarioCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(25)]
    public string? UsuarioModificacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaModificacion { get; set; }

    [StringLength(25)]
    public string? UsuarioAnulacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(150)]
    public string? MotivoAnulacion { get; set; }

    [Column("vt_referencia")]
    [StringLength(500)]
    public string? VtReferencia { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("FaFacturaEdehsa")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdCbteVta")]
    [InverseProperty("FaFacturaEdehsa")]
    public virtual FaFactura FaFactura { get; set; } = null!;
}
