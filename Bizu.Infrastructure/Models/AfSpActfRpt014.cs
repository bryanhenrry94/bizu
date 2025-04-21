using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdActivoFijoTipo", "IdUsuario")]
[Table("Af_spACTF_Rpt014")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfSpActfRpt014
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdActivoFijoTipo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Af_Descripcion")]
    [StringLength(500)]
    public string AfDescripcion { get; set; } = null!;

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Valor_Depreciacion")]
    public double ValorDepreciacion { get; set; }

    [Column("Valor_ult_depreciacion")]
    public double ValorUltDepreciacion { get; set; }

    [Column("Costo_neto")]
    public double CostoNeto { get; set; }
}
