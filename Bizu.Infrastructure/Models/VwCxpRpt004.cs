using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt004
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

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Detalle { get; set; } = null!;

    [Column("num_comprobante")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumComprobante { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    [Column("secuencia")]
    public int? Secuencia { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [Column("dc_Valor")]
    public double? DcValor { get; set; }

    [Column("valor_debe")]
    public double ValorDebe { get; set; }

    [Column("valor_haber")]
    public double ValorHaber { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DcObservacion { get; set; }

    [Column("nom_cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCuenta { get; set; }

    [Column("clave_cuenta")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClaveCuenta { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoCbte { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Codigo { get; set; } = null!;

    [Column("nom_comprobante")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomComprobante { get; set; } = null!;

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("Serie_Ret")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SerieRet { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("Num_Auto_Reten")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutoReten { get; set; }

    [Column("Fecha_Reten")]
    public DateOnly FechaReten { get; set; }

    [Column("Observacion_Reten")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObservacionReten { get; set; } = null!;

    [Column("Tiene_RTIva")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TieneRtiva { get; set; } = null!;

    [Column("Tiene_RTFte")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TieneRtfte { get; set; } = null!;

    [Column("IdTipoCbte_Ret")]
    public int? IdTipoCbteRet { get; set; }

    [Column("IdCbteCble_Ret")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleRet { get; set; }

    [Column("nom_TipoCbte_Ret")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoCbteRet { get; set; }

    [Column("IdEmpresa_Ret")]
    public int? IdEmpresaRet { get; set; }
}
