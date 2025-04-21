using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCbleOgiro", "IdTipoCbteOgiro")]
[Table("cp_orden_giro")]
[Index("IdEmpresa", "IdTipoFlujo", Name = "FK_cp_orden_giro_ba_TipoFlujo")]
[Index("IdTipoMovi", Name = "FK_cp_orden_giro_caj_Caja_Movimiento_Tipo")]
[Index("IdCodIce", Name = "FK_cp_orden_giro_cp_codigo_SRI")]
[Index("IdIdenCredito", Name = "FK_cp_orden_giro_cp_codigo_SRI1")]
[Index("IdCod101", Name = "FK_cp_orden_giro_cp_codigo_SRI2")]
[Index("PaisPago", Name = "FK_cp_orden_giro_cp_pais_sri")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_cp_orden_giro_cp_proveedor")]
[Index("IdEmpresa", "IdTipoCbteOgiro", "IdCbteCbleOgiro", Name = "FK_cp_orden_giro_ct_cbtecble")]
[Index("IdEmpresa", "IdTipoCbteAnulacion", "IdCbteCbleAnulacion", Name = "FK_cp_orden_giro_ct_cbtecble1")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_cp_orden_giro_ct_centro_costo")]
[Index("IdEmpresa", "IdCtaCbleGasto", Name = "FK_cp_orden_giro_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleIva", Name = "FK_cp_orden_giro_ct_plancta1")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_cp_orden_giro_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenGiro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Key]
    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    public string CoSerie { get; set; } = null!;

    [Column("co_factura")]
    [StringLength(50)]
    public string CoFactura { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_FechaContabilizacion")]
    [MaxLength(6)]
    public DateTime? CoFechaContabilizacion { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime CoFechaFacturaVct { get; set; }

    [Column("co_plazo")]
    public int CoPlazo { get; set; }

    [Column("co_observacion")]
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

    [Column("co_vaCoa")]
    [StringLength(1)]
    public string CoVaCoa { get; set; } = null!;

    [Column("IdIden_credito")]
    public int? IdIdenCredito { get; set; }

    [Column("IdCod_101")]
    public int? IdCod101 { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [StringLength(20)]
    public string? IdTipoServicio { get; set; }

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    public string? IdCtaCbleGasto { get; set; }

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    public string? IdCtaCbleIva { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(2)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(150)]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("co_retencionManual")]
    [StringLength(1)]
    public string? CoRetencionManual { get; set; }

    [Column("IdCbteCble_Anulacion")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnulacion { get; set; }

    [Column("IdTipoCbte_Anulacion")]
    public int? IdTipoCbteAnulacion { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    public int? IdSucursal { get; set; }

    [StringLength(3)]
    public string? PagoLocExt { get; set; }

    [StringLength(5)]
    public string? PaisPago { get; set; }

    [StringLength(2)]
    public string? ConvenioTributacion { get; set; }

    [StringLength(2)]
    public string? PagoSujetoRetencion { get; set; }

    public double? BseImpNoObjDeIva { get; set; }

    [Column("fecha_autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("Num_Autorizacion")]
    [StringLength(50)]
    public string? NumAutorizacion { get; set; }

    [Column("Num_Autorizacion_Imprenta")]
    [StringLength(50)]
    public string? NumAutorizacionImprenta { get; set; }

    [Column("co_propina")]
    public double CoPropina { get; set; }

    [Column("co_IRBPNR")]
    public double CoIrbpnr { get; set; }

    [Column("es_retencion_electronica")]
    public bool? EsRetencionElectronica { get; set; }

    [Column("cp_es_comprobante_electronico")]
    public bool? CpEsComprobanteElectronico { get; set; }

    [Column("Tipodoc_a_Modificar")]
    [StringLength(2)]
    public string? TipodocAModificar { get; set; }

    [Column("estable_a_Modificar")]
    [StringLength(3)]
    public string? EstableAModificar { get; set; }

    [Column("ptoEmi_a_Modificar")]
    [StringLength(3)]
    public string? PtoEmiAModificar { get; set; }

    [Column("num_docu_Modificar")]
    [StringLength(50)]
    public string? NumDocuModificar { get; set; }

    [Column("aut_doc_Modificar")]
    [StringLength(100)]
    public string? AutDocModificar { get; set; }

    public int? IdTipoMovi { get; set; }

    [Column("Archivo_PDF")]
    public byte[]? ArchivoPdf { get; set; }

    [ForeignKey("IdEmpresa, IdTipoFlujo")]
    [InverseProperty("CpOrdenGiro")]
    public virtual BaTipoFlujo? BaTipoFlujo { get; set; }

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpAprobacionIngBodXOc> CpAprobacionIngBodXOc { get; set; } = new List<CpAprobacionIngBodXOc>();

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpLiquidacionCompra> CpLiquidacionCompra { get; set; } = new List<CpLiquidacionCompra>();

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpOrdenGiroImpuesto> CpOrdenGiroImpuesto { get; set; } = new List<CpOrdenGiroImpuesto>();

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpOrdenGiroPagosSri> CpOrdenGiroPagosSri { get; set; } = new List<CpOrdenGiroPagosSri>();

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpOrdenGiroXComOrdencompraLocal> CpOrdenGiroXComOrdencompraLocal { get; set; } = new List<CpOrdenGiroXComOrdencompraLocal>();

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpOrdenGiroXComOrdencompraLocalDet> CpOrdenGiroXComOrdencompraLocalDet { get; set; } = new List<CpOrdenGiroXComOrdencompraLocalDet>();

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("CpOrdenGiro")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpReembolso> CpReembolso { get; set; } = new List<CpReembolso>();

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<CpRetencion> CpRetencion { get; set; } = new List<CpRetencion>();

    [ForeignKey("IdEmpresa, IdTipoCbteAnulacion, IdCbteCbleAnulacion")]
    [InverseProperty("CpOrdenGiroCtCbtecble")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteOgiro, IdCbteCbleOgiro")]
    [InverseProperty("CpOrdenGiroCtCbtecbleNavigation")]
    public virtual CtCbtecble CtCbtecbleNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CpOrdenGiro")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleGasto")]
    [InverseProperty("CpOrdenGiroCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleIva")]
    [InverseProperty("CpOrdenGiroCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdCod101")]
    [InverseProperty("CpOrdenGiroIdCod101Navigation")]
    public virtual CpCodigoSri? IdCod101Navigation { get; set; }

    [ForeignKey("IdCodIce")]
    [InverseProperty("CpOrdenGiroIdCodIceNavigation")]
    public virtual CpCodigoSri? IdCodIceNavigation { get; set; }

    [ForeignKey("IdIdenCredito")]
    [InverseProperty("CpOrdenGiroIdIdenCreditoNavigation")]
    public virtual CpCodigoSri? IdIdenCreditoNavigation { get; set; }

    [ForeignKey("IdTipoMovi")]
    [InverseProperty("CpOrdenGiro")]
    public virtual CajCajaMovimientoTipo? IdTipoMoviNavigation { get; set; }

    [ForeignKey("PaisPago")]
    [InverseProperty("CpOrdenGiro")]
    public virtual CpPaisSri? PaisPagoNavigation { get; set; }

    [InverseProperty("CpOrdenGiro")]
    public virtual ICollection<TbComprobantesRecibidos> TbComprobantesRecibidos { get; set; } = new List<TbComprobantesRecibidos>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CpOrdenGiro")]
    public virtual TbSucursal? TbSucursal { get; set; }
}
