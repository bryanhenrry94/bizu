using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_ciiu")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCiiu
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("codigo")]
    [StringLength(15)]
    public string? Codigo { get; set; }

    [Column("descripcion")]
    [StringLength(1500)]
    public string? Descripcion { get; set; }

    [Column("nivel")]
    public int? Nivel { get; set; }
}
