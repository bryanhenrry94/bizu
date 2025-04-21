using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaVentasXClienteXPeriodoBi
{
    public int IdEmpresa { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Empresa { get; set; } = null!;

    public int IdSucursal { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    public int IdBodega { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Bodega { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Cliente { get; set; } = null!;

    public int IdVendedor { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Vendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Producto { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Categoria { get; set; } = null!;

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

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    public int IdCalendario { get; set; }

    public int? AnioFiscal { get; set; }

    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreMes { get; set; }

    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreFecha { get; set; } = null!;

    [Column("Mes_x_anio")]
    public int? MesXAnio { get; set; }

    [Column("vt_cantidad")]
    public double VtCantidad { get; set; }

    [Column("vt_Subtotal")]
    public double VtSubtotal { get; set; }
}
