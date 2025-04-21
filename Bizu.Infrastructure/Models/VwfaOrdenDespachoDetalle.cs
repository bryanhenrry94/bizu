using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaOrdenDespachoDetalle
{
    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("od_Precio")]
    public double OdPrecio { get; set; }

    [Column("od_cantidad")]
    public double OdCantidad { get; set; }

    [Column("od_PorDescUnitario")]
    public double OdPorDescUnitario { get; set; }

    [Column("od_DescUnitario")]
    public double OdDescUnitario { get; set; }

    [Column("od_PrecioFinal")]
    public double OdPrecioFinal { get; set; }

    [Column("od_Subtotal")]
    public double OdSubtotal { get; set; }

    [Column("od_iva")]
    public double OdIva { get; set; }

    [Column("od_total")]
    public double OdTotal { get; set; }

    [Column("od_costo")]
    public double OdCosto { get; set; }

    [Column("od_tieneIVA")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OdTieneIva { get; set; } = null!;

    [Column("od_detallexItems")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OdDetallexItems { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int IdBodega { get; set; }

    public int IdSucursal { get; set; }

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenDespacho { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdTransportista { get; set; }

    [Column("od_fecha")]
    [MaxLength(6)]
    public DateTime OdFecha { get; set; }

    [Column("od_plazo")]
    public int OdPlazo { get; set; }

    [Column("od_fech_venc")]
    [MaxLength(6)]
    public DateTime OdFechVenc { get; set; }

    [Column("od_Observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OdObservacion { get; set; } = null!;

    [Column("od_TotalKilos")]
    public double OdTotalKilos { get; set; }

    [Column("od_TotalQuintales")]
    public double OdTotalQuintales { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    [Precision(18, 0)]
    public decimal Expr1 { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("em_telefonos")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmTelefonos { get; set; }

    [Column("em_direccion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmDireccion { get; set; } = null!;

    [Column("em_logo")]
    public byte[]? EmLogo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodOrdenDespacho { get; set; } = null!;

    [Column("od_DespAbierto")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? OdDespAbierto { get; set; }
}
