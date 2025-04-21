using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_grupocble")]
[Index("IdGrupoMayor", Name = "FK_ct_grupocble_ct_grupocble_Mayor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupocble
{
    [Key]
    [StringLength(5)]
    public string IdGrupoCble { get; set; } = null!;

    [Column("gc_GrupoCble")]
    [StringLength(50)]
    public string GcGrupoCble { get; set; } = null!;

    [Column("gc_Orden")]
    public byte GcOrden { get; set; }

    [Column("gc_estado_financiero")]
    [StringLength(2)]
    public string GcEstadoFinanciero { get; set; } = null!;

    [Column("gc_signo_operacion")]
    public int? GcSignoOperacion { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("IdGrupo_Mayor")]
    [StringLength(50)]
    public string? IdGrupoMayor { get; set; }

    [InverseProperty("IdGrupoCbleNavigation")]
    public virtual ICollection<CtPlancta> CtPlancta { get; set; } = new List<CtPlancta>();

    [ForeignKey("IdGrupoMayor")]
    [InverseProperty("CtGrupocble")]
    public virtual CtGrupocbleMayor? IdGrupoMayorNavigation { get; set; }
}
