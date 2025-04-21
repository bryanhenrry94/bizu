using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt014
{
    public int IdEmpresa { get; set; }

    public int? IdPeriodo { get; set; }

    [Column("nom_tipo_depreciacion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoDepreciacion { get; set; }

    [Column("Af_costo_compra")]
    public double? AfCostoCompra { get; set; }

    [Column("Valor_Depre_Acum")]
    public double? ValorDepreAcum { get; set; }

    [Column("Dep_Actual")]
    public double? DepActual { get; set; }

    [Column("Porc_Depreciacion")]
    public double? PorcDepreciacion { get; set; }

    public int IdActijoFijoTipo { get; set; }

    [Column("nom_ActijoFijoTipo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomActijoFijoTipo { get; set; } = null!;

    [Column("IdCategoriaAF")]
    public int? IdCategoriaAf { get; set; }

    [Column("nom_CategoriaAF")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCategoriaAf { get; set; } = null!;

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;
}
