using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPeriodo", "IdCtaCble", "IdCbteCble", "IdTipoCbte")]
[Table("ct_rpt_MovxCta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtRptMovxCta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdPeriodo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Key]
    public byte IdTipoCbte { get; set; }

    public DateOnly? FechaCbte { get; set; }

    [StringLength(20)]
    public string CodCbteCble { get; set; } = null!;

    [Column("sTipoCbte")]
    [StringLength(50)]
    public string STipoCbte { get; set; } = null!;

    [StringLength(200)]
    public string Observacion { get; set; } = null!;

    public double Debito { get; set; }

    public double Credito { get; set; }

    public double Saldo { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Nom_Pc")]
    [StringLength(20)]
    public string? NomPc { get; set; }
}
