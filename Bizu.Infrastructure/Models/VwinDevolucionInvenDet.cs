using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinDevolucionInvenDet
{
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

    [Column("cantidad_a_devolver")]
    public double CantidadADevolver { get; set; }

    [Column("cantidad_inven")]
    public double CantidadInven { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("cantidad_devuelta")]
    public double CantidadDevuelta { get; set; }

    [Column("cantidad_egresada")]
    public double CantidadEgresada { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }
}
