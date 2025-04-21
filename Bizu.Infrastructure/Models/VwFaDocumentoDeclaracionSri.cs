using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaDocumentoDeclaracionSri
{
    public int IdEmpresa { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtTipoDoc { get; set; } = null!;

    [Column("baseNoGraIva")]
    public double? BaseNoGraIva { get; set; }

    [Column("baseImpGrav")]
    public double? BaseImpGrav { get; set; }

    [Column("baseImponible")]
    public double? BaseImponible { get; set; }

    [Column("montoIva")]
    public double? MontoIva { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("vt_serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie1 { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_NumDocumento")]
    [StringLength(51)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNumDocumento { get; set; }

    [Column("Razon_Social")]
    [StringLength(201)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RazonSocial { get; set; } = null!;
}
