using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaFa", "IdSucursal", "IdBodega", "IdCbteVta", "Secuencia", "IdEmpresaDe", "IdDescuento", "SecuenciaReg")]
[Table("fa_factura_det_x_fa_descuento")]
[Index("IdEmpresaDe", "IdDescuento", Name = "FK_fa_factura_det_x_fa_descuento_fa_descuento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaDetXFaDescuento
{
    [Key]
    [Column("IdEmpresa_fa")]
    public int IdEmpresaFa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Key]
    [Column("IdEmpresa_de")]
    public int IdEmpresaDe { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdDescuento { get; set; }

    [Key]
    [Column("Secuencia_reg")]
    public int SecuenciaReg { get; set; }

    [Column("de_valor")]
    public double DeValor { get; set; }

    [ForeignKey("IdEmpresaDe, IdDescuento")]
    [InverseProperty("FaFacturaDetXFaDescuento")]
    public virtual FaDescuento FaDescuento { get; set; } = null!;

    [ForeignKey("IdEmpresaFa, IdSucursal, IdBodega, IdCbteVta, Secuencia")]
    [InverseProperty("FaFacturaDetXFaDescuento")]
    public virtual FaFacturaDet FaFacturaDet { get; set; } = null!;
}
