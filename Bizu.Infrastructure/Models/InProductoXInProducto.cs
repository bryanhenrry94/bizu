using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProducto", "IdProductoHijo")]
[Table("in_producto_x_in_producto")]
[Index("IdEmpresa", "IdProductoHijo", Name = "FK_in_producto_x_in_producto_in_Producto_hijo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoXInProducto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Key]
    [Column("IdProducto_hijo")]
    [Precision(18, 0)]
    public decimal IdProductoHijo { get; set; }

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InProductoXInProductoInProducto")]
    public virtual InProducto InProducto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProductoHijo")]
    [InverseProperty("InProductoXInProductoInProductoNavigation")]
    public virtual InProducto InProductoNavigation { get; set; } = null!;
}
