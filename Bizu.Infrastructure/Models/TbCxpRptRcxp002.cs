using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbCXP_Rpt_RCXP002")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxpRptRcxp002
{
    [StringLength(50)]
    public string? IdCtaCble { get; set; }

    [StringLength(250)]
    public string? NomCtaCble { get; set; }

    public double? Debe { get; set; }

    public double? Haber { get; set; }

    [StringLength(150)]
    public string? Observacion { get; set; }

    [StringLength(250)]
    public string? Caja { get; set; }

    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [StringLength(50)]
    public string? NumCheque { get; set; }

    public int? IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal? IdConciliacionCaja { get; set; }

    public int? IdCaja { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }
}
