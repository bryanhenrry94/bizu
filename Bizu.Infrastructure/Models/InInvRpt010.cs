using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto", "IdUsuario")]
[Table("in_INV_Rpt010")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InInvRpt010
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

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Saldo_ini_cant")]
    public double SaldoIniCant { get; set; }

    [Column("Saldo_ini_cost")]
    public double SaldoIniCost { get; set; }

    [Column("Saldo_fin_cant")]
    public double SaldoFinCant { get; set; }

    [Column("Saldo_fin_cost")]
    public double SaldoFinCost { get; set; }

    [Column("mov_ing_cant")]
    public double MovIngCant { get; set; }

    [Column("mov_ing_cost")]
    public double MovIngCost { get; set; }

    [Column("mov_egr_cant")]
    public double MovEgrCant { get; set; }

    [Column("mov_egr_cost")]
    public double MovEgrCost { get; set; }
}
