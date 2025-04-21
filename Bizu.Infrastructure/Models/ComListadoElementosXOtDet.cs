using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdListadoElementosXOt", "IdDetalle")]
[Table("com_ListadoElementos_x_OT_Det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComListadoElementosXOtDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdListadoElementos_x_OT")]
    [Precision(18, 0)]
    public decimal IdListadoElementosXOt { get; set; }

    [Key]
    public int IdDetalle { get; set; }

    [StringLength(20)]
    public string CodObra { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdOrdenTaller { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    public double Unidades { get; set; }

    [Column("Det_Kg")]
    public double DetKg { get; set; }

    [Column("pr_largo")]
    public double? PrLargo { get; set; }

    [Column("largo_total")]
    public double? LargoTotal { get; set; }

    [Column("largo_restante")]
    public double? LargoRestante { get; set; }

    [Column("largo_pieza_entera")]
    public double? LargoPiezaEntera { get; set; }

    [Column("cantidad_pieza_entera")]
    public int? CantidadPiezaEntera { get; set; }

    [Column("largo_pieza_complementaria")]
    public double? LargoPiezaComplementaria { get; set; }

    [Column("cantidad_pieza_complementaria")]
    public double? CantidadPiezaComplementaria { get; set; }

    [Column("cantidad_total_pieza_complementaria")]
    public double? CantidadTotalPiezaComplementaria { get; set; }

    [Column("largo_despunte1")]
    public double? LargoDespunte1 { get; set; }

    [Column("cantidad_despunte1")]
    public double? CantidadDespunte1 { get; set; }

    [Column("es_despunte_usable1")]
    public bool? EsDespunteUsable1 { get; set; }

    [Column("largo_despunte2")]
    public double? LargoDespunte2 { get; set; }

    [Column("cantidad_despunte2")]
    public double? CantidadDespunte2 { get; set; }

    [Column("es_despunte_usable2")]
    public bool? EsDespunteUsable2 { get; set; }

    [StringLength(25)]
    public string IdEstadoAprob { get; set; } = null!;
}
