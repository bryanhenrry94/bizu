using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbTransportistaXTbPersona
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdTransportista { get; set; }

    public int IdPersona { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeNombreCompleto { get; set; }

    [Column("pe_cedulaRuc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCedulaRuc { get; set; }
}
