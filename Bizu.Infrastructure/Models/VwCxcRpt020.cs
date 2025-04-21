using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcRpt020
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Column("cr_Codigo")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrCodigo { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("cr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrEstado { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime CrFechaDocu { get; set; }

    [Column("cr_fechaCobro")]
    [MaxLength(6)]
    public DateTime CrFechaCobro { get; set; }

    [Column("fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    [Column("cb_Valor")]
    public double? CbValor { get; set; }

    public int? IdPeriodo { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime? CbFecha { get; set; }

    [Column("cb_Estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbEstado { get; set; }

    [Column("cb_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbObservacion { get; set; }
}
