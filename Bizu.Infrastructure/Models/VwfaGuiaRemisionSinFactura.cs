using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaGuiaRemisionSinFactura
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodGuiaRemision { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodDocumentoTipo { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Column("NumGuia_Preimpresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumGuiaPreimpresa { get; set; }

    [Column("NUAutorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nuautorizacion { get; set; }

    [Column("Fecha_Autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdTransportista { get; set; }

    [Column("gi_fecha")]
    [MaxLength(6)]
    public DateTime GiFecha { get; set; }

    [Column("gi_plazo")]
    [Precision(18, 0)]
    public decimal? GiPlazo { get; set; }

    [Column("gi_fech_venc")]
    [MaxLength(6)]
    public DateTime? GiFechVenc { get; set; }

    [Column("gi_Observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? GiObservacion { get; set; }

    [Column("gi_TotalKilos")]
    public double? GiTotalKilos { get; set; }

    [Column("gi_TotalQuintales")]
    public double? GiTotalQuintales { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Ip { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotiAnula { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Impreso { get; set; }

    public int? IdPeriodo { get; set; }

    [Column("gi_flete")]
    public double GiFlete { get; set; }

    [Column("gi_interes")]
    public double GiInteres { get; set; }

    [Column("gi_seguro")]
    public double GiSeguro { get; set; }

    [Column("gi_OtroValor1")]
    public double GiOtroValor1 { get; set; }

    [Column("gi_OtroValor2")]
    public double GiOtroValor2 { get; set; }

    [Column("gi_FechaIniTraslado")]
    [MaxLength(6)]
    public DateTime GiFechaIniTraslado { get; set; }

    [Column("gi_FechaFinTraslado")]
    [MaxLength(6)]
    public DateTime GiFechaFinTraslado { get; set; }

    [Column("placa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Placa { get; set; } = null!;

    [Column("ruta")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ruta { get; set; }

    [Column("Direccion_Origen")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DireccionOrigen { get; set; } = null!;

    [Column("Direccion_Destino")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DireccionDestino { get; set; } = null!;

    [Column("idMotivo_traslado")]
    public int? IdMotivoTraslado { get; set; }
}
