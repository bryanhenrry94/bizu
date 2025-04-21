using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProductoPadre", "IdProductoHijo")]
[Table("in_Producto_Composicion")]
[Index("IdEmpresa", "IdProductoHijo", Name = "FK_in_Producto_Composicion_in_Producto1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoComposicion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProductoPadre { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProductoHijo { get; set; }

    public double Cantidad { get; set; }

    [ForeignKey("IdEmpresa, IdProductoHijo")]
    [InverseProperty("InProductoComposicionInProducto")]
    public virtual InProducto InProducto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProductoPadre")]
    [InverseProperty("InProductoComposicionInProductoNavigation")]
    public virtual InProducto InProductoNavigation { get; set; } = null!;
}
