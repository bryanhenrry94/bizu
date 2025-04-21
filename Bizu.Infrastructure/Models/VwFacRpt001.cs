using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt001
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("numDocumento")]
    [StringLength(69)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocumento { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nombreCliente")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCliente { get; set; } = null!;

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    public int IdCalendario { get; set; }

    public int? AnioFiscal { get; set; }

    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreMes { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCortoFecha { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nombreProducto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreProducto { get; set; } = null!;

    [Column("vt_cantidad")]
    public double VtCantidad { get; set; }

    [Column("vt_PrecioFinal")]
    public double VtPrecioFinal { get; set; }

    [Column("vt_Subtotal")]
    public double VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double VtIva { get; set; }

    [Column("vt_total")]
    public double VtTotal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCategoria { get; set; }

    public int? IdLinea { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdSubgrupo { get; set; }

    [Column("ca_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CaCategoria { get; set; }

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomLinea { get; set; }

    [Column("nom_grupo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomGrupo { get; set; }

    [Column("nom_subgrupo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSubgrupo { get; set; }

    [Column("Idtipo_cliente")]
    public int IdtipoCliente { get; set; }

    [Column("Descripcion_tip_cliente")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionTipCliente { get; set; } = null!;

    [Column("vt_Observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtObservacion { get; set; } = null!;

    public int IdVendedor { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Vendedor { get; set; }
}
