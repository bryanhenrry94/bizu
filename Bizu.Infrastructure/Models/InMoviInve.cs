using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdNumMovi")]
[Table("in_movi_inve")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_in_movi_inve_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_in_movi_inve_ct_plancta")]
[Index("IdEstadoDespachoCat", Name = "FK_in_movi_inve_in_Catalogo")]
[Index("IdEmpresa", "IdMotivoInv", Name = "FK_in_movi_inve_in_Motivo_Inven")]
[Index("IdEmpresaXAnu", "IdSucursalXAnu", "IdBodegaXAnu", "IdMoviInvenTipoXAnu", "IdNumMoviXAnu", Name = "FK_in_movi_inve_in_movi_inve")]
[Index("IdEmpresa", "IdMoviInvenTipo", Name = "FK_in_movi_inve_in_movi_inven_tipo")]
[Index("CmMes", Name = "FK_in_movi_inve_tb_mes")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInve
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [StringLength(25)]
    public string CodMoviInven { get; set; } = null!;

    [Column("cm_tipo")]
    [StringLength(1)]
    public string CmTipo { get; set; } = null!;

    [Column("cm_observacion")]
    [StringLength(1000)]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [Column("IdCbteCble_Tipo")]
    public int? IdCbteCbleTipo { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [Column("cm_anio")]
    public int CmAnio { get; set; }

    [Column("cm_mes")]
    public int CmMes { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

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

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Precision(18, 0)]
    public decimal? IdProvedor { get; set; }

    [StringLength(25)]
    public string? NumDocumentoRelacionado { get; set; }

    [StringLength(25)]
    public string? NumFactura { get; set; }

    [Column("IdEmpresa_x_Anu")]
    public int? IdEmpresaXAnu { get; set; }

    [Column("IdSucursal_x_Anu")]
    public int? IdSucursalXAnu { get; set; }

    [Column("IdBodega_x_Anu")]
    public int? IdBodegaXAnu { get; set; }

    [Column("IdMovi_inven_tipo_x_Anu")]
    public int? IdMoviInvenTipoXAnu { get; set; }

    [Column("IdNumMovi_x_Anu")]
    [Precision(18, 0)]
    public decimal? IdNumMoviXAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [Column("IdEstadoDespacho_cat")]
    [StringLength(15)]
    public string? IdEstadoDespachoCat { get; set; }

    [Column("Fecha_despacho")]
    [MaxLength(6)]
    public DateTime? FechaDespacho { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [ForeignKey("CmMes")]
    [InverseProperty("InMoviInve")]
    public virtual TbMes CmMesNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("InMoviInve")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("InMoviInve")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("InMoviInve")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [InverseProperty("InMoviInve")]
    public virtual ICollection<FaDevolVenta> FaDevolVentaInMoviInve { get; set; } = new List<FaDevolVenta>();

    [InverseProperty("InMoviInveNavigation")]
    public virtual ICollection<FaDevolVenta> FaDevolVentaInMoviInveNavigation { get; set; } = new List<FaDevolVenta>();

    [InverseProperty("InMoviInve")]
    public virtual ICollection<FaFacturaXInMoviInve> FaFacturaXInMoviInve { get; set; } = new List<FaFacturaXInMoviInve>();

    [InverseProperty("InMoviInve")]
    public virtual ICollection<FaFacturaXInMoviInveXAnulacion> FaFacturaXInMoviInveXAnulacion { get; set; } = new List<FaFacturaXInMoviInveXAnulacion>();

    [ForeignKey("IdEstadoDespachoCat")]
    [InverseProperty("InMoviInve")]
    public virtual InCatalogo? IdEstadoDespachoCatNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdMotivoInv")]
    [InverseProperty("InMoviInve")]
    public virtual InMotivoInven? InMotivoInven { get; set; }

    [InverseProperty("InMoviInve")]
    public virtual ICollection<InMoviInveDetalle> InMoviInveDetalle { get; set; } = new List<InMoviInveDetalle>();

    [ForeignKey("IdEmpresaXAnu, IdSucursalXAnu, IdBodegaXAnu, IdMoviInvenTipoXAnu, IdNumMoviXAnu")]
    [InverseProperty("InverseInMoviInveNavigation")]
    public virtual InMoviInve? InMoviInveNavigation { get; set; }

    [InverseProperty("InMoviInve")]
    public virtual ICollection<InMoviInveXCtCbteCble> InMoviInveXCtCbteCble { get; set; } = new List<InMoviInveXCtCbteCble>();

    [InverseProperty("InMoviInve")]
    public virtual ICollection<InMoviInveXInOrdencompraLocal> InMoviInveXInOrdencompraLocal { get; set; } = new List<InMoviInveXInOrdencompraLocal>();

    [ForeignKey("IdEmpresa, IdMoviInvenTipo")]
    [InverseProperty("InMoviInve")]
    public virtual InMoviInvenTipo InMoviInvenTipo { get; set; } = null!;

    [InverseProperty("InMoviInveNavigation")]
    public virtual ICollection<InMoviInve> InverseInMoviInveNavigation { get; set; } = new List<InMoviInve>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("InMoviInve")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
