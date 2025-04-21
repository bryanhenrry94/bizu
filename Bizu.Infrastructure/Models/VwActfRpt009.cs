using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt009
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodActivoFijo { get; set; } = null!;

    [Column("Af_Codigo_Barra")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfCodigoBarra { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;
}
