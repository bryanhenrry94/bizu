using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("CbrIdEmpresa", "CbrIdSucursal", "CbrIdCobro", "McjIdEmpresa", "McjIdCbteCble", "McjIdTipocbte")]
[Table("cxc_cobro_x_caj_Caja_Movimiento")]
[Index("McjIdEmpresa", "McjIdCbteCble", "McjIdTipocbte", Name = "FK_cxc_cobro_x_caj_Caja_Movimiento_caj_Caja_Movimiento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroXCajCajaMovimiento
{
    [Key]
    [Column("cbr_IdEmpresa")]
    public int CbrIdEmpresa { get; set; }

    [Key]
    [Column("cbr_IdSucursal")]
    public int CbrIdSucursal { get; set; }

    [Key]
    [Column("cbr_IdCobro")]
    [Precision(18, 0)]
    public decimal CbrIdCobro { get; set; }

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

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("McjIdEmpresa, McjIdCbteCble, McjIdTipocbte")]
    [InverseProperty("CxcCobroXCajCajaMovimiento")]
    public virtual CajCajaMovimiento CajCajaMovimiento { get; set; } = null!;

    [ForeignKey("CbrIdEmpresa, CbrIdSucursal, CbrIdCobro")]
    [InverseProperty("CxcCobroXCajCajaMovimiento")]
    public virtual CxcCobro CxcCobro { get; set; } = null!;
}
