using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Log_Error_Vzen")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisLogErrorVzen
{
    [Key]
    [Precision(18, 0)]
    public decimal Id { get; set; }

    [Column("Fecha_Trans", TypeName = "timestamp")]
    public DateTime? FechaTrans { get; set; }

    public string? Detalle { get; set; }

    public string? Tipo { get; set; }

    public string? Clase { get; set; }

    public string? Pantalla { get; set; }

    public string? Asamble { get; set; }

    [StringLength(50)]
    public string? Usuario { get; set; }

    [StringLength(50)]
    public string? Ip { get; set; }

    [Column("PC")]
    [StringLength(50)]
    public string? Pc { get; set; }
}
