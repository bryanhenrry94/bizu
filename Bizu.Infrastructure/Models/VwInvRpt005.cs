using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt005
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    public int? IdBodega { get; set; }

    public int IdSucursal { get; set; }

    [Column("dm_stock_ante")]
    public double DmStockAnte { get; set; }

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("dm_stock_actu")]
    public double DmStockActu { get; set; }

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoMovimiento { get; set; } = null!;

    [Column("dm_cantidad_sinConversion")]
    public double DmCantidadSinConversion { get; set; }

    [Column("mv_costo_sinConversion")]
    public double? MvCostoSinConversion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaSinConversion { get; set; } = null!;

    [Column("signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Signo { get; set; } = null!;
}
