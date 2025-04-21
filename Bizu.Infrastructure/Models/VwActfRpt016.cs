using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt016
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodActivoFijo { get; set; } = null!;

    [Column("Af_Codigo_Barra")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfCodigoBarra { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    public int? IdDepartamento { get; set; }

    [Column("nom_departamento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomDepartamento { get; set; }

    [Precision(18, 0)]
    public decimal? IdEncargado { get; set; }

    [Column("nom_encargado")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomEncargado { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }

    [Column("num_factura")]
    [StringLength(0)]
    public string NumFactura { get; set; } = null!;
}
