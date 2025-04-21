using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaOgiro", "IdCbteCbleOgiro", "IdTipoCbteOgiro", "IdEmpresaOc", "IdSucursalOc", "IdOrdenCompra", "SecuenciaOc", "SecuenciaReg")]
[Table("cp_orden_giro_x_com_ordencompra_local_det")]
[Index("IdEmpresaOc", "IdSucursalOc", "IdOrdenCompra", "SecuenciaOc", Name = "FK_cp_orden_giro_x_com_ordencompra_local_det_com_ordencompra_l27")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenGiroXComOrdencompraLocalDet
{
    [Key]
    [Column("IdEmpresa_Ogiro")]
    public int IdEmpresaOgiro { get; set; }

    [Key]
    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Key]
    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Key]
    [Column("IdEmpresa_OC")]
    public int IdEmpresaOc { get; set; }

    [Key]
    [Column("IdSucursal_OC")]
    public int IdSucursalOc { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Key]
    [Column("Secuencia_OC")]
    public int SecuenciaOc { get; set; }

    [Key]
    [Column("Secuencia_reg")]
    public int SecuenciaReg { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresaOc, IdSucursalOc, IdOrdenCompra, SecuenciaOc")]
    [InverseProperty("CpOrdenGiroXComOrdencompraLocalDet")]
    public virtual ComOrdencompraLocalDet ComOrdencompraLocalDet { get; set; } = null!;

    [ForeignKey("IdEmpresaOgiro, IdCbteCbleOgiro, IdTipoCbteOgiro")]
    [InverseProperty("CpOrdenGiroXComOrdencompraLocalDet")]
    public virtual CpOrdenGiro CpOrdenGiro { get; set; } = null!;
}
