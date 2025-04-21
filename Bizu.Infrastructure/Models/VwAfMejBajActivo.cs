using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfMejBajActivo
{
    public int IdEmpresa { get; set; }

    [Column("Id_Mejora_Baja_Activo")]
    [Precision(18, 0)]
    public decimal IdMejoraBajaActivo { get; set; }

    [Column("Id_Tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipo { get; set; } = null!;

    public int IdActivoFijo { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCompleto { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    public double? ValorActivo { get; set; }

    [Column("Valor_Mej_Baj_Activo")]
    public double? ValorMejBajActivo { get; set; }

    [Column("Compr_Mej_Baj")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ComprMejBaj { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescripcionTecnica { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Motivo { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("IdPeriodo_Inicio_Depr")]
    public int? IdPeriodoInicioDepr { get; set; }
}
