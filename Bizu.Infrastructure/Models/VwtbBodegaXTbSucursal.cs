using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbBodegaXTbSucursal
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("cod_sucursal")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodSucursal { get; set; }

    [Column("cod_bodega")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodBodega { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;
}
