using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobrosPendientesDeDeposito
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

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    [StringLength(8)]
    public string? CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    [StringLength(8)]
    public string? CrFechaDocu { get; set; }

    [Column("cr_fechaCobro")]
    [StringLength(8)]
    public string? CrFechaCobro { get; set; }

    [Column("cr_observacion")]
    [StringLength(700)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CrObservacion { get; set; } = null!;

    [Column("cr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrEstado { get; set; }

    [Column("CompCobro_IdTipoCbte")]
    public int CompCobroIdTipoCbte { get; set; }

    [Column("CompCobro_IdCbteCble")]
    [Precision(18, 0)]
    public decimal CompCobroIdCbteCble { get; set; }

    [Column("CompCobro_cb_Fecha")]
    [StringLength(8)]
    public string? CompCobroCbFecha { get; set; }

    [Column("CompCobro_Valor")]
    public double CompCobroValor { get; set; }

    [Column("Deposito_IdTipocbte")]
    public int? DepositoIdTipocbte { get; set; }

    [Column("Deposito_IdCbteCble")]
    [Precision(18, 0)]
    public decimal? DepositoIdCbteCble { get; set; }
}
