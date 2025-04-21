using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaCbr", "IdSucursalCbr", "IdCobroCbr", "IdEmpresaNt", "IdSucursalNt", "IdBodegaNt", "IdNotaNt")]
[Table("fa_notaCreDeb_x_cxc_cobro")]
[Index("IdEmpresaNt", "IdSucursalNt", "IdBodegaNt", "IdNotaNt", Name = "FK_fa_notaCreDeb_x_cxc_cobro_fa_notaCreDeb")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaNotaCreDebXCxcCobro
{
    [Key]
    [Column("IdEmpresa_cbr")]
    public int IdEmpresaCbr { get; set; }

    [Key]
    [Column("IdSucursal_cbr")]
    public int IdSucursalCbr { get; set; }

    [Key]
    [Column("IdCobro_cbr")]
    [Precision(18, 0)]
    public decimal IdCobroCbr { get; set; }

    [Key]
    [Column("IdEmpresa_nt")]
    public int IdEmpresaNt { get; set; }

    [Key]
    [Column("IdSucursal_nt")]
    public int IdSucursalNt { get; set; }

    [Key]
    [Column("IdBodega_nt")]
    public int IdBodegaNt { get; set; }

    [Key]
    [Column("IdNota_nt")]
    [Precision(18, 0)]
    public decimal IdNotaNt { get; set; }

    [Column("Valor_cobro")]
    public double ValorCobro { get; set; }

    [ForeignKey("IdEmpresaCbr, IdSucursalCbr, IdCobroCbr")]
    [InverseProperty("FaNotaCreDebXCxcCobro")]
    public virtual CxcCobro CxcCobro { get; set; } = null!;

    [ForeignKey("IdEmpresaNt, IdSucursalNt, IdBodegaNt, IdNotaNt")]
    [InverseProperty("FaNotaCreDebXCxcCobro")]
    public virtual FaNotaCreDeb FaNotaCreDeb { get; set; } = null!;
}
