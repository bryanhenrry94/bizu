using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_moneda")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbMoneda
{
    [Key]
    public int IdMoneda { get; set; }

    [Column("im_descripcion")]
    [StringLength(50)]
    public string? ImDescripcion { get; set; }

    [Column("im_simbolo")]
    [StringLength(2)]
    public string? ImSimbolo { get; set; }

    [Column("im_nemonico")]
    [StringLength(5)]
    public string? ImNemonico { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }
}
