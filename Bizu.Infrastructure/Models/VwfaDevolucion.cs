using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaDevolucion
{
    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdDevolucion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodDevolucion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("dv_fecha")]
    [MaxLength(6)]
    public DateTime DvFecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("dv_Observacion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DvObservacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("dv_total")]
    public double DvTotal { get; set; }

    [Column("dv_iva")]
    public double DvIva { get; set; }

    [Column("dv_subtotal")]
    public double DvSubtotal { get; set; }

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    [Column("dv_OtroValor2")]
    public double DvOtroValor2 { get; set; }

    [Column("dv_OtroValor1")]
    public double DvOtroValor1 { get; set; }

    [Column("dv_interes")]
    public double DvInteres { get; set; }

    [Column("dv_flete")]
    public double DvFlete { get; set; }

    [Column("dv_seguro")]
    public double DvSeguro { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNumFactura { get; set; }

    [Column("vt_serie2")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie2 { get; set; }

    [Column("vt_serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie1 { get; set; }
}
