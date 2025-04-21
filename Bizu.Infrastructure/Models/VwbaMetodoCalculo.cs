using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaMetodoCalculo
{
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdMetCalc { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoCatalogo { get; set; } = null!;

    [Column("ca_descripcion")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaDescripcion { get; set; } = null!;

    [Column("ca_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaEstado { get; set; } = null!;

    [Column("ca_orden")]
    public int CaOrden { get; set; }
}
