using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCompRpt009
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("plazo")]
    public int Plazo { get; set; }

    [Column("fecha_vtc")]
    [MaxLength(6)]
    public DateTime FechaVtc { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacion { get; set; }

    [Column("nom_EstadoAprobacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoAprobacion { get; set; } = null!;

    [Column("IdPersona_Solicita")]
    [Precision(18, 0)]
    public decimal IdPersonaSolicita { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Solicitante { get; set; } = null!;

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodProducto { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProducto { get; set; }

    [Column("Cantidad_Solicitada")]
    public double CantidadSolicitada { get; set; }

    [Column("Cantidad_Comprada")]
    public double CantidadComprada { get; set; }

    [Column("Cantidad_Pendiente")]
    public double CantidadPendiente { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [Column("nom_Unidad")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomUnidad { get; set; }

    [Column("nom_Unidad_Alterno")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomUnidadAlterno { get; set; }

    [Column("do_observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DoObservacion { get; set; }
}
