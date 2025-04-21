using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdRetencion")]
[Table("cp_retencion")]
[Index("IdEmpresaOgiro", "IdCbteCbleOgiro", "IdTipoCbteOgiro", Name = "FK_cp_retencion_cp_orden_giro")]
[Index("CtIdEmpresaAnu", "CtIdTipoCbteAnu", "CtIdCbteCbleAnu", Name = "FK_cp_retencion_ct_cbtecble")]
[Index("IdEmpresa", "CodDocumentoTipo", "Serie1", "Serie2", "NumRetencion", Name = "FK_cp_retencion_tb_sis_Documento_Tipo_Talonario")]
[Index("IdEmpresa", "Fecha", "Estado", Name = "cp_retencion_IdEmpresa_IDX")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpRetencion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    [StringLength(20)]
    public string? CodDocumentoTipo { get; set; }

    [Column("serie1")]
    [StringLength(3)]
    public string? Serie1 { get; set; }

    [Column("serie2")]
    [StringLength(3)]
    public string? Serie2 { get; set; }

    [StringLength(20)]
    public string? NumRetencion { get; set; }

    [Column("NAutorizacion")]
    [StringLength(50)]
    public string? Nautorizacion { get; set; }

    [Column("Fecha_Autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("fecha")]
    public DateOnly Fecha { get; set; }

    [Column("observacion")]
    public string Observacion { get; set; } = null!;

    [Column("re_Tiene_RTiva")]
    [StringLength(1)]
    public string ReTieneRtiva { get; set; } = null!;

    [Column("re_Tiene_RFuente")]
    [StringLength(1)]
    public string ReTieneRfuente { get; set; } = null!;

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("ct_IdEmpresa_Anu")]
    public int? CtIdEmpresaAnu { get; set; }

    [Column("ct_IdTipoCbte_Anu")]
    public int? CtIdTipoCbteAnu { get; set; }

    [Column("ct_IdCbteCble_Anu")]
    [Precision(18, 0)]
    public decimal? CtIdCbteCbleAnu { get; set; }

    [Column("re_EstaImpresa")]
    [StringLength(1)]
    public string ReEstaImpresa { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotivoAnulacion { get; set; }

    [ForeignKey("IdEmpresaOgiro, IdCbteCbleOgiro, IdTipoCbteOgiro")]
    [InverseProperty("CpRetencion")]
    public virtual CpOrdenGiro? CpOrdenGiro { get; set; }

    [InverseProperty("CpRetencion")]
    public virtual ICollection<CpRetencionDet> CpRetencionDet { get; set; } = new List<CpRetencionDet>();

    [InverseProperty("CpRetencion")]
    public virtual ICollection<CpRetencionXCtCbtecble> CpRetencionXCtCbtecble { get; set; } = new List<CpRetencionXCtCbtecble>();

    [ForeignKey("CtIdEmpresaAnu, CtIdTipoCbteAnu, CtIdCbteCbleAnu")]
    [InverseProperty("CpRetencion")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CpRetencion")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, CodDocumentoTipo, Serie1, Serie2, NumRetencion")]
    [InverseProperty("CpRetencion")]
    public virtual TbSisDocumentoTipoTalonario? TbSisDocumentoTipoTalonario { get; set; }
}
