using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("OgIdEmpresa", "OgIdCbteCble", "OgIdTipoCbte", "ComIdEmpresa", "ComIdSucursal", "ComIdOrdenCompraLocal")]
[Table("cp_orden_giro_x_com_ordencompra_local")]
[Index("ComIdEmpresa", "ComIdSucursal", "ComIdOrdenCompraLocal", Name = "FK_cp_orden_giro_x_com_ordencompra_local_com_ordencompra_local")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenGiroXComOrdencompraLocal
{
    [Key]
    [Column("og_IdEmpresa")]
    public int OgIdEmpresa { get; set; }

    [Key]
    [Column("og_IdCbteCble")]
    [Precision(18, 0)]
    public decimal OgIdCbteCble { get; set; }

    [Key]
    [Column("og_IdTipoCbte")]
    public int OgIdTipoCbte { get; set; }

    [Key]
    [Column("com_IdEmpresa")]
    public int ComIdEmpresa { get; set; }

    [Key]
    [Column("com_IdSucursal")]
    public int ComIdSucursal { get; set; }

    [Key]
    [Column("com_IdOrdenCompraLocal")]
    [Precision(18, 0)]
    public decimal ComIdOrdenCompraLocal { get; set; }

    [Column("og_Observacion")]
    [StringLength(500)]
    public string? OgObservacion { get; set; }

    [ForeignKey("ComIdEmpresa, ComIdSucursal, ComIdOrdenCompraLocal")]
    [InverseProperty("CpOrdenGiroXComOrdencompraLocal")]
    public virtual ComOrdencompraLocal ComOrdencompraLocal { get; set; } = null!;

    [ForeignKey("OgIdEmpresa, OgIdCbteCble, OgIdTipoCbte")]
    [InverseProperty("CpOrdenGiroXComOrdencompraLocal")]
    public virtual CpOrdenGiro CpOrdenGiro { get; set; } = null!;
}
