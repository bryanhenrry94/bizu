using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaFacturaEdehsa
{
    public long IdEmpresa { get; set; }

    public long IdSucursal { get; set; }

    public long IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodCbteVta { get; set; } = null!;

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtTipoDoc { get; set; } = null!;

    [Column("vt_serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie1 { get; set; }

    [Column("vt_serie2")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie2 { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNumFactura { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_plazo")]
    [Precision(18, 0)]
    public decimal VtPlazo { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime VtFechVenc { get; set; }

    [Column("vt_tipo_venta")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtTipoVenta { get; set; } = null!;

    [Column("vt_Observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtObservacion { get; set; } = null!;

    public int IdPeriodo { get; set; }

    [Column("vt_anio")]
    public int VtAnio { get; set; }

    [Column("vt_mes")]
    public int VtMes { get; set; }

    [Column("vt_flete")]
    public double VtFlete { get; set; }

    [Column("vt_interes")]
    public double VtInteres { get; set; }

    [Column("vt_OtroValor1")]
    public double VtOtroValor1 { get; set; }

    [Column("vt_OtroValor2")]
    public double VtOtroValor2 { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [Column("nom_pc")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    public int Secuencia { get; set; }

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("vt_autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtAutorizacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    public int IdCaja { get; set; }

    [Column("IdEmpresa_nc_anu")]
    public int? IdEmpresaNcAnu { get; set; }

    [Column("IdSucursal_nc_anu")]
    public int? IdSucursalNcAnu { get; set; }

    [Column("IdBodega_nc_anu")]
    public int? IdBodegaNcAnu { get; set; }

    [Column("IdNota_nc_anu")]
    [Precision(18, 0)]
    public decimal? IdNotaNcAnu { get; set; }

    [Column("vt_seguro")]
    public double VtSeguro { get; set; }

    [Column("vt_Subtotal")]
    public double? VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double? VtIva { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    [Column("vt_Subtotal0")]
    public double? VtSubtotal0 { get; set; }

    [Column("vt_SubtotalIva")]
    public double? VtSubtotalIva { get; set; }

    public int? IdPuntoVta { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdOferta { get; set; }

    [Precision(18, 0)]
    public decimal? IdPlanilla { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [Column("vt_referencia")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtReferencia { get; set; }
}
