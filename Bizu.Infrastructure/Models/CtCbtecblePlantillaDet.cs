using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte", "IdPlantilla", "Secuencia")]
[Table("ct_cbtecble_Plantilla_det")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_ct_cbtecble_Plantilla_det_ct_centro_costo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_cbtecble_Plantilla_det_ct_plancta")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_ct_cbtecble_Plantilla_det_ct_punto_cargo")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_ct_cbtecble_Plantilla_det_ct_punto_cargo_grupo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCbtecblePlantillaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPlantilla { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [Column("dc_Observacion")]
    [StringLength(750)]
    public string DcObservacion { get; set; } = null!;

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbte, IdPlantilla")]
    [InverseProperty("CtCbtecblePlantillaDet")]
    public virtual CtCbtecblePlantilla CtCbtecblePlantilla { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CtCbtecblePlantillaDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtCbtecblePlantillaDet")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("CtCbtecblePlantillaDet")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("CtCbtecblePlantillaDet")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }
}
