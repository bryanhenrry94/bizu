using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("in_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InCatalogoTipo
{
    [Key]
    [Column("IdCatalogo_tipo")]
    public int IdCatalogoTipo { get; set; }

    [Column("cod_Catalogo_tipo")]
    [StringLength(50)]
    public string? CodCatalogoTipo { get; set; }

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("IdCatalogoTipoNavigation")]
    public virtual ICollection<InCatalogo> InCatalogo { get; set; } = new List<InCatalogo>();
}
