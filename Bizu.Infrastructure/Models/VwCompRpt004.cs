using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCompRpt004
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Column("documento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Documento { get; set; } = null!;

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdComprador { get; set; }

    [Column("nom_comprador")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomComprador { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacionCat { get; set; } = null!;

    public int? IdMotivo { get; set; }

    [Column("Nom_motivo_oc")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMotivoOc { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [Column("precio")]
    public double Precio { get; set; }

    [Column("do_subtotal")]
    public double DoSubtotal { get; set; }

    [Column("do_iva")]
    public double DoIva { get; set; }

    [Column("do_total")]
    public double DoTotal { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("sub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SubCentroCosto { get; set; }
}
