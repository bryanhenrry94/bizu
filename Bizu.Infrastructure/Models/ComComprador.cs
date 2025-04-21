using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdComprador")]
[Table("com_comprador")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComComprador
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdComprador { get; set; }

    [Column("IdUsuario_com")]
    [StringLength(50)]
    public string? IdUsuarioCom { get; set; }

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(10)]
    public string Estado { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

    [Column("cedula")]
    [StringLength(20)]
    public string? Cedula { get; set; }

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
    public string? MotiAnula { get; set; }

    [InverseProperty("ComComprador")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("ComComprador")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
