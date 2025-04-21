using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaMoviCajaDepositados
{
    public long? IdEmpresa { get; set; }

    public long? IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCobroTipo { get; set; }

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime? CrFecha { get; set; }

    [Column("cr_fechaCobro")]
    [MaxLength(6)]
    public DateTime? CrFechaCobro { get; set; }

    [Column("cr_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrObservacion { get; set; }

    [Column("cr_Banco")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrBanco { get; set; }

    [Column("cr_cuenta")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrCuenta { get; set; }

    [Column("cr_Tarjeta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrTarjeta { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrNumDocumento { get; set; }

    [Column("cr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrEstado { get; set; }

    [Column("cr_recibo")]
    [Precision(18, 0)]
    public decimal? CrRecibo { get; set; }

    [Column("nSucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NSucursal { get; set; }

    [Column("nCliente", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NCliente { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime? CrFechaDocu { get; set; }

    public int IdCaja { get; set; }

    [Column("ca_Descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaDescripcion { get; set; } = null!;

    public int IdTipoMovi { get; set; }

    [Column("tm_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmDescripcion { get; set; } = null!;

    [Column("tm_Signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmSigno { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("IdCbteCble_MoviCaja")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMoviCaja { get; set; }

    [Column("IdTipocbte_MoviCaja")]
    public int IdTipocbteMoviCaja { get; set; }

    [Column("IdEmpresa_MoviBan")]
    public int IdEmpresaMoviBan { get; set; }

    [Column("IdCbteCble_MoviBan")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMoviBan { get; set; }

    [Column("IdTipocbte_MoviBan")]
    public int IdTipocbteMoviBan { get; set; }

    [Column("mcj_Secuencia")]
    public int McjSecuencia { get; set; }
}
