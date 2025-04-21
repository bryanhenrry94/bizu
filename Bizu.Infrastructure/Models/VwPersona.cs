using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwPersona
{
    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("Nombre_Completo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCompleto { get; set; } = null!;

    [Column("Razon_Social")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? RazonSocial { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Apellido { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nombre { get; set; } = null!;

    [Column("Cedula_Ruc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CedulaRuc { get; set; } = null!;

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Direccion { get; set; } = null!;

    [Column("Tel_Casa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TelCasa { get; set; }

    [Column("Tel_Oficina")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TelOficina { get; set; }

    [Column("Tel_Internacional")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TelInternacional { get; set; }

    [Column("Tel_Contacto")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TelContacto { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Celular { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Correo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Fax { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Casilla { get; set; }

    [Column("Fecha_Nacimiento")]
    [MaxLength(6)]
    public DateTime? FechaNacimiento { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Creacion")]
    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }
}
