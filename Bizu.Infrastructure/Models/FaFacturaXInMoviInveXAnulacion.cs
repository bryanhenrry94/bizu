using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("FaIdEmpresa", "FaIdSucursal", "FaIdBodega", "FaIdCbteVta", "InvIdEmpresa", "InvIdSucursal", "InvIdBodega", "InvIdMoviInvenTipo", "InvIdNumMovi")]
[Table("fa_factura_x_in_movi_inve_x_Anulacion")]
[Index("InvIdEmpresa", "InvIdSucursal", "InvIdBodega", "InvIdMoviInvenTipo", "InvIdNumMovi", Name = "FK_fa_factura_x_in_movi_inve_x_Anulacion_in_movi_inve")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaXInMoviInveXAnulacion
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
    [Column("inv_IdEmpresa")]
    public int InvIdEmpresa { get; set; }

    [Key]
    [Column("inv_IdSucursal")]
    public int InvIdSucursal { get; set; }

    [Key]
    [Column("inv_IdBodega")]
    public int InvIdBodega { get; set; }

    [Key]
    [Column("inv_IdMovi_inven_tipo")]
    public int InvIdMoviInvenTipo { get; set; }

    [Key]
    [Column("inv_IdNumMovi")]
    [Precision(18, 0)]
    public decimal InvIdNumMovi { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    [ForeignKey("FaIdEmpresa, FaIdSucursal, FaIdBodega, FaIdCbteVta")]
    [InverseProperty("FaFacturaXInMoviInveXAnulacion")]
    public virtual FaFactura FaFactura { get; set; } = null!;

    [ForeignKey("InvIdEmpresa, InvIdSucursal, InvIdBodega, InvIdMoviInvenTipo, InvIdNumMovi")]
    [InverseProperty("FaFacturaXInMoviInveXAnulacion")]
    public virtual InMoviInve InMoviInve { get; set; } = null!;
}
