using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("com_catalogo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComCatalogoTipo
{
    [Key]
    [Column("IdCatalogocompra_tipo")]
    [StringLength(15)]
    public string IdCatalogocompraTipo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("IdCatalogocompraTipoNavigation")]
    public virtual ICollection<ComCatalogo> ComCatalogo { get; set; } = new List<ComCatalogo>();
}
