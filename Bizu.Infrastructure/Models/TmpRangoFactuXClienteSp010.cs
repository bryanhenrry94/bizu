using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tmp_Rango_Factu_x_Cliente_SP010")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class TmpRangoFactuXClienteSp010
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeNombreCompleto { get; set; }

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCedulaRuc { get; set; }

    [Column("Id_Rango")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdRango { get; set; }

    public double? Monto { get; set; }

    public double? TotalCobrado { get; set; }

    [Column("Valor_Vencido")]
    public double? ValorVencido { get; set; }

    [Column("Valor_x_Vencer")]
    public double? ValorXVencer { get; set; }
}
