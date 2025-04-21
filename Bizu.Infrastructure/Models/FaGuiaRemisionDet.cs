using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdGuiaRemision", "Secuencia")]
[Table("fa_guia_remision_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_fa_guia_remision_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaGuiaRemisionDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [Key]
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
    public string? GiTieneIva { get; set; }

    [Column("gi_detallexItems")]
    [StringLength(250)]
    public string GiDetallexItems { get; set; } = null!;

    [Column("gi_peso")]
    public double? GiPeso { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdGuiaRemision")]
    [InverseProperty("FaGuiaRemisionDet")]
    public virtual FaGuiaRemision FaGuiaRemision { get; set; } = null!;

    [InverseProperty("FaGuiaRemisionDet")]
    public virtual ICollection<FaGuiaRemisionDetXFaFacturaDet> FaGuiaRemisionDetXFaFacturaDet { get; set; } = new List<FaGuiaRemisionDetXFaFacturaDet>();

    [InverseProperty("FaGuiaRemisionDet")]
    public virtual ICollection<FaGuiaRemisionDetXFaOrdenDespDet> FaGuiaRemisionDetXFaOrdenDespDet { get; set; } = new List<FaGuiaRemisionDetXFaOrdenDespDet>();

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("FaGuiaRemisionDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
