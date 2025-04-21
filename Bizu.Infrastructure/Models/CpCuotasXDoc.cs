using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCuota")]
[Table("cp_cuotas_x_doc")]
[Index("IdEmpresaCt", "IdTipoCbte", "IdCbteCble", Name = "FK_cp_cuotas_x_doc_ct_cbtecble1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCuotasXDoc
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCuota { get; set; }

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    public int? IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteCble { get; set; }

    [Column("Total_a_pagar")]
    public double TotalAPagar { get; set; }

    [Column("Num_cuotas")]
    public int NumCuotas { get; set; }

    [Column("Dias_plazo")]
    public int DiasPlazo { get; set; }

    [Column("Fecha_inicio")]
    [MaxLength(6)]
    public DateTime FechaInicio { get; set; }

    public bool Estado { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    [InverseProperty("CpCuotasXDoc")]
    public virtual ICollection<CpCuotasXDocDet> CpCuotasXDocDet { get; set; } = new List<CpCuotasXDocDet>();

    [ForeignKey("IdEmpresaCt, IdTipoCbte, IdCbteCble")]
    [InverseProperty("CpCuotasXDoc")]
    public virtual CtCbtecble? CtCbtecble { get; set; }
}
