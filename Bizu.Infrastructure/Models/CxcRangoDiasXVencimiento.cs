using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_Rango_dias_x_Vencimiento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcRangoDiasXVencimiento
{
    [Key]
    [Column("Id_Rango")]
    [StringLength(20)]
    public string IdRango { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [Column("Valor_Ini")]
    public int ValorIni { get; set; }

    [Column("Valor_Fin")]
    public int ValorFin { get; set; }
}
