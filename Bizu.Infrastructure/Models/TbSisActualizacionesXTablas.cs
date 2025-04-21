using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Actualizaciones_x_tablas")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisActualizacionesXTablas
{
    [Key]
    [StringLength(150)]
    public string IdTabla { get; set; } = null!;

    [Column("ult_fecha_update")]
    [MaxLength(6)]
    public DateTime? UltFechaUpdate { get; set; }

    [Column("ult_proceso")]
    public string? UltProceso { get; set; }
}
