using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_Menu")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegMenu
{
    [Key]
    public int IdMenu { get; set; }

    public int? IdMenuPadre { get; set; }

    [StringLength(255)]
    public string DescripcionMenu { get; set; } = null!;

    public int PosicionMenu { get; set; }

    public bool Habilitado { get; set; }

    [Column("Tiene_FormularioAsociado")]
    public bool TieneFormularioAsociado { get; set; }

    [Column("nom_Formulario")]
    [StringLength(255)]
    public string NomFormulario { get; set; } = null!;

    [Column("nom_Asembly")]
    [StringLength(200)]
    public string NomAsembly { get; set; } = null!;

    [Column("imagen_grande")]
    public byte[]? ImagenGrande { get; set; }

    [Column("imagen_peque")]
    public byte[]? ImagenPeque { get; set; }

    [Column("icono")]
    public byte[]? Icono { get; set; }

    [Column("nivel")]
    public int? Nivel { get; set; }

    [InverseProperty("IdMenuNavigation")]
    public virtual ICollection<SegMenuXEmpresa> SegMenuXEmpresa { get; set; } = new List<SegMenuXEmpresa>();
}
