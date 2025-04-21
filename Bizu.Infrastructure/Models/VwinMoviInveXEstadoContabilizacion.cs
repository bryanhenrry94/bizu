using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveXEstadoContabilizacion
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("cod_sucursal")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodSucursal { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("cod_bodega")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodBodega { get; set; }

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Column("nom_tipo_movi")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoMovi { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

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

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    public int? IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    [Column("Estado_contabilizacion")]
    [StringLength(16)]
    public string EstadoContabilizacion { get; set; } = null!;
}
