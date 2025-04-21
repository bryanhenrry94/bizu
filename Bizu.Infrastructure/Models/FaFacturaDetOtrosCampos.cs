using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVta", "Secuencia")]
[Table("fa_factura_det_otros_campos")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_fa_factura_det_otros_campos_ct_punto_cargo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaDetOtrosCampos
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

    [Column("IdPunto_Cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("Precio_Iva")]
    public double? PrecioIva { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("FaFacturaDetOtrosCampos")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdCbteVta")]
    [InverseProperty("FaFacturaDetOtrosCampos")]
    public virtual FaFactura FaFactura { get; set; } = null!;
}
