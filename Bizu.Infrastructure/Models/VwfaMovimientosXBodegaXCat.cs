using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaMovimientosXBodegaXCat
{
    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime? CmFecha { get; set; }

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CmObservacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoMoviInvent { get; set; }

    [Column("ca_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CaCategoria { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCategoria { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BoDescripcion { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SuDescripcion { get; set; }

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    public int IdBodega { get; set; }

    public int IdSucursal { get; set; }

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNumFactura { get; set; }

    [Column("vt_Observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtObservacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodGuiaRemision { get; set; }

    [Column("NumGuia_Preimpresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumGuiaPreimpresa { get; set; }

    [Column("NUAutorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nuautorizacion { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("pr_peso")]
    public double PrPeso { get; set; }

    [Column("pesototal")]
    public double Pesototal { get; set; }
}
