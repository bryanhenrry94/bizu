using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcRpt014
{
    public int IdEmpresa { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(28)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNumFactura { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("vt_cantidad")]
    public double VtCantidad { get; set; }

    [Column("vt_total")]
    public double VtTotal { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    public int IdVendedor { get; set; }

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }
}
