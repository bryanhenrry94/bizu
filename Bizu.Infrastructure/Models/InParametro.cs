using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("in_parametro")]
[Index("IdEmpresa", "IdCentroCostoCosto", Name = "FK_in_parametro_ct_centro_costo")]
[Index("IdEmpresa", "IdCentroCostoInventario", Name = "FK_in_parametro_ct_centro_costo1")]
[Index("IdEmpresa", "IdCtaCbleInven", Name = "FK_in_parametro_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleCostoInven", Name = "FK_in_parametro_ct_plancta1")]
[Index("IdEmpresa", "PIdCtaCbleTransitoriaTransfInven", Name = "FK_in_parametro_ct_plancta2")]
[Index("PAlContaCtaInvenBuscarEn", Name = "FK_in_parametro_in_Catalogo")]
[Index("PAlContaCtaCostoBuscarEn", Name = "FK_in_parametro_in_Catalogo1")]
[Index("IdEstadoAprobaXIng", Name = "FK_in_parametro_in_Ing_Egr_Inven_estado_apro")]
[Index("IdEstadoAprobaXEgr", Name = "FK_in_parametro_in_Ing_Egr_Inven_estado_apro1")]
[Index("IdEmpresa", "IdMoviInvenTipoXAnuIng", Name = "FK_in_parametro_in_movi_inven_tipo")]
[Index("IdEmpresa", "IdMoviInvenTipoXAnuEgr", Name = "FK_in_parametro_in_movi_inven_tipo1")]
[Index("IdEmpresa", "IdMoviInvenTipoEgresoBodegaOrigen", Name = "FK_in_parametro_in_movi_inven_tipo3")]
[Index("IdEmpresa", "IdMoviInvenTipoIngresoAjuste", Name = "FK_in_parametro_in_movi_inven_tipo4")]
[Index("IdEmpresa", "IdMoviInvenTipoEgresoAjuste", Name = "FK_in_parametro_in_movi_inven_tipo5")]
[Index("IdEmpresa", "IdMoviInvenTipoXDevInvXIng", Name = "FK_in_parametro_in_movi_inven_tipo6")]
[Index("IdEmpresa", "IdMoviInvenTipoXDevInvXErg", Name = "FK_in_parametro_in_movi_inven_tipo7")]
[Index("IdEmpresa", "IdMoviInvenTipoIngObra", Name = "FK_in_parametro_in_movi_inven_tipo8")]
[Index("IdEmpresa", "IdMoviInvenTipoEgrObra", Name = "FK_in_parametro_in_movi_inven_tipo9")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InParametro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("IdCentroCosto_Padre_a_cargar")]
    [StringLength(20)]
    public string? IdCentroCostoPadreACargar { get; set; }

    [StringLength(20)]
    public string? LabelCentroCosto { get; set; }

    [Column("IdMovi_inven_tipo_egresoBodegaOrigen")]
    public int? IdMoviInvenTipoEgresoBodegaOrigen { get; set; }

    [Column("IdMovi_inven_tipo_ingresoBodegaDestino")]
    public int? IdMoviInvenTipoIngresoBodegaDestino { get; set; }

    [Column("Maneja_Stock_Negativo")]
    [StringLength(1)]
    public string? ManejaStockNegativo { get; set; }

    [Column("Usuario_Escoge_Motivo")]
    [StringLength(1)]
    public string? UsuarioEscogeMotivo { get; set; }

    [Column("IdMovi_inven_tipo_egresoAjuste")]
    public int? IdMoviInvenTipoEgresoAjuste { get; set; }

    [Column("IdMovi_inven_tipo_ingresoAjuste")]
    public int? IdMoviInvenTipoIngresoAjuste { get; set; }

    [Column("Mostrar_CentroCosto_en_transacciones")]
    [StringLength(1)]
    public string? MostrarCentroCostoEnTransacciones { get; set; }

    [Column("Rango_Busqueda_Transacciones")]
    public int? RangoBusquedaTransacciones { get; set; }

    [Column("pa_EstadoInicial_Pedido")]
    [StringLength(5)]
    public string? PaEstadoInicialPedido { get; set; }

    [Column("IdCtaCble_Inven")]
    [StringLength(20)]
    public string? IdCtaCbleInven { get; set; }

    [Column("IdCtaCble_CostoInven")]
    [StringLength(20)]
    public string? IdCtaCbleCostoInven { get; set; }

    [Column("IdTipoCbte_CostoInven")]
    public int? IdTipoCbteCostoInven { get; set; }

    public int? IdBodegaSuministro { get; set; }

    [Column("IdCentro_Costo_Inventario")]
    [StringLength(20)]
    public string? IdCentroCostoInventario { get; set; }

    [Column("IdCentro_Costo_Costo")]
    [StringLength(20)]
    public string? IdCentroCostoCosto { get; set; }

    [Column("IdTipoCbte_CostoInven_Reverso")]
    public int? IdTipoCbteCostoInvenReverso { get; set; }

    [Column("IdMovi_Inven_tipo_x_anu_Ing")]
    public int? IdMoviInvenTipoXAnuIng { get; set; }

    [Column("IdMovi_Inven_tipo_x_anu_Egr")]
    public int? IdMoviInvenTipoXAnuEgr { get; set; }

    [Column("IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa")]
    public int? IdMoviInvenTipoIngAjustFisXDefa { get; set; }

    [Column("IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa")]
    public int? IdMoviInvenTipoEgrAjustFisXDefa { get; set; }

    [Column("IdMovi_Inven_tipo_Ing_Obra")]
    public int? IdMoviInvenTipoIngObra { get; set; }

    [Column("IdMovi_Inven_tipo_Egr_Obra")]
    public int? IdMoviInvenTipoEgrObra { get; set; }

    [StringLength(1)]
    public string? ApruebaAjusteFisicoAuto { get; set; }

    [Column("IdSucursal_Suministro")]
    public int? IdSucursalSuministro { get; set; }

    [Column("IdEstadoAproba_x_Ing")]
    [StringLength(15)]
    public string? IdEstadoAprobaXIng { get; set; }

    [Column("IdEstadoAproba_x_Egr")]
    [StringLength(15)]
    public string? IdEstadoAprobaXEgr { get; set; }

    [Column("IdMovi_Inven_tipo_x_Dev_Inv_x_Ing")]
    public int? IdMoviInvenTipoXDevInvXIng { get; set; }

    [Column("IdMovi_Inven_tipo_x_Dev_Inv_x_Erg")]
    public int? IdMoviInvenTipoXDevInvXErg { get; set; }

    [Column("P_Grabar_Items_x_Cada_Movi_Inven")]
    public bool? PGrabarItemsXCadaMoviInven { get; set; }

    [Column("P_Fecha_para_contabilizacion_ingr_egr")]
    [StringLength(20)]
    public string? PFechaParaContabilizacionIngrEgr { get; set; }

    [Column("P_se_valida_parametrizacion_x_producto")]
    public bool? PSeValidaParametrizacionXProducto { get; set; }

    [Column("P_Al_Conta_CtaInven_Buscar_en")]
    [StringLength(15)]
    public string? PAlContaCtaInvenBuscarEn { get; set; }

    [Column("P_Al_Conta_CtaCosto_Buscar_en")]
    [StringLength(15)]
    public string? PAlContaCtaCostoBuscarEn { get; set; }

    [Column("P_IdCtaCble_transitoria_transf_inven")]
    [StringLength(20)]
    public string? PIdCtaCbleTransitoriaTransfInven { get; set; }

    [Column("pa_ruta_descarga_xml_guia_elct")]
    [StringLength(500)]
    public string? PaRutaDescargaXmlGuiaElct { get; set; }

    [Column("Genera_Mov_Inv_x_GuiaRemision")]
    public bool? GeneraMovInvXGuiaRemision { get; set; }

    [Column("IdMovi_Inven_tipo_x_GuiaRemision")]
    public int? IdMoviInvenTipoXGuiaRemision { get; set; }

    [Column("IdMovi_Inven_tipo_x_Anulacion_GuiaRemision")]
    public int? IdMoviInvenTipoXAnulacionGuiaRemision { get; set; }

    [Column("IdMotivo_Inv_x_GuiaRemision")]
    public int? IdMotivoInvXGuiaRemision { get; set; }

    [Column("IdMotivo_Inv_x_Anulacion_GuiaRemision")]
    public int? IdMotivoInvXAnulacionGuiaRemision { get; set; }

    [Column("P_Maneja_Lote")]
    public bool? PManejaLote { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoCosto")]
    [InverseProperty("InParametroCtCentroCosto")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoInventario")]
    [InverseProperty("InParametroCtCentroCostoNavigation")]
    public virtual CtCentroCosto? CtCentroCostoNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCostoInven")]
    [InverseProperty("InParametroCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, PIdCtaCbleTransitoriaTransfInven")]
    [InverseProperty("InParametroCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleInven")]
    [InverseProperty("InParametroCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEstadoAprobaXEgr")]
    [InverseProperty("InParametroIdEstadoAprobaXEgrNavigation")]
    public virtual InIngEgrInvenEstadoApro? IdEstadoAprobaXEgrNavigation { get; set; }

    [ForeignKey("IdEstadoAprobaXIng")]
    [InverseProperty("InParametroIdEstadoAprobaXIngNavigation")]
    public virtual InIngEgrInvenEstadoApro? IdEstadoAprobaXIngNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoEgrObra")]
    [InverseProperty("InParametroInMoviInvenTipo")]
    public virtual InMoviInvenTipo? InMoviInvenTipo { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoEgresoBodegaOrigen")]
    [InverseProperty("InParametroInMoviInvenTipo1")]
    public virtual InMoviInvenTipo? InMoviInvenTipo1 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoIngObra")]
    [InverseProperty("InParametroInMoviInvenTipo2")]
    public virtual InMoviInvenTipo? InMoviInvenTipo2 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoIngresoAjuste")]
    [InverseProperty("InParametroInMoviInvenTipo3")]
    public virtual InMoviInvenTipo? InMoviInvenTipo3 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoXAnuEgr")]
    [InverseProperty("InParametroInMoviInvenTipo4")]
    public virtual InMoviInvenTipo? InMoviInvenTipo4 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoXAnuIng")]
    [InverseProperty("InParametroInMoviInvenTipo5")]
    public virtual InMoviInvenTipo? InMoviInvenTipo5 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoXDevInvXErg")]
    [InverseProperty("InParametroInMoviInvenTipo6")]
    public virtual InMoviInvenTipo? InMoviInvenTipo6 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoXDevInvXIng")]
    [InverseProperty("InParametroInMoviInvenTipo7")]
    public virtual InMoviInvenTipo? InMoviInvenTipo7 { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipoEgresoAjuste")]
    [InverseProperty("InParametroInMoviInvenTipoNavigation")]
    public virtual InMoviInvenTipo? InMoviInvenTipoNavigation { get; set; }

    [ForeignKey("PAlContaCtaCostoBuscarEn")]
    [InverseProperty("InParametroPAlContaCtaCostoBuscarEnNavigation")]
    public virtual InCatalogo? PAlContaCtaCostoBuscarEnNavigation { get; set; }

    [ForeignKey("PAlContaCtaInvenBuscarEn")]
    [InverseProperty("InParametroPAlContaCtaInvenBuscarEnNavigation")]
    public virtual InCatalogo? PAlContaCtaInvenBuscarEnNavigation { get; set; }
}
