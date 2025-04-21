using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt028
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public int IdCaja { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCierre { get; set; } = null!;

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("IdTipo_op")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoOp { get; set; } = null!;

    [Column("Fecha_OP")]
    [MaxLength(6)]
    public DateTime FechaOp { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SubCentroCosto { get; set; } = null!;

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CentroCosto { get; set; } = null!;

    [Column("Observacion_OP")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObservacionOp { get; set; } = null!;
}
