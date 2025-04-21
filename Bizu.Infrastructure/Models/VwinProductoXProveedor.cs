using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinProductoXProveedor
{
    [Column("IdEmpresa_prod")]
    public int IdEmpresaProd { get; set; }

    [Column("IdEmpresa_prov")]
    public int IdEmpresaProv { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }
}
