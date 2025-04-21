using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdLiquidacionCompra")]
[Table("cp_liquidacion_compra")]
[Index("IdEmpresa", "IdCbteCbleOgiro", "IdTipoCbteOgiro", Name = "FK_cp_liquidacion_compra_cp_orden_giro")]
[Index("IdEmpresa", "CodDocumentoTipo", "Serie1", "Serie2", "NumDocumento", Name = "FK_cp_liquidacion_compra_tb_sis_Documento_Tipo_Talonario")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpLiquidacionCompra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdLiquidacionCompra { get; set; }

    [StringLength(20)]
    public string? CodDocumentoTipo { get; set; }

    [Column("serie1")]
    [StringLength(3)]
    public string? Serie1 { get; set; }

    [Column("serie2")]
    [StringLength(3)]
    public string? Serie2 { get; set; }

    [StringLength(20)]
    public string? NumDocumento { get; set; }

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

    [Column("cp_EstaImpresa")]
    [StringLength(1)]
    public string CpEstaImpresa { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("CpLiquidacionCompra")]
    public virtual ICollection<CpLiquidacionCompraDet> CpLiquidacionCompraDet { get; set; } = new List<CpLiquidacionCompraDet>();

    [ForeignKey("IdEmpresa, IdCbteCbleOgiro, IdTipoCbteOgiro")]
    [InverseProperty("CpLiquidacionCompra")]
    public virtual CpOrdenGiro? CpOrdenGiro { get; set; }

    [ForeignKey("IdEmpresa, CodDocumentoTipo, Serie1, Serie2, NumDocumento")]
    [InverseProperty("CpLiquidacionCompra")]
    public virtual TbSisDocumentoTipoTalonario? TbSisDocumentoTipoTalonario { get; set; }
}
