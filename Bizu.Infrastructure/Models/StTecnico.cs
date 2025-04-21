using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdTecnico")]
[Table("st_Tecnico")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class StTecnico
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdTecnico { get; set; }

    [Column("nom_tecnico")]
    [StringLength(50)]
    public string NomTecnico { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("cedula")]
    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaTransaccion { get; set; }

    [StringLength(25)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(25)]
    public string? IdUsuarioUltAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(50)]
    public string? MotivoAnula { get; set; }

    [InverseProperty("StTecnico")]
    public virtual ICollection<StRequerimiento> StRequerimiento { get; set; } = new List<StRequerimiento>();
}
