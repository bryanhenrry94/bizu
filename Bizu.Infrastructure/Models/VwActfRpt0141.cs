using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt0141
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodActivoFijo { get; set; } = null!;

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    public int IdActijoFijoTipo { get; set; }

    [Column("Af_Descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfDescripcion { get; set; } = null!;

    [Column("IdCategoriaAF")]
    public int IdCategoriaAf { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    [Column("Fecha_Depreciacion")]
    [MaxLength(6)]
    public DateTime FechaDepreciacion { get; set; }

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }

    [Column("Af_fecha_ini_depre")]
    [MaxLength(6)]
    public DateTime AfFechaIniDepre { get; set; }

    [Column("Af_fecha_fin_depre")]
    [MaxLength(6)]
    public DateTime AfFechaFinDepre { get; set; }

    [Column("Af_costo_compra")]
    public double? AfCostoCompra { get; set; }

    [Column("Af_ValorResidual")]
    public double? AfValorResidual { get; set; }

    public double? ActivoNeto { get; set; }

    public double? DepAnioAnt { get; set; }

    public double? DepAnioAct { get; set; }

    public double? ValorMensual { get; set; }

    public double? DepAcum { get; set; }

    public double? TotlDep { get; set; }

    public double? ValorLibros { get; set; }
}
