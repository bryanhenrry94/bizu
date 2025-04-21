using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdVentaTel", "Secuencia")]
[Table("fa_venta_telefonica_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_fa_venta_telefonica_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaVentaTelefonicaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Column("IdVenta_tel")]
    [Precision(18, 0)]
    public decimal IdVentaTel { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    public double Cantidad { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdVentaTel")]
    [InverseProperty("FaVentaTelefonicaDet")]
    public virtual FaVentaTelefonica FaVentaTelefonica { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("FaVentaTelefonicaDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
