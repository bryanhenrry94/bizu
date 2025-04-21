using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdActivoFijo", "IdUsuario")]
[Table("Af_spACTF_Rpt012")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfSpActfRpt012
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdActivoFijo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(100)]
    public string SuDescripcion { get; set; } = null!;

    [StringLength(50)]
    public string CodActivoFijo { get; set; } = null!;

    [Column("Af_Nombre")]
    [StringLength(500)]
    public string AfNombre { get; set; } = null!;

    public int IdActivoFijoTipo { get; set; }

    [Column("tipo_AF")]
    [StringLength(200)]
    public string TipoAf { get; set; } = null!;

    [Column("IdCategoria_Af")]
    public int IdCategoriaAf { get; set; }

    [Column("Categoria_AF")]
    [StringLength(200)]
    public string CategoriaAf { get; set; } = null!;

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Af_Depreciacion_acum")]
    public double AfDepreciacionAcum { get; set; }

    [Column("Costo_actual")]
    public double CostoActual { get; set; }

    [Column("valor_ult_depreciacion")]
    public double ValorUltDepreciacion { get; set; }

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }
}
