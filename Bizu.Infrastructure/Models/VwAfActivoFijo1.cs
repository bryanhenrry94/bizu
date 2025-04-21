using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfActivoFijo1
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodActivoFijo { get; set; } = null!;

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    public int IdActijoFijoTipo { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Marca { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Modelo { get; set; }

    [Column("Af_NumSerie")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfNumSerie { get; set; }

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }

    [Column("Af_fecha_ini_depre")]
    [MaxLength(6)]
    public DateTime AfFechaIniDepre { get; set; }

    [Column("Af_fecha_fin_depre")]
    [MaxLength(6)]
    public DateTime AfFechaFinDepre { get; set; }

    [Column("Af_Costo_historico")]
    public double AfCostoHistorico { get; set; }

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Af_Vida_Util")]
    public int AfVidaUtil { get; set; }

    [Column("Af_Meses_depreciar")]
    public int AfMesesDepreciar { get; set; }

    [Column("Af_porcentaje_deprec")]
    public double AfPorcentajeDeprec { get; set; }

    [Column("Af_NumSerie_Motor")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfNumSerieMotor { get; set; }

    [Column("Af_NumSerie_Chasis")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfNumSerieChasis { get; set; }

    public int? IdSucursal { get; set; }

    [Column("nom_Sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSucursal { get; set; }

    [Column("nom_Categoria")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCategoria { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("nom_encargado")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomEncargado { get; set; }

    [Column("Af_ValorUnidad_Actu")]
    public double? AfValorUnidadActu { get; set; }

    [Column("nom_Color")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomColor { get; set; }

    [Column("IdUnidadFact_cat")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadFactCat { get; set; }

    [Column("IdCategoriaAF")]
    public int? IdCategoriaAf { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Af_ValorSalvamento")]
    public double? AfValorSalvamento { get; set; }

    [Column("Af_ValorResidual")]
    public double? AfValorResidual { get; set; }

    [Column("Af_Capacidad")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfCapacidad { get; set; }

    [Column("Es_carroceria")]
    public bool? EsCarroceria { get; set; }

    [Column("nom_tipo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipo { get; set; }
}
