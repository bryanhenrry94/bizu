using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdVtaActivo")]
[Table("Af_Venta_Activo")]
[Index("IdEmpresa", "IdActivoFijo", Name = "FK_Af_Venta_Activo_Af_Activo_fijo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfVentaActivo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdVtaActivo { get; set; }

    [Column("Cod_VtaActivo")]
    [StringLength(20)]
    public string CodVtaActivo { get; set; } = null!;

    public int IdActivoFijo { get; set; }

    public double ValorActivo { get; set; }

    [Column("Valor_Tot_Bajas")]
    public double ValorTotBajas { get; set; }

    [Column("Valor_Tot_Mejora")]
    public double ValorTotMejora { get; set; }

    [Column("Valor_Depre_Acu")]
    public double ValorDepreAcu { get; set; }

    [Column("Valor_Neto")]
    public double ValorNeto { get; set; }

    [Column("Valor_Venta")]
    public double ValorVenta { get; set; }

    [Column("Valor_Perdi_Gana")]
    public double ValorPerdiGana { get; set; }

    [StringLength(50)]
    public string? NumComprobante { get; set; }

    [Column("Concepto_Vta")]
    [StringLength(200)]
    public string? ConceptoVta { get; set; }

    [Column("Fecha_Venta")]
    [MaxLength(6)]
    public DateTime FechaVenta { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [ForeignKey("IdEmpresa, IdActivoFijo")]
    [InverseProperty("AfVentaActivo")]
    public virtual AfActivoFijo AfActivoFijo { get; set; } = null!;
}
