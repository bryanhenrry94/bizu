using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_Menu_Item")]
[Index("IdTipoItem", Name = "FK_seg_Menu_Item_seg_Menu_Item_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuItem
{
    [Key]
    [Column("Codigo_Item")]
    [StringLength(50)]
    public string CodigoItem { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    public int ImageIndex { get; set; }

    public int? LargeImageIndex { get; set; }

    [StringLength(50)]
    public string? ItemShortcut { get; set; }

    public bool Enabled { get; set; }

    [Column("position")]
    public int Position { get; set; }

    [Column("IdTipo_Item")]
    [StringLength(50)]
    public string IdTipoItem { get; set; } = null!;

    [Column("nom_Formulario")]
    [StringLength(250)]
    public string? NomFormulario { get; set; }

    [Column("nom_Asembly")]
    [StringLength(250)]
    public string? NomAsembly { get; set; }

    [StringLength(50)]
    public string? CodReporte { get; set; }

    [StringLength(20)]
    public string Tipo { get; set; } = null!;

    [Column("Se_muestra_menu_superior")]
    public bool SeMuestraMenuSuperior { get; set; }

    [Column("Se_muestra_menu_lateral")]
    public bool SeMuestraMenuLateral { get; set; }

    public bool Visible { get; set; }

    [ForeignKey("IdTipoItem")]
    [InverseProperty("SegMenuItem")]
    public virtual SegMenuItemTipo IdTipoItemNavigation { get; set; } = null!;

    [InverseProperty("CodigoItemNavigation")]
    public virtual ICollection<SegMenuGrupoXSegMenuItem> SegMenuGrupoXSegMenuItem { get; set; } = new List<SegMenuGrupoXSegMenuItem>();
}
