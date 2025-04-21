using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaContabilizacionFacturaXItem
{
    [Precision(21, 0)]
    public decimal IdFila { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    public double? Subtotal { get; set; }

    public double? Descuento { get; set; }

    [Column("iva")]
    public double? Iva { get; set; }

    public double? Total { get; set; }

    [Column("IdCtaCble_Ven0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVen0 { get; set; }

    [Column("IdCtaCble_VenIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVenIva { get; set; }

    [Column("vt_tipo_venta")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtTipoVenta { get; set; } = null!;

    [Column("vt_plazo")]
    [Precision(18, 0)]
    public decimal VtPlazo { get; set; }

    [Column("IdCtaCble_DesIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDesIva { get; set; }

    [Column("IdCtaCble_Des0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDes0 { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

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

    [Column("IdCtaCble_Imp_Iva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleImpIva { get; set; }

    [Column("IdCtaCble_Imp_Ice")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleImpIce { get; set; }

    [Column("IdPunto_Cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }
}
