using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdVendedor", "IdSucursal")]
[Table("fa_VendedorxSucursal")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_fa_VendedorxSucursal_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaVendedorxSucursal
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdVendedor { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaVendedorxSucursal")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("FaVendedorxSucursal")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
