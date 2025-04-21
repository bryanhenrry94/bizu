using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebXCxcCobro
{
    [Column("IdEmpresa_cbr")]
    public int IdEmpresaCbr { get; set; }

    [Column("IdSucursal_cbr")]
    public int IdSucursalCbr { get; set; }

    [Column("IdCobro_cbr")]
    [Precision(18, 0)]
    public decimal IdCobroCbr { get; set; }

    [Column("IdEmpresa_nt")]
    public int IdEmpresaNt { get; set; }

    [Column("IdSucursal_nt")]
    public int IdSucursalNt { get; set; }

    [Column("IdBodega_nt")]
    public int IdBodegaNt { get; set; }

    [Column("IdNota_nt")]
    [Precision(18, 0)]
    public decimal IdNotaNt { get; set; }

    [Column("Valor_cobro")]
    public double ValorCobro { get; set; }

    [Column("cr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrEstado { get; set; }
}
