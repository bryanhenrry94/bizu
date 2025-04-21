using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoNota")]
[Table("ba_tipo_nota")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_ba_tipo_nota_ct_centro_costo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ba_tipo_nota_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaTipoNota
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoNota { get; set; }

    [StringLength(5)]
    public string Tipo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [InverseProperty("BaTipoNota")]
    public virtual ICollection<BaCbteBan> BaCbteBan { get; set; } = new List<BaCbteBan>();

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("BaTipoNota")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("BaTipoNota")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("BaTipoNota")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("BaTipoNota")]
    public virtual ICollection<TbBancoProcesosBancariosXEmpresa> TbBancoProcesosBancariosXEmpresa { get; set; } = new List<TbBancoProcesosBancariosXEmpresa>();
}
