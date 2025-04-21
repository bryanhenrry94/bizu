using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Bizu.Infrastructure.Models;

public partial class DberpDbContext : DbContext
{
    public DberpDbContext()
    {
    }

    public DberpDbContext(DbContextOptions<DberpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AfActivoFijo> AfActivoFijo { get; set; }

    public virtual DbSet<AfActivoFijoCategoria> AfActivoFijoCategoria { get; set; }

    public virtual DbSet<AfActivoFijoCtasCbles> AfActivoFijoCtasCbles { get; set; }

    public virtual DbSet<AfActivoFijoCtasCblesTipo> AfActivoFijoCtasCblesTipo { get; set; }

    public virtual DbSet<AfActivoFijoTipo> AfActivoFijoTipo { get; set; }

    public virtual DbSet<AfActivoFijoXAfActivoFijo> AfActivoFijoXAfActivoFijo { get; set; }

    public virtual DbSet<AfCambioUbicacionActivo> AfCambioUbicacionActivo { get; set; }

    public virtual DbSet<AfCatalogo> AfCatalogo { get; set; }

    public virtual DbSet<AfCatalogoTipo> AfCatalogoTipo { get; set; }

    public virtual DbSet<AfDepartamento> AfDepartamento { get; set; }

    public virtual DbSet<AfDepreciacion> AfDepreciacion { get; set; }

    public virtual DbSet<AfDepreciacionDet> AfDepreciacionDet { get; set; }

    public virtual DbSet<AfDepreciacionDetHisAnulacion> AfDepreciacionDetHisAnulacion { get; set; }

    public virtual DbSet<AfDepreciacionHisAnulacion> AfDepreciacionHisAnulacion { get; set; }

    public virtual DbSet<AfEncargado> AfEncargado { get; set; }

    public virtual DbSet<AfMejBajActivo> AfMejBajActivo { get; set; }

    public virtual DbSet<AfParametros> AfParametros { get; set; }

    public virtual DbSet<AfPeriodoDepreciacion> AfPeriodoDepreciacion { get; set; }

    public virtual DbSet<AfProcesoDepreciacion> AfProcesoDepreciacion { get; set; }

    public virtual DbSet<AfRetiroActivo> AfRetiroActivo { get; set; }

    public virtual DbSet<AfSpActfActivosADepreciar> AfSpActfActivosADepreciar { get; set; }

    public virtual DbSet<AfSpActfRpt012> AfSpActfRpt012 { get; set; }

    public virtual DbSet<AfSpActfRpt014> AfSpActfRpt014 { get; set; }

    public virtual DbSet<AfTipoDepreciacion> AfTipoDepreciacion { get; set; }

    public virtual DbSet<AfTipoTransacXCtaCbteCble> AfTipoTransacXCtaCbteCble { get; set; }

    public virtual DbSet<AfVentaActivo> AfVentaActivo { get; set; }

    public virtual DbSet<BaArchivoTransferencia> BaArchivoTransferencia { get; set; }

    public virtual DbSet<BaArchivoTransferenciaDet> BaArchivoTransferenciaDet { get; set; }

    public virtual DbSet<BaArchivoTransferenciaParametros> BaArchivoTransferenciaParametros { get; set; }

    public virtual DbSet<BaArchivoTransferenciaXPreAvisoCheq> BaArchivoTransferenciaXPreAvisoCheq { get; set; }

    public virtual DbSet<BaArchivoTransferenciaXPreAvisoCheqDet> BaArchivoTransferenciaXPreAvisoCheqDet { get; set; }

    public virtual DbSet<BaBanRpt007> BaBanRpt007 { get; set; }

    public virtual DbSet<BaBanRpt009> BaBanRpt009 { get; set; }

    public virtual DbSet<BaBanRpt011> BaBanRpt011 { get; set; }

    public virtual DbSet<BaBancoCuenta> BaBancoCuenta { get; set; }

    public virtual DbSet<BaCajaMovimientoXCbteBanXDeposito> BaCajaMovimientoXCbteBanXDeposito { get; set; }

    public virtual DbSet<BaCatalogo> BaCatalogo { get; set; }

    public virtual DbSet<BaCatalogoTipo> BaCatalogoTipo { get; set; }

    public virtual DbSet<BaCbteBan> BaCbteBan { get; set; }

    public virtual DbSet<BaCbteBanDatosEntregaCheq> BaCbteBanDatosEntregaCheq { get; set; }

    public virtual DbSet<BaCbteBanDatosTransferencia> BaCbteBanDatosTransferencia { get; set; }

    public virtual DbSet<BaCbteBanEdehsa> BaCbteBanEdehsa { get; set; }

    public virtual DbSet<BaCbteBanTipo> BaCbteBanTipo { get; set; }

    public virtual DbSet<BaCbteBanTipoXCodBancoExterno> BaCbteBanTipoXCodBancoExterno { get; set; }

    public virtual DbSet<BaCbteBanTipoXCtCbteCbleTipo> BaCbteBanTipoXCtCbteCbleTipo { get; set; }

    public virtual DbSet<BaCbteBanVerificado> BaCbteBanVerificado { get; set; }

    public virtual DbSet<BaConciliacion> BaConciliacion { get; set; }

    public virtual DbSet<BaConciliacionDetIngEgr> BaConciliacionDetIngEgr { get; set; }

    public virtual DbSet<BaConfigDisenoCheque> BaConfigDisenoCheque { get; set; }

    public virtual DbSet<BaInversion> BaInversion { get; set; }

    public virtual DbSet<BaNotasDebCreMasivo> BaNotasDebCreMasivo { get; set; }

    public virtual DbSet<BaParametros> BaParametros { get; set; }

    public virtual DbSet<BaPrestamo> BaPrestamo { get; set; }

    public virtual DbSet<BaPrestamoDetalle> BaPrestamoDetalle { get; set; }

    public virtual DbSet<BaPrestamoDetalleCancelacion> BaPrestamoDetalleCancelacion { get; set; }

    public virtual DbSet<BaPrestamoDetalleXAfActivoFijoPrendados> BaPrestamoDetalleXAfActivoFijoPrendados { get; set; }

    public virtual DbSet<BaTalonarioChequesXBanco> BaTalonarioChequesXBanco { get; set; }

    public virtual DbSet<BaTipoFlujo> BaTipoFlujo { get; set; }

    public virtual DbSet<BaTipoNota> BaTipoNota { get; set; }

    public virtual DbSet<BaTransferencia> BaTransferencia { get; set; }

    public virtual DbSet<CajCaja> CajCaja { get; set; }

    public virtual DbSet<CajCajaMovimiento> CajCajaMovimiento { get; set; }

    public virtual DbSet<CajCajaMovimientoDet> CajCajaMovimientoDet { get; set; }

    public virtual DbSet<CajCajaMovimientoTipo> CajCajaMovimientoTipo { get; set; }

    public virtual DbSet<CajCajaMovimientoTipoXCtaCble> CajCajaMovimientoTipoXCtaCble { get; set; }

    public virtual DbSet<CajCajachica> CajCajachica { get; set; }

    public virtual DbSet<CajCajachicaDet> CajCajachicaDet { get; set; }

    public virtual DbSet<CajCatalogo> CajCatalogo { get; set; }

    public virtual DbSet<CajCatalogoTipo> CajCatalogoTipo { get; set; }

    public virtual DbSet<CajCustodio> CajCustodio { get; set; }

    public virtual DbSet<CajCustodioXCajRubro> CajCustodioXCajRubro { get; set; }

    public virtual DbSet<CajParametro> CajParametro { get; set; }

    public virtual DbSet<CajRubro> CajRubro { get; set; }

    public virtual DbSet<CajTalonarioRecibo> CajTalonarioRecibo { get; set; }

    public virtual DbSet<ComCatalogo> ComCatalogo { get; set; }

    public virtual DbSet<ComCatalogoTipo> ComCatalogoTipo { get; set; }

    public virtual DbSet<ComComprador> ComComprador { get; set; }

    public virtual DbSet<ComCotizacionCompra> ComCotizacionCompra { get; set; }

    public virtual DbSet<ComCotizacionCompraDet> ComCotizacionCompraDet { get; set; }

    public virtual DbSet<ComCotizacionCompraEdehsa> ComCotizacionCompraEdehsa { get; set; }

    public virtual DbSet<ComCotizacionCompraGe> ComCotizacionCompraGe { get; set; }

    public virtual DbSet<ComCotizacionCompraGeDet> ComCotizacionCompraGeDet { get; set; }

    public virtual DbSet<ComDepartamento> ComDepartamento { get; set; }

    public virtual DbSet<ComDevCompra> ComDevCompra { get; set; }

    public virtual DbSet<ComDevCompraDet> ComDevCompraDet { get; set; }

    public virtual DbSet<ComEstadoCierre> ComEstadoCierre { get; set; }

    public virtual DbSet<ComListadoDiseno> ComListadoDiseno { get; set; }

    public virtual DbSet<ComListadoDisenoDet> ComListadoDisenoDet { get; set; }

    public virtual DbSet<ComListadoDisenoTipo> ComListadoDisenoTipo { get; set; }

    public virtual DbSet<ComListadoElementosXOt> ComListadoElementosXOt { get; set; }

    public virtual DbSet<ComListadoElementosXOtDet> ComListadoElementosXOtDet { get; set; }

    public virtual DbSet<ComListadoMaterialesDet> ComListadoMaterialesDet { get; set; }

    public virtual DbSet<ComListadoMaterialesDisponiblesPreAsignadoAObra> ComListadoMaterialesDisponiblesPreAsignadoAObra { get; set; }

    public virtual DbSet<ComListadoMaterialesDisponiblesPreAsignadoAObraDet> ComListadoMaterialesDisponiblesPreAsignadoAObraDet { get; set; }

    public virtual DbSet<ComMotivoOrdenCompra> ComMotivoOrdenCompra { get; set; }

    public virtual DbSet<ComOrdencompraGeLocal> ComOrdencompraGeLocal { get; set; }

    public virtual DbSet<ComOrdencompraLocal> ComOrdencompraLocal { get; set; }

    public virtual DbSet<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; }

    public virtual DbSet<ComOrdencompraLocalDetXComSolicitudCompraDet> ComOrdencompraLocalDetXComSolicitudCompraDet { get; set; }

    public virtual DbSet<ComOrdencompraLocalXComSolicitudCompra> ComOrdencompraLocalXComSolicitudCompra { get; set; }

    public virtual DbSet<ComOrdencompralocal1> ComOrdencompralocal1 { get; set; }

    public virtual DbSet<ComParametro> ComParametro { get; set; }

    public virtual DbSet<ComRegistroOrdenCompraGXCotizacion> ComRegistroOrdenCompraGXCotizacion { get; set; }

    public virtual DbSet<ComRegistroOrdenCompraGeXCotizacion> ComRegistroOrdenCompraGeXCotizacion { get; set; }

    public virtual DbSet<ComRegistroOrdenCompraXCotizacion> ComRegistroOrdenCompraXCotizacion { get; set; }

    public virtual DbSet<ComRegistroOrdenCompraXSolicitud> ComRegistroOrdenCompraXSolicitud { get; set; }

    public virtual DbSet<ComRegistroOrdenCompraxCotizacion1> ComRegistroOrdenCompraxCotizacion1 { get; set; }

    public virtual DbSet<ComSolicitante> ComSolicitante { get; set; }

    public virtual DbSet<ComSolicitudCompra> ComSolicitudCompra { get; set; }

    public virtual DbSet<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; }

    public virtual DbSet<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacion { get; set; }

    public virtual DbSet<ComSolicitudCompraDetPreAprobacion> ComSolicitudCompraDetPreAprobacion { get; set; }

    public virtual DbSet<ComTarjetaOrdenCompra> ComTarjetaOrdenCompra { get; set; }

    public virtual DbSet<ComTerminoPago> ComTerminoPago { get; set; }

    public virtual DbSet<CpAprobacionIngBodXOc> CpAprobacionIngBodXOc { get; set; }

    public virtual DbSet<CpAprobacionIngBodXOcDet> CpAprobacionIngBodXOcDet { get; set; }

    public virtual DbSet<CpAprobacionIngBodXOcDetEliminados> CpAprobacionIngBodXOcDetEliminados { get; set; }

    public virtual DbSet<CpAprobacionIngBodXOcEliminados> CpAprobacionIngBodXOcEliminados { get; set; }

    public virtual DbSet<CpAprobacionIngBodXOt> CpAprobacionIngBodXOt { get; set; }

    public virtual DbSet<CpAprobacionOrdenPago> CpAprobacionOrdenPago { get; set; }

    public virtual DbSet<CpAprobacionOrdenPagoDet> CpAprobacionOrdenPagoDet { get; set; }

    public virtual DbSet<CpAutorizacionXDocXPag> CpAutorizacionXDocXPag { get; set; }

    public virtual DbSet<CpBaseImponibleXCentroCostoEdehsa> CpBaseImponibleXCentroCostoEdehsa { get; set; }

    public virtual DbSet<CpCatalogo> CpCatalogo { get; set; }

    public virtual DbSet<CpCatalogoTipo> CpCatalogoTipo { get; set; }

    public virtual DbSet<CpCodigoSri> CpCodigoSri { get; set; }

    public virtual DbSet<CpCodigoSriTipo> CpCodigoSriTipo { get; set; }

    public virtual DbSet<CpCodigoSriXCtaCble> CpCodigoSriXCtaCble { get; set; }

    public virtual DbSet<CpConciliacion> CpConciliacion { get; set; }

    public virtual DbSet<CpConciliacionCaja> CpConciliacionCaja { get; set; }

    public virtual DbSet<CpConciliacionCajaDet> CpConciliacionCajaDet { get; set; }

    public virtual DbSet<CpConciliacionCajaDetIngCaja> CpConciliacionCajaDetIngCaja { get; set; }

    public virtual DbSet<CpConciliacionCajaDetXValeCaja> CpConciliacionCajaDetXValeCaja { get; set; }

    public virtual DbSet<CpConciliacionDet> CpConciliacionDet { get; set; }

    public virtual DbSet<CpConciliacionIngBodegaXOrdenGiro> CpConciliacionIngBodegaXOrdenGiro { get; set; }

    public virtual DbSet<CpCuotasXDoc> CpCuotasXDoc { get; set; }

    public virtual DbSet<CpCuotasXDocDet> CpCuotasXDocDet { get; set; }

    public virtual DbSet<CpCxpEdehsaRpt001> CpCxpEdehsaRpt001 { get; set; }

    public virtual DbSet<CpCxpEdehsaRpt001SaldoInicial> CpCxpEdehsaRpt001SaldoInicial { get; set; }

    public virtual DbSet<CpCxpRpt001> CpCxpRpt001 { get; set; }

    public virtual DbSet<CpCxpRpt001SaldoInicial> CpCxpRpt001SaldoInicial { get; set; }

    public virtual DbSet<CpEstado> CpEstado { get; set; }

    public virtual DbSet<CpEstadoCuentaProveedor> CpEstadoCuentaProveedor { get; set; }

    public virtual DbSet<CpLiquidacionCompra> CpLiquidacionCompra { get; set; }

    public virtual DbSet<CpLiquidacionCompraDet> CpLiquidacionCompraDet { get; set; }

    public virtual DbSet<CpNotaDebCre> CpNotaDebCre { get; set; }

    public virtual DbSet<CpNotaDebCreAprobacionIngBodXOc> CpNotaDebCreAprobacionIngBodXOc { get; set; }

    public virtual DbSet<CpNotaDebCreAprobacionIngBodXOcDet> CpNotaDebCreAprobacionIngBodXOcDet { get; set; }

    public virtual DbSet<CpNotaDebCreImpuesto> CpNotaDebCreImpuesto { get; set; }

    public virtual DbSet<CpNotaDebCreXComOrdencompraLocal> CpNotaDebCreXComOrdencompraLocal { get; set; }

    public virtual DbSet<CpOrdenGiro> CpOrdenGiro { get; set; }

    public virtual DbSet<CpOrdenGiroImpuesto> CpOrdenGiroImpuesto { get; set; }

    public virtual DbSet<CpOrdenGiroPagosSri> CpOrdenGiroPagosSri { get; set; }

    public virtual DbSet<CpOrdenGiroXComOrdencompraLocal> CpOrdenGiroXComOrdencompraLocal { get; set; }

    public virtual DbSet<CpOrdenGiroXComOrdencompraLocalDet> CpOrdenGiroXComOrdencompraLocalDet { get; set; }

    public virtual DbSet<CpOrdenGiroXPrdOrdenTrabajoDet> CpOrdenGiroXPrdOrdenTrabajoDet { get; set; }

    public virtual DbSet<CpOrdenPago> CpOrdenPago { get; set; }

    public virtual DbSet<CpOrdenPagoCancelaciones> CpOrdenPagoCancelaciones { get; set; }

    public virtual DbSet<CpOrdenPagoConTransferenciaData> CpOrdenPagoConTransferenciaData { get; set; }

    public virtual DbSet<CpOrdenPagoDet> CpOrdenPagoDet { get; set; }

    public virtual DbSet<CpOrdenPagoEstadoAprob> CpOrdenPagoEstadoAprob { get; set; }

    public virtual DbSet<CpOrdenPagoFormapago> CpOrdenPagoFormapago { get; set; }

    public virtual DbSet<CpOrdenPagoTipo> CpOrdenPagoTipo { get; set; }

    public virtual DbSet<CpOrdenPagoTipoXEmpresa> CpOrdenPagoTipoXEmpresa { get; set; }

    public virtual DbSet<CpOrdenPagoXEmpleadoXNominaXPeriodo> CpOrdenPagoXEmpleadoXNominaXPeriodo { get; set; }

    public virtual DbSet<CpOrdenPagoXIdArchivo> CpOrdenPagoXIdArchivo { get; set; }

    public virtual DbSet<CpPagosSri> CpPagosSri { get; set; }

    public virtual DbSet<CpPaisSri> CpPaisSri { get; set; }

    public virtual DbSet<CpParametros> CpParametros { get; set; }

    public virtual DbSet<CpProveedor> CpProveedor { get; set; }

    public virtual DbSet<CpProveedorAutorizacion> CpProveedorAutorizacion { get; set; }

    public virtual DbSet<CpProveedorCalificacion> CpProveedorCalificacion { get; set; }

    public virtual DbSet<CpProveedorClase> CpProveedorClase { get; set; }

    public virtual DbSet<CpProveedorCodigoSri> CpProveedorCodigoSri { get; set; }

    public virtual DbSet<CpProveedorContactos> CpProveedorContactos { get; set; }

    public virtual DbSet<CpProveedorDatosAcreditacion> CpProveedorDatosAcreditacion { get; set; }

    public virtual DbSet<CpProveedorFiltro> CpProveedorFiltro { get; set; }

    public virtual DbSet<CpProveedorXIdCtaCbleCxc> CpProveedorXIdCtaCbleCxc { get; set; }

    public virtual DbSet<CpProveedorXTbCiiu> CpProveedorXTbCiiu { get; set; }

    public virtual DbSet<CpReembolso> CpReembolso { get; set; }

    public virtual DbSet<CpRetencion> CpRetencion { get; set; }

    public virtual DbSet<CpRetencionDet> CpRetencionDet { get; set; }

    public virtual DbSet<CpRetencionXCtCbtecble> CpRetencionXCtCbtecble { get; set; }

    public virtual DbSet<CpTerminoPago> CpTerminoPago { get; set; }

    public virtual DbSet<CpTipoDocumento> CpTipoDocumento { get; set; }

    public virtual DbSet<CpTransAGenerarXFormaPagoOp> CpTransAGenerarXFormaPagoOp { get; set; }

    public virtual DbSet<CtAnioFiscal> CtAnioFiscal { get; set; }

    public virtual DbSet<CtAnioFiscalXCuentaUtilidad> CtAnioFiscalXCuentaUtilidad { get; set; }

    public virtual DbSet<CtBalanceXGeneral> CtBalanceXGeneral { get; set; }

    public virtual DbSet<CtBalanceXGeneralDataFinal> CtBalanceXGeneralDataFinal { get; set; }

    public virtual DbSet<CtCbtecble> CtCbtecble { get; set; }

    public virtual DbSet<CtCbtecbleDet> CtCbtecbleDet { get; set; }

    public virtual DbSet<CtCbtecblePlantilla> CtCbtecblePlantilla { get; set; }

    public virtual DbSet<CtCbtecblePlantillaDet> CtCbtecblePlantillaDet { get; set; }

    public virtual DbSet<CtCbtecbleReversado> CtCbtecbleReversado { get; set; }

    public virtual DbSet<CtCbtecbleTipo> CtCbtecbleTipo { get; set; }

    public virtual DbSet<CtCentroCosto> CtCentroCosto { get; set; }

    public virtual DbSet<CtCentroCostoEstadoCierre> CtCentroCostoEstadoCierre { get; set; }

    public virtual DbSet<CtCentroCostoFiltro> CtCentroCostoFiltro { get; set; }

    public virtual DbSet<CtCentroCostoNivel> CtCentroCostoNivel { get; set; }

    public virtual DbSet<CtCentroCostoSubCentroCosto> CtCentroCostoSubCentroCosto { get; set; }

    public virtual DbSet<CtCentroCostoSubCentroCostoXAfActivoFijo> CtCentroCostoSubCentroCostoXAfActivoFijo { get; set; }

    public virtual DbSet<CtDashboardFinanciero> CtDashboardFinanciero { get; set; }

    public virtual DbSet<CtGrupoEmpresarial> CtGrupoEmpresarial { get; set; }

    public virtual DbSet<CtGrupoEmpresarialGrupocble> CtGrupoEmpresarialGrupocble { get; set; }

    public virtual DbSet<CtGrupoEmpresarialPlancta> CtGrupoEmpresarialPlancta { get; set; }

    public virtual DbSet<CtGrupoEmpresarialPlanctaNivel> CtGrupoEmpresarialPlanctaNivel { get; set; }

    public virtual DbSet<CtGrupoEmpresarialPlanctaXCtPlancta> CtGrupoEmpresarialPlanctaXCtPlancta { get; set; }

    public virtual DbSet<CtGrupoXTipoGasto> CtGrupoXTipoGasto { get; set; }

    public virtual DbSet<CtGrupocble> CtGrupocble { get; set; }

    public virtual DbSet<CtGrupocbleMayor> CtGrupocbleMayor { get; set; }

    public virtual DbSet<CtParametro> CtParametro { get; set; }

    public virtual DbSet<CtPeriodo> CtPeriodo { get; set; }

    public virtual DbSet<CtPeriodoXTbModulo> CtPeriodoXTbModulo { get; set; }

    public virtual DbSet<CtPlancta> CtPlancta { get; set; }

    public virtual DbSet<CtPlanctaNivel> CtPlanctaNivel { get; set; }

    public virtual DbSet<CtPuntoCargo> CtPuntoCargo { get; set; }

    public virtual DbSet<CtPuntoCargoGrupo> CtPuntoCargoGrupo { get; set; }

    public virtual DbSet<CtRptEmpresasAMostrar> CtRptEmpresasAMostrar { get; set; }

    public virtual DbSet<CtRptMovxCta> CtRptMovxCta { get; set; }

    public virtual DbSet<CtRptSaldoxCta> CtRptSaldoxCta { get; set; }

    public virtual DbSet<CtSaldoxCuentas> CtSaldoxCuentas { get; set; }

    public virtual DbSet<CtSaldoxCuentasMovi> CtSaldoxCuentasMovi { get; set; }

    public virtual DbSet<CtSaldoxCuentasMoviTmp> CtSaldoxCuentasMoviTmp { get; set; }

    public virtual DbSet<CtSaldoxCuentasMoviXRangoFecha> CtSaldoxCuentasMoviXRangoFecha { get; set; }

    public virtual DbSet<CtSaldoxCuentasTmp> CtSaldoxCuentasTmp { get; set; }

    public virtual DbSet<CtSumatoriaXCuenta> CtSumatoriaXCuenta { get; set; }

    public virtual DbSet<CtSumatoriaXCuentaCentrocosto> CtSumatoriaXCuentaCentrocosto { get; set; }

    public virtual DbSet<CtSumatoriaXCuentaXCentroCosto> CtSumatoriaXCuentaXCentroCosto { get; set; }

    public virtual DbSet<CtTipoCosto> CtTipoCosto { get; set; }

    public virtual DbSet<CtTipoCtacble> CtTipoCtacble { get; set; }

    public virtual DbSet<CxcAnticipoFacturado> CxcAnticipoFacturado { get; set; }

    public virtual DbSet<CxcAnticipoFacturadoDet> CxcAnticipoFacturadoDet { get; set; }

    public virtual DbSet<CxcAnticiposFacturados> CxcAnticiposFacturados { get; set; }

    public virtual DbSet<CxcCancelacionIntercompany> CxcCancelacionIntercompany { get; set; }

    public virtual DbSet<CxcCancelacionIntercompanyDet> CxcCancelacionIntercompanyDet { get; set; }

    public virtual DbSet<CxcCatalogo> CxcCatalogo { get; set; }

    public virtual DbSet<CxcCatalogoTipo> CxcCatalogoTipo { get; set; }

    public virtual DbSet<CxcCobro> CxcCobro { get; set; }

    public virtual DbSet<CxcCobroDet> CxcCobroDet { get; set; }

    public virtual DbSet<CxcCobroDetXCtCbtecbleDet> CxcCobroDetXCtCbtecbleDet { get; set; }

    public virtual DbSet<CxcCobroObra> CxcCobroObra { get; set; }

    public virtual DbSet<CxcCobroTipo> CxcCobroTipo { get; set; }

    public virtual DbSet<CxcCobroTipoMotivo> CxcCobroTipoMotivo { get; set; }

    public virtual DbSet<CxcCobroTipoParamContaXSucursal> CxcCobroTipoParamContaXSucursal { get; set; }

    public virtual DbSet<CxcCobroTipoXAnticipo> CxcCobroTipoXAnticipo { get; set; }

    public virtual DbSet<CxcCobroTipoXCobrosDocxc> CxcCobroTipoXCobrosDocxc { get; set; }

    public virtual DbSet<CxcCobroXAnticipo> CxcCobroXAnticipo { get; set; }

    public virtual DbSet<CxcCobroXAnticipoDet> CxcCobroXAnticipoDet { get; set; }

    public virtual DbSet<CxcCobroXCajCajaMovimiento> CxcCobroXCajCajaMovimiento { get; set; }

    public virtual DbSet<CxcCobroXCtCbtecble> CxcCobroXCtCbtecble { get; set; }

    public virtual DbSet<CxcCobroXCtCbtecbleXAnulado> CxcCobroXCtCbtecbleXAnulado { get; set; }

    public virtual DbSet<CxcCobroXEstadoCobro> CxcCobroXEstadoCobro { get; set; }

    public virtual DbSet<CxcCobroXTarjeta> CxcCobroXTarjeta { get; set; }

    public virtual DbSet<CxcConciliacion> CxcConciliacion { get; set; }

    public virtual DbSet<CxcConciliacionDet> CxcConciliacionDet { get; set; }

    public virtual DbSet<CxcConciliacionTipo> CxcConciliacionTipo { get; set; }

    public virtual DbSet<CxcCxcRpt017> CxcCxcRpt017 { get; set; }

    public virtual DbSet<CxcEstadoCobro> CxcEstadoCobro { get; set; }

    public virtual DbSet<CxcParametro> CxcParametro { get; set; }

    public virtual DbSet<CxcParametrosXCheqProtesto> CxcParametrosXCheqProtesto { get; set; }

    public virtual DbSet<CxcRangoDiasXVencimiento> CxcRangoDiasXVencimiento { get; set; }

    public virtual DbSet<CxcRetencionMultiple> CxcRetencionMultiple { get; set; }

    public virtual DbSet<CxcRetencionMultipleDocumento> CxcRetencionMultipleDocumento { get; set; }

    public virtual DbSet<CxcRetencionMultipleDocumentosValorAplicado> CxcRetencionMultipleDocumentosValorAplicado { get; set; }

    public virtual DbSet<CxcRptTmpCobrosFechaCorteSp012> CxcRptTmpCobrosFechaCorteSp012 { get; set; }

    public virtual DbSet<CxcRptTmpFactuNdNcCobroSp012> CxcRptTmpFactuNdNcCobroSp012 { get; set; }

    public virtual DbSet<CxpEstadoCuentaProv> CxpEstadoCuentaProv { get; set; }

    public virtual DbSet<EmpleadoTemp> EmpleadoTemp { get; set; }

    public virtual DbSet<FaCatalogo> FaCatalogo { get; set; }

    public virtual DbSet<FaCatalogoTipo> FaCatalogoTipo { get; set; }

    public virtual DbSet<FaCliente> FaCliente { get; set; }

    public virtual DbSet<FaClienteContactos> FaClienteContactos { get; set; }

    public virtual DbSet<FaClienteFiltro> FaClienteFiltro { get; set; }

    public virtual DbSet<FaClienteObra> FaClienteObra { get; set; }

    public virtual DbSet<FaClientePtoEmisionCliente> FaClientePtoEmisionCliente { get; set; }

    public virtual DbSet<FaClienteTipo> FaClienteTipo { get; set; }

    public virtual DbSet<FaCostoProductoVendido> FaCostoProductoVendido { get; set; }

    public virtual DbSet<FaCotizacion> FaCotizacion { get; set; }

    public virtual DbSet<FaCotizacionDet> FaCotizacionDet { get; set; }

    public virtual DbSet<FaDescuento> FaDescuento { get; set; }

    public virtual DbSet<FaDevolVenta> FaDevolVenta { get; set; }

    public virtual DbSet<FaDevolVentaDet> FaDevolVentaDet { get; set; }

    public virtual DbSet<FaFactura> FaFactura { get; set; }

    public virtual DbSet<FaFacturaDet> FaFacturaDet { get; set; }

    public virtual DbSet<FaFacturaDetOtrosCampos> FaFacturaDetOtrosCampos { get; set; }

    public virtual DbSet<FaFacturaDetXFaDescuento> FaFacturaDetXFaDescuento { get; set; }

    public virtual DbSet<FaFacturaEdehsa> FaFacturaEdehsa { get; set; }

    public virtual DbSet<FaFacturaXCtCbtecble> FaFacturaXCtCbtecble { get; set; }

    public virtual DbSet<FaFacturaXFaCotizacion> FaFacturaXFaCotizacion { get; set; }

    public virtual DbSet<FaFacturaXFaGuiaRemision> FaFacturaXFaGuiaRemision { get; set; }

    public virtual DbSet<FaFacturaXFaTerminoPago> FaFacturaXFaTerminoPago { get; set; }

    public virtual DbSet<FaFacturaXFormaPago> FaFacturaXFormaPago { get; set; }

    public virtual DbSet<FaFacturaXInIngEgrInven> FaFacturaXInIngEgrInven { get; set; }

    public virtual DbSet<FaFacturaXInMoviInve> FaFacturaXInMoviInve { get; set; }

    public virtual DbSet<FaFacturaXInMoviInveXAnulacion> FaFacturaXInMoviInveXAnulacion { get; set; }

    public virtual DbSet<FaFiltroCliente> FaFiltroCliente { get; set; }

    public virtual DbSet<FaFormaPago> FaFormaPago { get; set; }

    public virtual DbSet<FaGuiaRemision> FaGuiaRemision { get; set; }

    public virtual DbSet<FaGuiaRemisionDet> FaGuiaRemisionDet { get; set; }

    public virtual DbSet<FaGuiaRemisionDetXFaFacturaDet> FaGuiaRemisionDetXFaFacturaDet { get; set; }

    public virtual DbSet<FaGuiaRemisionDetXFaOrdenDespDet> FaGuiaRemisionDetXFaOrdenDespDet { get; set; }

    public virtual DbSet<FaGuiaRemisionXPrdDespacho> FaGuiaRemisionXPrdDespacho { get; set; }

    public virtual DbSet<FaMotivoAprobacionPedidoVenta> FaMotivoAprobacionPedidoVenta { get; set; }

    public virtual DbSet<FaMotivoVenta> FaMotivoVenta { get; set; }

    public virtual DbSet<FaNotaCreDeb> FaNotaCreDeb { get; set; }

    public virtual DbSet<FaNotaCreDebDet> FaNotaCreDebDet { get; set; }

    public virtual DbSet<FaNotaCreDebEdehsa> FaNotaCreDebEdehsa { get; set; }

    public virtual DbSet<FaNotaCreDebSubtotalIvas> FaNotaCreDebSubtotalIvas { get; set; }

    public virtual DbSet<FaNotaCreDebXCtCbtecble> FaNotaCreDebXCtCbtecble { get; set; }

    public virtual DbSet<FaNotaCreDebXCxcCobro> FaNotaCreDebXCxcCobro { get; set; }

    public virtual DbSet<FaNotaCreDebXFaFacturaNotaDeb> FaNotaCreDebXFaFacturaNotaDeb { get; set; }

    public virtual DbSet<FaOrdenDesp> FaOrdenDesp { get; set; }

    public virtual DbSet<FaOrdenDespDet> FaOrdenDespDet { get; set; }

    public virtual DbSet<FaOrdenDespDetXFaPedidoDet> FaOrdenDespDetXFaPedidoDet { get; set; }

    public virtual DbSet<FaParametro> FaParametro { get; set; }

    public virtual DbSet<FaPedido> FaPedido { get; set; }

    public virtual DbSet<FaPedidoDet> FaPedidoDet { get; set; }

    public virtual DbSet<FaPedidoEstadoAprobacion> FaPedidoEstadoAprobacion { get; set; }

    public virtual DbSet<FaPedidoXFormaPago> FaPedidoXFormaPago { get; set; }

    public virtual DbSet<FaPuntoVta> FaPuntoVta { get; set; }

    public virtual DbSet<FaTerminoPago> FaTerminoPago { get; set; }

    public virtual DbSet<FaTerminoPagoDistribucion> FaTerminoPagoDistribucion { get; set; }

    public virtual DbSet<FaTipoNota> FaTipoNota { get; set; }

    public virtual DbSet<FaTipoNotaXEmpresaXSucursal> FaTipoNotaXEmpresaXSucursal { get; set; }

    public virtual DbSet<FaVendedor> FaVendedor { get; set; }

    public virtual DbSet<FaVendedorXRoEmpleado> FaVendedorXRoEmpleado { get; set; }

    public virtual DbSet<FaVendedorxSucursal> FaVendedorxSucursal { get; set; }

    public virtual DbSet<FaVentaTelefonica> FaVentaTelefonica { get; set; }

    public virtual DbSet<FaVentaTelefonicaDet> FaVentaTelefonicaDet { get; set; }

    public virtual DbSet<InAjusteFisico> InAjusteFisico { get; set; }

    public virtual DbSet<InAjusteFisicoDetalle> InAjusteFisicoDetalle { get; set; }

    public virtual DbSet<InAjusteFisicoTmp> InAjusteFisicoTmp { get; set; }

    public virtual DbSet<InCatalogo> InCatalogo { get; set; }

    public virtual DbSet<InCatalogoTipo> InCatalogoTipo { get; set; }

    public virtual DbSet<InCategoriaXFormula> InCategoriaXFormula { get; set; }

    public virtual DbSet<InCategorias> InCategorias { get; set; }

    public virtual DbSet<InCategoriasFilter> InCategoriasFilter { get; set; }

    public virtual DbSet<InDevolucionInven> InDevolucionInven { get; set; }

    public virtual DbSet<InDevolucionInvenDet> InDevolucionInvenDet { get; set; }

    public virtual DbSet<InEgresoDSuministro> InEgresoDSuministro { get; set; }

    public virtual DbSet<InGrupo> InGrupo { get; set; }

    public virtual DbSet<InGuiaRemision> InGuiaRemision { get; set; }

    public virtual DbSet<InGuiaRemisionDet> InGuiaRemisionDet { get; set; }

    public virtual DbSet<InGuiaRemisionExportacion> InGuiaRemisionExportacion { get; set; }

    public virtual DbSet<InGuiaRemisionMotivo> InGuiaRemisionMotivo { get; set; }

    public virtual DbSet<InGuiaXTraspasoBodega> InGuiaXTraspasoBodega { get; set; }

    public virtual DbSet<InGuiaXTraspasoBodegaDet> InGuiaXTraspasoBodegaDet { get; set; }

    public virtual DbSet<InGuiaXTraspasoBodegaDetSinOc> InGuiaXTraspasoBodegaDetSinOc { get; set; }

    public virtual DbSet<InGuiaXTraspasoBodegaXInTransferenciaDet> InGuiaXTraspasoBodegaXInTransferenciaDet { get; set; }

    public virtual DbSet<InIngEgrInven> InIngEgrInven { get; set; }

    public virtual DbSet<InIngEgrInvenDet> InIngEgrInvenDet { get; set; }

    public virtual DbSet<InIngEgrInvenDetXPrdOrdenTrabajoDet> InIngEgrInvenDetXPrdOrdenTrabajoDet { get; set; }

    public virtual DbSet<InIngEgrInvenEstadoApro> InIngEgrInvenEstadoApro { get; set; }

    public virtual DbSet<InIngEgrInvenTmp> InIngEgrInvenTmp { get; set; }

    public virtual DbSet<InIngEgrInvenXInGuiaRemision> InIngEgrInvenXInGuiaRemision { get; set; }

    public virtual DbSet<InIngEgrInvenXInRequerimientoMaterial> InIngEgrInvenXInRequerimientoMaterial { get; set; }

    public virtual DbSet<InInvRpt010> InInvRpt010 { get; set; }

    public virtual DbSet<InInvRpt026> InInvRpt026 { get; set; }

    public virtual DbSet<InInvRpt027> InInvRpt027 { get; set; }

    public virtual DbSet<InKardex> InKardex { get; set; }

    public virtual DbSet<InKardexDet> InKardexDet { get; set; }

    public virtual DbSet<InLinea> InLinea { get; set; }

    public virtual DbSet<InLineaFilter> InLineaFilter { get; set; }

    public virtual DbSet<InMarca> InMarca { get; set; }

    public virtual DbSet<InMarcaFiltro> InMarcaFiltro { get; set; }

    public virtual DbSet<InMotivoInven> InMotivoInven { get; set; }

    public virtual DbSet<InMoviInve> InMoviInve { get; set; }

    public virtual DbSet<InMoviInveDetalle> InMoviInveDetalle { get; set; }

    public virtual DbSet<InMoviInveDetalleXComOrdencompraLocalDet> InMoviInveDetalleXComOrdencompraLocalDet { get; set; }

    public virtual DbSet<InMoviInveDetalleXCtCbtecbleDet> InMoviInveDetalleXCtCbtecbleDet { get; set; }

    public virtual DbSet<InMoviInveDetalleXItem> InMoviInveDetalleXItem { get; set; }

    public virtual DbSet<InMoviInveXCtCbteCble> InMoviInveXCtCbteCble { get; set; }

    public virtual DbSet<InMoviInveXInOrdencompraLocal> InMoviInveXInOrdencompraLocal { get; set; }

    public virtual DbSet<InMoviInvenParaRecosteoCtCbteCble> InMoviInvenParaRecosteoCtCbteCble { get; set; }

    public virtual DbSet<InMoviInvenTipo> InMoviInvenTipo { get; set; }

    public virtual DbSet<InMoviInvenTipoXTbBodega> InMoviInvenTipoXTbBodega { get; set; }

    public virtual DbSet<InMoviInvenXImpOrdCompraExterna> InMoviInvenXImpOrdCompraExterna { get; set; }

    public virtual DbSet<InParametro> InParametro { get; set; }

    public virtual DbSet<InParametroImpuestoIvaIce> InParametroImpuestoIvaIce { get; set; }

    public virtual DbSet<InPrecargaItemsOrdenCompra> InPrecargaItemsOrdenCompra { get; set; }

    public virtual DbSet<InPrecargaItemsOrdenCompraDet> InPrecargaItemsOrdenCompraDet { get; set; }

    public virtual DbSet<InPresentacion> InPresentacion { get; set; }

    public virtual DbSet<InPresupuesto> InPresupuesto { get; set; }

    public virtual DbSet<InPresupuestoDet> InPresupuestoDet { get; set; }

    public virtual DbSet<InProducto> InProducto { get; set; }

    public virtual DbSet<InProductoComposicion> InProductoComposicion { get; set; }

    public virtual DbSet<InProductoDimensiones> InProductoDimensiones { get; set; }

    public virtual DbSet<InProductoPrecioHistorico> InProductoPrecioHistorico { get; set; }

    public virtual DbSet<InProductoTipo> InProductoTipo { get; set; }

    public virtual DbSet<InProductoXCpProveedor> InProductoXCpProveedor { get; set; }

    public virtual DbSet<InProductoXInProducto> InProductoXInProducto { get; set; }

    public virtual DbSet<InProductoXTbBodega> InProductoXTbBodega { get; set; }

    public virtual DbSet<InProductoXTbBodegaCostoHistorico> InProductoXTbBodegaCostoHistorico { get; set; }

    public virtual DbSet<InProductoXTbBodegaCostoHistoricoFilter> InProductoXTbBodegaCostoHistoricoFilter { get; set; }

    public virtual DbSet<InRecosteoProductosXMoviInveDetalle> InRecosteoProductosXMoviInveDetalle { get; set; }

    public virtual DbSet<InResponsable> InResponsable { get; set; }

    public virtual DbSet<InRptDispInve> InRptDispInve { get; set; }

    public virtual DbSet<InRptMoviInvXProdResumido> InRptMoviInvXProdResumido { get; set; }

    public virtual DbSet<InSpSysInvReversarAprobacionCtCbtecble> InSpSysInvReversarAprobacionCtCbtecble { get; set; }

    public virtual DbSet<InSpSysInvReversarAprobacionInMoviInven> InSpSysInvReversarAprobacionInMoviInven { get; set; }

    public virtual DbSet<InSubgrupo> InSubgrupo { get; set; }

    public virtual DbSet<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble> InSubgrupoXCentroCostoXSubCentroCostoXCtaCble { get; set; }

    public virtual DbSet<InTransferencia> InTransferencia { get; set; }

    public virtual DbSet<InTransferenciaDet> InTransferenciaDet { get; set; }

    public virtual DbSet<InTransferenciaDetXInGuiaXTraspasoBodegaDet> InTransferenciaDetXInGuiaXTraspasoBodegaDet { get; set; }

    public virtual DbSet<InTransferenciaXFaGuiaRemision> InTransferenciaXFaGuiaRemision { get; set; }

    public virtual DbSet<InTransferenciaXInGuiaXTraspasoBodega> InTransferenciaXInGuiaXTraspasoBodega { get; set; }

    public virtual DbSet<InUnidadMedida> InUnidadMedida { get; set; }

    public virtual DbSet<InUnidadMedidaEquivConversion> InUnidadMedidaEquivConversion { get; set; }

    public virtual DbSet<InZona> InZona { get; set; }

    public virtual DbSet<InZonaVsCentroDeCosto> InZonaVsCentroDeCosto { get; set; }

    public virtual DbSet<Libro1> Libro1 { get; set; }

    public virtual DbSet<MailCuentaCorreo> MailCuentaCorreo { get; set; }

    public virtual DbSet<MailMail> MailMail { get; set; }

    public virtual DbSet<MailMailAttachment> MailMailAttachment { get; set; }

    public virtual DbSet<MailNotificacionConfig> MailNotificacionConfig { get; set; }

    public virtual DbSet<MailPlantillaMensaje> MailPlantillaMensaje { get; set; }

    public virtual DbSet<MgCtPlanCta> MgCtPlanCta { get; set; }

    public virtual DbSet<Movimientos> Movimientos { get; set; }

    public virtual DbSet<SegMenu> SegMenu { get; set; }

    public virtual DbSet<SegMenuCategoria> SegMenuCategoria { get; set; }

    public virtual DbSet<SegMenuGrupo> SegMenuGrupo { get; set; }

    public virtual DbSet<SegMenuGrupoXSegMenuItem> SegMenuGrupoXSegMenuItem { get; set; }

    public virtual DbSet<SegMenuItem> SegMenuItem { get; set; }

    public virtual DbSet<SegMenuItemTipo> SegMenuItemTipo { get; set; }

    public virtual DbSet<SegMenuPagina> SegMenuPagina { get; set; }

    public virtual DbSet<SegMenuWeb> SegMenuWeb { get; set; }

    public virtual DbSet<SegMenuWebXEmpresaXUsuario> SegMenuWebXEmpresaXUsuario { get; set; }

    public virtual DbSet<SegMenuXEmpresa> SegMenuXEmpresa { get; set; }

    public virtual DbSet<SegMenuXEmpresaXUsuario> SegMenuXEmpresaXUsuario { get; set; }

    public virtual DbSet<SegUsuario> SegUsuario { get; set; }

    public virtual DbSet<SegUsuarioXEmpresa> SegUsuarioXEmpresa { get; set; }

    public virtual DbSet<SegUsuarioXTbSisReporte> SegUsuarioXTbSisReporte { get; set; }

    public virtual DbSet<SriCiudad> SriCiudad { get; set; }

    public virtual DbSet<SriProvincia> SriProvincia { get; set; }

    public virtual DbSet<SriTipoGasto> SriTipoGasto { get; set; }

    public virtual DbSet<SriTipoIdentificacion> SriTipoIdentificacion { get; set; }

    public virtual DbSet<StCatalogo> StCatalogo { get; set; }

    public virtual DbSet<StCatalogoTipo> StCatalogoTipo { get; set; }

    public virtual DbSet<StRequerimiento> StRequerimiento { get; set; }

    public virtual DbSet<StTecnico> StTecnico { get; set; }

    public virtual DbSet<SypFeRespuestaSri> SypFeRespuestaSri { get; set; }

    public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }

    public virtual DbSet<TbActividadesHorario> TbActividadesHorario { get; set; }

    public virtual DbSet<TbActividadesHorarioAcciones> TbActividadesHorarioAcciones { get; set; }

    public virtual DbSet<TbActividadesHorarioTipoEjecucion> TbActividadesHorarioTipoEjecucion { get; set; }

    public virtual DbSet<TbActividadesHorarioTipoTiempo> TbActividadesHorarioTipoTiempo { get; set; }

    public virtual DbSet<TbBanRpt001> TbBanRpt001 { get; set; }

    public virtual DbSet<TbBanRpt007> TbBanRpt007 { get; set; }

    public virtual DbSet<TbBanco> TbBanco { get; set; }

    public virtual DbSet<TbBancoEstadoRegRespBancaria> TbBancoEstadoRegRespBancaria { get; set; }

    public virtual DbSet<TbBancoProcesosBancariosTipo> TbBancoProcesosBancariosTipo { get; set; }

    public virtual DbSet<TbBancoProcesosBancariosXEmpresa> TbBancoProcesosBancariosXEmpresa { get; set; }

    public virtual DbSet<TbBodega> TbBodega { get; set; }

    public virtual DbSet<TbBodegaFiltro> TbBodegaFiltro { get; set; }

    public virtual DbSet<TbCalendario> TbCalendario { get; set; }

    public virtual DbSet<TbCatalogo> TbCatalogo { get; set; }

    public virtual DbSet<TbCatalogoTipo> TbCatalogoTipo { get; set; }

    public virtual DbSet<TbCatastroGranContribuyente> TbCatastroGranContribuyente { get; set; }

    public virtual DbSet<TbCiiu> TbCiiu { get; set; }

    public virtual DbSet<TbCiudad> TbCiudad { get; set; }

    public virtual DbSet<TbCompRpt007> TbCompRpt007 { get; set; }

    public virtual DbSet<TbComprobantesRecibidos> TbComprobantesRecibidos { get; set; }

    public virtual DbSet<TbConexionDashboard> TbConexionDashboard { get; set; }

    public virtual DbSet<TbConexionDbfacturacionElectronica> TbConexionDbfacturacionElectronica { get; set; }

    public virtual DbSet<TbContaRpt005> TbContaRpt005 { get; set; }

    public virtual DbSet<TbContaRpt010> TbContaRpt010 { get; set; }

    public virtual DbSet<TbContaRpt012> TbContaRpt012 { get; set; }

    public virtual DbSet<TbContaRpt023Data> TbContaRpt023Data { get; set; }

    public virtual DbSet<TbContacto> TbContacto { get; set; }

    public virtual DbSet<TbCxcEdehsaRpt001CbtsVtas> TbCxcEdehsaRpt001CbtsVtas { get; set; }

    public virtual DbSet<TbCxcEdehsaRpt001XCobros> TbCxcEdehsaRpt001XCobros { get; set; }

    public virtual DbSet<TbCxcRpt001CbtsVtas> TbCxcRpt001CbtsVtas { get; set; }

    public virtual DbSet<TbCxcRpt001XCobros> TbCxcRpt001XCobros { get; set; }

    public virtual DbSet<TbCxcRpt007CbtsVtas> TbCxcRpt007CbtsVtas { get; set; }

    public virtual DbSet<TbCxcRpt007XCobros> TbCxcRpt007XCobros { get; set; }

    public virtual DbSet<TbCxpRpt001> TbCxpRpt001 { get; set; }

    public virtual DbSet<TbCxpRpt002> TbCxpRpt002 { get; set; }

    public virtual DbSet<TbCxpRpt003> TbCxpRpt003 { get; set; }

    public virtual DbSet<TbCxpRpt004> TbCxpRpt004 { get; set; }

    public virtual DbSet<TbCxpRpt005> TbCxpRpt005 { get; set; }

    public virtual DbSet<TbCxpRpt006> TbCxpRpt006 { get; set; }

    public virtual DbSet<TbCxpRptRcxp002> TbCxpRptRcxp002 { get; set; }

    public virtual DbSet<TbDia> TbDia { get; set; }

    public virtual DbSet<TbEmpresa> TbEmpresa { get; set; }

    public virtual DbSet<TbInvRpt001> TbInvRpt001 { get; set; }

    public virtual DbSet<TbInvRpt003> TbInvRpt003 { get; set; }

    public virtual DbSet<TbInvRpt004> TbInvRpt004 { get; set; }

    public virtual DbSet<TbInvRpt005> TbInvRpt005 { get; set; }

    public virtual DbSet<TbInvRpt018> TbInvRpt018 { get; set; }

    public virtual DbSet<TbInvRpt021> TbInvRpt021 { get; set; }

    public virtual DbSet<TbMes> TbMes { get; set; }

    public virtual DbSet<TbModulo> TbModulo { get; set; }

    public virtual DbSet<TbMoneda> TbMoneda { get; set; }

    public virtual DbSet<TbPais> TbPais { get; set; }

    public virtual DbSet<TbParametro> TbParametro { get; set; }

    public virtual DbSet<TbParametroTipo> TbParametroTipo { get; set; }

    public virtual DbSet<TbParroquia> TbParroquia { get; set; }

    public virtual DbSet<TbPersona> TbPersona { get; set; }

    public virtual DbSet<TbPersonaDireccion> TbPersonaDireccion { get; set; }

    public virtual DbSet<TbPersonaDireccionTipo> TbPersonaDireccionTipo { get; set; }

    public virtual DbSet<TbPersonaTipo> TbPersonaTipo { get; set; }

    public virtual DbSet<TbProvincia> TbProvincia { get; set; }

    public virtual DbSet<TbRangoFechaBusquedaXPeriodo> TbRangoFechaBusquedaXPeriodo { get; set; }

    public virtual DbSet<TbRegion> TbRegion { get; set; }

    public virtual DbSet<TbRolNominaGeneral> TbRolNominaGeneral { get; set; }

    public virtual DbSet<TbRolRpt001> TbRolRpt001 { get; set; }

    public virtual DbSet<TbRolRpt002> TbRolRpt002 { get; set; }

    public virtual DbSet<TbRolRpt003> TbRolRpt003 { get; set; }

    public virtual DbSet<TbSisActualizacionesXTablas> TbSisActualizacionesXTablas { get; set; }

    public virtual DbSet<TbSisDatosSistema> TbSisDatosSistema { get; set; }

    public virtual DbSet<TbSisDocumentoRegistrosXTalonario> TbSisDocumentoRegistrosXTalonario { get; set; }

    public virtual DbSet<TbSisDocumentoTipo> TbSisDocumentoTipo { get; set; }

    public virtual DbSet<TbSisDocumentoTipoReporteXEmpresa> TbSisDocumentoTipoReporteXEmpresa { get; set; }

    public virtual DbSet<TbSisDocumentoTipoTalonario> TbSisDocumentoTipoTalonario { get; set; }

    public virtual DbSet<TbSisDocumentoTipoXEmpresa> TbSisDocumentoTipoXEmpresa { get; set; }

    public virtual DbSet<TbSisDocumentoTipoXEmpresaAnulados> TbSisDocumentoTipoXEmpresaAnulados { get; set; }

    public virtual DbSet<TbSisDocumentoTipoXSecuenciaTalonario> TbSisDocumentoTipoXSecuenciaTalonario { get; set; }

    public virtual DbSet<TbSisFormulario> TbSisFormulario { get; set; }

    public virtual DbSet<TbSisGrupoEmpresarialCliente> TbSisGrupoEmpresarialCliente { get; set; }

    public virtual DbSet<TbSisIconos> TbSisIconos { get; set; }

    public virtual DbSet<TbSisImpuesto> TbSisImpuesto { get; set; }

    public virtual DbSet<TbSisImpuestoTipo> TbSisImpuestoTipo { get; set; }

    public virtual DbSet<TbSisImpuestoXCtacble> TbSisImpuestoXCtacble { get; set; }

    public virtual DbSet<TbSisLogErrorVzen> TbSisLogErrorVzen { get; set; }

    public virtual DbSet<TbSisMensajesSys> TbSisMensajesSys { get; set; }

    public virtual DbSet<TbSisReporte> TbSisReporte { get; set; }

    public virtual DbSet<TbSisReporteGrupo> TbSisReporteGrupo { get; set; }

    public virtual DbSet<TbSisReporteXFormulario> TbSisReporteXFormulario { get; set; }

    public virtual DbSet<TbSpSysInConsultaErroresFrecuentesEliminarMovimient1> TbSpSysInConsultaErroresFrecuentesEliminarMovimient1 { get; set; }

    public virtual DbSet<TbSucursal> TbSucursal { get; set; }

    public virtual DbSet<TbSysGeComparativoModuloVsContas> TbSysGeComparativoModuloVsContas { get; set; }

    public virtual DbSet<TbTarea> TbTarea { get; set; }

    public virtual DbSet<TbTareaEquipo> TbTareaEquipo { get; set; }

    public virtual DbSet<TbTarjeta> TbTarjeta { get; set; }

    public virtual DbSet<TbTarjetaParametro> TbTarjetaParametro { get; set; }

    public virtual DbSet<TbTransportista> TbTransportista { get; set; }

    public virtual DbSet<TmpCobrosFechaCorte> TmpCobrosFechaCorte { get; set; }

    public virtual DbSet<TmpCobrosFechaCorteSp010> TmpCobrosFechaCorteSp010 { get; set; }

    public virtual DbSet<TmpFactuNdNcCobro> TmpFactuNdNcCobro { get; set; }

    public virtual DbSet<TmpFactuNdNcCobroSp010> TmpFactuNdNcCobroSp010 { get; set; }

    public virtual DbSet<TmpRangoFactuXClienteSp010> TmpRangoFactuXClienteSp010 { get; set; }

    public virtual DbSet<TmpRoPrestamoDetalle> TmpRoPrestamoDetalle { get; set; }

    public virtual DbSet<TmpXrolRpt024> TmpXrolRpt024 { get; set; }

    public virtual DbSet<VwActfRpt001> VwActfRpt001 { get; set; }

    public virtual DbSet<VwActfRpt002> VwActfRpt002 { get; set; }

    public virtual DbSet<VwActfRpt003> VwActfRpt003 { get; set; }

    public virtual DbSet<VwActfRpt004> VwActfRpt004 { get; set; }

    public virtual DbSet<VwActfRpt005> VwActfRpt005 { get; set; }

    public virtual DbSet<VwActfRpt006> VwActfRpt006 { get; set; }

    public virtual DbSet<VwActfRpt007> VwActfRpt007 { get; set; }

    public virtual DbSet<VwActfRpt008> VwActfRpt008 { get; set; }

    public virtual DbSet<VwActfRpt009> VwActfRpt009 { get; set; }

    public virtual DbSet<VwActfRpt010> VwActfRpt010 { get; set; }

    public virtual DbSet<VwActfRpt011> VwActfRpt011 { get; set; }

    public virtual DbSet<VwActfRpt012> VwActfRpt012 { get; set; }

    public virtual DbSet<VwActfRpt013> VwActfRpt013 { get; set; }

    public virtual DbSet<VwActfRpt014> VwActfRpt014 { get; set; }

    public virtual DbSet<VwActfRpt0141> VwActfRpt0141 { get; set; }

    public virtual DbSet<VwActfRpt015> VwActfRpt015 { get; set; }

    public virtual DbSet<VwActfRpt016> VwActfRpt016 { get; set; }

    public virtual DbSet<VwAfActivoCtasCbles> VwAfActivoCtasCbles { get; set; }

    public virtual DbSet<VwAfActivoFijo> VwAfActivoFijo { get; set; }

    public virtual DbSet<VwAfActivoFijo1> VwAfActivoFijo1 { get; set; }

    public virtual DbSet<VwAfActivoFijoCategoria> VwAfActivoFijoCategoria { get; set; }

    public virtual DbSet<VwAfActivoFijoCtasCbles> VwAfActivoFijoCtasCbles { get; set; }

    public virtual DbSet<VwAfCatalogoIdAutoNumeric> VwAfCatalogoIdAutoNumeric { get; set; }

    public virtual DbSet<VwAfDepreXCicloValor> VwAfDepreXCicloValor { get; set; }

    public virtual DbSet<VwAfDepreciacion> VwAfDepreciacion { get; set; }

    public virtual DbSet<VwAfDepreciacionDetalle> VwAfDepreciacionDetalle { get; set; }

    public virtual DbSet<VwAfMejBajActivo> VwAfMejBajActivo { get; set; }

    public virtual DbSet<VwAfOrdenCompraXProveedorFacturaActivoFijo> VwAfOrdenCompraXProveedorFacturaActivoFijo { get; set; }

    public virtual DbSet<VwAfOrdenCompraXProveedorFacturaSinCruceActivoFijo> VwAfOrdenCompraXProveedorFacturaSinCruceActivoFijo { get; set; }

    public virtual DbSet<VwAfRetiroActivo> VwAfRetiroActivo { get; set; }

    public virtual DbSet<VwAfValoresDepreContabilizar> VwAfValoresDepreContabilizar { get; set; }

    public virtual DbSet<VwAfValoresDepreXAf> VwAfValoresDepreXAf { get; set; }

    public virtual DbSet<VwAfVentaActivo> VwAfVentaActivo { get; set; }

    public virtual DbSet<VwBaChequexCbteCtble> VwBaChequexCbteCtble { get; set; }

    public virtual DbSet<VwBaSucursalXTipoCobro> VwBaSucursalXTipoCobro { get; set; }

    public virtual DbSet<VwBanEdehsaRpt001> VwBanEdehsaRpt001 { get; set; }

    public virtual DbSet<VwBanRpt001> VwBanRpt001 { get; set; }

    public virtual DbSet<VwBanRpt002> VwBanRpt002 { get; set; }

    public virtual DbSet<VwBanRpt003> VwBanRpt003 { get; set; }

    public virtual DbSet<VwBanRpt004> VwBanRpt004 { get; set; }

    public virtual DbSet<VwBanRpt005> VwBanRpt005 { get; set; }

    public virtual DbSet<VwBanRpt006> VwBanRpt006 { get; set; }

    public virtual DbSet<VwBanRpt007> VwBanRpt007 { get; set; }

    public virtual DbSet<VwBanRpt010> VwBanRpt010 { get; set; }

    public virtual DbSet<VwBanRpt011> VwBanRpt011 { get; set; }

    public virtual DbSet<VwBanRpt012> VwBanRpt012 { get; set; }

    public virtual DbSet<VwBanRpt013> VwBanRpt013 { get; set; }

    public virtual DbSet<VwBanRpt014> VwBanRpt014 { get; set; }

    public virtual DbSet<VwBanRpt015> VwBanRpt015 { get; set; }

    public virtual DbSet<VwBanRpt016> VwBanRpt016 { get; set; }

    public virtual DbSet<VwBanRpt018> VwBanRpt018 { get; set; }

    public virtual DbSet<VwBanRpt019> VwBanRpt019 { get; set; }

    public virtual DbSet<VwCajRpt001> VwCajRpt001 { get; set; }

    public virtual DbSet<VwCajRpt002> VwCajRpt002 { get; set; }

    public virtual DbSet<VwCajRpt003> VwCajRpt003 { get; set; }

    public virtual DbSet<VwCajRpt004> VwCajRpt004 { get; set; }

    public virtual DbSet<VwCajRpt005> VwCajRpt005 { get; set; }

    public virtual DbSet<VwCajRpt006> VwCajRpt006 { get; set; }

    public virtual DbSet<VwCajRpt007> VwCajRpt007 { get; set; }

    public virtual DbSet<VwCajTalonarioRecibo> VwCajTalonarioRecibo { get; set; }

    public virtual DbSet<VwCompEdehsaRpt001> VwCompEdehsaRpt001 { get; set; }

    public virtual DbSet<VwCompEdehsaRpt002> VwCompEdehsaRpt002 { get; set; }

    public virtual DbSet<VwCompRpt001> VwCompRpt001 { get; set; }

    public virtual DbSet<VwCompRpt001Ge> VwCompRpt001Ge { get; set; }

    public virtual DbSet<VwCompRpt002> VwCompRpt002 { get; set; }

    public virtual DbSet<VwCompRpt003> VwCompRpt003 { get; set; }

    public virtual DbSet<VwCompRpt004> VwCompRpt004 { get; set; }

    public virtual DbSet<VwCompRpt005> VwCompRpt005 { get; set; }

    public virtual DbSet<VwCompRpt006> VwCompRpt006 { get; set; }

    public virtual DbSet<VwCompRpt008> VwCompRpt008 { get; set; }

    public virtual DbSet<VwCompRpt009> VwCompRpt009 { get; set; }

    public virtual DbSet<VwCompRpt011> VwCompRpt011 { get; set; }

    public virtual DbSet<VwCompRpt012> VwCompRpt012 { get; set; }

    public virtual DbSet<VwCompRpt013> VwCompRpt013 { get; set; }

    public virtual DbSet<VwContaEdehsaRpt001> VwContaEdehsaRpt001 { get; set; }

    public virtual DbSet<VwContaEdehsaRpt003> VwContaEdehsaRpt003 { get; set; }

    public virtual DbSet<VwContaEdehsaRpt004> VwContaEdehsaRpt004 { get; set; }

    public virtual DbSet<VwContaRpt001> VwContaRpt001 { get; set; }

    public virtual DbSet<VwContaRpt002> VwContaRpt002 { get; set; }

    public virtual DbSet<VwContaRpt003> VwContaRpt003 { get; set; }

    public virtual DbSet<VwContaRpt004> VwContaRpt004 { get; set; }

    public virtual DbSet<VwContaRpt005> VwContaRpt005 { get; set; }

    public virtual DbSet<VwContaRpt008> VwContaRpt008 { get; set; }

    public virtual DbSet<VwContaRpt009> VwContaRpt009 { get; set; }

    public virtual DbSet<VwContaRpt014> VwContaRpt014 { get; set; }

    public virtual DbSet<VwContaRpt024> VwContaRpt024 { get; set; }

    public virtual DbSet<VwCpRetencionValorTotal> VwCpRetencionValorTotal { get; set; }

    public virtual DbSet<VwCxcCatalogoIdAutoNumeric> VwCxcCatalogoIdAutoNumeric { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt001> VwCxcEdehsaRpt001 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt001Result> VwCxcEdehsaRpt001Result { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt002> VwCxcEdehsaRpt002 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt003> VwCxcEdehsaRpt003 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt004> VwCxcEdehsaRpt004 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt005> VwCxcEdehsaRpt005 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt006> VwCxcEdehsaRpt006 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt007> VwCxcEdehsaRpt007 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt008> VwCxcEdehsaRpt008 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt009> VwCxcEdehsaRpt009 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt011> VwCxcEdehsaRpt011 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt012> VwCxcEdehsaRpt012 { get; set; }

    public virtual DbSet<VwCxcEdehsaRpt014> VwCxcEdehsaRpt014 { get; set; }

    public virtual DbSet<VwCxcEstadoCtaXCliente> VwCxcEstadoCtaXCliente { get; set; }

    public virtual DbSet<VwCxcRpt001> VwCxcRpt001 { get; set; }

    public virtual DbSet<VwCxcRpt001Result> VwCxcRpt001Result { get; set; }

    public virtual DbSet<VwCxcRpt002> VwCxcRpt002 { get; set; }

    public virtual DbSet<VwCxcRpt003> VwCxcRpt003 { get; set; }

    public virtual DbSet<VwCxcRpt004> VwCxcRpt004 { get; set; }

    public virtual DbSet<VwCxcRpt005> VwCxcRpt005 { get; set; }

    public virtual DbSet<VwCxcRpt006> VwCxcRpt006 { get; set; }

    public virtual DbSet<VwCxcRpt007> VwCxcRpt007 { get; set; }

    public virtual DbSet<VwCxcRpt011> VwCxcRpt011 { get; set; }

    public virtual DbSet<VwCxcRpt013> VwCxcRpt013 { get; set; }

    public virtual DbSet<VwCxcRpt014> VwCxcRpt014 { get; set; }

    public virtual DbSet<VwCxcRpt016> VwCxcRpt016 { get; set; }

    public virtual DbSet<VwCxcRpt019> VwCxcRpt019 { get; set; }

    public virtual DbSet<VwCxcRpt0191> VwCxcRpt0191 { get; set; }

    public virtual DbSet<VwCxcRpt0192> VwCxcRpt0192 { get; set; }

    public virtual DbSet<VwCxcRpt020> VwCxcRpt020 { get; set; }

    public virtual DbSet<VwCxpEdehsaRpt005> VwCxpEdehsaRpt005 { get; set; }

    public virtual DbSet<VwCxpEdehsaRpt006> VwCxpEdehsaRpt006 { get; set; }

    public virtual DbSet<VwCxpEdehsaRpt007> VwCxpEdehsaRpt007 { get; set; }

    public virtual DbSet<VwCxpRpt001> VwCxpRpt001 { get; set; }

    public virtual DbSet<VwCxpRpt002> VwCxpRpt002 { get; set; }

    public virtual DbSet<VwCxpRpt003> VwCxpRpt003 { get; set; }

    public virtual DbSet<VwCxpRpt004> VwCxpRpt004 { get; set; }

    public virtual DbSet<VwCxpRpt005> VwCxpRpt005 { get; set; }

    public virtual DbSet<VwCxpRpt006> VwCxpRpt006 { get; set; }

    public virtual DbSet<VwCxpRpt007> VwCxpRpt007 { get; set; }

    public virtual DbSet<VwCxpRpt008> VwCxpRpt008 { get; set; }

    public virtual DbSet<VwCxpRpt010> VwCxpRpt010 { get; set; }

    public virtual DbSet<VwCxpRpt011> VwCxpRpt011 { get; set; }

    public virtual DbSet<VwCxpRpt012> VwCxpRpt012 { get; set; }

    public virtual DbSet<VwCxpRpt015> VwCxpRpt015 { get; set; }

    public virtual DbSet<VwCxpRpt016> VwCxpRpt016 { get; set; }

    public virtual DbSet<VwCxpRpt018> VwCxpRpt018 { get; set; }

    public virtual DbSet<VwCxpRpt019> VwCxpRpt019 { get; set; }

    public virtual DbSet<VwCxpRpt021> VwCxpRpt021 { get; set; }

    public virtual DbSet<VwCxpRpt022> VwCxpRpt022 { get; set; }

    public virtual DbSet<VwCxpRpt023> VwCxpRpt023 { get; set; }

    public virtual DbSet<VwCxpRpt024> VwCxpRpt024 { get; set; }

    public virtual DbSet<VwCxpRpt025> VwCxpRpt025 { get; set; }

    public virtual DbSet<VwCxpRpt026> VwCxpRpt026 { get; set; }

    public virtual DbSet<VwCxpRpt027> VwCxpRpt027 { get; set; }

    public virtual DbSet<VwCxpRpt028> VwCxpRpt028 { get; set; }

    public virtual DbSet<VwCxpRpt029> VwCxpRpt029 { get; set; }

    public virtual DbSet<VwCxpRpt030> VwCxpRpt030 { get; set; }

    public virtual DbSet<VwCxpRpt031> VwCxpRpt031 { get; set; }

    public virtual DbSet<VwCxpRpt032> VwCxpRpt032 { get; set; }

    public virtual DbSet<VwCxpRpt033> VwCxpRpt033 { get; set; }

    public virtual DbSet<VwCxpRpt034> VwCxpRpt034 { get; set; }

    public virtual DbSet<VwCxpRpt036> VwCxpRpt036 { get; set; }

    public virtual DbSet<VwCxpRpt039> VwCxpRpt039 { get; set; }

    public virtual DbSet<VwCxpRpt040> VwCxpRpt040 { get; set; }

    public virtual DbSet<VwEstadoCivil> VwEstadoCivil { get; set; }

    public virtual DbSet<VwFaDocumentoDeclaracionSri> VwFaDocumentoDeclaracionSri { get; set; }

    public virtual DbSet<VwFaDocumentoDeclaracionSriData> VwFaDocumentoDeclaracionSriData { get; set; }

    public virtual DbSet<VwFaDocumentosRelacionadosNcNd> VwFaDocumentosRelacionadosNcNd { get; set; }

    public virtual DbSet<VwFaDocumentosXRelacionarNcNd> VwFaDocumentosXRelacionarNcNd { get; set; }

    public virtual DbSet<VwFaFacturasConDevolucionxItemSaldos> VwFaFacturasConDevolucionxItemSaldos { get; set; }

    public virtual DbSet<VwFaFacturasYNotasDebito> VwFaFacturasYNotasDebito { get; set; }

    public virtual DbSet<VwFaFacturasxDevolucionxItem> VwFaFacturasxDevolucionxItem { get; set; }

    public virtual DbSet<VwFaFormasPagoXFacturaDeclaracionSri> VwFaFormasPagoXFacturaDeclaracionSri { get; set; }

    public virtual DbSet<VwFaPedidoDetXOrdenDespConSaldo> VwFaPedidoDetXOrdenDespConSaldo { get; set; }

    public virtual DbSet<VwFaProductoXPedidos> VwFaProductoXPedidos { get; set; }

    public virtual DbSet<VwFaTipoNotaXEmpresa> VwFaTipoNotaXEmpresa { get; set; }

    public virtual DbSet<VwFaTotalPedidosXClienteNoDespachados> VwFaTotalPedidosXClienteNoDespachados { get; set; }

    public virtual DbSet<VwFaVentasXClienteXPeriodoBi> VwFaVentasXClienteXPeriodoBi { get; set; }

    public virtual DbSet<VwFacEdehsaRpt001> VwFacEdehsaRpt001 { get; set; }

    public virtual DbSet<VwFacEdehsaRpt002> VwFacEdehsaRpt002 { get; set; }

    public virtual DbSet<VwFacEdehsaRpt003> VwFacEdehsaRpt003 { get; set; }

    public virtual DbSet<VwFacRpt001> VwFacRpt001 { get; set; }

    public virtual DbSet<VwFacRpt002> VwFacRpt002 { get; set; }

    public virtual DbSet<VwFacRpt003> VwFacRpt003 { get; set; }

    public virtual DbSet<VwFacRpt004> VwFacRpt004 { get; set; }

    public virtual DbSet<VwFacRpt004Detalle> VwFacRpt004Detalle { get; set; }

    public virtual DbSet<VwFacRpt005> VwFacRpt005 { get; set; }

    public virtual DbSet<VwFacRpt006> VwFacRpt006 { get; set; }

    public virtual DbSet<VwFacRpt007> VwFacRpt007 { get; set; }

    public virtual DbSet<VwFacRpt008> VwFacRpt008 { get; set; }

    public virtual DbSet<VwFacRpt009> VwFacRpt009 { get; set; }

    public virtual DbSet<VwFacRpt010> VwFacRpt010 { get; set; }

    public virtual DbSet<VwFacRpt011> VwFacRpt011 { get; set; }

    public virtual DbSet<VwFacRpt012> VwFacRpt012 { get; set; }

    public virtual DbSet<VwFacRpt013> VwFacRpt013 { get; set; }

    public virtual DbSet<VwFacRpt014> VwFacRpt014 { get; set; }

    public virtual DbSet<VwFacRpt016> VwFacRpt016 { get; set; }

    public virtual DbSet<VwGeTbSisDocumentoTipoTalonario> VwGeTbSisDocumentoTipoTalonario { get; set; }

    public virtual DbSet<VwGeTbTarjetaTbParametro> VwGeTbTarjetaTbParametro { get; set; }

    public virtual DbSet<VwInDashboardGuiaRemision> VwInDashboardGuiaRemision { get; set; }

    public virtual DbSet<VwInIngEgrInvenDetXCbteCble> VwInIngEgrInvenDetXCbteCble { get; set; }

    public virtual DbSet<VwInvEdehsaRpt001> VwInvEdehsaRpt001 { get; set; }

    public virtual DbSet<VwInvRpt001> VwInvRpt001 { get; set; }

    public virtual DbSet<VwInvRpt002> VwInvRpt002 { get; set; }

    public virtual DbSet<VwInvRpt003> VwInvRpt003 { get; set; }

    public virtual DbSet<VwInvRpt004> VwInvRpt004 { get; set; }

    public virtual DbSet<VwInvRpt005> VwInvRpt005 { get; set; }

    public virtual DbSet<VwInvRpt006> VwInvRpt006 { get; set; }

    public virtual DbSet<VwInvRpt007> VwInvRpt007 { get; set; }

    public virtual DbSet<VwInvRpt009> VwInvRpt009 { get; set; }

    public virtual DbSet<VwInvRpt010> VwInvRpt010 { get; set; }

    public virtual DbSet<VwInvRpt011> VwInvRpt011 { get; set; }

    public virtual DbSet<VwInvRpt012> VwInvRpt012 { get; set; }

    public virtual DbSet<VwInvRpt013> VwInvRpt013 { get; set; }

    public virtual DbSet<VwInvRpt015> VwInvRpt015 { get; set; }

    public virtual DbSet<VwInvRpt016> VwInvRpt016 { get; set; }

    public virtual DbSet<VwInvRpt017> VwInvRpt017 { get; set; }

    public virtual DbSet<VwInvRpt019> VwInvRpt019 { get; set; }

    public virtual DbSet<VwInvRpt020> VwInvRpt020 { get; set; }

    public virtual DbSet<VwInvRpt022> VwInvRpt022 { get; set; }

    public virtual DbSet<VwInvRpt023> VwInvRpt023 { get; set; }

    public virtual DbSet<VwInvRpt024> VwInvRpt024 { get; set; }

    public virtual DbSet<VwInvRpt025> VwInvRpt025 { get; set; }

    public virtual DbSet<VwInvRpt028> VwInvRpt028 { get; set; }

    public virtual DbSet<VwInvRpt030> VwInvRpt030 { get; set; }

    public virtual DbSet<VwInvRpt031> VwInvRpt031 { get; set; }

    public virtual DbSet<VwInvRpt037> VwInvRpt037 { get; set; }

    public virtual DbSet<VwInvRpt038> VwInvRpt038 { get; set; }

    public virtual DbSet<VwInvRpt039> VwInvRpt039 { get; set; }

    public virtual DbSet<VwInvRpt041> VwInvRpt041 { get; set; }

    public virtual DbSet<VwNaturalezaPersona> VwNaturalezaPersona { get; set; }

    public virtual DbSet<VwOrdenPagoCancelacionesTotalAplicado> VwOrdenPagoCancelacionesTotalAplicado { get; set; }

    public virtual DbSet<VwPersona> VwPersona { get; set; }

    public virtual DbSet<VwSegMenuXUsuarioXEmpresa> VwSegMenuXUsuarioXEmpresa { get; set; }

    public virtual DbSet<VwSysCbteRecursivo> VwSysCbteRecursivo { get; set; }

    public virtual DbSet<VwTipoCtaBancos> VwTipoCtaBancos { get; set; }

    public virtual DbSet<VwTipoDocumento> VwTipoDocumento { get; set; }

    public virtual DbSet<VwTipoEmpleado> VwTipoEmpleado { get; set; }

    public virtual DbSet<VwTipoEstudios> VwTipoEstudios { get; set; }

    public virtual DbSet<VwTipoSangre> VwTipoSangre { get; set; }

    public virtual DbSet<VwTipoTitulo> VwTipoTitulo { get; set; }

    public virtual DbSet<VwUsuario> VwUsuario { get; set; }

    public virtual DbSet<VwafPeriodoSinDepreciar> VwafPeriodoSinDepreciar { get; set; }

    public virtual DbSet<VwbaBaBancoCuenta> VwbaBaBancoCuenta { get; set; }

    public virtual DbSet<VwbaBaPrestamoDetalleXAfActivoFijoPrendados> VwbaBaPrestamoDetalleXAfActivoFijoPrendados { get; set; }

    public virtual DbSet<VwbaBancoEstadoCheques> VwbaBancoEstadoCheques { get; set; }

    public virtual DbSet<VwbaBancoMovimientoDetCancelado> VwbaBancoMovimientoDetCancelado { get; set; }

    public virtual DbSet<VwbaBancoMovimientoDetCanceladoLite> VwbaBancoMovimientoDetCanceladoLite { get; set; }

    public virtual DbSet<VwbaCatalogoIdAutoNumeric> VwbaCatalogoIdAutoNumeric { get; set; }

    public virtual DbSet<VwbaCbteBan> VwbaCbteBan { get; set; }

    public virtual DbSet<VwbaCbteBanDetallePagos> VwbaCbteBanDetallePagos { get; set; }

    public virtual DbSet<VwbaCbteBanTipoXCtCbteCbleTipo> VwbaCbteBanTipoXCtCbteCbleTipo { get; set; }

    public virtual DbSet<VwbaCbteBanVarios> VwbaCbteBanVarios { get; set; }

    public virtual DbSet<VwbaConciliacion> VwbaConciliacion { get; set; }

    public virtual DbSet<VwbaConciliacionDetIngEgr> VwbaConciliacionDetIngEgr { get; set; }

    public virtual DbSet<VwbaEstadoCbteBan> VwbaEstadoCbteBan { get; set; }

    public virtual DbSet<VwbaEstadoPago> VwbaEstadoPago { get; set; }

    public virtual DbSet<VwbaMetodoCalculo> VwbaMetodoCalculo { get; set; }

    public virtual DbSet<VwbaMotivoPrestamo> VwbaMotivoPrestamo { get; set; }

    public virtual DbSet<VwbaMoviCajaDepositados> VwbaMoviCajaDepositados { get; set; }

    public virtual DbSet<VwbaNotasDebCreMasivo> VwbaNotasDebCreMasivo { get; set; }

    public virtual DbSet<VwbaNotasDebCreMasivoConsul> VwbaNotasDebCreMasivoConsul { get; set; }

    public virtual DbSet<VwbaOpBaArchivoTransferenciaDet> VwbaOpBaArchivoTransferenciaDet { get; set; }

    public virtual DbSet<VwbaOrdenGiroPendientes> VwbaOrdenGiroPendientes { get; set; }

    public virtual DbSet<VwbaPeriocidadPago> VwbaPeriocidadPago { get; set; }

    public virtual DbSet<VwbaPrestamo> VwbaPrestamo { get; set; }

    public virtual DbSet<VwbaPrestamoDetalleCancelacion> VwbaPrestamoDetalleCancelacion { get; set; }

    public virtual DbSet<VwbaTipoFlujo> VwbaTipoFlujo { get; set; }

    public virtual DbSet<VwbaTipoNota> VwbaTipoNota { get; set; }

    public virtual DbSet<VwbaTransaccionesAconciliar> VwbaTransaccionesAconciliar { get; set; }

    public virtual DbSet<VwbaTransferencia> VwbaTransferencia { get; set; }

    public virtual DbSet<VwcajCajCaja> VwcajCajCaja { get; set; }

    public virtual DbSet<VwcajCajCajaMovimiento> VwcajCajCajaMovimiento { get; set; }

    public virtual DbSet<VwcajCajaMovimientoDetCancelado> VwcajCajaMovimientoDetCancelado { get; set; }

    public virtual DbSet<VwcajCajaMovimientoTipo> VwcajCajaMovimientoTipo { get; set; }

    public virtual DbSet<VwcajCajaMovimientoTipoConCta> VwcajCajaMovimientoTipoConCta { get; set; }

    public virtual DbSet<VwcajCajaMovimientoXConciliar> VwcajCajaMovimientoXConciliar { get; set; }

    public virtual DbSet<VwcajCajachica> VwcajCajachica { get; set; }

    public virtual DbSet<VwcajCustodio> VwcajCustodio { get; set; }

    public virtual DbSet<VwcajMovCajaXCobro> VwcajMovCajaXCobro { get; set; }

    public virtual DbSet<VwcajMovCajaXCobroAnticipo> VwcajMovCajaXCobroAnticipo { get; set; }

    public virtual DbSet<VwcajMoviXDespositar> VwcajMoviXDespositar { get; set; }

    public virtual DbSet<VwcomCatalogoIdAutoNumeric> VwcomCatalogoIdAutoNumeric { get; set; }

    public virtual DbSet<VwcomCotizacionCompraEdehsa> VwcomCotizacionCompraEdehsa { get; set; }

    public virtual DbSet<VwcomDevCompra> VwcomDevCompra { get; set; }

    public virtual DbSet<VwcomDevCompraConDet> VwcomDevCompraConDet { get; set; }

    public virtual DbSet<VwcomDevCompraDetCantDevueltaXProd> VwcomDevCompraDetCantDevueltaXProd { get; set; }

    public virtual DbSet<VwcomEstadoAnulacion> VwcomEstadoAnulacion { get; set; }

    public virtual DbSet<VwcomEstadoAprobListReq> VwcomEstadoAprobListReq { get; set; }

    public virtual DbSet<VwcomEstadoAprobacion> VwcomEstadoAprobacion { get; set; }

    public virtual DbSet<VwcomEstadoAprobacionSolCompra> VwcomEstadoAprobacionSolCompra { get; set; }

    public virtual DbSet<VwcomEstadoRecibido> VwcomEstadoRecibido { get; set; }

    public virtual DbSet<VwcomMotivoRequerimiento> VwcomMotivoRequerimiento { get; set; }

    public virtual DbSet<VwcomOrdencompraLocal> VwcomOrdencompraLocal { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalConCantDevolver> VwcomOrdencompraLocalConCantDevolver { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDet> VwcomOrdencompraLocalDet { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDetConCantEnviadasXGuiaXTraspaso> VwcomOrdencompraLocalDetConCantEnviadasXGuiaXTraspaso { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDetConSaldoXIngAInven> VwcomOrdencompraLocalDetConSaldoXIngAInven { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDetConSaldoXIngAInvenConSaldo> VwcomOrdencompraLocalDetConSaldoXIngAInvenConSaldo { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDetGe> VwcomOrdencompraLocalDetGe { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDetXCantPedidaSolicCompra> VwcomOrdencompraLocalDetXCantPedidaSolicCompra { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDetXComSolicitudCompraDet> VwcomOrdencompraLocalDetXComSolicitudCompraDet { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalDetXMoviInvenSaldoItem> VwcomOrdencompraLocalDetXMoviInvenSaldoItem { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalGe> VwcomOrdencompraLocalGe { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalSinGuiaXTraspasoBodega> VwcomOrdencompraLocalSinGuiaXTraspasoBodega { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalSinGuiaXTraspasoBodegaConsul> VwcomOrdencompraLocalSinGuiaXTraspasoBodegaConsul { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalSinGuiaXTraspasoBodegaDet> VwcomOrdencompraLocalSinGuiaXTraspasoBodegaDet { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalVsInGuiaXTraspasoBodegaTotalReg> VwcomOrdencompraLocalVsInGuiaXTraspasoBodegaTotalReg { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalXComSolicitudCompra> VwcomOrdencompraLocalXComSolicitudCompra { get; set; }

    public virtual DbSet<VwcomOrdencompraLocalXInGuiaXTraspasoBodega> VwcomOrdencompraLocalXInGuiaXTraspasoBodega { get; set; }

    public virtual DbSet<VwcomSolicitudCompra> VwcomSolicitudCompra { get; set; }

    public virtual DbSet<VwcomSolicitudCompraDet> VwcomSolicitudCompraDet { get; set; }

    public virtual DbSet<VwcomSolicitudCompraDetAprobacion> VwcomSolicitudCompraDetAprobacion { get; set; }

    public virtual DbSet<VwcomSolicitudCompraDetCantidadPedidaCompra> VwcomSolicitudCompraDetCantidadPedidaCompra { get; set; }

    public virtual DbSet<VwcomSolicitudCompraDetSaldoPendiente> VwcomSolicitudCompraDetSaldoPendiente { get; set; }

    public virtual DbSet<VwcomSolicitudCompraDetXOrdenCompra> VwcomSolicitudCompraDetXOrdenCompra { get; set; }

    public virtual DbSet<VwcomSolicitudCompraXItemsConSaldos> VwcomSolicitudCompraXItemsConSaldos { get; set; }

    public virtual DbSet<VwcomSolicitudCompraXOrdenCompra> VwcomSolicitudCompraXOrdenCompra { get; set; }

    public virtual DbSet<VwcomTerminoPago> VwcomTerminoPago { get; set; }

    public virtual DbSet<VwcpAnticiposParaConciliar> VwcpAnticiposParaConciliar { get; set; }

    public virtual DbSet<VwcpAnticiposProveedores> VwcpAnticiposProveedores { get; set; }

    public virtual DbSet<VwcpAnticiposXNotaCredSaldo> VwcpAnticiposXNotaCredSaldo { get; set; }

    public virtual DbSet<VwcpAprobacionIngBodXOc> VwcpAprobacionIngBodXOc { get; set; }

    public virtual DbSet<VwcpAprobacionIngBodXOcDet> VwcpAprobacionIngBodXOcDet { get; set; }

    public virtual DbSet<VwcpBaArchivoTransferenciaDet> VwcpBaArchivoTransferenciaDet { get; set; }

    public virtual DbSet<VwcpBaseRetenciones> VwcpBaseRetenciones { get; set; }

    public virtual DbSet<VwcpCbteXPagarOg> VwcpCbteXPagarOg { get; set; }

    public virtual DbSet<VwcpCbtesCxpParaConciliar> VwcpCbtesCxpParaConciliar { get; set; }

    public virtual DbSet<VwcpCbtesCxpParaConciliarConsulta> VwcpCbtesCxpParaConciliarConsulta { get; set; }

    public virtual DbSet<VwcpCodigoSri> VwcpCodigoSri { get; set; }

    public virtual DbSet<VwcpCodigoSriXCtaCble> VwcpCodigoSriXCtaCble { get; set; }

    public virtual DbSet<VwcpComprobanteXRetencion> VwcpComprobanteXRetencion { get; set; }

    public virtual DbSet<VwcpConciliacionCaja> VwcpConciliacionCaja { get; set; }

    public virtual DbSet<VwcpConciliacionCajaDet> VwcpConciliacionCajaDet { get; set; }

    public virtual DbSet<VwcpConciliacionCajaDetIngCaja> VwcpConciliacionCajaDetIngCaja { get; set; }

    public virtual DbSet<VwcpConciliacionCajaDetIngCajaTotalAplicado> VwcpConciliacionCajaDetIngCajaTotalAplicado { get; set; }

    public virtual DbSet<VwcpConciliacionCajaDetXValeCaja> VwcpConciliacionCajaDetXValeCaja { get; set; }

    public virtual DbSet<VwcpConciliacionDetXCbtePago> VwcpConciliacionDetXCbtePago { get; set; }

    public virtual DbSet<VwcpConciliacionIngBodegaXOrdenGiro> VwcpConciliacionIngBodegaXOrdenGiro { get; set; }

    public virtual DbSet<VwcpConciliacionPoli> VwcpConciliacionPoli { get; set; }

    public virtual DbSet<VwcpConciliacionXCbteCble> VwcpConciliacionXCbteCble { get; set; }

    public virtual DbSet<VwcpConciliacionXOrdenPago> VwcpConciliacionXOrdenPago { get; set; }

    public virtual DbSet<VwcpCpRetencionXEmpresa> VwcpCpRetencionXEmpresa { get; set; }

    public virtual DbSet<VwcpLiquidacionCompraSri> VwcpLiquidacionCompraSri { get; set; }

    public virtual DbSet<VwcpNotaDebCre> VwcpNotaDebCre { get; set; }

    public virtual DbSet<VwcpNotaDebCreAts> VwcpNotaDebCreAts { get; set; }

    public virtual DbSet<VwcpNotaDebCreTotalSaldo> VwcpNotaDebCreTotalSaldo { get; set; }

    public virtual DbSet<VwcpOrdenGiroConciliadoXFactura> VwcpOrdenGiroConciliadoXFactura { get; set; }

    public virtual DbSet<VwcpOrdenGiroConciliadoXIngBodXOc> VwcpOrdenGiroConciliadoXIngBodXOc { get; set; }

    public virtual DbSet<VwcpOrdenGiroCpNotaDebCreEstcue> VwcpOrdenGiroCpNotaDebCreEstcue { get; set; }

    public virtual DbSet<VwcpOrdenGiroNotaDebito> VwcpOrdenGiroNotaDebito { get; set; }

    public virtual DbSet<VwcpOrdenGiroPendienteConciliar> VwcpOrdenGiroPendienteConciliar { get; set; }

    public virtual DbSet<VwcpOrdenGiroRetencionReport> VwcpOrdenGiroRetencionReport { get; set; }

    public virtual DbSet<VwcpOrdenGiroSinRetenciones> VwcpOrdenGiroSinRetenciones { get; set; }

    public virtual DbSet<VwcpOrdenGiroSri> VwcpOrdenGiroSri { get; set; }

    public virtual DbSet<VwcpOrdenGiroTotalPagodo> VwcpOrdenGiroTotalPagodo { get; set; }

    public virtual DbSet<VwcpOrdenGiroTotalSaldo> VwcpOrdenGiroTotalSaldo { get; set; }

    public virtual DbSet<VwcpOrdenGiroXComOrdencompraLocalDetConsulta> VwcpOrdenGiroXComOrdencompraLocalDetConsulta { get; set; }

    public virtual DbSet<VwcpOrdenGiroXPagar> VwcpOrdenGiroXPagar { get; set; }

    public virtual DbSet<VwcpOrdenGiroXPagosSaldo> VwcpOrdenGiroXPagosSaldo { get; set; }

    public virtual DbSet<VwcpOrdenGiroXPagosSaldoSinIngresos> VwcpOrdenGiroXPagosSaldoSinIngresos { get; set; }

    public virtual DbSet<VwcpOrdenPago> VwcpOrdenPago { get; set; }

    public virtual DbSet<VwcpOrdenPagoAnticipoSaldo> VwcpOrdenPagoAnticipoSaldo { get; set; }

    public virtual DbSet<VwcpOrdenPagoCancelacionSaldos> VwcpOrdenPagoCancelacionSaldos { get; set; }

    public virtual DbSet<VwcpOrdenPagoCancelacionTotalPagadoXCbteble> VwcpOrdenPagoCancelacionTotalPagadoXCbteble { get; set; }

    public virtual DbSet<VwcpOrdenPagoConCancelacion> VwcpOrdenPagoConCancelacion { get; set; }

    public virtual DbSet<VwcpOrdenPagoConCancelacionLite> VwcpOrdenPagoConCancelacionLite { get; set; }

    public virtual DbSet<VwcpOrdenPagoConCancelacionPagadoConCbteBan> VwcpOrdenPagoConCancelacionPagadoConCbteBan { get; set; }

    public virtual DbSet<VwcpOrdenPagoConCancelacionPagadoConNcxp> VwcpOrdenPagoConCancelacionPagadoConNcxp { get; set; }

    public virtual DbSet<VwcpOrdenPagoConCancelacionParaConciliacion> VwcpOrdenPagoConCancelacionParaConciliacion { get; set; }

    public virtual DbSet<VwcpOrdenPagoConCancelacionXCbteBanDebi> VwcpOrdenPagoConCancelacionXCbteBanDebi { get; set; }

    public virtual DbSet<VwcpOrdenPagoConTransferencia> VwcpOrdenPagoConTransferencia { get; set; }

    public virtual DbSet<VwcpOrdenPagoDet> VwcpOrdenPagoDet { get; set; }

    public virtual DbSet<VwcpOrdenPagoDetActiva> VwcpOrdenPagoDetActiva { get; set; }

    public virtual DbSet<VwcpOrdenPagoDetConCtaAcreedora> VwcpOrdenPagoDetConCtaAcreedora { get; set; }

    public virtual DbSet<VwcpOrdenPagoParaAprobacion> VwcpOrdenPagoParaAprobacion { get; set; }

    public virtual DbSet<VwcpOrdenPagoTipoXEmpresa> VwcpOrdenPagoTipoXEmpresa { get; set; }

    public virtual DbSet<VwcpOrdenPagoTotal> VwcpOrdenPagoTotal { get; set; }

    public virtual DbSet<VwcpOrdenPagoTotalCancelacion> VwcpOrdenPagoTotalCancelacion { get; set; }

    public virtual DbSet<VwcpOrdenPagoTotalPagado> VwcpOrdenPagoTotalPagado { get; set; }

    public virtual DbSet<VwcpOrdenPagoTotalPago> VwcpOrdenPagoTotalPago { get; set; }

    public virtual DbSet<VwcpProveedorCalificacion> VwcpProveedorCalificacion { get; set; }

    public virtual DbSet<VwcpProveedorRuc> VwcpProveedorRuc { get; set; }

    public virtual DbSet<VwcpProveedorVistaPrevia> VwcpProveedorVistaPrevia { get; set; }

    public virtual DbSet<VwcpRetencion> VwcpRetencion { get; set; }

    public virtual DbSet<VwcpRetencionSri> VwcpRetencionSri { get; set; }

    public virtual DbSet<VwcpRetencionValorTotalXCbteCxp> VwcpRetencionValorTotalXCbteCxp { get; set; }

    public virtual DbSet<VwcpRetencionXRetFt> VwcpRetencionXRetFt { get; set; }

    public virtual DbSet<VwcpRetencionXRetIva> VwcpRetencionXRetIva { get; set; }

    public virtual DbSet<VwcpRetencionesXTipoImpresion> VwcpRetencionesXTipoImpresion { get; set; }

    public virtual DbSet<VwcpTipoImpresionCheq> VwcpTipoImpresionCheq { get; set; }

    public virtual DbSet<VwcpTipoServicioxProve> VwcpTipoServicioxProve { get; set; }

    public virtual DbSet<VwcpTotalCanceladoXCbteCxp> VwcpTotalCanceladoXCbteCxp { get; set; }

    public virtual DbSet<VwctAnioFiscalXCuentaUtilidad> VwctAnioFiscalXCuentaUtilidad { get; set; }

    public virtual DbSet<VwctCbtecbleConCtacbleAcreedora> VwctCbtecbleConCtacbleAcreedora { get; set; }

    public virtual DbSet<VwctCbtecbleConSaldo> VwctCbtecbleConSaldo { get; set; }

    public virtual DbSet<VwctCbtecbleConSaldoCxp> VwctCbtecbleConSaldoCxp { get; set; }

    public virtual DbSet<VwctCbtecbleConSaldoCxpAntiProvee> VwctCbtecbleConSaldoCxpAntiProvee { get; set; }

    public virtual DbSet<VwctCbtecbleConSaldoCxpConsulta> VwctCbtecbleConSaldoCxpConsulta { get; set; }

    public virtual DbSet<VwctCbtecbleConSaldoCxpDiario> VwctCbtecbleConSaldoCxpDiario { get; set; }

    public virtual DbSet<VwctCbtecbleConSaldoCxpNota> VwctCbtecbleConSaldoCxpNota { get; set; }

    public virtual DbSet<VwctCbtecbleDet> VwctCbtecbleDet { get; set; }

    public virtual DbSet<VwctCbtecbleDetTotalDiario> VwctCbtecbleDetTotalDiario { get; set; }

    public virtual DbSet<VwctCbtecbleXCpConciliacionCaja> VwctCbtecbleXCpConciliacionCaja { get; set; }

    public virtual DbSet<VwctCentroCosto> VwctCentroCosto { get; set; }

    public virtual DbSet<VwctCentroCostoSubCentroCosto> VwctCentroCostoSubCentroCosto { get; set; }

    public virtual DbSet<VwctCentroCostoXFaClienteObra> VwctCentroCostoXFaClienteObra { get; set; }

    public virtual DbSet<VwctComprobanteContable> VwctComprobanteContable { get; set; }

    public virtual DbSet<VwctGrupoXTipoGasto> VwctGrupoXTipoGasto { get; set; }

    public virtual DbSet<VwctPeriodo> VwctPeriodo { get; set; }

    public virtual DbSet<VwctPlancta> VwctPlancta { get; set; }

    public virtual DbSet<VwctPlanctaNivel> VwctPlanctaNivel { get; set; }

    public virtual DbSet<VwctSaldosxCuentas> VwctSaldosxCuentas { get; set; }

    public virtual DbSet<VwctUtilidadxPeriodo> VwctUtilidadxPeriodo { get; set; }

    public virtual DbSet<VwctUtilidadxPeriodoSaldoAcumulado> VwctUtilidadxPeriodoSaldoAcumulado { get; set; }

    public virtual DbSet<VwctUtilidadxPeriodoSaldoAnterior> VwctUtilidadxPeriodoSaldoAnterior { get; set; }

    public virtual DbSet<VwctUtilidadxPeriodoSaldoPeriodoActual> VwctUtilidadxPeriodoSaldoPeriodoActual { get; set; }

    public virtual DbSet<VwcxcAnticipoFacturado> VwcxcAnticipoFacturado { get; set; }

    public virtual DbSet<VwcxcAnticiposXCruzar> VwcxcAnticiposXCruzar { get; set; }

    public virtual DbSet<VwcxcAnticiposXCruzarEdehsa> VwcxcAnticiposXCruzarEdehsa { get; set; }

    public virtual DbSet<VwcxcCancelacionIntercompany> VwcxcCancelacionIntercompany { get; set; }

    public virtual DbSet<VwcxcCancelacionIntercompanyXCxcCobroDet> VwcxcCancelacionIntercompanyXCxcCobroDet { get; set; }

    public virtual DbSet<VwcxcCarteraXCobrar> VwcxcCarteraXCobrar { get; set; }

    public virtual DbSet<VwcxcCarteraXCobrarEdehsa> VwcxcCarteraXCobrarEdehsa { get; set; }

    public virtual DbSet<VwcxcCobro> VwcxcCobro { get; set; }

    public virtual DbSet<VwcxcCobroDet> VwcxcCobroDet { get; set; }

    public virtual DbSet<VwcxcCobroTipoParamContaXSucursal> VwcxcCobroTipoParamContaXSucursal { get; set; }

    public virtual DbSet<VwcxcCobroXAnticipoPendientesDeDiario> VwcxcCobroXAnticipoPendientesDeDiario { get; set; }

    public virtual DbSet<VwcxcCobroXAnticipoTotalRespaldado> VwcxcCobroXAnticipoTotalRespaldado { get; set; }

    public virtual DbSet<VwcxcCobroXAnticipoXCobros> VwcxcCobroXAnticipoXCobros { get; set; }

    public virtual DbSet<VwcxcCobroXAnticipoXPersona> VwcxcCobroXAnticipoXPersona { get; set; }

    public virtual DbSet<VwcxcCobroXCajCajaMovimiento> VwcxcCobroXCajCajaMovimiento { get; set; }

    public virtual DbSet<VwcxcCobroXCobroDet> VwcxcCobroXCobroDet { get; set; }

    public virtual DbSet<VwcxcCobroXDocumentosXCobrar> VwcxcCobroXDocumentosXCobrar { get; set; }

    public virtual DbSet<VwcxcCobroXEstadoCobro> VwcxcCobroXEstadoCobro { get; set; }

    public virtual DbSet<VwcxcCobroXMoviCajaXCbtecble> VwcxcCobroXMoviCajaXCbtecble { get; set; }

    public virtual DbSet<VwcxcCobrosConciliados> VwcxcCobrosConciliados { get; set; }

    public virtual DbSet<VwcxcCobrosPendientesDeDeposito> VwcxcCobrosPendientesDeDeposito { get; set; }

    public virtual DbSet<VwcxcCobrosPendientesXConciliar> VwcxcCobrosPendientesXConciliar { get; set; }

    public virtual DbSet<VwcxcCobrosPendientesXConciliarEdehsa> VwcxcCobrosPendientesXConciliarEdehsa { get; set; }

    public virtual DbSet<VwcxcCobrosXChequeDeposito> VwcxcCobrosXChequeDeposito { get; set; }

    public virtual DbSet<VwcxcCobrosXNdXRetFteXClienteXAnioMes> VwcxcCobrosXNdXRetFteXClienteXAnioMes { get; set; }

    public virtual DbSet<VwcxcCobrosXNdXRetIvaXClienteXAnioMes> VwcxcCobrosXNdXRetIvaXClienteXAnioMes { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaNotaXRetFuente> VwcxcCobrosXVtaNotaXRetFuente { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaNotaXRetFuenteEdehsa> VwcxcCobrosXVtaNotaXRetFuenteEdehsa { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaNotaXRetFuenteSumatoria> VwcxcCobrosXVtaNotaXRetFuenteSumatoria { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaNotaXRetIva> VwcxcCobrosXVtaNotaXRetIva { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaNotaXRetIvaEdehsa> VwcxcCobrosXVtaNotaXRetIvaEdehsa { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaNotaXRetIvaSumatoria> VwcxcCobrosXVtaNotaXRetIvaSumatoria { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaXRetFteXClienteXAnioMes> VwcxcCobrosXVtaXRetFteXClienteXAnioMes { get; set; }

    public virtual DbSet<VwcxcCobrosXVtaXRetIvaXClienteXAnioMes> VwcxcCobrosXVtaXRetIvaXClienteXAnioMes { get; set; }

    public virtual DbSet<VwcxcConciliacion> VwcxcConciliacion { get; set; }

    public virtual DbSet<VwcxcConciliacionDetAnticipo> VwcxcConciliacionDetAnticipo { get; set; }

    public virtual DbSet<VwcxcConciliacionDetCobro> VwcxcConciliacionDetCobro { get; set; }

    public virtual DbSet<VwcxcConciliacionDetCreDeb> VwcxcConciliacionDetCreDeb { get; set; }

    public virtual DbSet<VwcxcConciliacionEdehsa> VwcxcConciliacionEdehsa { get; set; }

    public virtual DbSet<VwcxcDetalleDeposito> VwcxcDetalleDeposito { get; set; }

    public virtual DbSet<VwcxcEstadoCobroActual> VwcxcEstadoCobroActual { get; set; }

    public virtual DbSet<VwcxcParametrosXCheqProtesto> VwcxcParametrosXCheqProtesto { get; set; }

    public virtual DbSet<VwcxcRetencionMultiple> VwcxcRetencionMultiple { get; set; }

    public virtual DbSet<VwcxcTotalCobrosXDocu> VwcxcTotalCobrosXDocu { get; set; }

    public virtual DbSet<VwfaCatalogoIdAutoNumeric> VwfaCatalogoIdAutoNumeric { get; set; }

    public virtual DbSet<VwfaCliente> VwfaCliente { get; set; }

    public virtual DbSet<VwfaClienteVistaPrevia> VwfaClienteVistaPrevia { get; set; }

    public virtual DbSet<VwfaClientesContactos> VwfaClientesContactos { get; set; }

    public virtual DbSet<VwfaContabilizacionFactura> VwfaContabilizacionFactura { get; set; }

    public virtual DbSet<VwfaContabilizacionFacturaXCosto> VwfaContabilizacionFacturaXCosto { get; set; }

    public virtual DbSet<VwfaContabilizacionFacturaXDescuentoXItem> VwfaContabilizacionFacturaXDescuentoXItem { get; set; }

    public virtual DbSet<VwfaContabilizacionFacturaXItem> VwfaContabilizacionFacturaXItem { get; set; }

    public virtual DbSet<VwfaContabilizacionFacturaXSucursal> VwfaContabilizacionFacturaXSucursal { get; set; }

    public virtual DbSet<VwfaContabilizacionNotaCreditoXDescuentoXItem> VwfaContabilizacionNotaCreditoXDescuentoXItem { get; set; }

    public virtual DbSet<VwfaContabilizarNotaCredDeb> VwfaContabilizarNotaCredDeb { get; set; }

    public virtual DbSet<VwfaContabilizarNotaCredDebXItem> VwfaContabilizarNotaCredDebXItem { get; set; }

    public virtual DbSet<VwfaContabilizarNotaCredDebXSucursal> VwfaContabilizarNotaCredDebXSucursal { get; set; }

    public virtual DbSet<VwfaCostoProductoVendido> VwfaCostoProductoVendido { get; set; }

    public virtual DbSet<VwfaCostoProductoVendidoDetalle> VwfaCostoProductoVendidoDetalle { get; set; }

    public virtual DbSet<VwfaCotizacionDetalle> VwfaCotizacionDetalle { get; set; }

    public virtual DbSet<VwfaCreditosDebitosConSaldo> VwfaCreditosDebitosConSaldo { get; set; }

    public virtual DbSet<VwfaCreditosDebitosConSaldoEdehsa> VwfaCreditosDebitosConSaldoEdehsa { get; set; }

    public virtual DbSet<VwfaDevolucion> VwfaDevolucion { get; set; }

    public virtual DbSet<VwfaDocumentoTipoXSecuenciaTalonario> VwfaDocumentoTipoXSecuenciaTalonario { get; set; }

    public virtual DbSet<VwfaFaGuiaRemisionXEmpresa> VwfaFaGuiaRemisionXEmpresa { get; set; }

    public virtual DbSet<VwfaFaNotaCreDebXEmpresa> VwfaFaNotaCreDebXEmpresa { get; set; }

    public virtual DbSet<VwfaFactura> VwfaFactura { get; set; }

    public virtual DbSet<VwfaFacturaDet> VwfaFacturaDet { get; set; }

    public virtual DbSet<VwfaFacturaDev> VwfaFacturaDev { get; set; }

    public virtual DbSet<VwfaFacturaEdehsa> VwfaFacturaEdehsa { get; set; }

    public virtual DbSet<VwfaFacturaSri> VwfaFacturaSri { get; set; }

    public virtual DbSet<VwfaFacturaSubTotalIvaTotal> VwfaFacturaSubTotalIvaTotal { get; set; }

    public virtual DbSet<VwfaFacturaSubtotalIva> VwfaFacturaSubtotalIva { get; set; }

    public virtual DbSet<VwfaFacturaSubtotalIva0Totales> VwfaFacturaSubtotalIva0Totales { get; set; }

    public virtual DbSet<VwfaFacturaTotalCobrado> VwfaFacturaTotalCobrado { get; set; }

    public virtual DbSet<VwfaFacturaXInMoviInve> VwfaFacturaXInMoviInve { get; set; }

    public virtual DbSet<VwfaGuiaRemision> VwfaGuiaRemision { get; set; }

    public virtual DbSet<VwfaGuiaRemisionDet> VwfaGuiaRemisionDet { get; set; }

    public virtual DbSet<VwfaGuiaRemisionSinFactura> VwfaGuiaRemisionSinFactura { get; set; }

    public virtual DbSet<VwfaMotivoAprobacionPedidoVenta> VwfaMotivoAprobacionPedidoVenta { get; set; }

    public virtual DbSet<VwfaMovimientosXBodegaXCat> VwfaMovimientosXBodegaXCat { get; set; }

    public virtual DbSet<VwfaNotaCreDeb> VwfaNotaCreDeb { get; set; }

    public virtual DbSet<VwfaNotaCreDebDetSri> VwfaNotaCreDebDetSri { get; set; }

    public virtual DbSet<VwfaNotaCreDebDetSubtotalIva0Totales> VwfaNotaCreDebDetSubtotalIva0Totales { get; set; }

    public virtual DbSet<VwfaNotaCreDebDetSubtotalIvaTotal> VwfaNotaCreDebDetSubtotalIvaTotal { get; set; }

    public virtual DbSet<VwfaNotaCreDebSri> VwfaNotaCreDebSri { get; set; }

    public virtual DbSet<VwfaNotaCreDebXCxcCobro> VwfaNotaCreDebXCxcCobro { get; set; }

    public virtual DbSet<VwfaNotaCreDebXFaFacturaNotaDeb> VwfaNotaCreDebXFaFacturaNotaDeb { get; set; }

    public virtual DbSet<VwfaNotaCreDebXFaFacturaNotaDebSinCobros> VwfaNotaCreDebXFaFacturaNotaDebSinCobros { get; set; }

    public virtual DbSet<VwfaNotaCreDebXFaFacturaNotaDebXCxcCobro> VwfaNotaCreDebXFaFacturaNotaDebXCxcCobro { get; set; }

    public virtual DbSet<VwfaNotaCreDebXFaFacturaNotaDebXNc> VwfaNotaCreDebXFaFacturaNotaDebXNc { get; set; }

    public virtual DbSet<VwfaNotaCreDebXValoresAplicados> VwfaNotaCreDebXValoresAplicados { get; set; }

    public virtual DbSet<VwfaNotaCredito> VwfaNotaCredito { get; set; }

    public virtual DbSet<VwfaNotaCreditoEdehsa> VwfaNotaCreditoEdehsa { get; set; }

    public virtual DbSet<VwfaNotaCreditoXDevolver> VwfaNotaCreditoXDevolver { get; set; }

    public virtual DbSet<VwfaOrdenDespDetXFaPedidoDetXPedido> VwfaOrdenDespDetXFaPedidoDetXPedido { get; set; }

    public virtual DbSet<VwfaOrdenDespDetXPedidoDet> VwfaOrdenDespDetXPedidoDet { get; set; }

    public virtual DbSet<VwfaOrdenDespSinGuiaRemi> VwfaOrdenDespSinGuiaRemi { get; set; }

    public virtual DbSet<VwfaOrdenDespachoDetalle> VwfaOrdenDespachoDetalle { get; set; }

    public virtual DbSet<VwfaPedidoDetalle> VwfaPedidoDetalle { get; set; }

    public virtual DbSet<VwfaPedidoXFaOrdenDespDetXFaGuiaRemisionDet> VwfaPedidoXFaOrdenDespDetXFaGuiaRemisionDet { get; set; }

    public virtual DbSet<VwfaPuntoVta> VwfaPuntoVta { get; set; }

    public virtual DbSet<VwfaVentaTelefonicaDet> VwfaVentaTelefonicaDet { get; set; }

    public virtual DbSet<VwinAjusteFisico> VwinAjusteFisico { get; set; }

    public virtual DbSet<VwinAjusteFisicoXRelacionInvenXCbteCble> VwinAjusteFisicoXRelacionInvenXCbteCble { get; set; }

    public virtual DbSet<VwinCateLinGrupSubGrup> VwinCateLinGrupSubGrup { get; set; }

    public virtual DbSet<VwinCategoriaLinGrSubgr> VwinCategoriaLinGrSubgr { get; set; }

    public virtual DbSet<VwinDevolucionInven> VwinDevolucionInven { get; set; }

    public virtual DbSet<VwinDevolucionInvenDet> VwinDevolucionInvenDet { get; set; }

    public virtual DbSet<VwinDevolucionInvenDetCantidadDevuelta> VwinDevolucionInvenDetCantidadDevuelta { get; set; }

    public virtual DbSet<VwinGeneracionCompraCidersus> VwinGeneracionCompraCidersus { get; set; }

    public virtual DbSet<VwinGuiaRemision> VwinGuiaRemision { get; set; }

    public virtual DbSet<VwinGuiaRemisionDetConSaldoXIngAInven> VwinGuiaRemisionDetConSaldoXIngAInven { get; set; }

    public virtual DbSet<VwinGuiaRemisionDetConSaldoXIngAInvenConSaldo> VwinGuiaRemisionDetConSaldoXIngAInvenConSaldo { get; set; }

    public virtual DbSet<VwinGuiaXTraspasoBodega> VwinGuiaXTraspasoBodega { get; set; }

    public virtual DbSet<VwinGuiaXTraspasoBodegaDetSinTransferencia> VwinGuiaXTraspasoBodegaDetSinTransferencia { get; set; }

    public virtual DbSet<VwinGuiaXTraspasoBodegaXOrdencompraLocalDet> VwinGuiaXTraspasoBodegaXOrdencompraLocalDet { get; set; }

    public virtual DbSet<VwinInGuiaXTraspasoBodegaXInTransferenciaDet> VwinInGuiaXTraspasoBodegaXInTransferenciaDet { get; set; }

    public virtual DbSet<VwinInProductoXTbBodegaXUnidadMedida> VwinInProductoXTbBodegaXUnidadMedida { get; set; }

    public virtual DbSet<VwinIngEgrInven> VwinIngEgrInven { get; set; }

    public virtual DbSet<VwinIngEgrInvenDet> VwinIngEgrInvenDet { get; set; }

    public virtual DbSet<VwinIngEgrInvenDetXComOrdencompraLocalDet> VwinIngEgrInvenDetXComOrdencompraLocalDet { get; set; }

    public virtual DbSet<VwinIngEgrInvenDetXComOrdencompraLocalDet2> VwinIngEgrInvenDetXComOrdencompraLocalDet2 { get; set; }

    public virtual DbSet<VwinIngEgrInvenDetXComOrdencompraLocalDetXCpAprob> VwinIngEgrInvenDetXComOrdencompraLocalDetXCpAprob { get; set; }

    public virtual DbSet<VwinIngEgrInvenDetXEstadoAprob> VwinIngEgrInvenDetXEstadoAprob { get; set; }

    public virtual DbSet<VwinIngEgrInvenDetXProducto> VwinIngEgrInvenDetXProducto { get; set; }

    public virtual DbSet<VwinIngEgrInvenParaDevolucion> VwinIngEgrInvenParaDevolucion { get; set; }

    public virtual DbSet<VwinIngEgrInvenXInMoviInve> VwinIngEgrInvenXInMoviInve { get; set; }

    public virtual DbSet<VwinMotivoTrasladoBodega> VwinMotivoTrasladoBodega { get; set; }

    public virtual DbSet<VwinMoviInve> VwinMoviInve { get; set; }

    public virtual DbSet<VwinMoviInveDetalle> VwinMoviInveDetalle { get; set; }

    public virtual DbSet<VwinMoviInveDetalleParaStockALaFecha> VwinMoviInveDetalleParaStockALaFecha { get; set; }

    public virtual DbSet<VwinMoviInveDetalleXComOrdencompraLocalDetTotalCant> VwinMoviInveDetalleXComOrdencompraLocalDetTotalCant { get; set; }

    public virtual DbSet<VwinMoviInveDetalleXContabilizarXCtacbles> VwinMoviInveDetalleXContabilizarXCtacbles { get; set; }

    public virtual DbSet<VwinMoviInveDetalleXItemDisponibles> VwinMoviInveDetalleXItemDisponibles { get; set; }

    public virtual DbSet<VwinMoviInveDetalleXItemIngresos> VwinMoviInveDetalleXItemIngresos { get; set; }

    public virtual DbSet<VwinMoviInveFechaCosteoRecomendadaXSucursal> VwinMoviInveFechaCosteoRecomendadaXSucursal { get; set; }

    public virtual DbSet<VwinMoviInveXCbteCbleDatos> VwinMoviInveXCbteCbleDatos { get; set; }

    public virtual DbSet<VwinMoviInveXComOrdencompraLocal> VwinMoviInveXComOrdencompraLocal { get; set; }

    public virtual DbSet<VwinMoviInveXDespachar> VwinMoviInveXDespachar { get; set; }

    public virtual DbSet<VwinMoviInveXEstadoContabilizacion> VwinMoviInveXEstadoContabilizacion { get; set; }

    public virtual DbSet<VwinMoviInveXIngOrdencompraLocal> VwinMoviInveXIngOrdencompraLocal { get; set; }

    public virtual DbSet<VwinMoviInvenXIngXOc> VwinMoviInvenXIngXOc { get; set; }

    public virtual DbSet<VwinPresentacion> VwinPresentacion { get; set; }

    public virtual DbSet<VwinProducto> VwinProducto { get; set; }

    public virtual DbSet<VwinProductoDespachado> VwinProductoDespachado { get; set; }

    public virtual DbSet<VwinProductoDespachadoXGuiaRemision> VwinProductoDespachadoXGuiaRemision { get; set; }

    public virtual DbSet<VwinProductoDespachadoXGuiaRemisionAcumulada> VwinProductoDespachadoXGuiaRemisionAcumulada { get; set; }

    public virtual DbSet<VwinProductoMarcaTipoCategoria> VwinProductoMarcaTipoCategoria { get; set; }

    public virtual DbSet<VwinProductoPedidosEgresosXBodega> VwinProductoPedidosEgresosXBodega { get; set; }

    public virtual DbSet<VwinProductoPrecioHistorico> VwinProductoPrecioHistorico { get; set; }

    public virtual DbSet<VwinProductoStock> VwinProductoStock { get; set; }

    public virtual DbSet<VwinProductoStockLote> VwinProductoStockLote { get; set; }

    public virtual DbSet<VwinProductoStockXBodega> VwinProductoStockXBodega { get; set; }

    public virtual DbSet<VwinProductoStockXProducto> VwinProductoStockXProducto { get; set; }

    public virtual DbSet<VwinProductoStockXSucursal> VwinProductoStockXSucursal { get; set; }

    public virtual DbSet<VwinProductoUltCostoHistXBod> VwinProductoUltCostoHistXBod { get; set; }

    public virtual DbSet<VwinProductoUltCostoHistXSucu> VwinProductoUltCostoHistXSucu { get; set; }

    public virtual DbSet<VwinProductoXModulo> VwinProductoXModulo { get; set; }

    public virtual DbSet<VwinProductoXModuloLite> VwinProductoXModuloLite { get; set; }

    public virtual DbSet<VwinProductoXModuloSinStock> VwinProductoXModuloSinStock { get; set; }

    public virtual DbSet<VwinProductoXProveedor> VwinProductoXProveedor { get; set; }

    public virtual DbSet<VwinProductoXSucursal> VwinProductoXSucursal { get; set; }

    public virtual DbSet<VwinProductoXTbBodega> VwinProductoXTbBodega { get; set; }

    public virtual DbSet<VwinProductoXTbBodegaCostoHistorico> VwinProductoXTbBodegaCostoHistorico { get; set; }

    public virtual DbSet<VwinProductoXTbBodegaLite> VwinProductoXTbBodegaLite { get; set; }

    public virtual DbSet<VwinProductoXTbBodegaLote> VwinProductoXTbBodegaLote { get; set; }

    public virtual DbSet<VwinProductoXTbBodegaPrecios> VwinProductoXTbBodegaPrecios { get; set; }

    public virtual DbSet<VwinProductoXTbBodegaSinStock> VwinProductoXTbBodegaSinStock { get; set; }

    public virtual DbSet<VwinProductoXTbBodegaXCtasCbles> VwinProductoXTbBodegaXCtasCbles { get; set; }

    public virtual DbSet<VwinPrtTransferencia> VwinPrtTransferencia { get; set; }

    public virtual DbSet<VwinSubgrupoXCentroCostoXSubCentroCostoSinCtaCble> VwinSubgrupoXCentroCostoXSubCentroCostoSinCtaCble { get; set; }

    public virtual DbSet<VwinSubgrupoXCentroCostoXSubCentroCostoXCtaCble> VwinSubgrupoXCentroCostoXSubCentroCostoXCtaCble { get; set; }

    public virtual DbSet<VwinSubgrupoXCentroCostoXSubCentroCostoXCtaCbleNoParam> VwinSubgrupoXCentroCostoXSubCentroCostoXCtaCbleNoParam { get; set; }

    public virtual DbSet<VwinTransferenciaDetXInGuiaXTraspasoBodegaDet> VwinTransferenciaDetXInGuiaXTraspasoBodegaDet { get; set; }

    public virtual DbSet<VwinTransferenciaDetalle> VwinTransferenciaDetalle { get; set; }

    public virtual DbSet<VwinTransferenciaSinGuia> VwinTransferenciaSinGuia { get; set; }

    public virtual DbSet<VwinTransferenciaXInMoviInveAgrupadaParaRecosteo> VwinTransferenciaXInMoviInveAgrupadaParaRecosteo { get; set; }

    public virtual DbSet<VwinTransferenciaXIngEgrInven> VwinTransferenciaXIngEgrInven { get; set; }

    public virtual DbSet<VwinTransferencias> VwinTransferencias { get; set; }

    public virtual DbSet<VwinUnidadMedida> VwinUnidadMedida { get; set; }

    public virtual DbSet<VwinUnidadMedidaEquivalencia> VwinUnidadMedidaEquivalencia { get; set; }

    public virtual DbSet<VwinVistaParaContabilizarInventario> VwinVistaParaContabilizarInventario { get; set; }

    public virtual DbSet<VwinZonaVsCtCentroCosto> VwinZonaVsCtCentroCosto { get; set; }

    public virtual DbSet<VwsegMenuXUsuarioXEmpresa1> VwsegMenuXUsuarioXEmpresa1 { get; set; }

    public virtual DbSet<VwsegUsuarioXEmpresa> VwsegUsuarioXEmpresa { get; set; }

    public virtual DbSet<VwsegUsuarioXTbSisReporte> VwsegUsuarioXTbSisReporte { get; set; }

    public virtual DbSet<VwtbBodegaXSucursalTreeList> VwtbBodegaXSucursalTreeList { get; set; }

    public virtual DbSet<VwtbBodegaXTbSucursal> VwtbBodegaXTbSucursal { get; set; }

    public virtual DbSet<VwtbCiudad> VwtbCiudad { get; set; }

    public virtual DbSet<VwtbContacto> VwtbContacto { get; set; }

    public virtual DbSet<VwtbEmpresaXUsuario> VwtbEmpresaXUsuario { get; set; }

    public virtual DbSet<VwtbPersonaBeneficiario> VwtbPersonaBeneficiario { get; set; }

    public virtual DbSet<VwtbPersonaBeneficiarioPorBancoAcreditacion> VwtbPersonaBeneficiarioPorBancoAcreditacion { get; set; }

    public virtual DbSet<VwtbSisDocumentoTipoXDisenioReport> VwtbSisDocumentoTipoXDisenioReport { get; set; }

    public virtual DbSet<VwtbSisDocumentoTipoXEmpresaAnulados> VwtbSisDocumentoTipoXEmpresaAnulados { get; set; }

    public virtual DbSet<VwtbTbBancoProcesosBancarios> VwtbTbBancoProcesosBancarios { get; set; }

    public virtual DbSet<VwtbTbSisDocumentoTipoTalonario> VwtbTbSisDocumentoTipoTalonario { get; set; }

    public virtual DbSet<VwtbTransportistaXTbPersona> VwtbTransportistaXTbPersona { get; set; }

    public virtual DbSet<VwtbUbicacionGeografica> VwtbUbicacionGeografica { get; set; }

    public virtual DbSet<XxxCentroCostoDuplicados> XxxCentroCostoDuplicados { get; set; }

    public virtual DbSet<XxxEstadoCuentaCxp> XxxEstadoCuentaCxp { get; set; }

    public virtual DbSet<XxxTotalCancelado> XxxTotalCancelado { get; set; }

    public virtual DbSet<XxxTotalCanceladoConciliacion> XxxTotalCanceladoConciliacion { get; set; }

    public virtual DbSet<XxxTotalRetencion> XxxTotalRetencion { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=DBERP_PRODUCCION;uid=mysql_sa;pwd=M1n0T4ur0", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AfActivoFijo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdActivoFijo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.EstadoProcesoNavigation).WithMany(p => p.AfActivoFijoEstadoProcesoNavigation).HasConstraintName("FK_Af_Activo_fijo_Af_Catalogo4");

            entity.HasOne(d => d.IdCatalogoColorNavigation).WithMany(p => p.AfActivoFijoIdCatalogoColorNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_Af_Catalogo3");

            entity.HasOne(d => d.IdCatalogoMarcaNavigation).WithMany(p => p.AfActivoFijoIdCatalogoMarcaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_Af_Catalogo1");

            entity.HasOne(d => d.IdCatalogoModeloNavigation).WithMany(p => p.AfActivoFijoIdCatalogoModeloNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_Af_Catalogo2");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.AfActivoFijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_tb_empresa");

            entity.HasOne(d => d.IdPeriodoDeprecNavigation).WithMany(p => p.AfActivoFijo).HasConstraintName("FK_Af_Activo_fijo_Af_PeriodoDepreciacion");

            entity.HasOne(d => d.IdTipoCatalogoUbicacionNavigation).WithMany(p => p.AfActivoFijoIdTipoCatalogoUbicacionNavigation).HasConstraintName("FK_Af_Activo_fijo_Af_Catalogo");

            entity.HasOne(d => d.IdTipoDepreciacionNavigation).WithMany(p => p.AfActivoFijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_Af_Tipo_Depreciacion");

            entity.HasOne(d => d.AfActivoFijoTipo).WithMany(p => p.AfActivoFijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_Af_Activo_fijo_tipo");

            entity.HasOne(d => d.AfActivoFijoCategoria).WithMany(p => p.AfActivoFijo).HasConstraintName("FK_Af_Activo_fijo_Af_Activo_fijo_Categoria");

            entity.HasOne(d => d.AfDepartamento).WithMany(p => p.AfActivoFijo).HasConstraintName("FK_Af_Activo_fijo_Af_Departamento");

            entity.HasOne(d => d.AfEncargado).WithMany(p => p.AfActivoFijo).HasConstraintName("FK_Af_Activo_fijo_Af_Encargado");

            entity.HasOne(d => d.InProducto).WithMany(p => p.AfActivoFijo).HasConstraintName("FK_Af_Activo_fijo_in_Producto");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.AfActivoFijo).HasConstraintName("FK_Af_Activo_fijo_cp_proveedor");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.AfActivoFijo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_tb_sucursal");
        });

        modelBuilder.Entity<AfActivoFijoCategoria>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoriaAf })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.AfActivoFijoTipo).WithMany(p => p.AfActivoFijoCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_Categoria_Af_Activo_fijo_tipo");
        });

        modelBuilder.Entity<AfActivoFijoCtasCbles>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdActivoFijo, e.IdTipoCuenta, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdTipoCuentaNavigation).WithMany(p => p.AfActivoFijoCtasCbles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_CtasCbles_Af_Activo_fijo_CtasCbles_Tipo");

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfActivoFijoCtasCbles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_CtasCbles_Af_Activo_fijo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.AfActivoFijoCtasCbles).HasConstraintName("FK_Af_Activo_fijo_CtasCbles_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.AfActivoFijoCtasCbles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Activo_fijo_CtasCbles_ct_plancta");
        });

        modelBuilder.Entity<AfActivoFijoCtasCblesTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoCuenta).HasName("PRIMARY");
        });

        modelBuilder.Entity<AfActivoFijoTipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdActijoFijoTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.AfActivoFijoTipoCtPlancta).HasConstraintName("FK_Af_Activo_fijo_tipo_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.AfActivoFijoTipoCtPlanctaNavigation).HasConstraintName("FK_Af_Activo_fijo_tipo_ct_plancta1");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.AfActivoFijoTipoCtPlancta1).HasConstraintName("FK_Af_Activo_fijo_tipo_ct_plancta2");
        });

        modelBuilder.Entity<AfActivoFijoXAfActivoFijo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdActivoFijoPadre, e.IdActivoFijoHijo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<AfCambioUbicacionActivo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCambioUbicacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdTipoCatalogoUbicacionActuNavigation).WithMany(p => p.AfCambioUbicacionActivoIdTipoCatalogoUbicacionActuNavigation).HasConstraintName("FK_Af_CambioUbicacion_Activo_Af_Catalogo");

            entity.HasOne(d => d.IdTipoCatalogoUbicacionAntNavigation).WithMany(p => p.AfCambioUbicacionActivoIdTipoCatalogoUbicacionAntNavigation).HasConstraintName("FK_Af_CambioUbicacion_Activo_Af_Catalogo1");

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfCambioUbicacionActivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_CambioUbicacion_Activo_Af_Activo_fijo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.AfCambioUbicacionActivoCtCentroCosto).HasConstraintName("FK_Af_CambioUbicacion_Activo_ct_centro_costo");

            entity.HasOne(d => d.CtCentroCostoNavigation).WithMany(p => p.AfCambioUbicacionActivoCtCentroCostoNavigation).HasConstraintName("FK_Af_CambioUbicacion_Activo_ct_centro_costo1");

            entity.HasOne(d => d.AfDepartamento).WithMany(p => p.AfCambioUbicacionActivoAfDepartamento).HasConstraintName("FK_Af_CambioUbicacion_Activo_Af_Departamento");

            entity.HasOne(d => d.AfDepartamentoNavigation).WithMany(p => p.AfCambioUbicacionActivoAfDepartamentoNavigation).HasConstraintName("FK_Af_CambioUbicacion_Activo_Af_Departamento1");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.AfCambioUbicacionActivoTbSucursal).HasConstraintName("FK_Af_CambioUbicacion_Activo_tb_sucursal");

            entity.HasOne(d => d.TbSucursalNavigation).WithMany(p => p.AfCambioUbicacionActivoTbSucursalNavigation).HasConstraintName("FK_Af_CambioUbicacion_Activo_tb_sucursal1");
        });

        modelBuilder.Entity<AfCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogo).HasName("PRIMARY");

            entity.HasOne(d => d.IdTipoCatalogoNavigation).WithMany(p => p.AfCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Catalogo_Af_CatalogoTipo");
        });

        modelBuilder.Entity<AfCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoCatalogo).HasName("PRIMARY");
        });

        modelBuilder.Entity<AfDepartamento>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDepartamento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<AfDepreciacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDepreciacion, e.IdTipoDepreciacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CodDepreciacion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdTipoDepreciacionNavigation).WithMany(p => p.AfDepreciacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Depreciacion_Af_Tipo_Depreciacion");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.AfDepreciacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Depreciacion_ct_periodo");

            entity.HasMany(d => d.CtCbtecble).WithMany(p => p.AfDepreciacion)
                .UsingEntity<Dictionary<string, object>>(
                    "AfDepreciacionXCtaCbtecble",
                    r => r.HasOne<CtCbtecble>().WithMany()
                        .HasForeignKey("CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Af_Depreciacion_x_cta_cbtecble_ct_cbtecble"),
                    l => l.HasOne<AfDepreciacion>().WithMany()
                        .HasForeignKey("IdEmpresa", "IdDepreciacion", "IdTipoDepreciacion")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Af_Depreciacion_x_cta_cbtecble_Af_Depreciacion"),
                    j =>
                    {
                        j.HasKey("IdEmpresa", "IdDepreciacion", "IdTipoDepreciacion", "CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });
                        j
                            .ToTable("Af_Depreciacion_x_cta_cbtecble")
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble" }, "FK_Af_Depreciacion_x_cta_cbtecble_ct_cbtecble");
                        j.IndexerProperty<decimal>("IdDepreciacion").HasPrecision(18);
                        j.IndexerProperty<int>("CtIdEmpresa").HasColumnName("ct_IdEmpresa");
                        j.IndexerProperty<int>("CtIdTipoCbte").HasColumnName("ct_IdTipoCbte");
                        j.IndexerProperty<decimal>("CtIdCbteCble")
                            .HasPrecision(18)
                            .HasColumnName("ct_IdCbteCble");
                    });
        });

        modelBuilder.Entity<AfDepreciacionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDepreciacion, e.IdTipoDepreciacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfDepreciacionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Depreciacion_Det_Af_Activo_fijo");

            entity.HasOne(d => d.AfDepreciacion).WithMany(p => p.AfDepreciacionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Depreciacion_Det_Af_Depreciacion");
        });

        modelBuilder.Entity<AfDepreciacionDetHisAnulacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdHisDepreciacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfDepreciacionDetHisAnulacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Depreciacion_Det_His_Anulacion_Af_Activo_fijo");

            entity.HasOne(d => d.AfDepreciacionHisAnulacion).WithMany(p => p.AfDepreciacionDetHisAnulacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_His_Depre_Det_Af_His_Depre");
        });

        modelBuilder.Entity<AfDepreciacionHisAnulacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdHisDepreciacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.CodDepreciacion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.AfDepreciacion).WithMany(p => p.AfDepreciacionHisAnulacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Depreciacion_His_Anulacion_Af_Depreciacion");
        });

        modelBuilder.Entity<AfEncargado>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdEncargado })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<AfMejBajActivo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMejoraBajaActivo, e.IdTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CodMejBajActivo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfMejBajActivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Mej_Baj_Activo_Af_Activo_fijo");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.AfMejBajActivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Mej_Baj_Activo_cp_proveedor");
        });

        modelBuilder.Entity<AfParametros>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.AfParametros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_tb_empresa");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.AfParametrosCtPlancta).HasConstraintName("FK_Af_Parametros_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.AfParametrosCtPlanctaNavigation).HasConstraintName("FK_Af_Parametros_ct_plancta1");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.AfParametrosCtPlancta1).HasConstraintName("FK_Af_Parametros_ct_plancta2");

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.AfParametrosCtCbtecbleTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo");

            entity.HasOne(d => d.CtCbtecbleTipoNavigation).WithMany(p => p.AfParametrosCtCbtecbleTipoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo2");

            entity.HasOne(d => d.CtCbtecbleTipo1).WithMany(p => p.AfParametrosCtCbtecbleTipo1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo6");

            entity.HasOne(d => d.CtCbtecbleTipo2).WithMany(p => p.AfParametrosCtCbtecbleTipo2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo9");

            entity.HasOne(d => d.CtCbtecbleTipo3).WithMany(p => p.AfParametrosCtCbtecbleTipo3)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo1");

            entity.HasOne(d => d.CtCbtecbleTipo4).WithMany(p => p.AfParametrosCtCbtecbleTipo4)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo5");

            entity.HasOne(d => d.CtCbtecbleTipo5).WithMany(p => p.AfParametrosCtCbtecbleTipo5)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo4");

            entity.HasOne(d => d.CtCbtecbleTipo6).WithMany(p => p.AfParametrosCtCbtecbleTipo6)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo8");

            entity.HasOne(d => d.CtCbtecbleTipo7).WithMany(p => p.AfParametrosCtCbtecbleTipo7)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo3");

            entity.HasOne(d => d.CtCbtecbleTipo8).WithMany(p => p.AfParametrosCtCbtecbleTipo8)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Parametros_ct_cbtecble_tipo7");
        });

        modelBuilder.Entity<AfPeriodoDepreciacion>(entity =>
        {
            entity.HasKey(e => e.IdPeriodoDeprec).HasName("PRIMARY");
        });

        modelBuilder.Entity<AfProcesoDepreciacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdActivoFijo, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfProcesoDepreciacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_proceso_depreciacion_Af_Activo_fijo");
        });

        modelBuilder.Entity<AfRetiroActivo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdRetiroActivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.CodRetActivo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfRetiroActivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Retiro_Activo_Af_Activo_fijo");
        });

        modelBuilder.Entity<AfSpActfRpt012>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdActivoFijo, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<AfSpActfRpt014>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdActivoFijoTipo, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<AfTipoDepreciacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoDepreciacion).HasName("PRIMARY");

            entity.Property(e => e.IdTipoDepreciacion).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<AfTipoTransacXCtaCbteCble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipTransActivoFijo, e.IdCatalogo, e.CtIdEmpresa, e.CtIdTipoCbte, e.CtIdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.AfTipoTransacXCtaCbteCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_TipoTransac_x_Cta_CbteCble_Af_Catalogo");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.AfTipoTransacXCtaCbteCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_TipoTransac_x_Cta_CbteCble_ct_cbtecble");
        });

        modelBuilder.Entity<AfVentaActivo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdVtaActivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.CodVtaActivo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.AfActivoFijo).WithMany(p => p.AfVentaActivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Af_Venta_Activo_Af_Activo_fijo");
        });

        modelBuilder.Entity<BaArchivoTransferencia>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdArchivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdEstadoArchivoCatNavigation).WithMany(p => p.BaArchivoTransferenciaIdEstadoArchivoCatNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_ba_Catalogo");

            entity.HasOne(d => d.IdMotivoArchivoCatNavigation).WithMany(p => p.BaArchivoTransferenciaIdMotivoArchivoCatNavigation).HasConstraintName("FK_ba_Archivo_Transferencia_ba_Catalogo1");

            entity.HasOne(d => d.IdProcesoBancarioNavigation).WithMany(p => p.BaArchivoTransferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_tb_banco_procesos_bancarios_tipo");

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.BaArchivoTransferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_ba_Banco_Cuenta");
        });

        modelBuilder.Entity<BaArchivoTransferenciaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdArchivo, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdEstadoRegistroCatNavigation).WithMany(p => p.BaArchivoTransferenciaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_Det_ba_Catalogo1");

            entity.HasOne(d => d.BaArchivoTransferencia).WithMany(p => p.BaArchivoTransferenciaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_Det_ba_Archivo_Transferencia1");

            entity.HasOne(d => d.CpOrdenPagoDet).WithMany(p => p.BaArchivoTransferenciaDet).HasConstraintName("FK_ba_Archivo_Transferencia_Det_cp_orden_pago_det");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.BaArchivoTransferenciaDet).HasConstraintName("FK_ba_Archivo_Transferencia_Det_ct_cbtecble");
        });

        modelBuilder.Entity<BaArchivoTransferenciaParametros>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdBanco })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<BaArchivoTransferenciaXPreAvisoCheq>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdArchivoPreavisoCheq })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.BaArchivoTransferenciaXPreAvisoCheq)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_x_PreAviso_Cheq_ba_Banco_Cuenta");
        });

        modelBuilder.Entity<BaArchivoTransferenciaXPreAvisoCheqDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdArchivoPreavisoCheq, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.BaArchivoTransferenciaXPreAvisoCheq).WithMany(p => p.BaArchivoTransferenciaXPreAvisoCheqDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_x_PreAviso_Cheq_det_ba_Archivo_Tra4");

            entity.HasOne(d => d.BaCbteBan).WithMany(p => p.BaArchivoTransferenciaXPreAvisoCheqDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Archivo_Transferencia_x_PreAviso_Cheq_det_ba_Cbte_Ban");
        });

        modelBuilder.Entity<BaBanRpt007>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdBanco, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<BaBanRpt009>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<BaBanRpt011>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacion, e.IdTipoCbte, e.IdCbteCble, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<BaBancoCuenta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdBanco })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdBancoFinancieroNavigation).WithMany(p => p.BaBancoCuenta).HasConstraintName("FK_ba_Banco_Cuenta_tb_banco");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.BaBancoCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Banco_Cuenta_tb_empresa");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.BaBancoCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Banco_Cuenta_ct_plancta");
        });

        modelBuilder.Entity<BaCajaMovimientoXCbteBanXDeposito>(entity =>
        {
            entity.HasKey(e => new { e.McjIdEmpresa, e.McjIdCbteCble, e.McjIdTipocbte, e.MbaIdEmpresa, e.MbaIdCbteCble, e.MbaIdTipocbte, e.McjSecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.BaCbteBan).WithMany(p => p.BaCajaMovimientoXCbteBanXDeposito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_ba_Cbte_Ban1");

            entity.HasOne(d => d.CajCajaMovimiento).WithMany(p => p.BaCajaMovimientoXCbteBanXDeposito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_caj_Caja_Movimiento");
        });

        modelBuilder.Entity<BaCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogo).HasName("PRIMARY");

            entity.HasOne(d => d.IdTipoCatalogoNavigation).WithMany(p => p.BaCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Catalogo_ba_CatalogoTipo");
        });

        modelBuilder.Entity<BaCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoCatalogo).HasName("PRIMARY");
        });

        modelBuilder.Entity<BaCbteBan>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCble, e.IdTipocbte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CbChequeImpreso).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.PorAnticipo).IsFixedLength();
            entity.Property(e => e.PosFechado).IsFixedLength();

            entity.HasOne(d => d.CbCiudadChqNavigation).WithMany(p => p.BaCbteBan).HasConstraintName("FK_ba_Cbte_Ban_tb_ciudad");

            entity.HasOne(d => d.IdEstadoCbteBanCatNavigation).WithMany(p => p.BaCbteBanIdEstadoCbteBanCatNavigation).HasConstraintName("FK_ba_Cbte_Ban_ba_Catalogo");

            entity.HasOne(d => d.IdEstadoChequeCatNavigation).WithMany(p => p.BaCbteBanIdEstadoChequeCatNavigation).HasConstraintName("FK_ba_Cbte_Ban_ba_Catalogo1");

            entity.HasOne(d => d.IdPersonaGiradoANavigation).WithMany(p => p.BaCbteBan).HasConstraintName("FK_ba_Cbte_Ban_tb_persona");

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.BaCbteBan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Cbte_Ban_ba_Banco_Cuenta");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.BaCbteBan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Cbte_Ban_ct_periodo");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.BaCbteBan).HasConstraintName("FK_ba_Cbte_Ban_tb_sucursal");

            entity.HasOne(d => d.BaTipoFlujo).WithMany(p => p.BaCbteBan).HasConstraintName("FK_ba_Cbte_Ban_ba_TipoFlujo");

            entity.HasOne(d => d.BaTipoNota).WithMany(p => p.BaCbteBan).HasConstraintName("FK_ba_Cbte_Ban_ba_tipo_nota");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.BaCbteBanCtCbtecble).HasConstraintName("FK_ba_Cbte_Ban_ct_cbtecble1");

            entity.HasOne(d => d.CtCbtecbleNavigation).WithMany(p => p.BaCbteBanCtCbtecbleNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Cbte_Ban_ct_cbtecble");
        });

        modelBuilder.Entity<BaCbteBanDatosEntregaCheq>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCble, e.IdTipocbte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<BaCbteBanDatosTransferencia>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCble, e.IdTipocbte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdProcesoBancarioNavigation).WithMany(p => p.BaCbteBanDatosTransferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Cbte_Ban_Datos_Transferencia_tb_banco_procesos_bancarios6");

            entity.HasOne(d => d.BaCbteBan).WithOne(p => p.BaCbteBanDatosTransferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Cbte_Ban_Datos_Transferencia_ba_Cbte_Ban");
        });

        modelBuilder.Entity<BaCbteBanEdehsa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCble, e.IdTipocbte, e.IdOrdenPago })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<BaCbteBanTipo>(entity =>
        {
            entity.HasKey(e => e.CodTipoCbteBan).HasName("PRIMARY");

            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<BaCbteBanTipoXCodBancoExterno>(entity =>
        {
            entity.HasKey(e => new { e.CodTipoCbteBan, e.CodBanco })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CodTipoCbteBanNavigation).WithMany(p => p.BaCbteBanTipoXCodBancoExterno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Cbte_Ban_tipo_x_CodBancoExterno_ba_Cbte_Ban_tipo");
        });

        modelBuilder.Entity<BaCbteBanTipoXCtCbteCbleTipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.CodTipoCbteBan })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.TipoDebCred).IsFixedLength();

            entity.HasOne(d => d.CodTipoCbteBanNavigation).WithMany(p => p.BaCbteBanTipoXCtCbteCbleTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_ba_Cbte_Ban_tipo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.BaCbteBanTipoXCtCbteCbleTipo).HasConstraintName("FK_ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_ct_plancta");
        });

        modelBuilder.Entity<BaCbteBanVerificado>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPeriodo, e.Secuencia, e.TipoIngEgr, e.IdCbteCble, e.IdTipocbte, e.SecuenciaCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.Property(e => e.TipoIngEgr).IsFixedLength();
        });

        modelBuilder.Entity<BaConciliacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEstadoConcilCatNavigation).WithMany(p => p.BaConciliacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Conciliacion_ba_Catalogo");

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.BaConciliacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Conciliacion_ba_Banco_Cuenta");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.BaConciliacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Conciliacion_ct_periodo");
        });

        modelBuilder.Entity<BaConciliacionDetIngEgr>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.TipoIngEgr).IsFixedLength();

            entity.HasOne(d => d.BaConciliacion).WithMany(p => p.BaConciliacionDetIngEgr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Conciliacion_det_IngEgr_ba_Conciliacion");
        });

        modelBuilder.Entity<BaConfigDisenoCheque>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdBanco })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.BaBancoCuenta).WithOne(p => p.BaConfigDisenoCheque)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Config_Diseno_Cheque_ba_Banco_Cuenta");
        });

        modelBuilder.Entity<BaInversion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdInversion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.BaInversion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Inversion_ba_Banco_Cuenta");
        });

        modelBuilder.Entity<BaNotasDebCreMasivo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTransaccion, e.IdEmpresaCb, e.IdCbteCbleCb, e.IdTipocbteCb })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.DebCred).IsFixedLength();
        });

        modelBuilder.Entity<BaParametros>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.CiudadDefaultParaCrearChequesNavigation).WithMany(p => p.BaParametros).HasConstraintName("FK_ba_parametros_tb_ciudad");

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.BaParametros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_parametros_tb_empresa");
        });

        modelBuilder.Entity<BaPrestamo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPrestamo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdMetCalcNavigation).WithMany(p => p.BaPrestamoIdMetCalcNavigation).HasConstraintName("FK_ba_prestamo_ba_Catalogo");

            entity.HasOne(d => d.IdMotivoPrestamoNavigation).WithMany(p => p.BaPrestamoIdMotivoPrestamoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_prestamo_ba_Catalogo1");

            entity.HasOne(d => d.IdTipoPagoNavigation).WithMany(p => p.BaPrestamoIdTipoPagoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_prestamo_ba_Catalogo2");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.BaPrestamo).HasConstraintName("FK_ba_prestamo_ct_plancta");

            entity.HasOne(d => d.BaTipoFlujo).WithMany(p => p.BaPrestamo).HasConstraintName("FK_ba_prestamo_ba_TipoFlujo");
        });

        modelBuilder.Entity<BaPrestamoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPrestamo, e.NumCuota })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.EstadoPagoNavigation).WithMany(p => p.BaPrestamoDetalle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_prestamo_detalle_ba_Catalogo1");

            entity.HasOne(d => d.BaPrestamo).WithMany(p => p.BaPrestamoDetalle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_prestamo_detalle_ba_prestamo");
        });

        modelBuilder.Entity<BaPrestamoDetalleCancelacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPrestamo, e.NumCuota, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.BaPrestamoDetalle).WithMany(p => p.BaPrestamoDetalleCancelacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_prestamo_detalle_cancelacion_ba_prestamo_detalle");
        });

        modelBuilder.Entity<BaPrestamoDetalleXAfActivoFijoPrendados>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPrestamo, e.IdActivoFijo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<BaTalonarioChequesXBanco>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdBanco, e.NumCheque })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.BaTalonarioChequesXBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_Talonario_cheques_x_banco_ba_Banco_Cuenta");
        });

        modelBuilder.Entity<BaTipoFlujo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoFlujo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.BaTipoFlujo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_TipoFlujo_tb_empresa");

            entity.HasOne(d => d.BaTipoFlujoNavigation).WithMany(p => p.InverseBaTipoFlujoNavigation).HasConstraintName("FK_ba_TipoFlujo_ba_TipoFlujo");
        });

        modelBuilder.Entity<BaTipoNota>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoNota })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.BaTipoNota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_tipo_nota_tb_empresa");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.BaTipoNota).HasConstraintName("FK_ba_tipo_nota_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.BaTipoNota).HasConstraintName("FK_ba_tipo_nota_ct_plancta");
        });

        modelBuilder.Entity<BaTransferencia>(entity =>
        {
            entity.HasKey(e => new { e.IdTransferencia, e.IdEmpresaOrigen })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.IdUsuarioAnu).IsFixedLength();

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.BaTransferenciaBaBancoCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_transferencia_ba_Banco_Cuenta1");

            entity.HasOne(d => d.BaBancoCuentaNavigation).WithMany(p => p.BaTransferenciaBaBancoCuentaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_transferencia_ba_Banco_Cuenta");

            entity.HasOne(d => d.BaCbteBan).WithMany(p => p.BaTransferenciaBaCbteBan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_transferencia_ba_Cbte_Ban1");

            entity.HasOne(d => d.BaCbteBanNavigation).WithMany(p => p.BaTransferenciaBaCbteBanNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ba_transferencia_ba_Cbte_Ban");
        });

        modelBuilder.Entity<CajCaja>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCaja })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CajCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_Caja_tb_empresa");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CajCaja).HasConstraintName("FK_caj_Caja_ct_plancta");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CajCaja).HasConstraintName("FK_caj_Caja_tb_sucursal");
        });

        modelBuilder.Entity<CajCajaMovimiento>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCble, e.IdTipocbte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CmSigno).IsFixedLength();

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.CajCajaMovimiento).HasConstraintName("FK_caj_Caja_Movimiento_tb_persona");

            entity.HasOne(d => d.IdTipoMoviNavigation).WithMany(p => p.CajCajaMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_Caja_Movimiento_caj_Caja_Movimiento_Tipo");

            entity.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.CajCajaMovimiento).HasConstraintName("FK_caj_Caja_Movimiento_tb_persona_tipo");

            entity.HasOne(d => d.CajCaja).WithMany(p => p.CajCajaMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_Caja_Movimiento_caj_Caja");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.CajCajaMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_Caja_Movimiento_ct_periodo");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CajCajaMovimiento).HasConstraintName("FK_caj_Caja_Movimiento_tb_sucursal");

            entity.HasOne(d => d.BaTipoFlujo).WithMany(p => p.CajCajaMovimiento).HasConstraintName("FK_caj_Caja_Movimiento_ba_TipoFlujo");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CajCajaMovimientoCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_Caja_Movimiento_ct_cbtecble");

            entity.HasOne(d => d.CtCbtecbleNavigation).WithMany(p => p.CajCajaMovimientoCtCbtecbleNavigation).HasConstraintName("FK_caj_Caja_Movimiento_ct_cbtecble1");
        });

        modelBuilder.Entity<CajCajaMovimientoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCble, e.IdTipocbte, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdCobroTipoNavigation).WithMany(p => p.CajCajaMovimientoDet).HasConstraintName("FK_caj_Caja_Movimiento_det_cxc_cobro_tipo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CajCajaMovimientoDet).HasConstraintName("FK_caj_Caja_Movimiento_det_ct_centro_costo");

            entity.HasOne(d => d.BaTipoFlujo).WithMany(p => p.CajCajaMovimientoDet).HasConstraintName("FK_caj_Caja_Movimiento_det_ba_TipoFlujo");

            entity.HasOne(d => d.CpOrdenPago).WithMany(p => p.CajCajaMovimientoDet).HasConstraintName("FK_caj_Caja_Movimiento_det_cp_orden_pago");

            entity.HasOne(d => d.CajCajaMovimiento).WithMany(p => p.CajCajaMovimientoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_Caja_Movimiento_det_caj_Caja_Movimiento");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.CajCajaMovimientoDet).HasConstraintName("FK_caj_Caja_Movimiento_det_ct_centro_costo_sub_centro_costo");
        });

        modelBuilder.Entity<CajCajaMovimientoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoMovi).HasName("PRIMARY");

            entity.Property(e => e.IdTipoMovi).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.TmSigno).IsFixedLength();
        });

        modelBuilder.Entity<CajCajaMovimientoTipoXCtaCble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoMovi })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdTipoMoviNavigation).WithMany(p => p.CajCajaMovimientoTipoXCtaCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_Caja_Movimiento_Tipo_x_CtaCble_caj_Caja_Movimiento_Tipo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CajCajaMovimientoTipoXCtaCble).HasConstraintName("FK_caj_Caja_Movimiento_Tipo_x_CtaCble_ct_plancta");
        });

        modelBuilder.Entity<CajCajachica>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCaja })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CajCustodio).WithMany(p => p.CajCajachica).HasConstraintName("caj_cajachica_caj_custodio_FK");
        });

        modelBuilder.Entity<CajCajachicaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCaja, e.IdSecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Check).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.CajRubro).WithMany(p => p.CajCajachicaDet).HasConstraintName("caj_cajachica_det_caj_rubro_FK");
        });

        modelBuilder.Entity<CajCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoCj).HasName("PRIMARY");
        });

        modelBuilder.Entity<CajCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoCjTipo).HasName("PRIMARY");
        });

        modelBuilder.Entity<CajCustodio>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCustodio })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CajCustodioXCajRubro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCustodio, e.IdRubro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CajCustodio).WithMany(p => p.CajCustodioXCajRubro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("caj_custodio_x_caj_rubro_FK");

            entity.HasOne(d => d.CajRubro).WithMany(p => p.CajCustodioXCajRubro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("caj_custodio_x_caj_rubro_FK_1");
        });

        modelBuilder.Entity<CajParametro>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.CajParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_parametro_tb_empresa");

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.CajParametroCtCbtecbleTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_parametro_ct_cbtecble_tipo1");

            entity.HasOne(d => d.CtCbtecbleTipoNavigation).WithMany(p => p.CajParametroCtCbtecbleTipoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_parametro_ct_cbtecble_tipo3");

            entity.HasOne(d => d.CtCbtecbleTipo1).WithMany(p => p.CajParametroCtCbtecbleTipo1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_parametro_ct_cbtecble_tipo");

            entity.HasOne(d => d.CtCbtecbleTipo2).WithMany(p => p.CajParametroCtCbtecbleTipo2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_caj_parametro_ct_cbtecble_tipo2");
        });

        modelBuilder.Entity<CajRubro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdRubro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CajTalonarioRecibo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdRecibo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<ComCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogocompra).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdCatalogocompraTipoNavigation).WithMany(p => p.ComCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_catalogo_com_catalogo_tipo");
        });

        modelBuilder.Entity<ComCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogocompraTipo).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComComprador>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdComprador })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ComComprador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_comprador_tb_empresa");
        });

        modelBuilder.Entity<ComCotizacionCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCotizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.ComCotizacionCompra).HasConstraintName("FK_com_cotizacion_compra_cp_proveedor");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.ComCotizacionCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_cotizacion_compra_tb_sucursal");
        });

        modelBuilder.Entity<ComCotizacionCompraDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCotizacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.ComCotizacionCompra).WithMany(p => p.ComCotizacionCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_cotizacion_compra_det_com_cotizacion_compra");

            entity.HasOne(d => d.InProducto).WithMany(p => p.ComCotizacionCompraDet).HasConstraintName("FK_com_cotizacion_compra_det_in_Producto");

            entity.HasOne(d => d.ComListadoMaterialesDet).WithMany(p => p.ComCotizacionCompraDet).HasConstraintName("FK_com_cotizacion_compra_det_com_ListadoMateriales_Det");
        });

        modelBuilder.Entity<ComCotizacionCompraEdehsa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCotizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();
        });

        modelBuilder.Entity<ComCotizacionCompraGe>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCotizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();
        });

        modelBuilder.Entity<ComCotizacionCompraGeDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCotizacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<ComDepartamento>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDepartamento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComDevCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdDevCompra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.AfectaCosto).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.ComDevCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_dev_compra_cp_proveedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.ComDevCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_dev_compra_tb_bodega");
        });

        modelBuilder.Entity<ComDevCompraDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdDevCompra, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.DvCosteado).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.ComDevCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_dev_compra_det_in_Producto");

            entity.HasOne(d => d.ComDevCompra).WithMany(p => p.ComDevCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_dev_compra_det_com_dev_compra");

            entity.HasOne(d => d.ComOrdencompraLocalDet).WithMany(p => p.ComDevCompraDet).HasConstraintName("FK_com_dev_compra_det_com_ordencompra_local_det");
        });

        modelBuilder.Entity<ComEstadoCierre>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCierre).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComListadoDiseno>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdListadoDiseno })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.TipoListado).IsFixedLength();
        });

        modelBuilder.Entity<ComListadoDisenoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdListadoDiseno, e.IdDetalle })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<ComListadoDisenoTipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoListadoDiseno })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComListadoElementosXOt>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdListadoElementosXOt })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComListadoElementosXOtDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdListadoElementosXOt, e.IdDetalle })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<ComListadoMaterialesDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdListadoMateriales, e.IdDetalle })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InProducto).WithMany(p => p.ComListadoMaterialesDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ListadoMateriales_Det_in_Producto");
        });

        modelBuilder.Entity<ComListadoMaterialesDisponiblesPreAsignadoAObra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdListadoMppreasingado, e.IdNumMovi, e.CodObraPreasignada })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComListadoMaterialesDisponiblesPreAsignadoAObraDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdListadoMppreasingado, e.IdNumMovi, e.CodObraPreasignada, e.CodigoBarra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<ComMotivoOrdenCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMotivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComOrdencompraGeLocal>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<ComOrdencompraLocal>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.AfectaCosto).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();

            entity.HasOne(d => d.IdEstadoAprobacionCatNavigation).WithMany(p => p.ComOrdencompraLocalIdEstadoAprobacionCatNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_com_catalogo");

            entity.HasOne(d => d.IdEstadoCierreNavigation).WithMany(p => p.ComOrdencompraLocal).HasConstraintName("FK_com_ordencompra_local_com_estado_cierre");

            entity.HasOne(d => d.IdEstadoRecepcionCatNavigation).WithMany(p => p.ComOrdencompraLocalIdEstadoRecepcionCatNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_com_catalogo1");

            entity.HasOne(d => d.IdTerminoPagoNavigation).WithMany(p => p.ComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_com_TerminoPago");

            entity.HasOne(d => d.ComComprador).WithMany(p => p.ComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_com_comprador");

            entity.HasOne(d => d.ComDepartamento).WithMany(p => p.ComOrdencompraLocal).HasConstraintName("FK_com_ordencompra_local_com_departamento");

            entity.HasOne(d => d.ComMotivoOrdenCompra).WithMany(p => p.ComOrdencompraLocal).HasConstraintName("FK_com_ordencompra_local_com_Motivo_Orden_Compra");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.ComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_cp_proveedor");

            entity.HasOne(d => d.ComSolicitante).WithMany(p => p.ComOrdencompraLocal).HasConstraintName("FK_com_ordencompra_local_com_solicitante");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.ComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_tb_sucursal");
        });

        modelBuilder.Entity<ComOrdencompraLocalDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.DoCosteado).IsFixedLength();

            entity.HasOne(d => d.IdCodImpuestoNavigation).WithMany(p => p.ComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_det_tb_sis_Impuesto");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.ComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_det_in_UnidadMedida");

            entity.HasOne(d => d.InProducto).WithMany(p => p.ComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_det_in_Producto");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.ComOrdencompraLocalDet).HasConstraintName("FK_com_ordencompra_local_det_ct_punto_cargo");

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.ComOrdencompraLocalDet).HasConstraintName("FK_com_ordencompra_local_det_ct_punto_cargo_grupo");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.ComOrdencompraLocalDet).HasConstraintName("FK_com_ordencompra_local_det_ct_centro_costo_sub_centro_costo");

            entity.HasOne(d => d.ComOrdencompraLocal).WithMany(p => p.ComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_det_com_ordencompra_local");
        });

        modelBuilder.Entity<ComOrdencompraLocalDetXComSolicitudCompraDet>(entity =>
        {
            entity.HasKey(e => new { e.OcdIdEmpresa, e.OcdIdSucursal, e.OcdIdOrdenCompra, e.OcdSecuencia, e.ScdIdEmpresa, e.ScdIdSucursal, e.ScdIdSolicitudCompra, e.ScdSecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.ComOrdencompraLocalDet).WithMany(p => p.ComOrdencompraLocalDetXComSolicitudCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_det_x_com_solicitud_compra_det_com_or20");
        });

        modelBuilder.Entity<ComOrdencompraLocalXComSolicitudCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaOc, e.IdSucursalOc, e.IdOrdenCompraOc, e.IdEmpresaSc, e.IdSucursalSc, e.IdSolicitudCompraSc, e.SecuenciaSc })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.ComOrdencompraLocal).WithMany(p => p.ComOrdencompraLocalXComSolicitudCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_ordencompra_local_x_com_solicitud_compra_com_ordencompr16");
        });

        modelBuilder.Entity<ComOrdencompralocal1>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<ComParametro>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.ComParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_tb_empresa");

            entity.HasOne(d => d.IdEstadoAnulacionOcNavigation).WithMany(p => p.ComParametroIdEstadoAnulacionOcNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_com_catalogo1");

            entity.HasOne(d => d.IdEstadoAprobacionOcNavigation).WithMany(p => p.ComParametroIdEstadoAprobacionOcNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_com_catalogo");

            entity.HasOne(d => d.IdEstadoAprobacionSolCompraNavigation).WithMany(p => p.ComParametroIdEstadoAprobacionSolCompraNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_com_catalogo2");

            entity.HasOne(d => d.IdEstadoCierreNavigation).WithMany(p => p.ComParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_com_estado_cierre");

            entity.HasOne(d => d.InMoviInvenTipo).WithMany(p => p.ComParametroInMoviInvenTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_in_movi_inven_tipo1");

            entity.HasOne(d => d.InMoviInvenTipoNavigation).WithMany(p => p.ComParametroInMoviInvenTipoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_in_movi_inven_tipo");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.ComParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_parametro_tb_sucursal");
        });

        modelBuilder.Entity<ComRegistroOrdenCompraGXCotizacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra, e.IdCotizacion, e.SecuenciaDetalleCotizacion, e.IdListadoMateriales })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<ComRegistroOrdenCompraGeXCotizacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra, e.IdCotizacion, e.SecuenciaDetalleCotizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<ComRegistroOrdenCompraXCotizacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra, e.IdCotizacion, e.SecuenciaDetalleCotizacion, e.IdListadoMateriales })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<ComRegistroOrdenCompraXSolicitud>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra, e.IdSolicitud, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<ComRegistroOrdenCompraxCotizacion1>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdOrdenCompra, e.IdCotizacion, e.SecuenciaDetalleCotizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<ComSolicitante>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSolicitante })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ComSolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_solicitante_tb_empresa");
        });

        modelBuilder.Entity<ComSolicitudCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdSolicitudCompra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();

            entity.HasOne(d => d.IdEstadoAprobacionNavigation).WithMany(p => p.ComSolicitudCompra).HasConstraintName("FK_com_solicitud_compra_com_catalogo");
        });

        modelBuilder.Entity<ComSolicitudCompraDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdSolicitudCompra, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.ComSolicitudCompraDet).HasConstraintName("FK_com_solicitud_compra_det_in_UnidadMedida");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.ComSolicitudCompraDet).HasConstraintName("FK_com_solicitud_compra_det_ct_centro_costo");

            entity.HasOne(d => d.InProducto).WithMany(p => p.ComSolicitudCompraDet).HasConstraintName("FK_com_solicitud_compra_det_in_Producto");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.ComSolicitudCompraDet).HasConstraintName("FK_com_solicitud_compra_det_ct_punto_cargo1");

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.ComSolicitudCompraDet).HasConstraintName("FK_com_solicitud_compra_det_ct_punto_cargo_grupo");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.ComSolicitudCompraDet).HasConstraintName("FK_com_solicitud_compra_det_ct_centro_costo_sub_centro_costo");

            entity.HasOne(d => d.ComSolicitudCompra).WithMany(p => p.ComSolicitudCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_solicitud_compra_det_com_solicitud_compra");
        });

        modelBuilder.Entity<ComSolicitudCompraDetAprobacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursalSc, e.IdSolicitudCompra, e.SecuenciaSc })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdCodImpuestoIvaNavigation).WithMany(p => p.ComSolicitudCompraDetAprobacion).HasConstraintName("FK_com_solicitud_compra_det_aprobacion_tb_sis_Impuesto");

            entity.HasOne(d => d.IdEstadoAprobacionNavigation).WithMany(p => p.ComSolicitudCompraDetAprobacionIdEstadoAprobacionNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_solicitud_compra_det_aprobacion_com_catalogo");

            entity.HasOne(d => d.IdEstadoPreAprobacionNavigation).WithMany(p => p.ComSolicitudCompraDetAprobacionIdEstadoPreAprobacionNavigation).HasConstraintName("FK_com_solicitud_compra_det_aprobacion_com_catalogo1");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.ComSolicitudCompraDetAprobacion).HasConstraintName("FK_com_solicitud_compra_det_aprobacion_in_UnidadMedida");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.ComSolicitudCompraDetAprobacion).HasConstraintName("FK_com_solicitud_compra_det_aprobacion_ct_centro_costo");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.ComSolicitudCompraDetAprobacion).HasConstraintName("FK_com_solicitud_compra_det_aprobacion_ct_punto_cargo1");

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.ComSolicitudCompraDetAprobacion).HasConstraintName("FK_com_solicitud_compra_det_aprobacion_ct_punto_cargo_grupo");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.ComSolicitudCompraDetAprobacion).HasConstraintName("FK_com_solicitud_compra_det_aprobacion_ct_centro_costo_sub_cen26");
        });

        modelBuilder.Entity<ComSolicitudCompraDetPreAprobacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursalSc, e.IdSolicitudCompra, e.SecuenciaSc })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdEstadoAprobacionNavigation).WithMany(p => p.ComSolicitudCompraDetPreAprobacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_com_solicitud_compra_det_pre_aprobacion_com_catalogo");
        });

        modelBuilder.Entity<ComTarjetaOrdenCompra>(entity =>
        {
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<ComTerminoPago>(entity =>
        {
            entity.HasKey(e => e.IdTerminoPago).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CpAprobacionIngBodXOc>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.CpAprobacionIngBodXOc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_cp_proveedor");

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpAprobacionIngBodXOc).HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_cp_orden_giro");
        });

        modelBuilder.Entity<CpAprobacionIngBodXOcDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CpAprobacionIngBodXOc).WithMany(p => p.CpAprobacionIngBodXOcDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_det_cp_Aprobacion_Ing_Bod_x_OC");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CpAprobacionIngBodXOcDet).HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_det_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpAprobacionIngBodXOcDetCtPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_det_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.CpAprobacionIngBodXOcDetCtPlanctaNavigation).HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_det_ct_plancta1");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.CpAprobacionIngBodXOcDet).HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_det_ct_centro_costo_sub_centro_c24");

            entity.HasOne(d => d.InIngEgrInvenDet).WithMany(p => p.CpAprobacionIngBodXOcDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_Aprobacion_Ing_Bod_x_OC_det_in_Ing_Egr_Inven_det");
        });

        modelBuilder.Entity<CpAprobacionIngBodXOcDetEliminados>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpAprobacionIngBodXOcEliminados>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<CpAprobacionIngBodXOt>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<CpAprobacionOrdenPago>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<CpAprobacionOrdenPagoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CpAprobacionOrdenPago).WithMany(p => p.CpAprobacionOrdenPagoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_Aprobacion_Orden_pago_det_cp_Aprobacion_Orden_pago");

            entity.HasOne(d => d.CpOrdenPagoDet).WithMany(p => p.CpAprobacionOrdenPagoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_Aprobacion_Orden_pago_det_cp_orden_pago_det");
        });

        modelBuilder.Entity<CpAutorizacionXDocXPag>(entity =>
        {
            entity.HasKey(e => e.IdNumAutorizacion).HasName("PRIMARY");
        });

        modelBuilder.Entity<CpBaseImponibleXCentroCostoEdehsa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbteOgiro, e.IdCbteCbleOgiro, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CpCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogo).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdCatalogoTipoNavigation).WithMany(p => p.CpCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_catalogo_cp_catalogo_tipo");
        });

        modelBuilder.Entity<CpCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoTipo).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CpCodigoSri>(entity =>
        {
            entity.HasKey(e => e.IdCodigoSri).HasName("PRIMARY");

            entity.Property(e => e.IdCodigoSri).ValueGeneratedNever();

            entity.HasOne(d => d.IdTipoSriNavigation).WithMany(p => p.CpCodigoSri)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_codigo_SRI_cp_codigo_SRI_tipo");
        });

        modelBuilder.Entity<CpCodigoSriTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoSri).HasName("PRIMARY");
        });

        modelBuilder.Entity<CpCodigoSriXCtaCble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCodigoSri })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdCodigoSriNavigation).WithMany(p => p.CpCodigoSriXCtaCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_codigo_SRI_x_CtaCble_cp_codigo_SRI");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpCodigoSriXCtaCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_codigo_SRI_x_CtaCble_ct_plancta");
        });

        modelBuilder.Entity<CpConciliacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpConciliacion).HasConstraintName("FK_cp_conciliacion_ct_cbtecble");
        });

        modelBuilder.Entity<CpConciliacionCaja>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacionCaja })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdEstadoCierreNavigation).WithMany(p => p.CpConciliacionCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_cp_catalogo");

            entity.HasOne(d => d.CajCaja).WithMany(p => p.CpConciliacionCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_caj_Caja");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpConciliacionCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_ct_plancta");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.CpConciliacionCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_ct_periodo");

            entity.HasOne(d => d.BaTipoFlujo).WithMany(p => p.CpConciliacionCaja).HasConstraintName("FK_cp_conciliacion_Caja_ba_TipoFlujo");

            entity.HasOne(d => d.CpOrdenPago).WithMany(p => p.CpConciliacionCaja).HasConstraintName("FK_cp_conciliacion_Caja_cp_orden_pago");

            entity.HasOne(d => d.CajCajaMovimiento).WithMany(p => p.CpConciliacionCaja).HasConstraintName("FK_cp_conciliacion_Caja_caj_Caja_Movimiento");
        });

        modelBuilder.Entity<CpConciliacionCajaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacionCaja, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CpConciliacionCajaDet).HasConstraintName("FK_cp_conciliacion_Caja_det_ct_centro_costo");

            entity.HasOne(d => d.CpConciliacionCaja).WithMany(p => p.CpConciliacionCajaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_det_cp_conciliacion_Caja");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.CpConciliacionCajaDet).HasConstraintName("FK_cp_conciliacion_Caja_det_ct_centro_costo_sub_centro_costo");
        });

        modelBuilder.Entity<CpConciliacionCajaDetIngCaja>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacionCaja, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CpConciliacionCaja).WithMany(p => p.CpConciliacionCajaDetIngCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_det_Ing_Caja_cp_conciliacion_Caja");

            entity.HasOne(d => d.CajCajaMovimiento).WithMany(p => p.CpConciliacionCajaDetIngCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_det_Ing_Caja_caj_Caja_Movimiento");
        });

        modelBuilder.Entity<CpConciliacionCajaDetXValeCaja>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacionCaja, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CpConciliacionCaja).WithMany(p => p.CpConciliacionCajaDetXValeCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_det_x_ValeCaja_cp_conciliacion_Caja");

            entity.HasOne(d => d.CajCajaMovimiento).WithMany(p => p.CpConciliacionCajaDetXValeCaja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_Caja_det_x_ValeCaja_caj_Caja_Movimiento");
        });

        modelBuilder.Entity<CpConciliacionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CpConciliacion).WithMany(p => p.CpConciliacionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_det_cp_conciliacion");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpConciliacionDetCtCbtecble).HasConstraintName("FK_cp_conciliacion_det_ct_cbtecble");

            entity.HasOne(d => d.CpOrdenPagoDet).WithMany(p => p.CpConciliacionDet).HasConstraintName("FK_cp_conciliacion_det_cp_orden_pago_det");

            entity.HasOne(d => d.CtCbtecbleNavigation).WithMany(p => p.CpConciliacionDetCtCbtecbleNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_conciliacion_det_ct_cbtecble1");
        });

        modelBuilder.Entity<CpConciliacionIngBodegaXOrdenGiro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdConciliacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CpAprobacionIngBodXOc).WithMany(p => p.CpConciliacionIngBodegaXOrdenGiro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_Conciliacion_Ing_Bodega_x_Orden_Giro_cp_Aprobacion_Ing_B37");
        });

        modelBuilder.Entity<CpCuotasXDoc>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCuota })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpCuotasXDoc).HasConstraintName("FK_cp_cuotas_x_doc_ct_cbtecble1");
        });

        modelBuilder.Entity<CpCuotasXDocDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCuota, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CpCuotasXDoc).WithMany(p => p.CpCuotasXDocDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_cuotas_x_doc_det_cp_cuotas_x_doc1");

            entity.HasOne(d => d.CpOrdenPagoDet).WithMany(p => p.CpCuotasXDocDet).HasConstraintName("FK_cp_cuotas_x_doc_det_cp_orden_pago_det1");
        });

        modelBuilder.Entity<CpCxpEdehsaRpt001>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpCxpEdehsaRpt001SaldoInicial>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpCxpRpt001>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpCxpRpt001SaldoInicial>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpEstado>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCp).HasName("PRIMARY");
        });

        modelBuilder.Entity<CpLiquidacionCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdLiquidacionCompra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.CpEstaImpresa).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpLiquidacionCompra).HasConstraintName("FK_cp_liquidacion_compra_cp_orden_giro");

            entity.HasOne(d => d.TbSisDocumentoTipoTalonario).WithMany(p => p.CpLiquidacionCompra).HasConstraintName("FK_cp_liquidacion_compra_tb_sis_Documento_Tipo_Talonario");
        });

        modelBuilder.Entity<CpLiquidacionCompraDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdLiquidacionCompra, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdCodImpuestoIvaNavigation).WithMany(p => p.CpLiquidacionCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_liquidacion_compra_det_tb_sis_Impuesto");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.CpLiquidacionCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_liquidacion_compra_det_in_UnidadMedida");

            entity.HasOne(d => d.CpLiquidacionCompra).WithMany(p => p.CpLiquidacionCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_liquidacion_compra_det_cp_liquidacion_compra");

            entity.HasOne(d => d.InProducto).WithMany(p => p.CpLiquidacionCompraDet).HasConstraintName("FK_cp_liquidacion_compra_det_in_Producto");
        });

        modelBuilder.Entity<CpNotaDebCre>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCbleNota, e.IdTipoCbteNota })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CnVaCoa).IsFixedLength();

            entity.HasOne(d => d.IdCodIceNavigation).WithMany(p => p.CpNotaDebCreIdCodIceNavigation).HasConstraintName("FK_cp_nota_DebCre_cp_codigo_SRI");

            entity.HasOne(d => d.IdIdenCreditoNavigation).WithMany(p => p.CpNotaDebCreIdIdenCreditoNavigation).HasConstraintName("FK_cp_nota_DebCre_cp_codigo_SRI1");

            entity.HasOne(d => d.IdTipoNotaNavigation).WithMany(p => p.CpNotaDebCre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_nota_DebCre_cp_catalogo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CpNotaDebCre).HasConstraintName("FK_cp_nota_DebCre_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpNotaDebCreCtPlancta).HasConstraintName("FK_cp_nota_DebCre_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.CpNotaDebCreCtPlanctaNavigation).HasConstraintName("FK_cp_nota_DebCre_ct_plancta1");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.CpNotaDebCre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_nota_DebCre_cp_proveedor");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CpNotaDebCre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_nota_DebCre_tb_sucursal");

            entity.HasOne(d => d.BaTipoFlujo).WithMany(p => p.CpNotaDebCre).HasConstraintName("FK_cp_nota_DebCre_ba_TipoFlujo");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpNotaDebCreCtCbtecble).HasConstraintName("FK_cp_nota_DebCre_ct_cbtecble1");

            entity.HasOne(d => d.CtCbtecbleNavigation).WithMany(p => p.CpNotaDebCreCtCbtecbleNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_nota_DebCre_ct_cbtecble");
        });

        modelBuilder.Entity<CpNotaDebCreAprobacionIngBodXOc>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<CpNotaDebCreAprobacionIngBodXOcDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAprobacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InIngEgrInvenDet).WithMany(p => p.CpNotaDebCreAprobacionIngBodXOcDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_inven_det_FK");
        });

        modelBuilder.Entity<CpNotaDebCreImpuesto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCbleNota, e.IdTipoCbteNota, e.Codigo, e.CodigoPorcentaje })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.Codigo).IsFixedLength();
            entity.Property(e => e.CodigoPorcentaje).IsFixedLength();

            entity.HasOne(d => d.CpNotaDebCre).WithMany(p => p.CpNotaDebCreImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cp_nota_DebCre__Impuesto_cp_nota_DebCre_FK");
        });

        modelBuilder.Entity<CpNotaDebCreXComOrdencompraLocal>(entity =>
        {
            entity.HasKey(e => new { e.NdcIdEmpresa, e.NdcIdCbteCbleNota, e.NdcIdTipoCbteNota, e.ComIdEmpresa, e.ComIdSucursal, e.ComIdOrdenCompraLocal })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.ComOrdencompraLocal).WithMany(p => p.CpNotaDebCreXComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_nota_DebCre_x_com_ordencompra_local_com_ordencompra_local");

            entity.HasOne(d => d.CpNotaDebCre).WithMany(p => p.CpNotaDebCreXComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_nota_DebCre_x_com_ordencompra_local_cp_nota_DebCre");
        });

        modelBuilder.Entity<CpOrdenGiro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCbleOgiro, e.IdTipoCbteOgiro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CoRetencionManual).IsFixedLength();
            entity.Property(e => e.CoVaCoa).IsFixedLength();

            entity.HasOne(d => d.IdCod101Navigation).WithMany(p => p.CpOrdenGiroIdCod101Navigation).HasConstraintName("FK_cp_orden_giro_cp_codigo_SRI2");

            entity.HasOne(d => d.IdCodIceNavigation).WithMany(p => p.CpOrdenGiroIdCodIceNavigation).HasConstraintName("FK_cp_orden_giro_cp_codigo_SRI");

            entity.HasOne(d => d.IdIdenCreditoNavigation).WithMany(p => p.CpOrdenGiroIdIdenCreditoNavigation).HasConstraintName("FK_cp_orden_giro_cp_codigo_SRI1");

            entity.HasOne(d => d.IdTipoMoviNavigation).WithMany(p => p.CpOrdenGiro).HasConstraintName("FK_cp_orden_giro_caj_Caja_Movimiento_Tipo");

            entity.HasOne(d => d.PaisPagoNavigation).WithMany(p => p.CpOrdenGiro).HasConstraintName("FK_cp_orden_giro_cp_pais_sri");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CpOrdenGiro).HasConstraintName("FK_cp_orden_giro_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpOrdenGiroCtPlancta).HasConstraintName("FK_cp_orden_giro_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.CpOrdenGiroCtPlanctaNavigation).HasConstraintName("FK_cp_orden_giro_ct_plancta1");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.CpOrdenGiro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_cp_proveedor");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CpOrdenGiro).HasConstraintName("FK_cp_orden_giro_tb_sucursal");

            entity.HasOne(d => d.BaTipoFlujo).WithMany(p => p.CpOrdenGiro).HasConstraintName("FK_cp_orden_giro_ba_TipoFlujo");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpOrdenGiroCtCbtecble).HasConstraintName("FK_cp_orden_giro_ct_cbtecble1");

            entity.HasOne(d => d.CtCbtecbleNavigation).WithMany(p => p.CpOrdenGiroCtCbtecbleNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_ct_cbtecble");
        });

        modelBuilder.Entity<CpOrdenGiroImpuesto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCbleOgiro, e.IdTipoCbteOgiro, e.Codigo, e.CodigoPorcentaje })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.Codigo).IsFixedLength();
            entity.Property(e => e.CodigoPorcentaje).IsFixedLength();

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpOrdenGiroImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cp_orden_giro_Impuesto2_FK");
        });

        modelBuilder.Entity<CpOrdenGiroPagosSri>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCbleOgiro, e.IdTipoCbteOgiro, e.CodigoPagoSri })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.CodigoPagoSriNavigation).WithMany(p => p.CpOrdenGiroPagosSri)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_pagos_sri_cp_pagos_sri");

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpOrdenGiroPagosSri)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_pagos_sri_cp_orden_giro");
        });

        modelBuilder.Entity<CpOrdenGiroXComOrdencompraLocal>(entity =>
        {
            entity.HasKey(e => new { e.OgIdEmpresa, e.OgIdCbteCble, e.OgIdTipoCbte, e.ComIdEmpresa, e.ComIdSucursal, e.ComIdOrdenCompraLocal })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.ComOrdencompraLocal).WithMany(p => p.CpOrdenGiroXComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_x_com_ordencompra_local_com_ordencompra_local");

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpOrdenGiroXComOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_x_com_ordencompra_local_cp_orden_giro");
        });

        modelBuilder.Entity<CpOrdenGiroXComOrdencompraLocalDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaOgiro, e.IdCbteCbleOgiro, e.IdTipoCbteOgiro, e.IdEmpresaOc, e.IdSucursalOc, e.IdOrdenCompra, e.SecuenciaOc, e.SecuenciaReg })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpOrdenGiroXComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_x_com_ordencompra_local_det_cp_orden_giro");

            entity.HasOne(d => d.ComOrdencompraLocalDet).WithMany(p => p.CpOrdenGiroXComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_giro_x_com_ordencompra_local_det_com_ordencompra_l27");
        });

        modelBuilder.Entity<CpOrdenGiroXPrdOrdenTrabajoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaOgiro, e.IdCbteCbleOgiro, e.IdTipoCbteOgiro, e.IdEmpresaOt, e.IdSucursalOt, e.IdOrdenTrabajo, e.SecuenciaOt, e.SecuenciaReg })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CpOrdenPago>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdOrdenPago })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.CpOrdenPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_cp_orden_pago_formapago");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.CpOrdenPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_tb_persona");

            entity.HasOne(d => d.IdTipoOpNavigation).WithMany(p => p.CpOrdenPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_cp_orden_pago_tipo");

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.CpOrdenPago).HasConstraintName("FK_cp_orden_pago_ba_Banco_Cuenta");
        });

        modelBuilder.Entity<CpOrdenPagoCancelaciones>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.Idcancelacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpOrdenPagoCancelacionesCtCbtecble).HasConstraintName("FK_cp_orden_pago_cancelaciones_ct_cbtecble");

            entity.HasOne(d => d.CpOrdenPagoDet).WithMany(p => p.CpOrdenPagoCancelacionesCpOrdenPagoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_cancelaciones_cp_orden_pago_det");

            entity.HasOne(d => d.CpOrdenPagoDetNavigation).WithMany(p => p.CpOrdenPagoCancelacionesCpOrdenPagoDetNavigation).HasConstraintName("FK_cp_orden_pago_cancelaciones_cp_orden_pago_det1");

            entity.HasOne(d => d.CtCbtecbleNavigation).WithMany(p => p.CpOrdenPagoCancelacionesCtCbtecbleNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_cancelaciones_ct_cbtecble1");
        });

        modelBuilder.Entity<CpOrdenPagoConTransferenciaData>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.IdOrdenPago, e.SecuenciaOp })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CpOrdenPagoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdOrdenPago, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.CpOrdenPagoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_det_cp_orden_pago_formapago");

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.CpOrdenPagoDet).HasConstraintName("FK_cp_orden_pago_det_ba_Banco_Cuenta");

            entity.HasOne(d => d.CpOrdenPago).WithMany(p => p.CpOrdenPagoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_det_cp_orden_pago");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpOrdenPagoDet).HasConstraintName("FK_cp_orden_pago_det_ct_cbtecble");
        });

        modelBuilder.Entity<CpOrdenPagoEstadoAprob>(entity =>
        {
            entity.HasKey(e => e.IdEstadoAprobacion).HasName("PRIMARY");
        });

        modelBuilder.Entity<CpOrdenPagoFormapago>(entity =>
        {
            entity.HasKey(e => e.IdFormaPago).HasName("PRIMARY");

            entity.HasOne(d => d.CodModuloNavigation).WithMany(p => p.CpOrdenPagoFormapago).HasConstraintName("FK_cp_orden_pago_formapago_tb_modulo");

            entity.HasOne(d => d.IdTipoMoviCajNavigation).WithMany(p => p.CpOrdenPagoFormapago).HasConstraintName("FK_cp_orden_pago_formapago_caj_Caja_Movimiento_Tipo");

            entity.HasOne(d => d.IdTipoTransaccionNavigation).WithMany(p => p.CpOrdenPagoFormapago).HasConstraintName("FK_cp_orden_pago_formapago_cp_trans_a_generar_x_FormaPago_OP");
        });

        modelBuilder.Entity<CpOrdenPagoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoOp).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.GeneraDiario).IsFixedLength();
        });

        modelBuilder.Entity<CpOrdenPagoTipoXEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoOp })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.BuscarFactxPagar).IsFixedLength();

            entity.HasOne(d => d.IdTipoOpNavigation).WithMany(p => p.CpOrdenPagoTipoXEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_tipo_x_empresa_cp_orden_pago_tipo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CpOrdenPagoTipoXEmpresa).HasConstraintName("FK_cp_orden_pago_tipo_x_empresa_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpOrdenPagoTipoXEmpresa).HasConstraintName("FK_cp_orden_pago_tipo_x_empresa_ct_plancta");
        });

        modelBuilder.Entity<CpOrdenPagoXEmpleadoXNominaXPeriodo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdOrdenPago, e.IdPersona, e.IdEmpleado })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CpOrdenPago).WithMany(p => p.CpOrdenPagoXEmpleadoXNominaXPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_orden_pago_x_empleado_x_nomina_x_periodo_cp_orden_pago");
        });

        modelBuilder.Entity<CpOrdenPagoXIdArchivo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdOrdenPago, e.IdArchivo, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CpPagosSri>(entity =>
        {
            entity.HasKey(e => e.CodigoPagoSri).HasName("PRIMARY");
        });

        modelBuilder.Entity<CpPaisSri>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");
        });

        modelBuilder.Entity<CpParametros>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.CpParametros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_parametros_tb_empresa");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpParametrosCtPlancta).HasConstraintName("FK_cp_parametros_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.CpParametrosCtPlanctaNavigation).HasConstraintName("FK_cp_parametros_ct_plancta1");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.CpParametrosCtPlancta1).HasConstraintName("FK_cp_parametros_ct_plancta2");

            entity.HasOne(d => d.CtPlancta2).WithMany(p => p.CpParametrosCtPlancta2).HasConstraintName("FK_cp_parametros_ct_plancta3");

            entity.HasOne(d => d.CtPlancta3).WithMany(p => p.CpParametrosCtPlancta3).HasConstraintName("FK_cp_parametros_ct_plancta4");

            entity.HasOne(d => d.BaBancoCuenta).WithMany(p => p.CpParametros).HasConstraintName("FK_cp_parametros_ba_Banco_Cuenta");

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.CpParametrosCtCbtecbleTipo).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo3");

            entity.HasOne(d => d.CtCbtecbleTipoNavigation).WithMany(p => p.CpParametrosCtCbtecbleTipoNavigation).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo2");

            entity.HasOne(d => d.CtCbtecbleTipo1).WithMany(p => p.CpParametrosCtCbtecbleTipo1).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo4");

            entity.HasOne(d => d.CtCbtecbleTipo2).WithMany(p => p.CpParametrosCtCbtecbleTipo2).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo5");

            entity.HasOne(d => d.CtCbtecbleTipo3).WithMany(p => p.CpParametrosCtCbtecbleTipo3).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo6");

            entity.HasOne(d => d.CtCbtecbleTipo4).WithMany(p => p.CpParametrosCtCbtecbleTipo4).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo7");

            entity.HasOne(d => d.CtCbtecbleTipo5).WithMany(p => p.CpParametrosCtCbtecbleTipo5).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo");

            entity.HasOne(d => d.CtCbtecbleTipo6).WithMany(p => p.CpParametrosCtCbtecbleTipo6).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo1");

            entity.HasOne(d => d.CtCbtecbleTipo7).WithMany(p => p.CpParametrosCtCbtecbleTipo7).HasConstraintName("FK_cp_parametros_ct_cbtecble_tipo8");
        });

        modelBuilder.Entity<CpProveedor>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.PrContribuyenteEspecial).IsFixedLength();
            entity.Property(e => e.PrContribuyenteExentoDeIva).IsFixedLength();
            entity.Property(e => e.PrGranContribuyente).IsFixedLength();

            entity.HasOne(d => d.CodigoSri101PredeterNavigation).WithMany(p => p.CpProveedorCodigoSri101PredeterNavigation).HasConstraintName("FK_cp_proveedor_cp_codigo_SRI2");

            entity.HasOne(d => d.CodigoSriIcePredeterNavigation).WithMany(p => p.CpProveedorCodigoSriIcePredeterNavigation).HasConstraintName("FK_cp_proveedor_cp_codigo_SRI1");

            entity.HasOne(d => d.IdBancoAcreditacionNavigation).WithMany(p => p.CpProveedor).HasConstraintName("FK_cp_proveedor_tb_banco");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.CpProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_tb_ciudad");

            entity.HasOne(d => d.IdCreditoPredeterNavigation).WithMany(p => p.CpProveedorIdCreditoPredeterNavigation).HasConstraintName("FK_cp_proveedor_cp_codigo_SRI");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CpProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_tb_empresa");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.CpProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_tb_persona");

            entity.HasOne(d => d.IdTipoCtaAcreditacionCatNavigation).WithMany(p => p.CpProveedorIdTipoCtaAcreditacionCatNavigation).HasConstraintName("FK_cp_proveedor_cp_catalogo2");

            entity.HasOne(d => d.IdTipoGastoNavigation).WithMany(p => p.CpProveedorIdTipoGastoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_cp_catalogo1");

            entity.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.CpProveedorIdTipoServicioNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_cp_catalogo");

            entity.HasOne(d => d.CpProveedorClase).WithMany(p => p.CpProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_cp_proveedor_clase");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CpProveedorCtPlancta).HasConstraintName("FK_cp_proveedor_ct_plancta1");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.CpProveedorCtPlanctaNavigation).HasConstraintName("FK_cp_proveedor_ct_plancta");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.CpProveedorCtPlancta1).HasConstraintName("FK_cp_proveedor_ct_plancta2");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.CpProveedor).HasConstraintName("FK_cp_proveedor_ct_punto_cargo");

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.CpProveedor).HasConstraintName("FK_cp_proveedor_ct_punto_cargo_grupo");
        });

        modelBuilder.Entity<CpProveedorAutorizacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdAutorizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.CpProveedorAutorizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_Autorizacion_cp_proveedor");
        });

        modelBuilder.Entity<CpProveedorCalificacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdCalificacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CpProveedorClase>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdClaseProveedor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CpProveedorCodigoSri>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdCodigoSri })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdCodigoSriNavigation).WithMany(p => p.CpProveedorCodigoSri)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_codigo_SRI_cp_codigo_SRI");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.CpProveedorCodigoSri)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_codigo_SRI_cp_proveedor");
        });

        modelBuilder.Entity<CpProveedorContactos>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaProv, e.IdProveedor, e.IdEmpresaCont, e.IdContacto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.TbContacto).WithMany(p => p.CpProveedorContactos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_contactos_tb_contacto");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.CpProveedorContactos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_proveedor_contactos_cp_proveedor");
        });

        modelBuilder.Entity<CpProveedorDatosAcreditacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Predefinida).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<CpProveedorFiltro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpProveedorXIdCtaCbleCxc>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.IdCtaCbleCxc })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpProveedorXTbCiiu>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CpReembolso>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCbteCbleOgiro, e.IdTipoCbteOgiro, e.IdReembolso })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.CpReembolso).HasConstraintName("FK_cp_reembolso_cp_proveedor");

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpReembolso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_reembolso_cp_orden_giro");
        });

        modelBuilder.Entity<CpRetencion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdRetencion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
            entity.Property(e => e.ReTieneRfuente).IsFixedLength();
            entity.Property(e => e.ReTieneRtiva).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CpRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_retencion_tb_empresa");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpRetencion).HasConstraintName("FK_cp_retencion_ct_cbtecble");

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.CpRetencion).HasConstraintName("FK_cp_retencion_cp_orden_giro");

            entity.HasOne(d => d.TbSisDocumentoTipoTalonario).WithMany(p => p.CpRetencion).HasConstraintName("FK_cp_retencion_tb_sis_Documento_Tipo_Talonario");
        });

        modelBuilder.Entity<CpRetencionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdRetencion, e.Idsecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.ReEstado).IsFixedLength();
            entity.Property(e => e.ReTipoRet).IsFixedLength();

            entity.HasOne(d => d.IdCodigoSriNavigation).WithMany(p => p.CpRetencionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_retencion_det_cp_codigo_SRI");

            entity.HasOne(d => d.CpRetencion).WithMany(p => p.CpRetencionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_retencion_det_cp_retencion");
        });

        modelBuilder.Entity<CpRetencionXCtCbtecble>(entity =>
        {
            entity.HasKey(e => new { e.RtIdEmpresa, e.RtIdRetencion, e.CtIdEmpresa, e.CtIdTipoCbte, e.CtIdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CpRetencion).WithMany(p => p.CpRetencionXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_retencion_x_ct_cbtecble_cp_retencion");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CpRetencionXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cp_retencion_x_ct_cbtecble_ct_cbtecble");
        });

        modelBuilder.Entity<CpTerminoPago>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTerminoPago })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CpTipoDocumento>(entity =>
        {
            entity.HasKey(e => e.CodTipoDocumento).HasName("PRIMARY");
        });

        modelBuilder.Entity<CpTransAGenerarXFormaPagoOp>(entity =>
        {
            entity.HasKey(e => e.IdTipoTransaccion).HasName("PRIMARY");
        });

        modelBuilder.Entity<CtAnioFiscal>(entity =>
        {
            entity.HasKey(e => e.IdanioFiscal).HasName("PRIMARY");

            entity.Property(e => e.IdanioFiscal).ValueGeneratedNever();
        });

        modelBuilder.Entity<CtAnioFiscalXCuentaUtilidad>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdanioFiscal, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdanioFiscalNavigation).WithMany(p => p.CtAnioFiscalXCuentaUtilidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_anio_fiscal_x_cuenta_utilidad_ct_anio_fiscal");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtAnioFiscalXCuentaUtilidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_anio_fiscal_x_cuenta_utilidad_ct_plancta");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CtAnioFiscalXCuentaUtilidad).HasConstraintName("FK_ct_anio_fiscal_x_cuenta_utilidad_ct_cbtecble");
        });

        modelBuilder.Entity<CtBalanceXGeneral>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCtaCble, e.IdCentroCosto, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.GcEstadoFinanciero).IsFixedLength();
            entity.Property(e => e.GrupoCble).IsFixedLength();
        });

        modelBuilder.Entity<CtBalanceXGeneralDataFinal>(entity =>
        {
            entity.Property(e => e.GcEstadoFinanciero).IsFixedLength();
            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
        });

        modelBuilder.Entity<CtCbtecble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte, e.IdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CbEstado).IsFixedLength();
            entity.Property(e => e.CbMayorizado).IsFixedLength();

            entity.HasOne(d => d.CbAnioNavigation).WithMany(p => p.CtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_ct_anio_fiscal");

            entity.HasOne(d => d.CbMesNavigation).WithMany(p => p.CtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_tb_mes");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.CtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_ct_periodo");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_tb_sucursal");

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.CtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_ct_cbtecble_tipo");
        });

        modelBuilder.Entity<CtCbtecbleDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte, e.IdCbteCble, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.DcEstaConciliado).IsFixedLength();

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CtCbtecbleDet).HasConstraintName("FK_ct_cbtecble_det_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtCbtecbleDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_det_ct_plancta");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.CtCbtecbleDet).HasConstraintName("FK_ct_cbtecble_det_ct_punto_cargo");

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.CtCbtecbleDet).HasConstraintName("FK_ct_cbtecble_det_ct_punto_cargo_grupo");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.CtCbtecbleDet).HasConstraintName("FK_ct_cbtecble_det_ct_centro_costo_sub_centro_costo");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CtCbtecbleDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_det_ct_cbtecble");
        });

        modelBuilder.Entity<CtCbtecblePlantilla>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte, e.IdPlantilla })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CbEstado).IsFixedLength();

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.CtCbtecblePlantilla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_Plantilla_ct_cbtecble_tipo");
        });

        modelBuilder.Entity<CtCbtecblePlantillaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte, e.IdPlantilla, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CtCbtecblePlantillaDet).HasConstraintName("FK_ct_cbtecble_Plantilla_det_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtCbtecblePlantillaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_Plantilla_det_ct_plancta");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.CtCbtecblePlantillaDet).HasConstraintName("FK_ct_cbtecble_Plantilla_det_ct_punto_cargo");

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.CtCbtecblePlantillaDet).HasConstraintName("FK_ct_cbtecble_Plantilla_det_ct_punto_cargo_grupo");

            entity.HasOne(d => d.CtCbtecblePlantilla).WithMany(p => p.CtCbtecblePlantillaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_Plantilla_det_ct_cbtecble_Plantilla");
        });

        modelBuilder.Entity<CtCbtecbleReversado>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte, e.IdCbteCble, e.IdEmpresaAnu, e.IdTipoCbteAnu, e.IdCbteCbleAnu })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.Property(e => e.Ip).IsFixedLength();

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CtCbtecbleReversadoCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_Reversado_ct_cbtecble");

            entity.HasOne(d => d.CtCbtecbleNavigation).WithMany(p => p.CtCbtecbleReversadoCtCbtecbleNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_cbtecble_Reversado_ct_cbtecble1");
        });

        modelBuilder.Entity<CtCbtecbleTipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.CodTipoCbte).IsFixedLength();
            entity.Property(e => e.TcEstado).IsFixedLength();
            entity.Property(e => e.TcInterno).IsFixedLength();
            entity.Property(e => e.TcNemonico).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<CtCentroCosto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCentroCosto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
            entity.Property(e => e.PcEstado).IsFixedLength();

            entity.HasOne(d => d.CtCentroCostoNavigation).WithMany(p => p.InverseCtCentroCostoNavigation).HasConstraintName("FK_ct_centro_costo_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtCentroCosto).HasConstraintName("FK_ct_centro_costo_ct_plancta");

            entity.HasOne(d => d.CtCentroCostoNivel).WithMany(p => p.CtCentroCosto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_centro_costo_ct_centro_costo_nivel");
        });

        modelBuilder.Entity<CtCentroCostoEstadoCierre>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCentroCosto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CtCentroCosto).WithOne(p => p.CtCentroCostoEstadoCierre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_centro_costo_EstadoCierre_ct_centro_costo");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.CtCentroCostoEstadoCierre).HasConstraintName("FK_ct_centro_costo_EstadoCierre_fa_cliente");
        });

        modelBuilder.Entity<CtCentroCostoFiltro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCentroCosto, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CtCentroCostoNivel>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdNivel })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CtCentroCostoNivel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_centro_costo_nivel_tb_empresa");
        });

        modelBuilder.Entity<CtCentroCostoSubCentroCosto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCentroCosto, e.IdCentroCostoSubCentroCosto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.PcEstado).IsFixedLength();

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CtCentroCostoSubCentroCosto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_centro_costo_sub_centro_costo_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtCentroCostoSubCentroCosto).HasConstraintName("FK_ct_centro_costo_sub_centro_costo_ct_plancta");
        });

        modelBuilder.Entity<CtCentroCostoSubCentroCostoXAfActivoFijo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaScc, e.IdCentroCostoScc, e.IdCentroCostoSubCentroCostoScc, e.IdEmpresaAf, e.IdActivoFijoAf })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CtDashboardFinanciero>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.AnioFiscal, e.IdMes })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CtGrupoEmpresarial>(entity =>
        {
            entity.HasKey(e => e.IdGrupoEmpresarial).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CtGrupoEmpresarialGrupocble>(entity =>
        {
            entity.HasKey(e => e.IdGrupoCbleGr).HasName("PRIMARY");
        });

        modelBuilder.Entity<CtGrupoEmpresarialPlancta>(entity =>
        {
            entity.HasKey(e => e.IdCuentaGr).HasName("PRIMARY");

            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
            entity.Property(e => e.PcEstado).IsFixedLength();
            entity.Property(e => e.PcNaturaleza).IsFixedLength();

            entity.HasOne(d => d.IdCuentaPadreGrNavigation).WithMany(p => p.InverseIdCuentaPadreGrNavigation).HasConstraintName("FK_ct_GrupoEmpresarial_plancta_ct_GrupoEmpresarial_plancta");

            entity.HasOne(d => d.IdGrupoCbleGrNavigation).WithMany(p => p.CtGrupoEmpresarialPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_GrupoEmpresarial_plancta_ct_GrupoEmpresarial_grupocble");

            entity.HasOne(d => d.IdNivelCtaGrNavigation).WithMany(p => p.CtGrupoEmpresarialPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_GrupoEmpresarial_plancta_ct_GrupoEmpresarial_plancta_nivel");
        });

        modelBuilder.Entity<CtGrupoEmpresarialPlanctaNivel>(entity =>
        {
            entity.HasKey(e => e.IdNivelCtaGr).HasName("PRIMARY");

            entity.Property(e => e.IdNivelCtaGr).ValueGeneratedNever();
        });

        modelBuilder.Entity<CtGrupoEmpresarialPlanctaXCtPlancta>(entity =>
        {
            entity.HasKey(e => new { e.IdGrupoEmpresarial, e.IdCuentaGr, e.IdEmpresa, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdCuentaGrNavigation).WithMany(p => p.CtGrupoEmpresarialPlanctaXCtPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_GrupoEmpresarial_plancta_x_ct_plancta_ct_GrupoEmpresaria23");

            entity.HasOne(d => d.IdGrupoEmpresarialNavigation).WithMany(p => p.CtGrupoEmpresarialPlanctaXCtPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_GrupoEmpresarial_plancta_x_ct_plancta_ct_GrupoEmpresarial");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtGrupoEmpresarialPlanctaXCtPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_GrupoEmpresarial_plancta_x_ct_plancta_ct_plancta");
        });

        modelBuilder.Entity<CtGrupoXTipoGasto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoGasto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CtGrupoXTipoGastoNavigation).WithMany(p => p.InverseCtGrupoXTipoGastoNavigation).HasConstraintName("FK_ct_grupo_x_Tipo_Gasto_ct_grupo_x_Tipo_Gasto");
        });

        modelBuilder.Entity<CtGrupocble>(entity =>
        {
            entity.HasKey(e => e.IdGrupoCble).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.GcEstadoFinanciero).IsFixedLength();
            entity.Property(e => e.GcGrupoCble).IsFixedLength();

            entity.HasOne(d => d.IdGrupoMayorNavigation).WithMany(p => p.CtGrupocble).HasConstraintName("FK_ct_grupocble_ct_grupocble_Mayor");
        });

        modelBuilder.Entity<CtGrupocbleMayor>(entity =>
        {
            entity.HasKey(e => e.IdGrupoMayor).HasName("PRIMARY");
        });

        modelBuilder.Entity<CtParametro>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.CtParametroCtCbtecbleTipo).HasConstraintName("FK_ct_parametro_ct_cbtecble_tipo1");

            entity.HasOne(d => d.CtCbtecbleTipoNavigation).WithMany(p => p.CtParametroCtCbtecbleTipoNavigation).HasConstraintName("FK_ct_parametro_ct_cbtecble_tipo");
        });

        modelBuilder.Entity<CtPeriodo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPeriodo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CtPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_periodo_tb_empresa");

            entity.HasOne(d => d.IdanioFiscalNavigation).WithMany(p => p.CtPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_periodo_ct_anio_fiscal");

            entity.HasOne(d => d.PeMesNavigation).WithMany(p => p.CtPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_periodo_tb_mes");
        });

        modelBuilder.Entity<CtPeriodoXTbModulo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPeriodo, e.IdModulo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdModuloNavigation).WithMany(p => p.CtPeriodoXTbModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_periodo_x_tb_modulo_tb_modulo");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.CtPeriodoXTbModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_periodo_x_tb_modulo_ct_periodo");
        });

        modelBuilder.Entity<CtPlancta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.PcEsFlujoEfectivo).IsFixedLength();
            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
            entity.Property(e => e.PcEstado).IsFixedLength();
            entity.Property(e => e.PcNaturaleza).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CtPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_plancta_tb_empresa");

            entity.HasOne(d => d.IdGrupoCbleNavigation).WithMany(p => p.CtPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_plancta_ct_grupocble");

            entity.HasOne(d => d.IdTipoCtaCbleNavigation).WithMany(p => p.CtPlancta).HasConstraintName("FK_ct_plancta_ct_tipo_ctacble");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.InverseCtPlanctaNavigation).HasConstraintName("FK_ct_plancta_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNivel).WithMany(p => p.CtPlancta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_plancta_ct_plancta_nivel");

            entity.HasOne(d => d.CtGrupoXTipoGasto).WithMany(p => p.CtPlancta).HasConstraintName("FK_ct_plancta_ct_grupo_x_Tipo_Gasto");
        });

        modelBuilder.Entity<CtPlanctaNivel>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdNivelCta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CtPuntoCargo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPuntoCargo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.CtPuntoCargo).HasConstraintName("FK_ct_punto_cargo_ct_punto_cargo_grupo");
        });

        modelBuilder.Entity<CtPuntoCargoGrupo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPuntoCargoGrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtPuntoCargoGrupo).HasConstraintName("FK_ct_punto_cargo_grupo_ct_plancta");
        });

        modelBuilder.Entity<CtRptEmpresasAMostrar>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();
        });

        modelBuilder.Entity<CtRptMovxCta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPeriodo, e.IdCtaCble, e.IdCbteCble, e.IdTipoCbte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.IdCtaCble).IsFixedLength();
            entity.Property(e => e.IdCentroCosto).IsFixedLength();
            entity.Property(e => e.Observacion).IsFixedLength();
            entity.Property(e => e.STipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<CtRptSaldoxCta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.IdCtaCble).IsFixedLength();
        });

        modelBuilder.Entity<CtSaldoxCuentas>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAnioF, e.IdPeriodo, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdAnioFNavigation).WithMany(p => p.CtSaldoxCuentas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_saldoxCuentas_ct_anio_fiscal");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtSaldoxCuentas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_saldoxCuentas_ct_plancta");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.CtSaldoxCuentas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_saldoxCuentas_ct_periodo");
        });

        modelBuilder.Entity<CtSaldoxCuentasMovi>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAnioF, e.IdPeriodo, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdAnioFNavigation).WithMany(p => p.CtSaldoxCuentasMovi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_saldoxCuentas_Movi_ct_anio_fiscal");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtSaldoxCuentasMovi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_saldoxCuentas_Movi_ct_plancta");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.CtSaldoxCuentasMovi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_saldoxCuentas_Movi_ct_periodo");
        });

        modelBuilder.Entity<CtSaldoxCuentasMoviTmp>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAnioF, e.IdPeriodo, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CtSaldoxCuentasMoviXRangoFecha>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdEmpresa, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CtSaldoxCuentasTmp>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAnioF, e.IdPeriodo, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CtSumatoriaXCuenta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCtaCble, e.Idcentrocosto, e.Idusuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.EsMovimento).IsFixedLength();

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CtSumatoriaXCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ct_Sumatoria_x_Cuenta_ct_plancta");
        });

        modelBuilder.Entity<CtSumatoriaXCuentaCentrocosto>(entity =>
        {
            entity.Property(e => e.EsMovimento).IsFixedLength();
        });

        modelBuilder.Entity<CtSumatoriaXCuentaXCentroCosto>(entity =>
        {
            entity.Property(e => e.EsMovimento).IsFixedLength();
        });

        modelBuilder.Entity<CtTipoCosto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCosto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<CtTipoCtacble>(entity =>
        {
            entity.HasKey(e => e.IdTipoCtaCble).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CxcAnticipoFacturado>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdAnticipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CxcAnticipoFacturado).HasConstraintName("FK_cxc_anticipo_facturado_ct_centro_costo");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.CxcAnticipoFacturado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_anticipo_facturado_fa_cliente");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CxcAnticipoFacturado).HasConstraintName("FK_cxc_anticipo_facturado_ct_cbtecble");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.CxcAnticipoFacturado).HasConstraintName("FK_cxc_anticipo_facturado_fa_factura");
        });

        modelBuilder.Entity<CxcAnticipoFacturadoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdAnticipo, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.CxcAnticipoFacturado).WithMany(p => p.CxcAnticipoFacturadoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_anticipo_facturado_det_cxc_anticipo_facturado");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CxcAnticipoFacturadoDet).HasConstraintName("FK_cxc_anticipo_facturado_det_ct_cbtecble");
        });

        modelBuilder.Entity<CxcAnticiposFacturados>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAnticipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<CxcCancelacionIntercompany>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCancelacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.CrEstado).IsFixedLength();
            entity.Property(e => e.GeneraDeps).IsFixedLength();

            entity.HasOne(d => d.IdCobroTipoNavigation).WithMany(p => p.CxcCancelacionIntercompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cancelacion_Intercompany_cxc_cobro_tipo");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.CxcCancelacionIntercompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cancelacion_Intercompany_fa_cliente");
        });

        modelBuilder.Entity<CxcCancelacionIntercompanyDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCancelacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CxcCancelacionIntercompany).WithMany(p => p.CxcCancelacionIntercompanyDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cancelacion_Intercompany_det_cxc_cancelacion_Intercompany");
        });

        modelBuilder.Entity<CxcCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogo).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdCatalogoTipoNavigation).WithMany(p => p.CxcCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_Catalogo_cxc_CatalogoTipo");
        });

        modelBuilder.Entity<CxcCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoTipo).HasName("PRIMARY");
        });

        modelBuilder.Entity<CxcCobro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdCobro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.CrEsAnticipo).IsFixedLength();

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.CxcCobro).HasConstraintName("FK_cxc_cobro_ba_Banco_Cuenta");

            entity.HasOne(d => d.IdCobroTipoNavigation).WithMany(p => p.CxcCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_cxc_cobro_tipo");

            entity.HasOne(d => d.IdTipoNotaCreditoNavigation).WithMany(p => p.CxcCobro).HasConstraintName("FK_cxc_cobro_fa_TipoNota");

            entity.HasOne(d => d.CajCaja).WithMany(p => p.CxcCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_caj_Caja");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.CxcCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_fa_cliente");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CxcCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_tb_sucursal");
        });

        modelBuilder.Entity<CxcCobroDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdCobro, e.Secuencial })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CxcCobroDet).HasConstraintName("FK_cxc_cobro_det_ct_centro_costo");

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.CxcCobroDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_det_cxc_cobro");
        });

        modelBuilder.Entity<CxcCobroDetXCtCbtecbleDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaCb, e.IdSucursalCb, e.IdCobroCb, e.SecuencialCb, e.IdEmpresaCt, e.IdTipoCbteCt, e.IdCbteCbleCt, e.SecuenciaCt, e.SecuenciaReg })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CxcCobroObra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdCobro })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<CxcCobroTipo>(entity =>
        {
            entity.HasKey(e => e.IdCobroTipo).HasName("PRIMARY");

            entity.Property(e => e.EsretenFte).IsFixedLength();
            entity.Property(e => e.EsretenIva).IsFixedLength();
            entity.Property(e => e.TcAbreviatura).IsFixedLength();
            entity.Property(e => e.TcSePuedeDepositar).IsFixedLength();

            entity.HasOne(d => d.IdMotivoTipoCobroNavigation).WithMany(p => p.CxcCobroTipo).HasConstraintName("FK_cxc_cobro_tipo_cxc_cobro_tipo_motivo");
        });

        modelBuilder.Entity<CxcCobroTipoMotivo>(entity =>
        {
            entity.HasKey(e => e.IdMotivoTipoCobro).HasName("PRIMARY");
        });

        modelBuilder.Entity<CxcCobroTipoParamContaXSucursal>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdCobroTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdCobroTipoNavigation).WithMany(p => p.CxcCobroTipoParamContaXSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_tipo_Param_conta_x_sucursal_cxc_cobro_tipo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.CxcCobroTipoParamContaXSucursalCtPlancta).HasConstraintName("FK_cxc_cobro_tipo_Param_conta_x_sucursal_ct_plancta");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.CxcCobroTipoParamContaXSucursalCtPlanctaNavigation).HasConstraintName("FK_cxc_cobro_tipo_Param_conta_x_sucursal_ct_plancta1");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CxcCobroTipoParamContaXSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_tipo_Param_conta_x_sucursal_tb_sucursal");
        });

        modelBuilder.Entity<CxcCobroTipoXAnticipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCobroTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdCobroTipoNavigation).WithMany(p => p.CxcCobroTipoXAnticipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_tipo_x_anticipo_cxc_cobro_tipo");
        });

        modelBuilder.Entity<CxcCobroTipoXCobrosDocxc>(entity =>
        {
            entity.HasKey(e => e.IdCobroTipo).HasName("PRIMARY");

            entity.HasOne(d => d.IdCobroTipoNavigation).WithOne(p => p.CxcCobroTipoXCobrosDocxc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_tipo_x_cobros_Docxc_cxc_cobro_tipo");
        });

        modelBuilder.Entity<CxcCobroXAnticipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAnticipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CajCaja).WithMany(p => p.CxcCobroXAnticipo).HasConstraintName("FK_cxc_cobro_x_Anticipo_caj_Caja");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.CxcCobroXAnticipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_Anticipo_fa_cliente");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.CxcCobroXAnticipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_Anticipo_tb_sucursal");
        });

        modelBuilder.Entity<CxcCobroXAnticipoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAnticipo, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdCobroTipoNavigation).WithMany(p => p.CxcCobroXAnticipoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_Anticipo_det_cxc_cobro_tipo");

            entity.HasOne(d => d.CxcCobroXAnticipo).WithMany(p => p.CxcCobroXAnticipoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_Anticipo_det_cxc_cobro_x_Anticipo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.CxcCobroXAnticipoDet).HasConstraintName("FK_cxc_cobro_x_Anticipo_det_ct_centro_costo");

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.CxcCobroXAnticipoDet).HasConstraintName("FK_cxc_cobro_x_Anticipo_det_cxc_cobro");
        });

        modelBuilder.Entity<CxcCobroXCajCajaMovimiento>(entity =>
        {
            entity.HasKey(e => new { e.CbrIdEmpresa, e.CbrIdSucursal, e.CbrIdCobro, e.McjIdEmpresa, e.McjIdCbteCble, e.McjIdTipocbte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.CxcCobroXCajCajaMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_caj_Caja_Movimiento_cxc_cobro");

            entity.HasOne(d => d.CajCajaMovimiento).WithMany(p => p.CxcCobroXCajCajaMovimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_caj_Caja_Movimiento_caj_Caja_Movimiento");
        });

        modelBuilder.Entity<CxcCobroXCtCbtecble>(entity =>
        {
            entity.HasKey(e => new { e.CbrIdEmpresa, e.CbrIdSucursal, e.CbrIdCobro, e.CtIdEmpresa, e.CtIdTipoCbte, e.CtIdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.CxcCobroXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_ct_cbtecble_cxc_cobro");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CxcCobroXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_ct_cbtecble_ct_cbtecble");
        });

        modelBuilder.Entity<CxcCobroXCtCbtecbleXAnulado>(entity =>
        {
            entity.HasKey(e => new { e.CbrIdEmpresa, e.CbrIdSucursal, e.CbrIdCobro, e.CtIdEmpresa, e.CtIdTipoCbte, e.CtIdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.CxcCobroXCtCbtecbleXAnulado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_ct_cbtecble_x_Anulado_cxc_cobro");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CxcCobroXCtCbtecbleXAnulado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_ct_cbtecble_x_Anulado_ct_cbtecble");
        });

        modelBuilder.Entity<CxcCobroXEstadoCobro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdCobro, e.IdEstadoCobro, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.IdEstadoCobroNavigation).WithMany(p => p.CxcCobroXEstadoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_EstadoCobro_cxc_EstadoCobro");

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.CxcCobroXEstadoCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_EstadoCobro_cxc_cobro");
        });

        modelBuilder.Entity<CxcCobroXTarjeta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdCobro, e.IdCobroTipo, e.IdCobroAplicado, e.IdCobroTipoAplicado, e.IdCbteVtaAplicado })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.CxcCobroXTarjeta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_cobro_x_tarjeta_cxc_cobro");
        });

        modelBuilder.Entity<CxcConciliacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdConciliacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.FaCliente).WithMany(p => p.CxcConciliacion).HasConstraintName("FK_cxc_conciliacion_fa_cliente");

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.CxcConciliacion).HasConstraintName("FK_cxc_conciliacion_ct_cbtecble");
        });

        modelBuilder.Entity<CxcConciliacionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdConciliacion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdTipoConciliacionNavigation).WithMany(p => p.CxcConciliacionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_conciliacion_det_cxc_conciliacion_tipo");

            entity.HasOne(d => d.CxcConciliacion).WithMany(p => p.CxcConciliacionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_conciliacion_det_cxc_conciliacion");

            entity.HasOne(d => d.CxcCobroDet).WithMany(p => p.CxcConciliacionDet).HasConstraintName("FK_cxc_conciliacion_det_cxc_cobro_det");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.CxcConciliacionDet).HasConstraintName("FK_cxc_conciliacion_det_fa_factura");

            entity.HasOne(d => d.FaNotaCreDeb).WithMany(p => p.CxcConciliacionDet).HasConstraintName("FK_cxc_conciliacion_det_fa_notaCreDeb");
        });

        modelBuilder.Entity<CxcConciliacionTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoConciliacion).HasName("PRIMARY");
        });

        modelBuilder.Entity<CxcCxcRpt017>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCbteVtaNota, e.DcTipoDocumento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<CxcEstadoCobro>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCobro).HasName("PRIMARY");
        });

        modelBuilder.Entity<CxcParametro>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.CxcParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_Parametro_tb_empresa");

            entity.HasOne(d => d.PaIdCobroTipoComisionTcNavigation).WithMany(p => p.CxcParametroPaIdCobroTipoComisionTcNavigation).HasConstraintName("FK_cxc_Parametro_cxc_cobro_tipo");

            entity.HasOne(d => d.PaIdCobroTipoDefaultNavigation).WithMany(p => p.CxcParametroPaIdCobroTipoDefaultNavigation).HasConstraintName("FK_cxc_Parametro_cxc_cobro_tipo1");

            entity.HasOne(d => d.PaIdTipoMoviCajaXCobrosXClienteNavigation).WithMany(p => p.CxcParametro).HasConstraintName("FK_cxc_Parametro_caj_Caja_Movimiento_Tipo");

            entity.HasOne(d => d.PaTipoNdXCheqProtestadoNavigation).WithMany(p => p.CxcParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_Parametro_fa_TipoNota");

            entity.HasOne(d => d.CajCaja).WithMany(p => p.CxcParametroCajCaja).HasConstraintName("FK_cxc_Parametro_caj_Caja");

            entity.HasOne(d => d.CajCajaNavigation).WithMany(p => p.CxcParametroCajCajaNavigation).HasConstraintName("FK_cxc_Parametro_caj_Caja1");

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.CxcParametroCtCbtecbleTipo).HasConstraintName("FK_cxc_Parametro_ct_cbtecble_tipo");

            entity.HasOne(d => d.CtCbtecbleTipoNavigation).WithMany(p => p.CxcParametroCtCbtecbleTipoNavigation).HasConstraintName("FK_cxc_Parametro_ct_cbtecble_tipo1");

            entity.HasOne(d => d.CtCbtecbleTipo1).WithMany(p => p.CxcParametroCtCbtecbleTipo1).HasConstraintName("FK_cxc_Parametro_ct_cbtecble_tipo2");
        });

        modelBuilder.Entity<CxcParametrosXCheqProtesto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CxcParametrosXCheqProtesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_Parametros_x_cheqProtesto_tb_empresa");

            entity.HasOne(d => d.InProducto).WithMany(p => p.CxcParametrosXCheqProtestoInProducto).HasConstraintName("FK_cxc_Parametros_x_cheqProtesto_in_Producto1");

            entity.HasOne(d => d.InProductoNavigation).WithMany(p => p.CxcParametrosXCheqProtestoInProductoNavigation).HasConstraintName("FK_cxc_Parametros_x_cheqProtesto_in_Producto");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.CxcParametrosXCheqProtesto).HasConstraintName("FK_cxc_Parametros_x_cheqProtesto_tb_bodega");
        });

        modelBuilder.Entity<CxcRangoDiasXVencimiento>(entity =>
        {
            entity.HasKey(e => e.IdRango).HasName("PRIMARY");
        });

        modelBuilder.Entity<CxcRetencionMultiple>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMultir })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<CxcRetencionMultipleDocumento>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMultir, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CxcRetencionMultiple).WithMany(p => p.CxcRetencionMultipleDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_retencion_Multiple_Documento_cxc_retencion_Multiple");
        });

        modelBuilder.Entity<CxcRetencionMultipleDocumentosValorAplicado>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMultir, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.CxcRetencionMultiple).WithMany(p => p.CxcRetencionMultipleDocumentosValorAplicado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cxc_retencion_Multiple_Documentos_ValorAplicado_cxc_retenci17");
        });

        modelBuilder.Entity<CxcRptTmpFactuNdNcCobroSp012>(entity =>
        {
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<FaCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogo).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdCatalogoTipoNavigation).WithMany(p => p.FaCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_catalogo_fa_catalogo_tipo");
        });

        modelBuilder.Entity<FaCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoTipo).HasName("PRIMARY");

            entity.Property(e => e.IdCatalogoTipo).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<FaCliente>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCliente })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.ClCatCrediticia).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdActividadComercialNavigation).WithMany(p => p.FaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_fa_catalogo");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.FaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_tb_ciudad");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.FaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_tb_empresa");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.FaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_tb_persona");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.FaClienteCtCentroCosto).HasConstraintName("FK_fa_cliente_ct_centro_costo1");

            entity.HasOne(d => d.CtCentroCostoNavigation).WithMany(p => p.FaClienteCtCentroCostoNavigation).HasConstraintName("FK_fa_cliente_ct_centro_costo");

            entity.HasOne(d => d.CtCentroCosto1).WithMany(p => p.FaClienteCtCentroCosto1).HasConstraintName("FK_fa_cliente_ct_centro_costo2");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.FaClienteCtPlancta).HasConstraintName("FK_fa_cliente_ct_plancta1");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.FaClienteCtPlanctaNavigation).HasConstraintName("FK_fa_cliente_ct_plancta");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.FaClienteCtPlancta1).HasConstraintName("FK_fa_cliente_ct_plancta2");

            entity.HasOne(d => d.FaClienteTipo).WithMany(p => p.FaCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_fa_cliente_tipo");
        });

        modelBuilder.Entity<FaClienteContactos>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaCli, e.IdCliente, e.IdEmpresaCont, e.IdContacto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaClienteContactos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_contactos_fa_cliente");

            entity.HasOne(d => d.TbContacto).WithMany(p => p.FaClienteContactos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_contactos_tb_contacto");
        });

        modelBuilder.Entity<FaClienteFiltro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCliente, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<FaClienteObra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCliente, e.IdCentroCosto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdEstadoObraNavigation).WithMany(p => p.FaClienteObra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_obra_fa_catalogo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.FaClienteObra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_obra_ct_centro_costo");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaClienteObra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cliente_obra_fa_cliente");
        });

        modelBuilder.Entity<FaClientePtoEmisionCliente>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCliente, e.IdPuntoEmision })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<FaClienteTipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdtipoCliente })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.FaClienteTipoCtPlancta).HasConstraintName("FK_fa_cliente_tipo_ct_plancta2");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.FaClienteTipoCtPlanctaNavigation).HasConstraintName("FK_fa_cliente_tipo_ct_plancta");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.FaClienteTipoCtPlancta1).HasConstraintName("FK_fa_cliente_tipo_ct_plancta1");
        });

        modelBuilder.Entity<FaCostoProductoVendido>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.TipoDoc, e.IdCbteVta, e.IdUsuario, e.IdProducto, e.IdCliente })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 255, 0, 0 });

            entity.HasIndex(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.TipoDoc, e.IdCbteVta, e.IdUsuario }, "index_fa_costo_producto_vendido").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 255 });
        });

        modelBuilder.Entity<FaCotizacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCotizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.CcEstado).IsFixedLength();
            entity.Property(e => e.CcTipopago).IsFixedLength();
            entity.Property(e => e.Ip).IsFixedLength();

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaCotizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cotizacion_fa_cliente");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaCotizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cotizacion_fa_Vendedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.FaCotizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cotizacion_tb_bodega");
        });

        modelBuilder.Entity<FaCotizacionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCotizacion, e.Secuencial })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.DcPagaIva).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.FaCotizacionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cotizacion_det_in_Producto");

            entity.HasOne(d => d.FaCotizacion).WithMany(p => p.FaCotizacionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_cotizacion_det_fa_cotizacion");
        });

        modelBuilder.Entity<FaDescuento>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDescuento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.FaDescuento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_descuento_ct_plancta");
        });

        modelBuilder.Entity<FaDevolVenta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdDevolucion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuario).IsFixedLength();

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaDevolVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_devol_venta_fa_cliente");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaDevolVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_devol_venta_fa_Vendedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.FaDevolVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_devol_venta_tb_bodega");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaDevolVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_devol_venta_fa_factura");

            entity.HasOne(d => d.FaNotaCreDeb).WithMany(p => p.FaDevolVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_devol_venta_fa_notaCreDeb");

            entity.HasOne(d => d.InMoviInve).WithMany(p => p.FaDevolVentaInMoviInve).HasConstraintName("FK_fa_devol_venta_in_movi_inve");

            entity.HasOne(d => d.InMoviInveNavigation).WithMany(p => p.FaDevolVentaInMoviInveNavigation).HasConstraintName("FK_fa_devol_venta_in_movi_inve1");
        });

        modelBuilder.Entity<FaDevolVentaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdDevolucion, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InProducto).WithMany(p => p.FaDevolVentaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_devol_venta_det_in_Producto");

            entity.HasOne(d => d.FaDevolVenta).WithMany(p => p.FaDevolVentaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_devol_venta_det_fa_devol_venta");
        });

        modelBuilder.Entity<FaFactura>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCbteVta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Id).IsFixedLength();

            entity.HasOne(d => d.VtMesNavigation).WithMany(p => p.FaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_tb_mes");

            entity.HasOne(d => d.CajCaja).WithMany(p => p.FaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_caj_Caja");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_fa_cliente");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.FaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_ct_periodo");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_fa_Vendedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.FaFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_tb_bodega");

            entity.HasOne(d => d.FaPuntoVta).WithMany(p => p.FaFactura).HasConstraintName("FK_fa_factura_fa_PuntoVta");

            entity.HasOne(d => d.FaNotaCreDeb).WithMany(p => p.FaFactura).HasConstraintName("FK_fa_factura_fa_notaCreDeb");

            entity.HasOne(d => d.TbSisDocumentoTipoTalonario).WithMany(p => p.FaFactura).HasConstraintName("FK_fa_factura_tb_sis_Documento_Tipo_Talonario");
        });

        modelBuilder.Entity<FaFacturaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCbteVta, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.VtEstado).IsFixedLength();

            entity.HasOne(d => d.IdCodImpuestoIceNavigation).WithMany(p => p.FaFacturaDetIdCodImpuestoIceNavigation).HasConstraintName("FK_fa_factura_det_tb_sis_Impuesto1");

            entity.HasOne(d => d.IdCodImpuestoIvaNavigation).WithMany(p => p.FaFacturaDetIdCodImpuestoIvaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_det_tb_sis_Impuesto");

            entity.HasOne(d => d.InProducto).WithMany(p => p.FaFacturaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_det_in_Producto");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_det_fa_factura");
        });

        modelBuilder.Entity<FaFacturaDetOtrosCampos>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCbteVta, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.FaFacturaDetOtrosCampos).HasConstraintName("FK_fa_factura_det_otros_campos_ct_punto_cargo");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaDetOtrosCampos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_det_otros_campos_fa_factura");
        });

        modelBuilder.Entity<FaFacturaDetXFaDescuento>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaFa, e.IdSucursal, e.IdBodega, e.IdCbteVta, e.Secuencia, e.IdEmpresaDe, e.IdDescuento, e.SecuenciaReg })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaDescuento).WithMany(p => p.FaFacturaDetXFaDescuento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_det_x_fa_descuento_fa_descuento");

            entity.HasOne(d => d.FaFacturaDet).WithMany(p => p.FaFacturaDetXFaDescuento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_det_x_fa_descuento_fa_factura_det");
        });

        modelBuilder.Entity<FaFacturaEdehsa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCbteVta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.FaFacturaEdehsa).HasConstraintName("FK_fa_factura_ct_centro_costo");

            entity.HasOne(d => d.FaFactura).WithOne(p => p.FaFacturaEdehsa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_fa_factura");
        });

        modelBuilder.Entity<FaFacturaXCtCbtecble>(entity =>
        {
            entity.HasKey(e => new { e.VtIdEmpresa, e.VtIdSucursal, e.VtIdBodega, e.VtIdCbteVta, e.CtIdEmpresa, e.CtIdTipoCbte, e.CtIdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.FaFacturaXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_ct_cbtecble_ct_cbtecble");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_ct_cbtecble_fa_factura");
        });

        modelBuilder.Entity<FaFacturaXFaCotizacion>(entity =>
        {
            entity.HasKey(e => new { e.FaIdEmpresa, e.FaIdSucursal, e.FaIdBodega, e.FaIdCbteVta, e.CcIdEmpresa, e.CcIdSucursal, e.CcIdBodega, e.CcIdCotizacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaCotizacion).WithMany(p => p.FaFacturaXFaCotizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_fa_cotizacion_fa_cotizacion");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaXFaCotizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_fa_cotizacion_fa_factura");
        });

        modelBuilder.Entity<FaFacturaXFaGuiaRemision>(entity =>
        {
            entity.HasKey(e => new { e.FaIdEmpresa, e.FaIdSucursal, e.FaIdBodega, e.FaIdCbteVta, e.GiIdEmpresa, e.GiIdSucursal, e.GiIdBodega, e.GiIdGuiaRemision })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaXFaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_fa_guia_remision_fa_factura");

            entity.HasOne(d => d.FaGuiaRemision).WithMany(p => p.FaFacturaXFaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_fa_guia_remision_fa_guia_remision");
        });

        modelBuilder.Entity<FaFacturaXFaTerminoPago>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCbteVta, e.IdTerminoPago, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<FaFacturaXFormaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdCbteVta, e.IdFormaPago })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.FaFacturaXFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_formaPago_fa_formaPago");

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaXFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_formaPago_fa_factura");
        });

        modelBuilder.Entity<FaFacturaXInIngEgrInven>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaFa, e.IdSucursalFa, e.IdBodegaFa, e.IdCbteVtaFa, e.IdEmpresaInEgXInv, e.IdSucursalInEgXInv, e.IdMoviInvenTipoInEgXInv, e.IdNumMoviInEgXInv })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaXInIngEgrInven)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_in_Ing_Egr_Inven_fa_factura");

            entity.HasOne(d => d.InIngEgrInven).WithMany(p => p.FaFacturaXInIngEgrInven)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_in_Ing_Egr_Inven_in_Ing_Egr_Inven");
        });

        modelBuilder.Entity<FaFacturaXInMoviInve>(entity =>
        {
            entity.HasKey(e => new { e.FaIdEmpresa, e.FaIdSucursal, e.FaIdBodega, e.FaIdCbteVta, e.InvIdEmpresa, e.InvIdSucursal, e.InvIdBodega, e.InvIdMoviInvenTipo, e.InvIdNumMovi })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaXInMoviInve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_in_movi_inve_fa_factura");

            entity.HasOne(d => d.InMoviInve).WithMany(p => p.FaFacturaXInMoviInve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_in_movi_inve_in_movi_inve");
        });

        modelBuilder.Entity<FaFacturaXInMoviInveXAnulacion>(entity =>
        {
            entity.HasKey(e => new { e.FaIdEmpresa, e.FaIdSucursal, e.FaIdBodega, e.FaIdCbteVta, e.InvIdEmpresa, e.InvIdSucursal, e.InvIdBodega, e.InvIdMoviInvenTipo, e.InvIdNumMovi })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaFactura).WithMany(p => p.FaFacturaXInMoviInveXAnulacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_in_movi_inve_x_Anulacion_fa_factura");

            entity.HasOne(d => d.InMoviInve).WithMany(p => p.FaFacturaXInMoviInveXAnulacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_factura_x_in_movi_inve_x_Anulacion_in_movi_inve");
        });

        modelBuilder.Entity<FaFiltroCliente>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdUsuario, e.IdCliente })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<FaFormaPago>(entity =>
        {
            entity.HasKey(e => e.IdFormaPago).HasName("PRIMARY");
        });

        modelBuilder.Entity<FaGuiaRemision>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdGuiaRemision })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Impreso).IsFixedLength();

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_fa_cliente");

            entity.HasOne(d => d.CtPeriodo).WithMany(p => p.FaGuiaRemision).HasConstraintName("FK_fa_guia_remision_ct_periodo");

            entity.HasOne(d => d.TbTransportista).WithMany(p => p.FaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_tb_transportista");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_fa_Vendedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.FaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_tb_bodega");

            entity.HasOne(d => d.TbSisDocumentoTipoTalonario).WithMany(p => p.FaGuiaRemision).HasConstraintName("FK_fa_guia_remision_tb_sis_Documento_Tipo_Talonario");
        });

        modelBuilder.Entity<FaGuiaRemisionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdGuiaRemision, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.GiDetallexItems).IsFixedLength();
            entity.Property(e => e.GiTieneIva).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.FaGuiaRemisionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_det_in_Producto");

            entity.HasOne(d => d.FaGuiaRemision).WithMany(p => p.FaGuiaRemisionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_det_fa_guia_remision");
        });

        modelBuilder.Entity<FaGuiaRemisionDetXFaFacturaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaGuia, e.IdSucursalGuia, e.IdBodegaGuia, e.IdGuiaRemisionGuia, e.SecuenciaGuia, e.IdEmpresaFact, e.IdSucursalFact, e.IdBodegaFact, e.IdCbteVtaFact, e.SecuenciaFact })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaFacturaDet).WithMany(p => p.FaGuiaRemisionDetXFaFacturaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_det_x_fa_factura_det_fa_factura_det");

            entity.HasOne(d => d.FaGuiaRemisionDet).WithMany(p => p.FaGuiaRemisionDetXFaFacturaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_det_x_fa_factura_det_fa_guia_remision_det");
        });

        modelBuilder.Entity<FaGuiaRemisionDetXFaOrdenDespDet>(entity =>
        {
            entity.HasKey(e => new { e.GiIdEmpresa, e.GiIdSucursal, e.GiIdBodega, e.GiIdGuiaRemision, e.GiSecuencia, e.GiIdProducto, e.OdIdEmpresa, e.OdIdSucursal, e.OdIdBodega, e.OdIdOrdenDespacho, e.OdSecuencia, e.OdIdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaGuiaRemisionDet).WithMany(p => p.FaGuiaRemisionDetXFaOrdenDespDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_det_x_fa_orden_Desp_det_fa_guia_remision_det");

            entity.HasOne(d => d.FaOrdenDespDet).WithMany(p => p.FaGuiaRemisionDetXFaOrdenDespDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_guia_remision_det_x_fa_orden_Desp_det_fa_orden_Desp_det");
        });

        modelBuilder.Entity<FaMotivoAprobacionPedidoVenta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMotivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<FaMotivoVenta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMotivoVta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<FaNotaCreDeb>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdNota })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NaturalezaNota).IsFixedLength();
            entity.Property(e => e.NoDevVenta).IsFixedLength();

            entity.HasOne(d => d.IdTipoNotaNavigation).WithMany(p => p.FaNotaCreDeb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_fa_TipoNota");

            entity.HasOne(d => d.CajCaja).WithMany(p => p.FaNotaCreDeb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_caj_Caja");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaNotaCreDeb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_fa_cliente");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.FaNotaCreDeb).HasConstraintName("FK_fa_notaCreDeb_ct_plancta");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaNotaCreDeb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_fa_Vendedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.FaNotaCreDeb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_tb_bodega");

            entity.HasOne(d => d.FaPuntoVta).WithMany(p => p.FaNotaCreDeb).HasConstraintName("FK_fa_notaCreDeb_fa_PuntoVta");

            entity.HasMany(d => d.InIngEgrInven).WithMany(p => p.FaNotaCreDeb)
                .UsingEntity<Dictionary<string, object>>(
                    "FaNotaCreDebXInIngEgrInven",
                    r => r.HasOne<InIngEgrInven>().WithMany()
                        .HasForeignKey("InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_fa_notaCreDeb_x_in_Ing_Egr_Inven_in_Ing_Egr_Inven"),
                    l => l.HasOne<FaNotaCreDeb>().WithMany()
                        .HasForeignKey("NoIdEmpresa", "NoIdSucursal", "NoIdBodega", "NoIdNota")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_fa_notaCreDeb_x_in_Ing_Egr_Inven_fa_notaCreDeb"),
                    j =>
                    {
                        j.HasKey("NoIdEmpresa", "NoIdSucursal", "NoIdBodega", "NoIdNota", "InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });
                        j
                            .ToTable("fa_notaCreDeb_x_in_Ing_Egr_Inven")
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi" }, "FK_fa_notaCreDeb_x_in_Ing_Egr_Inven_in_Ing_Egr_Inven");
                        j.IndexerProperty<int>("NoIdEmpresa").HasColumnName("no_IdEmpresa");
                        j.IndexerProperty<int>("NoIdSucursal").HasColumnName("no_IdSucursal");
                        j.IndexerProperty<int>("NoIdBodega").HasColumnName("no_IdBodega");
                        j.IndexerProperty<decimal>("NoIdNota")
                            .HasPrecision(18)
                            .HasColumnName("no_IdNota");
                        j.IndexerProperty<int>("InIdEmpresa").HasColumnName("in_IdEmpresa");
                        j.IndexerProperty<int>("InIdSucursal").HasColumnName("in_IdSucursal");
                        j.IndexerProperty<int>("InIdMoviInvenTipo").HasColumnName("in_IdMovi_inven_tipo");
                        j.IndexerProperty<decimal>("InIdNumMovi")
                            .HasPrecision(18)
                            .HasColumnName("in_IdNumMovi");
                    });
        });

        modelBuilder.Entity<FaNotaCreDebDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdNota, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.ScEstado).IsFixedLength();

            entity.HasOne(d => d.IdCodImpuestoIceNavigation).WithMany(p => p.FaNotaCreDebDetIdCodImpuestoIceNavigation).HasConstraintName("FK_fa_notaCreDeb_det_tb_sis_Impuesto1");

            entity.HasOne(d => d.IdCodImpuestoIvaNavigation).WithMany(p => p.FaNotaCreDebDetIdCodImpuestoIvaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_det_tb_sis_Impuesto");

            entity.HasOne(d => d.FaNotaCreDeb).WithMany(p => p.FaNotaCreDebDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_det_fa_notaCreDeb");

            entity.HasMany(d => d.InIngEgrInvenDet).WithMany(p => p.FaNotaCreDebDet)
                .UsingEntity<Dictionary<string, object>>(
                    "FaNotaCreDebDetXInIngEgrInvenDet",
                    r => r.HasOne<InIngEgrInvenDet>().WithMany()
                        .HasForeignKey("InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi", "InSecuencia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven_det"),
                    l => l.HasOne<FaNotaCreDebDet>().WithMany()
                        .HasForeignKey("NoIdEmpresa", "NoIdSucursal", "NoIdBodega", "NoIdNota", "NoSecuencia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_fa_notaCreDeb_det"),
                    j =>
                    {
                        j.HasKey("NoIdEmpresa", "NoIdSucursal", "NoIdBodega", "NoIdNota", "NoSecuencia", "InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi", "InSecuencia")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
                        j
                            .ToTable("fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det")
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi", "InSecuencia" }, "FK_fa_notaCreDeb_det_x_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven_det");
                        j.IndexerProperty<int>("NoIdEmpresa").HasColumnName("no_IdEmpresa");
                        j.IndexerProperty<int>("NoIdSucursal").HasColumnName("no_IdSucursal");
                        j.IndexerProperty<int>("NoIdBodega").HasColumnName("no_IdBodega");
                        j.IndexerProperty<decimal>("NoIdNota")
                            .HasPrecision(18)
                            .HasColumnName("no_IdNota");
                        j.IndexerProperty<int>("NoSecuencia").HasColumnName("no_Secuencia");
                        j.IndexerProperty<int>("InIdEmpresa").HasColumnName("in_IdEmpresa");
                        j.IndexerProperty<int>("InIdSucursal").HasColumnName("in_IdSucursal");
                        j.IndexerProperty<int>("InIdMoviInvenTipo").HasColumnName("in_IdMovi_inven_tipo");
                        j.IndexerProperty<decimal>("InIdNumMovi")
                            .HasPrecision(18)
                            .HasColumnName("in_IdNumMovi");
                        j.IndexerProperty<int>("InSecuencia").HasColumnName("in_Secuencia");
                    });

            entity.HasMany(d => d.InIngEgrInvenDetNavigation).WithMany(p => p.FaNotaCreDebDetNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "FaOrdenDespDetXInIngEgrInvenDet",
                    r => r.HasOne<InIngEgrInvenDet>().WithMany()
                        .HasForeignKey("InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi", "InSecuencia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_fa_orden_Desp_det_x_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven_det"),
                    l => l.HasOne<FaNotaCreDebDet>().WithMany()
                        .HasForeignKey("NoIdEmpresa", "NoIdSucursal", "NoIdBodega", "NoIdNota", "NoSecuencia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_fa_orden_Desp_det_x_in_Ing_Egr_Inven_det_fa_notaCreDeb_det"),
                    j =>
                    {
                        j.HasKey("NoIdEmpresa", "NoIdSucursal", "NoIdBodega", "NoIdNota", "NoSecuencia", "InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi", "InSecuencia")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
                        j
                            .ToTable("fa_orden_Desp_det_x_in_Ing_Egr_Inven_det")
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "InIdEmpresa", "InIdSucursal", "InIdMoviInvenTipo", "InIdNumMovi", "InSecuencia" }, "FK_fa_orden_Desp_det_x_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven_det");
                        j.IndexerProperty<int>("NoIdEmpresa").HasColumnName("no_IdEmpresa");
                        j.IndexerProperty<int>("NoIdSucursal").HasColumnName("no_IdSucursal");
                        j.IndexerProperty<int>("NoIdBodega").HasColumnName("no_IdBodega");
                        j.IndexerProperty<decimal>("NoIdNota")
                            .HasPrecision(18)
                            .HasColumnName("no_IdNota");
                        j.IndexerProperty<int>("NoSecuencia").HasColumnName("no_Secuencia");
                        j.IndexerProperty<int>("InIdEmpresa").HasColumnName("in_IdEmpresa");
                        j.IndexerProperty<int>("InIdSucursal").HasColumnName("in_IdSucursal");
                        j.IndexerProperty<int>("InIdMoviInvenTipo").HasColumnName("in_IdMovi_inven_tipo");
                        j.IndexerProperty<decimal>("InIdNumMovi")
                            .HasPrecision(18)
                            .HasColumnName("in_IdNumMovi");
                        j.IndexerProperty<int>("InSecuencia").HasColumnName("in_Secuencia");
                    });
        });

        modelBuilder.Entity<FaNotaCreDebEdehsa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdNota })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<FaNotaCreDebSubtotalIvas>(entity =>
        {
            entity.ToView("fa_notaCreDeb_Subtotal_Ivas");
        });

        modelBuilder.Entity<FaNotaCreDebXCtCbtecble>(entity =>
        {
            entity.HasKey(e => new { e.NoIdEmpresa, e.NoIdSucursal, e.NoIdBodega, e.NoIdNota, e.CtIdEmpresa, e.CtIdTipoCbte, e.CtIdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.FaNotaCreDebXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_x_ct_cbtecble_ct_cbtecble");

            entity.HasOne(d => d.FaNotaCreDeb).WithMany(p => p.FaNotaCreDebXCtCbtecble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_x_ct_cbtecble_fa_notaCreDeb");
        });

        modelBuilder.Entity<FaNotaCreDebXCxcCobro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaCbr, e.IdSucursalCbr, e.IdCobroCbr, e.IdEmpresaNt, e.IdSucursalNt, e.IdBodegaNt, e.IdNotaNt })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CxcCobro).WithMany(p => p.FaNotaCreDebXCxcCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_x_cxc_cobro_cxc_cobro");

            entity.HasOne(d => d.FaNotaCreDeb).WithMany(p => p.FaNotaCreDebXCxcCobro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_notaCreDeb_x_cxc_cobro_fa_notaCreDeb");
        });

        modelBuilder.Entity<FaNotaCreDebXFaFacturaNotaDeb>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaNt, e.IdSucursalNt, e.IdBodegaNt, e.IdNotaNt, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<FaOrdenDesp>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdOrdenDespacho })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.OdDespAbierto).IsFixedLength();

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaOrdenDesp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_orden_Desp_fa_cliente");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaOrdenDesp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_orden_Desp_fa_Vendedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.FaOrdenDesp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_orden_Desp_tb_bodega");
        });

        modelBuilder.Entity<FaOrdenDespDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdOrdenDespacho, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.OdDetallexItems).IsFixedLength();
            entity.Property(e => e.OdTieneIva).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.FaOrdenDespDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_orden_Desp_det_in_Producto");

            entity.HasOne(d => d.FaOrdenDesp).WithMany(p => p.FaOrdenDespDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_orden_Desp_det_fa_orden_Desp");
        });

        modelBuilder.Entity<FaOrdenDespDetXFaPedidoDet>(entity =>
        {
            entity.HasKey(e => new { e.OdIdEmpresa, e.OdIdSucursal, e.OdIdBodega, e.OdIdOrdenDespacho, e.OdSecuencia, e.PeIdEmpresa, e.PeIdSucursal, e.PeIdBodega, e.PeIdPedido, e.PeSecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.FaOrdenDespDet).WithMany(p => p.FaOrdenDespDetXFaPedidoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_orden_Desp_det_x_fa_pedido_det_fa_orden_Desp_det");

            entity.HasOne(d => d.FaPedidoDet).WithMany(p => p.FaOrdenDespDetXFaPedidoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_orden_Desp_det_x_fa_pedido_det_fa_pedido_det");
        });

        modelBuilder.Entity<FaParametro>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();
            entity.Property(e => e.IdEstadoAprobacion).IsFixedLength();
            entity.Property(e => e.SeImprimiGuiaRemiAuto).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithOne(p => p.FaParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_parametro_tb_empresa");

            entity.HasOne(d => d.IdEstadoAprobacionNavigation).WithMany(p => p.FaParametro).HasConstraintName("FK_fa_parametro_fa_pedido_estadoAprobacion");

            entity.HasOne(d => d.PaIdTipoNotaNcXAnulacionNavigation).WithMany(p => p.FaParametro).HasConstraintName("FK_fa_parametro_fa_TipoNota");

            entity.HasOne(d => d.TipoCobroDafaultFactuNavigation).WithMany(p => p.FaParametro).HasConstraintName("FK_fa_parametro_cxc_cobro_tipo");

            entity.HasOne(d => d.CajCaja).WithMany(p => p.FaParametro).HasConstraintName("FK_fa_parametro_caj_Caja");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.FaParametroCtPlancta).HasConstraintName("FK_fa_parametro_ct_plancta1");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.FaParametroCtPlanctaNavigation).HasConstraintName("FK_fa_parametro_ct_plancta");

            entity.HasOne(d => d.InMoviInvenTipo).WithMany(p => p.FaParametroInMoviInvenTipo).HasConstraintName("FK_fa_parametro_in_movi_inven_tipo1");

            entity.HasOne(d => d.InMoviInvenTipoNavigation).WithMany(p => p.FaParametroInMoviInvenTipoNavigation).HasConstraintName("FK_fa_parametro_in_movi_inven_tipo3");

            entity.HasOne(d => d.InMoviInvenTipo1).WithMany(p => p.FaParametroInMoviInvenTipo1).HasConstraintName("FK_fa_parametro_in_movi_inven_tipo");

            entity.HasOne(d => d.InMoviInvenTipo2).WithMany(p => p.FaParametroInMoviInvenTipo2).HasConstraintName("FK_fa_parametro_in_movi_inven_tipo2");

            entity.HasOne(d => d.CtCbtecbleTipo).WithMany(p => p.FaParametroCtCbtecbleTipo).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo");

            entity.HasOne(d => d.CtCbtecbleTipoNavigation).WithMany(p => p.FaParametroCtCbtecbleTipoNavigation).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo2");

            entity.HasOne(d => d.CtCbtecbleTipo1).WithMany(p => p.FaParametroCtCbtecbleTipo1).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo3");

            entity.HasOne(d => d.CtCbtecbleTipo2).WithMany(p => p.FaParametroCtCbtecbleTipo2).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo1");

            entity.HasOne(d => d.CtCbtecbleTipo3).WithMany(p => p.FaParametroCtCbtecbleTipo3).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo4");

            entity.HasOne(d => d.CtCbtecbleTipo4).WithMany(p => p.FaParametroCtCbtecbleTipo4).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo5");

            entity.HasOne(d => d.CtCbtecbleTipo5).WithMany(p => p.FaParametroCtCbtecbleTipo5).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo6");

            entity.HasOne(d => d.CtCbtecbleTipo6).WithMany(p => p.FaParametroCtCbtecbleTipo6).HasConstraintName("FK_fa_parametro_ct_cbtecble_tipo7");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.FaParametroCtPlancta1).HasConstraintName("FK_fa_parametro_ct_plancta2");
        });

        modelBuilder.Entity<FaPedido>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdPedido })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.CpTipopago).IsFixedLength();
            entity.Property(e => e.Entregado).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion).IsFixedLength();

            entity.HasOne(d => d.IdEstadoAprobacionNavigation).WithMany(p => p.FaPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_pedido_fa_pedido_estadoAprobacion");

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_pedido_fa_cliente");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_pedido_fa_Vendedor");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.FaPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_pedido_tb_bodega");
        });

        modelBuilder.Entity<FaPedidoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdPedido, e.Secuencial })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.DpEstado).IsFixedLength();
            entity.Property(e => e.DpPagaIva).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.FaPedidoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_pedido_det_in_Producto");

            entity.HasOne(d => d.FaPedido).WithMany(p => p.FaPedidoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_pedido_det_fa_pedido");
        });

        modelBuilder.Entity<FaPedidoEstadoAprobacion>(entity =>
        {
            entity.HasKey(e => e.IdEstadoAprobacion).HasName("PRIMARY");

            entity.Property(e => e.IdEstadoAprobacion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<FaPedidoXFormaPago>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdPedido, e.IdTipoFormaPago, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.IdTipoFormaPagoNavigation).WithMany(p => p.FaPedidoXFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_pedido_x_formaPago_fa_TerminoPago");
        });

        modelBuilder.Entity<FaPuntoVta>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdPuntoVta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.FaPuntoVta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_PuntoVta_tb_sucursal");
        });

        modelBuilder.Entity<FaTerminoPago>(entity =>
        {
            entity.HasKey(e => e.IdTerminoPago).HasName("PRIMARY");
        });

        modelBuilder.Entity<FaTerminoPagoDistribucion>(entity =>
        {
            entity.HasKey(e => new { e.IdTerminoPago, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdTerminoPagoNavigation).WithMany(p => p.FaTerminoPagoDistribucion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_TerminoPago_Distribucion_fa_TerminoPago");
        });

        modelBuilder.Entity<FaTipoNota>(entity =>
        {
            entity.HasKey(e => e.IdTipoNota).HasName("PRIMARY");

            entity.Property(e => e.IdTipoNota).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.InternoSis).IsFixedLength();
            entity.Property(e => e.SeDeclaraSri).IsFixedLength();
            entity.Property(e => e.Tipo).IsFixedLength();
        });

        modelBuilder.Entity<FaTipoNotaXEmpresaXSucursal>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdTipoNota })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdTipoNotaNavigation).WithMany(p => p.FaTipoNotaXEmpresaXSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_TipoNota_x_Empresa_x_Sucursal_fa_TipoNota");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.FaTipoNotaXEmpresaXSucursal).HasConstraintName("FK_fa_TipoNota_x_Empresa_x_Sucursal_ct_plancta");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.FaTipoNotaXEmpresaXSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_TipoNota_x_Empresa_x_Sucursal_tb_sucursal");
        });

        modelBuilder.Entity<FaVendedor>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdVendedor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.FaVendedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_Vendedor_tb_empresa");
        });

        modelBuilder.Entity<FaVendedorXRoEmpleado>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdVendedor, e.IdEmpleado })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaVendedorXRoEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_vendedor_x_ro_empleado_fa_Vendedor");
        });

        modelBuilder.Entity<FaVendedorxSucursal>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdVendedor, e.IdSucursal })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.FaVendedorxSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_VendedorxSucursal_tb_sucursal");

            entity.HasOne(d => d.FaVendedor).WithMany(p => p.FaVendedorxSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_VendedorxSucursal_fa_Vendedor");
        });

        modelBuilder.Entity<FaVentaTelefonica>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdVentaTel })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.ContactarFuturo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.FaCliente).WithMany(p => p.FaVentaTelefonica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_venta_telefonica_fa_cliente");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.FaVentaTelefonica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_venta_telefonica_tb_sucursal");
        });

        modelBuilder.Entity<FaVentaTelefonicaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdVentaTel, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.InProducto).WithMany(p => p.FaVentaTelefonicaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_venta_telefonica_det_in_Producto");

            entity.HasOne(d => d.FaVentaTelefonica).WithMany(p => p.FaVentaTelefonicaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_fa_venta_telefonica_det_fa_venta_telefonica");
        });

        modelBuilder.Entity<InAjusteFisico>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAjusteFisico })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEstadoAprobacionNavigation).WithMany(p => p.InAjusteFisico).HasConstraintName("FK_in_ajusteFisico_in_Catalogo");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InAjusteFisico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_ajusteFisico_tb_bodega");
        });

        modelBuilder.Entity<InAjusteFisicoDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAjusteFisico, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InAjusteFisico).WithMany(p => p.InAjusteFisicoDetalle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_AjusteFisico_Detalle_in_ajusteFisico");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InAjusteFisicoDetalle).HasConstraintName("FK_in_AjusteFisico_Detalle_ct_centro_costo");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InAjusteFisicoDetalle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_AjusteFisico_Detalle_in_Producto");
        });

        modelBuilder.Entity<InCatalogo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogo).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdCatalogoTipoNavigation).WithMany(p => p.InCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Catalogo_in_CatalogoTipo");
        });

        modelBuilder.Entity<InCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoTipo).HasName("PRIMARY");

            entity.Property(e => e.IdCatalogoTipo).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<InCategoriaXFormula>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria, e.IdLinea })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Densidad).HasDefaultValueSql("'7850'");
        });

        modelBuilder.Entity<InCategorias>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.InCategorias)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_categorias_tb_empresa");
        });

        modelBuilder.Entity<InCategoriasFilter>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<InDevolucionInven>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDevInven })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<InDevolucionInvenDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDevInven, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InDevolucionInven).WithMany(p => p.InDevolucionInvenDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_devolucion_inven_det_in_devolucion_inven");

            entity.HasOne(d => d.InMoviInveDetalle).WithMany(p => p.InDevolucionInvenDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_devolucion_inven_det_in_movi_inve_detalle");
        });

        modelBuilder.Entity<InEgresoDSuministro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursa, e.IdBodega, e.IdEgresoSumin })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<InGrupo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria, e.IdLinea, e.IdGrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.InLinea).WithMany(p => p.InGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_grupo_in_linea");
        });

        modelBuilder.Entity<InGuiaRemision>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdGuiaRemision })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NumDocumento).IsFixedLength();
            entity.Property(e => e.Serie1).IsFixedLength();
            entity.Property(e => e.Serie2).IsFixedLength();

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InGuiaRemision).HasConstraintName("FK_in_GuiaRemision_ct_centro_costo");

            entity.HasOne(d => d.InGuiaRemisionMotivo).WithMany(p => p.InGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_GuiaRemision_in_GuiaRemision_Motivo");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InGuiaRemision).HasConstraintName("FK_in_GuiaRemision_tb_bodega");
        });

        modelBuilder.Entity<InGuiaRemisionDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdGuiaRemision, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.InGuiaRemisionDet).HasConstraintName("FK_in_GuiaRemision_Det_in_UnidadMedida");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InGuiaRemisionDet).HasConstraintName("FK_in_GuiaRemision_Det_ct_centro_costo");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InGuiaRemisionDet).HasConstraintName("FK_in_GuiaRemision_Det_in_Producto");

            entity.HasOne(d => d.InGuiaRemision).WithMany(p => p.InGuiaRemisionDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_GuiaRemision_Det_in_GuiaRemision");
        });

        modelBuilder.Entity<InGuiaRemisionExportacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdGuiaRemision })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InGuiaRemision).WithOne(p => p.InGuiaRemisionExportacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_GuiaRemision_Exportacion_in_GuiaRemision");
        });

        modelBuilder.Entity<InGuiaRemisionMotivo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMotivo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<InGuiaXTraspasoBodega>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdGuia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdMotivoTrasladoNavigation).WithMany(p => p.InGuiaXTraspasoBodega).HasConstraintName("FK_in_Guia_x_traspaso_bodega_in_Catalogo");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.InGuiaXTraspasoBodegaTbSucursal).HasConstraintName("FK_in_Guia_x_traspaso_bodega_tb_sucursal1");

            entity.HasOne(d => d.TbSucursalNavigation).WithMany(p => p.InGuiaXTraspasoBodegaTbSucursalNavigation).HasConstraintName("FK_in_Guia_x_traspaso_bodega_tb_sucursal");

            entity.HasOne(d => d.TbTransportista).WithMany(p => p.InGuiaXTraspasoBodega).HasConstraintName("FK_in_Guia_x_traspaso_bodega_tb_transportista");

            entity.HasOne(d => d.TbSisDocumentoTipoTalonario).WithMany(p => p.InGuiaXTraspasoBodega).HasConstraintName("FK_in_Guia_x_traspaso_bodega_tb_sis_Documento_Tipo_Talonario");
        });

        modelBuilder.Entity<InGuiaXTraspasoBodegaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdGuia, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InGuiaXTraspasoBodega).WithMany(p => p.InGuiaXTraspasoBodegaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Guia_x_traspaso_bodega_det_in_Guia_x_traspaso_bodega");

            entity.HasOne(d => d.ComOrdencompraLocalDet).WithMany(p => p.InGuiaXTraspasoBodegaDet).HasConstraintName("FK_in_Guia_x_traspaso_bodega_det_com_ordencompra_local_det");
        });

        modelBuilder.Entity<InGuiaXTraspasoBodegaDetSinOc>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdGuia, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InGuiaXTraspasoBodega).WithMany(p => p.InGuiaXTraspasoBodegaDetSinOc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Guia_x_traspaso_bodega_det_sin_oc_in_Guia_x_traspaso_bod10");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InGuiaXTraspasoBodegaDetSinOc).HasConstraintName("FK_in_Guia_x_traspaso_bodega_det_sin_oc_in_Producto");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.InGuiaXTraspasoBodegaDetSinOc).HasConstraintName("FK_in_Guia_x_traspaso_bodega_det_sin_oc_cp_proveedor");
        });

        modelBuilder.Entity<InGuiaXTraspasoBodegaXInTransferenciaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdGuia, e.IdEmpresaTras, e.IdSucursalOrigen, e.IdBodegaOrigen, e.IdTransferencia, e.DtSecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InGuiaXTraspasoBodega).WithMany(p => p.InGuiaXTraspasoBodegaXInTransferenciaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Guia_x_traspaso_bodega_x_in_transferencia_det_in_Guia_x_13");

            entity.HasOne(d => d.InTransferenciaDet).WithMany(p => p.InGuiaXTraspasoBodegaXInTransferenciaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Guia_x_traspaso_bodega_x_in_transferencia_det_in_transfe14");
        });

        modelBuilder.Entity<InIngEgrInven>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdMoviInvenTipo, e.IdNumMovi })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InIngEgrInven).HasConstraintName("FK_in_Ing_Egr_Inven_ct_centro_costo");

            entity.HasOne(d => d.InMotivoInven).WithMany(p => p.InIngEgrInven).HasConstraintName("FK_in_Ing_Egr_Inven_in_Motivo_Inven");

            entity.HasOne(d => d.ComMotivoOrdenCompra).WithMany(p => p.InIngEgrInven).HasConstraintName("FK_in_Ing_Egr_Inven_com_Motivo_Orden_Compra");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.InIngEgrInven)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_tb_sucursal");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.InIngEgrInven).HasConstraintName("FK_in_Ing_Egr_Inven_ct_centro_costo_sub_centro_costo");
        });

        modelBuilder.Entity<InIngEgrInvenDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdMoviInvenTipo, e.IdNumMovi, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.IdEstadoAprobaNavigation).WithMany(p => p.InIngEgrInvenDet).HasConstraintName("FK_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven_estado_apro");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.InIngEgrInvenDetIdUnidadMedidaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_det_in_UnidadMedida2");

            entity.HasOne(d => d.IdUnidadMedidaSinConversionNavigation).WithMany(p => p.InIngEgrInvenDetIdUnidadMedidaSinConversionNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_det_in_UnidadMedida3");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InIngEgrInvenDet).HasConstraintName("FK_in_Ing_Egr_Inven_det_ct_centro_costo");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InIngEgrInvenDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_det_in_Producto");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.InIngEgrInvenDet).HasConstraintName("FK_in_Ing_Egr_Inven_det_ct_punto_cargo");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.InIngEgrInvenDet).HasConstraintName("FK_in_Ing_Egr_Inven_det_ct_centro_costo_sub_centro_costo");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InIngEgrInvenDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_det_tb_bodega");

            entity.HasOne(d => d.InIngEgrInven).WithMany(p => p.InIngEgrInvenDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_det_in_Ing_Egr_Inven");

            entity.HasOne(d => d.InGuiaRemisionDet).WithMany(p => p.InIngEgrInvenDet).HasConstraintName("FK_in_Ing_Egr_Inven_det_in_GuiaRemision_Det");

            entity.HasOne(d => d.ComOrdencompraLocalDet).WithMany(p => p.InIngEgrInvenDet).HasConstraintName("FK_in_Ing_Egr_Inven_det_com_ordencompra_local_det");

            entity.HasOne(d => d.InMoviInveDetalle).WithMany(p => p.InIngEgrInvenDet).HasConstraintName("FK_in_Ing_Egr_Inven_det_in_movi_inve_detalle");
        });

        modelBuilder.Entity<InIngEgrInvenDetXPrdOrdenTrabajoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaInv, e.IdSucursalInv, e.IdMoviInvenTipoInv, e.IdNumMoviInv, e.SecuenciaInv, e.IdEmpresaOt, e.IdSucursalOt, e.IdOrdenTrabajoOt, e.SecuenciaOt })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InIngEgrInvenEstadoApro>(entity =>
        {
            entity.HasKey(e => e.IdEstadoAproba).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<InIngEgrInvenXInGuiaRemision>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdMoviInvenTipo, e.IdNumMovi, e.IdGuiaRemision })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InGuiaRemision).WithMany(p => p.InIngEgrInvenXInGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_x_in_GuiaRemision_in_GuiaRemision");

            entity.HasOne(d => d.InIngEgrInven).WithMany(p => p.InIngEgrInvenXInGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_x_in_GuiaRemision_in_Ing_Egr_Inven");
        });

        modelBuilder.Entity<InIngEgrInvenXInRequerimientoMaterial>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdMoviInvenTipo, e.IdNumMovi })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InIngEgrInvenXInRequerimientoMaterial).HasConstraintName("FK_in_Ing_Egr_Inven_x_in_RequerimientoMaterial_tb_bodega");

            entity.HasOne(d => d.InIngEgrInven).WithOne(p => p.InIngEgrInvenXInRequerimientoMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Ing_Egr_Inven_x_in_RequerimientoMaterial_in_Ing_Egr_Inven");
        });

        modelBuilder.Entity<InInvRpt010>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InInvRpt026>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.InInvRpt026)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_INV_Rpt026_in_UnidadMedida");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InInvRpt026)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_INV_Rpt026_in_Producto");

            entity.HasOne(d => d.InLinea).WithMany(p => p.InInvRpt026)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_INV_Rpt026_in_linea");
        });

        modelBuilder.Entity<InInvRpt027>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InKardex>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InKardex)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_kardex_tb_bodega");
        });

        modelBuilder.Entity<InKardexDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.KrTipo).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.InKardexDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_kardex_det_in_Producto");

            entity.HasOne(d => d.InKardex).WithMany(p => p.InKardexDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_kardex_det_in_kardex");
        });

        modelBuilder.Entity<InLinea>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria, e.IdLinea })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.InCategorias).WithMany(p => p.InLinea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_linea_in_categorias");
        });

        modelBuilder.Entity<InLineaFilter>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria, e.IdLinea, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InMarca>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMarca })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.InMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Marca_tb_empresa");
        });

        modelBuilder.Entity<InMarcaFiltro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.Codigo, e.IdMarca })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InMarca).WithMany(p => p.InMarcaFiltro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Marca_filtro_in_Marca");
        });

        modelBuilder.Entity<InMotivoInven>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMotivoInv })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ExigirPuntoCargo).IsFixedLength();
            entity.Property(e => e.GeneraCxp).IsFixedLength();
            entity.Property(e => e.GeneraMoviInven).IsFixedLength();

            entity.HasOne(d => d.EsInvenOConsumoNavigation).WithMany(p => p.InMotivoInvenEsInvenOConsumoNavigation).HasConstraintName("FK_in_Motivo_Inven_in_Catalogo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.InMotivoInven)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Motivo_Inven_tb_empresa");

            entity.HasOne(d => d.TipoIngEgrNavigation).WithMany(p => p.InMotivoInvenTipoIngEgrNavigation).HasConstraintName("FK_in_Motivo_Inven_in_Catalogo1");
        });

        modelBuilder.Entity<InMoviInve>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdNumMovi })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.CmTipo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CmMesNavigation).WithMany(p => p.InMoviInve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_tb_mes");

            entity.HasOne(d => d.IdEstadoDespachoCatNavigation).WithMany(p => p.InMoviInve).HasConstraintName("FK_in_movi_inve_in_Catalogo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InMoviInve).HasConstraintName("FK_in_movi_inve_ct_centro_costo");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.InMoviInve).HasConstraintName("FK_in_movi_inve_ct_plancta");

            entity.HasOne(d => d.InMotivoInven).WithMany(p => p.InMoviInve).HasConstraintName("FK_in_movi_inve_in_Motivo_Inven");

            entity.HasOne(d => d.InMoviInvenTipo).WithMany(p => p.InMoviInve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_in_movi_inven_tipo");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.InMoviInve).HasConstraintName("FK_in_movi_inve_ct_centro_costo_sub_centro_costo");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InMoviInve)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_tb_bodega");

            entity.HasOne(d => d.InMoviInveNavigation).WithMany(p => p.InverseInMoviInveNavigation).HasConstraintName("FK_in_movi_inve_in_movi_inve");
        });

        modelBuilder.Entity<InMoviInveDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdNumMovi, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.InMoviInveDetalleIdUnidadMedidaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_in_UnidadMedida");

            entity.HasOne(d => d.IdUnidadMedidaSinConversionNavigation).WithMany(p => p.InMoviInveDetalleIdUnidadMedidaSinConversionNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_in_UnidadMedida1");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InMoviInveDetalle).HasConstraintName("FK_in_movi_inve_detalle_ct_centro_costo");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InMoviInveDetalle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_in_Producto");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.InMoviInveDetalle).HasConstraintName("FK_in_movi_inve_detalle_ct_centro_costo_sub_centro_costo");

            entity.HasOne(d => d.InMoviInve).WithMany(p => p.InMoviInveDetalle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_in_movi_inve");
        });

        modelBuilder.Entity<InMoviInveDetalleXComOrdencompraLocalDet>(entity =>
        {
            entity.HasKey(e => new { e.MiIdEmpresa, e.MiIdSucursal, e.MiIdBodega, e.MiIdMoviInvenTipo, e.MiIdNumMovi, e.MiSecuencia, e.OcdIdEmpresa, e.OcdIdSucursal, e.OcdIdOrdenCompra, e.OcdSecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.ComOrdencompraLocalDet).WithMany(p => p.InMoviInveDetalleXComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_x_com_ordencompra_local_det_com_ordenc18");

            entity.HasOne(d => d.InMoviInveDetalle).WithMany(p => p.InMoviInveDetalleXComOrdencompraLocalDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_x_com_ordencompra_local_det_in_movi_in19");
        });

        modelBuilder.Entity<InMoviInveDetalleXCtCbtecbleDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaInv, e.IdSucursalInv, e.IdBodegaInv, e.IdMoviInvenTipoInv, e.IdNumMoviInv, e.SecuenciaInv, e.IdEmpresaCt, e.IdTipoCbteCt, e.IdCbteCbleCt, e.SecuenciaCt, e.SecuencialReg })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InMoviInveXCtCbteCble).WithMany(p => p.InMoviInveDetalleXCtCbtecbleDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_x_ct_cbtecble_det_in_movi_inve_x_ct_cb21");
        });

        modelBuilder.Entity<InMoviInveDetalleXItem>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdNumMovi, e.Secuencia, e.SecuenciaReg })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InMoviInveDetalle).WithMany(p => p.InMoviInveDetalleXItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_detalle_x_item_in_movi_inve_detalle");
        });

        modelBuilder.Entity<InMoviInveXCtCbteCble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdNumMovi, e.IdTipoCbte, e.IdCbteCble, e.IdEmpresaCt })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CtCbtecble).WithMany(p => p.InMoviInveXCtCbteCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_x_ct_cbteCble_ct_cbtecble");

            entity.HasOne(d => d.InMoviInve).WithMany(p => p.InMoviInveXCtCbteCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_x_ct_cbteCble_in_movi_inve");
        });

        modelBuilder.Entity<InMoviInveXInOrdencompraLocal>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdNumMovi, e.IdEmpresaOc, e.IdSucursalOc, e.IdOrdenCompra })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.ComOrdencompraLocal).WithMany(p => p.InMoviInveXInOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_x_in_ordencompra_local_com_ordencompra_local");

            entity.HasOne(d => d.InMoviInve).WithMany(p => p.InMoviInveXInOrdencompraLocal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inve_x_in_ordencompra_local_in_movi_inve");
        });

        modelBuilder.Entity<InMoviInvenParaRecosteoCtCbteCble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte, e.IdCbteCble, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InMoviInvenTipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMoviInvenTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.CmInterno).IsFixedLength();
            entity.Property(e => e.CmTipoMovi).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<InMoviInvenTipoXTbBodega>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMoviInvenTipo, e.IdSucucursal, e.IdBodega })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.InMoviInvenTipoXTbBodega).HasConstraintName("FK_in_movi_inven_tipo_x_tb_bodega_ct_plancta");

            entity.HasOne(d => d.InMoviInvenTipo).WithMany(p => p.InMoviInvenTipoXTbBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inven_tipo_x_tb_bodega_in_movi_inven_tipo");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InMoviInvenTipoXTbBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_movi_inven_tipo_x_tb_bodega_tb_bodega");
        });

        modelBuilder.Entity<InMoviInvenXImpOrdCompraExterna>(entity =>
        {
            entity.HasKey(e => new { e.ImpIdEmpresa, e.ImpIdSucursal, e.ImpIdOrdenCompraExt, e.InIdEmpresa, e.InIdSucursal, e.InIdBodega, e.InIdMoviInvenTipo, e.InIdNumMovi })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InParametro>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

            entity.HasOne(d => d.IdEstadoAprobaXEgrNavigation).WithMany(p => p.InParametroIdEstadoAprobaXEgrNavigation).HasConstraintName("FK_in_parametro_in_Ing_Egr_Inven_estado_apro1");

            entity.HasOne(d => d.IdEstadoAprobaXIngNavigation).WithMany(p => p.InParametroIdEstadoAprobaXIngNavigation).HasConstraintName("FK_in_parametro_in_Ing_Egr_Inven_estado_apro");

            entity.HasOne(d => d.PAlContaCtaCostoBuscarEnNavigation).WithMany(p => p.InParametroPAlContaCtaCostoBuscarEnNavigation).HasConstraintName("FK_in_parametro_in_Catalogo1");

            entity.HasOne(d => d.PAlContaCtaInvenBuscarEnNavigation).WithMany(p => p.InParametroPAlContaCtaInvenBuscarEnNavigation).HasConstraintName("FK_in_parametro_in_Catalogo");

            entity.HasOne(d => d.CtCentroCosto).WithMany(p => p.InParametroCtCentroCosto).HasConstraintName("FK_in_parametro_ct_centro_costo");

            entity.HasOne(d => d.CtCentroCostoNavigation).WithMany(p => p.InParametroCtCentroCostoNavigation).HasConstraintName("FK_in_parametro_ct_centro_costo1");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.InParametroCtPlancta).HasConstraintName("FK_in_parametro_ct_plancta1");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.InParametroCtPlanctaNavigation).HasConstraintName("FK_in_parametro_ct_plancta");

            entity.HasOne(d => d.InMoviInvenTipo).WithMany(p => p.InParametroInMoviInvenTipo).HasConstraintName("FK_in_parametro_in_movi_inven_tipo9");

            entity.HasOne(d => d.InMoviInvenTipoNavigation).WithMany(p => p.InParametroInMoviInvenTipoNavigation).HasConstraintName("FK_in_parametro_in_movi_inven_tipo5");

            entity.HasOne(d => d.InMoviInvenTipo1).WithMany(p => p.InParametroInMoviInvenTipo1).HasConstraintName("FK_in_parametro_in_movi_inven_tipo2");

            entity.HasOne(d => d.InMoviInvenTipo2).WithMany(p => p.InParametroInMoviInvenTipo2).HasConstraintName("FK_in_parametro_in_movi_inven_tipo8");

            entity.HasOne(d => d.InMoviInvenTipo3).WithMany(p => p.InParametroInMoviInvenTipo3).HasConstraintName("FK_in_parametro_in_movi_inven_tipo4");

            entity.HasOne(d => d.InMoviInvenTipo4).WithMany(p => p.InParametroInMoviInvenTipo4).HasConstraintName("FK_in_parametro_in_movi_inven_tipo1");

            entity.HasOne(d => d.InMoviInvenTipo5).WithMany(p => p.InParametroInMoviInvenTipo5).HasConstraintName("FK_in_parametro_in_movi_inven_tipo");

            entity.HasOne(d => d.InMoviInvenTipo6).WithMany(p => p.InParametroInMoviInvenTipo6).HasConstraintName("FK_in_parametro_in_movi_inven_tipo7");

            entity.HasOne(d => d.InMoviInvenTipo7).WithMany(p => p.InParametroInMoviInvenTipo7).HasConstraintName("FK_in_parametro_in_movi_inven_tipo6");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.InParametroCtPlancta1).HasConstraintName("FK_in_parametro_ct_plancta2");
        });

        modelBuilder.Entity<InParametroImpuestoIvaIce>(entity =>
        {
            entity.HasKey(e => e.Idempresa).HasName("PRIMARY");

            entity.Property(e => e.Idempresa).ValueGeneratedNever();
        });

        modelBuilder.Entity<InPrecargaItemsOrdenCompra>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdPrecarga })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.InPrecargaItemsOrdenCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_PrecargaItemsOrdenCompra_cp_proveedor");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.InPrecargaItemsOrdenCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_PrecargaItemsOrdenCompra_tb_sucursal");
        });

        modelBuilder.Entity<InPrecargaItemsOrdenCompraDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdPrecarga, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.DprCosteado).IsFixedLength();
            entity.Property(e => e.DprManejaIva).IsFixedLength();
            entity.Property(e => e.EstadoProcesado).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.InPrecargaItemsOrdenCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_PrecargaItemsOrdenCompra_det_in_Producto");

            entity.HasOne(d => d.InPrecargaItemsOrdenCompra).WithMany(p => p.InPrecargaItemsOrdenCompraDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_PrecargaItemsOrdenCompra_det_in_PrecargaItemsOrdenCompra");
        });

        modelBuilder.Entity<InPresentacion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPresentacion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<InPresupuesto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdPresupuesto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.InPresupuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_presupuesto_cp_proveedor");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.InPresupuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_presupuesto_tb_sucursal");
        });

        modelBuilder.Entity<InPresupuestoDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdPresupuesto, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.DpCosteado).IsFixedLength();
            entity.Property(e => e.DpManejaIva).IsFixedLength();

            entity.HasOne(d => d.InProducto).WithMany(p => p.InPresupuestoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_presupuesto_det_in_Producto");

            entity.HasOne(d => d.InPresupuesto).WithMany(p => p.InPresupuestoDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_presupuesto_det_in_presupuesto");
        });

        modelBuilder.Entity<InProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.ManejaLote).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.InProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_tb_empresa");

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.InProductoIdUnidadMedidaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_in_UnidadMedida");

            entity.HasOne(d => d.IdUnidadMedidaConsumoNavigation).WithMany(p => p.InProductoIdUnidadMedidaConsumoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_in_UnidadMedida1");

            entity.HasOne(d => d.InMarca).WithMany(p => p.InProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_in_Marca");

            entity.HasOne(d => d.FaMotivoVenta).WithMany(p => p.InProducto).HasConstraintName("FK_in_Producto_fa_motivo_venta");

            entity.HasOne(d => d.InPresentacion).WithMany(p => p.InProducto).HasConstraintName("FK_in_Producto_in_presentacion");

            entity.HasOne(d => d.InProductoTipo).WithMany(p => p.InProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_in_ProductoTipo");

            entity.HasOne(d => d.InSubgrupo).WithMany(p => p.InProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_in_subgrupo");
        });

        modelBuilder.Entity<InProductoComposicion>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProductoPadre, e.IdProductoHijo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InProducto).WithMany(p => p.InProductoComposicionInProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_Composicion_in_Producto1");

            entity.HasOne(d => d.InProductoNavigation).WithMany(p => p.InProductoComposicionInProductoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_Producto_Composicion_in_Producto");
        });

        modelBuilder.Entity<InProductoDimensiones>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<InProductoPrecioHistorico>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdProducto, e.IdUsuario, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InProductoTipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProductoTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.EsMateriaPrima).IsFixedLength();
            entity.Property(e => e.EsProductoTerminado).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.TpEsCombo).IsFixedLength();
            entity.Property(e => e.TpManejaInven).IsFixedLength();
        });

        modelBuilder.Entity<InProductoXCpProveedor>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaProd, e.IdProducto, e.IdEmpresaProv, e.IdProveedor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.InProducto).WithMany(p => p.InProductoXCpProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_producto_x_cp_proveedor_in_Producto");

            entity.HasOne(d => d.CpProveedor).WithMany(p => p.InProductoXCpProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_producto_x_cp_proveedor_cp_proveedor");
        });

        modelBuilder.Entity<InProductoXInProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProducto, e.IdProductoHijo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.InProducto).WithMany(p => p.InProductoXInProductoInProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_producto_x_in_producto_in_Producto");

            entity.HasOne(d => d.InProductoNavigation).WithMany(p => p.InProductoXInProductoInProductoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_producto_x_in_producto_in_Producto_hijo");
        });

        modelBuilder.Entity<InProductoXTbBodega>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.InProductoXTbBodegaCtPlancta).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta2");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.InProductoXTbBodegaCtPlanctaNavigation).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta1");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.InProductoXTbBodegaCtPlancta1).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta9");

            entity.HasOne(d => d.CtPlancta2).WithMany(p => p.InProductoXTbBodegaCtPlancta2).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta6");

            entity.HasOne(d => d.CtPlancta3).WithMany(p => p.InProductoXTbBodegaCtPlancta3).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta8");

            entity.HasOne(d => d.CtPlancta4).WithMany(p => p.InProductoXTbBodegaCtPlancta4).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta5");

            entity.HasOne(d => d.CtPlancta5).WithMany(p => p.InProductoXTbBodegaCtPlancta5).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta10");

            entity.HasOne(d => d.CtPlancta6).WithMany(p => p.InProductoXTbBodegaCtPlancta6).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta");

            entity.HasOne(d => d.CtPlancta7).WithMany(p => p.InProductoXTbBodegaCtPlancta7).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta4");

            entity.HasOne(d => d.CtPlancta8).WithMany(p => p.InProductoXTbBodegaCtPlancta8).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta3");

            entity.HasOne(d => d.CtPlancta9).WithMany(p => p.InProductoXTbBodegaCtPlancta9).HasConstraintName("FK_in_producto_x_tb_bodega_ct_plancta11");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InProductoXTbBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_producto_x_tb_bodega_in_Producto");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InProductoXTbBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_producto_x_tb_bodega_tb_bodega");
        });

        modelBuilder.Entity<InProductoXTbBodegaCostoHistorico>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto, e.IdFecha, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InProductoXTbBodega).WithMany(p => p.InProductoXTbBodegaCostoHistorico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_producto_x_tb_bodega_Costo_Historico_in_producto_x_tb_bo35");
        });

        modelBuilder.Entity<InRecosteoProductosXMoviInveDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InResponsable>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdResponsable })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<InRptDispInve>(entity =>
        {
            entity.HasKey(e => new { e.EmpresaSi, e.IdSucursalSi, e.IdBodegaSi, e.IdProductoSi, e.IdCategoria, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<InRptMoviInvXProdResumido>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdProducto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InSpSysInvReversarAprobacionCtCbtecble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTipoCbte, e.IdCbteCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<InSpSysInvReversarAprobacionInMoviInven>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaInv, e.IdSucursalInv, e.IdBodegaInv, e.IdMoviInvenTipoInv, e.IdNumMoviInv, e.SecuenciaInv })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<InSubgrupo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria, e.IdLinea, e.IdGrupo, e.IdSubgrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.InSubgrupoCtPlancta).HasConstraintName("FK_in_subgrupo_ct_plancta9");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.InSubgrupoCtPlanctaNavigation).HasConstraintName("FK_in_subgrupo_ct_plancta11");

            entity.HasOne(d => d.CtPlancta1).WithMany(p => p.InSubgrupoCtPlancta1).HasConstraintName("FK_in_subgrupo_ct_plancta3");

            entity.HasOne(d => d.CtPlancta2).WithMany(p => p.InSubgrupoCtPlancta2).HasConstraintName("FK_in_subgrupo_ct_plancta");

            entity.HasOne(d => d.CtPlancta3).WithMany(p => p.InSubgrupoCtPlancta3).HasConstraintName("FK_in_subgrupo_ct_plancta2");

            entity.HasOne(d => d.CtPlancta4).WithMany(p => p.InSubgrupoCtPlancta4).HasConstraintName("FK_in_subgrupo_ct_plancta1");

            entity.HasOne(d => d.InGrupo).WithMany(p => p.InSubgrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_subgrupo_in_grupo");
        });

        modelBuilder.Entity<InSubgrupoXCentroCostoXSubCentroCostoXCtaCble>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCategoria, e.IdLinea, e.IdGrupo, e.IdSubgrupo, e.IdCentroCosto, e.IdSubCentroCosto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.InSubgrupoXCentroCostoXSubCentroCostoXCtaCble).HasConstraintName("FK_in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_ct_pla8");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.InSubgrupoXCentroCostoXSubCentroCostoXCtaCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_ct_cen7");

            entity.HasOne(d => d.InSubgrupo).WithMany(p => p.InSubgrupoXCentroCostoXSubCentroCostoXCtaCble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_in_sub9");
        });

        modelBuilder.Entity<InTransferencia>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursalOrigen, e.IdBodegaOrigen, e.IdTransferencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEstadoAprobacionCatNavigation).WithMany(p => p.InTransferencia).HasConstraintName("FK_in_transferencia_in_Catalogo");

            entity.HasOne(d => d.TbBodega).WithMany(p => p.InTransferencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_tb_bodega");

            entity.HasOne(d => d.InIngEgrInven).WithMany(p => p.InTransferenciaInIngEgrInven).HasConstraintName("FK_in_transferencia_in_Ing_Egr_Inven1");

            entity.HasOne(d => d.InIngEgrInvenNavigation).WithMany(p => p.InTransferenciaInIngEgrInvenNavigation).HasConstraintName("FK_in_transferencia_in_Ing_Egr_Inven");
        });

        modelBuilder.Entity<InTransferenciaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursalOrigen, e.IdBodegaOrigen, e.IdTransferencia, e.DtSecuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.InTransferenciaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_det_in_UnidadMedida");

            entity.HasOne(d => d.InProducto).WithMany(p => p.InTransferenciaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_det_in_Producto");

            entity.HasOne(d => d.CtPuntoCargo).WithMany(p => p.InTransferenciaDet).HasConstraintName("FK_in_transferencia_det_ct_punto_cargo");

            entity.HasOne(d => d.CtPuntoCargoGrupo).WithMany(p => p.InTransferenciaDet).HasConstraintName("FK_in_transferencia_det_ct_punto_cargo_grupo");

            entity.HasOne(d => d.CtCentroCostoSubCentroCosto).WithMany(p => p.InTransferenciaDet).HasConstraintName("FK_in_transferencia_det_ct_centro_costo_sub_centro_costo");

            entity.HasOne(d => d.InTransferencia).WithMany(p => p.InTransferenciaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_det_in_transferencia");
        });

        modelBuilder.Entity<InTransferenciaDetXInGuiaXTraspasoBodegaDet>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaTrans, e.IdSucursalOrigenTrans, e.IdBodegaOrigenTrans, e.IdTransferenciaTrans, e.SecuenciaTrans, e.IdEmpresaGuia, e.IdGuiaGuia, e.SecuenciaGuia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InGuiaXTraspasoBodegaDet).WithMany(p => p.InTransferenciaDetXInGuiaXTraspasoBodegaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_in_Gui11");

            entity.HasOne(d => d.InTransferenciaDet).WithMany(p => p.InTransferenciaDetXInGuiaXTraspasoBodegaDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_in_tra12");
        });

        modelBuilder.Entity<InTransferenciaXFaGuiaRemision>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursalOrigen, e.IdBodegaOrigen, e.IdTransferencia, e.IdEmpresaGuia, e.IdSucursalGuia, e.IdBodegaGuia, e.IdGuiaRemision })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.Property(e => e.Obser).IsFixedLength();

            entity.HasOne(d => d.InTransferencia).WithMany(p => p.InTransferenciaXFaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_x_fa_guia_remision_in_transferencia");

            entity.HasOne(d => d.FaGuiaRemision).WithMany(p => p.InTransferenciaXFaGuiaRemision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_x_fa_guia_remision_fa_guia_remision");
        });

        modelBuilder.Entity<InTransferenciaXInGuiaXTraspasoBodega>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursalOrgen, e.IdBodegaOrigen, e.IdTransferencia, e.IdEmpresaGuia, e.IdGuia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

            entity.HasOne(d => d.InGuiaXTraspasoBodega).WithMany(p => p.InTransferenciaXInGuiaXTraspasoBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_x_in_Guia_x_traspaso_bodega_in_Guia_x_tras36");

            entity.HasOne(d => d.InTransferencia).WithMany(p => p.InTransferenciaXInGuiaXTraspasoBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_transferencia_x_in_Guia_x_traspaso_bodega_in_transferencia");
        });

        modelBuilder.Entity<InUnidadMedida>(entity =>
        {
            entity.HasKey(e => e.IdUnidadMedida).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.UsadoEnMovimiento).IsFixedLength();
        });

        modelBuilder.Entity<InUnidadMedidaEquivConversion>(entity =>
        {
            entity.HasKey(e => new { e.IdUnidadMedida, e.IdUnidadMedidaEquiva })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdUnidadMedidaNavigation).WithMany(p => p.InUnidadMedidaEquivConversionIdUnidadMedidaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_UnidadMedida_Equiv_conversion_in_UnidadMedida");

            entity.HasOne(d => d.IdUnidadMedidaEquivaNavigation).WithMany(p => p.InUnidadMedidaEquivConversionIdUnidadMedidaEquivaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_in_UnidadMedida_Equiv_conversion_in_UnidadMedida1");
        });

        modelBuilder.Entity<InZona>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdZona })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.IdZona).IsFixedLength();
        });

        modelBuilder.Entity<InZonaVsCentroDeCosto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaIdZona, e.IdZona, e.IdEmpresaCentrCosot, e.IdCentroCosto, e.IdSubZona })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<Libro1>(entity =>
        {
            entity.Property(e => e.J).IsFixedLength();
        });

        modelBuilder.Entity<MailCuentaCorreo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCuenta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<MailMail>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdMail })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<MailMailAttachment>(entity =>
        {
            entity.HasKey(e => new { e.Secuencia, e.IdEmpresa, e.IdSucursal, e.IdMail })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.HasOne(d => d.MailMail).WithMany(p => p.MailMailAttachment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mail_Mail_mail_Mail_Attachment_fk");
        });

        modelBuilder.Entity<MailNotificacionConfig>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.HostName })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<MailPlantillaMensaje>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMensaje })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<MgCtPlanCta>(entity =>
        {
            entity.HasKey(e => e.IdCtaCble).HasName("PRIMARY");
        });

        modelBuilder.Entity<SegMenu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PRIMARY");

            entity.Property(e => e.IdMenu).ValueGeneratedNever();
        });

        modelBuilder.Entity<SegMenuCategoria>(entity =>
        {
            entity.HasKey(e => e.CodigoCategoria).HasName("PRIMARY");
        });

        modelBuilder.Entity<SegMenuGrupo>(entity =>
        {
            entity.HasKey(e => e.CodigoGrupo).HasName("PRIMARY");

            entity.HasOne(d => d.CodigoPaginaNavigation).WithMany(p => p.SegMenuGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_Grupo_seg_Menu_Pagina");
        });

        modelBuilder.Entity<SegMenuGrupoXSegMenuItem>(entity =>
        {
            entity.HasKey(e => new { e.CodigoItem, e.CodigoGrupo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CodigoGrupoNavigation).WithMany(p => p.SegMenuGrupoXSegMenuItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_Grupo_x_seg_Menu_Item_seg_Menu_Grupo");

            entity.HasOne(d => d.CodigoItemNavigation).WithMany(p => p.SegMenuGrupoXSegMenuItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_Grupo_x_seg_Menu_Item_seg_Menu_Item");
        });

        modelBuilder.Entity<SegMenuItem>(entity =>
        {
            entity.HasKey(e => e.CodigoItem).HasName("PRIMARY");

            entity.HasOne(d => d.IdTipoItemNavigation).WithMany(p => p.SegMenuItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_Item_seg_Menu_Item_Tipo");
        });

        modelBuilder.Entity<SegMenuItemTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoItem).HasName("PRIMARY");
        });

        modelBuilder.Entity<SegMenuPagina>(entity =>
        {
            entity.HasKey(e => e.CodigoPagina).HasName("PRIMARY");

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.SegMenuPagina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_Pagina_seg_Menu_Categoria");
        });

        modelBuilder.Entity<SegMenuWeb>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PRIMARY");

            entity.Property(e => e.IdMenu).ValueGeneratedNever();

            entity.HasOne(d => d.IdMenuPadreNavigation).WithMany(p => p.InverseIdMenuPadreNavigation).HasConstraintName("seg_Menu_Web_x_seg_Menu_Web");
        });

        modelBuilder.Entity<SegMenuWebXEmpresaXUsuario>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdEmpresa, e.IdMenu })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<SegMenuXEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdMenu })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.SegMenuXEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_x_Empresa_tb_empresa");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.SegMenuXEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_x_Empresa_seg_Menu");
        });

        modelBuilder.Entity<SegMenuXEmpresaXUsuario>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.IdMenu })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SegMenuXEmpresaXUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_x_Empresa_x_Usuario_seg_usuario");

            entity.HasOne(d => d.SegMenuXEmpresa).WithMany(p => p.SegMenuXEmpresaXUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Menu_x_Empresa_x_Usuario_seg_Menu_x_Empresa");
        });

        modelBuilder.Entity<SegUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PRIMARY");

            entity.Property(e => e.IdDepartamento).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<SegUsuarioXEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdEmpresa })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.SegUsuarioXEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Usuario_x_Empresa_tb_empresa");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SegUsuarioXEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_Usuario_x_Empresa_seg_usuario");
        });

        modelBuilder.Entity<SegUsuarioXTbSisReporte>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.CodReporte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CodReporteNavigation).WithMany(p => p.SegUsuarioXTbSisReporte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_usuario_x_tb_sis_reporte_tb_sis_reporte");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SegUsuarioXTbSisReporte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seg_usuario_x_tb_sis_reporte_seg_usuario");
        });

        modelBuilder.Entity<SriCiudad>(entity =>
        {
            entity.HasKey(e => new { e.IdCiudad, e.IdPais })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<SriProvincia>(entity =>
        {
            entity.HasKey(e => e.IdProvincia).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<SriTipoGasto>(entity =>
        {
            entity.HasKey(e => e.IdTipoGasto).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<SriTipoIdentificacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoIdenti).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<StCatalogo>(entity =>
        {
            entity.HasKey(e => e.CodCatalogo).HasName("PRIMARY");

            entity.HasOne(d => d.IdTipoCatalogoNavigation).WithMany(p => p.StCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_st_Catalogo_st_CatalogoTipo");
        });

        modelBuilder.Entity<StCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoCatalogo).HasName("PRIMARY");

            entity.Property(e => e.IdTipoCatalogo).ValueGeneratedNever();
        });

        modelBuilder.Entity<StRequerimiento>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.RequerimientoTipo, e.IdRequerimiento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdEstadoRequerimientoNavigation).WithMany(p => p.StRequerimientoIdEstadoRequerimientoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_st_Requerimiento_st_Catalogo");

            entity.HasOne(d => d.IdPrioridadNavigation).WithMany(p => p.StRequerimientoIdPrioridadNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_st_Requerimiento_st_Catalogo1");

            entity.HasOne(d => d.StTecnico).WithMany(p => p.StRequerimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_st_Requerimiento_st_Tecnico");
        });

        modelBuilder.Entity<StTecnico>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdTecnico })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<SypFeRespuestaSri>(entity =>
        {
            entity.Property(e => e.ClaveAcceso).IsFixedLength();
            entity.Property(e => e.CodDoc).IsFixedLength();
            entity.Property(e => e.NumDoc).IsFixedLength();
            entity.Property(e => e.Numeroautorizacion).IsFixedLength();
        });

        modelBuilder.Entity<Sysdiagrams>(entity =>
        {
            entity.HasKey(e => e.DiagramId).HasName("PRIMARY");

            entity.Property(e => e.DiagramId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbActividadesHorario>(entity =>
        {
            entity.HasKey(e => e.IdTransaccion).HasName("PRIMARY");

            entity.HasOne(d => d.IdTipoEjecucionNavigation).WithMany(p => p.TbActividadesHorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Actividades_Horario_tb_Actividades_Horario_Tipo_Ejecucion");

            entity.HasOne(d => d.IdTipoTiempoNavigation).WithMany(p => p.TbActividadesHorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Actividades_Horario_tb_Actividades_Horario_Tipo_Tiempo");
        });

        modelBuilder.Entity<TbActividadesHorarioAcciones>(entity =>
        {
            entity.HasKey(e => new { e.IdTransaccion, e.IdAccion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdTransaccionNavigation).WithMany(p => p.TbActividadesHorarioAcciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Actividades_Horario_Acciones_tb_Actividades_Horario");
        });

        modelBuilder.Entity<TbActividadesHorarioTipoEjecucion>(entity =>
        {
            entity.HasKey(e => e.IdTipoEjecucion).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbActividadesHorarioTipoTiempo>(entity =>
        {
            entity.HasKey(e => e.IdTipoTiempo).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbBanco>(entity =>
        {
            entity.HasKey(e => e.IdBanco).HasName("PRIMARY");

            entity.Property(e => e.IdBanco).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbBancoEstadoRegRespBancaria>(entity =>
        {
            entity.HasKey(e => new { e.IdBanco, e.IdEstadoRegCat, e.IdEstadoRegBancario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.TbBancoEstadoRegRespBancaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_banco_estado_reg__resp_bancaria_tb_banco");
        });

        modelBuilder.Entity<TbBancoProcesosBancariosTipo>(entity =>
        {
            entity.HasKey(e => e.IdProcesoBancarioTipo).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbBancoProcesosBancariosXEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdProcesoBancarioTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.BaTipoNota).WithMany(p => p.TbBancoProcesosBancariosXEmpresa).HasConstraintName("FK_tb_banco_procesos_bancarios_x_empresa_ba_tipo_nota");
        });

        modelBuilder.Entity<TbBodega>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.BoEsBodega).IsFixedLength();
            entity.Property(e => e.BoManejaFacturacion).IsFixedLength();
            entity.Property(e => e.CodPuntoEmision).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.TbBodegaCtPlancta).HasConstraintName("FK_tb_bodega_ct_plancta1");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.TbBodegaCtPlanctaNavigation).HasConstraintName("FK_tb_bodega_ct_plancta");

            entity.HasOne(d => d.TbSucursal).WithMany(p => p.TbBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_bodega_tb_sucursal");
        });

        modelBuilder.Entity<TbBodegaFiltro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbCalendario>(entity =>
        {
            entity.HasKey(e => e.IdCalendario).HasName("PRIMARY");

            entity.Property(e => e.IdCalendario).ValueGeneratedNever();
            entity.Property(e => e.EsFeriado).IsFixedLength();
            entity.Property(e => e.InicialDelDia).IsFixedLength();
        });

        modelBuilder.Entity<TbCatalogo>(entity =>
        {
            entity.HasKey(e => e.CodCatalogo).HasName("PRIMARY");

            entity.HasOne(d => d.IdTipoCatalogoNavigation).WithMany(p => p.TbCatalogo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Catalogo_tb_CatalogoTipo");
        });

        modelBuilder.Entity<TbCatalogoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoCatalogo).HasName("PRIMARY");

            entity.Property(e => e.IdTipoCatalogo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbCatastroGranContribuyente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbCiiu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbCiudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.TbCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_ciudad_tb_provincia");
        });

        modelBuilder.Entity<TbComprobantesRecibidos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CpOrdenGiro).WithMany(p => p.TbComprobantesRecibidos).HasConstraintName("tb_ComprobantesRecibidos_FK");
        });

        modelBuilder.Entity<TbConexionDashboard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbConexionDbfacturacionElectronica>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbContaRpt010>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPuntoCargoGrupo, e.IdPuntoCargo, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbContaRpt012>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<TbContaRpt023Data>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdCtaCble, e.IdCtaCblePadre, e.IdCentroCosto, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbContacto>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdContacto })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.TbContacto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_contacto_tb_ciudad");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbContacto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_contacto_tb_empresa");

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.TbContactoIdNacionalidadNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_contacto_tb_pais");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.TbContactoIdPaisNavigation).HasConstraintName("FK_tb_contacto_tb_pais1");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.TbContacto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_contacto_tb_persona");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.TbContacto).HasConstraintName("FK_tb_contacto_tb_provincia");
        });

        modelBuilder.Entity<TbCxpRpt001>(entity =>
        {
            entity.HasKey(e => e.Secuencia).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbCxpRpt002>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        });

        modelBuilder.Entity<TbCxpRpt003>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.NomPc, e.IdProveedor })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbCxpRpt004>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.Nretencion, e.NomPc, e.IdSecuenciaReten, e.TipoRetencion, e.Ndocumento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbCxpRpt005>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.NomPc, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbCxpRpt006>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.NomPc, e.NDoc, e.Nautorizacion, e.Documento, e.IdProveedor, e.IdCbte, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbDia>(entity =>
        {
            entity.HasKey(e => e.IdDia).HasName("PRIMARY");

            entity.Property(e => e.IdDia).ValueGeneratedNever();
            entity.Property(e => e.Nemonico).IsFixedLength();
        });

        modelBuilder.Entity<TbEmpresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("PRIMARY");

            entity.Property(e => e.IdEmpresa).ValueGeneratedNever();
            entity.Property(e => e.EmFax).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbInvRpt001>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresaSp, e.IdUsuarioSp })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<TbInvRpt004>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario, e.FechaTransac })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<TbMes>(entity =>
        {
            entity.HasKey(e => e.IdMes).HasName("PRIMARY");

            entity.Property(e => e.IdMes).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbModulo>(entity =>
        {
            entity.HasKey(e => e.CodModulo).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbMoneda>(entity =>
        {
            entity.HasKey(e => e.IdMoneda).HasName("PRIMARY");

            entity.Property(e => e.IdMoneda).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ImNemonico).IsFixedLength();
            entity.Property(e => e.ImSimbolo).IsFixedLength();
        });

        modelBuilder.Entity<TbPais>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbParametro>(entity =>
        {
            entity.HasKey(e => e.IdParametro).HasName("PRIMARY");

            entity.HasOne(d => d.IdTipoParamNavigation).WithMany(p => p.TbParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_parametro_tb_parametro_tipo");
        });

        modelBuilder.Entity<TbParametroTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoParam).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbParroquia>(entity =>
        {
            entity.HasKey(e => e.IdParroquia).HasName("PRIMARY");

            entity.HasOne(d => d.IdCiudadCantonNavigation).WithMany(p => p.TbParroquia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_parroquia_tb_ciudad");
        });

        modelBuilder.Entity<TbPersona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PRIMARY");

            entity.HasOne(d => d.IdBancoAcreditacionNavigation).WithMany(p => p.TbPersona).HasConstraintName("FK_tb_persona_tb_banco");

            entity.HasOne(d => d.IdEstadoCivilNavigation).WithMany(p => p.TbPersonaIdEstadoCivilNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_persona_tb_Catalogo3");

            entity.HasOne(d => d.IdTipoCtaAcreditacionCatNavigation).WithMany(p => p.TbPersonaIdTipoCtaAcreditacionCatNavigation).HasConstraintName("FK_tb_persona_tb_Catalogo6");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.TbPersonaIdTipoDocumentoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_persona_tb_Catalogo1");

            entity.HasOne(d => d.PeNaturalezaNavigation).WithMany(p => p.TbPersonaPeNaturalezaNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_persona_tb_Catalogo");

            entity.HasOne(d => d.PeSexoNavigation).WithMany(p => p.TbPersonaPeSexoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_persona_tb_Catalogo4");
        });

        modelBuilder.Entity<TbPersonaDireccion>(entity =>
        {
            entity.HasKey(e => new { e.IdPersona, e.IdDireccion })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.TbPersonaDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_persona_direccion_tb_persona");

            entity.HasOne(d => d.IdTipoDireccionNavigation).WithMany(p => p.TbPersonaDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_persona_direccion_tb_persona_direccion_tipo");
        });

        modelBuilder.Entity<TbPersonaDireccionTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoDireccion).HasName("PRIMARY");

            entity.Property(e => e.IdTipoDireccion).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbPersonaTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoPersona).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbProvincia>(entity =>
        {
            entity.HasKey(e => e.IdProvincia).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CodRegionNavigation).WithMany(p => p.TbProvincia).HasConstraintName("FK_tb_provincia_tb_region");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.TbProvincia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_provincia_tb_pais");
        });

        modelBuilder.Entity<TbRangoFechaBusquedaXPeriodo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbRegion>(entity =>
        {
            entity.HasKey(e => e.CodRegion).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbRolNominaGeneral>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdEmpleado, e.IdNominaTipo, e.IdNominaTipoLiqui, e.IdPeriodo, e.NomPc, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbRolRpt002>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdEmpleado, e.IdPeriodo, e.IdRubro, e.IdNominaTipo, e.IdNominaTipoLiqui, e.IdNovedad, e.SecuenciaNovedad, e.IdPrestamo, e.NunCouta, e.IdUsuario, e.NomPc, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            entity.Property(e => e.Departamento).IsFixedLength();
            entity.Property(e => e.EmNombre).IsFixedLength();
            entity.Property(e => e.RuTipo).IsFixedLength();
        });

        modelBuilder.Entity<TbRolRpt003>(entity =>
        {
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.EstadoDet).IsFixedLength();
        });

        modelBuilder.Entity<TbSisActualizacionesXTablas>(entity =>
        {
            entity.HasKey(e => e.IdTabla).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbSisDatosSistema>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbSisDocumentoRegistrosXTalonario>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoTalonario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Utilizado).IsFixedLength();
        });

        modelBuilder.Entity<TbSisDocumentoTipo>(entity =>
        {
            entity.HasKey(e => e.CodDocumentoTipo).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbSisDocumentoTipoReporteXEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.CodDocumentoTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CodDocumentoTipoNavigation).WithMany(p => p.TbSisDocumentoTipoReporteXEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_Documento_Tipo_Reporte_x_Empresa_tb_sis_Documento_Tipo");
        });

        modelBuilder.Entity<TbSisDocumentoTipoTalonario>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.CodDocumentoTipo, e.Establecimiento, e.PuntoEmision, e.NumDocumento })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.CodDocumentoTipoNavigation).WithMany(p => p.TbSisDocumentoTipoTalonario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_Documento_Tipo_Talonario_tb_sis_Documento_Tipo");

            entity.HasOne(d => d.TbSisDocumentoTipoXEmpresa).WithMany(p => p.TbSisDocumentoTipoTalonario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_Documento_Tipo_Talonario_tb_sis_Documento_Tipo_x_Emp5");
        });

        modelBuilder.Entity<TbSisDocumentoTipoXEmpresa>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.CodDocumentoTipo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.ApareceComboFacImport).IsFixedLength();
            entity.Property(e => e.ApareceComboFacTipoFact).IsFixedLength();
            entity.Property(e => e.ApareceComboFileReporte).IsFixedLength();
            entity.Property(e => e.ApareceTalonario).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbSisDocumentoTipoXEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_Documento_Tipo_x_Empresa_tb_empresa");
        });

        modelBuilder.Entity<TbSisDocumentoTipoXEmpresaAnulados>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.CodDocumentoTipo, e.IdTipoDocAnu })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<TbSisDocumentoTipoXSecuenciaTalonario>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.CodDocumentoTipo, e.Secuencia })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbSisFormulario>(entity =>
        {
            entity.HasKey(e => e.IdFormulario).HasName("PRIMARY");

            entity.HasOne(d => d.CodModuloNavigation).WithMany(p => p.TbSisFormulario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_formulario_tb_modulo");
        });

        modelBuilder.Entity<TbSisGrupoEmpresarialCliente>(entity =>
        {
            entity.HasKey(e => e.IdGrupoEmpresarialCliente).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbSisIconos>(entity =>
        {
            entity.HasKey(e => e.IdIcono).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbSisImpuesto>(entity =>
        {
            entity.HasKey(e => e.IdCodImpuesto).HasName("PRIMARY");

            entity.HasOne(d => d.IdCodigoSriNavigation).WithMany(p => p.TbSisImpuesto).HasConstraintName("FK_tb_sis_Impuesto_cp_codigo_SRI");

            entity.HasOne(d => d.IdTipoImpuestoNavigation).WithMany(p => p.TbSisImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_Impuesto_tb_sis_Impuesto_Tipo");
        });

        modelBuilder.Entity<TbSisImpuestoTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoImpuesto).HasName("PRIMARY");
        });

        modelBuilder.Entity<TbSisImpuestoXCtacble>(entity =>
        {
            entity.HasKey(e => new { e.IdCodImpuesto, e.IdEmpresaCta, e.IdCtaCble })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.HasOne(d => d.IdCodImpuestoNavigation).WithMany(p => p.TbSisImpuestoXCtacble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_Impuesto_x_ctacble_tb_sis_Impuesto");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.TbSisImpuestoXCtacble)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_Impuesto_x_ctacble_ct_plancta");
        });

        modelBuilder.Entity<TbSisLogErrorVzen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.FechaTrans).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<TbSisMensajesSys>(entity =>
        {
            entity.HasKey(e => e.IdMensaje).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbSisReporte>(entity =>
        {
            entity.HasKey(e => e.CodReporte).HasName("PRIMARY");

            entity.Property(e => e.Estado).IsFixedLength();

            entity.HasOne(d => d.IdGrupoReporteNavigation).WithMany(p => p.TbSisReporte).HasConstraintName("FK_tb_sis_reporte_tb_sis_reporte_Grupo");

            entity.HasOne(d => d.ModuloNavigation).WithMany(p => p.TbSisReporte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_reporte_tb_modulo");
        });

        modelBuilder.Entity<TbSisReporteGrupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupoReporte).HasName("PRIMARY");

            entity.Property(e => e.IdGrupoReporte).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbSisReporteXFormulario>(entity =>
        {
            entity.HasKey(e => new { e.IdFormulario, e.CodReporte })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.CodReporteNavigation).WithMany(p => p.TbSisReporteXFormulario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_reporte_x_formulario_tb_sis_reporte");

            entity.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.TbSisReporteXFormulario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sis_reporte_x_formulario_tb_sis_formulario");
        });

        modelBuilder.Entity<TbSpSysInConsultaErroresFrecuentesEliminarMovimient1>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal, e.IdBodega, e.IdMoviInvenTipo, e.IdNumMovi, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });
        });

        modelBuilder.Entity<TbSucursal>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdSucursal })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_sucursal_tb_empresa");
        });

        modelBuilder.Entity<TbTarea>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTarea })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbTareaEquipo>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTarea, e.IdUsuario })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        });

        modelBuilder.Entity<TbTarjeta>(entity =>
        {
            entity.HasKey(e => e.IdTarjeta).HasName("PRIMARY");

            entity.Property(e => e.IdTarjeta).ValueGeneratedNever();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TbTarjetaParametro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTarjeta })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.IdCobroTipoXRetFuNavigation).WithMany(p => p.TbTarjetaParametroIdCobroTipoXRetFuNavigation).HasConstraintName("FK_tb_tarjeta_parametro_cxc_cobro_tipo1");

            entity.HasOne(d => d.IdCobroTipoXRetIvaNavigation).WithMany(p => p.TbTarjetaParametroIdCobroTipoXRetIvaNavigation).HasConstraintName("FK_tb_tarjeta_parametro_cxc_cobro_tipo2");

            entity.HasOne(d => d.IdCobroTipoXTarjNavigation).WithMany(p => p.TbTarjetaParametroIdCobroTipoXTarjNavigation).HasConstraintName("FK_tb_tarjeta_parametro_cxc_cobro_tipo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbTarjetaParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_tarjeta_parametro_tb_empresa");

            entity.HasOne(d => d.IdTarjetaNavigation).WithMany(p => p.TbTarjetaParametro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_tarjeta_parametro_tb_tarjeta");

            entity.HasOne(d => d.CtPlancta).WithMany(p => p.TbTarjetaParametroCtPlancta).HasConstraintName("FK_tb_tarjeta_parametro_ct_plancta1");

            entity.HasOne(d => d.CtPlanctaNavigation).WithMany(p => p.TbTarjetaParametroCtPlanctaNavigation).HasConstraintName("FK_tb_tarjeta_parametro_ct_plancta");
        });

        modelBuilder.Entity<TbTransportista>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdTransportista })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<TmpCobrosFechaCorte>(entity =>
        {
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<TmpCobrosFechaCorteSp010>(entity =>
        {
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<TmpFactuNdNcCobro>(entity =>
        {
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<TmpFactuNdNcCobroSp010>(entity =>
        {
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<TmpRangoFactuXClienteSp010>(entity =>
        {
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<TmpRoPrestamoDetalle>(entity =>
        {
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.EstadoPago).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<TmpXrolRpt024>(entity =>
        {
            entity.Property(e => e.EstadoPago).HasDefaultValueSql("''");
            entity.Property(e => e.EstadoPrestamo).IsFixedLength();
            entity.Property(e => e.IdUsuario).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwActfRpt001>(entity =>
        {
            entity.ToView("vwACTF_Rpt001");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt002>(entity =>
        {
            entity.ToView("vwACTF_Rpt002");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt003>(entity =>
        {
            entity.ToView("vwACTF_Rpt003");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt004>(entity =>
        {
            entity.ToView("vwACTF_Rpt004");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt005>(entity =>
        {
            entity.ToView("vwACTF_Rpt005");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt006>(entity =>
        {
            entity.ToView("vwACTF_Rpt006");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt007>(entity =>
        {
            entity.ToView("vwACTF_Rpt007");

            entity.Property(e => e.CodVtaActivo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt008>(entity =>
        {
            entity.ToView("vwACTF_Rpt008");

            entity.Property(e => e.CodRetActivo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt009>(entity =>
        {
            entity.ToView("vwACTF_Rpt009");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt010>(entity =>
        {
            entity.ToView("vwACTF_Rpt010");

            entity.Property(e => e.SucActual).IsFixedLength();
            entity.Property(e => e.SucAnterior).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt011>(entity =>
        {
            entity.ToView("vwACTF_Rpt011");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt012>(entity =>
        {
            entity.ToView("vwACTF_Rpt012");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt013>(entity =>
        {
            entity.ToView("vwACTF_Rpt013");

            entity.Property(e => e.AfFechaCompra).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.AfFechaFinDepre).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.AfFechaIniDepre).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.AfNombre).HasDefaultValueSql("''");
            entity.Property(e => e.CodActivoFijo).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.TipoRegistro).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwActfRpt014>(entity =>
        {
            entity.ToView("vwACTF_Rpt014");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt0141>(entity =>
        {
            entity.ToView("vwACTF_Rpt014_1");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt015>(entity =>
        {
            entity.ToView("vwACTF_Rpt015");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwActfRpt016>(entity =>
        {
            entity.ToView("vwACTF_Rpt016");

            entity.Property(e => e.NumFactura)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwAfActivoCtasCbles>(entity =>
        {
            entity.ToView("vwAf_ActivoCtasCbles");
        });

        modelBuilder.Entity<VwAfActivoFijo>(entity =>
        {
            entity.ToView("vwAf_ActivoFijo");

            entity.Property(e => e.AfFechaFinDepre).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.AfNombre).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwAfActivoFijo1>(entity =>
        {
            entity.ToView("vwAf_Activo_fijo");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwAfActivoFijoCategoria>(entity =>
        {
            entity.ToView("vwAf_Activo_fijo_Categoria");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwAfActivoFijoCtasCbles>(entity =>
        {
            entity.ToView("vwAf_Activo_fijo_CtasCbles");

            entity.Property(e => e.IdTipoCuenta).HasDefaultValueSql("''");
            entity.Property(e => e.Observacion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwAfCatalogoIdAutoNumeric>(entity =>
        {
            entity.ToView("vwAf_Catalogo_IdAuto_numeric");

            entity.Property(e => e.IdCatalogo).HasDefaultValueSql("''");
            entity.Property(e => e.Observacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwAfDepreXCicloValor>(entity =>
        {
            entity.ToView("vwAf_Depre_x_Ciclo_Valor");
        });

        modelBuilder.Entity<VwAfDepreciacion>(entity =>
        {
            entity.ToView("vwAf_Depreciacion");

            entity.Property(e => e.CodDepreciacion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwAfDepreciacionDetalle>(entity =>
        {
            entity.ToView("vwAf_Depreciacion_Detalle");
        });

        modelBuilder.Entity<VwAfMejBajActivo>(entity =>
        {
            entity.ToView("vwAf_Mej_Baj_Activo");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwAfOrdenCompraXProveedorFacturaActivoFijo>(entity =>
        {
            entity.ToView("vwAF_OrdenCompra_x_Proveedor_Factura_ActivoFijo");

            entity.Property(e => e.NomBodega).IsFixedLength();
        });

        modelBuilder.Entity<VwAfOrdenCompraXProveedorFacturaSinCruceActivoFijo>(entity =>
        {
            entity.ToView("vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo");

            entity.Property(e => e.NomBodega).IsFixedLength();
        });

        modelBuilder.Entity<VwAfRetiroActivo>(entity =>
        {
            entity.ToView("vwAf_Retiro_Activo");

            entity.Property(e => e.CodRetActivo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwAfValoresDepreContabilizar>(entity =>
        {
            entity.ToView("vwAf_Valores_Depre_Contabilizar");

            entity.Property(e => e.CodDepreciacion).IsFixedLength();
        });

        modelBuilder.Entity<VwAfValoresDepreXAf>(entity =>
        {
            entity.ToView("vwAf_ValoresDepre_x_AF");
        });

        modelBuilder.Entity<VwAfVentaActivo>(entity =>
        {
            entity.ToView("vwAf_Venta_Activo");

            entity.Property(e => e.CodVtaActivo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwBaChequexCbteCtble>(entity =>
        {
            entity.ToView("vwBa_ChequexCbteCtble");

            entity.Property(e => e.CbChequeImpreso).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwBaSucursalXTipoCobro>(entity =>
        {
            entity.ToView("vwBA_Sucursal_x_TipoCobro");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwBanEdehsaRpt001>(entity =>
        {
            entity.ToView("vwBAN_EDEHSA_Rpt001");

            entity.Property(e => e.EsChqImpreso).HasDefaultValueSql("''");
            entity.Property(e => e.FchPostFechado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt001>(entity =>
        {
            entity.ToView("vwBAN_Rpt001");

            entity.Property(e => e.EsChqImpreso).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.FchPostFechado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt002>(entity =>
        {
            entity.ToView("vwBAN_Rpt002");

            entity.Property(e => e.EsChqImpreso).HasDefaultValueSql("''");
            entity.Property(e => e.FchPostFechado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt003>(entity =>
        {
            entity.ToView("vwBAN_Rpt003");

            entity.Property(e => e.Banco).HasDefaultValueSql("''");
            entity.Property(e => e.CtaCbleBanco).HasDefaultValueSql("''");
            entity.Property(e => e.EsChqImpreso).HasDefaultValueSql("''");
            entity.Property(e => e.FchCbte).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.FchPostFechado).IsFixedLength();
            entity.Property(e => e.NombreCortoFecha).HasDefaultValueSql("''");
            entity.Property(e => e.TipoCbte).HasDefaultValueSql("''");
            entity.Property(e => e.TipoRegistro).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwBanRpt004>(entity =>
        {
            entity.ToView("vwBAN_Rpt004");

            entity.Property(e => e.Banco).HasDefaultValueSql("''");
            entity.Property(e => e.CtaCbleBanco).HasDefaultValueSql("''");
            entity.Property(e => e.EsChqImpreso).HasDefaultValueSql("''");
            entity.Property(e => e.FchCbte).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.FchPostFechado).IsFixedLength();
            entity.Property(e => e.NombreCortoFecha).HasDefaultValueSql("''");
            entity.Property(e => e.TipoCbte).HasDefaultValueSql("''");
            entity.Property(e => e.TipoRegistro).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwBanRpt005>(entity =>
        {
            entity.ToView("vwBAN_Rpt005");

            entity.Property(e => e.BaDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.BaNumCuenta)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CbChequeImpreso).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt006>(entity =>
        {
            entity.ToView("vwBAN_Rpt006");

            entity.Property(e => e.CbChequeImpreso).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NombreProveedor)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.PorAnticipo).IsFixedLength();
            entity.Property(e => e.PosFechado).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt007>(entity =>
        {
            entity.ToView("vwBAN_Rpt007");

            entity.Property(e => e.CbFecha).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.NomBanco).HasDefaultValueSql("''");
            entity.Property(e => e.NomTipoFlujo).HasDefaultValueSql("''");
            entity.Property(e => e.TipoCbteCxp)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TipoCbtePago)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TipoMovi).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwBanRpt010>(entity =>
        {
            entity.ToView("vwBAN_Rpt010");

            entity.Property(e => e.CbFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Descripcion).HasDefaultValueSql("''");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.NomBanco).HasDefaultValueSql("''");
            entity.Property(e => e.NomCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.NomEmpresa).HasDefaultValueSql("''");
            entity.Property(e => e.RucEmpresa).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwBanRpt011>(entity =>
        {
            entity.ToView("vwBAN_Rpt011");

            entity.Property(e => e.CodTipoCbte).IsFixedLength();
            entity.Property(e => e.Referencia).IsFixedLength();
            entity.Property(e => e.TipoCbte).IsFixedLength();
            entity.Property(e => e.TituloGrupo).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt012>(entity =>
        {
            entity.ToView("vwBAN_Rpt012");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt013>(entity =>
        {
            entity.ToView("vwBAN_Rpt013");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt014>(entity =>
        {
            entity.ToView("vwBAN_Rpt014");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt015>(entity =>
        {
            entity.ToView("vwBAN_Rpt015");

            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.NomTipocbte).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt016>(entity =>
        {
            entity.ToView("vwBAN_Rpt016");

            entity.Property(e => e.CbChequeImpreso).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.PorAnticipo).IsFixedLength();
            entity.Property(e => e.PosFechado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt018>(entity =>
        {
            entity.ToView("vwBAN_Rpt018");

            entity.Property(e => e.CbChequeImpreso).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwBanRpt019>(entity =>
        {
            entity.ToView("vwBAN_Rpt019");

            entity.Property(e => e.CoFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwCajRpt001>(entity =>
        {
            entity.ToView("vwCAJ_Rpt001");

            entity.Property(e => e.Sucursal).IsFixedLength();
            entity.Property(e => e.TipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwCajRpt002>(entity =>
        {
            entity.ToView("vwCAJ_Rpt002");

            entity.Property(e => e.CmSigno).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.TipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwCajRpt003>(entity =>
        {
            entity.ToView("vwCAJ_Rpt003");

            entity.Property(e => e.CaDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Descripcion).HasDefaultValueSql("''");
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoCierre).HasDefaultValueSql("''");
            entity.Property(e => e.IdOrdenGiroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.ReTipoRetRf).IsFixedLength();
            entity.Property(e => e.ReTipoRetRiva).IsFixedLength();
            entity.Property(e => e.Smes).HasDefaultValueSql("''");
            entity.Property(e => e.TmDescripcion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCajRpt004>(entity =>
        {
            entity.ToView("vwCAJ_Rpt004");

            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdEstadoCierre).HasDefaultValueSql("''");
            entity.Property(e => e.NomCaja).HasDefaultValueSql("''");
            entity.Property(e => e.NomTipoCbte).IsFixedLength();
            entity.Property(e => e.PcCuenta).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCajRpt005>(entity =>
        {
            entity.ToView("vwCAJ_Rpt005");

            entity.Property(e => e.CmSigno).IsFixedLength();
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCajRpt006>(entity =>
        {
            entity.ToView("vwCAJ_Rpt006");

            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaConci).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoCierre).HasDefaultValueSql("''");
            entity.Property(e => e.NomCaja).HasDefaultValueSql("''");
            entity.Property(e => e.NomTipoMovi).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.TipoDocumento).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCajRpt007>(entity =>
        {
            entity.ToView("vwCAJ_Rpt007");

            entity.Property(e => e.Check).HasDefaultValueSql("'0'");
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwCajTalonarioRecibo>(entity =>
        {
            entity.ToView("vwCaj_Talonario_Recibo");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCompEdehsaRpt001>(entity =>
        {
            entity.ToView("vwCOMP_EDEHSA_Rpt001");

            entity.Property(e => e.EstadoOc).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwCompEdehsaRpt002>(entity =>
        {
            entity.ToView("vwCOMP_EDEHSA_Rpt002");
        });

        modelBuilder.Entity<VwCompRpt001>(entity =>
        {
            entity.ToView("vwCOMP_Rpt001");

            entity.Property(e => e.CentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.PrContribuyenteEspecial).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt001Ge>(entity =>
        {
            entity.ToView("vwCOMP_Rpt001_GE");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.PrContribuyenteEspecial).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt002>(entity =>
        {
            entity.ToView("vwCOMP_Rpt002");

            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt003>(entity =>
        {
            entity.ToView("vwCOMP_Rpt003");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.CmTipo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt004>(entity =>
        {
            entity.ToView("vwCOMP_Rpt004");
        });

        modelBuilder.Entity<VwCompRpt005>(entity =>
        {
            entity.ToView("vwCOMP_Rpt005");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt006>(entity =>
        {
            entity.ToView("vwCOMP_Rpt006");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt008>(entity =>
        {
            entity.ToView("vwCOMP_Rpt008");
        });

        modelBuilder.Entity<VwCompRpt009>(entity =>
        {
            entity.ToView("vwCOMP_Rpt009");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt011>(entity =>
        {
            entity.ToView("vwCOMP_Rpt011");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt012>(entity =>
        {
            entity.ToView("vwCOMP_Rpt012");

            entity.Property(e => e.PrContribuyenteEspecial).IsFixedLength();
        });

        modelBuilder.Entity<VwCompRpt013>(entity =>
        {
            entity.ToView("vwCOMP_Rpt013");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.PrContribuyenteEspecial).IsFixedLength();
        });

        modelBuilder.Entity<VwContaEdehsaRpt001>(entity =>
        {
            entity.ToView("vwCONTA_EDEHSA_Rpt001");

            entity.Property(e => e.CbEstado).IsFixedLength();
            entity.Property(e => e.CbObservacion).HasDefaultValueSql("''");
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwContaEdehsaRpt003>(entity =>
        {
            entity.ToView("vwCONTA_EDEHSA_Rpt003");

            entity.Property(e => e.CbEstado).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwContaEdehsaRpt004>(entity =>
        {
            entity.ToView("vwCONTA_EDEHSA_Rpt004");

            entity.Property(e => e.GcEstadoFinanciero).IsFixedLength();
        });

        modelBuilder.Entity<VwContaRpt001>(entity =>
        {
            entity.ToView("vwCONTA_Rpt001");

            entity.Property(e => e.GcEstadoFinanciero).HasDefaultValueSql("''");
            entity.Property(e => e.GcGrupoCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdGrupoCble).HasDefaultValueSql("''");
            entity.Property(e => e.PcCuenta).HasDefaultValueSql("''");
            entity.Property(e => e.PcNaturaleza).IsFixedLength();
            entity.Property(e => e.SidPeriodo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwContaRpt002>(entity =>
        {
            entity.ToView("vwCONTA_Rpt002");

            entity.Property(e => e.GcEstadoFinanciero).HasDefaultValueSql("''");
            entity.Property(e => e.GcGrupoCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdGrupoCble).HasDefaultValueSql("''");
            entity.Property(e => e.PcCuenta).HasDefaultValueSql("''");
            entity.Property(e => e.PcNaturaleza).IsFixedLength();
            entity.Property(e => e.SidPeriodo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwContaRpt003>(entity =>
        {
            entity.ToView("vwCONTA_Rpt003");

            entity.Property(e => e.CbEstado).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwContaRpt004>(entity =>
        {
            entity.ToView("vwCONTA_Rpt004");

            entity.Property(e => e.PcEsFlujoEfectivo).IsFixedLength();
            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
            entity.Property(e => e.PcEstado).IsFixedLength();
            entity.Property(e => e.PcNaturaleza).IsFixedLength();
        });

        modelBuilder.Entity<VwContaRpt005>(entity =>
        {
            entity.ToView("vwCONTA_Rpt005");

            entity.Property(e => e.NaturalezaCta).IsFixedLength();
            entity.Property(e => e.TipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwContaRpt008>(entity =>
        {
            entity.ToView("vwCONTA_Rpt008");

            entity.Property(e => e.CodTipoCbte).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwContaRpt009>(entity =>
        {
            entity.ToView("vwCONTA_Rpt009");

            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.NomCuenta).HasDefaultValueSql("''");
            entity.Property(e => e.TcTipoCbte)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwContaRpt014>(entity =>
        {
            entity.ToView("vwCONTA_Rpt014");

            entity.Property(e => e.CentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.GcGrupoCble).IsFixedLength();
            entity.Property(e => e.NomPuntoCargo).HasDefaultValueSql("''");
            entity.Property(e => e.NomPuntoCargoGrupo).HasDefaultValueSql("''");
            entity.Property(e => e.NomSubcentro).HasDefaultValueSql("''");
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwContaRpt024>(entity =>
        {
            entity.ToView("vwCONTA_Rpt024");

            entity.Property(e => e.Tipo).IsFixedLength();
        });

        modelBuilder.Entity<VwCpRetencionValorTotal>(entity =>
        {
            entity.ToView("vwCP_Retencion_Valor_total");
        });

        modelBuilder.Entity<VwCxcCatalogoIdAutoNumeric>(entity =>
        {
            entity.ToView("vwCxc_Catalogo_IdAuto_numeric");

            entity.Property(e => e.IdCatalogo).HasDefaultValueSql("''");
            entity.Property(e => e.Observacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt001>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt001");

            entity.Property(e => e.DescripcionTipCliente).HasDefaultValueSql("''");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwCxcEdehsaRpt001Result>(entity =>
        {
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt002>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt002");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt003>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt003");

            entity.Property(e => e.CrFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.TcDescripcion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxcEdehsaRpt004>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt004");

            entity.Property(e => e.CrFechaCobro).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeDireccion).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt005>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt005");

            entity.Property(e => e.CrFechaCobro).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeDireccion).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt006>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt006");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt007>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt007");

            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwCxcEdehsaRpt008>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt008");

            entity.Property(e => e.DescripcionTipCliente).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwCxcEdehsaRpt009>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt009");

            entity.Property(e => e.CrEsAnticipo).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt011>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt011");

            entity.Property(e => e.CrEsAnticipo).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt012>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt012");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEdehsaRpt014>(entity =>
        {
            entity.ToView("vwCXC_EDEHSA_Rpt014");

            entity.Property(e => e.Archivo)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CodigoContrato)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.EstadoContrato)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdEstadoCierre)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Observacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcEstadoCtaXCliente>(entity =>
        {
            entity.ToView("vwCXC_EstadoCta_x_Cliente");

            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Saldo).IsFixedLength();
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.ValorVencido).IsFixedLength();
            entity.Property(e => e.ValorXPagar).IsFixedLength();
            entity.Property(e => e.VtFechVenc).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxcRpt001>(entity =>
        {
            entity.ToView("vwCXC_Rpt001");
        });

        modelBuilder.Entity<VwCxcRpt001Result>(entity =>
        {
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcRpt002>(entity =>
        {
            entity.ToView("vwCXC_Rpt002");
        });

        modelBuilder.Entity<VwCxcRpt003>(entity =>
        {
            entity.ToView("vwCXC_Rpt003");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcRpt004>(entity =>
        {
            entity.ToView("vwCXC_Rpt004");

            entity.Property(e => e.CrFechaCobro).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeDireccion).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwCxcRpt005>(entity =>
        {
            entity.ToView("vwCXC_Rpt005");

            entity.Property(e => e.CrFechaCobro).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeDireccion).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwCxcRpt006>(entity =>
        {
            entity.ToView("vwCXC_Rpt006");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcRpt007>(entity =>
        {
            entity.ToView("vwCXC_Rpt007");

            entity.Property(e => e.DescripcionTipCliente).HasDefaultValueSql("''");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwCxcRpt011>(entity =>
        {
            entity.ToView("vwCXC_Rpt011");

            entity.Property(e => e.DescripcionTipCliente).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwCxcRpt013>(entity =>
        {
            entity.ToView("vwCXC_Rpt013");

            entity.Property(e => e.FechaCobro).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaFact).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaRetencion).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NomTipoCobro).HasDefaultValueSql("''");
            entity.Property(e => e.NomTipoRetencion).HasDefaultValueSql("''");
            entity.Property(e => e.RucCed).HasDefaultValueSql("''");
            entity.Property(e => e.TipoRetencion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxcRpt014>(entity =>
        {
            entity.ToView("vwCXC_Rpt014");

            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwCxcRpt016>(entity =>
        {
            entity.ToView("vwCXC_Rpt016");

            entity.Property(e => e.CrFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.TcDescripcion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxcRpt019>(entity =>
        {
            entity.ToView("vwCXC_Rpt019");

            entity.Property(e => e.BoDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CiudadNom).HasDefaultValueSql("''");
            entity.Property(e => e.CodCbteVta).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdCiudad).HasDefaultValueSql("''");
            entity.Property(e => e.IdProvincia).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.ProvinciaNom).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoVenta).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxcRpt0191>(entity =>
        {
            entity.ToView("vwCXC_Rpt019_1");
        });

        modelBuilder.Entity<VwCxcRpt0192>(entity =>
        {
            entity.ToView("vwCXC_Rpt019_2");
        });

        modelBuilder.Entity<VwCxcRpt020>(entity =>
        {
            entity.ToView("vwCXC_Rpt020");

            entity.Property(e => e.CbEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpEdehsaRpt005>(entity =>
        {
            entity.ToView("vwCXP_EDEHSA_Rpt005");

            entity.Property(e => e.Cuenta).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaDocumento).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpEdehsaRpt006>(entity =>
        {
            entity.ToView("vwCXP_EDEHSA_Rpt006");
        });

        modelBuilder.Entity<VwCxpEdehsaRpt007>(entity =>
        {
            entity.ToView("vwCXP_EDEHSA_Rpt007");

            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Codigo).HasDefaultValueSql("''");
            entity.Property(e => e.DescripcionClasProve).HasDefaultValueSql("''");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdOrdenGiroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.PcCuenta).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt001>(entity =>
        {
            entity.ToView("vwCXP_Rpt001");

            entity.Property(e => e.DescripcionClasProve).HasDefaultValueSql("''");
            entity.Property(e => e.Documento).HasDefaultValueSql("''");
            entity.Property(e => e.RucProveedor).HasDefaultValueSql("''");
            entity.Property(e => e.TipoCbte).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt002>(entity =>
        {
            entity.ToView("vwCXP_Rpt002");

            entity.Property(e => e.Documento).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt003>(entity =>
        {
            entity.ToView("vwCXP_Rpt003");

            entity.Property(e => e.CodTipoCbte).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt004>(entity =>
        {
            entity.ToView("vwCXP_Rpt004");

            entity.Property(e => e.CodTipoCbte).IsFixedLength();
            entity.Property(e => e.NomTipoCbteRet).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.TieneRtfte).IsFixedLength();
            entity.Property(e => e.TieneRtiva).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt005>(entity =>
        {
            entity.ToView("vwCXP_Rpt005");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt006>(entity =>
        {
            entity.ToView("vwCXP_Rpt006");

            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.NomTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt007>(entity =>
        {
            entity.ToView("vwCXP_Rpt007");

            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.NomTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt008>(entity =>
        {
            entity.ToView("vwCXP_Rpt008");

            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CodClaseProveedor).HasDefaultValueSql("''");
            entity.Property(e => e.DescripcionClasProve).HasDefaultValueSql("''");
            entity.Property(e => e.Documento).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.PrCodigo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt010>(entity =>
        {
            entity.ToView("vwCXP_Rpt010");

            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CodTipoDoc).HasDefaultValueSql("''");
            entity.Property(e => e.Documento).HasDefaultValueSql("''");
            entity.Property(e => e.IdOrdenGiroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.NomTipoDoc).HasDefaultValueSql("''");
            entity.Property(e => e.RucProveedor).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt011>(entity =>
        {
            entity.ToView("vwCXP_Rpt011");

            entity.Property(e => e.Impuesto).IsFixedLength();
            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt012>(entity =>
        {
            entity.ToView("vwCXP_Rpt012");

            entity.Property(e => e.CoFechaFacturaVct).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CodTipoDoc).HasDefaultValueSql("''");
            entity.Property(e => e.Documento).HasDefaultValueSql("''");
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdOrdenGiroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.NombreCortoFecha).HasDefaultValueSql("''");
            entity.Property(e => e.TipoRegistro).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt015>(entity =>
        {
            entity.ToView("vwCXP_Rpt015");

            entity.Property(e => e.Impuesto).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt016>(entity =>
        {
            entity.ToView("vwCXP_Rpt016");

            entity.Property(e => e.CodTipoCbte).IsFixedLength();
            entity.Property(e => e.NumFactura).HasDefaultValueSql("''");
            entity.Property(e => e.SaldoOg).HasDefaultValueSql("'0'");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.TotalRetencion).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<VwCxpRpt018>(entity =>
        {
            entity.ToView("vwCXP_Rpt018");

            entity.Property(e => e.Documento).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.ReTipoRet).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt019>(entity =>
        {
            entity.ToView("vwCXP_Rpt019");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoCierre).HasDefaultValueSql("''");
            entity.Property(e => e.Nombre).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt021>(entity =>
        {
            entity.ToView("vwCXP_Rpt021");

            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdCentroCostoSubCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt022>(entity =>
        {
            entity.ToView("vwCXP_Rpt022");

            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdCentroCostoSubCentroCosto).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt023>(entity =>
        {
            entity.ToView("vwCXP_Rpt023");

            entity.Property(e => e.ReTipoRet).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt024>(entity =>
        {
            entity.ToView("vwCXP_Rpt024");

            entity.Property(e => e.ReTipoRet).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt025>(entity =>
        {
            entity.ToView("vwCXP_Rpt025");

            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt026>(entity =>
        {
            entity.ToView("vwCXP_Rpt026");
        });

        modelBuilder.Entity<VwCxpRpt027>(entity =>
        {
            entity.ToView("vwCXP_Rpt027");
        });

        modelBuilder.Entity<VwCxpRpt028>(entity =>
        {
            entity.ToView("vwCXP_Rpt028");
        });

        modelBuilder.Entity<VwCxpRpt029>(entity =>
        {
            entity.ToView("vwCXP_Rpt029");

            entity.Property(e => e.Factura).HasDefaultValueSql("''");
            entity.Property(e => e.ReTipoRet).IsFixedLength();
            entity.Property(e => e.TieneRetencion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt030>(entity =>
        {
            entity.ToView("vwCXP_Rpt030");

            entity.Property(e => e.CoDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.CoVaCoa).HasDefaultValueSql("''");
            entity.Property(e => e.Codigo).HasDefaultValueSql("''");
            entity.Property(e => e.CodigoSri).HasDefaultValueSql("''");
            entity.Property(e => e.Descripcion).HasDefaultValueSql("''");
            entity.Property(e => e.FechaEmision).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdOrdenGiroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.TipoServicio).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwCxpRpt031>(entity =>
        {
            entity.ToView("vwCXP_Rpt031");
        });

        modelBuilder.Entity<VwCxpRpt032>(entity =>
        {
            entity.ToView("vwCXP_Rpt032");
        });

        modelBuilder.Entity<VwCxpRpt033>(entity =>
        {
            entity.ToView("vwCXP_Rpt033");
        });

        modelBuilder.Entity<VwCxpRpt034>(entity =>
        {
            entity.ToView("vwCXP_Rpt034");

            entity.Property(e => e.Impuesto).IsFixedLength();
            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt036>(entity =>
        {
            entity.ToView("vwCXP_Rpt036");

            entity.Property(e => e.ReTipoRet).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt039>(entity =>
        {
            entity.ToView("vwCXP_Rpt039");

            entity.Property(e => e.OcEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwCxpRpt040>(entity =>
        {
            entity.ToView("vwCXP_Rpt040");

            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwEstadoCivil>(entity =>
        {
            entity.ToView("vw_EstadoCivil");
        });

        modelBuilder.Entity<VwFaDocumentoDeclaracionSri>(entity =>
        {
            entity.ToView("vwFa_Documento_DeclaracionSRI");

            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.RazonSocial).HasDefaultValueSql("''");
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwFaDocumentoDeclaracionSriData>(entity =>
        {
            entity.ToView("vwFa_Documento_DeclaracionSRI_DATA");

            entity.Property(e => e.IdCliente).HasDefaultValueSql("''");
            entity.Property(e => e.RazonSocial).HasDefaultValueSql("''");
            entity.Property(e => e.TpIdCliente).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwFaDocumentosRelacionadosNcNd>(entity =>
        {
            entity.ToView("vwFa_Documentos_Relacionados_NC_ND");

            entity.Property(e => e.Bodega)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CodComprobante).HasDefaultValueSql("''");
            entity.Property(e => e.EmNombre).HasDefaultValueSql("''");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwFaDocumentosXRelacionarNcNd>(entity =>
        {
            entity.ToView("vwFa_Documentos_x_Relacionar_NC_ND");

            entity.Property(e => e.Bodega)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CodComprobante).HasDefaultValueSql("''");
            entity.Property(e => e.EmNombre).HasDefaultValueSql("''");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwFaFacturasConDevolucionxItemSaldos>(entity =>
        {
            entity.ToView("vwFa_FacturasConDevolucionxItemSaldos");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwFaFacturasYNotasDebito>(entity =>
        {
            entity.ToView("vwFa_Facturas_y_NotasDebito");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwFaFacturasxDevolucionxItem>(entity =>
        {
            entity.ToView("vwFa_FacturasxDevolucionxItem");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwFaFormasPagoXFacturaDeclaracionSri>(entity =>
        {
            entity.ToView("vwFa_Formas_Pago_x_Factura_DeclaracionSRI");
        });

        modelBuilder.Entity<VwFaPedidoDetXOrdenDespConSaldo>(entity =>
        {
            entity.ToView("vwFa_Pedido_det_x_orden_desp_conSaldo");

            entity.Property(e => e.DetelleSys).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwFaProductoXPedidos>(entity =>
        {
            entity.ToView("vwFa_Producto_x_Pedidos");
        });

        modelBuilder.Entity<VwFaTipoNotaXEmpresa>(entity =>
        {
            entity.ToView("vwFa_TipoNota_x_Empresa");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.InternoSis).IsFixedLength();
            entity.Property(e => e.SeDeclaraSri).IsFixedLength();
            entity.Property(e => e.Tipo).IsFixedLength();
        });

        modelBuilder.Entity<VwFaTotalPedidosXClienteNoDespachados>(entity =>
        {
            entity.ToView("vwFa_Total_pedidos_x_cliente_No_despachados");
        });

        modelBuilder.Entity<VwFaVentasXClienteXPeriodoBi>(entity =>
        {
            entity.ToView("vwFa_Ventas_x_cliente_x_periodo_BI");

            entity.Property(e => e.Bodega).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
            entity.Property(e => e.Vendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacEdehsaRpt001>(entity =>
        {
            entity.ToView("vwFAC_EDEHSA_Rpt001");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.TipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwFacEdehsaRpt002>(entity =>
        {
            entity.ToView("vwFAC_EDEHSA_Rpt002");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.TipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwFacEdehsaRpt003>(entity =>
        {
            entity.ToView("vwFAC_EDEHSA_Rpt003");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt001>(entity =>
        {
            entity.ToView("vwFAC_Rpt001");

            entity.Property(e => e.DescripcionTipCliente).HasDefaultValueSql("''");
            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.NombreCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NombreCortoFecha).HasDefaultValueSql("''");
            entity.Property(e => e.NombreProducto).HasDefaultValueSql("''");
            entity.Property(e => e.NumDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Vendedor).IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwFacRpt002>(entity =>
        {
            entity.ToView("vwFAC_Rpt002");

            entity.Property(e => e.IdUsuario)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt003>(entity =>
        {
            entity.ToView("vwFAC_Rpt003");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt004>(entity =>
        {
            entity.ToView("vwFAC_Rpt004");

            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.NaturalezaNota).IsFixedLength();
            entity.Property(e => e.NumDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt004Detalle>(entity =>
        {
            entity.ToView("vwFAC_Rpt004_Detalle");

            entity.Property(e => e.NaturalezaNota).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt005>(entity =>
        {
            entity.ToView("vwFAC_Rpt005");

            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt006>(entity =>
        {
            entity.ToView("vwFAC_Rpt006");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuario).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt007>(entity =>
        {
            entity.ToView("vwFAC_Rpt007");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt008>(entity =>
        {
            entity.ToView("vwFAC_Rpt008");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt009>(entity =>
        {
            entity.ToView("vwFAC_Rpt009");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt010>(entity =>
        {
            entity.ToView("vwFAC_Rpt010");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt011>(entity =>
        {
            entity.ToView("vwFAC_Rpt011");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdUsuario).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt012>(entity =>
        {
            entity.ToView("vwFAC_Rpt012");

            entity.Property(e => e.CedRucCliente).HasDefaultValueSql("''");
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomEmpresa).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt013>(entity =>
        {
            entity.ToView("vwFAC_Rpt013");

            entity.Property(e => e.CedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomEmpresa).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwFacRpt014>(entity =>
        {
            entity.ToView("vwFAC_Rpt014");
        });

        modelBuilder.Entity<VwFacRpt016>(entity =>
        {
            entity.ToView("vwFAC_Rpt016");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomGrupo).HasDefaultValueSql("''");
            entity.Property(e => e.PrDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.TipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwGeTbSisDocumentoTipoTalonario>(entity =>
        {
            entity.ToView("vwGe_tb_sis_Documento_Tipo_Talonario");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwGeTbTarjetaTbParametro>(entity =>
        {
            entity.ToView("vwGe_tb_Tarjeta_tb_Parametro");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwInDashboardGuiaRemision>(entity =>
        {
            entity.ToView("vwIn_Dashboard_GuiaRemision");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NumDocumento).IsFixedLength();
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.Serie1).IsFixedLength();
            entity.Property(e => e.Serie2).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwInIngEgrInvenDetXCbteCble>(entity =>
        {
            entity.ToView("vwIn_Ing_Egr_Inven_det_x_Cbte_Cble");
        });

        modelBuilder.Entity<VwInvEdehsaRpt001>(entity =>
        {
            entity.ToView("vwINV_EDEHSA_Rpt001");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt001>(entity =>
        {
            entity.ToView("vwINV_Rpt001");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt002>(entity =>
        {
            entity.ToView("vwINV_Rpt002");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt003>(entity =>
        {
            entity.ToView("vwINV_Rpt003");

            entity.Property(e => e.Bodega).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt004>(entity =>
        {
            entity.ToView("vwINV_Rpt004");

            entity.Property(e => e.EstadoOc).IsFixedLength();
            entity.Property(e => e.EstadoPago).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwInvRpt005>(entity =>
        {
            entity.ToView("vwINV_Rpt005");

            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt006>(entity =>
        {
            entity.ToView("vwINV_Rpt006");

            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt007>(entity =>
        {
            entity.ToView("vwINV_Rpt007");

            entity.Property(e => e.BoDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CaCategoria).HasDefaultValueSql("''");
            entity.Property(e => e.CodAjusteFisico).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCategoria).HasDefaultValueSql("''");
            entity.Property(e => e.NomEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.NomLinea).HasDefaultValueSql("''");
            entity.Property(e => e.NomUnidadMedida).HasDefaultValueSql("''");
            entity.Property(e => e.Observacion).HasDefaultValueSql("''");
            entity.Property(e => e.PrCodigo).HasDefaultValueSql("''");
            entity.Property(e => e.PrDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TipoEgreso).HasDefaultValueSql("''");
            entity.Property(e => e.TipoIngreso).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwInvRpt009>(entity =>
        {
            entity.ToView("vwINV_Rpt009");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt010>(entity =>
        {
            entity.ToView("vwINV_Rpt010");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt011>(entity =>
        {
            entity.ToView("vwINV_Rpt011");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt012>(entity =>
        {
            entity.ToView("vwINV_Rpt012");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt013>(entity =>
        {
            entity.ToView("vwINV_Rpt013");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt015>(entity =>
        {
            entity.ToView("vwINV_Rpt015");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt016>(entity =>
        {
            entity.ToView("vwINV_Rpt016");

            entity.Property(e => e.CmTipoMovi).IsFixedLength();
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.NomSubCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt017>(entity =>
        {
            entity.ToView("vwINV_Rpt017");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodegaDestino).IsFixedLength();
            entity.Property(e => e.NomBodegaOrigen).IsFixedLength();
            entity.Property(e => e.NomSucursalDestino).IsFixedLength();
            entity.Property(e => e.NomSucursalOrigen).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt019>(entity =>
        {
            entity.ToView("vwINV_Rpt019");

            entity.Property(e => e.CmTipo).IsFixedLength();
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubcentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt020>(entity =>
        {
            entity.ToView("vwINV_Rpt020");

            entity.Property(e => e.CmTipo).IsFixedLength();
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubcentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt022>(entity =>
        {
            entity.ToView("vwINV_Rpt022");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt023>(entity =>
        {
            entity.ToView("vwINV_Rpt023");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt024>(entity =>
        {
            entity.ToView("vwINV_Rpt024");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.Tipo).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt025>(entity =>
        {
            entity.ToView("vwINV_Rpt025");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Signo).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt028>(entity =>
        {
            entity.ToView("vwINV_Rpt028");
        });

        modelBuilder.Entity<VwInvRpt030>(entity =>
        {
            entity.ToView("vwINV_Rpt030");

            entity.Property(e => e.CmTipo).IsFixedLength();
            entity.Property(e => e.IdCentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubcentroCosto).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt031>(entity =>
        {
            entity.ToView("vwINV_Rpt031");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.Stock).HasDefaultValueSql("'0'");
            entity.Property(e => e.TpManejaInven).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt037>(entity =>
        {
            entity.ToView("vwINV_Rpt037");

            entity.Property(e => e.NumDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.TipoDocumento).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwInvRpt038>(entity =>
        {
            entity.ToView("vwINV_Rpt038");

            entity.Property(e => e.BodegDest).IsFixedLength();
            entity.Property(e => e.BodegaOrig).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SucuDest).IsFixedLength();
            entity.Property(e => e.SucuOrigen).IsFixedLength();
        });

        modelBuilder.Entity<VwInvRpt039>(entity =>
        {
            entity.ToView("vwINV_Rpt039");

            entity.Property(e => e.NumDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.TipoDocumento).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwInvRpt041>(entity =>
        {
            entity.ToView("vwINV_Rpt041");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NumDocumento).IsFixedLength();
            entity.Property(e => e.Serie1).IsFixedLength();
            entity.Property(e => e.Serie2).IsFixedLength();
        });

        modelBuilder.Entity<VwNaturalezaPersona>(entity =>
        {
            entity.ToView("vw_NaturalezaPersona");
        });

        modelBuilder.Entity<VwOrdenPagoCancelacionesTotalAplicado>(entity =>
        {
            entity.ToView("vw_orden_pago_cancelaciones_TotalAplicado");
        });

        modelBuilder.Entity<VwPersona>(entity =>
        {
            entity.ToView("vw_Persona");
        });

        modelBuilder.Entity<VwSegMenuXUsuarioXEmpresa>(entity =>
        {
            entity.ToView("vw_Seg_Menu_x_Usuario_x_Empresa");
        });

        modelBuilder.Entity<VwSysCbteRecursivo>(entity =>
        {
            entity.ToView("vwSys_Cbte_Recursivo");

            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwTipoCtaBancos>(entity =>
        {
            entity.ToView("vw_TipoCtaBancos");
        });

        modelBuilder.Entity<VwTipoDocumento>(entity =>
        {
            entity.ToView("vw_TipoDocumento");
        });

        modelBuilder.Entity<VwTipoEmpleado>(entity =>
        {
            entity.ToView("vw_TipoEmpleado");
        });

        modelBuilder.Entity<VwTipoEstudios>(entity =>
        {
            entity.ToView("vw_TipoEstudios");
        });

        modelBuilder.Entity<VwTipoSangre>(entity =>
        {
            entity.ToView("vw_TipoSangre");
        });

        modelBuilder.Entity<VwTipoTitulo>(entity =>
        {
            entity.ToView("vw_TipoTitulo");
        });

        modelBuilder.Entity<VwUsuario>(entity =>
        {
            entity.ToView("vw_usuario");

            entity.Property(e => e.CodPersona)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwafPeriodoSinDepreciar>(entity =>
        {
            entity.ToView("vwaf_Periodo_Sin_Depreciar");
        });

        modelBuilder.Entity<VwbaBaBancoCuenta>(entity =>
        {
            entity.ToView("vwba_ba_Banco_Cuenta");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwbaBaPrestamoDetalleXAfActivoFijoPrendados>(entity =>
        {
            entity.ToView("vwba_ba_prestamo_detalle_x_af_activo_fijo_Prendados");
        });

        modelBuilder.Entity<VwbaBancoEstadoCheques>(entity =>
        {
            entity.ToView("vwba_Banco_Estado_Cheques");
        });

        modelBuilder.Entity<VwbaBancoMovimientoDetCancelado>(entity =>
        {
            entity.ToView("vwba_Banco_Movimiento_det_cancelado");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
            entity.Property(e => e.PosFechado).IsFixedLength();
        });

        modelBuilder.Entity<VwbaBancoMovimientoDetCanceladoLite>(entity =>
        {
            entity.ToView("vwba_Banco_Movimiento_det_cancelado_lite");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
            entity.Property(e => e.PosFechado).IsFixedLength();
        });

        modelBuilder.Entity<VwbaCatalogoIdAutoNumeric>(entity =>
        {
            entity.ToView("vwba_Catalogo_IdAuto_numeric");

            entity.Property(e => e.IdCatalogo).HasDefaultValueSql("''");
            entity.Property(e => e.Observacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwbaCbteBan>(entity =>
        {
            entity.ToView("vwba_Cbte_Ban");

            entity.Property(e => e.CbChequeImpreso).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.EstadoConciliacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdEstadoCbteBanCat).HasDefaultValueSql("''");
            entity.Property(e => e.IdEstadoPreavisoChCat).HasDefaultValueSql("''");
            entity.Property(e => e.NombreProveedor)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.PorAnticipo).IsFixedLength();
            entity.Property(e => e.PosFechado).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwbaCbteBanDetallePagos>(entity =>
        {
            entity.ToView("vwba_Cbte_Ban_detallePagos");
        });

        modelBuilder.Entity<VwbaCbteBanTipoXCtCbteCbleTipo>(entity =>
        {
            entity.ToView("vwba_Cbte_Ban_tipo_x_ct_CbteCble_tipo");

            entity.Property(e => e.TipoDebCred).IsFixedLength();
        });

        modelBuilder.Entity<VwbaCbteBanVarios>(entity =>
        {
            entity.ToView("vwba_Cbte_Ban_varios");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwbaConciliacion>(entity =>
        {
            entity.ToView("vwba_Conciliacion");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Periodo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwbaConciliacionDetIngEgr>(entity =>
        {
            entity.ToView("vwba_Conciliacion_det_IngEgr");

            entity.Property(e => e.CodTipoCbte).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.TipoIngEgr).IsFixedLength();
        });

        modelBuilder.Entity<VwbaEstadoCbteBan>(entity =>
        {
            entity.ToView("vwba_Estado_cbte_ban");
        });

        modelBuilder.Entity<VwbaEstadoPago>(entity =>
        {
            entity.ToView("vwba_EstadoPago");
        });

        modelBuilder.Entity<VwbaMetodoCalculo>(entity =>
        {
            entity.ToView("vwba_MetodoCalculo");
        });

        modelBuilder.Entity<VwbaMotivoPrestamo>(entity =>
        {
            entity.ToView("vwba_MotivoPrestamo");
        });

        modelBuilder.Entity<VwbaMoviCajaDepositados>(entity =>
        {
            entity.ToView("vwba_MoviCaja_Depositados");

            entity.Property(e => e.TmSigno).IsFixedLength();
        });

        modelBuilder.Entity<VwbaNotasDebCreMasivo>(entity =>
        {
            entity.ToView("vwba_notasDebCre_masivo");

            entity.Property(e => e.TmTipo).IsFixedLength();
        });

        modelBuilder.Entity<VwbaNotasDebCreMasivoConsul>(entity =>
        {
            entity.ToView("vwba_notasDebCre_masivo_consul");

            entity.Property(e => e.TmTipo).IsFixedLength();
        });

        modelBuilder.Entity<VwbaOpBaArchivoTransferenciaDet>(entity =>
        {
            entity.ToView("vwba_op_ba_Archivo_Transferencia_Det");
        });

        modelBuilder.Entity<VwbaOrdenGiroPendientes>(entity =>
        {
            entity.ToView("vwba_ordenGiroPendientes");
        });

        modelBuilder.Entity<VwbaPeriocidadPago>(entity =>
        {
            entity.ToView("vwba_PeriocidadPago");
        });

        modelBuilder.Entity<VwbaPrestamo>(entity =>
        {
            entity.ToView("vwba_prestamo");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwbaPrestamoDetalleCancelacion>(entity =>
        {
            entity.ToView("vwba_prestamo_detalle_cancelacion");
        });

        modelBuilder.Entity<VwbaTipoFlujo>(entity =>
        {
            entity.ToView("vwba_TipoFlujo");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwbaTipoNota>(entity =>
        {
            entity.ToView("vwba_tipo_nota");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwbaTransaccionesAconciliar>(entity =>
        {
            entity.ToView("vwba_TransaccionesAConciliar");

            entity.Property(e => e.BaDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.CbFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdEstadoConcilCat).HasDefaultValueSql("''");
            entity.Property(e => e.NomIdTipoCbte)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwbaTransferencia>(entity =>
        {
            entity.ToView("vwba_transferencia");

            entity.Property(e => e.IdUsuarioAnu).IsFixedLength();
        });

        modelBuilder.Entity<VwcajCajCaja>(entity =>
        {
            entity.ToView("vwcaj_caj_Caja");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcajCajCajaMovimiento>(entity =>
        {
            entity.ToView("vwcaj_caj_Caja_Movimiento");

            entity.Property(e => e.CmSigno).IsFixedLength();
            entity.Property(e => e.ResponsableCaja)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcajCajaMovimientoDetCancelado>(entity =>
        {
            entity.ToView("vwcaj_Caja_Movimiento_det_cancelado");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcajCajaMovimientoTipo>(entity =>
        {
            entity.ToView("vwcaj_Caja_Movimiento_Tipo");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.TmSigno).IsFixedLength();
        });

        modelBuilder.Entity<VwcajCajaMovimientoTipoConCta>(entity =>
        {
            entity.ToView("vwcaj_Caja_Movimiento_Tipo_conCta");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.TmSigno).IsFixedLength();
        });

        modelBuilder.Entity<VwcajCajaMovimientoXConciliar>(entity =>
        {
            entity.ToView("vwcaj_Caja_Movimiento_x_Conciliar");

            entity.Property(e => e.CmSigno).IsFixedLength();
        });

        modelBuilder.Entity<VwcajCajachica>(entity =>
        {
            entity.ToView("vwcaj_cajachica");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcajCustodio>(entity =>
        {
            entity.ToView("vwcaj_custodio");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcajMovCajaXCobro>(entity =>
        {
            entity.ToView("vwcaj_MovCaja_x_Cobro");

            entity.Property(e => e.DocumentoCobrado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcajMovCajaXCobroAnticipo>(entity =>
        {
            entity.ToView("vwcaj_MovCaja_x_Cobro_Anticipo");

            entity.Property(e => e.DocumentoCobrado).IsFixedLength();
            entity.Property(e => e.IdCtaCbleTipoCobro)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcajMoviXDespositar>(entity =>
        {
            entity.ToView("vwcaj_Movi_x_Despositar");

            entity.Property(e => e.CaDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.CrFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TmDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.TmSigno)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwcomCatalogoIdAutoNumeric>(entity =>
        {
            entity.ToView("vwcom_Catalogo_IdAuto_numeric");

            entity.Property(e => e.IdCatalogocompra).HasDefaultValueSql("''");
            entity.Property(e => e.Observacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwcomCotizacionCompraEdehsa>(entity =>
        {
            entity.ToView("vwcom_cotizacion_compra_Edehsa");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomDevCompra>(entity =>
        {
            entity.ToView("vwcom_dev_compra");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomDevCompraConDet>(entity =>
        {
            entity.ToView("vwcom_dev_compra_con_det");

            entity.Property(e => e.DvCosteado).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomDevCompraDetCantDevueltaXProd>(entity =>
        {
            entity.ToView("vwcom_dev_compra_det_cant_devuelta_x_prod");
        });

        modelBuilder.Entity<VwcomEstadoAnulacion>(entity =>
        {
            entity.ToView("vwcom_EstadoAnulacion");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomEstadoAprobListReq>(entity =>
        {
            entity.ToView("vwcom_EstadoAprob_List_Req");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomEstadoAprobacion>(entity =>
        {
            entity.ToView("vwcom_EstadoAprobacion");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomEstadoAprobacionSolCompra>(entity =>
        {
            entity.ToView("vwcom_EstadoAprobacion_sol_compra");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomEstadoRecibido>(entity =>
        {
            entity.ToView("vwcom_EstadoRecibido");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomMotivoRequerimiento>(entity =>
        {
            entity.ToView("vwcom_MotivoRequerimiento");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocal>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local");

            entity.Property(e => e.AfectaCosto).IsFixedLength();
            entity.Property(e => e.EnGuia).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalConCantDevolver>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_con_cant_devolver");

            entity.Property(e => e.DoCosteado).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDet>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det");

            entity.Property(e => e.DoCosteado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TieneMoviInven).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDetConCantEnviadasXGuiaXTraspaso>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det_con_cant_enviadas_x_Guia_x_Traspaso");
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDetConSaldoXIngAInven>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdEstadoRecepcion).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucu).IsFixedLength();
            entity.Property(e => e.Referencia).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDetConSaldoXIngAInvenConSaldo>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdEstadoRecepcion).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucu).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDetGe>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det_GE");

            entity.Property(e => e.DoCosteado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TieneMoviInven).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDetXCantPedidaSolicCompra>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det_x_cant_pedida_solic_compra");
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDetXComSolicitudCompraDet>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det_x_com_solicitud_compra_det");

            entity.Property(e => e.AfectaCosto).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalDetXMoviInvenSaldoItem>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_det_x_MoviInven_SaldoItem");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalGe>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_GE");

            entity.Property(e => e.AfectaCosto).IsFixedLength();
            entity.Property(e => e.EnGuia).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalSinGuiaXTraspasoBodega>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalSinGuiaXTraspasoBodegaConsul>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalSinGuiaXTraspasoBodegaDet>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_det");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcomOrdencompraLocalVsInGuiaXTraspasoBodegaTotalReg>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_vs_in_Guia_x_traspaso_bodega_Total_Reg");
        });

        modelBuilder.Entity<VwcomOrdencompraLocalXComSolicitudCompra>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_x_com_solicitud_compra");
        });

        modelBuilder.Entity<VwcomOrdencompraLocalXInGuiaXTraspasoBodega>(entity =>
        {
            entity.ToView("vwcom_ordencompra_local_x_in_guia_x_traspaso_bodega");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcionLlegada).IsFixedLength();
        });

        modelBuilder.Entity<VwcomSolicitudCompra>(entity =>
        {
            entity.ToView("vwcom_solicitud_compra");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomSolicitudCompraDet>(entity =>
        {
            entity.ToView("vwcom_solicitud_compra_det");

            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.OcdIdEmpresa).IsFixedLength();
            entity.Property(e => e.OcdIdOrdenCompra).IsFixedLength();
            entity.Property(e => e.OcdIdSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomSolicitudCompraDetAprobacion>(entity =>
        {
            entity.ToView("vwcom_solicitud_compra_det_aprobacion");
        });

        modelBuilder.Entity<VwcomSolicitudCompraDetCantidadPedidaCompra>(entity =>
        {
            entity.ToView("vwcom_SolicitudCompra_Det_CantidadPedida_Compra");
        });

        modelBuilder.Entity<VwcomSolicitudCompraDetSaldoPendiente>(entity =>
        {
            entity.ToView("vwcom_SolicitudCompra_Det_SaldoPendiente");

            entity.Property(e => e.CantidadPedida).HasDefaultValueSql("'0'");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomSolicitudCompraDetXOrdenCompra>(entity =>
        {
            entity.ToView("vwcom_solicitud_compra_det_x_Orden_Compra");
        });

        modelBuilder.Entity<VwcomSolicitudCompraXItemsConSaldos>(entity =>
        {
            entity.ToView("vwcom_solicitud_compra_x_items_con_saldos");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomSolicitudCompraXOrdenCompra>(entity =>
        {
            entity.ToView("vwcom_solicitud_compra_X_Orden_Compra");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcomTerminoPago>(entity =>
        {
            entity.ToView("vwcom_TerminoPago");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpAnticiposParaConciliar>(entity =>
        {
            entity.ToView("vwcp_Anticipos_para_Conciliar");

            entity.Property(e => e.Referencia)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwcpAnticiposProveedores>(entity =>
        {
            entity.ToView("vwcp_Anticipos_Proveedores");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaPago).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpAnticiposXNotaCredSaldo>(entity =>
        {
            entity.ToView("vwcp_Anticipos_x_NotaCred_Saldo");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Referencia).HasDefaultValueSql("''");
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpAprobacionIngBodXOc>(entity =>
        {
            entity.ToView("vwcp_Aprobacion_Ing_Bod_x_OC");
        });

        modelBuilder.Entity<VwcpAprobacionIngBodXOcDet>(entity =>
        {
            entity.ToView("vwcp_Aprobacion_Ing_Bod_x_OC_det");

            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcpBaArchivoTransferenciaDet>(entity =>
        {
            entity.ToView("vwcp_ba_Archivo_Transferencia_Det");
        });

        modelBuilder.Entity<VwcpBaseRetenciones>(entity =>
        {
            entity.ToView("vwcp_base_retenciones");

            entity.Property(e => e.ReTipoRet).IsFixedLength();
        });

        modelBuilder.Entity<VwcpCbteXPagarOg>(entity =>
        {
            entity.ToView("vwcp_Cbte_x_pagar_OG");

            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoSerie).HasDefaultValueSql("''");
            entity.Property(e => e.CodTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.Descripcion).HasDefaultValueSql("''");
            entity.Property(e => e.EmNombre).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.TipoReg).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpCbtesCxpParaConciliar>(entity =>
        {
            entity.ToView("vwcp_cbtes_cxp_para_conciliar");

            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaFacturaVct).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdTipoPersona).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpCbtesCxpParaConciliarConsulta>(entity =>
        {
            entity.ToView("vwcp_cbtes_cxp_para_conciliar_consulta");

            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaFacturaVct).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpCodigoSri>(entity =>
        {
            entity.ToView("vwcp_codigo_SRI");

            entity.Property(e => e.CoCodigoBase).HasDefaultValueSql("''");
            entity.Property(e => e.CoDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.CoEstado).HasDefaultValueSql("''");
            entity.Property(e => e.CoFValidesDesde).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.CoFValidesHasta).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.CodigoSri).HasDefaultValueSql("''");
            entity.Property(e => e.IdTipoSri).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpCodigoSriXCtaCble>(entity =>
        {
            entity.ToView("vwcp_codigo_SRI_x_ctaCble");

            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
        });

        modelBuilder.Entity<VwcpComprobanteXRetencion>(entity =>
        {
            entity.ToView("vwcp_comprobante_x_retencion");

            entity.Property(e => e.CoRetencionManual).IsFixedLength();
            entity.Property(e => e.CoVaCoa).IsFixedLength();
            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
            entity.Property(e => e.ReEstado).IsFixedLength();
            entity.Property(e => e.ReTieneRfuente).IsFixedLength();
            entity.Property(e => e.ReTieneRtiva).IsFixedLength();
            entity.Property(e => e.ReTipoRet).IsFixedLength();
            entity.Property(e => e.RetEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpConciliacionCaja>(entity =>
        {
            entity.ToView("vwcp_Conciliacion_Caja");
        });

        modelBuilder.Entity<VwcpConciliacionCajaDet>(entity =>
        {
            entity.ToView("vwcp_Conciliacion_Caja_det");

            entity.Property(e => e.CaDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaFacturaVct).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdEstadoCierre).HasDefaultValueSql("''");
            entity.Property(e => e.IdOrdenGiroTipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpConciliacionCajaDetIngCaja>(entity =>
        {
            entity.ToView("vwcp_conciliacion_Caja_det_Ing_Caja");
        });

        modelBuilder.Entity<VwcpConciliacionCajaDetIngCajaTotalAplicado>(entity =>
        {
            entity.ToView("vwcp_conciliacion_Caja_det_Ing_Caja_total_aplicado");
        });

        modelBuilder.Entity<VwcpConciliacionCajaDetXValeCaja>(entity =>
        {
            entity.ToView("vwcp_conciliacion_Caja_det_x_ValeCaja");

            entity.Property(e => e.CmSigno).IsFixedLength();
            entity.Property(e => e.IdBeneficiario).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpConciliacionDetXCbtePago>(entity =>
        {
            entity.ToView("vwcp_conciliacion_det_x_cbte_pago");
        });

        modelBuilder.Entity<VwcpConciliacionIngBodegaXOrdenGiro>(entity =>
        {
            entity.ToView("vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro");

            entity.Property(e => e.NumFactura).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpConciliacionPoli>(entity =>
        {
            entity.ToView("vwcp_Conciliacion_Poli");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpConciliacionXCbteCble>(entity =>
        {
            entity.ToView("vwcp_conciliacion_x_cbte_cble");

            entity.Property(e => e.CbFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwcpConciliacionXOrdenPago>(entity =>
        {
            entity.ToView("vwcp_conciliacion_x_orden_pago");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpCpRetencionXEmpresa>(entity =>
        {
            entity.ToView("vwcp_cp_retencion_x_empresa");
        });

        modelBuilder.Entity<VwcpLiquidacionCompraSri>(entity =>
        {
            entity.ToView("vwcp_liquidacionCompra_sri");

            entity.Property(e => e.ContribuyenteEspecial).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcpNotaDebCre>(entity =>
        {
            entity.ToView("vwcp_nota_DebCre");

            entity.Property(e => e.CnVaCoa).IsFixedLength();
        });

        modelBuilder.Entity<VwcpNotaDebCreAts>(entity =>
        {
            entity.ToView("vwcp_nota_DebCre_ATS");

            entity.Property(e => e.CnVaCoa).IsFixedLength();
        });

        modelBuilder.Entity<VwcpNotaDebCreTotalSaldo>(entity =>
        {
            entity.ToView("vwcp_nota_DebCre_total_saldo");
        });

        modelBuilder.Entity<VwcpOrdenGiroConciliadoXFactura>(entity =>
        {
            entity.ToView("vwcp_Orden_Giro_Conciliado_x_Factura");

            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
            entity.Property(e => e.Serie).HasDefaultValueSql("''");
            entity.Property(e => e.Serie2).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenGiroConciliadoXIngBodXOc>(entity =>
        {
            entity.ToView("vwcp_Orden_Giro_Conciliado_x_Ing_Bod_x_OC");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenGiroCpNotaDebCreEstcue>(entity =>
        {
            entity.ToView("vwcp_orden_giro_cp_nota_DebCre_estcue");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwcpOrdenGiroNotaDebito>(entity =>
        {
            entity.ToView("vwcp_orden_giro_NotaDebito");

            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaFacturaVct).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenGiroPendienteConciliar>(entity =>
        {
            entity.ToView("vwcp_Orden_Giro_Pendiente_Conciliar");

            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
            entity.Property(e => e.Serie).HasDefaultValueSql("''");
            entity.Property(e => e.Serie2).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenGiroRetencionReport>(entity =>
        {
            entity.ToView("vwcp_OrdenGiroRetencionReport");

            entity.Property(e => e.NRetencionSri).HasDefaultValueSql("''");
            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
            entity.Property(e => e.ReEstado).IsFixedLength();
            entity.Property(e => e.ReTieneRfuente).IsFixedLength();
            entity.Property(e => e.ReTieneRtiva).IsFixedLength();
            entity.Property(e => e.ReTipoRet).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenGiroSinRetenciones>(entity =>
        {
            entity.ToView("vwcp_orden_giro_sin_retenciones");

            entity.Property(e => e.CoRetencionManual).IsFixedLength();
            entity.Property(e => e.CoVaCoa).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenGiroSri>(entity =>
        {
            entity.ToView("vwcp_orden_giro_SRI");

            entity.Property(e => e.CoVaCoa).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenGiroTotalPagodo>(entity =>
        {
            entity.ToView("vwcp_orden_giro_total_pagodo");
        });

        modelBuilder.Entity<VwcpOrdenGiroTotalSaldo>(entity =>
        {
            entity.ToView("vwcp_orden_giro_total_saldo");
        });

        modelBuilder.Entity<VwcpOrdenGiroXComOrdencompraLocalDetConsulta>(entity =>
        {
            entity.ToView("vwcp_orden_giro_x_com_ordencompra_local_det_consulta");

            entity.Property(e => e.DoCosteado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TieneMoviInven).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenGiroXPagar>(entity =>
        {
            entity.ToView("vwcp_orden_giro_x_pagar");

            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaFacturaVct).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaOg).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoSerie).HasDefaultValueSql("''");
            entity.Property(e => e.CodDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.CodTipoCbte)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.IdOrdenGiroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
            entity.Property(e => e.NomTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.TcTipoCbte)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenGiroXPagosSaldo>(entity =>
        {
            entity.ToView("vwcp_orden_giro_x_Pagos_saldo");

            entity.Property(e => e.CoRetencionManual).IsFixedLength();
            entity.Property(e => e.CoVaCoa).IsFixedLength();
            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenGiroXPagosSaldoSinIngresos>(entity =>
        {
            entity.ToView("vwcp_orden_giro_x_Pagos_saldo_SinIngresos");

            entity.Property(e => e.CoRetencionManual).IsFixedLength();
            entity.Property(e => e.CoVaCoa).IsFixedLength();
            entity.Property(e => e.ReEstaImpresa).IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenPago>(entity =>
        {
            entity.ToView("vwcp_orden_pago");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenPagoAnticipoSaldo>(entity =>
        {
            entity.ToView("vwcp_orden_pago_Anticipo_Saldo");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Referencia).HasDefaultValueSql("''");
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoCancelacionSaldos>(entity =>
        {
            entity.ToView("vwcp_orden_pago_cancelacion_Saldos");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenPagoCancelacionTotalPagadoXCbteble>(entity =>
        {
            entity.ToView("vwcp_orden_pago_cancelacion_Total_pagado_x_cbteble");
        });

        modelBuilder.Entity<VwcpOrdenPagoConCancelacion>(entity =>
        {
            entity.ToView("vwcp_orden_pago_con_cancelacion");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoConCancelacionLite>(entity =>
        {
            entity.ToView("vwcp_orden_pago_con_cancelacion_lite");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoConCancelacionPagadoConCbteBan>(entity =>
        {
            entity.ToView("vwcp_orden_pago_con_cancelacion_pagado_con_CbteBan");
        });

        modelBuilder.Entity<VwcpOrdenPagoConCancelacionPagadoConNcxp>(entity =>
        {
            entity.ToView("vwcp_orden_pago_con_cancelacion_pagado_con_ncxp");
        });

        modelBuilder.Entity<VwcpOrdenPagoConCancelacionParaConciliacion>(entity =>
        {
            entity.ToView("vwcp_orden_pago_con_cancelacion_para_conciliacion");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoConCancelacionXCbteBanDebi>(entity =>
        {
            entity.ToView("vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoConTransferencia>(entity =>
        {
            entity.ToView("vwcp_orden_pago_con_Transferencia");

            entity.Property(e => e.Estado).HasDefaultValueSql("''");
            entity.Property(e => e.FechaFaProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaOp).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.FechaVencFacProv).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoDet>(entity =>
        {
            entity.ToView("vwcp_orden_pago_det");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenPagoDetActiva>(entity =>
        {
            entity.ToView("vwcp_orden_pago_det_activa");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpOrdenPagoDetConCtaAcreedora>(entity =>
        {
            entity.ToView("vwcp_orden_pago_det_con_cta_acreedora");
        });

        modelBuilder.Entity<VwcpOrdenPagoParaAprobacion>(entity =>
        {
            entity.ToView("vwcp_orden_pago_para_aprobacion");

            entity.Property(e => e.CoFechaFactura).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CoFechaFacturaVct).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Descripcion).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.FechaPago).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.IdEstadoAprobacion).HasDefaultValueSql("''");
            entity.Property(e => e.IdFormaPago).HasDefaultValueSql("''");
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoTipoXEmpresa>(entity =>
        {
            entity.ToView("vwcp_orden_pago_tipo_x_empresa");

            entity.Property(e => e.Descripcion).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.GeneraDiario)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdTipoOp).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpOrdenPagoTotal>(entity =>
        {
            entity.ToView("vwcp_orden_pago_total");
        });

        modelBuilder.Entity<VwcpOrdenPagoTotalCancelacion>(entity =>
        {
            entity.ToView("vwcp_orden_pago_Total_cancelacion");
        });

        modelBuilder.Entity<VwcpOrdenPagoTotalPagado>(entity =>
        {
            entity.ToView("vwcp_orden_pago_Total_Pagado");
        });

        modelBuilder.Entity<VwcpOrdenPagoTotalPago>(entity =>
        {
            entity.ToView("vwcp_orden_pago_Total_Pago");
        });

        modelBuilder.Entity<VwcpProveedorCalificacion>(entity =>
        {
            entity.ToView("vwcp_proveedor_Calificacion");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcpProveedorRuc>(entity =>
        {
            entity.ToView("vwcp_ProveedorRuc");

            entity.Property(e => e.PrContribuyenteEspecial).IsFixedLength();
            entity.Property(e => e.PrContribuyenteExentoDeIva).IsFixedLength();
            entity.Property(e => e.PrGranContribuyente).IsFixedLength();
        });

        modelBuilder.Entity<VwcpProveedorVistaPrevia>(entity =>
        {
            entity.ToView("vwcp_proveedor_vista_previa");

            entity.Property(e => e.PrContribuyenteEspecial).IsFixedLength();
        });

        modelBuilder.Entity<VwcpRetencion>(entity =>
        {
            entity.ToView("vwcp_retencion");

            entity.Property(e => e.EstadoRt).IsFixedLength();
            entity.Property(e => e.ImpresaRt).IsFixedLength();
            entity.Property(e => e.ReTieneRfuente).IsFixedLength();
            entity.Property(e => e.ReTieneRtiva).IsFixedLength();
        });

        modelBuilder.Entity<VwcpRetencionSri>(entity =>
        {
            entity.ToView("vwcp_Retencion_sri");

            entity.Property(e => e.ContribuyenteEspecial).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcpRetencionValorTotalXCbteCxp>(entity =>
        {
            entity.ToView("vwcp_Retencion_valor_total_x_cbte_cxp");
        });

        modelBuilder.Entity<VwcpRetencionXRetFt>(entity =>
        {
            entity.ToView("vwcp_retencion_x_RET_FT");

            entity.Property(e => e.ReTipoRetRf).IsFixedLength();
        });

        modelBuilder.Entity<VwcpRetencionXRetIva>(entity =>
        {
            entity.ToView("vwcp_retencion_x_RET_IVA");

            entity.Property(e => e.ReTipoRetRiva).IsFixedLength();
        });

        modelBuilder.Entity<VwcpRetencionesXTipoImpresion>(entity =>
        {
            entity.ToView("vwcp_Retenciones_x_tipo_impresion");

            entity.Property(e => e.NumDocumento).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcpTipoImpresionCheq>(entity =>
        {
            entity.ToView("vwcp_Tipo_Impresion_Cheq");
        });

        modelBuilder.Entity<VwcpTipoServicioxProve>(entity =>
        {
            entity.ToView("vwcp_TipoServicioxProve");
        });

        modelBuilder.Entity<VwcpTotalCanceladoXCbteCxp>(entity =>
        {
            entity.ToView("vwcp_Total_cancelado_x_cbte_cxp");
        });

        modelBuilder.Entity<VwctAnioFiscalXCuentaUtilidad>(entity =>
        {
            entity.ToView("vwct_anio_fiscal_x_cuenta_utilidad");

            entity.Property(e => e.GcGrupoCble).IsFixedLength();
        });

        modelBuilder.Entity<VwctCbtecbleConCtacbleAcreedora>(entity =>
        {
            entity.ToView("vwct_cbtecble_con_ctacble_acreedora");
        });

        modelBuilder.Entity<VwctCbtecbleConSaldo>(entity =>
        {
            entity.ToView("vwct_cbtecble_Con_Saldo");

            entity.Property(e => e.CbFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Detalle).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwctCbtecbleConSaldoCxp>(entity =>
        {
            entity.ToView("vwct_cbtecble_con_saldo_cxp");

            entity.Property(e => e.CbFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwctCbtecbleConSaldoCxpAntiProvee>(entity =>
        {
            entity.ToView("vwct_cbtecble_con_saldo_cxp_ANTI_PROVEE");

            entity.Property(e => e.Referencia)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwctCbtecbleConSaldoCxpConsulta>(entity =>
        {
            entity.ToView("vwct_cbtecble_con_saldo_cxp_consulta");

            entity.Property(e => e.CbFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwctCbtecbleConSaldoCxpDiario>(entity =>
        {
            entity.ToView("vwct_cbtecble_con_saldo_cxp_DIARIO");

            entity.Property(e => e.IdCtaCble).IsFixedLength();
            entity.Property(e => e.IdCtaCbleAnticipo).IsFixedLength();
            entity.Property(e => e.IdEmpresaOp).IsFixedLength();
            entity.Property(e => e.IdOrdenPagoOp).IsFixedLength();
            entity.Property(e => e.SecuenciaOp).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwctCbtecbleConSaldoCxpNota>(entity =>
        {
            entity.ToView("vwct_cbtecble_con_saldo_cxp_NOTA");

            entity.Property(e => e.IdEmpresaOp).IsFixedLength();
            entity.Property(e => e.IdOrdenPagoOp).IsFixedLength();
            entity.Property(e => e.SecuenciaOp).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.Tipo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwctCbtecbleDet>(entity =>
        {
            entity.ToView("vwct_cbtecble_det");

            entity.Property(e => e.CbEstado).IsFixedLength();
            entity.Property(e => e.CbMayorizado).IsFixedLength();
        });

        modelBuilder.Entity<VwctCbtecbleDetTotalDiario>(entity =>
        {
            entity.ToView("vwct_cbtecble_det_TotalDiario");
        });

        modelBuilder.Entity<VwctCbtecbleXCpConciliacionCaja>(entity =>
        {
            entity.ToView("vwct_cbtecble_x_cp_Conciliacion_caja");

            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.NomCuenta).HasDefaultValueSql("''");
            entity.Property(e => e.TcTipoCbte)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwctCentroCosto>(entity =>
        {
            entity.ToView("vwct_centro_costo");

            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
            entity.Property(e => e.PcEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwctCentroCostoSubCentroCosto>(entity =>
        {
            entity.ToView("vwct_centro_costo_sub_centro_costo");

            entity.Property(e => e.PcEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwctCentroCostoXFaClienteObra>(entity =>
        {
            entity.ToView("vwct_centro_costo_x_fa_cliente_obra");

            entity.Property(e => e.IdEstadoObra).HasDefaultValueSql("''");
            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
            entity.Property(e => e.PcEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwctComprobanteContable>(entity =>
        {
            entity.ToView("vwct_ComprobanteContable");

            entity.Property(e => e.CbEstado).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwctGrupoXTipoGasto>(entity =>
        {
            entity.ToView("vwct_grupo_x_Tipo_Gasto");
        });

        modelBuilder.Entity<VwctPeriodo>(entity =>
        {
            entity.ToView("vwct_periodo");
        });

        modelBuilder.Entity<VwctPlancta>(entity =>
        {
            entity.ToView("vwct_plancta");

            entity.Property(e => e.CuentaPadre).HasDefaultValueSql("''");
            entity.Property(e => e.PcEsFlujoEfectivo).IsFixedLength();
            entity.Property(e => e.PcEsMovimiento).IsFixedLength();
            entity.Property(e => e.PcEstado).IsFixedLength();
            entity.Property(e => e.PcNaturaleza).IsFixedLength();
        });

        modelBuilder.Entity<VwctPlanctaNivel>(entity =>
        {
            entity.ToView("vwct_plancta_nivel");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwctSaldosxCuentas>(entity =>
        {
            entity.ToView("vwct_SaldosxCuentas");

            entity.Property(e => e.GcEstadoFinanciero).HasDefaultValueSql("''");
            entity.Property(e => e.GcGrupoCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdCtaCble).HasDefaultValueSql("''");
            entity.Property(e => e.IdGrupoCble).HasDefaultValueSql("''");
            entity.Property(e => e.PcCuenta).HasDefaultValueSql("''");
            entity.Property(e => e.PcNaturaleza).IsFixedLength();
            entity.Property(e => e.SidPeriodo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwctUtilidadxPeriodo>(entity =>
        {
            entity.ToView("vwct_UtilidadxPeriodo");
        });

        modelBuilder.Entity<VwctUtilidadxPeriodoSaldoAcumulado>(entity =>
        {
            entity.ToView("vwct_UtilidadxPeriodo_Saldo_Acumulado");
        });

        modelBuilder.Entity<VwctUtilidadxPeriodoSaldoAnterior>(entity =>
        {
            entity.ToView("vwct_UtilidadxPeriodo_Saldo_Anterior");
        });

        modelBuilder.Entity<VwctUtilidadxPeriodoSaldoPeriodoActual>(entity =>
        {
            entity.ToView("vwct_UtilidadxPeriodo_Saldo_PeriodoActual");
        });

        modelBuilder.Entity<VwcxcAnticipoFacturado>(entity =>
        {
            entity.ToView("vwcxc_anticipo_facturado");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcAnticiposXCruzar>(entity =>
        {
            entity.ToView("vwcxc_anticipos_x_cruzar");
        });

        modelBuilder.Entity<VwcxcAnticiposXCruzarEdehsa>(entity =>
        {
            entity.ToView("vwcxc_anticipos_x_cruzar_Edehsa");
        });

        modelBuilder.Entity<VwcxcCancelacionIntercompany>(entity =>
        {
            entity.ToView("vwcxc_cancelacion_Intercompany");

            entity.Property(e => e.CrEstado).IsFixedLength();
            entity.Property(e => e.GeneraDeps).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCancelacionIntercompanyXCxcCobroDet>(entity =>
        {
            entity.ToView("vwcxc_cancelacion_Intercompany_x_cxc_cobro_det");
        });

        modelBuilder.Entity<VwcxcCarteraXCobrar>(entity =>
        {
            entity.ToView("vwcxc_cartera_x_cobrar");

            entity.Property(e => e.Bodega)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CodComprobante).HasDefaultValueSql("''");
            entity.Property(e => e.EmNombre).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcxcCarteraXCobrarEdehsa>(entity =>
        {
            entity.ToView("vwcxc_cartera_x_cobrar_Edehsa");

            entity.Property(e => e.Bodega)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CodComprobante).HasDefaultValueSql("''");
            entity.Property(e => e.EmNombre).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcxcCobro>(entity =>
        {
            entity.ToView("vwcxc_cobro");

            entity.Property(e => e.CrEsAnticipo).IsFixedLength();
            entity.Property(e => e.CrNumCheque)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroDet>(entity =>
        {
            entity.ToView("vwcxc_cobro_det");

            entity.Property(e => e.CrFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CrFechaCobro).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CrFechaDocu).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.CrNumCheque)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdCobroTipo).HasDefaultValueSql("''");
            entity.Property(e => e.NCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroTipoParamContaXSucursal>(entity =>
        {
            entity.ToView("vwcxc_cobro_tipo_Param_conta_x_sucursal");

            entity.Property(e => e.Sucursal).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcxcCobroXAnticipoPendientesDeDiario>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_anticipo_pendientes_de_diario");

            entity.Property(e => e.CbEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroXAnticipoTotalRespaldado>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_anticipo_total_respaldado");
        });

        modelBuilder.Entity<VwcxcCobroXAnticipoXCobros>(entity =>
        {
            entity.ToView("vwcxc_Cobro_x_anticipo_x_cobros");
        });

        modelBuilder.Entity<VwcxcCobroXAnticipoXPersona>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_Anticipo_x_Persona");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroXCajCajaMovimiento>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_caj_Caja_Movimiento");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroXCobroDet>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_cobro_det");

            entity.Property(e => e.CrNumCheque)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdEstadoCobro).HasDefaultValueSql("''");
            entity.Property(e => e.NSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroXDocumentosXCobrar>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_documentos_x_cobrar");

            entity.Property(e => e.Bodega).IsFixedLength();
            entity.Property(e => e.FechaVta).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroXEstadoCobro>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_EstadoCobro");

            entity.Property(e => e.CrNumCheque)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.IdEstadoCobro).HasDefaultValueSql("''");
            entity.Property(e => e.NSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobroXMoviCajaXCbtecble>(entity =>
        {
            entity.ToView("vwcxc_cobro_x_movi_caja_x_cbtecble");

            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosConciliados>(entity =>
        {
            entity.ToView("vwcxc_cobros_conciliados");

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.IdTipoConciliacion).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosPendientesDeDeposito>(entity =>
        {
            entity.ToView("vwcxc_cobros_Pendientes_de_deposito");
        });

        modelBuilder.Entity<VwcxcCobrosPendientesXConciliar>(entity =>
        {
            entity.ToView("vwcxc_cobros_Pendientes_x_conciliar");

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.IdTipoConciliacion).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosPendientesXConciliarEdehsa>(entity =>
        {
            entity.ToView("vwcxc_cobros_Pendientes_x_conciliar_Edehsa");

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.IdTipoConciliacion).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomSucursal)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosXChequeDeposito>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_cheque_deposito");

            entity.Property(e => e.Referencia)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Sucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosXNdXRetFteXClienteXAnioMes>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_ND_x_RetFte_x_Cliente_x_AnioMes");
        });

        modelBuilder.Entity<VwcxcCobrosXNdXRetIvaXClienteXAnioMes>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_ND_x_RetIva_x_Cliente_x_AnioMes");
        });

        modelBuilder.Entity<VwcxcCobrosXVtaNotaXRetFuente>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_nota_x_RetFuente");

            entity.Property(e => e.EsretenFte).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosXVtaNotaXRetFuenteEdehsa>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_nota_x_RetFuente_Edehsa");

            entity.Property(e => e.EsretenFte).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosXVtaNotaXRetFuenteSumatoria>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_nota_x_RetFuente_Sumatoria");
        });

        modelBuilder.Entity<VwcxcCobrosXVtaNotaXRetIva>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_nota_x_RetIVA");

            entity.Property(e => e.EsretenIva).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosXVtaNotaXRetIvaEdehsa>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_nota_x_RetIVA_Edehsa");

            entity.Property(e => e.EsretenIva).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcCobrosXVtaNotaXRetIvaSumatoria>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_nota_x_RetIVA_Sumatoria");
        });

        modelBuilder.Entity<VwcxcCobrosXVtaXRetFteXClienteXAnioMes>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_x_RetFte_x_Cliente_x_AnioMes");

            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcxcCobrosXVtaXRetIvaXClienteXAnioMes>(entity =>
        {
            entity.ToView("vwcxc_cobros_x_vta_x_RetIva_x_Cliente_x_AnioMes");

            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcxcConciliacion>(entity =>
        {
            entity.ToView("vwcxc_conciliacion");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcConciliacionDetAnticipo>(entity =>
        {
            entity.ToView("vwcxc_conciliacion_Det_Anticipo");
        });

        modelBuilder.Entity<VwcxcConciliacionDetCobro>(entity =>
        {
            entity.ToView("vwcxc_conciliacion_Det_Cobro");

            entity.Property(e => e.Bodega)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.CodComprobante).HasDefaultValueSql("''");
            entity.Property(e => e.EmNombre).HasDefaultValueSql("''");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwcxcConciliacionDetCreDeb>(entity =>
        {
            entity.ToView("vwcxc_conciliacion_Det_CreDeb");

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcConciliacionEdehsa>(entity =>
        {
            entity.ToView("vwcxc_conciliacion_Edehsa");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcDetalleDeposito>(entity =>
        {
            entity.ToView("vwcxc_Detalle_Deposito");

            entity.Property(e => e.CrNumCheque)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcEstadoCobroActual>(entity =>
        {
            entity.ToView("vwcxc_EstadoCobro_Actual");
        });

        modelBuilder.Entity<VwcxcParametrosXCheqProtesto>(entity =>
        {
            entity.ToView("vwcxc_Parametros_x_cheqProtesto");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcRetencionMultiple>(entity =>
        {
            entity.ToView("vwcxc_retencion_Multiple");

            entity.Property(e => e.CrEsAnticipo).IsFixedLength();
            entity.Property(e => e.CrNumCheque)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.NSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwcxcTotalCobrosXDocu>(entity =>
        {
            entity.ToView("vwcxc_total_cobros_x_Docu");
        });

        modelBuilder.Entity<VwfaCatalogoIdAutoNumeric>(entity =>
        {
            entity.ToView("vwfa_Catalogo_IdAuto_numeric");

            entity.Property(e => e.IdCatalogo).HasDefaultValueSql("''");
            entity.Property(e => e.Observacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwfaCliente>(entity =>
        {
            entity.ToView("vwfa_cliente");

            entity.Property(e => e.ClCatCrediticia).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwfaClienteVistaPrevia>(entity =>
        {
            entity.ToView("vwfa_cliente_vista_previa");

            entity.Property(e => e.ClCatCrediticia).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwfaClientesContactos>(entity =>
        {
            entity.ToView("vwfa_clientes_contactos");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwfaContabilizacionFactura>(entity =>
        {
            entity.ToView("vwfa_ContabilizacionFactura");
        });

        modelBuilder.Entity<VwfaContabilizacionFacturaXCosto>(entity =>
        {
            entity.ToView("vwfa_ContabilizacionFactura_x_Costo");
        });

        modelBuilder.Entity<VwfaContabilizacionFacturaXDescuentoXItem>(entity =>
        {
            entity.ToView("vwfa_ContabilizacionFactura_x_descuento_x_item");
        });

        modelBuilder.Entity<VwfaContabilizacionFacturaXItem>(entity =>
        {
            entity.ToView("vwfa_ContabilizacionFactura_x_Item");
        });

        modelBuilder.Entity<VwfaContabilizacionFacturaXSucursal>(entity =>
        {
            entity.ToView("vwfa_ContabilizacionFactura_x_Sucursal");
        });

        modelBuilder.Entity<VwfaContabilizacionNotaCreditoXDescuentoXItem>(entity =>
        {
            entity.ToView("vwfa_ContabilizacionNotaCredito_x_descuento_x_item");
        });

        modelBuilder.Entity<VwfaContabilizarNotaCredDeb>(entity =>
        {
            entity.ToView("vwfa_ContabilizarNotaCredDeb");
        });

        modelBuilder.Entity<VwfaContabilizarNotaCredDebXItem>(entity =>
        {
            entity.ToView("vwfa_ContabilizarNotaCredDeb_x_Item");
        });

        modelBuilder.Entity<VwfaContabilizarNotaCredDebXSucursal>(entity =>
        {
            entity.ToView("vwfa_ContabilizarNotaCredDeb_x_sucursal");
        });

        modelBuilder.Entity<VwfaCostoProductoVendido>(entity =>
        {
            entity.ToView("vwfa_costo_producto_vendido");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomGrupo).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwfaCostoProductoVendidoDetalle>(entity =>
        {
            entity.ToView("vwfa_costo_producto_vendido_detalle");

            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.NomGrupo).HasDefaultValueSql("''");
            entity.Property(e => e.PrDescripcion).HasDefaultValueSql("''");
            entity.Property(e => e.TipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwfaCotizacionDetalle>(entity =>
        {
            entity.ToView("vwfa_cotizacion_detalle");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.CcEstado).IsFixedLength();
            entity.Property(e => e.CcTipopago).IsFixedLength();
            entity.Property(e => e.DcPagaIva).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaCreditosDebitosConSaldo>(entity =>
        {
            entity.ToView("vwfa_creditos_debitos_con_saldo");

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.IdTipoConciliacion).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwfaCreditosDebitosConSaldoEdehsa>(entity =>
        {
            entity.ToView("vwfa_creditos_debitos_con_saldo_Edehsa");

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.IdTipoConciliacion).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwfaDevolucion>(entity =>
        {
            entity.ToView("vwfa_devolucion");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdUsuario).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaDocumentoTipoXSecuenciaTalonario>(entity =>
        {
            entity.ToView("vwfa_Documento_Tipo_x_Secuencia_Talonario");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwfaFaGuiaRemisionXEmpresa>(entity =>
        {
            entity.ToView("vwfa_fa_guia_remision_x_empresa");
        });

        modelBuilder.Entity<VwfaFaNotaCreDebXEmpresa>(entity =>
        {
            entity.ToView("vwfa_fa_notaCreDeb_x_empresa");
        });

        modelBuilder.Entity<VwfaFactura>(entity =>
        {
            entity.ToView("vwfa_factura");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaFacturaDet>(entity =>
        {
            entity.ToView("vwfa_factura_det");

            entity.Property(e => e.VtEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwfaFacturaDev>(entity =>
        {
            entity.ToView("vwfa_Factura_Dev");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
            entity.Property(e => e.VtDetallexItems)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwfaFacturaEdehsa>(entity =>
        {
            entity.ToView("vwfa_factura_Edehsa");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaFacturaSri>(entity =>
        {
            entity.ToView("vwfa_factura_sri");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwfaFacturaSubTotalIvaTotal>(entity =>
        {
            entity.ToView("vwfa_factura_SubTotal_Iva_total");
        });

        modelBuilder.Entity<VwfaFacturaSubtotalIva>(entity =>
        {
            entity.ToView("vwfa_factura_Subtotal_Iva");
        });

        modelBuilder.Entity<VwfaFacturaSubtotalIva0Totales>(entity =>
        {
            entity.ToView("vwfa_factura_subtotal_iva_0_totales");
        });

        modelBuilder.Entity<VwfaFacturaTotalCobrado>(entity =>
        {
            entity.ToView("vwfa_factura_total_cobrado");
        });

        modelBuilder.Entity<VwfaFacturaXInMoviInve>(entity =>
        {
            entity.ToView("vwfa_factura_x_in_movi_inve");
        });

        modelBuilder.Entity<VwfaGuiaRemision>(entity =>
        {
            entity.ToView("vwfa_Guia_Remision");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.GiDetallexItems).IsFixedLength();
            entity.Property(e => e.GiTieneIva).IsFixedLength();
            entity.Property(e => e.Impreso).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaGuiaRemisionDet>(entity =>
        {
            entity.ToView("vwfa_guia_remision_det");

            entity.Property(e => e.GiDetallexItems).IsFixedLength();
            entity.Property(e => e.GiTieneIva).IsFixedLength();
        });

        modelBuilder.Entity<VwfaGuiaRemisionSinFactura>(entity =>
        {
            entity.ToView("vwfa_guia_remision_sin_factura");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Impreso).IsFixedLength();
        });

        modelBuilder.Entity<VwfaMotivoAprobacionPedidoVenta>(entity =>
        {
            entity.ToView("vwfa_motivo_aprobacion_Pedido_Venta");
        });

        modelBuilder.Entity<VwfaMovimientosXBodegaXCat>(entity =>
        {
            entity.ToView("vwfa_movimientos_x_bodega_x_cat");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwfaNotaCreDeb>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb");

            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NoDevVenta).IsFixedLength();
        });

        modelBuilder.Entity<VwfaNotaCreDebDetSri>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_det_sri");

            entity.Property(e => e.ScEstado).IsFixedLength();
        });

        modelBuilder.Entity<VwfaNotaCreDebDetSubtotalIva0Totales>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_det_subtotal_iva_0_totales");
        });

        modelBuilder.Entity<VwfaNotaCreDebDetSubtotalIvaTotal>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_det_Subtotal_Iva_total");
        });

        modelBuilder.Entity<VwfaNotaCreDebSri>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_sri");

            entity.Property(e => e.CodNota).HasDefaultValueSql("''");
            entity.Property(e => e.CreDeb)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.EmDireccion).HasDefaultValueSql("''");
            entity.Property(e => e.EmRuc).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.FechaFact).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.NaturalezaNota).IsFixedLength();
            entity.Property(e => e.NoFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.NombreComercial).HasDefaultValueSql("''");
            entity.Property(e => e.ObligadoAllevarConta).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.RazonSocial).HasDefaultValueSql("''");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TipoDocAplicado).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwfaNotaCreDebXCxcCobro>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_x_cxc_cobro");
        });

        modelBuilder.Entity<VwfaNotaCreDebXFaFacturaNotaDeb>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_x_fa_factura_NotaDeb");

            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwfaNotaCreDebXFaFacturaNotaDebSinCobros>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_x_fa_factura_NotaDeb_sin_cobros");
        });

        modelBuilder.Entity<VwfaNotaCreDebXFaFacturaNotaDebXCxcCobro>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_cxc_cobro");
        });

        modelBuilder.Entity<VwfaNotaCreDebXFaFacturaNotaDebXNc>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_x_fa_factura_NotaDeb_x_NC");

            entity.Property(e => e.FechaCruce).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.NomCliente).HasDefaultValueSql("''");
            entity.Property(e => e.VtFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.VtTipoDoc).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwfaNotaCreDebXValoresAplicados>(entity =>
        {
            entity.ToView("vwfa_notaCreDeb_x_Valores_Aplicados");
        });

        modelBuilder.Entity<VwfaNotaCredito>(entity =>
        {
            entity.ToView("vwfa_Nota_Credito");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NaturalezaNota).IsFixedLength();
            entity.Property(e => e.NoDevVenta).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaNotaCreditoEdehsa>(entity =>
        {
            entity.ToView("vwfa_Nota_Credito_Edehsa");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.CreDeb).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NaturalezaNota).IsFixedLength();
            entity.Property(e => e.NoDevVenta).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaNotaCreditoXDevolver>(entity =>
        {
            entity.ToView("vwfa_Nota_Credito_x_Devolver");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.CreDeb).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwfaOrdenDespDetXFaPedidoDetXPedido>(entity =>
        {
            entity.ToView("vwfa_orden_Desp_det_x_fa_pedido_det_x_pedido");
        });

        modelBuilder.Entity<VwfaOrdenDespDetXPedidoDet>(entity =>
        {
            entity.ToView("vwfa_orden_Desp_det_x_Pedido_det");

            entity.Property(e => e.OdDetallexItems).IsFixedLength();
            entity.Property(e => e.OdTieneIva).IsFixedLength();
            entity.Property(e => e.TieneGuia).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwfaOrdenDespSinGuiaRemi>(entity =>
        {
            entity.ToView("vwfa_orden_Desp_sin_guiaRemi");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.OdDespAbierto).IsFixedLength();
        });

        modelBuilder.Entity<VwfaOrdenDespachoDetalle>(entity =>
        {
            entity.ToView("vwfa_orden_despacho_detalle");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.OdDespAbierto).IsFixedLength();
            entity.Property(e => e.OdDetallexItems).IsFixedLength();
            entity.Property(e => e.OdTieneIva).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaPedidoDetalle>(entity =>
        {
            entity.ToView("vwfa_pedido_detalle");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.BoEsBodega).IsFixedLength();
            entity.Property(e => e.BoManejaFacturacion).IsFixedLength();
            entity.Property(e => e.CodPuntoEmision).IsFixedLength();
            entity.Property(e => e.CpTipopago).IsFixedLength();
            entity.Property(e => e.DpEstado).IsFixedLength();
            entity.Property(e => e.DpPagaIva).IsFixedLength();
            entity.Property(e => e.Entregado).IsFixedLength();
            entity.Property(e => e.EstaEnBase).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TieneDespacho).HasDefaultValueSql("''");
            entity.Property(e => e.VeVendedor).IsFixedLength();
        });

        modelBuilder.Entity<VwfaPedidoXFaOrdenDespDetXFaGuiaRemisionDet>(entity =>
        {
            entity.ToView("vwfa_pedido_x_fa_orden_Desp_det_x_fa_guia_remision_det");
        });

        modelBuilder.Entity<VwfaPuntoVta>(entity =>
        {
            entity.ToView("vwfa_PuntoVta");

            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwfaVentaTelefonicaDet>(entity =>
        {
            entity.ToView("vwfa_venta_telefonica_det");

            entity.Property(e => e.VieneBase).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwinAjusteFisico>(entity =>
        {
            entity.ToView("vwin_ajusteFisico");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinAjusteFisicoXRelacionInvenXCbteCble>(entity =>
        {
            entity.ToView("vwin_Ajuste_fisico_x_relacion_inven_x_cbteCble");

            entity.Property(e => e.CmFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.SuDescripcion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.TmDescripcion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwinCateLinGrupSubGrup>(entity =>
        {
            entity.ToView("vwin_Cate_Lin_Grup_SubGrup");
        });

        modelBuilder.Entity<VwinCategoriaLinGrSubgr>(entity =>
        {
            entity.ToView("vwin_categoria_lin_gr_subgr");

            entity.Property(e => e.Descripcion).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Id).HasDefaultValueSql("''");
            entity.Property(e => e.IdCategoria).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwinDevolucionInven>(entity =>
        {
            entity.ToView("vwin_devolucion_inven");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinDevolucionInvenDet>(entity =>
        {
            entity.ToView("vwin_devolucion_inven_det");
        });

        modelBuilder.Entity<VwinDevolucionInvenDetCantidadDevuelta>(entity =>
        {
            entity.ToView("vwin_devolucion_inven_det_cantidad_devuelta");
        });

        modelBuilder.Entity<VwinGeneracionCompraCidersus>(entity =>
        {
            entity.ToView("vwin_GeneracionCompraCidersus");

            entity.Property(e => e.AfectaCosto).IsFixedLength();
            entity.Property(e => e.DoCosteado).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBase0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBaseIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDes0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDesIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDev0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDevIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVen0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVenIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVta).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltAnu).IsFixedLength();
            entity.Property(e => e.IdUsuarioUltMod).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
        });

        modelBuilder.Entity<VwinGuiaRemision>(entity =>
        {
            entity.ToView("vwin_GuiaRemision");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NumDocumento).IsFixedLength();
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.Serie1).IsFixedLength();
            entity.Property(e => e.Serie2).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinGuiaRemisionDetConSaldoXIngAInven>(entity =>
        {
            entity.ToView("vwin_GuiaRemision_det_con_saldo_x_ing_a_inven");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.IdEstadoCierre).HasDefaultValueSql("''");
            entity.Property(e => e.IdEstadoRecepcion).HasDefaultValueSql("''");
            entity.Property(e => e.NumDocumento).IsFixedLength();
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.Serie1).IsFixedLength();
            entity.Property(e => e.Serie2).IsFixedLength();
        });

        modelBuilder.Entity<VwinGuiaRemisionDetConSaldoXIngAInvenConSaldo>(entity =>
        {
            entity.ToView("vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NumDocumento).IsFixedLength();
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
            entity.Property(e => e.Serie1).IsFixedLength();
            entity.Property(e => e.Serie2).IsFixedLength();
        });

        modelBuilder.Entity<VwinGuiaXTraspasoBodega>(entity =>
        {
            entity.ToView("vwin_guia_x_traspaso_bodega");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcionLlegada).IsFixedLength();
        });

        modelBuilder.Entity<VwinGuiaXTraspasoBodegaDetSinTransferencia>(entity =>
        {
            entity.ToView("vwin_Guia_x_traspaso_bodega_det_sin_Transferencia");
        });

        modelBuilder.Entity<VwinGuiaXTraspasoBodegaXOrdencompraLocalDet>(entity =>
        {
            entity.ToView("vwin_Guia_x_traspaso_bodega_x_ordencompra_local_det");
        });

        modelBuilder.Entity<VwinInGuiaXTraspasoBodegaXInTransferenciaDet>(entity =>
        {
            entity.ToView("vwin_in_Guia_x_traspaso_bodega_x_in_transferencia_det");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinInProductoXTbBodegaXUnidadMedida>(entity =>
        {
            entity.ToView("vwin_in_Producto_x_tb_bodega_x_UnidadMedida");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinIngEgrInven>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
            entity.Property(e => e.SignoTipoInv).IsFixedLength();
        });

        modelBuilder.Entity<VwinIngEgrInvenDet>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_det");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<VwinIngEgrInvenDetXComOrdencompraLocalDet>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<VwinIngEgrInvenDetXComOrdencompraLocalDet2>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_2");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinIngEgrInvenDetXComOrdencompraLocalDetXCpAprob>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_x_cp_Aprob");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
        });

        modelBuilder.Entity<VwinIngEgrInvenDetXEstadoAprob>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_det_x_estado_aprob");
        });

        modelBuilder.Entity<VwinIngEgrInvenDetXProducto>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_det_x_Producto");
        });

        modelBuilder.Entity<VwinIngEgrInvenParaDevolucion>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_para_devolucion");

            entity.Property(e => e.Signo).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinIngEgrInvenXInMoviInve>(entity =>
        {
            entity.ToView("vwin_Ing_Egr_Inven_x_in_movi_inve");

            entity.Property(e => e.CmDescripcionCorta).HasDefaultValueSql("''");
            entity.Property(e => e.CmFecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
            entity.Property(e => e.DescMovInv).HasDefaultValueSql("''");
            entity.Property(e => e.GeneraMoviInven)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Signo)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.TmDescripcion).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwinMotivoTrasladoBodega>(entity =>
        {
            entity.ToView("vwin_Motivo_traslado_bodega");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwinMoviInve>(entity =>
        {
            entity.ToView("vwin_movi_inve");

            entity.Property(e => e.CmTipo).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinMoviInveDetalle>(entity =>
        {
            entity.ToView("vwin_movi_inve_detalle");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinMoviInveDetalleParaStockALaFecha>(entity =>
        {
            entity.ToView("vwin_movi_inve_detalle_para_stock_a_la_fecha");
        });

        modelBuilder.Entity<VwinMoviInveDetalleXComOrdencompraLocalDetTotalCant>(entity =>
        {
            entity.ToView("vwin_movi_inve_detalle_x_com_ordencompra_local_det_TotalCant");
        });

        modelBuilder.Entity<VwinMoviInveDetalleXContabilizarXCtacbles>(entity =>
        {
            entity.ToView("vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
            entity.Property(e => e.NomTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwinMoviInveDetalleXItemDisponibles>(entity =>
        {
            entity.ToView("vwin_movi_inve_detalle_x_item_disponibles");
        });

        modelBuilder.Entity<VwinMoviInveDetalleXItemIngresos>(entity =>
        {
            entity.ToView("vwin_movi_inve_detalle_x_item_ingresos");
        });

        modelBuilder.Entity<VwinMoviInveFechaCosteoRecomendadaXSucursal>(entity =>
        {
            entity.ToView("vwin_movi_inve_fecha_costeo_recomendada_x_sucursal");
        });

        modelBuilder.Entity<VwinMoviInveXCbteCbleDatos>(entity =>
        {
            entity.ToView("vwin_movi_inve_x_cbteCble_Datos");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.CmTipoMovi).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
            entity.Property(e => e.TipoContabilizado).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwinMoviInveXComOrdencompraLocal>(entity =>
        {
            entity.ToView("vwin_movi_inve_x_com_ordencompra_local");
        });

        modelBuilder.Entity<VwinMoviInveXDespachar>(entity =>
        {
            entity.ToView("vwin_movi_inve_x_despachar");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Signo).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinMoviInveXEstadoContabilizacion>(entity =>
        {
            entity.ToView("vwin_movi_inve_x_estado_contabilizacion");

            entity.Property(e => e.CmTipo).IsFixedLength();
            entity.Property(e => e.EstadoContabilizacion).HasDefaultValueSql("''");
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinMoviInveXIngOrdencompraLocal>(entity =>
        {
            entity.ToView("vwin_movi_inve_x_Ing_Ordencompra_local");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinMoviInvenXIngXOc>(entity =>
        {
            entity.ToView("vwin_Movi_Inven_x_Ing_x_OC");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.SucursalOc).IsFixedLength();
        });

        modelBuilder.Entity<VwinPresentacion>(entity =>
        {
            entity.ToView("vwin_Presentacion");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwinProducto>(entity =>
        {
            entity.ToView("vwin_producto");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.ManejaLote).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.TpManejaInven).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoDespachado>(entity =>
        {
            entity.ToView("vwin_producto_despachado");
        });

        modelBuilder.Entity<VwinProductoDespachadoXGuiaRemision>(entity =>
        {
            entity.ToView("vwin_producto_despachado_x_guiaRemision");

            entity.Property(e => e.NumDocumento).IsFixedLength();
            entity.Property(e => e.Serie1).IsFixedLength();
            entity.Property(e => e.Serie2).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoDespachadoXGuiaRemisionAcumulada>(entity =>
        {
            entity.ToView("vwin_producto_despachado_x_guiaRemision_Acumulada");
        });

        modelBuilder.Entity<VwinProductoMarcaTipoCategoria>(entity =>
        {
            entity.ToView("vwin_Producto_Marca_Tipo_Categoria");

            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoPedidosEgresosXBodega>(entity =>
        {
            entity.ToView("vwin_Producto_Pedidos_Egresos_x_Bodega");
        });

        modelBuilder.Entity<VwinProductoPrecioHistorico>(entity =>
        {
            entity.ToView("vwin_producto_precio_historico");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoStock>(entity =>
        {
            entity.ToView("vwin_Producto_Stock");
        });

        modelBuilder.Entity<VwinProductoStockLote>(entity =>
        {
            entity.ToView("vwin_Producto_Stock_Lote");
        });

        modelBuilder.Entity<VwinProductoStockXBodega>(entity =>
        {
            entity.ToView("vwin_Producto_Stock_x_Bodega");
        });

        modelBuilder.Entity<VwinProductoStockXProducto>(entity =>
        {
            entity.ToView("vwin_Producto_Stock_x_producto");
        });

        modelBuilder.Entity<VwinProductoStockXSucursal>(entity =>
        {
            entity.ToView("vwin_Producto_Stock_x_Sucursal");
        });

        modelBuilder.Entity<VwinProductoUltCostoHistXBod>(entity =>
        {
            entity.ToView("vwin_producto_Ult_Costo_Hist_x_Bod");
        });

        modelBuilder.Entity<VwinProductoUltCostoHistXSucu>(entity =>
        {
            entity.ToView("vwin_producto_Ult_Costo_Hist_x_Sucu");
        });

        modelBuilder.Entity<VwinProductoXModulo>(entity =>
        {
            entity.ToView("vwin_producto_x_modulo");

            entity.Property(e => e.IdCentroCostoCosto).IsFixedLength();
            entity.Property(e => e.IdCentroCostoInventario).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCost).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCxp).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoInv).IsFixedLength();
            entity.Property(e => e.IdCentroCostoXGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBase0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBaseIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosto).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDes0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDesIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDev0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDevIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleInventario).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVen0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVenIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVta).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXModuloLite>(entity =>
        {
            entity.ToView("vwin_producto_x_modulo_lite");

            entity.Property(e => e.IdCentroCostoCosto).IsFixedLength();
            entity.Property(e => e.IdCentroCostoInventario).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCost).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCxp).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoInv).IsFixedLength();
            entity.Property(e => e.IdCentroCostoXGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBase0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBaseIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosto).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDes0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDesIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDev0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDevIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleInventario).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVen0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVenIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVta).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXModuloSinStock>(entity =>
        {
            entity.ToView("vwin_producto_x_modulo_sin_Stock");

            entity.Property(e => e.IdCentroCostoCosto).IsFixedLength();
            entity.Property(e => e.IdCentroCostoInventario).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCost).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCxp).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoInv).IsFixedLength();
            entity.Property(e => e.IdCentroCostoXGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBase0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBaseIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosto).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDes0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDesIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDev0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDevIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleInventario).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVen0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVenIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVta).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXProveedor>(entity =>
        {
            entity.ToView("vwin_Producto_x_Proveedor");
        });

        modelBuilder.Entity<VwinProductoXSucursal>(entity =>
        {
            entity.ToView("vwin_producto_x_sucursal");

            entity.Property(e => e.IdCentroCostoCosto).IsFixedLength();
            entity.Property(e => e.IdCentroCostoInventario).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCost).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoCxp).IsFixedLength();
            entity.Property(e => e.IdCentroCostoSubCentroCostoInv).IsFixedLength();
            entity.Property(e => e.IdCentroCostoXGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBase0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosBaseIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleCosto).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDes0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDesIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDev0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleDevIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleGastoXCxp).IsFixedLength();
            entity.Property(e => e.IdCtaCbleInventario).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVen0).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVenIva).IsFixedLength();
            entity.Property(e => e.IdCtaCbleVta).IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXTbBodega>(entity =>
        {
            entity.ToView("vwin_producto_x_tb_bodega");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXTbBodegaCostoHistorico>(entity =>
        {
            entity.ToView("vwin_producto_x_tb_bodega_Costo_Historico");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXTbBodegaLite>(entity =>
        {
            entity.ToView("vwin_producto_x_tb_bodega_lite");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXTbBodegaLote>(entity =>
        {
            entity.ToView("vwin_producto_x_tb_bodega_Lote");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXTbBodegaPrecios>(entity =>
        {
            entity.ToView("vwin_producto_x_tb_bodega_Precios");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXTbBodegaSinStock>(entity =>
        {
            entity.ToView("vwin_producto_x_tb_bodega_sin_Stock");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.IdEstadoAprobacion)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.ManejaKardex).IsFixedLength();
            entity.Property(e => e.PrManejaIva).IsFixedLength();
            entity.Property(e => e.PrManejaSeries).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinProductoXTbBodegaXCtasCbles>(entity =>
        {
            entity.ToView("vwin_producto_x_tb_bodega_x_Ctas_cbles");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinPrtTransferencia>(entity =>
        {
            entity.ToView("vwin_prt_transferencia");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.BodegaDestinno).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.SucursalDestino).IsFixedLength();
        });

        modelBuilder.Entity<VwinSubgrupoXCentroCostoXSubCentroCostoSinCtaCble>(entity =>
        {
            entity.ToView("vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_sin_CtaCble");
        });

        modelBuilder.Entity<VwinSubgrupoXCentroCostoXSubCentroCostoXCtaCble>(entity =>
        {
            entity.ToView("vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble");
        });

        modelBuilder.Entity<VwinSubgrupoXCentroCostoXSubCentroCostoXCtaCbleNoParam>(entity =>
        {
            entity.ToView("vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_no_param");
        });

        modelBuilder.Entity<VwinTransferenciaDetXInGuiaXTraspasoBodegaDet>(entity =>
        {
            entity.ToView("vwin_transferencia_det_x_in_Guia_x_traspaso_bodega_det");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwinTransferenciaDetalle>(entity =>
        {
            entity.ToView("vwin_Transferencia_Detalle");
        });

        modelBuilder.Entity<VwinTransferenciaSinGuia>(entity =>
        {
            entity.ToView("vwin_Transferencia_sin_guia");
        });

        modelBuilder.Entity<VwinTransferenciaXInMoviInveAgrupadaParaRecosteo>(entity =>
        {
            entity.ToView("vwin_transferencia_x_in_movi_inve_agrupada_para_recosteo");

            entity.Property(e => e.NomBodega).IsFixedLength();
            entity.Property(e => e.NomSucursal).IsFixedLength();
        });

        modelBuilder.Entity<VwinTransferenciaXIngEgrInven>(entity =>
        {
            entity.ToView("vwin_Transferencia_x_Ing_Egr_Inven");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwinTransferencias>(entity =>
        {
            entity.ToView("vwin_Transferencias");

            entity.Property(e => e.BodegDest).IsFixedLength();
            entity.Property(e => e.BodegaOrig).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.SucuDest).IsFixedLength();
            entity.Property(e => e.SucuOrigen).IsFixedLength();
        });

        modelBuilder.Entity<VwinUnidadMedida>(entity =>
        {
            entity.ToView("vwin_UnidadMedida");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwinUnidadMedidaEquivalencia>(entity =>
        {
            entity.ToView("vwin_UnidadMedida_Equivalencia");
        });

        modelBuilder.Entity<VwinVistaParaContabilizarInventario>(entity =>
        {
            entity.ToView("vwin_VistaParaContabilizarInventario");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
            entity.Property(e => e.TcTipoCbte).IsFixedLength();
        });

        modelBuilder.Entity<VwinZonaVsCtCentroCosto>(entity =>
        {
            entity.ToView("vwin_Zona_vs_ct_Centro_Costo");

            entity.Property(e => e.IdSubZona).IsFixedLength();
            entity.Property(e => e.IdZona).IsFixedLength();
        });

        modelBuilder.Entity<VwsegMenuXUsuarioXEmpresa1>(entity =>
        {
            entity.ToView("vwseg_Menu_x_Usuario_x_Empresa");
        });

        modelBuilder.Entity<VwsegUsuarioXEmpresa>(entity =>
        {
            entity.ToView("vwseg_Usuario_x_Empresa");
        });

        modelBuilder.Entity<VwsegUsuarioXTbSisReporte>(entity =>
        {
            entity.ToView("vwseg_usuario_x_tb_sis_reporte");

            entity.Property(e => e.ClassData).HasDefaultValueSql("''");
            entity.Property(e => e.CodReporte).HasDefaultValueSql("''");
            entity.Property(e => e.Estado).IsFixedLength();
            entity.Property(e => e.Formulario).HasDefaultValueSql("''");
            entity.Property(e => e.IdUsuario).HasDefaultValueSql("''");
            entity.Property(e => e.Modulo).HasDefaultValueSql("''");
            entity.Property(e => e.Nombre).HasDefaultValueSql("''");
            entity.Property(e => e.NombreCorto).HasDefaultValueSql("''");
            entity.Property(e => e.VistaRpt).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwtbBodegaXSucursalTreeList>(entity =>
        {
            entity.ToView("vwtb_Bodega_x_Sucursal_TreeList");

            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Id).HasDefaultValueSql("''");
            entity.Property(e => e.Nombre)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<VwtbBodegaXTbSucursal>(entity =>
        {
            entity.ToView("vwtb_bodega_x_tb_sucursal");

            entity.Property(e => e.BoDescripcion).IsFixedLength();
            entity.Property(e => e.SuDescripcion).IsFixedLength();
        });

        modelBuilder.Entity<VwtbCiudad>(entity =>
        {
            entity.ToView("vwtb_Ciudad");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwtbContacto>(entity =>
        {
            entity.ToView("vwtb_contacto");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwtbEmpresaXUsuario>(entity =>
        {
            entity.ToView("vwtb_empresa_x_Usuario");

            entity.Property(e => e.EmFax).IsFixedLength();
            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwtbPersonaBeneficiario>(entity =>
        {
            entity.ToView("vwtb_persona_beneficiario");

            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.PeApellido).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeDireccion).HasDefaultValueSql("''");
            entity.Property(e => e.PeNaturaleza).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombre).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwtbPersonaBeneficiarioPorBancoAcreditacion>(entity =>
        {
            entity.ToView("vwtb_persona_beneficiario_por_Banco_Acreditacion");

            entity.Property(e => e.IdBeneficiario).HasDefaultValueSql("''");
            entity.Property(e => e.IdSubCentroCosto).IsFixedLength();
            entity.Property(e => e.IdTipoDocumento).HasDefaultValueSql("''");
            entity.Property(e => e.IdTipoPersona).HasDefaultValueSql("''");
            entity.Property(e => e.PeApellido).HasDefaultValueSql("''");
            entity.Property(e => e.PeCedulaRuc).HasDefaultValueSql("''");
            entity.Property(e => e.PeDireccion).HasDefaultValueSql("''");
            entity.Property(e => e.PeNaturaleza).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombre).HasDefaultValueSql("''");
            entity.Property(e => e.PeNombreCompleto).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<VwtbSisDocumentoTipoXDisenioReport>(entity =>
        {
            entity.ToView("vwtb_sis_Documento_Tipo_x_Disenio_Report");

            entity.Property(e => e.ApareceComboFileReporte).IsFixedLength();
        });

        modelBuilder.Entity<VwtbSisDocumentoTipoXEmpresaAnulados>(entity =>
        {
            entity.ToView("vwtb_sis_Documento_Tipo_x_Empresa_Anulados");

            entity.Property(e => e.CodDocumentoTipo).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasDefaultValueSql("'0000-00-00 00:00:00.000000'");
        });

        modelBuilder.Entity<VwtbTbBancoProcesosBancarios>(entity =>
        {
            entity.ToView("vwtb_tb_banco_procesos_bancarios");
        });

        modelBuilder.Entity<VwtbTbSisDocumentoTipoTalonario>(entity =>
        {
            entity.ToView("vwtb_tb_sis_Documento_Tipo_Talonario");
        });

        modelBuilder.Entity<VwtbTransportistaXTbPersona>(entity =>
        {
            entity.ToView("vwtb_transportista_x_tb_persona");

            entity.Property(e => e.Estado).IsFixedLength();
        });

        modelBuilder.Entity<VwtbUbicacionGeografica>(entity =>
        {
            entity.ToView("vwtb_Ubicacion_Geografica");

            entity.Property(e => e.Codigo).HasDefaultValueSql("''");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Id).HasDefaultValueSql("''");
            entity.Property(e => e.IdPais).HasDefaultValueSql("''");
            entity.Property(e => e.Nombre).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<XxxEstadoCuentaCxp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<XxxTotalCancelado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<XxxTotalCanceladoConciliacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<XxxTotalRetencion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
