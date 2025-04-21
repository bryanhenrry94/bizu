using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt011
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodMoviInven { get; set; } = null!;

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("cod_Movi_Inven_tipo")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodMoviInvenTipo { get; set; } = null!;

    [Column("nom_Movi_Inven_tipo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomMoviInvenTipo { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumentoRelacionado { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumFactura { get; set; }

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("mv_tipo_movi")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MvTipoMovi { get; set; } = null!;

    public double CantiIngreso { get; set; }

    public double CantiEgreso { get; set; }

    public double Costo { get; set; }

    [Column("Cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }
}
