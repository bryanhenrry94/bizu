using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("com_TerminoPago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComTerminoPago
{
    [Key]
    [StringLength(25)]
    public string IdTerminoPago { get; set; } = null!;

    [StringLength(500)]
    public string Descripcion { get; set; } = null!;

    public int Dias { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(50)]
    public string? MotiAnula { get; set; }

    [InverseProperty("IdTerminoPagoNavigation")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();
}
