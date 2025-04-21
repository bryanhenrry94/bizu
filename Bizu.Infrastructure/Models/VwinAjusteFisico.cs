using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinAjusteFisico
{
    [Precision(18, 0)]
    public decimal IdAjusteFisico { get; set; }

    [Column("IdMovi_inven_tipo_Ing")]
    public int? IdMoviInvenTipoIng { get; set; }

    [Column("IdNumMovi_Ing")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIng { get; set; }

    [Column("IdMovi_inven_tipo_Egr")]
    public int? IdMoviInvenTipoEgr { get; set; }

    [Column("IdNumMovi_Egr")]
    [Precision(18, 0)]
    public decimal? IdNumMoviEgr { get; set; }

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("tm_descripcion_ing")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TmDescripcionIng { get; set; }

    [Column("tm_descripcion_Egr")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TmDescripcionEgr { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdBodega { get; set; }

    public int IdSucursal { get; set; }

    [Column("Nombre_Estado")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreEstado { get; set; } = null!;

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacion { get; set; }
}
