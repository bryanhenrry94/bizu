using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaTipoNotaXEmpresa
{
    public int IdEmpresa { get; set; }

    public int IdTipoNota { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoNota { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Tipo { get; set; } = null!;

    [Column("No_Descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NoDescripcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nemonico { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string InternoSis { get; set; } = null!;

    [Column("SeDeclaraSRI")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SeDeclaraSri { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
