using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwGeTbTarjetaTbParametro
{
    public int IdTarjeta { get; set; }

    [Column("tr_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TrDescripcion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    public int IdBanco { get; set; }

    public int IdEmpresa { get; set; }

    [Column("IdCtaCble_Comision")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleComision { get; set; }

    [Column("Porcetaje_Comision")]
    public double? PorcetajeComision { get; set; }

    [Column("IdCobro_tipo_x_Tarj")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCobroTipoXTarj { get; set; }

    [Column("IdCobro_tipo_x_RetFu")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCobroTipoXRetFu { get; set; }

    [Column("IdCobro_tipo_x_RetIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCobroTipoXRetIva { get; set; }

    [Column("IdCtaCble_Tarj")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleTarj { get; set; }
}
