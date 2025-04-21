using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto")]
[Table("ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_centro_costo_sub_centro_costo_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCentroCostoSubCentroCosto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [Key]
    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string IdCentroCostoSubCentroCosto { get; set; } = null!;

    [Column("cod_subcentroCosto")]
    [StringLength(25)]
    public string? CodSubcentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(200)]
    public string CentroCosto { get; set; } = null!;

    [Column("pc_Estado")]
    [StringLength(1)]
    public string PcEstado { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<CajCajaMovimientoDet> CajCajaMovimientoDet { get; set; } = new List<CajCajaMovimientoDet>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; } = new List<ComOrdencompraLocalDet>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; } = new List<ComSolicitudCompraDet>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacion { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<CpAprobacionIngBodXOcDet> CpAprobacionIngBodXOcDet { get; set; } = new List<CpAprobacionIngBodXOcDet>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<CpConciliacionCajaDet> CpConciliacionCajaDet { get; set; } = new List<CpConciliacionCajaDet>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<CtCbtecbleDet> CtCbtecbleDet { get; set; } = new List<CtCbtecbleDet>();

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual CtCentroCosto CtCentroCosto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<InIngEgrInven> InIngEgrInven { get; set; } = new List<InIngEgrInven>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<InMoviInveDetalle> InMoviInveDetalle { get; set; } = new List<InMoviInveDetalle>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble> InSubgrupoXCentroCostoXSubCentroCostoXCtaCble { get; set; } = new List<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble>();

    [InverseProperty("CtCentroCostoSubCentroCosto")]
    public virtual ICollection<InTransferenciaDet> InTransferenciaDet { get; set; } = new List<InTransferenciaDet>();
}
