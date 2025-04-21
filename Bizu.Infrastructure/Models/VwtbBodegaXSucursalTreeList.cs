using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbBodegaXSucursalTreeList
{
    public int IdEmpresa { get; set; }

    [StringLength(27)]
    public string Id { get; set; } = null!;

    [StringLength(15)]
    public string? IdPadre { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nombre { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    public long Nivel { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }
}
