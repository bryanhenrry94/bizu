using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCajRpt003
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCedulaRuc { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoDocumento { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(8)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("Num_Autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoSerie { get; set; }

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoFactura { get; set; }

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    public int IdCaja { get; set; }

    [Column("ca_Descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaDescripcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    public int IdTipoMovi { get; set; }

    [Column("tm_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmDescripcion { get; set; } = null!;

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("co_Serv_valor")]
    public double CoServValor { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    [Precision(18, 0)]
    public decimal? IdRetencion { get; set; }

    [Column("serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("NAutorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nautorizacion { get; set; }

    [Column("re_tipoRet_RF")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ReTipoRetRf { get; set; }

    [Column("re_baseRetencion_RF")]
    public double? ReBaseRetencionRf { get; set; }

    [Column("re_Porcen_retencion_RF")]
    public double? RePorcenRetencionRf { get; set; }

    [Column("re_valor_retencion_RF")]
    public double? ReValorRetencionRf { get; set; }

    [Column("re_tipoRet_RIVA")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ReTipoRetRiva { get; set; }

    [Column("re_baseRetencion_RIVA")]
    public double? ReBaseRetencionRiva { get; set; }

    [Column("re_Porcen_retencion_RIVA")]
    public double? RePorcenRetencionRiva { get; set; }

    [Column("re_valor_retencion_RIVA")]
    public double? ReValorRetencionRiva { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeNombreCompleto { get; set; }

    [Column("pe_razonSocial")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeRazonSocial { get; set; }

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeApellido { get; set; }

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeNombre { get; set; }

    public int IdPeriodo { get; set; }

    public int IdanioFiscal { get; set; }

    [Column("pe_mes")]
    public int PeMes { get; set; }

    [Column("smes")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Smes { get; set; } = null!;

    [Column("pe_FechaIni")]
    [MaxLength(6)]
    public DateTime? PeFechaIni { get; set; }

    [Column("pe_FechaFin")]
    [MaxLength(6)]
    public DateTime? PeFechaFin { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCierre { get; set; } = null!;

    [Column(TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("Saldo_cont_al_periodo")]
    public double SaldoContAlPeriodo { get; set; }

    public double Ingresos { get; set; }

    [Column("Total_Ing")]
    public double TotalIng { get; set; }

    [Column("Total_fact_vale")]
    public double TotalFactVale { get; set; }

    [Column("Total_fondo")]
    public double TotalFondo { get; set; }

    [Column("Dif_x_pagar_o_cobrar")]
    public double DifXPagarOCobrar { get; set; }

    [Column("co_OtroValor_a_descontar")]
    public double? CoOtroValorADescontar { get; set; }
}
