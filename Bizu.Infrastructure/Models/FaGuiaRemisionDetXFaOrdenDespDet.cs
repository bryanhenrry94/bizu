using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("GiIdEmpresa", "GiIdSucursal", "GiIdBodega", "GiIdGuiaRemision", "GiSecuencia", "GiIdProducto", "OdIdEmpresa", "OdIdSucursal", "OdIdBodega", "OdIdOrdenDespacho", "OdSecuencia", "OdIdProducto")]
[Table("fa_guia_remision_det_x_fa_orden_Desp_det")]
[Index("OdIdEmpresa", "OdIdSucursal", "OdIdBodega", "OdIdOrdenDespacho", "OdSecuencia", Name = "FK_fa_guia_remision_det_x_fa_orden_Desp_det_fa_orden_Desp_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaGuiaRemisionDetXFaOrdenDespDet
{
    [Key]
    [Column("gi_IdEmpresa")]
    public int GiIdEmpresa { get; set; }

    [Key]
    [Column("gi_IdSucursal")]
    public int GiIdSucursal { get; set; }

    [Key]
    [Column("gi_IdBodega")]
    public int GiIdBodega { get; set; }

    [Key]
    [Column("gi_IdGuiaRemision")]
    [Precision(18, 0)]
    public decimal GiIdGuiaRemision { get; set; }

    [Key]
    [Column("gi_Secuencia")]
    public int GiSecuencia { get; set; }

    [Key]
    [Column("gi_IdProducto")]
    [Precision(18, 0)]
    public decimal GiIdProducto { get; set; }

    [Column("gi_cantidad")]
    public double GiCantidad { get; set; }

    [Key]
    [Column("od_IdEmpresa")]
    public int OdIdEmpresa { get; set; }

    [Key]
    [Column("od_IdSucursal")]
    public int OdIdSucursal { get; set; }

    [Key]
    [Column("od_IdBodega")]
    public int OdIdBodega { get; set; }

    [Key]
    [Column("od_IdOrdenDespacho")]
    [Precision(18, 0)]
    public decimal OdIdOrdenDespacho { get; set; }

    [Key]
    [Column("od_Secuencia")]
    public int OdSecuencia { get; set; }

    [Key]
    [Column("od_IdProducto")]
    [Precision(18, 0)]
    public decimal OdIdProducto { get; set; }

    [ForeignKey("GiIdEmpresa, GiIdSucursal, GiIdBodega, GiIdGuiaRemision, GiSecuencia")]
    [InverseProperty("FaGuiaRemisionDetXFaOrdenDespDet")]
    public virtual FaGuiaRemisionDet FaGuiaRemisionDet { get; set; } = null!;

    [ForeignKey("OdIdEmpresa, OdIdSucursal, OdIdBodega, OdIdOrdenDespacho, OdSecuencia")]
    [InverseProperty("FaGuiaRemisionDetXFaOrdenDespDet")]
    public virtual FaOrdenDespDet FaOrdenDespDet { get; set; } = null!;
}
