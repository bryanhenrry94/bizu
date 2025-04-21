using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto")]
[Table("in_rptMovi_Inv_x_prod_resumido")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InRptMoviInvXProdResumido
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [StringLength(50)]
    public string? CodProducto { get; set; }

    [StringLength(25)]
    public string? IdCategoria { get; set; }

    [Column("pr_peso")]
    public double? PrPeso { get; set; }

    [Column("stock")]
    public double? Stock { get; set; }

    [Column("Nom_Sucursal")]
    [StringLength(50)]
    public string? NomSucursal { get; set; }

    [Column("Nom_Bodega")]
    [StringLength(50)]
    public string? NomBodega { get; set; }

    [Column("Nom_Producto")]
    [StringLength(500)]
    public string? NomProducto { get; set; }

    [Column("Nom_Categoria")]
    [StringLength(100)]
    public string? NomCategoria { get; set; }

    [Column("Nom_Empresa")]
    [StringLength(50)]
    public string? NomEmpresa { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }
}
