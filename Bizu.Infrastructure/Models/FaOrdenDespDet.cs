using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdOrdenDespacho", "Secuencia")]
[Table("fa_orden_Desp_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_fa_orden_Desp_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaOrdenDespDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenDespacho { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("od_cantidad")]
    public double OdCantidad { get; set; }

    [Column("od_Precio")]
    public double OdPrecio { get; set; }

    [Column("od_PorDescUnitario")]
    public double OdPorDescUnitario { get; set; }

    [Column("od_DescUnitario")]
    public double OdDescUnitario { get; set; }

    [Column("od_PrecioFinal")]
    public double OdPrecioFinal { get; set; }

    [Column("od_Subtotal")]
    public double OdSubtotal { get; set; }

    [Column("od_iva")]
    public double OdIva { get; set; }

    [Column("od_total")]
    public double OdTotal { get; set; }

    [Column("od_costo")]
    public double OdCosto { get; set; }

    [Column("od_tieneIVA")]
    [StringLength(1)]
    public string OdTieneIva { get; set; } = null!;

    [Column("od_detallexItems")]
    [StringLength(250)]
    public string OdDetallexItems { get; set; } = null!;

    [Column("od_peso")]
    public double OdPeso { get; set; }

    [InverseProperty("FaOrdenDespDet")]
    public virtual ICollection<FaGuiaRemisionDetXFaOrdenDespDet> FaGuiaRemisionDetXFaOrdenDespDet { get; set; } = new List<FaGuiaRemisionDetXFaOrdenDespDet>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdOrdenDespacho")]
    [InverseProperty("FaOrdenDespDet")]
    public virtual FaOrdenDesp FaOrdenDesp { get; set; } = null!;

    [InverseProperty("FaOrdenDespDet")]
    public virtual ICollection<FaOrdenDespDetXFaPedidoDet> FaOrdenDespDetXFaPedidoDet { get; set; } = new List<FaOrdenDespDetXFaPedidoDet>();

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("FaOrdenDespDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
