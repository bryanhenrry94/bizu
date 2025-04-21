using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_region")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbRegion
{
    [Key]
    [Column("Cod_Region")]
    [StringLength(10)]
    public string CodRegion { get; set; } = null!;

    [Column("Nom_region")]
    [StringLength(100)]
    public string NomRegion { get; set; } = null!;

    [InverseProperty("CodRegionNavigation")]
    public virtual ICollection<TbProvincia> TbProvincia { get; set; } = new List<TbProvincia>();
}
