using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomSolicitudCompraXOrdenCompra
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocumento { get; set; } = null!;

    [Column("IdPersona_Solicita")]
    [Precision(18, 0)]
    public decimal IdPersonaSolicita { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("plazo")]
    public int Plazo { get; set; }

    [Column("fecha_vtc")]
    [MaxLength(6)]
    public DateTime FechaVtc { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacion { get; set; }

    [Column("nom_EstadoAprobacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoAprobacion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprobo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAprobacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAprobacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Solicitante { get; set; } = null!;
}
