using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt022
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    [Column("IdDev_Inven")]
    [Precision(18, 0)]
    public decimal IdDevInven { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_movi_inv")]
    public int IdEmpresaMoviInv { get; set; }

    [Column("IdSucursal_movi_inv")]
    public int IdSucursalMoviInv { get; set; }

    [Column("IdBodega_movi_inv")]
    public int IdBodegaMoviInv { get; set; }

    [Column("IdMovi_inven_tipo_movi_inv")]
    public int IdMoviInvenTipoMoviInv { get; set; }

    [Column("IdNumMovi_movi_inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviMoviInv { get; set; }

    [Column("Secuencia_movi_inv")]
    public int SecuenciaMoviInv { get; set; }

    [Column("cod_Dev_Inven")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodDevInven { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("num_egreso")]
    [Precision(18, 0)]
    public decimal NumEgreso { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrCodigo { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrDescripcion { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("cantidad_a_devolver")]
    public double CantidadADevolver { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SuDescripcion { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BoDescripcion { get; set; }

    [Column("observacion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }
}
