using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMensaje")]
[Table("mail_Plantilla_Mensaje")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class MailPlantillaMensaje
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(80)]
    public string IdMensaje { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    [StringLength(10)]
    public string? NotificacionEntrega { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;
}
