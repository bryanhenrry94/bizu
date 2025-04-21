using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcParametrosXCheqProtesto
{
    public int IdEmpresa { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("pa_IdSucursal_x_default_x_cheqProtes")]
    public int? PaIdSucursalXDefaultXCheqProtes { get; set; }

    [Column("pa_IdBodega_x_default_x_cheqProtes")]
    public int? PaIdBodegaXDefaultXCheqProtes { get; set; }

    [Column("pa_IdProducto_x_ND_x_CheqProtes")]
    [Precision(18, 0)]
    public decimal? PaIdProductoXNdXCheqProtes { get; set; }

    [Column("pa_IdProducto_x_NC_x_Cobro")]
    [Precision(18, 0)]
    public decimal? PaIdProductoXNcXCobro { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("ProductoND")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ProductoNd { get; set; } = null!;

    [Column("ProductoNC")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ProductoNc { get; set; } = null!;
}
