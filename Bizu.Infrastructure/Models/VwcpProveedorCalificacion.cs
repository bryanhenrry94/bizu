using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpProveedorCalificacion
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    public int? IdCalificacion { get; set; }

    public double? Calificacion { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioModificacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaModificacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAnulacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    public long Liberado { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprobacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAprobacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAprobacion { get; set; }
}
