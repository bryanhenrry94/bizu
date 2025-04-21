using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt032
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    public int Secuencia { get; set; }

    [Column("IdEmpresa_OGiro")]
    public int IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    public int? IdTipoMovi { get; set; }

    [Column("Valor_a_aplicar")]
    [Precision(18, 2)]
    public decimal ValorAAplicar { get; set; }

    [Column("Tipo_documento")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoDocumento { get; set; }

    [Column("IdEmpresa_OP")]
    public int? IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_OP")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoSerie { get; set; } = null!;

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoFactura { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime CoFechaFacturaVct { get; set; }

    [Column("co_plazo")]
    public int CoPlazo { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Codigo { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("nom_centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }
}
