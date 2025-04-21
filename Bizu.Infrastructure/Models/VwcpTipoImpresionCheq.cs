using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpTipoImpresionCheq
{
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Codigo { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;
}
