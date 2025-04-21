using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaDocumentoDeclaracionSriData
{
    [Precision(21, 0)]
    public decimal IdFila { get; set; }

    [Column("tpIdCliente")]
    [StringLength(2)]
    public string TpIdCliente { get; set; } = null!;

    [Column("idCliente")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCliente { get; set; } = null!;

    [Column("tipoComprobante")]
    [StringLength(2)]
    public string? TipoComprobante { get; set; }

    [Column("numeroComprobantes")]
    public long NumeroComprobantes { get; set; }

    [Column("baseNoGraIva")]
    public double? BaseNoGraIva { get; set; }

    [Column("baseImponible")]
    [Precision(18, 2)]
    public decimal? BaseImponible { get; set; }

    [Column("baseImpGrav")]
    [Precision(18, 2)]
    public decimal? BaseImpGrav { get; set; }

    [Column("montoIva")]
    [Precision(18, 2)]
    public decimal? MontoIva { get; set; }

    public int IdEmpresa { get; set; }

    [Column("anio")]
    public int? Anio { get; set; }

    [Column("mes")]
    public int? Mes { get; set; }

    [Column("Razon_Social")]
    [StringLength(201)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RazonSocial { get; set; } = null!;
}
