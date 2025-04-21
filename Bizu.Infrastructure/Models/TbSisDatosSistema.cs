using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Datos_Sistema")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDatosSistema
{
    [Key]
    public int Id { get; set; }

    [Column("Nombre_sistema")]
    [StringLength(50)]
    public string NombreSistema { get; set; } = null!;

    [Column("version")]
    [StringLength(12)]
    public string Version { get; set; } = null!;

    [StringLength(50)]
    public string Propietario { get; set; } = null!;

    [StringLength(500)]
    public string Desarrolladores { get; set; } = null!;

    [StringLength(500)]
    public string Observacion { get; set; } = null!;
}
