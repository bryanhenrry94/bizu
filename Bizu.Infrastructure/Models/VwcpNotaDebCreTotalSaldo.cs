using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpNotaDebCreTotalSaldo
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal IdCbteCbleNota { get; set; }

    [Column("IdTipoCbte_Nota")]
    public int IdTipoCbteNota { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DebCre { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("cn_fecha")]
    public DateOnly CnFecha { get; set; }

    [Column("serie")]
    [StringLength(23)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [Column("cn_Nota")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnNota { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("Fecha_contable")]
    public DateOnly? FechaContable { get; set; }

    [Column("cn_Fecha_vcto")]
    public DateOnly CnFechaVcto { get; set; }

    [Column("cn_observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CnObservacion { get; set; } = null!;

    [Column("cn_total")]
    [Precision(18, 2)]
    public decimal CnTotal { get; set; }

    [Column("valorpagar")]
    [Precision(18, 2)]
    public decimal Valorpagar { get; set; }

    public double TotalPagado { get; set; }

    [Column("SaldoOG")]
    public double SaldoOg { get; set; }
}
