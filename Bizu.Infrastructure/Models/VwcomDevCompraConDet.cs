using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomDevCompraConDet
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdDevCompra { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Tipo { get; set; } = null!;

    [Column("dv_fecha")]
    [MaxLength(6)]
    public DateTime DvFecha { get; set; }

    [Column("dv_flete")]
    public double DvFlete { get; set; }

    [Column("dv_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DvObservacion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("cod_proveedor")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProveedor { get; set; } = null!;

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dv_Cantidad")]
    public double DvCantidad { get; set; }

    [Column("dv_precioCompra")]
    public double DvPrecioCompra { get; set; }

    [Column("dv_porc_des")]
    public double DvPorcDes { get; set; }

    [Column("dv_descuento")]
    public double DvDescuento { get; set; }

    [Column("dv_subtotal")]
    public double DvSubtotal { get; set; }

    [Column("dv_iva")]
    public double DvIva { get; set; }

    [Column("dv_total")]
    public double DvTotal { get; set; }

    [Column("dv_ManejaIva")]
    public bool DvManejaIva { get; set; }

    [Column("dv_Costeado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DvCosteado { get; set; } = null!;

    [Column("dv_peso")]
    public double DvPeso { get; set; }

    [Column("dvt_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DvtObservacion { get; set; } = null!;

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("ocdet_IdEmpresa")]
    public int? OcdetIdEmpresa { get; set; }

    [Column("ocdet_IdSucursal")]
    public int? OcdetIdSucursal { get; set; }

    [Column("ocdet_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal? OcdetIdOrdenCompra { get; set; }

    [Column("ocdet_Secuencia")]
    public int? OcdetSecuencia { get; set; }
}
