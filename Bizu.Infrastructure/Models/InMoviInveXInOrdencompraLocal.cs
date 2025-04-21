using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdNumMovi", "IdEmpresaOc", "IdSucursalOc", "IdOrdenCompra")]
[Table("in_movi_inve_x_in_ordencompra_local")]
[Index("IdEmpresaOc", "IdSucursalOc", "IdOrdenCompra", Name = "FK_in_movi_inve_x_in_ordencompra_local_com_ordencompra_local")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInveXInOrdencompraLocal
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
    [Column("IdEmpresaOC")]
    public int IdEmpresaOc { get; set; }

    [Key]
    [Column("IdSucursalOC")]
    public int IdSucursalOc { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("IdEmpresaOc, IdSucursalOc, IdOrdenCompra")]
    [InverseProperty("InMoviInveXInOrdencompraLocal")]
    public virtual ComOrdencompraLocal ComOrdencompraLocal { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdMoviInvenTipo, IdNumMovi")]
    [InverseProperty("InMoviInveXInOrdencompraLocal")]
    public virtual InMoviInve InMoviInve { get; set; } = null!;
}
