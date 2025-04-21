using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomEstadoRecibido
{
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoCatalogo { get; set; } = null!;

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Codigo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Id { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    public int? Orden { get; set; }

    [Column("name")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Name { get; set; }
}
