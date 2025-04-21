using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("FaIdEmpresa", "FaIdSucursal", "FaIdBodega", "FaIdCbteVta", "GiIdEmpresa", "GiIdSucursal", "GiIdBodega", "GiIdGuiaRemision")]
[Table("fa_factura_x_fa_guia_remision")]
[Index("GiIdEmpresa", "GiIdSucursal", "GiIdBodega", "GiIdGuiaRemision", Name = "FK_fa_factura_x_fa_guia_remision_fa_guia_remision")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaXFaGuiaRemision
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
    [Column("gi_IdEmpresa")]
    public int GiIdEmpresa { get; set; }

    [Key]
    [Column("gi_IdSucursal")]
    public int GiIdSucursal { get; set; }

    [Key]
    [Column("gi_IdBodega")]
    public int GiIdBodega { get; set; }

    [Key]
    [Column("gi_IdGuiaRemision")]
    [Precision(18, 0)]
    public decimal GiIdGuiaRemision { get; set; }

    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("FaIdEmpresa, FaIdSucursal, FaIdBodega, FaIdCbteVta")]
    [InverseProperty("FaFacturaXFaGuiaRemision")]
    public virtual FaFactura FaFactura { get; set; } = null!;

    [ForeignKey("GiIdEmpresa, GiIdSucursal, GiIdBodega, GiIdGuiaRemision")]
    [InverseProperty("FaFacturaXFaGuiaRemision")]
    public virtual FaGuiaRemision FaGuiaRemision { get; set; } = null!;
}
