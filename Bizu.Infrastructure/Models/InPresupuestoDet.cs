using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdPresupuesto", "Secuencia")]
[Table("in_presupuesto_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_presupuesto_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InPresupuestoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPresupuesto { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("dp_iva")]
    public double DpIva { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dp_Cantidad")]
    public double DpCantidad { get; set; }

    [Column("dp_costo")]
    public double DpCosto { get; set; }

    [Column("dp_porc_des")]
    public double DpPorcDes { get; set; }

    [Column("dp_descuento")]
    public double DpDescuento { get; set; }

    [Column("dp_subtotal")]
    public double DpSubtotal { get; set; }

    [Column("dp_total")]
    public double DpTotal { get; set; }

    [Column("dp_ManejaIva")]
    [StringLength(1)]
    public string DpManejaIva { get; set; } = null!;

    [Column("dp_Costeado")]
    [StringLength(1)]
    public string DpCosteado { get; set; } = null!;

    [Column("dp_costo_promedio_hist")]
    public double DpCostoPromedioHist { get; set; }

    [Column("dp_peso")]
    public double DpPeso { get; set; }

    [Column("dp_observacion")]
    [StringLength(200)]
    public string DpObservacion { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdPresupuesto")]
    [InverseProperty("InPresupuestoDet")]
    public virtual InPresupuesto InPresupuesto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InPresupuestoDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
