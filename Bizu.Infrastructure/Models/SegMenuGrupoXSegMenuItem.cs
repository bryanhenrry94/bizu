using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("CodigoItem", "CodigoGrupo")]
[Table("seg_Menu_Grupo_x_seg_Menu_Item")]
[Index("CodigoGrupo", Name = "FK_seg_Menu_Grupo_x_seg_Menu_Item_seg_Menu_Grupo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuGrupoXSegMenuItem
{
    [Key]
    [Column("Codigo_Item")]
    [StringLength(50)]
    public string CodigoItem { get; set; } = null!;

    [Key]
    [Column("Codigo_Grupo")]
    [StringLength(50)]
    public string CodigoGrupo { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("CodigoGrupo")]
    [InverseProperty("SegMenuGrupoXSegMenuItem")]
    public virtual SegMenuGrupo CodigoGrupoNavigation { get; set; } = null!;

    [ForeignKey("CodigoItem")]
    [InverseProperty("SegMenuGrupoXSegMenuItem")]
    public virtual SegMenuItem CodigoItemNavigation { get; set; } = null!;
}
