using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdHisDepreciacion", "Secuencia")]
[Table("Af_Depreciacion_Det_His_Anulacion")]
[Index("IdEmpresa", "IdActivoFijo", Name = "FK_Af_Depreciacion_Det_His_Anulacion_Af_Activo_fijo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfDepreciacionDetHisAnulacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdHisDepreciacion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    public int IdTipoDepreciacion { get; set; }

    public int IdActivoFijo { get; set; }

    public int Ciclo { get; set; }

    [StringLength(100)]
    public string? Concepto { get; set; }

    [Column("Valor_Compra")]
    public double ValorCompra { get; set; }

    [Column("Valor_Salvamento")]
    public double ValorSalvamento { get; set; }

    [Column("Vida_Util")]
    public int VidaUtil { get; set; }

    [Column("Porc_Depreciacion")]
    public double PorcDepreciacion { get; set; }

    [Column("Valor_Depreciacion")]
    public double ValorDepreciacion { get; set; }

    [Column("Valor_Depre_Acum")]
    public double ValorDepreAcum { get; set; }

    [Column("Valor_Importe")]
    public double ValorImporte { get; set; }

    [Column("Es_Activo_x_Mejora")]
    public bool EsActivoXMejora { get; set; }

    [ForeignKey("IdEmpresa, IdActivoFijo")]
    [InverseProperty("AfDepreciacionDetHisAnulacion")]
    public virtual AfActivoFijo AfActivoFijo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdHisDepreciacion")]
    [InverseProperty("AfDepreciacionDetHisAnulacion")]
    public virtual AfDepreciacionHisAnulacion AfDepreciacionHisAnulacion { get; set; } = null!;
}
