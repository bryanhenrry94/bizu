using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwContaRpt005
{
    public int IdEmpresa { get; set; }

    public int IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdPeriodo { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    public double Valor { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoCbte { get; set; } = null!;

    [Column("nom_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCuenta { get; set; } = null!;

    [Column("Naturaleza_cta")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NaturalezaCta { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCblePadre { get; set; }

    public int? AnioFiscal { get; set; }

    public int? IdMes { get; set; }

    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Mes { get; set; }
}
