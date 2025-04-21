using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("EmpresaSi", "IdSucursalSi", "IdBodegaSi", "IdProductoSi", "IdCategoria", "IdUsuario")]
[Table("in_rptDispInve")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InRptDispInve
{
    [Key]
    public int EmpresaSi { get; set; }

    [Key]
    public int IdSucursalSi { get; set; }

    [Key]
    public int IdBodegaSi { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProductoSi { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    public string BoDescripcion { get; set; } = null!;

    [Column("pr_codigo")]
    [StringLength(50)]
    public string? PrCodigo { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    public string? PrDescripcion { get; set; }

    [Key]
    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Column("pr_peso")]
    public double? PrPeso { get; set; }

    [Column("ca_Categoria")]
    [StringLength(100)]
    public string CaCategoria { get; set; } = null!;

    public int? IdEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("stock")]
    public double? Stock { get; set; }

    [Column("pr_Pedidos")]
    public double PrPedidos { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;
}
