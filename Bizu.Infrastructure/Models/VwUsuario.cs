using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwUsuario
{
    public int IdEmpresa { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    public int IdPersona { get; set; }

    [StringLength(0)]
    public string CodPersona { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeNombreCompleto { get; set; }

    [Column("pe_razonSocial")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeRazonSocial { get; set; }

    [Column("pe_apellido")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeApellido { get; set; }

    [Column("pe_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeNombre { get; set; }

    [Column("estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }
}
