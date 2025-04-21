using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdMoviInvenTipo", "IdNumMovi")]
[Table("in_Ing_Egr_Inven")]
[Index("IdEmpresa", "IdMotivoOc", Name = "FK_in_Ing_Egr_Inven_com_Motivo_Orden_Compra")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_in_Ing_Egr_Inven_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdMotivoInv", Name = "FK_in_Ing_Egr_Inven_in_Motivo_Inven")]
[Index("Estado", "IdEmpresa", "IdSucursal", "IdMoviInvenTipo", "IdNumMovi", Name = "in_Ing_Egr_Inven_estado_index")]
[Index("IdEmpresa", "IdSucursal", "Signo", "Estado", "IdMoviInvenTipo", "IdNumMovi", Name = "vwin_producto_x_tb_bodega_Lote_Index3")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InIngEgrInven
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    public int? IdBodega { get; set; }

    [Column("signo")]
    [StringLength(1)]
    public string Signo { get; set; } = null!;

    [StringLength(25)]
    public string CodMoviInven { get; set; } = null!;

    [Column("cm_observacion")]
    [StringLength(1000)]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [Column("IdMotivo_oc")]
    public int? IdMotivoOc { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdusuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(30)]
    public string? Ip { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Precision(18, 0)]
    public decimal? IdResponsable { get; set; }

    [Column("numGuia")]
    [StringLength(50)]
    public string? NumGuia { get; set; }

    public bool? EsDocumentoAutorizado { get; set; }

    [Column("numDocumento")]
    [StringLength(50)]
    public string? NumDocumento { get; set; }

    [ForeignKey("IdEmpresa, IdMotivoOc")]
    [InverseProperty("InIngEgrInven")]
    public virtual ComMotivoOrdenCompra? ComMotivoOrdenCompra { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("InIngEgrInven")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("InIngEgrInven")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [InverseProperty("InIngEgrInven")]
    public virtual ICollection<FaFacturaXInIngEgrInven> FaFacturaXInIngEgrInven { get; set; } = new List<FaFacturaXInIngEgrInven>();

    [InverseProperty("InIngEgrInven")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("InIngEgrInven")]
    public virtual ICollection<InIngEgrInvenXInGuiaRemision> InIngEgrInvenXInGuiaRemision { get; set; } = new List<InIngEgrInvenXInGuiaRemision>();

    [InverseProperty("InIngEgrInven")]
    public virtual InIngEgrInvenXInRequerimientoMaterial? InIngEgrInvenXInRequerimientoMaterial { get; set; }

    [ForeignKey("IdEmpresa, IdMotivoInv")]
    [InverseProperty("InIngEgrInven")]
    public virtual InMotivoInven? InMotivoInven { get; set; }

    [InverseProperty("InIngEgrInven")]
    public virtual ICollection<InTransferencia> InTransferenciaInIngEgrInven { get; set; } = new List<InTransferencia>();

    [InverseProperty("InIngEgrInvenNavigation")]
    public virtual ICollection<InTransferencia> InTransferenciaInIngEgrInvenNavigation { get; set; } = new List<InTransferencia>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("InIngEgrInven")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;

    [ForeignKey("InIdEmpresa, InIdSucursal, InIdMoviInvenTipo, InIdNumMovi")]
    [InverseProperty("InIngEgrInven")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();
}
