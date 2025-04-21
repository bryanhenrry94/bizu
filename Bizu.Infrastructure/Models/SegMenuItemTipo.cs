using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_Menu_Item_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuItemTipo
{
    [Key]
    [Column("IdTipo_Item")]
    [StringLength(50)]
    public string IdTipoItem { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("IdTipoItemNavigation")]
    public virtual ICollection<SegMenuItem> SegMenuItem { get; set; } = new List<SegMenuItem>();
}
