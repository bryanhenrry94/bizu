using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenPagoDetActiva
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("IdTipo_op")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoOp { get; set; } = null!;

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public int? IdBanco { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdFormaPago { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [Column("Fecha_Pago")]
    public DateOnly FechaPago { get; set; }
}
