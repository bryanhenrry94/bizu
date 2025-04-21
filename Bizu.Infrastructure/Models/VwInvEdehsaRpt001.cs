using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvEdehsaRpt001
{
    [Column("fila")]
    [Precision(21, 0)]
    public decimal Fila { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    public int Secuencia { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Proveedor { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("oc_detalle_x_item")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcDetalleXItem { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string UnidadMedida { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    public int IdGrupo { get; set; }

    public int IdSubGrupo { get; set; }

    [Column("oc_cantidad_pedida")]
    public double? OcCantidadPedida { get; set; }

    [Column("do_precioCompra")]
    public double DoPrecioCompra { get; set; }

    [Column("mv_costo")]
    public double? MvCosto { get; set; }

    [Column("IdEmpresa_inv")]
    public int? IdEmpresaInv { get; set; }

    [Column("IdSucursal_inv")]
    public int? IdSucursalInv { get; set; }

    [Column("IdBodega_inv")]
    public int? IdBodegaInv { get; set; }

    [Column("IdMovi_inven_tipo_inv")]
    public int? IdMoviInvenTipoInv { get; set; }

    [Precision(18, 0)]
    public decimal? IdNumMovi { get; set; }

    [Column("cantidad_ing")]
    public double? CantidadIng { get; set; }

    [Column("subtotal")]
    public double? Subtotal { get; set; }

    [Column("Fecha_Ing")]
    [MaxLength(6)]
    public DateTime? FechaIng { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Column("num_documento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime? CoFechaFactura { get; set; }

    [Column("numGuia")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumGuia { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
