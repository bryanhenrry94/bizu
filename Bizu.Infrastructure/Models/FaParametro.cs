using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("fa_parametro")]
[Index("IdEmpresa", "IdCajaDefaultFactura", Name = "FK_fa_parametro_caj_Caja")]
[Index("IdEmpresa", "IdTipoCbteCbleFactura", Name = "FK_fa_parametro_ct_cbtecble_tipo")]
[Index("IdEmpresa", "IdTipoCbteCbleFacturaReverso", Name = "FK_fa_parametro_ct_cbtecble_tipo1")]
[Index("IdEmpresa", "IdTipoCbteCbleFacturaCostoVta", Name = "FK_fa_parametro_ct_cbtecble_tipo2")]
[Index("IdEmpresa", "IdTipoCbteCbleFacturaCostoVtaReverso", Name = "FK_fa_parametro_ct_cbtecble_tipo3")]
[Index("IdEmpresa", "IdTipoCbteCbleNc", Name = "FK_fa_parametro_ct_cbtecble_tipo4")]
[Index("IdEmpresa", "IdTipoCbteCbleNcReverso", Name = "FK_fa_parametro_ct_cbtecble_tipo5")]
[Index("IdEmpresa", "IdTipoCbteCbleNd", Name = "FK_fa_parametro_ct_cbtecble_tipo6")]
[Index("IdEmpresa", "IdTipoCbteCbleNdReverso", Name = "FK_fa_parametro_ct_cbtecble_tipo7")]
[Index("IdEmpresa", "IdCtaCbleXAnticipoCliente", Name = "FK_fa_parametro_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleIva", Name = "FK_fa_parametro_ct_plancta1")]
[Index("IdEmpresa", "PaIdCtaCbleDescuento", Name = "FK_fa_parametro_ct_plancta2")]
[Index("TipoCobroDafaultFactu", Name = "FK_fa_parametro_cxc_cobro_tipo")]
[Index("PaIdTipoNotaNcXAnulacion", Name = "FK_fa_parametro_fa_TipoNota")]
[Index("IdEstadoAprobacion", Name = "FK_fa_parametro_fa_pedido_estadoAprobacion")]
[Index("IdEmpresa", "IdMoviInvenTipoFactura", Name = "FK_fa_parametro_in_movi_inven_tipo")]
[Index("IdEmpresa", "IdMoviInvenTipoDevVta", Name = "FK_fa_parametro_in_movi_inven_tipo1")]
[Index("IdEmpresa", "IdMoviInvenTipoFacturaAnulacion", Name = "FK_fa_parametro_in_movi_inven_tipo2")]
[Index("IdEmpresa", "IdMoviInvenTipoDevVtaAnulacion", Name = "FK_fa_parametro_in_movi_inven_tipo3")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaParametro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("IdMovi_inven_tipo_Factura")]
    public int? IdMoviInvenTipoFactura { get; set; }

    [Column("pa_porc_max_total_item_x_despa_Guia")]
    public double? PaPorcMaxTotalItemXDespaGuia { get; set; }

    [Column("IdMovi_inven_tipo_Dev_Vta")]
    public int? IdMoviInvenTipoDevVta { get; set; }

    [Column("IdMovi_inven_tipo_Factura_Anulacion")]
    public int? IdMoviInvenTipoFacturaAnulacion { get; set; }

    [Column("IdMovi_inven_tipo_Dev_Vta_Anulacion")]
    public int? IdMoviInvenTipoDevVtaAnulacion { get; set; }

    [Column("Tipo_NC_x_DevVta")]
    public int? TipoNcXDevVta { get; set; }

    [Column("IdDepartamento_x_DevVta")]
    public int? IdDepartamentoXDevVta { get; set; }

    [Column("IdTipoCbteCble_Factura")]
    public int? IdTipoCbteCbleFactura { get; set; }

    [Column("IdTipoCbteCble_Factura_Reverso")]
    public int? IdTipoCbteCbleFacturaReverso { get; set; }

    [Column("IdTipoCbteCble_Factura_Costo_VTA")]
    public int? IdTipoCbteCbleFacturaCostoVta { get; set; }

    [Column("IdTipoCbteCble_Factura_Costo_VTA_Reverso")]
    public int? IdTipoCbteCbleFacturaCostoVtaReverso { get; set; }

    [Column("IdTipoCbteCble_NC")]
    public int? IdTipoCbteCbleNc { get; set; }

    [Column("IdTipoCbteCble_NC_Reverso")]
    public int? IdTipoCbteCbleNcReverso { get; set; }

    [Column("IdTipoCbteCble_ND")]
    public int? IdTipoCbteCbleNd { get; set; }

    [Column("IdTipoCbteCble_ND_Reverso")]
    public int? IdTipoCbteCbleNdReverso { get; set; }

    [StringLength(1)]
    public string? SeImprimiGuiaRemiAuto { get; set; }

    public int? NumeroDeItemFact { get; set; }

    [StringLength(20)]
    public string? TipoCobroDafaultFactu { get; set; }

    [Column("IdCaja_Default_Factura")]
    public int? IdCajaDefaultFactura { get; set; }

    [Column("IdCtaCble_x_anticipo_cliente")]
    [StringLength(20)]
    public string? IdCtaCbleXAnticipoCliente { get; set; }

    [Column("pa_IdTipoNota_NC_x_Anulacion")]
    public int? PaIdTipoNotaNcXAnulacion { get; set; }

    [StringLength(1)]
    public string? IdEstadoAprobacion { get; set; }

    [Column("pa_ruta_descarga_xml_fac_elct")]
    [StringLength(500)]
    public string? PaRutaDescargaXmlFacElct { get; set; }

    [Column("File_Reporte_FacturaDiseño")]
    public byte[]? FileReporteFacturaDiseño { get; set; }

    [Column("File_Reporte_Nota_CRED_DEB")]
    public byte[]? FileReporteNotaCredDeb { get; set; }

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    public string? IdCtaCbleIva { get; set; }

    [Column("IdCtaCble_SubTotal_Vtas_x_Default")]
    [StringLength(20)]
    public string? IdCtaCbleSubTotalVtasXDefault { get; set; }

    [Column("IdCtaCble_CXC_Vtas_x_Default")]
    [StringLength(20)]
    public string? IdCtaCbleCxcVtasXDefault { get; set; }

    [Column("pa_X_Defecto_la_factura_es_cbte_elect")]
    public bool? PaXDefectoLaFacturaEsCbteElect { get; set; }

    [Column("pa_X_Defecto_la_guia_es_cbte_elect")]
    public bool? PaXDefectoLaGuiaEsCbteElect { get; set; }

    [Column("pa_X_Defecto_la_ND_es_cbte_elect")]
    public bool? PaXDefectoLaNdEsCbteElect { get; set; }

    [Column("pa_X_Defecto_la_NC_es_cbte_elect")]
    public bool? PaXDefectoLaNcEsCbteElect { get; set; }

    [Column("pa_Contabiliza_descuento")]
    public bool? PaContabilizaDescuento { get; set; }

    [Column("pa_IdCtaCble_descuento")]
    [StringLength(20)]
    public string? PaIdCtaCbleDescuento { get; set; }

    [ForeignKey("IdEmpresa, IdCajaDefaultFactura")]
    [InverseProperty("FaParametro")]
    public virtual CajCaja? CajCaja { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleFactura")]
    [InverseProperty("FaParametroCtCbtecbleTipo")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleFacturaCostoVtaReverso")]
    [InverseProperty("FaParametroCtCbtecbleTipo1")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo1 { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleFacturaReverso")]
    [InverseProperty("FaParametroCtCbtecbleTipo2")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo2 { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleNc")]
    [InverseProperty("FaParametroCtCbtecbleTipo3")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo3 { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleNcReverso")]
    [InverseProperty("FaParametroCtCbtecbleTipo4")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo4 { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleNd")]
    [InverseProperty("FaParametroCtCbtecbleTipo5")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo5 { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleNdReverso")]
    [InverseProperty("FaParametroCtCbtecbleTipo6")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo6 { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleFacturaCostoVta")]
    [InverseProperty("FaParametroCtCbtecbleTipoNavigation")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipoNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleIva")]
    [InverseProperty("FaParametroCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, PaIdCtaCbleDescuento")]
    [InverseProperty("FaParametroCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleXAnticipoCliente")]
    [InverseProperty("FaParametroCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("FaParametro")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoAprobacion")]
    [InverseProperty("FaParametro")]
    public virtual FaPedidoEstadoAprobacion? IdEstadoAprobacionNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoDevVta")]
    [InverseProperty("FaParametroInMoviInvenTipo")]
    public virtual InMoviInvenTipo? InMoviInvenTipo { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoFactura")]
    [InverseProperty("FaParametroInMoviInvenTipo1")]
    public virtual InMoviInvenTipo? InMoviInvenTipo1 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoFacturaAnulacion")]
    [InverseProperty("FaParametroInMoviInvenTipo2")]
    public virtual InMoviInvenTipo? InMoviInvenTipo2 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoDevVtaAnulacion")]
    [InverseProperty("FaParametroInMoviInvenTipoNavigation")]
    public virtual InMoviInvenTipo? InMoviInvenTipoNavigation { get; set; }

    [ForeignKey("PaIdTipoNotaNcXAnulacion")]
    [InverseProperty("FaParametro")]
    public virtual FaTipoNota? PaIdTipoNotaNcXAnulacionNavigation { get; set; }

    [ForeignKey("TipoCobroDafaultFactu")]
    [InverseProperty("FaParametro")]
    public virtual CxcCobroTipo? TipoCobroDafaultFactuNavigation { get; set; }
}
