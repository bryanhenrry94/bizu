using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_catalogo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCatalogoTipo
{
    [Key]
    [Column("IdCatalogo_tipo")]
    [StringLength(15)]
    public string IdCatalogoTipo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("IdCatalogoTipoNavigation")]
    public virtual ICollection<CpCatalogo> CpCatalogo { get; set; } = new List<CpCatalogo>();
}
