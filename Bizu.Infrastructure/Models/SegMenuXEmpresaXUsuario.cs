using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "IdMenu")]
[Table("seg_Menu_x_Empresa_x_Usuario")]
[Index("IdEmpresa", "IdMenu", Name = "FK_seg_Menu_x_Empresa_x_Usuario_seg_Menu_x_Empresa")]
[Index("IdUsuario", Name = "FK_seg_Menu_x_Empresa_x_Usuario_seg_usuario")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuXEmpresaXUsuario
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int IdMenu { get; set; }

    public bool Lectura { get; set; }

    public bool Escritura { get; set; }

    public bool Eliminacion { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("SegMenuXEmpresaXUsuario")]
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdMenu")]
    [InverseProperty("SegMenuXEmpresaXUsuario")]
    public virtual SegMenuXEmpresa SegMenuXEmpresa { get; set; } = null!;
}
