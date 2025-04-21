using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("Af_Activo_fijo_CtasCbles_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfActivoFijoCtasCblesTipo
{
    [Key]
    [StringLength(20)]
    public string IdTipoCuenta { get; set; } = null!;

    [StringLength(120)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdTipoCuentaNavigation")]
    public virtual ICollection<AfActivoFijoCtasCbles> AfActivoFijoCtasCbles { get; set; } = new List<AfActivoFijoCtasCbles>();
}
