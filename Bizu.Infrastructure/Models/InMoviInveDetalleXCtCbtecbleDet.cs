using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaInv", "IdSucursalInv", "IdBodegaInv", "IdMoviInvenTipoInv", "IdNumMoviInv", "SecuenciaInv", "IdEmpresaCt", "IdTipoCbteCt", "IdCbteCbleCt", "SecuenciaCt", "SecuencialReg")]
[Table("in_movi_inve_detalle_x_ct_cbtecble_det")]
[Index("IdEmpresaInv", "IdSucursalInv", "IdBodegaInv", "IdMoviInvenTipoInv", "IdNumMoviInv", "IdTipoCbteCt", "IdCbteCbleCt", "IdEmpresaCt", Name = "FK_in_movi_inve_detalle_x_ct_cbtecble_det_in_movi_inve_x_ct_cb21")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInveDetalleXCtCbtecbleDet
{
    [Key]
    [Column("IdEmpresa_inv")]
    public int IdEmpresaInv { get; set; }

    [Key]
    [Column("IdSucursal_inv")]
    public int IdSucursalInv { get; set; }

    [Key]
    [Column("IdBodega_inv")]
    public int IdBodegaInv { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo_inv")]
    public int IdMoviInvenTipoInv { get; set; }

    [Key]
    [Column("IdNumMovi_inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviInv { get; set; }

    [Key]
    [Column("Secuencia_inv")]
    public int SecuenciaInv { get; set; }

    [Key]
    [Column("IdEmpresa_ct")]
    public int IdEmpresaCt { get; set; }

    [Key]
    [Column("IdTipoCbte_ct")]
    public int IdTipoCbteCt { get; set; }

    [Key]
    [Column("IdCbteCble_ct")]
    [Precision(18, 0)]
    public decimal IdCbteCbleCt { get; set; }

    [Key]
    [Column("secuencia_ct")]
    public int SecuenciaCt { get; set; }

    [Key]
    [Column("Secuencial_reg")]
    [Precision(18, 0)]
    public decimal SecuencialReg { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresaInv, IdSucursalInv, IdBodegaInv, IdMoviInvenTipoInv, IdNumMoviInv, IdTipoCbteCt, IdCbteCbleCt, IdEmpresaCt")]
    [InverseProperty("InMoviInveDetalleXCtCbtecbleDet")]
    public virtual InMoviInveXCtCbteCble InMoviInveXCtCbteCble { get; set; } = null!;
}
