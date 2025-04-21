using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcajCajCaja
{
    public int IdEmpresa { get; set; }

    public int IdCaja { get; set; }

    [Column("ca_Codigo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaCodigo { get; set; } = null!;

    [Column("ca_Descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaDescripcion { get; set; } = null!;

    [Column("ca_Moneda")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaMoneda { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("IdUsuario_Responsable")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioResponsable { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnu { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nombre { get; set; }

    public int? IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int? IdMoneda { get; set; }

    [Column("im_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ImDescripcion { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }
}
