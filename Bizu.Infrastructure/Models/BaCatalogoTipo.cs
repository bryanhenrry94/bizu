using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ba_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCatalogoTipo
{
    [Key]
    [StringLength(10)]
    public string IdTipoCatalogo { get; set; } = null!;

    [Column("tc_Descripcion")]
    [StringLength(50)]
    public string TcDescripcion { get; set; } = null!;

    [InverseProperty("IdTipoCatalogoNavigation")]
    public virtual ICollection<BaCatalogo> BaCatalogo { get; set; } = new List<BaCatalogo>();
}
