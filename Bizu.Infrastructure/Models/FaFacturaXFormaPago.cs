using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVta", "IdFormaPago")]
[Table("fa_factura_x_formaPago")]
[Index("IdFormaPago", Name = "FK_fa_factura_x_formaPago_fa_formaPago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaXFormaPago
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
    [StringLength(2)]
    public string IdFormaPago { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdCbteVta")]
    [InverseProperty("FaFacturaXFormaPago")]
    public virtual FaFactura FaFactura { get; set; } = null!;

    [ForeignKey("IdFormaPago")]
    [InverseProperty("FaFacturaXFormaPago")]
    public virtual FaFormaPago IdFormaPagoNavigation { get; set; } = null!;
}
