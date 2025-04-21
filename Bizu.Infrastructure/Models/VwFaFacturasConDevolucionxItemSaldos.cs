using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaFacturasConDevolucionxItemSaldos
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("vt_cantidad")]
    public double VtCantidad { get; set; }

    [Column("dv_cantidad")]
    public double DvCantidad { get; set; }

    [Column("dv_saldo")]
    public double DvSaldo { get; set; }

    [Column("vt_PorDescUnitario")]
    public double VtPorDescUnitario { get; set; }

    [Column("vt_DescUnitario")]
    public double VtDescUnitario { get; set; }

    [Column("vt_iva")]
    public double VtIva { get; set; }

    [Column("vt_PrecioFinal")]
    public double VtPrecioFinal { get; set; }

    [Column("vt_Precio")]
    public double VtPrecio { get; set; }

    public int Expr1 { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("dv_seguro")]
    public double? DvSeguro { get; set; }

    [Column("dv_flete")]
    public double? DvFlete { get; set; }

    [Column("dv_interes")]
    public double? DvInteres { get; set; }

    [Column("dv_OtroValor1")]
    public double? DvOtroValor1 { get; set; }

    [Column("dv_OtroValor2")]
    public double? DvOtroValor2 { get; set; }
}
