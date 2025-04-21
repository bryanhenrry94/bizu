using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdListadoMppreasingado", "IdNumMovi", "CodObraPreasignada", "CodigoBarra")]
[Table("com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComListadoMaterialesDisponiblesPreAsignadoAObraDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Column("IdListadoMPPreasingado")]
    [Precision(18, 0)]
    public decimal IdListadoMppreasingado { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
    [Column("CodObra_preasignada")]
    [StringLength(20)]
    public string CodObraPreasignada { get; set; } = null!;

    [Key]
    [StringLength(100)]
    public string CodigoBarra { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("dm_observacion")]
    [StringLength(1000)]
    public string? DmObservacion { get; set; }

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
