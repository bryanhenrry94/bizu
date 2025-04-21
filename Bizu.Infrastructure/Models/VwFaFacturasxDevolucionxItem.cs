using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaFacturasxDevolucionxItem
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dv_cantidad")]
    public double? DvCantidad { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("dv_OtroValor2")]
    public double DvOtroValor2 { get; set; }

    [Column("dv_OtroValor1")]
    public double DvOtroValor1 { get; set; }

    [Column("dv_interes")]
    public double DvInteres { get; set; }

    [Column("dv_flete")]
    public double DvFlete { get; set; }

    [Column("dv_seguro")]
    public double DvSeguro { get; set; }
}
