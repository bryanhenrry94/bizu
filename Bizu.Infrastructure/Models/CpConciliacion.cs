using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacion")]
[Table("cp_conciliacion")]
[Index("IdEmpresaCbtecble", "IdTipoCbteCbtecble", "IdCbteCbleCbtecble", Name = "FK_cp_conciliacion_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpConciliacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public DateOnly Fecha { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(150)]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [Precision(18, 0)]
    public decimal? IdCancelacion { get; set; }

    [Column("Tipo_detalle")]
    [StringLength(20)]
    public string? TipoDetalle { get; set; }

    [StringLength(50)]
    public string? Tipo { get; set; }

    [Column("IdEmpresa_cbtecble")]
    public int? IdEmpresaCbtecble { get; set; }

    [Column("IdTipoCbte_cbtecble")]
    public int? IdTipoCbteCbtecble { get; set; }

    [Column("IdCbteCble_cbtecble")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCbtecble { get; set; }

    [InverseProperty("CpConciliacion")]
    public virtual ICollection<CpConciliacionDet> CpConciliacionDet { get; set; } = new List<CpConciliacionDet>();

    [ForeignKey("IdEmpresaCbtecble, IdTipoCbteCbtecble, IdCbteCbleCbtecble")]
    [InverseProperty("CpConciliacion")]
    public virtual CtCbtecble? CtCbtecble { get; set; }
}
