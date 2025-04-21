using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_GrupoEmpresarial_grupocble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupoEmpresarialGrupocble
{
    [Key]
    [Column("IdGrupoCble_gr")]
    [StringLength(5)]
    public string IdGrupoCbleGr { get; set; } = null!;

    [Column("gc_GrupoCble_gr")]
    [StringLength(50)]
    public string GcGrupoCbleGr { get; set; } = null!;

    [Column("gc_Orden")]
    public int GcOrden { get; set; }

    [Column("gc_estado_financiero")]
    [StringLength(50)]
    public string GcEstadoFinanciero { get; set; } = null!;

    [Column("gc_signo_operacion")]
    public int GcSignoOperacion { get; set; }

    [InverseProperty("IdGrupoCbleGrNavigation")]
    public virtual ICollection<CtGrupoEmpresarialPlancta> CtGrupoEmpresarialPlancta { get; set; } = new List<CtGrupoEmpresarialPlancta>();
}
