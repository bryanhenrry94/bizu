using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("Secuencia", "IdEmpresa", "IdSucursal", "IdMail")]
[Table("mail_Mail_Attachment")]
[Index("IdEmpresa", "IdSucursal", "IdMail", Name = "mail_Mail_idx")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class MailMailAttachment
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdMail { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("nombre")]
    [StringLength(45)]
    public string Nombre { get; set; } = null!;

    [Column("archivo")]
    public byte[] Archivo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdMail")]
    [InverseProperty("MailMailAttachment")]
    public virtual MailMail MailMail { get; set; } = null!;
}
