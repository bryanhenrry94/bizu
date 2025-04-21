using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_parametros")]
[Index("IdEmpresa", "PaIdBancoCuentaDefaultParaOp", Name = "FK_cp_parametros_ba_Banco_Cuenta")]
[Index("IdEmpresa", "PaTipoCbteOg", Name = "FK_cp_parametros_ct_cbtecble_tipo")]
[Index("IdEmpresa", "PaTipoCbteOgAnulacion", Name = "FK_cp_parametros_ct_cbtecble_tipo1")]
[Index("IdEmpresa", "PaIdTipoCbteXRetencion", Name = "FK_cp_parametros_ct_cbtecble_tipo2")]
[Index("IdEmpresa", "PaIdTipoCbteXAnuRetencion", Name = "FK_cp_parametros_ct_cbtecble_tipo3")]
[Index("IdEmpresa", "PaTipoCbteNc", Name = "FK_cp_parametros_ct_cbtecble_tipo4")]
[Index("IdEmpresa", "PaTipoCbteNcAnulacion", Name = "FK_cp_parametros_ct_cbtecble_tipo5")]
[Index("IdEmpresa", "PaTipoCbteNd", Name = "FK_cp_parametros_ct_cbtecble_tipo6")]
[Index("IdEmpresa", "PaTipoCbteNdAnulacion", Name = "FK_cp_parametros_ct_cbtecble_tipo7")]
[Index("IdEmpresa", "PaTipoCbteParaConciXAntcipo", Name = "FK_cp_parametros_ct_cbtecble_tipo8")]
[Index("IdEmpresa", "PaCtacbleDeudora", Name = "FK_cp_parametros_ct_plancta")]
[Index("IdEmpresa", "PaCtacbleIva", Name = "FK_cp_parametros_ct_plancta1")]
[Index("IdEmpresa", "PaCtacbleProveedoresDefault", Name = "FK_cp_parametros_ct_plancta2")]
[Index("IdEmpresa", "PaCtacbleXRetFteDefault", Name = "FK_cp_parametros_ct_plancta3")]
[Index("IdEmpresa", "PaCtacbleXRetIvaDefault", Name = "FK_cp_parametros_ct_plancta4")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpParametros
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("pa_TipoCbte_OG")]
    public int? PaTipoCbteOg { get; set; }

    [Column("pa_TipoCbte_OG_anulacion")]
    public int? PaTipoCbteOgAnulacion { get; set; }

    [Column("pa_ctacble_deudora")]
    [StringLength(20)]
    public string? PaCtacbleDeudora { get; set; }

    [Column("pa_ctacble_iva")]
    [StringLength(20)]
    public string? PaCtacbleIva { get; set; }

    [Column("pa_ctacble_Proveedores_default")]
    [StringLength(20)]
    public string? PaCtacbleProveedoresDefault { get; set; }

    [Column("pa_IdTipoCbte_x_Retencion")]
    public int? PaIdTipoCbteXRetencion { get; set; }

    [Column("pa_IdTipoCbte_x_Anu_Retencion")]
    public int? PaIdTipoCbteXAnuRetencion { get; set; }

    public int? IdTipoMoviCaja { get; set; }

    [Column("pa_TipoEgrMoviCaja_Conciliacion")]
    public int? PaTipoEgrMoviCajaConciliacion { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("pa_TipoCbte_NC")]
    public int? PaTipoCbteNc { get; set; }

    [Column("pa_TipoCbte_NC_anulacion")]
    public int? PaTipoCbteNcAnulacion { get; set; }

    [Column("pa_obligaOC")]
    [StringLength(1)]
    public string? PaObligaOc { get; set; }

    [Column("pa_TipoCbte_ND")]
    public int? PaTipoCbteNd { get; set; }

    [Column("pa_TipoCbte_ND_anulacion")]
    public int? PaTipoCbteNdAnulacion { get; set; }

    [Column("pa_xsd_de_atsSRI")]
    public byte[]? PaXsdDeAtsSri { get; set; }

    [Column("pa_Formulario103_104")]
    public byte[]? PaFormulario103104 { get; set; }

    [Column("pa_TipoCbte_para_conci_anulacion_x_antcipo")]
    public int? PaTipoCbteParaConciAnulacionXAntcipo { get; set; }

    [Column("pa_TipoCbte_para_conci_x_antcipo")]
    public int? PaTipoCbteParaConciXAntcipo { get; set; }

    [Column("pa_ruta_descarga_xml_fac_elct")]
    [StringLength(500)]
    public string? PaRutaDescargaXmlFacElct { get; set; }

    [Column("pa_ctacble_x_RetIva_default")]
    [StringLength(20)]
    public string? PaCtacbleXRetIvaDefault { get; set; }

    [Column("pa_ctacble_x_RetFte_default")]
    [StringLength(20)]
    public string? PaCtacbleXRetFteDefault { get; set; }

    [Column("archivo_diseño_reporte")]
    public byte[]? ArchivoDiseñoReporte { get; set; }

    [Column("pa_IdBancoCuenta_default_para_OP")]
    public int? PaIdBancoCuentaDefaultParaOp { get; set; }

    [Column("pa_X_Defecto_la_Retencion_es_cbte_elect")]
    public bool? PaXDefectoLaRetencionEsCbteElect { get; set; }

    [Column("pa_ctacble_x_Iva_Gastos_default")]
    [StringLength(20)]
    public string? PaCtacbleXIvaGastosDefault { get; set; }

    [Column("pa_notificacion_archivo_transferencia_auto")]
    public bool? PaNotificacionArchivoTransferenciaAuto { get; set; }

    [Column("pa_valida_existe_retencion")]
    public bool? PaValidaExisteRetencion { get; set; }

    [Column("pa_notificacion_archivo_transferencia")]
    public bool? PaNotificacionArchivoTransferencia { get; set; }

    [ForeignKey("IdEmpresa, PaIdBancoCuentaDefaultParaOp")]
    [InverseProperty("CpParametros")]
    public virtual BaBancoCuenta? BaBancoCuenta { get; set; }

    [ForeignKey("IdEmpresa, PaIdTipoCbteXAnuRetencion")]
    [InverseProperty("CpParametrosCtCbtecbleTipo")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo { get; set; }

    [ForeignKey("IdEmpresa, PaTipoCbteNc")]
    [InverseProperty("CpParametrosCtCbtecbleTipo1")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo1 { get; set; }

    [ForeignKey("IdEmpresa, PaTipoCbteNcAnulacion")]
    [InverseProperty("CpParametrosCtCbtecbleTipo2")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo2 { get; set; }

    [ForeignKey("IdEmpresa, PaTipoCbteNd")]
    [InverseProperty("CpParametrosCtCbtecbleTipo3")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo3 { get; set; }

    [ForeignKey("IdEmpresa, PaTipoCbteNdAnulacion")]
    [InverseProperty("CpParametrosCtCbtecbleTipo4")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo4 { get; set; }

    [ForeignKey("IdEmpresa, PaTipoCbteOg")]
    [InverseProperty("CpParametrosCtCbtecbleTipo5")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo5 { get; set; }

    [ForeignKey("IdEmpresa, PaTipoCbteOgAnulacion")]
    [InverseProperty("CpParametrosCtCbtecbleTipo6")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo6 { get; set; }

    [ForeignKey("IdEmpresa, PaTipoCbteParaConciXAntcipo")]
    [InverseProperty("CpParametrosCtCbtecbleTipo7")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo7 { get; set; }

    [ForeignKey("IdEmpresa, PaIdTipoCbteXRetencion")]
    [InverseProperty("CpParametrosCtCbtecbleTipoNavigation")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipoNavigation { get; set; }

    [ForeignKey("IdEmpresa, PaCtacbleDeudora")]
    [InverseProperty("CpParametrosCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, PaCtacbleProveedoresDefault")]
    [InverseProperty("CpParametrosCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, PaCtacbleXRetFteDefault")]
    [InverseProperty("CpParametrosCtPlancta2")]
    public virtual CtPlancta? CtPlancta2 { get; set; }

    [ForeignKey("IdEmpresa, PaCtacbleXRetIvaDefault")]
    [InverseProperty("CpParametrosCtPlancta3")]
    public virtual CtPlancta? CtPlancta3 { get; set; }

    [ForeignKey("IdEmpresa, PaCtacbleIva")]
    [InverseProperty("CpParametrosCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CpParametros")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
