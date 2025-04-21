using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_codigo_SRI_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCodigoSriTipo
{
    [Key]
    [Column("IdTipoSRI")]
    [StringLength(20)]
    public string IdTipoSri { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }

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

    [Column("estado")]
    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [InverseProperty("IdTipoSriNavigation")]
    public virtual ICollection<CpCodigoSri> CpCodigoSri { get; set; } = new List<CpCodigoSri>();
}
