using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_EstadoCobro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcEstadoCobro
{
    [Key]
    [StringLength(5)]
    public string IdEstadoCobro { get; set; } = null!;

    [StringLength(50)]
    public string? Descripcion { get; set; }

    [Column("posicion")]
    public int? Posicion { get; set; }

    [InverseProperty("IdEstadoCobroNavigation")]
    public virtual ICollection<CxcCobroXEstadoCobro> CxcCobroXEstadoCobro { get; set; } = new List<CxcCobroXEstadoCobro>();
}
