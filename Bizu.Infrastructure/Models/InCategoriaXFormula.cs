using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoria", "IdLinea")]
[Table("in_Categoria_x_Formula")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InCategoriaXFormula
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdCategoria { get; set; }

    [Key]
    public int IdLinea { get; set; }

    [Column("descripcion_corta")]
    [StringLength(10)]
    public string? DescripcionCorta { get; set; }

    [Column("tiene_longitud")]
    public bool? TieneLongitud { get; set; }

    [Column("tiene_espesor")]
    public bool? TieneEspesor { get; set; }

    [Column("tiene_ancho")]
    public bool? TieneAncho { get; set; }

    [Column("tiene_alto")]
    public bool? TieneAlto { get; set; }

    [Column("tiene_ceja")]
    public bool? TieneCeja { get; set; }

    [Column("tiene_diametro")]
    public bool? TieneDiametro { get; set; }

    [Column("densidad")]
    public int Densidad { get; set; }

    [Column("formula")]
    [StringLength(250)]
    public string Formula { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }
}
