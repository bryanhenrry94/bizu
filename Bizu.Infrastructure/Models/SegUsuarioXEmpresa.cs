using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdUsuario", "IdEmpresa")]
[Table("seg_Usuario_x_Empresa")]
[Index("IdEmpresa", Name = "FK_seg_Usuario_x_Empresa_tb_empresa")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegUsuarioXEmpresa
{
    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int IdEmpresa { get; set; }

    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("SegUsuarioXEmpresa")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("SegUsuarioXEmpresa")]
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
