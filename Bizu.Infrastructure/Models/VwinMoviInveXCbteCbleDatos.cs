using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveXCbteCbleDatos
{
    public int? IdEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int? IdMoviInvenTipo { get; set; }

    [Column("nom_categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCategoria { get; set; } = null!;

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomLinea { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdNumMovi { get; set; }

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CmObservacion { get; set; }

    [Column("cm_observacion_inv")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacionInv { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SuDescripcion { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BoDescripcion { get; set; }

    [Column("cm_tipo_movi")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmTipoMovi { get; set; } = null!;

    [Column("cm_descripcionCorta")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmDescripcionCorta { get; set; } = null!;

    public int? Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("dm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DmObservacion { get; set; } = null!;

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TcTipoCbte { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime? CbFecha { get; set; }

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    public int? IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    [Column("Tipo_Contabilizado")]
    [StringLength(16)]
    public string TipoContabilizado { get; set; } = null!;

    [Column("IdEmpresa_inv")]
    public int IdEmpresaInv { get; set; }

    [Column("IdSucursal_inv")]
    public int IdSucursalInv { get; set; }

    [Column("IdBodega_inv")]
    public int IdBodegaInv { get; set; }

    [Column("IdMovi_inven_tipo_inv")]
    public int IdMoviInvenTipoInv { get; set; }

    [Column("IdNumMovi_inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviInv { get; set; }

    [Column("tm_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmDescripcion { get; set; } = null!;
}
