using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt008
{
    public int IdEmpresa { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_factura")]
    [StringLength(56)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoFactura { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_codigo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    public int IdClaseProveedor { get; set; }

    [Column("cod_clase_proveedor")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodClaseProveedor { get; set; } = null!;

    [Column("descripcion_clas_prove")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionClasProve { get; set; } = null!;

    [Column("valor_fa")]
    public double ValorFa { get; set; }

    [Column("valor_nc")]
    public double ValorNc { get; set; }

    [Column("valor_ba")]
    public double ValorBa { get; set; }

    [Column("valor_ret")]
    public double ValorRet { get; set; }

    public double Total { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(14)]
    public string Documento { get; set; } = null!;
}
