using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Mensajes_sys")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisMensajesSys
{
    [Precision(18, 0)]
    public decimal IdSecuencia { get; set; }

    [Key]
    [StringLength(80)]
    public string IdMensaje { get; set; } = null!;

    [Column("Mensaje_Esp")]
    [StringLength(500)]
    public string MensajeEsp { get; set; } = null!;

    [Column("Mensaje_Englesh")]
    [StringLength(500)]
    public string MensajeEnglesh { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;
}
