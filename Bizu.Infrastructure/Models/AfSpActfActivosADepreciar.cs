using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("Af_spACTF_activos_a_depreciar")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfSpActfActivosADepreciar
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Af_depreciacion_acum")]
    public double AfDepreciacionAcum { get; set; }

    [Column("Af_dias_a_depreciar")]
    public int AfDiasADepreciar { get; set; }

    [Column("Af_valor_depr_diario")]
    public double AfValorDeprDiario { get; set; }

    [Column("Af_valor_depreciacion")]
    public double AfValorDepreciacion { get; set; }
}
