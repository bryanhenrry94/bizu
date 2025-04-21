using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMotivoTrasladoBodega
{
    [Column("IdMotivo_Traslado")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdMotivoTraslado { get; set; } = null!;

    [Column("IdCatalogo_tipo")]
    public int IdCatalogoTipo { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nombre { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
