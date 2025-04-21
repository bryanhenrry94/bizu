using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdActivoFijoPadre", "IdActivoFijoHijo")]
[Table("Af_Activo_fijo_x_Af_Activo_fijo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfActivoFijoXAfActivoFijo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdActivoFijo_padre")]
    public int IdActivoFijoPadre { get; set; }

    [Key]
    [Column("IdActivoFijo_hijo")]
    public int IdActivoFijoHijo { get; set; }
}
