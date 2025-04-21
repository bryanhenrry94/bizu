using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("McjIdEmpresa", "McjIdCbteCble", "McjIdTipocbte", "MbaIdEmpresa", "MbaIdCbteCble", "MbaIdTipocbte", "McjSecuencia")]
[Table("ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito")]
[Index("MbaIdEmpresa", "MbaIdCbteCble", "MbaIdTipocbte", Name = "FK_ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_ba_Cbte_Ban1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCajaMovimientoXCbteBanXDeposito
{
    [Key]
    [Column("mcj_IdEmpresa")]
    public int McjIdEmpresa { get; set; }

    [Key]
    [Column("mcj_IdCbteCble")]
    [Precision(18, 0)]
    public decimal McjIdCbteCble { get; set; }

    [Key]
    [Column("mcj_IdTipocbte")]
    public int McjIdTipocbte { get; set; }

    [Key]
    [Column("mba_IdEmpresa")]
    public int MbaIdEmpresa { get; set; }

    [Key]
    [Column("mba_IdCbteCble")]
    [Precision(18, 0)]
    public decimal MbaIdCbteCble { get; set; }

    [Key]
    [Column("mba_IdTipocbte")]
    public int MbaIdTipocbte { get; set; }

    [Key]
    [Column("mcj_Secuencia")]
    public int McjSecuencia { get; set; }

    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("MbaIdEmpresa, MbaIdCbteCble, MbaIdTipocbte")]
    [InverseProperty("BaCajaMovimientoXCbteBanXDeposito")]
    public virtual BaCbteBan BaCbteBan { get; set; } = null!;

    [ForeignKey("McjIdEmpresa, McjIdCbteCble, McjIdTipocbte")]
    [InverseProperty("BaCajaMovimientoXCbteBanXDeposito")]
    public virtual CajCajaMovimiento CajCajaMovimiento { get; set; } = null!;
}
