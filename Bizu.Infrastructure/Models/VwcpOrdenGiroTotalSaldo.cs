using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenGiroTotalSaldo
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

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

    [Column("co_FechaContabilizacion")]
    [MaxLength(6)]
    public DateTime? CoFechaContabilizacion { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime CoFechaFacturaVct { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    public double TotalPagado { get; set; }

    [Column("SaldoOG")]
    public double SaldoOg { get; set; }

    [Column("Tipodoc_a_Modificar")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipodocAModificar { get; set; }

    [Column("estable_a_Modificar")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EstableAModificar { get; set; }

    [Column("ptoEmi_a_Modificar")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PtoEmiAModificar { get; set; }

    [Column("num_docu_Modificar")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocuModificar { get; set; }

    [Column("aut_doc_Modificar")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AutDocModificar { get; set; }
}
