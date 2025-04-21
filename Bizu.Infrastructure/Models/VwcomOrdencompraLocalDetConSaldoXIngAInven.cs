using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalDetConSaldoXIngAInven
{
    public int? IdEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("secuencia_oc_det")]
    public int SecuenciaOcDet { get; set; }

    [Column("nom_sucu")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSucu { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Tipo { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime? OcFecha { get; set; }

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? OcObservacion { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("oc_precio")]
    public double OcPrecio { get; set; }

    [Column("secuencia_inv_det")]
    public int? SecuenciaInvDet { get; set; }

    [Column("cantidad_pedida_OC")]
    public double CantidadPedidaOc { get; set; }

    [Column("pr_stock")]
    public double PrStock { get; set; }

    [Column("pr_peso")]
    public double PrPeso { get; set; }

    public double CostoProducto { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacionCat { get; set; }

    [StringLength(11)]
    public string IdEstadoRecepcion { get; set; } = null!;

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

    [Column("Nom_Motivo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMotivo { get; set; }

    [MaxLength(0)]
    public byte[]? Referencia { get; set; }

    [Column("IdMotivo_oc")]
    public int? IdMotivoOc { get; set; }

    [Column("Fecha_ing_bod")]
    [MaxLength(6)]
    public DateTime? FechaIngBod { get; set; }

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [Column("cantidad_ing_a_Inven")]
    public double? CantidadIngAInven { get; set; }

    [Column("cantidad_ingresada")]
    public double? CantidadIngresada { get; set; }

    [Column("IdEstado_cierre")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoCierre { get; set; }

    [Column("nom_estado_cierre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomEstadoCierre { get; set; }

    [Column("Nomsub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomsubCentroCosto { get; set; }

    [Column("do_descuento")]
    public double DoDescuento { get; set; }

    [Column("do_precioFinal")]
    public double DoPrecioFinal { get; set; }

    [Column("do_subtotal")]
    public double DoSubtotal { get; set; }

    [Column("do_iva")]
    public double DoIva { get; set; }

    [Column("do_total")]
    public double DoTotal { get; set; }

    [Column("IdUnidadMedida_Consumo")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaConsumo { get; set; } = null!;

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("oc_NumDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? OcNumDocumento { get; set; }

    public int? IdBodegaProducto { get; set; }

    [Column("detalle_x_tiem")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DetalleXTiem { get; set; } = null!;

    public int IdProductoTipo { get; set; }
}
