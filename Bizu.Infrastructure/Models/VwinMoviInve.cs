using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInve
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Column("cm_tipo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmTipo { get; set; } = null!;

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [Column("IdCbteCble_Tipo")]
    public int? IdCbteCbleTipo { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [Column("cm_anio")]
    public int CmAnio { get; set; }

    [Column("cm_mes")]
    public int CmMes { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdusuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoMovi { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoMovi { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NemoTipoMovi { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodMoviInven { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [Precision(18, 0)]
    public decimal? IdProvedor { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumentoRelacionado { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
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
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }
}
