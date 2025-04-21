using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCbleNota", "IdTipoCbteNota")]
[Table("cp_nota_DebCre")]
[Index("IdEmpresa", "IdTipoFlujo", Name = "FK_cp_nota_DebCre_ba_TipoFlujo")]
[Index("IdTipoNota", Name = "FK_cp_nota_DebCre_cp_catalogo")]
[Index("IdCodIce", Name = "FK_cp_nota_DebCre_cp_codigo_SRI")]
[Index("IdIdenCredito", Name = "FK_cp_nota_DebCre_cp_codigo_SRI1")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_cp_nota_DebCre_cp_proveedor")]
[Index("IdEmpresa", "IdTipoCbteAnulacion", "IdCbteCbleAnulacion", Name = "FK_cp_nota_DebCre_ct_cbtecble1")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_cp_nota_DebCre_ct_centro_costo")]
[Index("IdEmpresa", "IdCtaCbleAcre", Name = "FK_cp_nota_DebCre_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleIva", Name = "FK_cp_nota_DebCre_ct_plancta1")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_cp_nota_DebCre_tb_sucursal")]
[Index("IdEmpresa", "IdTipoCbteNota", "IdCbteCbleNota", "IdProveedor", Name = "IX_cp_nota_DebCre")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpNotaDebCre
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal IdCbteCbleNota { get; set; }

    [Key]
    [Column("IdTipoCbte_Nota")]
    public int IdTipoCbteNota { get; set; }

    [StringLength(1)]
    public string DebCre { get; set; } = null!;

    [StringLength(25)]
    public string IdTipoNota { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    public int IdSucursal { get; set; }

    [Column("cn_fecha")]
    public DateOnly CnFecha { get; set; }

    [Column("Fecha_contable")]
    public DateOnly? FechaContable { get; set; }

    [Column("cn_Fecha_vcto")]
    public DateOnly CnFechaVcto { get; set; }

    [Column("cn_serie1")]
    [StringLength(10)]
    public string? CnSerie1 { get; set; }

    [Column("cn_serie2")]
    [StringLength(10)]
    public string? CnSerie2 { get; set; }

    [Column("cn_Nota")]
    [StringLength(15)]
    public string? CnNota { get; set; }

    [Column("cn_observacion")]
    [StringLength(500)]
    public string CnObservacion { get; set; } = null!;

    [Column("cn_subtotal_iva")]
    public double CnSubtotalIva { get; set; }

    [Column("cn_subtotal_siniva")]
    public double CnSubtotalSiniva { get; set; }

    [Column("cn_baseImponible")]
    public double CnBaseImponible { get; set; }

    [Column("cn_Por_iva")]
    public double CnPorIva { get; set; }

    [Column("cn_valoriva")]
    public double CnValoriva { get; set; }

    [Column("cn_Ice_base")]
    public double CnIceBase { get; set; }

    [Column("cn_Ice_por")]
    public double CnIcePor { get; set; }

    [Column("cn_Ice_valor")]
    public double CnIceValor { get; set; }

    [Column("cn_Serv_por")]
    public double CnServPor { get; set; }

    [Column("cn_Serv_valor")]
    public double CnServValor { get; set; }

    [Column("cn_BaseSeguro")]
    [Precision(18, 2)]
    public decimal CnBaseSeguro { get; set; }

    [Column("cn_total")]
    [Precision(18, 2)]
    public decimal CnTotal { get; set; }

    [Column("cn_vaCoa")]
    [StringLength(1)]
    public string CnVaCoa { get; set; } = null!;

    [Column("cn_Autorizacion")]
    [StringLength(50)]
    public string? CnAutorizacion { get; set; }

    [Column("cn_Autorizacion_Imprenta")]
    [StringLength(50)]
    public string? CnAutorizacionImprenta { get; set; }

    [Column("cn_num_doc_modificado")]
    [StringLength(50)]
    public string? CnNumDocModificado { get; set; }

    [Column("IdCod_ICE")]
    public int? IdCodIce { get; set; }

    [StringLength(5)]
    public string? IdTipoServicio { get; set; }

    [Column("IdIden_credito")]
    public int? IdIdenCredito { get; set; }

    [Column("IdCtaCble_Acre")]
    [StringLength(20)]
    public string? IdCtaCbleAcre { get; set; }

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    public string? IdCtaCbleIva { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

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
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("IdCbteCble_Anulacion")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnulacion { get; set; }

    [Column("IdTipoCbte_Anulacion")]
    public int? IdTipoCbteAnulacion { get; set; }

    [Column("cn_tipoLocacion")]
    [StringLength(5)]
    public string? CnTipoLocacion { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [StringLength(3)]
    public string? PagoLocExt { get; set; }

    [StringLength(5)]
    public string? PaisPago { get; set; }

    [StringLength(2)]
    public string? ConvenioTributacion { get; set; }

    [StringLength(2)]
    public string? PagoSujetoRetencion { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("fecha_autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("cod_nota")]
    [StringLength(50)]
    public string? CodNota { get; set; }

    [ForeignKey("IdEmpresa, IdTipoFlujo")]
    [InverseProperty("CpNotaDebCre")]
    public virtual BaTipoFlujo? BaTipoFlujo { get; set; }

    [InverseProperty("CpNotaDebCre")]
    public virtual ICollection<CpNotaDebCreImpuesto> CpNotaDebCreImpuesto { get; set; } = new List<CpNotaDebCreImpuesto>();

    [InverseProperty("CpNotaDebCre")]
    public virtual ICollection<CpNotaDebCreXComOrdencompraLocal> CpNotaDebCreXComOrdencompraLocal { get; set; } = new List<CpNotaDebCreXComOrdencompraLocal>();

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("CpNotaDebCre")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteAnulacion, IdCbteCbleAnulacion")]
    [InverseProperty("CpNotaDebCreCtCbtecble")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteNota, IdCbteCbleNota")]
    [InverseProperty("CpNotaDebCreCtCbtecbleNavigation")]
    public virtual CtCbtecble CtCbtecbleNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CpNotaDebCre")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleAcre")]
    [InverseProperty("CpNotaDebCreCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleIva")]
    [InverseProperty("CpNotaDebCreCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdCodIce")]
    [InverseProperty("CpNotaDebCreIdCodIceNavigation")]
    public virtual CpCodigoSri? IdCodIceNavigation { get; set; }

    [ForeignKey("IdIdenCredito")]
    [InverseProperty("CpNotaDebCreIdIdenCreditoNavigation")]
    public virtual CpCodigoSri? IdIdenCreditoNavigation { get; set; }

    [ForeignKey("IdTipoNota")]
    [InverseProperty("CpNotaDebCre")]
    public virtual CpCatalogo IdTipoNotaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CpNotaDebCre")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
