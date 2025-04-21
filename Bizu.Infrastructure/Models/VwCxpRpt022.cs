using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt022
{
    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

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

    public int IdSucursal { get; set; }

    [Column("cn_fecha")]
    public DateOnly CnFecha { get; set; }

    [Column("cn_serie1")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnSerie1 { get; set; }

    [Column("cn_serie2")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnSerie2 { get; set; }

    [Column("cn_Nota")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnNota { get; set; }

    [Column("cn_observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CnObservacion { get; set; } = null!;

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCentroCosto { get; set; } = null!;

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCentroCostoSubCentroCosto { get; set; } = null!;

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DcObservacion { get; set; } = null!;

    [Column("nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("nom_sucCentro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSucCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoNota { get; set; } = null!;

    [Column("nom_cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCuenta { get; set; } = null!;

    [Column("cn_subtotal_iva")]
    public double CnSubtotalIva { get; set; }

    [Column("cn_subtotal_siniva")]
    public double CnSubtotalSiniva { get; set; }

    [Column("cn_baseImponible")]
    public double CnBaseImponible { get; set; }

    [Column("cn_total")]
    [Precision(18, 2)]
    public decimal CnTotal { get; set; }
}
