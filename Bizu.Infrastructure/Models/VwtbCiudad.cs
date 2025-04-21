using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbCiudad
{
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCiudad { get; set; } = null!;

    [Column("Cod_Ciudad")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodCiudad { get; set; } = null!;

    [Column("Descripcion_Ciudad")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionCiudad { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdPais { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdProvincia { get; set; } = null!;
}
