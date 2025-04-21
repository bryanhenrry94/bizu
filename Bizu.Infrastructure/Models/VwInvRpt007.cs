using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt007
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdAjusteFisico { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodAjusteFisico { get; set; } = null!;

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("IdNumMovi_Ing")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIng { get; set; }

    [Column("IdMovi_inven_tipo_Ing")]
    public int? IdMoviInvenTipoIng { get; set; }

    [Column("IdNumMovi_Egr")]
    [Precision(18, 0)]
    public decimal? IdNumMoviEgr { get; set; }

    [Column("IdMovi_inven_tipo_Egr")]
    public int? IdMoviInvenTipoEgr { get; set; }

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

    public double StockFisico { get; set; }

    public double StockSistema { get; set; }

    public double CantidadAjustada { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacion { get; set; }

    [Column("nom_estado_aprobacion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoAprobacion { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [Column("ca_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomLinea { get; set; } = null!;

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [Column("Tipo_ingreso")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoIngreso { get; set; } = null!;

    [Column("Tipo_egreso")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoEgreso { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("nom_unidad_medida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomUnidadMedida { get; set; } = null!;

    [Column("costo")]
    public double Costo { get; set; }

    [Column("Total_costo")]
    public double TotalCosto { get; set; }
}
