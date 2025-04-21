using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt003
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    public int IdSucursal { get; set; }

    public int IdActijoFijoTipo { get; set; }

    public int IdTipoDepreciacion { get; set; }

    [Column("Af_Codigo_Barra")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfCodigoBarra { get; set; }

    [Column("nom_tipo_depreciacion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoDepreciacion { get; set; }

    [Column("Af_Descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfDescripcion { get; set; } = null!;

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    public int? IdDepartamento { get; set; }

    [Column("Af_Marca")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfMarca { get; set; } = null!;

    [Column("Af_Modelo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfModelo { get; set; } = null!;

    [Column("Af_NumSerie")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfNumSerie { get; set; }

    [Column("Af_Color")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfColor { get; set; } = null!;

    [Column("Af_Ubicacion")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfUbicacion { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCompleto { get; set; }

    [Column("Af_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfObservacion { get; set; } = null!;

    [Column("Af_NumPlaca")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfNumPlaca { get; set; }

    [Column("Af_Anio_fabrica")]
    public int? AfAnioFabrica { get; set; }

    [Column("Af_DescripcionCorta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfDescripcionCorta { get; set; }

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Af_Costo_historico")]
    public double AfCostoHistorico { get; set; }

    [Column("Af_Vida_Util")]
    public int AfVidaUtil { get; set; }

    [Column("Af_Meses_depreciar")]
    public int AfMesesDepreciar { get; set; }

    [Column("Af_ValorSalvamento")]
    public double AfValorSalvamento { get; set; }

    [Column("Af_ValorResidual")]
    public double AfValorResidual { get; set; }

    [Column("Estado_Proceso")]
    [StringLength(35)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EstadoProceso { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdPeriodoDeprec { get; set; } = null!;

    [Column("Descri_Periodo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescriPeriodo { get; set; }

    [Column("Valor_Depreciacion")]
    public double ValorDepreciacion { get; set; }

    [Column("Valor_Depre_Acum")]
    public double ValorDepreAcum { get; set; }

    [Column("Valor_Importe")]
    public double ValorImporte { get; set; }
}
