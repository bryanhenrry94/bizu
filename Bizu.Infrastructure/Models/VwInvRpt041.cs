using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt041
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    public int? IdBodega { get; set; }

    public DateOnly FechaEmision { get; set; }

    public DateOnly FechaTrasladoIni { get; set; }

    public DateOnly FechaTrasladoFin { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoPersona { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdEntidad { get; set; }

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Origen { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Destino { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    public int IdMotivo { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Codigo { get; set; } = null!;

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [Column("Detalle_x_Item")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DetalleXItem { get; set; }

    public double Cantidad { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    public double? Peso { get; set; }

    [Column("Cantidad_sinConversion")]
    public double? CantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedidaSinConversion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmbarqueTipo { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Ruta { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Contenedor { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sello { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Vapor { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Embalaje { get; set; }

    public double PesoNeto { get; set; }

    public double PesoBruto { get; set; }

    [Column("Exportador_nombre")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ExportadorNombre { get; set; }

    [Column("Exportador_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ExportadorDireccion { get; set; }

    [Column("Exportador_correo")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ExportadorCorreo { get; set; }

    [Column("Exportador_telefono")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ExportadorTelefono { get; set; }

    [Column("Exportador_fax")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ExportadorFax { get; set; }

    [Column("Comprador_nombre")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CompradorNombre { get; set; }

    [Column("Comprador_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CompradorDireccion { get; set; }

    [Column("Comprador_correo")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CompradorCorreo { get; set; }

    [Column("Comprador_telefono")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CompradorTelefono { get; set; }

    [Column("Comprador_fax")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CompradorFax { get; set; }
}
