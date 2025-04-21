using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCentroCosto", "IdUsuario")]
[Table("ct_centro_costo_Filtro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCentroCostoFiltro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;
}
