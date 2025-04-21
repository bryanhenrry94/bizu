using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinProductoXTbBodegaCostoHistorico
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("cod_sucursal")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodSucursal { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    public int IdBodega { get; set; }

    [Column("cod_bodega")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodBodega { get; set; }

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    public int IdFecha { get; set; }

    public int Secuencia { get; set; }

    [Column("fecha")]
    public DateOnly Fecha { get; set; }

    [Column("costo")]
    public double Costo { get; set; }

    [Column("Stock_a_la_fecha")]
    public double StockALaFecha { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("fecha_trans")]
    [MaxLength(6)]
    public DateTime? FechaTrans { get; set; }
}
