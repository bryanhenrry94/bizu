using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCustodio")]
[Table("caj_custodio")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCustodio
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdCustodio { get; set; }

    public int? IdPersona { get; set; }

    public double? FondoAsignado { get; set; }

    [MaxLength(6)]
    public DateTime? FechaInicioCustodia { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [StringLength(50)]
    public string? IdUsuarioCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(150)]
    public string? MotivoAnulacion { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [InverseProperty("CajCustodio")]
    public virtual ICollection<CajCajachica> CajCajachica { get; set; } = new List<CajCajachica>();

    [InverseProperty("CajCustodio")]
    public virtual ICollection<CajCustodioXCajRubro> CajCustodioXCajRubro { get; set; } = new List<CajCustodioXCajRubro>();
}
