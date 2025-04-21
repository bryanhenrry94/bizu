using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_estado")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpEstado
{
    [Key]
    [Column("IdEstado_cp")]
    [StringLength(25)]
    public string IdEstadoCp { get; set; } = null!;

    [Column("nom_estado_cp")]
    [StringLength(50)]
    public string NomEstadoCp { get; set; } = null!;

    [Column("IdEstado_cp_tipo")]
    [StringLength(25)]
    public string IdEstadoCpTipo { get; set; } = null!;
}
