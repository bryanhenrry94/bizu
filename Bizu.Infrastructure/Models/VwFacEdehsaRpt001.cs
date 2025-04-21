using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacEdehsaRpt001
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [StringLength(4)]
    public string TipoDoc { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nom_cliente")]
    [StringLength(251)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCliente { get; set; } = null!;

    [Column(TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Documento { get; set; }

    [Column("vt_cantidad")]
    public double VtCantidad { get; set; }

    [Column("vt_Precio")]
    public double VtPrecio { get; set; }

    [Column("vt_venta_bruta")]
    public double VtVentaBruta { get; set; }

    [Column("vt_venta_neta")]
    public double VtVentaNeta { get; set; }

    [Column("vt_DescUnitario")]
    public double VtDescUnitario { get; set; }

    [Column("vt_PorDescUnitario")]
    public double VtPorDescUnitario { get; set; }

    [Column("vt_Subtotal")]
    public double VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double VtIva { get; set; }

    [Column("vt_por_iva")]
    public double VtPorIva { get; set; }

    [Column("vt_total")]
    public double VtTotal { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_descripcion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }
}
