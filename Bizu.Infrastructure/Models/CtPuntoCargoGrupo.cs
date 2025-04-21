using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPuntoCargoGrupo")]
[Table("ct_punto_cargo_grupo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_punto_cargo_grupo_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtPuntoCargoGrupo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdPunto_cargo_grupo")]
    public int IdPuntoCargoGrupo { get; set; }

    [Column("cod_Punto_cargo_grupo")]
    [StringLength(25)]
    public string CodPuntoCargoGrupo { get; set; } = null!;

    [Column("nom_punto_cargo_grupo")]
    [StringLength(150)]
    public string NomPuntoCargoGrupo { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; } = new List<ComOrdencompraLocalDet>();

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; } = new List<ComSolicitudCompraDet>();

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacion { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<CpProveedor> CpProveedor { get; set; } = new List<CpProveedor>();

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<CtCbtecbleDet> CtCbtecbleDet { get; set; } = new List<CtCbtecbleDet>();

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<CtCbtecblePlantillaDet> CtCbtecblePlantillaDet { get; set; } = new List<CtCbtecblePlantillaDet>();

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<CtPuntoCargo> CtPuntoCargo { get; set; } = new List<CtPuntoCargo>();

    [InverseProperty("CtPuntoCargoGrupo")]
    public virtual ICollection<InTransferenciaDet> InTransferenciaDet { get; set; } = new List<InTransferenciaDet>();
}
