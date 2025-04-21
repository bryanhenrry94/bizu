using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("FaIdEmpresa", "FaIdSucursal", "FaIdBodega", "FaIdCbteVta", "CcIdEmpresa", "CcIdSucursal", "CcIdBodega", "CcIdCotizacion")]
[Table("fa_factura_x_fa_cotizacion")]
[Index("CcIdEmpresa", "CcIdSucursal", "CcIdBodega", "CcIdCotizacion", Name = "FK_fa_factura_x_fa_cotizacion_fa_cotizacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaXFaCotizacion
{
    [Key]
    [Column("fa_IdEmpresa")]
    public int FaIdEmpresa { get; set; }

    [Key]
    [Column("fa_IdSucursal")]
    public int FaIdSucursal { get; set; }

    [Key]
    [Column("fa_IdBodega")]
    public int FaIdBodega { get; set; }

    [Key]
    [Column("fa_IdCbteVta")]
    [Precision(18, 0)]
    public decimal FaIdCbteVta { get; set; }

    [Key]
    [Column("cc_IdEmpresa")]
    public int CcIdEmpresa { get; set; }

    [Key]
    [Column("cc_IdSucursal")]
    public int CcIdSucursal { get; set; }

    [Key]
    [Column("cc_IdBodega")]
    public int CcIdBodega { get; set; }

    [Key]
    [Column("cc_IdCotizacion")]
    [Precision(18, 0)]
    public decimal CcIdCotizacion { get; set; }

    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("CcIdEmpresa, CcIdSucursal, CcIdBodega, CcIdCotizacion")]
    [InverseProperty("FaFacturaXFaCotizacion")]
    public virtual FaCotizacion FaCotizacion { get; set; } = null!;

    [ForeignKey("FaIdEmpresa, FaIdSucursal, FaIdBodega, FaIdCbteVta")]
    [InverseProperty("FaFacturaXFaCotizacion")]
    public virtual FaFactura FaFactura { get; set; } = null!;
}
