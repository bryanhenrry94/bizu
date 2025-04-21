using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("OdIdEmpresa", "OdIdSucursal", "OdIdBodega", "OdIdOrdenDespacho", "OdSecuencia", "PeIdEmpresa", "PeIdSucursal", "PeIdBodega", "PeIdPedido", "PeSecuencia")]
[Table("fa_orden_Desp_det_x_fa_pedido_det")]
[Index("PeIdEmpresa", "PeIdSucursal", "PeIdBodega", "PeIdPedido", "PeSecuencia", Name = "FK_fa_orden_Desp_det_x_fa_pedido_det_fa_pedido_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaOrdenDespDetXFaPedidoDet
{
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

    [Column("od_IdProducto")]
    [Precision(18, 0)]
    public decimal OdIdProducto { get; set; }

    [Column("od_cantidad")]
    public double OdCantidad { get; set; }

    [Key]
    [Column("pe_IdEmpresa")]
    public int PeIdEmpresa { get; set; }

    [Key]
    [Column("pe_IdSucursal")]
    public int PeIdSucursal { get; set; }

    [Key]
    [Column("pe_IdBodega")]
    public int PeIdBodega { get; set; }

    [Key]
    [Column("pe_IdPedido")]
    [Precision(18, 0)]
    public decimal PeIdPedido { get; set; }

    [Key]
    [Column("pe_Secuencia")]
    public int PeSecuencia { get; set; }

    [Column("pe_IdProducto")]
    [Precision(18, 0)]
    public decimal PeIdProducto { get; set; }

    [ForeignKey("OdIdEmpresa, OdIdSucursal, OdIdBodega, OdIdOrdenDespacho, OdSecuencia")]
    [InverseProperty("FaOrdenDespDetXFaPedidoDet")]
    public virtual FaOrdenDespDet FaOrdenDespDet { get; set; } = null!;

    [ForeignKey("PeIdEmpresa, PeIdSucursal, PeIdBodega, PeIdPedido, PeSecuencia")]
    [InverseProperty("FaOrdenDespDetXFaPedidoDet")]
    public virtual FaPedidoDet FaPedidoDet { get; set; } = null!;
}
