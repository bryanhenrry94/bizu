using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVta", "Secuencia")]
[Table("fa_factura_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_fa_factura_det_in_Producto")]
[Index("IdCodImpuestoIva", Name = "FK_fa_factura_det_tb_sis_Impuesto")]
[Index("IdCodImpuestoIce", Name = "FK_fa_factura_det_tb_sis_Impuesto1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("vt_cantidad")]
    public double VtCantidad { get; set; }

    [Column("vt_Precio")]
    public double VtPrecio { get; set; }

    [Column("vt_PorDescUnitario")]
    public double VtPorDescUnitario { get; set; }

    [Column("vt_DescUnitario")]
    public double VtDescUnitario { get; set; }

    [Column("vt_PrecioFinal")]
    public double VtPrecioFinal { get; set; }

    [Column("vt_Subtotal")]
    public double VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double VtIva { get; set; }

    [Column("vt_total")]
    public double VtTotal { get; set; }

    [Column("vt_estado")]
    [StringLength(1)]
    public string VtEstado { get; set; } = null!;

    [Column("vt_detallexItems")]
    public string? VtDetallexItems { get; set; }

    [Column("vt_Peso")]
    public double? VtPeso { get; set; }

    [Column("vt_por_iva")]
    public double VtPorIva { get; set; }

    [Column("IdPunto_Cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    public string IdCodImpuestoIva { get; set; } = null!;

    [Column("IdCod_Impuesto_Ice")]
    [StringLength(25)]
    public string? IdCodImpuestoIce { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdCbteVta")]
    [InverseProperty("FaFacturaDet")]
    public virtual FaFactura FaFactura { get; set; } = null!;

    [InverseProperty("FaFacturaDet")]
    public virtual ICollection<FaFacturaDetXFaDescuento> FaFacturaDetXFaDescuento { get; set; } = new List<FaFacturaDetXFaDescuento>();

    [InverseProperty("FaFacturaDet")]
    public virtual ICollection<FaGuiaRemisionDetXFaFacturaDet> FaGuiaRemisionDetXFaFacturaDet { get; set; } = new List<FaGuiaRemisionDetXFaFacturaDet>();

    [ForeignKey("IdCodImpuestoIce")]
    [InverseProperty("FaFacturaDetIdCodImpuestoIceNavigation")]
    public virtual TbSisImpuesto? IdCodImpuestoIceNavigation { get; set; }

    [ForeignKey("IdCodImpuestoIva")]
    [InverseProperty("FaFacturaDetIdCodImpuestoIvaNavigation")]
    public virtual TbSisImpuesto IdCodImpuestoIvaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("FaFacturaDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
