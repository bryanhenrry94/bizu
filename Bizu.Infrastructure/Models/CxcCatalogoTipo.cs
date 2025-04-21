using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCatalogoTipo
{
    [Key]
    [Column("IdCatalogo_tipo")]
    [StringLength(20)]
    public string IdCatalogoTipo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("IdCatalogoTipoNavigation")]
    public virtual ICollection<CxcCatalogo> CxcCatalogo { get; set; } = new List<CxcCatalogo>();
}
