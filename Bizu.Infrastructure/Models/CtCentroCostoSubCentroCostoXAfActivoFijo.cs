using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaScc", "IdCentroCostoScc", "IdCentroCostoSubCentroCostoScc", "IdEmpresaAf", "IdActivoFijoAf")]
[Table("ct_centro_costo_sub_centro_costo_x_Af_Activo_fijo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCentroCostoSubCentroCostoXAfActivoFijo
{
    [Key]
    [Column("IdEmpresa_scc")]
    public int IdEmpresaScc { get; set; }

    [Key]
    [Column("IdCentroCosto_scc")]
    [StringLength(20)]
    public string IdCentroCostoScc { get; set; } = null!;

    [Key]
    [Column("IdCentroCosto_sub_centro_costo_scc")]
    [StringLength(20)]
    public string IdCentroCostoSubCentroCostoScc { get; set; } = null!;

    [Key]
    [Column("IdEmpresa_af")]
    public int IdEmpresaAf { get; set; }

    [Key]
    [Column("IdActivoFijo_af")]
    public int IdActivoFijoAf { get; set; }
}
