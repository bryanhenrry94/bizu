using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto")]
[Table("in_kardex")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InKardex
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

    [Column("kr_saldoInicial")]
    public double KrSaldoInicial { get; set; }

    [Column("kr_saldoFinal")]
    public double KrSaldoFinal { get; set; }

    [Column("kr_TotalIngresos")]
    public double KrTotalIngresos { get; set; }

    [Column("kr_TotalEgresos")]
    public double KrTotalEgresos { get; set; }

    [Column("kr_TotalMovimientos")]
    public double KrTotalMovimientos { get; set; }

    [Column("kr_costoInicial")]
    public double KrCostoInicial { get; set; }

    [Column("kr_costoFinal")]
    public double KrCostoFinal { get; set; }

    [Column("kr_stockActual")]
    public double KrStockActual { get; set; }

    [InverseProperty("InKardex")]
    public virtual ICollection<InKardexDet> InKardexDet { get; set; } = new List<InKardexDet>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("InKardex")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
