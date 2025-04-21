using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacionCaja", "Secuencia")]
[Table("cp_conciliacion_Caja_det")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_cp_conciliacion_Caja_det_ct_centro_costo_sub_centro_costo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpConciliacionCajaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_OGiro")]
    public int IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    public int? IdTipoMovi { get; set; }

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("Valor_a_aplicar")]
    [Precision(18, 2)]
    public decimal ValorAAplicar { get; set; }

    [Column("Tipo_documento")]
    [StringLength(10)]
    public string? TipoDocumento { get; set; }

    [Column("IdEmpresa_OP")]
    public int? IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_OP")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [ForeignKey("IdEmpresa, IdConciliacionCaja")]
    [InverseProperty("CpConciliacionCajaDet")]
    public virtual CpConciliacionCaja CpConciliacionCaja { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CpConciliacionCajaDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("CpConciliacionCajaDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }
}
