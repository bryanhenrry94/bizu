using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfActivoFijo
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    public int IdTipoDepreciacion { get; set; }

    [Column("cod_tipo_depreciacion")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodTipoDepreciacion { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Af_ValorSalvamento")]
    public double AfValorSalvamento { get; set; }

    [Column("Af_Vida_Util")]
    public int AfVidaUtil { get; set; }

    [Column("Af_Vida_TipDepre")]
    public long? AfVidaTipDepre { get; set; }

    [Column("Af_fecha_ini_depre")]
    [MaxLength(6)]
    public DateTime? AfFechaIniDepre { get; set; }

    [Column("Af_fecha_fin_depre")]
    [MaxLength(6)]
    public DateTime AfFechaFinDepre { get; set; }

    [Column("Af_Meses_depreciar")]
    public long AfMesesDepreciar { get; set; }

    public long Ciclo { get; set; }

    [Column("Af_porcentaje_deprec")]
    public double AfPorcentajeDeprec { get; set; }

    [Column("Valor_Depre")]
    public double? ValorDepre { get; set; }

    [Column("Valor_Depreciacion_Acum")]
    public double? ValorDepreciacionAcum { get; set; }

    [Column("Valor_Importe")]
    public double? ValorImporte { get; set; }

    [Column("Estado_Proceso")]
    [StringLength(35)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EstadoProceso { get; set; }

    [Column("Es_Activo_x_Mejora")]
    public long EsActivoXMejora { get; set; }
}
