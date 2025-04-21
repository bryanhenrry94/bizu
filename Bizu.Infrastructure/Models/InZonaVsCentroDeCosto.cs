using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaIdZona", "IdZona", "IdEmpresaCentrCosot", "IdCentroCosto", "IdSubZona")]
[Table("in_Zona_vs_CentroDeCosto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InZonaVsCentroDeCosto
{
    [Key]
    public int IdEmpresaIdZona { get; set; }

    [Key]
    public int IdZona { get; set; }

    [Key]
    public int IdEmpresaCentrCosot { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCentroCosto { get; set; }

    [Key]
    public int IdSubZona { get; set; }

    [Column("CodigoZN")]
    [StringLength(50)]
    public string? CodigoZn { get; set; }

    [StringLength(20)]
    public string? IdCtaCbleZona { get; set; }
}
