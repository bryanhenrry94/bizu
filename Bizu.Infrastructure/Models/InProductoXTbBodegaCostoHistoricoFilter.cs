using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("in_producto_x_tb_bodega_Costo_Historico_filter")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoXTbBodegaCostoHistoricoFilter
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    public DateOnly Fecha { get; set; }

    public double Costo { get; set; }

    public double Stock { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }
}
