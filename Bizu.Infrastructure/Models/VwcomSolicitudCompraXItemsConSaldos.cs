using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomSolicitudCompraXItemsConSaldos
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocumento { get; set; } = null!;

    [Column("IdPersona_Solicita")]
    [Precision(18, 0)]
    public decimal IdPersonaSolicita { get; set; }

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

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [Column("nom_EstadoAprobacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoAprobacion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprobo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAprobacion { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProducto { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProducto1 { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("cant_solicitada")]
    public double CantSolicitada { get; set; }

    [Column("Cantidad_aprobada")]
    public double CantidadAprobada { get; set; }

    [Column("cant_aprobada_OC")]
    public double CantAprobadaOc { get; set; }

    [Column("Saldo_can_SolCom")]
    public double SaldoCanSolCom { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAprobacion { get; set; }

    [Column("observacion_Aprob")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ObservacionAprob { get; set; }

    [Column("IdProveedor_SC")]
    [Precision(18, 0)]
    public decimal? IdProveedorSc { get; set; }

    public int? IdMotivo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [Column("pr_ManejaIva")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrManejaIva { get; set; }

    [Column("Nomsub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomsubCentroCosto { get; set; }

    [Column("do_precioCompra")]
    public double? DoPrecioCompra { get; set; }

    [Column("do_porc_des")]
    public double? DoPorcDes { get; set; }

    [Column("do_descuento")]
    public double? DoDescuento { get; set; }

    [Column("do_subtotal")]
    public double? DoSubtotal { get; set; }

    [Column("do_iva")]
    public double? DoIva { get; set; }

    [Column("do_total")]
    public double? DoTotal { get; set; }

    [Column("do_ManejaIva")]
    public bool? DoManejaIva { get; set; }

    [Column("do_observacion")]
    [StringLength(550)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DoObservacion { get; set; }

    [Column("ocd_IdEmpresa")]
    public int? OcdIdEmpresa { get; set; }

    [Column("ocd_IdSucursal")]
    public int? OcdIdSucursal { get; set; }

    [Column("ocd_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal? OcdIdOrdenCompra { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoPreAprobacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Solicitante { get; set; } = null!;

    [Column("Nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    public double? Stock { get; set; }

    [Column("precio_minimo")]
    public double? PrecioMinimo { get; set; }
}
