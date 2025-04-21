using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class Movimientos
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(10)]
    public string? Tipo { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdEmpresa_pago")]
    public int? IdEmpresaPago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int? IdTipoCbtePago { get; set; }

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal? IdCbteCblePago { get; set; }

    [Column("IdEmpresaOP")]
    public int? IdEmpresaOp { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenPago { get; set; }

    [StringLength(50)]
    public string? Documento { get; set; }

    public DateOnly? Fecha { get; set; }

    [Precision(18, 2)]
    public decimal Debe { get; set; }

    [Precision(18, 2)]
    public decimal Haber { get; set; }

    [StringLength(500)]
    public string Observacion { get; set; } = null!;

    public int Orden { get; set; }

    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;
}
