using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenGiroXPagosSaldo
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

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoSerie { get; set; } = null!;

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoFactura { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime CoFechaFacturaVct { get; set; }

    [Column("co_plazo")]
    public int CoPlazo { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_Por_iva")]
    public double CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("IdCod_ICE")]
    public int? IdCodIce { get; set; }

    [Column("co_Ice_base")]
    public double CoIceBase { get; set; }

    [Column("co_Ice_por")]
    public double CoIcePor { get; set; }

    [Column("co_Ice_valor")]
    public double CoIceValor { get; set; }

    [Column("co_Serv_por")]
    public double CoServPor { get; set; }

    [Column("co_Serv_valor")]
    public double CoServValor { get; set; }

    [Column("co_OtroValor_a_descontar")]
    public double CoOtroValorADescontar { get; set; }

    [Column("co_OtroValor_a_Sumar")]
    public double CoOtroValorASumar { get; set; }

    [Column("co_BaseSeguro")]
    public double CoBaseSeguro { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    [Column("SaldoOG")]
    public double SaldoOg { get; set; }

    public double? TotalPagado { get; set; }

    [Column("co_vaCoa")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoVaCoa { get; set; } = null!;

    [Column("IdIden_credito")]
    public int? IdIdenCredito { get; set; }

    [Column("IdCod_101")]
    public int? IdCod101 { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoServicio { get; set; }

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleGasto { get; set; }

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleIva { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("co_retencionManual")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoRetencionManual { get; set; }

    [Column("IdCbteCble_Anulacion")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnulacion { get; set; }

    [Column("IdTipoCbte_Anulacion")]
    public int? IdTipoCbteAnulacion { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;

    public int? IdSucursal { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Sucursal { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoFlujo { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PagoLocExt { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PaisPago { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PagoSujetoRetencion { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ConvenioTributacion { get; set; }

    [Column("co_FechaContabilizacion")]
    [MaxLength(6)]
    public DateTime? CoFechaContabilizacion { get; set; }

    public double? BseImpNoObjDeIva { get; set; }

    [Column("fecha_autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("Num_Autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Column("Num_Autorizacion_Imprenta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacionImprenta { get; set; }

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

    [Column("co_propina")]
    public double CoPropina { get; set; }

    [Column("co_IRBPNR")]
    public double CoIrbpnr { get; set; }

    [Column("Estado_Cancelacion")]
    [StringLength(9)]
    public string? EstadoCancelacion { get; set; }

    [Column("Total_Retencion")]
    public double TotalRetencion { get; set; }

    [Column("cp_es_comprobante_electronico")]
    public bool? CpEsComprobanteElectronico { get; set; }

    [Column("Tipodoc_a_Modificar")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipodocAModificar { get; set; }

    [Column("estable_a_Modificar")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EstableAModificar { get; set; }

    [Column("ptoEmi_a_Modificar")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PtoEmiAModificar { get; set; }

    [Column("num_docu_Modificar")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocuModificar { get; set; }

    [Column("aut_doc_Modificar")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AutDocModificar { get; set; }

    [Column("Tiene_ingresos")]
    public int TieneIngresos { get; set; }

    public int? IdTipoMovi { get; set; }

    [Column("En_conciliacion")]
    public int EnConciliacion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [Column("serie2")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }
}
