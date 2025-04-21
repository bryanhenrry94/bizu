using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto", "IdFecha", "Secuencia")]
[Table("in_producto_x_tb_bodega_Costo_Historico")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoXTbBodegaCostoHistorico
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

    [Key]
    public int IdFecha { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("fecha")]
    public DateOnly Fecha { get; set; }

    [Column("costo")]
    public double Costo { get; set; }

    [Column("Stock_a_la_fecha")]
    public double StockALaFecha { get; set; }

    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [Column("fecha_trans")]
    [MaxLength(6)]
    public DateTime? FechaTrans { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdProducto")]
    [InverseProperty("InProductoXTbBodegaCostoHistorico")]
    public virtual InProductoXTbBodega InProductoXTbBodega { get; set; } = null!;
}
