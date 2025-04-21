using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("OcdIdEmpresa", "OcdIdSucursal", "OcdIdOrdenCompra", "OcdSecuencia", "ScdIdEmpresa", "ScdIdSucursal", "ScdIdSolicitudCompra", "ScdSecuencia")]
[Table("com_ordencompra_local_det_x_com_solicitud_compra_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComOrdencompraLocalDetXComSolicitudCompraDet
{
    [Key]
    [Column("ocd_IdEmpresa")]
    public int OcdIdEmpresa { get; set; }

    [Key]
    [Column("ocd_IdSucursal")]
    public int OcdIdSucursal { get; set; }

    [Key]
    [Column("ocd_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal OcdIdOrdenCompra { get; set; }

    [Key]
    [Column("ocd_Secuencia")]
    public int OcdSecuencia { get; set; }

    [Key]
    [Column("scd_IdEmpresa")]
    public int ScdIdEmpresa { get; set; }

    [Key]
    [Column("scd_IdSucursal")]
    public int ScdIdSucursal { get; set; }

    [Key]
    [Column("scd_IdSolicitudCompra")]
    [Precision(18, 0)]
    public decimal ScdIdSolicitudCompra { get; set; }

    [Key]
    [Column("scd_Secuencia")]
    public int ScdSecuencia { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("OcdIdEmpresa, OcdIdSucursal, OcdIdOrdenCompra, OcdSecuencia")]
    [InverseProperty("ComOrdencompraLocalDetXComSolicitudCompraDet")]
    public virtual ComOrdencompraLocalDet ComOrdencompraLocalDet { get; set; } = null!;
}
