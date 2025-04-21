using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursalOrigen", "IdBodegaOrigen", "IdTransferencia")]
[Table("in_transferencia")]
[Index("IdEstadoAprobacionCat", Name = "FK_in_transferencia_in_Catalogo")]
[Index("IdEmpresaIngEgrInvenOrigen", "IdSucursalIngEgrInvenOrigen", "IdMoviInvenTipoSucuOrig", "IdNumMoviIngEgrInvenOrigen", Name = "FK_in_transferencia_in_Ing_Egr_Inven")]
[Index("IdEmpresaIngEgrInvenDestino", "IdSucursalIngEgrInvenDestino", "IdMoviInvenTipoSucuDest", "IdNumMoviIngEgrInvenDestino", Name = "FK_in_transferencia_in_Ing_Egr_Inven1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InTransferencia
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursalOrigen { get; set; }

    [Key]
    public int IdBodegaOrigen { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    public int IdSucursalDest { get; set; }

    public int IdBodegaDest { get; set; }

    [Column("tr_Observacion")]
    [StringLength(500)]
    public string TrObservacion { get; set; } = null!;

    [Column("tr_fecha")]
    [MaxLength(6)]
    public DateTime TrFecha { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inven_Origen")]
    public int? IdEmpresaIngEgrInvenOrigen { get; set; }

    [Column("IdSucursal_Ing_Egr_Inven_Origen")]
    public int? IdSucursalIngEgrInvenOrigen { get; set; }

    [Column("IdMovi_inven_tipo_SucuOrig")]
    public int? IdMoviInvenTipoSucuOrig { get; set; }

    [Column("IdNumMovi_Ing_Egr_Inven_Origen")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIngEgrInvenOrigen { get; set; }

    [Column("IdCentroCosto_Ing_Egr_Inven_Origen")]
    [StringLength(20)]
    public string? IdCentroCostoIngEgrInvenOrigen { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inven_Destino")]
    public int? IdEmpresaIngEgrInvenDestino { get; set; }

    [Column("IdSucursal_Ing_Egr_Inven_Destino")]
    public int? IdSucursalIngEgrInvenDestino { get; set; }

    [Column("IdMovi_inven_tipo_SucuDest")]
    public int? IdMoviInvenTipoSucuDest { get; set; }

    [Column("IdNumMovi_Ing_Egr_Inven_Destino")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIngEgrInvenDestino { get; set; }

    [Column("IdCentroCosto_Ing_Egr_Inven_Destino")]
    [StringLength(20)]
    public string? IdCentroCostoIngEgrInvenDestino { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("tr_userAnulo")]
    [StringLength(20)]
    public string? TrUserAnulo { get; set; }

    [Column("tr_fechaAnulacion")]
    [MaxLength(6)]
    public DateTime? TrFechaAnulacion { get; set; }

    [Column("tr_fecha_transaccion")]
    [MaxLength(6)]
    public DateTime? TrFechaTransaccion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(20)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("motivo_anula")]
    [StringLength(1000)]
    public string? MotivoAnula { get; set; }

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(15)]
    public string? IdEstadoAprobacionCat { get; set; }

    [ForeignKey("IdEstadoAprobacionCat")]
    [InverseProperty("InTransferencia")]
    public virtual InCatalogo? IdEstadoAprobacionCatNavigation { get; set; }

    [ForeignKey("IdEmpresaIngEgrInvenDestino, IdSucursalIngEgrInvenDestino, IdMoviInvenTipoSucuDest, IdNumMoviIngEgrInvenDestino")]
    [InverseProperty("InTransferenciaInIngEgrInven")]
    public virtual InIngEgrInven? InIngEgrInven { get; set; }

    [ForeignKey("IdEmpresaIngEgrInvenOrigen, IdSucursalIngEgrInvenOrigen, IdMoviInvenTipoSucuOrig, IdNumMoviIngEgrInvenOrigen")]
    [InverseProperty("InTransferenciaInIngEgrInvenNavigation")]
    public virtual InIngEgrInven? InIngEgrInvenNavigation { get; set; }

    [InverseProperty("InTransferencia")]
    public virtual ICollection<InTransferenciaDet> InTransferenciaDet { get; set; } = new List<InTransferenciaDet>();

    [InverseProperty("InTransferencia")]
    public virtual ICollection<InTransferenciaXFaGuiaRemision> InTransferenciaXFaGuiaRemision { get; set; } = new List<InTransferenciaXFaGuiaRemision>();

    [InverseProperty("InTransferencia")]
    public virtual ICollection<InTransferenciaXInGuiaXTraspasoBodega> InTransferenciaXInGuiaXTraspasoBodega { get; set; } = new List<InTransferenciaXInGuiaXTraspasoBodega>();

    [ForeignKey("IdEmpresa, IdSucursalOrigen, IdBodegaOrigen")]
    [InverseProperty("InTransferencia")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
