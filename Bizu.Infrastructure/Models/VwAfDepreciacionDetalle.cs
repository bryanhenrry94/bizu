using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfDepreciacionDetalle
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    public int IdTipoDepreciacion { get; set; }

    [Column("cod_tipo_depreciacion")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodTipoDepreciacion { get; set; }

    public int IdActivoFijo { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    [Column("Valor_Compra")]
    public double ValorCompra { get; set; }

    [Column("Valor_Salvamento")]
    public double ValorSalvamento { get; set; }

    [Column("Vida_Util")]
    public int VidaUtil { get; set; }

    public int Ciclo { get; set; }

    [Column("Porc_Depreciacion")]
    public double PorcDepreciacion { get; set; }

    [Column("Valor_Depreciacion")]
    public double ValorDepreciacion { get; set; }

    [Column("Valor_Depre_Acum")]
    public double ValorDepreAcum { get; set; }

    [Column("Valor_Importe")]
    public double ValorImporte { get; set; }

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Concepto { get; set; }

    [Column("Es_Activo_x_Mejora")]
    public bool EsActivoXMejora { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodActivoFijo { get; set; } = null!;
}
