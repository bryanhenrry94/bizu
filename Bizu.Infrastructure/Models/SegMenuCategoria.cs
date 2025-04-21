using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_Menu_Categoria")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuCategoria
{
    [Key]
    [Column("Codigo_Categoria")]
    [StringLength(50)]
    public string CodigoCategoria { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    public bool Visible { get; set; }

    public bool Expanded { get; set; }

    [StringLength(50)]
    public string Color { get; set; } = null!;

    [Column("position")]
    public int Position { get; set; }

    [InverseProperty("CodigoCategoriaNavigation")]
    public virtual ICollection<SegMenuPagina> SegMenuPagina { get; set; } = new List<SegMenuPagina>();
}
