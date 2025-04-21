using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaVentaTelefonicaDet
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("IdVenta_tel")]
    [Precision(18, 0)]
    public decimal IdVentaTel { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    public double Cantidad { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("Viene_Base")]
    [StringLength(1)]
    public string VieneBase { get; set; } = null!;
}
