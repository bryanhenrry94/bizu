using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbINV_Rpt018")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbInvRpt018
{
    public int? IdEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal? Idproducto { get; set; }

    [Column("cod_producto")]
    [StringLength(50)]
    public string? CodProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(150)]
    public string? NomProducto { get; set; }

    [Column("nom_sucursal")]
    [StringLength(350)]
    public string? NomSucursal { get; set; }

    [Column("nom_bodega")]
    [StringLength(150)]
    public string? NomBodega { get; set; }

    [Column("egresos")]
    public double? Egresos { get; set; }

    [Column("stock_fecha_desde")]
    public double? StockFechaDesde { get; set; }

    [Column("stock_fecha_hasta")]
    public double? StockFechaHasta { get; set; }

    [Column("promedio")]
    public double? Promedio { get; set; }

    [Column("indice")]
    public double? Indice { get; set; }

    [Column("stock_minimo")]
    public double? StockMinimo { get; set; }

    [Column("stock_hoy")]
    public double? StockHoy { get; set; }

    [Column("cant_a_comprar")]
    public double? CantAComprar { get; set; }
}
