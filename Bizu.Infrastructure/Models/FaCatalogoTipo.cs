using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("fa_catalogo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaCatalogoTipo
{
    [Key]
    [Column("IdCatalogo_tipo")]
    public int IdCatalogoTipo { get; set; }

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("IdCatalogoTipoNavigation")]
    public virtual ICollection<FaCatalogo> FaCatalogo { get; set; } = new List<FaCatalogo>();
}
