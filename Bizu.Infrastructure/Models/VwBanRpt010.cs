using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt010
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Precision(18, 0)]
    public decimal IdTipocbte { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    public int IdPeriodo { get; set; }

    public int IdBanco { get; set; }

    [Column("nom_Banco")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBanco { get; set; } = null!;

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("nom_CtaCble")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCtaCble { get; set; } = null!;

    public double? Debito { get; set; }

    public double? Haber { get; set; }

    [Column("referencia")]
    [StringLength(72)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Concepto { get; set; }

    [Column("ruc_empresa")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RucEmpresa { get; set; } = null!;

    [Column("nom_empresa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEmpresa { get; set; } = null!;
}
