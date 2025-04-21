using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMenu")]
[Table("seg_Menu_x_Empresa")]
[Index("IdMenu", Name = "FK_seg_Menu_x_Empresa_seg_Menu")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenuXEmpresa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMenu { get; set; }

    public bool Habilitado { get; set; }

    [Column("NombreAsambly_x_Emp")]
    [StringLength(200)]
    public string NombreAsamblyXEmp { get; set; } = null!;

    [Column("NomFormulario_x_Emp")]
    [StringLength(200)]
    public string NomFormularioXEmp { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("SegMenuXEmpresa")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdMenu")]
    [InverseProperty("SegMenuXEmpresa")]
    public virtual SegMenu IdMenuNavigation { get; set; } = null!;

    [InverseProperty("SegMenuXEmpresa")]
    public virtual ICollection<SegMenuXEmpresaXUsuario> SegMenuXEmpresaXUsuario { get; set; } = new List<SegMenuXEmpresaXUsuario>();
}
