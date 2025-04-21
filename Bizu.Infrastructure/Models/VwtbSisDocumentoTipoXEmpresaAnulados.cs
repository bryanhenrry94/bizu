using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbSisDocumentoTipoXEmpresaAnulados
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("anio")]
    public long? Anio { get; set; }

    [Column("mes")]
    public long? Mes { get; set; }

    [StringLength(2)]
    public string CodDocumentoTipo { get; set; } = null!;

    [Column("serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [Column("serie2")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("Documento_ini")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DocumentoIni { get; set; }

    [Column("Documento_fin")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DocumentoFin { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
