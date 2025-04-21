using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCotizacion", "Secuencial")]
[Table("fa_cotizacion_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_fa_cotizacion_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaCotizacionDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCotizacion { get; set; }

    [Key]
    public int Secuencial { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dc_cantidad")]
    public double DcCantidad { get; set; }

    [Column("dc_precio")]
    public double DcPrecio { get; set; }

    [Column("dc_por_desUni")]
    public double DcPorDesUni { get; set; }

    [Column("dc_desUni")]
    public double DcDesUni { get; set; }

    [Column("dc_precioFinal")]
    public double DcPrecioFinal { get; set; }

    [Column("dc_subtotal")]
    public double DcSubtotal { get; set; }

    [Column("dc_iva")]
    public double DcIva { get; set; }

    [Column("dc_total")]
    public double DcTotal { get; set; }

    [Column("dc_pagaIva")]
    [StringLength(1)]
    public string DcPagaIva { get; set; } = null!;

    [Column("dc_detallexItems")]
    [StringLength(500)]
    public string DcDetallexItems { get; set; } = null!;

    [Column("dc_peso")]
    public double DcPeso { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdCotizacion")]
    [InverseProperty("FaCotizacionDet")]
    public virtual FaCotizacion FaCotizacion { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("FaCotizacionDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
