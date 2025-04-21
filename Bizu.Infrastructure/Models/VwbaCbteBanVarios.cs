using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaCbteBanVarios
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("IdTipo_op")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoOp { get; set; } = null!;

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    public int? IdBanco { get; set; }

    [Column("IdEmpresa_ban")]
    public int IdEmpresaBan { get; set; }

    [Column("IdCbteCble_ban")]
    [Precision(18, 0)]
    public decimal IdCbteCbleBan { get; set; }

    [Column("IdTipocbte_ban")]
    public int IdTipocbteBan { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }
}
