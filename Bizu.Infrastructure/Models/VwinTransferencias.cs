using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinTransferencias
{
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SucuOrigen { get; set; } = null!;

    [Column("BodegaORIG")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BodegaOrig { get; set; } = null!;

    [Column("SucuDEST")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SucuDest { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BodegDest { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursalOrigen { get; set; }

    public int IdBodegaOrigen { get; set; }

    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    public int IdSucursalDest { get; set; }

    public int IdBodegaDest { get; set; }

    [Column("tr_Observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TrObservacion { get; set; } = null!;

    [Column("tr_fecha")]
    [MaxLength(6)]
    public DateTime TrFecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inven_Origen")]
    public int? IdEmpresaIngEgrInvenOrigen { get; set; }

    [Column("IdSucursal_Ing_Egr_Inven_Origen")]
    public int? IdSucursalIngEgrInvenOrigen { get; set; }

    [Column("IdNumMovi_Ing_Egr_Inven_Origen")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIngEgrInvenOrigen { get; set; }

    [Column("IdCentroCosto_Ing_Egr_Inven_Origen")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoIngEgrInvenOrigen { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inven_Destino")]
    public int? IdEmpresaIngEgrInvenDestino { get; set; }

    [Column("IdSucursal_Ing_Egr_Inven_Destino")]
    public int? IdSucursalIngEgrInvenDestino { get; set; }

    [Column("IdNumMovi_Ing_Egr_Inven_Destino")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIngEgrInvenDestino { get; set; }

    [Column("IdCentroCosto_Ing_Egr_Inven_Destino")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoIngEgrInvenDestino { get; set; }

    [Column("tr_fechaAnulacion")]
    [MaxLength(6)]
    public DateTime? TrFechaAnulacion { get; set; }

    [Column("tr_userAnulo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TrUserAnulo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Codigo { get; set; }

    [Column("IdMovi_inven_tipo_SucuOrig")]
    public int? IdMoviInvenTipoSucuOrig { get; set; }

    [Column("IdMovi_inven_tipo_SucuDest")]
    public int? IdMoviInvenTipoSucuDest { get; set; }

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacionCat { get; set; }

    [Column("EstadoAprobacion_cat")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EstadoAprobacionCat { get; set; } = null!;

    [Column("IdEstadoAproba_ing")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobaIng { get; set; }

    [Column("IdEstadoAproba_egr")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobaEgr { get; set; }
}
