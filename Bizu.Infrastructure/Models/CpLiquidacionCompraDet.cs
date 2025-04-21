using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdLiquidacionCompra", "Secuencia")]
[Table("cp_liquidacion_compra_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_cp_liquidacion_compra_det_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_cp_liquidacion_compra_det_in_UnidadMedida")]
[Index("IdCodImpuestoIva", Name = "FK_cp_liquidacion_compra_det_tb_sis_Impuesto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpLiquidacionCompraDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdLiquidacionCompra { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [StringLength(50)]
    public string Codigo { get; set; } = null!;

    [StringLength(150)]
    public string Descripcion { get; set; } = null!;

    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    public double Cantidad { get; set; }

    public double Precio { get; set; }

    public double PorDescUnitario { get; set; }

    public double DescUnitario { get; set; }

    public double PrecioFinal { get; set; }

    public double Subtotal { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    public string IdCodImpuestoIva { get; set; } = null!;

    public double Iva { get; set; }

    [Column("por_iva")]
    public double PorIva { get; set; }

    public double Total { get; set; }

    [ForeignKey("IdEmpresa, IdLiquidacionCompra")]
    [InverseProperty("CpLiquidacionCompraDet")]
    public virtual CpLiquidacionCompra CpLiquidacionCompra { get; set; } = null!;

    [ForeignKey("IdCodImpuestoIva")]
    [InverseProperty("CpLiquidacionCompraDet")]
    public virtual TbSisImpuesto IdCodImpuestoIvaNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("CpLiquidacionCompraDet")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("CpLiquidacionCompraDet")]
    public virtual InProducto? InProducto { get; set; }
}
