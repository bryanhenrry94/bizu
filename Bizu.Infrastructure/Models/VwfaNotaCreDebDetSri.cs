using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebDetSri
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("sc_cantidad")]
    public double ScCantidad { get; set; }

    [Column("sc_Precio")]
    public double ScPrecio { get; set; }

    [Column("sc_descUni")]
    public double ScDescUni { get; set; }

    [Column("sc_PordescUni")]
    public double ScPordescUni { get; set; }

    [Column("sc_precioFinal")]
    public double ScPrecioFinal { get; set; }

    [Column("sc_subtotal")]
    public double ScSubtotal { get; set; }

    [Column("sc_iva")]
    public double ScIva { get; set; }

    [Column("sc_total")]
    public double ScTotal { get; set; }

    [Column("sc_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ScEstado { get; set; } = null!;

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

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCodImpuestoIva { get; set; } = null!;

    [Column("IdCod_Impuesto_Ice")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCodImpuestoIce { get; set; }

    [Column("sc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ScObservacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }
}
