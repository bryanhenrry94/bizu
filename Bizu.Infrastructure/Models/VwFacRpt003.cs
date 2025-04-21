using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt003
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtTipoDoc { get; set; } = null!;

    [Column("vt_NunDocumento")]
    [StringLength(51)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNunDocumento { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Referencia { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdComprobante { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodComprobante { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nombreCliente")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCliente { get; set; } = null!;

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    public double? Saldo { get; set; }

    public double TotalCobrado { get; set; }

    [Column("vt_Subtotal")]
    public double? VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double? VtIva { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime VtFechVenc { get; set; }

    [Column("vt_plazo")]
    [Precision(18, 0)]
    public decimal VtPlazo { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nombreProducto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreProducto { get; set; } = null!;

    [Column("sc_cantidad")]
    public double? ScCantidad { get; set; }

    [Column("sc_precioFinal")]
    public double? ScPrecioFinal { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }
}
