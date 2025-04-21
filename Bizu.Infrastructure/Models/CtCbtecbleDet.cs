using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte", "IdCbteCble", "Secuencia")]
[Table("ct_cbtecble_det")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_ct_cbtecble_det_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_cbtecble_det_ct_plancta")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_ct_cbtecble_det_ct_punto_cargo")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_ct_cbtecble_det_ct_punto_cargo_grupo")]
[Index("IdEmpresa", "IdTipoCbte", "IdCbteCble", "Secuencia", "IdCtaCble", Name = "IX_ct_cbtecble_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCbtecbleDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [Column("dc_Observacion")]
    public string DcObservacion { get; set; } = null!;

    [Column("dc_Numconciliacion")]
    [Precision(18, 0)]
    public decimal? DcNumconciliacion { get; set; }

    [Column("dc_EstaConciliado")]
    [StringLength(1)]
    public string? DcEstaConciliado { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("dc_para_conciliar")]
    public bool? DcParaConciliar { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbte, IdCbteCble")]
    [InverseProperty("CtCbtecbleDet")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CtCbtecbleDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("CtCbtecbleDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtCbtecbleDet")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("CtCbtecbleDet")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("CtCbtecbleDet")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }
}
