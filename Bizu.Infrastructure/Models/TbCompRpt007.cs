using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbCOMP_Rpt007")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCompRpt007
{
    public int? IdEmpresa { get; set; }

    [Column("Nom_Empresa")]
    [StringLength(100)]
    public string? NomEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    [Column("Nom_Sucursal")]
    [StringLength(100)]
    public string? NomSucursal { get; set; }

    [Column("Fecha_Corte")]
    [MaxLength(6)]
    public DateTime? FechaCorte { get; set; }

    [Column("IdMes1_anio")]
    public int? IdMes1Anio { get; set; }

    [Column("IdMes2_anio")]
    public int? IdMes2Anio { get; set; }

    [Column("IdMes3_anio")]
    public int? IdMes3Anio { get; set; }

    [Column("IdMes4_anio")]
    public int? IdMes4Anio { get; set; }

    [Column("Nom_Mes1_anio")]
    [StringLength(20)]
    public string? NomMes1Anio { get; set; }

    [Column("Nom_Mes2_anio")]
    [StringLength(20)]
    public string? NomMes2Anio { get; set; }

    [Column("Nom_Mes3_anio")]
    [StringLength(20)]
    public string? NomMes3Anio { get; set; }

    [Column("Nom_Mes4_anio")]
    [StringLength(20)]
    public string? NomMes4Anio { get; set; }

    [Column("Cant_Mes1_anio")]
    public int? CantMes1Anio { get; set; }

    [Column("Cant_Mes2_anio")]
    public int? CantMes2Anio { get; set; }

    [Column("Cant_Mes3_anio")]
    public int? CantMes3Anio { get; set; }

    [Column("Cant_Mes4_anio")]
    public int? CantMes4Anio { get; set; }

    [Column("Prom_cant_x_comp")]
    public int? PromCantXComp { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("Cod_Producto")]
    [StringLength(100)]
    public string? CodProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(200)]
    public string? NomProducto { get; set; }

    [Column("stock_min")]
    public int? StockMin { get; set; }

    [Column("stock_a_la_fecha")]
    public int? StockALaFecha { get; set; }

    public int? Alerta { get; set; }

    [Column("varianza")]
    public double? Varianza { get; set; }
}
