using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcRpt019
{
    public int IdEmpresa { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodCbteVta { get; set; } = null!;

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtTipoDoc { get; set; }

    [Column("vt_serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie1 { get; set; }

    [Column("vt_serie2")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie2 { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNumFactura { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_plazo")]
    [Precision(10, 0)]
    public decimal? VtPlazo { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime? VtFechVenc { get; set; }

    [Column("vt_tipo_venta")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtTipoVenta { get; set; } = null!;

    [Column("vt_Observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtObservacion { get; set; } = null!;

    public double? IdPeriodo { get; set; }

    [Column("vt_anio")]
    [StringLength(11)]
    public string? VtAnio { get; set; }

    [Column("vt_mes")]
    [StringLength(11)]
    public string? VtMes { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("vt_Subtotal")]
    public double? VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double? VtIva { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    public double CobroTotal { get; set; }

    public double? Saldo { get; set; }

    [Column("fechaCobro")]
    [MaxLength(6)]
    public DateTime? FechaCobro { get; set; }

    [Column("diasCobro")]
    [Precision(10, 0)]
    public decimal? DiasCobro { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCiudad { get; set; } = null!;

    [Column("ciudadNom")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CiudadNom { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdProvincia { get; set; } = null!;

    [Column("provinciaNom")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ProvinciaNom { get; set; } = null!;
}
