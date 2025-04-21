using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaGuiaRemision
{
    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

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

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("gi_cantidad")]
    public double GiCantidad { get; set; }

    [Column("gi_Precio")]
    public double GiPrecio { get; set; }

    [Column("gi_PorDescUnitario")]
    public double GiPorDescUnitario { get; set; }

    [Column("gi_DescUnitario")]
    public double GiDescUnitario { get; set; }

    [Column("gi_PrecioFinal")]
    public double GiPrecioFinal { get; set; }

    [Column("gi_Subtotal")]
    public double GiSubtotal { get; set; }

    [Column("gi_iva")]
    public double GiIva { get; set; }

    [Column("gi_total")]
    public double GiTotal { get; set; }

    [Column("gi_costo")]
    public double GiCosto { get; set; }

    [Column("gi_tieneIVA")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? GiTieneIva { get; set; }

    [Column("gi_detallexItems")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string GiDetallexItems { get; set; } = null!;

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    public int IdBodega { get; set; }

    public int IdSucursal { get; set; }

    public int IdEmpresa { get; set; }

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Precision(18, 0)]
    public decimal Expr1 { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

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

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodGuiaRemision { get; set; } = null!;

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

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodDocumentoTipo { get; set; }

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

    [Column("placa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Placa { get; set; } = null!;
}
