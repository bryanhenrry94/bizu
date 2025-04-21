using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaFacturaDet
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("vt_cantidad")]
    public double VtCantidad { get; set; }

    [Column("vt_Precio")]
    public double VtPrecio { get; set; }

    [Column("vt_PorDescUnitario")]
    public double VtPorDescUnitario { get; set; }

    [Column("vt_DescUnitario")]
    public double VtDescUnitario { get; set; }

    [Column("vt_PrecioFinal")]
    public double VtPrecioFinal { get; set; }

    [Column("vt_Subtotal")]
    public double VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double VtIva { get; set; }

    [Column("vt_total")]
    public double VtTotal { get; set; }

    [Column("vt_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtEstado { get; set; } = null!;

    [Column("vt_detallexItems")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtDetallexItems { get; set; }

    [Column("vt_Peso")]
    public double? VtPeso { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("vt_por_iva")]
    public double VtPorIva { get; set; }

    [Column("IdPunto_Cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCodImpuestoIva { get; set; } = null!;

    [Column("IdCod_Impuesto_Ice")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCodImpuestoIce { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string UnidadMedida { get; set; } = null!;
}
