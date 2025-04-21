using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinGuiaXTraspasoBodega
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumGuia { get; set; }

    [Column("IdSucursal_Partida")]
    public int? IdSucursalPartida { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("IdSucursal_Llegada")]
    public int? IdSucursalLlegada { get; set; }

    [Column("Su_Descripcion_Llegada")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcionLlegada { get; set; } = null!;

    [Column("Direc_sucu_Partida")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DirecSucuPartida { get; set; }

    [Column("Direc_sucu_Llegada")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DirecSucuLlegada { get; set; }

    [Precision(18, 0)]
    public decimal? IdTransportista { get; set; }

    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [Column("IdMotivo_Traslado")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdMotivoTraslado { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Traslado")]
    [MaxLength(6)]
    public DateTime? FechaTraslado { get; set; }

    [Column("Fecha_llegada")]
    [MaxLength(6)]
    public DateTime? FechaLlegada { get; set; }

    [Column("Hora_Traslado")]
    [MaxLength(6)]
    public TimeOnly? HoraTraslado { get; set; }

    [Column("Hora_Llegada")]
    [MaxLength(6)]
    public TimeOnly? HoraLlegada { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodDocumentoTipo { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstablecimiento { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdPuntoEmision { get; set; }

    [Column("NumDocumento_Guia")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumentoGuia { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("ced_transportista")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CedTransportista { get; set; }

    [Column("nom_transportista")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTransportista { get; set; }

    [Column("nom_Motivo_Traslado")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomMotivoTraslado { get; set; } = null!;

    [Column("cod_estable_llegada")]
    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodEstableLlegada { get; set; }

    [Column("cod_estable_partida")]
    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodEstablePartida { get; set; }

    [Column("razon_social_empresa")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RazonSocialEmpresa { get; set; } = null!;

    [Column("nom_comercial_empresa")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomComercialEmpresa { get; set; } = null!;

    [Column("contrib_especial_empresa")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ContribEspecialEmpresa { get; set; }

    [Column("obligado_conta_empresa")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObligadoContaEmpresa { get; set; } = null!;

    [Column("ruc_empresa")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RucEmpresa { get; set; } = null!;

    [Column("nom_empresa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEmpresa { get; set; } = null!;

    [Column("direc_empresa")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DirecEmpresa { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Placa { get; set; }
}
