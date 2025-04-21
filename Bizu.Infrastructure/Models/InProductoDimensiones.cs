using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProducto")]
[Table("in_Producto_Dimensiones")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoDimensiones
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("longitud")]
    public double Longitud { get; set; }

    [Column("espesor")]
    public double Espesor { get; set; }

    [Column("ancho")]
    public double Ancho { get; set; }

    [Column("alto")]
    public double Alto { get; set; }

    [Column("ceja")]
    public double Ceja { get; set; }

    [Column("diametro")]
    public double Diametro { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }
}
