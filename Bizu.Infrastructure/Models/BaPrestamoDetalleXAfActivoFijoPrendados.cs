using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPrestamo", "IdActivoFijo")]
[Table("ba_prestamo_detalle_x_af_activo_fijo_Prendados")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaPrestamoDetalleXAfActivoFijoPrendados
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdPrestamo { get; set; }

    [Key]
    public int IdActivoFijo { get; set; }

    [Column("Garantia_Bancaria")]
    public double? GarantiaBancaria { get; set; }
}
