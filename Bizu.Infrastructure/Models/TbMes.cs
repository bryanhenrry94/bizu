using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_mes")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbMes
{
    [Key]
    [Column("idMes")]
    public int IdMes { get; set; }

    [Column("smes")]
    [StringLength(10)]
    public string Smes { get; set; } = null!;

    [StringLength(50)]
    public string Nemonico { get; set; } = null!;

    [Column("smesIngles")]
    [StringLength(20)]
    public string? SmesIngles { get; set; }

    [InverseProperty("CbMesNavigation")]
    public virtual ICollection<CtCbtecble> CtCbtecble { get; set; } = new List<CtCbtecble>();

    [InverseProperty("PeMesNavigation")]
    public virtual ICollection<CtPeriodo> CtPeriodo { get; set; } = new List<CtPeriodo>();

    [InverseProperty("VtMesNavigation")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("CmMesNavigation")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();
}
