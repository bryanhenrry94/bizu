using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcRpt0192
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodDocumentoTipo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodNota { get; set; } = null!;

    [Column("serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [Column("serie2")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Column("NumNota_Impresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumNotaImpresa { get; set; }

    public double? CobroTotal { get; set; }

    [Column("fechaUltimoCobro")]
    [MaxLength(6)]
    public DateTime? FechaUltimoCobro { get; set; }
}
