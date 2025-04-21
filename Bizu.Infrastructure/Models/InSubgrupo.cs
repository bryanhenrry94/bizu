using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoria", "IdLinea", "IdGrupo", "IdSubgrupo")]
[Table("in_subgrupo")]
[Index("IdEmpresa", "IdCtaCtbleCosto", Name = "FK_in_subgrupo_ct_plancta")]
[Index("IdEmpresa", "IdCtaCtbleInve", Name = "FK_in_subgrupo_ct_plancta1")]
[Index("IdEmpresa", "IdCtaCbleDev0", Name = "FK_in_subgrupo_ct_plancta11")]
[Index("IdEmpresa", "IdCtaCtbleGastoXCxp", Name = "FK_in_subgrupo_ct_plancta2")]
[Index("IdEmpresa", "IdCtaCbleVta", Name = "FK_in_subgrupo_ct_plancta3")]
[Index("IdEmpresa", "IdCtaCbleDes0", Name = "FK_in_subgrupo_ct_plancta9")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InSubgrupo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Key]
    public int IdLinea { get; set; }

    [Key]
    public int IdGrupo { get; set; }

    [Key]
    public int IdSubgrupo { get; set; }

    [Column("abreviatura")]
    [StringLength(10)]
    public string Abreviatura { get; set; } = null!;

    [Column("cod_subgrupo")]
    [StringLength(50)]
    public string CodSubgrupo { get; set; } = null!;

    [Column("nom_subgrupo")]
    [StringLength(150)]
    public string NomSubgrupo { get; set; } = null!;

    [Column("observacion")]
    [StringLength(150)]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("IdCtaCtble_Inve")]
    [StringLength(20)]
    public string? IdCtaCtbleInve { get; set; }

    [Column("IdCtaCtble_Costo")]
    [StringLength(20)]
    public string? IdCtaCtbleCosto { get; set; }

    [Column("IdCtaCtble_Gasto_x_cxp")]
    [StringLength(20)]
    public string? IdCtaCtbleGastoXCxp { get; set; }

    [Column("IdCtaCble_Vta")]
    [StringLength(20)]
    public string? IdCtaCbleVta { get; set; }

    [Column("IdCtaCble_Des0")]
    [StringLength(20)]
    public string? IdCtaCbleDes0 { get; set; }

    [Column("IdCtaCble_Dev0")]
    [StringLength(20)]
    public string? IdCtaCbleDev0 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleDes0")]
    [InverseProperty("InSubgrupoCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleVta")]
    [InverseProperty("InSubgrupoCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCtbleCosto")]
    [InverseProperty("InSubgrupoCtPlancta2")]
    public virtual CtPlancta? CtPlancta2 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCtbleGastoXCxp")]
    [InverseProperty("InSubgrupoCtPlancta3")]
    public virtual CtPlancta? CtPlancta3 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCtbleInve")]
    [InverseProperty("InSubgrupoCtPlancta4")]
    public virtual CtPlancta? CtPlancta4 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleDev0")]
    [InverseProperty("InSubgrupoCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdCategoria, IdLinea, IdGrupo")]
    [InverseProperty("InSubgrupo")]
    public virtual InGrupo InGrupo { get; set; } = null!;

    [InverseProperty("InSubgrupo")]
    public virtual ICollection<InProducto> InProducto { get; set; } = new List<InProducto>();

    [InverseProperty("InSubgrupo")]
    public virtual ICollection<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble> InSubgrupoXCentroCostoXSubCentroCostoXCtaCble { get; set; } = new List<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble>();
}
