using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfOrdenCompraXProveedorFacturaActivoFijo
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    public int Secuencia { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("mv_costo")]
    public double? MvCosto { get; set; }

    [Column("dm_precio")]
    public double DmPrecio { get; set; }

    [Column("dm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DmObservacion { get; set; } = null!;

    [Column("Fecha_Ing_Bod")]
    [MaxLength(6)]
    public DateTime FechaIngBod { get; set; }

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    [Column("IdEmpresa_oc")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_oc")]
    public int? IdSucursalOc { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Secuencia_oc")]
    public int? SecuenciaOc { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Precision(18, 0)]
    public decimal? IdAprobacion { get; set; }

    [Column("numDocumento")]
    [StringLength(58)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("Fecha_Factura")]
    [MaxLength(6)]
    public DateTime? FechaFactura { get; set; }

    public double? Cantidad { get; set; }

    [Column("Costo_uni")]
    public double? CostoUni { get; set; }

    public double? SubTotal { get; set; }

    public double? PorIva { get; set; }

    [Column("valor_Iva")]
    public double? ValorIva { get; set; }

    public double? Total { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdOrdenGiroTipo { get; set; }

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleGasto { get; set; }

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleIva { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdNaturaleza { get; set; }
}
