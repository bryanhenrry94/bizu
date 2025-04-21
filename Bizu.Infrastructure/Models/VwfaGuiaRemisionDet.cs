using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaGuiaRemisionDet
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("gi_cantidad")]
    public double GiCantidad { get; set; }

    [Column("gi_Precio")]
    public double GiPrecio { get; set; }

    [Column("gi_PorDescUnitario")]
    public double GiPorDescUnitario { get; set; }

    [Column("gi_DescUnitario")]
    public double GiDescUnitario { get; set; }

    [Column("gi_PrecioFinal")]
    public double GiPrecioFinal { get; set; }

    [Column("gi_Subtotal")]
    public double GiSubtotal { get; set; }

    [Column("gi_iva")]
    public double GiIva { get; set; }

    [Column("gi_total")]
    public double GiTotal { get; set; }

    [Column("gi_costo")]
    public double GiCosto { get; set; }

    [Column("gi_tieneIVA")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? GiTieneIva { get; set; }

    [Column("gi_detallexItems")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string GiDetallexItems { get; set; } = null!;

    [Column("gi_peso")]
    public double? GiPeso { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_descripcion_2")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrDescripcion2 { get; set; }
}
