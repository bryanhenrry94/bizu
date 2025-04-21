using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenGiroConciliadoXFactura
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

    [Column("IdEmpresa_Apro_Ing")]
    public int IdEmpresaAproIng { get; set; }

    [Column("IdAprobacion_Apro_Ing")]
    [Precision(18, 0)]
    public decimal IdAprobacionAproIng { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public int IdEmpresaConciliacion { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nombreProveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreProveedor { get; set; }

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoFactura { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("IdEmpresa_ret")]
    public int? IdEmpresaRet { get; set; }

    [Precision(18, 0)]
    public decimal? IdRetencion { get; set; }

    [Column("re_serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ReSerie { get; set; }

    [Column("re_NumRetencion")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ReNumRetencion { get; set; }

    [Column("re_EstaImpresa")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ReEstaImpresa { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoFlujo { get; set; }

    [Column("IdIden_credito")]
    public int? IdIdenCredito { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Serie { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Serie2 { get; set; } = null!;

    [Column("numDocFactura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocFactura { get; set; } = null!;

    [Column("Num_Autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Column("Num_Autorizacion_Imprenta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacionImprenta { get; set; }

    [Column("co_OtroValor_a_descontar")]
    public double CoOtroValorADescontar { get; set; }

    [Column("co_Por_iva")]
    public double CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("fecha_autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleGasto { get; set; }

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleIva { get; set; }
}
