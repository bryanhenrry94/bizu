using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("MiIdEmpresa", "MiIdSucursal", "MiIdBodega", "MiIdMoviInvenTipo", "MiIdNumMovi", "MiSecuencia", "OcdIdEmpresa", "OcdIdSucursal", "OcdIdOrdenCompra", "OcdSecuencia")]
[Table("in_movi_inve_detalle_x_com_ordencompra_local_det")]
[Index("OcdIdEmpresa", "OcdIdSucursal", "OcdIdOrdenCompra", "OcdSecuencia", Name = "FK_in_movi_inve_detalle_x_com_ordencompra_local_det_com_ordenc18")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInveDetalleXComOrdencompraLocalDet
{
    [Key]
    [Column("mi_IdEmpresa")]
    public int MiIdEmpresa { get; set; }

    [Key]
    [Column("mi_IdSucursal")]
    public int MiIdSucursal { get; set; }

    [Key]
    [Column("mi_IdBodega")]
    public int MiIdBodega { get; set; }

    [Key]
    [Column("mi_IdMovi_inven_tipo")]
    public int MiIdMoviInvenTipo { get; set; }

    [Key]
    [Column("mi_IdNumMovi")]
    [Precision(18, 0)]
    public decimal MiIdNumMovi { get; set; }

    [Key]
    [Column("mi_Secuencia")]
    public int MiSecuencia { get; set; }

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

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("OcdIdEmpresa, OcdIdSucursal, OcdIdOrdenCompra, OcdSecuencia")]
    [InverseProperty("InMoviInveDetalleXComOrdencompraLocalDet")]
    public virtual ComOrdencompraLocalDet ComOrdencompraLocalDet { get; set; } = null!;

    [ForeignKey("MiIdEmpresa, MiIdSucursal, MiIdBodega, MiIdMoviInvenTipo, MiIdNumMovi, MiSecuencia")]
    [InverseProperty("InMoviInveDetalleXComOrdencompraLocalDet")]
    public virtual InMoviInveDetalle InMoviInveDetalle { get; set; } = null!;
}
