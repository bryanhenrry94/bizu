using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaPedidoDetalle
{
    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("cp_fecha")]
    [MaxLength(6)]
    public DateTime CpFecha { get; set; }

    [Column("cp_diasPlazo")]
    public int CpDiasPlazo { get; set; }

    [Column("cp_fechaVencimiento")]
    [MaxLength(6)]
    public DateTime CpFechaVencimiento { get; set; }

    [Column("cp_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CpObservacion { get; set; } = null!;

    [Column("cp_tipopago")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CpTipopago { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdPedido { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dp_cantidad")]
    public double DpCantidad { get; set; }

    [Column("dp_precio")]
    public double DpPrecio { get; set; }

    [Column("dp_PorDescuento")]
    public double DpPorDescuento { get; set; }

    [Column("cp_PrecioFinal")]
    public double CpPrecioFinal { get; set; }

    [Column("cp_desUni")]
    public double CpDesUni { get; set; }

    [Column("dp_subtotal")]
    public double DpSubtotal { get; set; }

    [Column("dp_total")]
    public double DpTotal { get; set; }

    [Column("dp_iva")]
    public double DpIva { get; set; }

    [Column("dp_pagaIva")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DpPagaIva { get; set; } = null!;

    [Column("dp_detallexItems")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DpDetallexItems { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("cod_punto_emision")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodPuntoEmision { get; set; }

    [Column("bo_manejaFacturacion")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BoManejaFacturacion { get; set; }

    [Column("bo_EsBodega")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BoEsBodega { get; set; }

    public int Secuencial { get; set; }

    [Column("interes")]
    public double Interes { get; set; }

    [Column("transporte")]
    public double Transporte { get; set; }

    [Column("otro1")]
    public double Otro1 { get; set; }

    [Column("otro2")]
    public double Otro2 { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodPedido { get; set; }

    [Column("dp_peso")]
    public double? DpPeso { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Entregado { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoProduccion { get; set; }

    [Column("Tiene_Despacho")]
    [StringLength(1)]
    public string TieneDespacho { get; set; } = null!;

    [Column("Esta_en_Base")]
    [StringLength(1)]
    public string EstaEnBase { get; set; } = null!;

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCodImpuestoIva { get; set; }

    [Column("dp_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DpEstado { get; set; }

    [Column("idPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("idPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("dp_por_iva")]
    public double? DpPorIva { get; set; }

    [Column("idCod_Impuesto_Ice")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCodImpuestoIce { get; set; }
}
