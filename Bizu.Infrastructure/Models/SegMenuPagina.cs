using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_Menu_Pagina")]
[Index("CodigoCategoria", Name = "FK_seg_Menu_Pagina_seg_Menu_Categoria")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuPagina
{
    [Key]
    [Column("Codigo_Pagina")]
    [StringLength(50)]
    public string CodigoPagina { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    public bool Visible { get; set; }

    public bool Expanded { get; set; }

    public int ImageIndex { get; set; }

    [StringLength(50)]
    public string ImageAlign { get; set; } = null!;

    [Column("Codigo_Categoria")]
    [StringLength(50)]
    public string CodigoCategoria { get; set; } = null!;

    [Column("position")]
    public int Position { get; set; }

    [ForeignKey("CodigoCategoria")]
    [InverseProperty("SegMenuPagina")]
    public virtual SegMenuCategoria CodigoCategoriaNavigation { get; set; } = null!;

    [InverseProperty("CodigoPaginaNavigation")]
    public virtual ICollection<SegMenuGrupo> SegMenuGrupo { get; set; } = new List<SegMenuGrupo>();
}
