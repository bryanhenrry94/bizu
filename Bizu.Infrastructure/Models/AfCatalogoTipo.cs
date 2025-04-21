using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("Af_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfCatalogoTipo
{
    [Key]
    [StringLength(25)]
    public string IdTipoCatalogo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("IdTipoCatalogoNavigation")]
    public virtual ICollection<AfCatalogo> AfCatalogo { get; set; } = new List<AfCatalogo>();
}
