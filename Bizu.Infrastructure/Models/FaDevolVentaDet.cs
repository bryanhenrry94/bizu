using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdDevolucion", "Secuencia")]
[Table("fa_devol_venta_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_fa_devol_venta_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaDevolVentaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdDevolucion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dv_cantidad")]
    public double DvCantidad { get; set; }

    [Column("dv_valor")]
    public double DvValor { get; set; }

    [Column("dv_PorDescUni")]
    public double? DvPorDescUni { get; set; }

    [Column("dv_descUni")]
    public double DvDescUni { get; set; }

    [Column("dv_PrecioFinal")]
    public double DvPrecioFinal { get; set; }

    [Column("dv_subtotal")]
    public double DvSubtotal { get; set; }

    [Column("dv_iva")]
    public double DvIva { get; set; }

    [Column("dv_total")]
    public double DvTotal { get; set; }

    [Column("dv_costo")]
    public double DvCosto { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdDevolucion")]
    [InverseProperty("FaDevolVentaDet")]
    public virtual FaDevolVenta FaDevolVenta { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("FaDevolVentaDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
