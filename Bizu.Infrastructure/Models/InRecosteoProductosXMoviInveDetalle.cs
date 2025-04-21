using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto")]
[Table("in_Recosteo_Productos_x_movi_inve_detalle")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InRecosteoProductosXMoviInveDetalle
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }
}
