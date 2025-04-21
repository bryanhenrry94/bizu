using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "TipoDoc", "IdCbteVta", "IdUsuario", "IdProducto", "IdCliente")]
[Table("fa_costo_producto_vendido")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaCostoProductoVendido
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [StringLength(50)]
    public string TipoDoc { get; set; } = null!;

    [Key]
    public int IdCbteVta { get; set; }

    [Key]
    [StringLength(500)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Key]
    public int IdCliente { get; set; }

    [Column("vt_cantidad")]
    public double? VtCantidad { get; set; }

    [Column("vt_Precio")]
    public double? VtPrecio { get; set; }

    [Column("vt_Peso")]
    public double? VtPeso { get; set; }

    [Column("vt_peso_total")]
    public double? VtPesoTotal { get; set; }

    [Column("mv_costo")]
    public double? MvCosto { get; set; }

    [Column("vt_costo_total")]
    public double? VtCostoTotal { get; set; }

    [Column("vt_venta_bruta")]
    public double? VtVentaBruta { get; set; }

    [Column("vt_venta_neta")]
    public double? VtVentaNeta { get; set; }

    [Column("vt_DescUnitario")]
    public double? VtDescUnitario { get; set; }

    [Column("vt_PorDescUnitario")]
    public double? VtPorDescUnitario { get; set; }

    [Column("vt_Subtotal")]
    public double? VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double? VtIva { get; set; }

    [Column("vt_por_iva")]
    public double? VtPorIva { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime? VtFecha { get; set; }
}
