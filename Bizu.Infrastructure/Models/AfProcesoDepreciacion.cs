using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdActivoFijo", "IdUsuario")]
[Table("Af_proceso_depreciacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfProcesoDepreciacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdActivoFijo { get; set; }

    [Key]
    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Af_depreciacion_acum")]
    public double AfDepreciacionAcum { get; set; }

    [Column("Af_valor_depreciacion")]
    public double AfValorDepreciacion { get; set; }

    [ForeignKey("IdEmpresa, IdActivoFijo")]
    [InverseProperty("AfProcesoDepreciacion")]
    public virtual AfActivoFijo AfActivoFijo { get; set; } = null!;
}
