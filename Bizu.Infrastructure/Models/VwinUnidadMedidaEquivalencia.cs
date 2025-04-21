using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinUnidadMedidaEquivalencia
{
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("IdUnidadMedida_equiva")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaEquiva { get; set; } = null!;

    [Column("cod_alterno")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodAlterno { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [Column("valor_equiv")]
    public double ValorEquiv { get; set; }

    [Column("interpretacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Interpretacion { get; set; }

    [Column("cod_alterno_Padre")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodAlternoPadre { get; set; }

    [Column("Descripcion_Padre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionPadre { get; set; } = null!;
}
