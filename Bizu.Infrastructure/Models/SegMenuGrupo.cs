using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_Menu_Grupo")]
[Index("CodigoPagina", Name = "FK_seg_Menu_Grupo_seg_Menu_Pagina")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuGrupo
{
    [Key]
    [Column("Codigo_Grupo")]
    [StringLength(50)]
    public string CodigoGrupo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    public bool AllowMinimize { get; set; }

    public int ImageIndex { get; set; }

    public bool ShowCaptionButton { get; set; }

    public bool Visible { get; set; }

    [Column("Codigo_Pagina")]
    [StringLength(50)]
    public string CodigoPagina { get; set; } = null!;

    [Column("position")]
    public int Position { get; set; }

    [ForeignKey("CodigoPagina")]
    [InverseProperty("SegMenuGrupo")]
    public virtual SegMenuPagina CodigoPaginaNavigation { get; set; } = null!;

    [InverseProperty("CodigoGrupoNavigation")]
    public virtual ICollection<SegMenuGrupoXSegMenuItem> SegMenuGrupoXSegMenuItem { get; set; } = new List<SegMenuGrupoXSegMenuItem>();
}
