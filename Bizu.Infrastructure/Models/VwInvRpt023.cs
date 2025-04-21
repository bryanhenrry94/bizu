using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt023
{
    public int IdEmpresa { get; set; }

    [Column("IdDev_Inven")]
    [Precision(18, 0)]
    public decimal IdDevInven { get; set; }

    [Column("cod_Dev_Inven")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodDevInven { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int? IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal? IdNumMovi { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("cantidad_a_devolver")]
    public double CantidadADevolver { get; set; }

    [Column("dm_cantidad")]
    public double? DmCantidad { get; set; }

    [Column("mv_costo")]
    public double? MvCosto { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrDescripcion { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("tm_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TmDescripcion { get; set; }

    [Column("Secuencia_movi_inv")]
    public int SecuenciaMoviInv { get; set; }

    [Column("observacion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }
}
