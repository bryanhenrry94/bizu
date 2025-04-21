using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomSolicitudCompraDetAprobacion
{
    public int IdEmpresa { get; set; }

    [Column("IdSucursal_SC")]
    public int IdSucursalSc { get; set; }

    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [Column("Secuencia_SC")]
    public int SecuenciaSc { get; set; }

    [Column("IdProducto_SC")]
    [Precision(18, 0)]
    public decimal? IdProductoSc { get; set; }

    [Column("NomProducto_SC")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProductoSc { get; set; }

    [Column("Cantidad_aprobada")]
    public double CantidadAprobada { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [Column("IdProveedor_SC")]
    [Precision(18, 0)]
    public decimal? IdProveedorSc { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAprobacion { get; set; }

    [Column("observacion")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [Column("do_precioCompra")]
    public double? DoPrecioCompra { get; set; }

    [Column("do_porc_des")]
    public double? DoPorcDes { get; set; }

    [Column("do_descuento")]
    public double? DoDescuento { get; set; }

    [Column("do_subtotal")]
    public double? DoSubtotal { get; set; }

    [Column("do_iva")]
    public double? DoIva { get; set; }

    [Column("do_total")]
    public double? DoTotal { get; set; }

    [Column("do_ManejaIva")]
    public bool? DoManejaIva { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("do_observacion")]
    [StringLength(550)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DoObservacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoPreAprobacion { get; set; }

    [Column("Nom_Proveedor_SC")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedorSc { get; set; }
}
