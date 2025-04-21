using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaCb", "IdSucursalCb", "IdCobroCb", "SecuencialCb", "IdEmpresaCt", "IdTipoCbteCt", "IdCbteCbleCt", "SecuenciaCt", "SecuenciaReg")]
[Table("cxc_cobro_det_x_ct_cbtecble_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroDetXCtCbtecbleDet
{
    [Key]
    [Column("IdEmpresa_cb")]
    public int IdEmpresaCb { get; set; }

    [Key]
    [Column("IdSucursal_cb")]
    public int IdSucursalCb { get; set; }

    [Key]
    [Column("IdCobro_cb")]
    [Precision(18, 0)]
    public decimal IdCobroCb { get; set; }

    [Key]
    [Column("secuencial_cb")]
    public int SecuencialCb { get; set; }

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
    [Column("secuencia_reg")]
    public int SecuenciaReg { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }
}
