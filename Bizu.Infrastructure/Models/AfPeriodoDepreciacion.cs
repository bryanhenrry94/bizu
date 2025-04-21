using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("Af_PeriodoDepreciacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfPeriodoDepreciacion
{
    [Key]
    [StringLength(20)]
    public string IdPeriodoDeprec { get; set; } = null!;

    [StringLength(50)]
    public string? Descripcion { get; set; }

    [Column("Valor_Ciclo_Anual")]
    public int? ValorCicloAnual { get; set; }

    [InverseProperty("IdPeriodoDeprecNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();
}
