using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "HostName")]
[Table("mail_Notificacion_Config")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class MailNotificacionConfig
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string HostName { get; set; } = null!;

    public bool EmiteNotificacion { get; set; }
}
