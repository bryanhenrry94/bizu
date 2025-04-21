using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("Af_Tipo_Depreciacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfTipoDepreciacion
{
    [Key]
    public int IdTipoDepreciacion { get; set; }

    [Column("cod_tipo_depreciacion")]
    [StringLength(20)]
    public string? CodTipoDepreciacion { get; set; }

    [Column("nom_tipo_depreciacion")]
    [StringLength(150)]
    public string? NomTipoDepreciacion { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string? Estado { get; set; }

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

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(100)]
    public string? MotiAnula { get; set; }

    [InverseProperty("IdTipoDepreciacionNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("IdTipoDepreciacionNavigation")]
    public virtual ICollection<AfDepreciacion> AfDepreciacion { get; set; } = new List<AfDepreciacion>();
}
