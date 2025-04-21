using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdNumMovi", "Secuencia", "SecuenciaReg")]
[Table("in_movi_inve_detalle_x_item")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInveDetalleXItem
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
    public int Secuencia { get; set; }

    [Key]
    [Column("Secuencia_reg")]
    [Precision(18, 0)]
    public decimal SecuenciaReg { get; set; }

    [Column("codigo_reg")]
    [StringLength(100)]
    public string CodigoReg { get; set; } = null!;

    [Column("cantidad")]
    public double Cantidad { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdMoviInvenTipo, IdNumMovi, Secuencia")]
    [InverseProperty("InMoviInveDetalleXItem")]
    public virtual InMoviInveDetalle InMoviInveDetalle { get; set; } = null!;
}
