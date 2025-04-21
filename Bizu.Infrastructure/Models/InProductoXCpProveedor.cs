using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaProd", "IdProducto", "IdEmpresaProv", "IdProveedor")]
[Table("in_producto_x_cp_proveedor")]
[Index("IdEmpresaProv", "IdProveedor", Name = "FK_in_producto_x_cp_proveedor_cp_proveedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoXCpProveedor
{
    [Key]
    [Column("IdEmpresa_prod")]
    public int IdEmpresaProd { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Key]
    [Column("IdEmpresa_prov")]
    public int IdEmpresaProv { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("NomProducto_en_Proveedor")]
    [StringLength(200)]
    public string NomProductoEnProveedor { get; set; } = null!;

    [ForeignKey("IdEmpresaProv, IdProveedor")]
    [InverseProperty("InProductoXCpProveedor")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [ForeignKey("IdEmpresaProd, IdProducto")]
    [InverseProperty("InProductoXCpProveedor")]
    public virtual InProducto InProducto { get; set; } = null!;
}
