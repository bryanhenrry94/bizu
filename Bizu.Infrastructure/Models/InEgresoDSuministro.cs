using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursa", "IdBodega", "IdEgresoSumin")]
[Table("in_egreso_d_Suministro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InEgresoDSuministro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursa { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdEgresoSumin { get; set; }

    [Precision(18, 0)]
    public decimal IdGasto { get; set; }

    [Precision(18, 0)]
    public decimal IdCentroDeCosto { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    public double? Cantidad { get; set; }

    public double? Precio { get; set; }

    public double? Subtotal { get; set; }

    [Column("observacion")]
    [StringLength(200)]
    public string? Observacion { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transa")]
    [MaxLength(6)]
    public DateTime? FechaTransa { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltModi { get; set; }

    [StringLength(20)]
    public string? IdUsuarioAnula { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnula { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }
}
