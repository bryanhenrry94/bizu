using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSolicitante")]
[Table("com_solicitante")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComSolicitante
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdSolicitante { get; set; }

    [Column("nom_solicitante")]
    [StringLength(50)]
    public string NomSolicitante { get; set; } = null!;

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("cedula")]
    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

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

    [StringLength(150)]
    public string? MotiAnula { get; set; }

    [InverseProperty("ComSolicitante")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("ComSolicitante")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
