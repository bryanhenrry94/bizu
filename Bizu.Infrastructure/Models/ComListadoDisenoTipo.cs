using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoListadoDiseno")]
[Table("com_ListadoDisenoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComListadoDisenoTipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoListadoDiseno { get; set; }

    [StringLength(20)]
    public string TipoListadoDiseno { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;
}
