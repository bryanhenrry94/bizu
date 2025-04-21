using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdUsuario", "IdEmpresa", "IdMenu")]
[Table("seg_Menu_Web_x_Empresa_x_Usuario")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuWebXEmpresaXUsuario
{
    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMenu { get; set; }

    public bool Lectura { get; set; }

    public bool Escritura { get; set; }

    public bool Eliminacion { get; set; }
}
