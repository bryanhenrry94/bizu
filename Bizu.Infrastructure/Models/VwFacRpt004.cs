using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt004
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [StringLength(4)]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("numDocumento")]
    [StringLength(51)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocumento { get; set; } = null!;

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Referencia { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdComprobante { get; set; }

    [StringLength(50)]
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

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("no_fecha")]
    [MaxLength(6)]
    public DateTime NoFecha { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    public double? Saldo { get; set; }

    public double? TotalCobrado { get; set; }

    [Column("SubTotal_0")]
    public double? SubTotal0 { get; set; }

    [Column("SubTotal_Iva")]
    public double? SubTotalIva { get; set; }

    [Column("vt_iva")]
    public double? VtIva { get; set; }

    [Column("total")]
    public double? Total { get; set; }

    [Column("no_fecha_venc")]
    [MaxLength(6)]
    public DateTime? NoFechaVenc { get; set; }

    public int IdTipoNota { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoNota { get; set; } = null!;

    [Column("No_Descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NoDescripcion { get; set; } = null!;

    public int? Plazo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NaturalezaNota { get; set; }
}
