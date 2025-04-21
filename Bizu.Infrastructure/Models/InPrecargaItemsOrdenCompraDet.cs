using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdPrecarga", "Secuencia")]
[Table("in_PrecargaItemsOrdenCompra_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_PrecargaItemsOrdenCompra_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InPrecargaItemsOrdenCompraDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPrecarga { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dpr_Cantidad")]
    public double DprCantidad { get; set; }

    [Column("dpr_costo")]
    public double DprCosto { get; set; }

    [Column("dpr_porc_des")]
    public double DprPorcDes { get; set; }

    [Column("dpr_descuento")]
    public double DprDescuento { get; set; }

    [Column("dpr_subtotal")]
    public double DprSubtotal { get; set; }

    [Column("dpr_iva")]
    public double DprIva { get; set; }

    [Column("dpr_total")]
    public double DprTotal { get; set; }

    [Column("dpr_ManejaIva")]
    [StringLength(1)]
    public string DprManejaIva { get; set; } = null!;

    [Column("dpr_Costeado")]
    [StringLength(1)]
    public string DprCosteado { get; set; } = null!;

    [Column("dpr_costo_promedio_hist")]
    public double DprCostoPromedioHist { get; set; }

    [Column("dpr_peso")]
    public double DprPeso { get; set; }

    [Column("dpr_observacion")]
    [StringLength(200)]
    public string DprObservacion { get; set; } = null!;

    [StringLength(1)]
    public string EstadoProcesado { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdPrecarga")]
    [InverseProperty("InPrecargaItemsOrdenCompraDet")]
    public virtual InPrecargaItemsOrdenCompra InPrecargaItemsOrdenCompra { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InPrecargaItemsOrdenCompraDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
