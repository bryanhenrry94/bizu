using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_pais")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbPais
{
    [Key]
    [StringLength(10)]
    public string IdPais { get; set; } = null!;

    [StringLength(50)]
    public string CodPais { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Nacionalidad { get; set; } = null!;

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [InverseProperty("IdNacionalidadNavigation")]
    public virtual ICollection<TbContacto> TbContactoIdNacionalidadNavigation { get; set; } = new List<TbContacto>();

    [InverseProperty("IdPaisNavigation")]
    public virtual ICollection<TbContacto> TbContactoIdPaisNavigation { get; set; } = new List<TbContacto>();

    [InverseProperty("IdPaisNavigation")]
    public virtual ICollection<TbProvincia> TbProvincia { get; set; } = new List<TbProvincia>();
}
