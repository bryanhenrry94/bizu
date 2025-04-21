using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_dia")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbDia
{
    [Key]
    [Column("idDia")]
    public int IdDia { get; set; }

    [Column("sdia")]
    [StringLength(15)]
    public string? Sdia { get; set; }

    [Column("nemonico")]
    [StringLength(5)]
    public string? Nemonico { get; set; }

    [Column("sdiaIngles")]
    [StringLength(15)]
    public string? SdiaIngles { get; set; }
}
