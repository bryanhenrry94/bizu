using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("empleado_temp")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class EmpleadoTemp
{
    [Column("Nombres_Apellidos")]
    [StringLength(100)]
    public string? NombresApellidos { get; set; }

    [Column("idEmpleado")]
    [Precision(18, 0)]
    public decimal? IdEmpleado { get; set; }

    [Column("cedula")]
    [StringLength(15)]
    public string? Cedula { get; set; }

    [Column("idRubro")]
    [Precision(18, 0)]
    public decimal? IdRubro { get; set; }

    public double? Valor { get; set; }

    [Column("idPeriodo")]
    [StringLength(15)]
    public string? IdPeriodo { get; set; }
}
