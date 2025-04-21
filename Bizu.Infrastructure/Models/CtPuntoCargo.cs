using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPuntoCargo")]
[Table("ct_punto_cargo")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_ct_punto_cargo_ct_punto_cargo_grupo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtPuntoCargo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdPunto_cargo")]
    public int IdPuntoCargo { get; set; }

    [Column("codPunto_cargo")]
    [StringLength(20)]
    public string CodPuntoCargo { get; set; } = null!;

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    public string NomPuntoCargo { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; } = new List<ComOrdencompraLocalDet>();

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; } = new List<ComSolicitudCompraDet>();

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacion { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<CpProveedor> CpProveedor { get; set; } = new List<CpProveedor>();

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<CtCbtecbleDet> CtCbtecbleDet { get; set; } = new List<CtCbtecbleDet>();

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<CtCbtecblePlantillaDet> CtCbtecblePlantillaDet { get; set; } = new List<CtCbtecblePlantillaDet>();

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("CtPuntoCargo")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<FaFacturaDetOtrosCampos> FaFacturaDetOtrosCampos { get; set; } = new List<FaFacturaDetOtrosCampos>();

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("CtPuntoCargo")]
    public virtual ICollection<InTransferenciaDet> InTransferenciaDet { get; set; } = new List<InTransferenciaDet>();
}
