using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTarea", "IdUsuario")]
[Table("tb_tarea_equipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbTareaEquipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTarea { get; set; }

    [Key]
    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;
}
