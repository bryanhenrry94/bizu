using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreditoEdehsa
{
    public long IdEmpresa { get; set; }

    public long IdSucursal { get; set; }

    public long IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CreDeb { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("no_fecha")]
    [MaxLength(6)]
    public DateTime NoFecha { get; set; }

    public int IdTipoNota { get; set; }

    [Column("sc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ScObservacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdDevolucion { get; set; }

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
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotiAnula { get; set; }

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

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodNota { get; set; } = null!;

    [Column("no_dev_venta")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NoDevVenta { get; set; }

    [Column("no_fecha_venc")]
    [MaxLength(6)]
    public DateTime? NoFechaVenc { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("interes")]
    public double? Interes { get; set; }

    [Column("valor1")]
    public double? Valor1 { get; set; }

    [Column("valor2")]
    public double? Valor2 { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Column("NumNota_Impresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumNotaImpresa { get; set; }

    [Column("flete")]
    public double? Flete { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NaturalezaNota { get; set; }

    [Column("seguro")]
    public double? Seguro { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    public int IdCaja { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Caja { get; set; } = null!;

    [Column("IdEmpresa_fac_doc_mod")]
    public int? IdEmpresaFacDocMod { get; set; }

    [Column("IdSucursal_fac_doc_mod")]
    public int? IdSucursalFacDocMod { get; set; }

    [Column("IdBodega_fac_doc_mod")]
    public int? IdBodegaFacDocMod { get; set; }

    [Column("IdCbteVta_fac_doc_mod")]
    [Precision(18, 0)]
    public decimal? IdCbteVtaFacDocMod { get; set; }

    [Column("IdCtaCble_TipoNota")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleTipoNota { get; set; }

    [Column("fecha_Ctble")]
    [MaxLength(6)]
    public DateTime? FechaCtble { get; set; }

    [Column("sc_subtotal")]
    public double? ScSubtotal { get; set; }

    [Column("sc_total")]
    public double? ScTotal { get; set; }

    [Column("sc_iva")]
    public double? ScIva { get; set; }

    [Column("vt_subtotal0")]
    public double? VtSubtotal0 { get; set; }

    [Column("vt_subtotalIva")]
    public double? VtSubtotalIva { get; set; }

    public int? IdPuntoVta { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdOferta { get; set; }

    public int? IdPlanilla { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Column("Fecha_Autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }
}
