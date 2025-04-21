using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdMail")]
[Table("mail_Mail")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class MailMail
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdMail { get; set; }

    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [StringLength(10)]
    public string? Origen { get; set; }

    [StringLength(150)]
    public string? Asunto { get; set; }

    public string? Mensaje { get; set; }

    public bool? IsBodyHtml { get; set; }

    [StringLength(250)]
    public string? Para { get; set; }

    [Column("CC")]
    [StringLength(250)]
    public string? Cc { get; set; }

    [StringLength(500)]
    public string? MensajeError { get; set; }

    [InverseProperty("MailMail")]
    public virtual ICollection<MailMailAttachment> MailMailAttachment { get; set; } = new List<MailMailAttachment>();
}
