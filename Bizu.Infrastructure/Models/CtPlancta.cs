using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCtaCble")]
[Table("ct_plancta")]
[Index("IdEmpresa", "IdTipoGasto", Name = "FK_ct_plancta_ct_grupo_x_Tipo_Gasto")]
[Index("IdGrupoCble", Name = "FK_ct_plancta_ct_grupocble")]
[Index("IdEmpresa", "IdCtaCblePadre", Name = "FK_ct_plancta_ct_plancta")]
[Index("IdEmpresa", "IdNivelCta", Name = "FK_ct_plancta_ct_plancta_nivel")]
[Index("IdTipoCtaCble", Name = "FK_ct_plancta_ct_tipo_ctacble")]
[Index("IdEmpresa", "IdCtaCble", Name = "IX_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtPlancta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    public string PcCuenta { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCblePadre { get; set; }

    [Precision(18, 0)]
    public decimal? IdCatalogo { get; set; }

    [Column("pc_Naturaleza")]
    [StringLength(1)]
    public string PcNaturaleza { get; set; } = null!;

    public int IdNivelCta { get; set; }

    [StringLength(5)]
    public string IdGrupoCble { get; set; } = null!;

    [StringLength(10)]
    public string? IdTipoCtaCble { get; set; }

    [Column("pc_Estado")]
    [StringLength(1)]
    public string PcEstado { get; set; } = null!;

    [Column("pc_EsMovimiento")]
    [StringLength(1)]
    public string PcEsMovimiento { get; set; } = null!;

    [Column("pc_es_flujo_efectivo")]
    [StringLength(1)]
    public string? PcEsFlujoEfectivo { get; set; }

    [Column("pc_clave_corta")]
    [StringLength(15)]
    public string? PcClaveCorta { get; set; }

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

    [Column("IdTipo_Gasto")]
    public int? IdTipoGasto { get; set; }

    [Column("IdTipo_Costo")]
    public int? IdTipoCosto { get; set; }

    [InverseProperty("CtPlancta")]
    public virtual ICollection<AfActivoFijoCtasCbles> AfActivoFijoCtasCbles { get; set; } = new List<AfActivoFijoCtasCbles>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<AfActivoFijoTipo> AfActivoFijoTipoCtPlancta { get; set; } = new List<AfActivoFijoTipo>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<AfActivoFijoTipo> AfActivoFijoTipoCtPlancta1 { get; set; } = new List<AfActivoFijoTipo>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<AfActivoFijoTipo> AfActivoFijoTipoCtPlanctaNavigation { get; set; } = new List<AfActivoFijoTipo>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<AfParametros> AfParametrosCtPlancta { get; set; } = new List<AfParametros>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<AfParametros> AfParametrosCtPlancta1 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<AfParametros> AfParametrosCtPlanctaNavigation { get; set; } = new List<AfParametros>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<BaBancoCuenta> BaBancoCuenta { get; set; } = new List<BaBancoCuenta>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<BaCbteBanTipoXCtCbteCbleTipo> BaCbteBanTipoXCtCbteCbleTipo { get; set; } = new List<BaCbteBanTipoXCtCbteCbleTipo>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<BaPrestamo> BaPrestamo { get; set; } = new List<BaPrestamo>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<BaTipoNota> BaTipoNota { get; set; } = new List<BaTipoNota>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CajCaja> CajCaja { get; set; } = new List<CajCaja>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CajCajaMovimientoTipoXCtaCble> CajCajaMovimientoTipoXCtaCble { get; set; } = new List<CajCajaMovimientoTipoXCtaCble>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpAprobacionIngBodXOcDet> CpAprobacionIngBodXOcDetCtPlancta { get; set; } = new List<CpAprobacionIngBodXOcDet>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<CpAprobacionIngBodXOcDet> CpAprobacionIngBodXOcDetCtPlanctaNavigation { get; set; } = new List<CpAprobacionIngBodXOcDet>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpCodigoSriXCtaCble> CpCodigoSriXCtaCble { get; set; } = new List<CpCodigoSriXCtaCble>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpConciliacionCaja> CpConciliacionCaja { get; set; } = new List<CpConciliacionCaja>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCreCtPlancta { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCreCtPlanctaNavigation { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiroCtPlancta { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiroCtPlanctaNavigation { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpOrdenPagoTipoXEmpresa> CpOrdenPagoTipoXEmpresa { get; set; } = new List<CpOrdenPagoTipoXEmpresa>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpParametros> CpParametrosCtPlancta { get; set; } = new List<CpParametros>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<CpParametros> CpParametrosCtPlancta1 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtPlancta2")]
    public virtual ICollection<CpParametros> CpParametrosCtPlancta2 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtPlancta3")]
    public virtual ICollection<CpParametros> CpParametrosCtPlancta3 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<CpParametros> CpParametrosCtPlanctaNavigation { get; set; } = new List<CpParametros>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CpProveedor> CpProveedorCtPlancta { get; set; } = new List<CpProveedor>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<CpProveedor> CpProveedorCtPlancta1 { get; set; } = new List<CpProveedor>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<CpProveedor> CpProveedorCtPlanctaNavigation { get; set; } = new List<CpProveedor>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtAnioFiscalXCuentaUtilidad> CtAnioFiscalXCuentaUtilidad { get; set; } = new List<CtAnioFiscalXCuentaUtilidad>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtCbtecbleDet> CtCbtecbleDet { get; set; } = new List<CtCbtecbleDet>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtCbtecblePlantillaDet> CtCbtecblePlantillaDet { get; set; } = new List<CtCbtecblePlantillaDet>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtCentroCosto> CtCentroCosto { get; set; } = new List<CtCentroCosto>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtCentroCostoSubCentroCosto> CtCentroCostoSubCentroCosto { get; set; } = new List<CtCentroCostoSubCentroCosto>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtGrupoEmpresarialPlanctaXCtPlancta> CtGrupoEmpresarialPlanctaXCtPlancta { get; set; } = new List<CtGrupoEmpresarialPlanctaXCtPlancta>();

    [ForeignKey("IdEmpresa, IdTipoGasto")]
    [InverseProperty("CtPlancta")]
    public virtual CtGrupoXTipoGasto? CtGrupoXTipoGasto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCblePadre")]
    [InverseProperty("InverseCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdNivelCta")]
    [InverseProperty("CtPlancta")]
    public virtual CtPlanctaNivel CtPlanctaNivel { get; set; } = null!;

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtPuntoCargoGrupo> CtPuntoCargoGrupo { get; set; } = new List<CtPuntoCargoGrupo>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtSaldoxCuentas> CtSaldoxCuentas { get; set; } = new List<CtSaldoxCuentas>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtSaldoxCuentasMovi> CtSaldoxCuentasMovi { get; set; } = new List<CtSaldoxCuentasMovi>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CtSumatoriaXCuenta> CtSumatoriaXCuenta { get; set; } = new List<CtSumatoriaXCuenta>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<CxcCobroTipoParamContaXSucursal> CxcCobroTipoParamContaXSucursalCtPlancta { get; set; } = new List<CxcCobroTipoParamContaXSucursal>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<CxcCobroTipoParamContaXSucursal> CxcCobroTipoParamContaXSucursalCtPlanctaNavigation { get; set; } = new List<CxcCobroTipoParamContaXSucursal>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<FaCliente> FaClienteCtPlancta { get; set; } = new List<FaCliente>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<FaCliente> FaClienteCtPlancta1 { get; set; } = new List<FaCliente>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<FaCliente> FaClienteCtPlanctaNavigation { get; set; } = new List<FaCliente>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<FaClienteTipo> FaClienteTipoCtPlancta { get; set; } = new List<FaClienteTipo>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<FaClienteTipo> FaClienteTipoCtPlancta1 { get; set; } = new List<FaClienteTipo>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<FaClienteTipo> FaClienteTipoCtPlanctaNavigation { get; set; } = new List<FaClienteTipo>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<FaDescuento> FaDescuento { get; set; } = new List<FaDescuento>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<FaParametro> FaParametroCtPlancta { get; set; } = new List<FaParametro>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<FaParametro> FaParametroCtPlancta1 { get; set; } = new List<FaParametro>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<FaParametro> FaParametroCtPlanctaNavigation { get; set; } = new List<FaParametro>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<FaTipoNotaXEmpresaXSucursal> FaTipoNotaXEmpresaXSucursal { get; set; } = new List<FaTipoNotaXEmpresaXSucursal>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CtPlancta")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdGrupoCble")]
    [InverseProperty("CtPlancta")]
    public virtual CtGrupocble IdGrupoCbleNavigation { get; set; } = null!;

    [ForeignKey("IdTipoCtaCble")]
    [InverseProperty("CtPlancta")]
    public virtual CtTipoCtacble? IdTipoCtaCbleNavigation { get; set; }

    [InverseProperty("CtPlancta")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<InMoviInvenTipoXTbBodega> InMoviInvenTipoXTbBodega { get; set; } = new List<InMoviInvenTipoXTbBodega>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<InParametro> InParametroCtPlancta { get; set; } = new List<InParametro>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<InParametro> InParametroCtPlancta1 { get; set; } = new List<InParametro>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<InParametro> InParametroCtPlanctaNavigation { get; set; } = new List<InParametro>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta1 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta2")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta2 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta3")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta3 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta4")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta4 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta5")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta5 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta6")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta6 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta7")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta7 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta8")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta8 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta9")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlancta9 { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodegaCtPlanctaNavigation { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<InSubgrupo> InSubgrupoCtPlancta { get; set; } = new List<InSubgrupo>();

    [InverseProperty("CtPlancta1")]
    public virtual ICollection<InSubgrupo> InSubgrupoCtPlancta1 { get; set; } = new List<InSubgrupo>();

    [InverseProperty("CtPlancta2")]
    public virtual ICollection<InSubgrupo> InSubgrupoCtPlancta2 { get; set; } = new List<InSubgrupo>();

    [InverseProperty("CtPlancta3")]
    public virtual ICollection<InSubgrupo> InSubgrupoCtPlancta3 { get; set; } = new List<InSubgrupo>();

    [InverseProperty("CtPlancta4")]
    public virtual ICollection<InSubgrupo> InSubgrupoCtPlancta4 { get; set; } = new List<InSubgrupo>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<InSubgrupo> InSubgrupoCtPlanctaNavigation { get; set; } = new List<InSubgrupo>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble> InSubgrupoXCentroCostoXSubCentroCostoXCtaCble { get; set; } = new List<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<CtPlancta> InverseCtPlanctaNavigation { get; set; } = new List<CtPlancta>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<TbBodega> TbBodegaCtPlancta { get; set; } = new List<TbBodega>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<TbBodega> TbBodegaCtPlanctaNavigation { get; set; } = new List<TbBodega>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<TbSisImpuestoXCtacble> TbSisImpuestoXCtacble { get; set; } = new List<TbSisImpuestoXCtacble>();

    [InverseProperty("CtPlancta")]
    public virtual ICollection<TbTarjetaParametro> TbTarjetaParametroCtPlancta { get; set; } = new List<TbTarjetaParametro>();

    [InverseProperty("CtPlanctaNavigation")]
    public virtual ICollection<TbTarjetaParametro> TbTarjetaParametroCtPlanctaNavigation { get; set; } = new List<TbTarjetaParametro>();
}
