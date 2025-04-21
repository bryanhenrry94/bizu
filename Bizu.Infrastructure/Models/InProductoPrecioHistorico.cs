using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdProducto", "IdUsuario", "Secuencia")]
[Table("in_producto_precio_historico")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoPrecioHistorico
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdProducto { get; set; }

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int Secuencia { get; set; }

    public DateOnly Fecha { get; set; }

    [MaxLength(6)]
    public DateTime FechaTrans { get; set; }

    [Column("pr_precio_publico")]
    public double? PrPrecioPublico { get; set; }

    [Column("pr_precio_mayor")]
    public double? PrPrecioMayor { get; set; }

    [Column("pr_precio_minimo")]
    public double? PrPrecioMinimo { get; set; }
}
