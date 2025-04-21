using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCompRpt011
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    public int Secuencia { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("oc_fechaVencimiento")]
    [MaxLength(6)]
    public DateTime? OcFechaVencimiento { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdComprador { get; set; }

    [Column("Nom_Comprador")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomComprador { get; set; } = null!;

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("nom_EstadoCerrado")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoCerrado { get; set; } = null!;

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacionCat { get; set; } = null!;

    [Column("ap_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ApDescripcion { get; set; } = null!;

    [Column("IdUsuario_Aprueba")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [Column("co_fecha_aprobacion")]
    [MaxLength(6)]
    public DateTime? CoFechaAprobacion { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

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

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [Column("do_precioCompra")]
    public double DoPrecioCompra { get; set; }

    [Column("do_precioFinal")]
    public double DoPrecioFinal { get; set; }

    [Column("do_subtotal")]
    public double DoSubtotal { get; set; }

    [Column("do_iva")]
    public double DoIva { get; set; }

    [Column("do_total")]
    public double DoTotal { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }
}
