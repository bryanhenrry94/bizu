using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinGeneracionCompraCidersus
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("oc_NumDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcNumDocumento { get; set; } = null!;

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Tipo { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTerminoPago { get; set; } = null!;

    [Column("oc_plazo")]
    public int OcPlazo { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("oc_flete")]
    public double OcFlete { get; set; }

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [Column("co_fecha_aprobacion")]
    [MaxLength(6)]
    public DateTime? CoFechaAprobacion { get; set; }

    [Column("IdUsuario_Aprueba")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [Column("IdUsuario_Reprue")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioReprue { get; set; }

    [Column("co_fechaReproba")]
    [MaxLength(6)]
    public DateTime? CoFechaReproba { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EstadoRecepcion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfectaCosto { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoReprobacion { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Solicitante { get; set; }

    [Column("IdPersona_Sol")]
    [Precision(18, 0)]
    public decimal? IdPersonaSol { get; set; }

    [Precision(18, 0)]
    public decimal? IdDepartamento { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    public int? IdMotivo { get; set; }

    [Column("oc_fechaVencimiento")]
    [MaxLength(6)]
    public DateTime? OcFechaVencimiento { get; set; }

    [Column("IdEstado_cierre")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoCierre { get; set; }

    [Precision(18, 0)]
    public decimal IdComprador { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("do_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DoObservacion { get; set; } = null!;

    [Column("do_peso")]
    public double DoPeso { get; set; }

    [Column("do_Costeado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DoCosteado { get; set; } = null!;

    [Column("do_ManejaIva")]
    public bool DoManejaIva { get; set; }

    [Column("do_total")]
    public double DoTotal { get; set; }

    [Column("do_iva")]
    public double DoIva { get; set; }

    [Column("do_subtotal")]
    public double DoSubtotal { get; set; }

    [Column("do_descuento")]
    public double DoDescuento { get; set; }

    [Column("do_porc_des")]
    public double DoPorcDes { get; set; }

    [Column("do_precioCompra")]
    public double DoPrecioCompra { get; set; }

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    public int Secuencia { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrObservacion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Expr1 { get; set; } = null!;

    [Column("pr_precio_publico")]
    public double PrPrecioPublico { get; set; }

    [Column("pr_precio_mayor")]
    public double PrPrecioMayor { get; set; }

    [Column("pr_precio_minimo")]
    public double PrPrecioMinimo { get; set; }

    [Column("pr_precio_puerta")]
    public double PrPrecioPuerta { get; set; }

    [Column("pr_stock")]
    public int PrStock { get; set; }

    [Column("pr_pedidos")]
    public int PrPedidos { get; set; }

    [Column("pr_ManejaIva")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaIva { get; set; } = null!;

    [Column("pr_ManejaSeries")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrManejaSeries { get; set; } = null!;

    [Column("pr_costo_fob")]
    public double PrCostoFob { get; set; }

    [Column("pr_costo_CIF")]
    public double PrCostoCif { get; set; }

    [Column("pr_costo_promedio")]
    public double PrCostoPromedio { get; set; }

    [Column("IdCtaCble_Vta")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleVta { get; set; }

    [Column("IdCtaCble_CosBaseIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleCosBaseIva { get; set; }

    [Column("IdCtaCble_CosBase0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleCosBase0 { get; set; }

    [Column("IdCtaCble_VenIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleVenIva { get; set; }

    [Column("IdCtaCble_Ven0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleVen0 { get; set; }

    [Column("IdCtaCble_DesIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDesIva { get; set; }

    [Column("IdCtaCble_Des0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDes0 { get; set; }

    [Column("IdCtaCble_DevIva")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDevIva { get; set; }

    [Column("IdCtaCble_Dev0")]
    [MaxLength(0)]
    public byte[]? IdCtaCbleDev0 { get; set; }

    [Column("pr_peso")]
    public double PrPeso { get; set; }

    [Column("pr_profundidad")]
    public double PrProfundidad { get; set; }

    [Column("pr_stock_minimo")]
    public double PrStockMinimo { get; set; }

    [Column("pr_stock_maximo")]
    public double PrStockMaximo { get; set; }
}
