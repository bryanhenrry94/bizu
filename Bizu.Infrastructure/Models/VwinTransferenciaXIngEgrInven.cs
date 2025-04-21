using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinTransferenciaXIngEgrInven
{
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

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("IdMovi_inven_tipo_Origen")]
    public int IdMoviInvenTipoOrigen { get; set; }

    [Column("IdMotivo_Inv_Origen")]
    public int? IdMotivoInvOrigen { get; set; }

    [Column("IdMovi_inven_tipo_Destino")]
    public int IdMoviInvenTipoDestino { get; set; }

    [Column("IdMotivo_Inv_Destino")]
    public int? IdMotivoInvDestino { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Codigo { get; set; }
}
