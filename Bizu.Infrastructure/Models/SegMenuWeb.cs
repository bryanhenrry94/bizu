using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_Menu_Web")]
[Index("IdMenuPadre", Name = "seg_Menu_Web_x_seg_Menu_Web_idx")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuWeb
{
    [Key]
    public int IdMenu { get; set; }

    [StringLength(100)]
    public string Descripcion { get; set; } = null!;

    public int Posicion { get; set; }

    [StringLength(250)]
    public string? Link { get; set; }

    [StringLength(50)]
    public string? Icon { get; set; }

    public int? IdMenuPadre { get; set; }

    public bool Estado { get; set; }

    [ForeignKey("IdMenuPadre")]
    [InverseProperty("InverseIdMenuPadreNavigation")]
    public virtual SegMenuWeb? IdMenuPadreNavigation { get; set; }

    [InverseProperty("IdMenuPadreNavigation")]
    public virtual ICollection<SegMenuWeb> InverseIdMenuPadreNavigation { get; set; } = new List<SegMenuWeb>();
}
