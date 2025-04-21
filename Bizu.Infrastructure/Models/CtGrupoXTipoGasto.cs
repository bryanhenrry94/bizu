using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoGasto")]
[Table("ct_grupo_x_Tipo_Gasto")]
[Index("IdEmpresa", "IdTipoGastoPadre", Name = "FK_ct_grupo_x_Tipo_Gasto_ct_grupo_x_Tipo_Gasto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtGrupoXTipoGasto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdTipo_Gasto")]
    public int IdTipoGasto { get; set; }

    [Column("IdTipo_Gasto_Padre")]
    public int? IdTipoGastoPadre { get; set; }

    [Column("nom_tipo_Gasto")]
    [StringLength(50)]
    public string NomTipoGasto { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    [Column("nivel")]
    public int? Nivel { get; set; }

    [Column("orden")]
    public int? Orden { get; set; }

    [ForeignKey("IdEmpresa, IdTipoGastoPadre")]
    [InverseProperty("InverseCtGrupoXTipoGastoNavigation")]
    public virtual CtGrupoXTipoGasto? CtGrupoXTipoGastoNavigation { get; set; }

    [InverseProperty("CtGrupoXTipoGasto")]
    public virtual ICollection<CtPlancta> CtPlancta { get; set; } = new List<CtPlancta>();

    [InverseProperty("CtGrupoXTipoGastoNavigation")]
    public virtual ICollection<CtGrupoXTipoGasto> InverseCtGrupoXTipoGastoNavigation { get; set; } = new List<CtGrupoXTipoGasto>();
}
