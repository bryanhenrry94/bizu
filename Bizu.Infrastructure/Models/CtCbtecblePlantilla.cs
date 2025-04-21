using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte", "IdPlantilla")]
[Table("ct_cbtecble_Plantilla")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCbtecblePlantilla
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPlantilla { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("cb_Observacion")]
    [StringLength(700)]
    public string CbObservacion { get; set; } = null!;

    [Column("cb_Estado")]
    [StringLength(1)]
    public string CbEstado { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioAnu { get; set; }

    [Column("cb_MotivoAnu")]
    [StringLength(100)]
    public string? CbMotivoAnu { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("cb_FechaAnu")]
    [MaxLength(6)]
    public DateTime? CbFechaAnu { get; set; }

    [Column("cb_FechaTransac")]
    [MaxLength(6)]
    public DateTime CbFechaTransac { get; set; }

    [Column("cb_FechaUltModi")]
    [MaxLength(6)]
    public DateTime? CbFechaUltModi { get; set; }

    [InverseProperty("CtCbtecblePlantilla")]
    public virtual ICollection<CtCbtecblePlantillaDet> CtCbtecblePlantillaDet { get; set; } = new List<CtCbtecblePlantillaDet>();

    [ForeignKey("IdEmpresa, IdTipoCbte")]
    [InverseProperty("CtCbtecblePlantilla")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo { get; set; } = null!;
}
