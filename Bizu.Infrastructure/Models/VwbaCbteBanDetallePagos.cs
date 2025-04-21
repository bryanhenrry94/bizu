using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaCbteBanDetallePagos
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    [Column("pg_MontoAplicado")]
    public double PgMontoAplicado { get; set; }

    [Column("pg_saldoAnterior")]
    public double PgSaldoAnterior { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("IdCbteCble_cbte")]
    [Precision(18, 0)]
    public decimal IdCbteCbleCbte { get; set; }

    [Column("IdTipocbte_cbte")]
    public int IdTipocbteCbte { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Column("NFactura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nfactura { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Proveedor { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? GiraCheque { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CtaProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdCancelacion { get; set; }

    [Column("IdEmpresa_cbte")]
    public int IdEmpresaCbte { get; set; }
}
