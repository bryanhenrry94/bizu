using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoria", "IdLinea", "IdGrupo")]
[Table("in_grupo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGrupo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Key]
    public int IdLinea { get; set; }

    [Key]
    public int IdGrupo { get; set; }

    [Column("cod_grupo")]
    [StringLength(50)]
    public string CodGrupo { get; set; } = null!;

    [Column("nom_grupo")]
    [StringLength(150)]
    public string NomGrupo { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("abreviatura")]
    [StringLength(10)]
    public string Abreviatura { get; set; } = null!;

    [Column("observacion")]
    [StringLength(150)]
    public string Observacion { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

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

    [ForeignKey("IdEmpresa, IdCategoria, IdLinea")]
    [InverseProperty("InGrupo")]
    public virtual InLinea InLinea { get; set; } = null!;

    [InverseProperty("InGrupo")]
    public virtual ICollection<InSubgrupo> InSubgrupo { get; set; } = new List<InSubgrupo>();
}
