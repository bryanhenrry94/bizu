using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt007
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdVtaActivo { get; set; }

    [Column("Cod_VtaActivo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodVtaActivo { get; set; } = null!;

    public int IdActivoFijo { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCompleto { get; set; }

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
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumComprobante { get; set; }

    [Column("Concepto_Vta")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ConceptoVta { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("Fecha_Venta")]
    [MaxLength(6)]
    public DateTime FechaVenta { get; set; }
}
