using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_iconos")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisIconos
{
    [Key]
    [StringLength(150)]
    public string IdIcono { get; set; } = null!;

    public byte[] Icono { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(250)]
    public string Descripcion { get; set; } = null!;

    [StringLength(250)]
    public string Extencion { get; set; } = null!;

    [StringLength(250)]
    public string FullName { get; set; } = null!;

    [Precision(18, 0)]
    public decimal Length { get; set; }

    [StringLength(250)]
    public string DirectoryName { get; set; } = null!;
}
