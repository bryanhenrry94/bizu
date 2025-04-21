using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt010
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    public int Secuencia { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoNota { get; set; } = null!;

    [StringLength(4)]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("numDocumento")]
    [StringLength(48)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_telefonoCasa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeTelefonoCasa { get; set; }

    [Column("pe_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeDireccion { get; set; } = null!;

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    [Column("no_fecha")]
    [MaxLength(6)]
    public DateTime NoFecha { get; set; }

    [Column("no_fecha_venc")]
    [MaxLength(6)]
    public DateTime? NoFechaVenc { get; set; }

    public int? Plazo { get; set; }

    public int IdTipoNota { get; set; }

    [Column("sc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ScObservacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdDevolucion { get; set; }

    [Column("interes")]
    public double? Interes { get; set; }

    [Column("sc_cantidad")]
    public double ScCantidad { get; set; }

    [Column("sc_Precio")]
    public double ScPrecio { get; set; }

    [Column("sc_subtotal")]
    public double ScSubtotal { get; set; }

    [Column("sc_iva")]
    public double ScIva { get; set; }

    [Column("sc_total")]
    public double ScTotal { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nombreProducto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreProducto { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("valorFlete")]
    public double? ValorFlete { get; set; }

    public int IdCaja { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Caja { get; set; } = null!;
}
