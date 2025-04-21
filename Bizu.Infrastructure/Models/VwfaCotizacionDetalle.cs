using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaCotizacionDetalle
{
    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCotizacion { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("cc_fecha")]
    [MaxLength(6)]
    public DateTime CcFecha { get; set; }

    [Column("cc_diasPlazo")]
    public short CcDiasPlazo { get; set; }

    [Column("cc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CcObservacion { get; set; } = null!;

    [Column("cc_tipopago")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CcTipopago { get; set; } = null!;

    [Column("cc_fechaVencimiento")]
    [MaxLength(6)]
    public DateTime CcFechaVencimiento { get; set; }

    [Column("cc_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CcEstado { get; set; } = null!;

    [Column("cc_dirigidoA")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CcDirigidoA { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    public int Secuencial { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dc_cantidad")]
    public double DcCantidad { get; set; }

    [Column("dc_precio")]
    public double DcPrecio { get; set; }

    [Column("dc_por_desUni")]
    public double DcPorDesUni { get; set; }

    [Column("dc_desUni")]
    public double DcDesUni { get; set; }

    [Column("dc_precioFinal")]
    public double DcPrecioFinal { get; set; }

    [Column("dc_subtotal")]
    public double DcSubtotal { get; set; }

    [Column("dc_iva")]
    public double DcIva { get; set; }

    [Column("dc_total")]
    public double DcTotal { get; set; }

    [Column("dc_pagaIva")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DcPagaIva { get; set; } = null!;

    [Column("dc_detallexItems")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DcDetallexItems { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodCotizacion { get; set; } = null!;
}
