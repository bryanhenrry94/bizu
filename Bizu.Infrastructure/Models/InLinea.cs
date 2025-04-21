using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoria", "IdLinea")]
[Table("in_linea")]
[Index("IdLinea", Name = "IX_in_linea")]
[Index("IdCategoria", Name = "IX_in_linea_IdCategoria")]
[Index("IdEmpresa", Name = "IX_in_linea_IdEmpresa")]
[Index("NomLinea", Name = "IX_in_linea_nom_linea")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InLinea
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Key]
    public int IdLinea { get; set; }

    [Column("cod_linea")]
    [StringLength(50)]
    public string CodLinea { get; set; } = null!;

    [Column("nom_linea")]
    [StringLength(150)]
    public string NomLinea { get; set; } = null!;

    [Column("abreviatura")]
    [StringLength(10)]
    public string Abreviatura { get; set; } = null!;

    [Column("observacion")]
    [StringLength(150)]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

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

    [ForeignKey("IdEmpresa, IdCategoria")]
    [InverseProperty("InLinea")]
    public virtual InCategorias InCategorias { get; set; } = null!;

    [InverseProperty("InLinea")]
    public virtual ICollection<InGrupo> InGrupo { get; set; } = new List<InGrupo>();

    [InverseProperty("InLinea")]
    public virtual ICollection<InInvRpt026> InInvRpt026 { get; set; } = new List<InInvRpt026>();
}
