using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcajMovCajaXCobro
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipocbte { get; set; }

    public int? IdBanco { get; set; }

    public int IdCaja { get; set; }

    [Column("IdCtaCble_TipoCobro")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleTipoCobro { get; set; }

    [Column("IdCtaCble_ban")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCbleBan { get; set; } = null!;

    [Column("IdPeriodo_Caja")]
    public int IdPeriodoCaja { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime CrFechaDocu { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrNumDocumento { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("cm_valor")]
    public double CmValor { get; set; }

    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Column("dc_ValorPago")]
    public double DcValorPago { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Column("nSucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NSucursal { get; set; } = null!;

    [Column("nCliente")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NCliente { get; set; } = null!;

    [Column("Documento_Cobrado")]
    [StringLength(0)]
    public string DocumentoCobrado { get; set; } = null!;

    [Column("IdCtaCble_caja")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCaja { get; set; }
}
