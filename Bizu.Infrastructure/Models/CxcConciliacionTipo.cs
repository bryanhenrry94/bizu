using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_conciliacion_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcConciliacionTipo
{
    [Key]
    [StringLength(20)]
    public string IdTipoConciliacion { get; set; } = null!;

    [StringLength(50)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdTipoConciliacionNavigation")]
    public virtual ICollection<CxcConciliacionDet> CxcConciliacionDet { get; set; } = new List<CxcConciliacionDet>();
}
