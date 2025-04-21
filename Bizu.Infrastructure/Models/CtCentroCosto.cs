using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCentroCosto")]
[Table("ct_centro_costo")]
[Index("IdEmpresa", "IdCentroCostoPadre", Name = "FK_ct_centro_costo_ct_centro_costo")]
[Index("IdEmpresa", "IdNivel", Name = "FK_ct_centro_costo_ct_centro_costo_nivel")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_centro_costo_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCentroCosto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [StringLength(20)]
    public string CodCentroCosto { get; set; } = null!;

    [Column("Centro_costo")]
    [StringLength(250)]
    public string CentroCosto { get; set; } = null!;

    [StringLength(20)]
    public string? IdCentroCostoPadre { get; set; }

    [Precision(18, 0)]
    public decimal? IdCatalogo { get; set; }

    [Column("pc_EsMovimiento")]
    [StringLength(1)]
    public string PcEsMovimiento { get; set; } = null!;

    public int IdNivel { get; set; }

    [Column("pc_Estado")]
    [StringLength(1)]
    public string PcEstado { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(150)]
    public string? MotivoAnulacion { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<AfActivoFijoCtasCbles> AfActivoFijoCtasCbles { get; set; } = new List<AfActivoFijoCtasCbles>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoCtCentroCosto { get; set; } = new List<AfCambioUbicacionActivo>();

    [InverseProperty("CtCentroCostoNavigation")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoCtCentroCostoNavigation { get; set; } = new List<AfCambioUbicacionActivo>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<BaTipoNota> BaTipoNota { get; set; } = new List<BaTipoNota>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CajCajaMovimientoDet> CajCajaMovimientoDet { get; set; } = new List<CajCajaMovimientoDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; } = new List<ComSolicitudCompraDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacion { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CpAprobacionIngBodXOcDet> CpAprobacionIngBodXOcDet { get; set; } = new List<CpAprobacionIngBodXOcDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CpConciliacionCajaDet> CpConciliacionCajaDet { get; set; } = new List<CpConciliacionCajaDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCre { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiro { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CpOrdenPagoTipoXEmpresa> CpOrdenPagoTipoXEmpresa { get; set; } = new List<CpOrdenPagoTipoXEmpresa>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CtCbtecbleDet> CtCbtecbleDet { get; set; } = new List<CtCbtecbleDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CtCbtecblePlantillaDet> CtCbtecblePlantillaDet { get; set; } = new List<CtCbtecblePlantillaDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual CtCentroCostoEstadoCierre? CtCentroCostoEstadoCierre { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoPadre")]
    [InverseProperty("InverseCtCentroCostoNavigation")]
    public virtual CtCentroCosto? CtCentroCostoNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdNivel")]
    [InverseProperty("CtCentroCosto")]
    public virtual CtCentroCostoNivel CtCentroCostoNivel { get; set; } = null!;

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CtCentroCostoSubCentroCosto> CtCentroCostoSubCentroCosto { get; set; } = new List<CtCentroCostoSubCentroCosto>();

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtCentroCosto")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CxcAnticipoFacturado> CxcAnticipoFacturado { get; set; } = new List<CxcAnticipoFacturado>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CxcCobroDet> CxcCobroDet { get; set; } = new List<CxcCobroDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<CxcCobroXAnticipoDet> CxcCobroXAnticipoDet { get; set; } = new List<CxcCobroXAnticipoDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<FaCliente> FaClienteCtCentroCosto { get; set; } = new List<FaCliente>();

    [InverseProperty("CtCentroCosto1")]
    public virtual ICollection<FaCliente> FaClienteCtCentroCosto1 { get; set; } = new List<FaCliente>();

    [InverseProperty("CtCentroCostoNavigation")]
    public virtual ICollection<FaCliente> FaClienteCtCentroCostoNavigation { get; set; } = new List<FaCliente>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<FaClienteObra> FaClienteObra { get; set; } = new List<FaClienteObra>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<FaFacturaEdehsa> FaFacturaEdehsa { get; set; } = new List<FaFacturaEdehsa>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InAjusteFisicoDetalle> InAjusteFisicoDetalle { get; set; } = new List<InAjusteFisicoDetalle>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InGuiaRemision> InGuiaRemision { get; set; } = new List<InGuiaRemision>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InGuiaRemisionDet> InGuiaRemisionDet { get; set; } = new List<InGuiaRemisionDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InIngEgrInven> InIngEgrInven { get; set; } = new List<InIngEgrInven>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InMoviInveDetalle> InMoviInveDetalle { get; set; } = new List<InMoviInveDetalle>();

    [InverseProperty("CtCentroCosto")]
    public virtual ICollection<InParametro> InParametroCtCentroCosto { get; set; } = new List<InParametro>();

    [InverseProperty("CtCentroCostoNavigation")]
    public virtual ICollection<InParametro> InParametroCtCentroCostoNavigation { get; set; } = new List<InParametro>();

    [InverseProperty("CtCentroCostoNavigation")]
    public virtual ICollection<CtCentroCosto> InverseCtCentroCostoNavigation { get; set; } = new List<CtCentroCosto>();
}
