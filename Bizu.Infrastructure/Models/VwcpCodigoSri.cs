using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpCodigoSri
{
    public int? IdEmpresa { get; set; }

    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("codigoSRI")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodigoSri { get; set; } = null!;

    [Column("co_codigoBase")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoCodigoBase { get; set; } = null!;

    [Column("co_descripcion")]
    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoDescripcion { get; set; } = null!;

    [Column("co_porRetencion")]
    public double CoPorRetencion { get; set; }

    [Column("co_f_valides_desde")]
    public DateOnly CoFValidesDesde { get; set; }

    [Column("co_f_valides_hasta")]
    public DateOnly CoFValidesHasta { get; set; }

    [Column("co_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoEstado { get; set; } = null!;

    [Column("IdTipoSRI")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoSri { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }
}
