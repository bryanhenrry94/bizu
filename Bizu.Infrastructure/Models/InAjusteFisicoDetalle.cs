using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAjusteFisico", "Secuencia")]
[Table("in_AjusteFisico_Detalle")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_in_AjusteFisico_Detalle_ct_centro_costo")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_AjusteFisico_Detalle_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InAjusteFisicoDetalle
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAjusteFisico { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    public double StockSistema { get; set; }

    public double CantidadAjustada { get; set; }

    public double StockFisico { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("InAjusteFisicoDetalle")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdAjusteFisico")]
    [InverseProperty("InAjusteFisicoDetalle")]
    public virtual InAjusteFisico InAjusteFisico { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InAjusteFisicoDetalle")]
    public virtual InProducto InProducto { get; set; } = null!;
}
