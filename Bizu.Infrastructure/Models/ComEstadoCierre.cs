using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("com_estado_cierre")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComEstadoCierre
{
    [Key]
    [Column("IdEstado_cierre")]
    [StringLength(25)]
    public string IdEstadoCierre { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(25)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(25)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("IdEstadoCierreNavigation")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();

    [InverseProperty("IdEstadoCierreNavigation")]
    public virtual ICollection<ComParametro> ComParametro { get; set; } = new List<ComParametro>();
}
