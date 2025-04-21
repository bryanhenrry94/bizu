using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte", "IdCbteCble")]
[Table("ct_cbtecble")]
[Index("CbAnio", Name = "FK_ct_cbtecble_ct_anio_fiscal")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_ct_cbtecble_ct_periodo")]
[Index("CbMes", Name = "FK_ct_cbtecble_tb_mes")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_ct_cbtecble_tb_sucursal")]
[Index("IdEmpresa", "IdCbteCble", "IdTipoCbte", Name = "IX_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCbtecble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [StringLength(20)]
    public string CodCbteCble { get; set; } = null!;

    public int IdPeriodo { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("cb_Valor")]
    public double CbValor { get; set; }

    [Column("cb_Observacion")]
    public string CbObservacion { get; set; } = null!;

    [Column("cb_Secuencia")]
    [Precision(18, 0)]
    public decimal CbSecuencia { get; set; }

    [Column("cb_Estado")]
    [StringLength(1)]
    public string CbEstado { get; set; } = null!;

    [Column("cb_Anio")]
    public int CbAnio { get; set; }

    [Column("cb_mes")]
    public int CbMes { get; set; }

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioAnu { get; set; }

    [Column("cb_MotivoAnu")]
    [StringLength(100)]
    public string? CbMotivoAnu { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("cb_FechaAnu")]
    [MaxLength(6)]
    public DateTime? CbFechaAnu { get; set; }

    [Column("cb_FechaTransac")]
    [MaxLength(6)]
    public DateTime CbFechaTransac { get; set; }

    [Column("cb_FechaUltModi")]
    [MaxLength(6)]
    public DateTime? CbFechaUltModi { get; set; }

    [Column("cb_Mayorizado")]
    [StringLength(1)]
    public string CbMayorizado { get; set; } = null!;

    [Column("cb_para_conciliar")]
    public bool CbParaConciliar { get; set; }

    public int IdSucursal { get; set; }

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<AfTipoTransacXCtaCbteCble> AfTipoTransacXCtaCbteCble { get; set; } = new List<AfTipoTransacXCtaCbteCble>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<BaArchivoTransferenciaDet> BaArchivoTransferenciaDet { get; set; } = new List<BaArchivoTransferenciaDet>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<BaCbteBan> BaCbteBanCtCbtecble { get; set; } = new List<BaCbteBan>();

    [InverseProperty("CtCbtecbleNavigation")]
    public virtual ICollection<BaCbteBan> BaCbteBanCtCbtecbleNavigation { get; set; } = new List<BaCbteBan>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimientoCtCbtecble { get; set; } = new List<CajCajaMovimiento>();

    [InverseProperty("CtCbtecbleNavigation")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimientoCtCbtecbleNavigation { get; set; } = new List<CajCajaMovimiento>();

    [ForeignKey("CbAnio")]
    [InverseProperty("CtCbtecble")]
    public virtual CtAnioFiscal CbAnioNavigation { get; set; } = null!;

    [ForeignKey("CbMes")]
    [InverseProperty("CtCbtecble")]
    public virtual TbMes CbMesNavigation { get; set; } = null!;

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpConciliacion> CpConciliacion { get; set; } = new List<CpConciliacion>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpConciliacionDet> CpConciliacionDetCtCbtecble { get; set; } = new List<CpConciliacionDet>();

    [InverseProperty("CtCbtecbleNavigation")]
    public virtual ICollection<CpConciliacionDet> CpConciliacionDetCtCbtecbleNavigation { get; set; } = new List<CpConciliacionDet>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpCuotasXDoc> CpCuotasXDoc { get; set; } = new List<CpCuotasXDoc>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCreCtCbtecble { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("CtCbtecbleNavigation")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCreCtCbtecbleNavigation { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiroCtCbtecble { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("CtCbtecbleNavigation")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiroCtCbtecbleNavigation { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpOrdenPagoCancelaciones> CpOrdenPagoCancelacionesCtCbtecble { get; set; } = new List<CpOrdenPagoCancelaciones>();

    [InverseProperty("CtCbtecbleNavigation")]
    public virtual ICollection<CpOrdenPagoCancelaciones> CpOrdenPagoCancelacionesCtCbtecbleNavigation { get; set; } = new List<CpOrdenPagoCancelaciones>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpOrdenPagoDet> CpOrdenPagoDet { get; set; } = new List<CpOrdenPagoDet>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpRetencion> CpRetencion { get; set; } = new List<CpRetencion>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CpRetencionXCtCbtecble> CpRetencionXCtCbtecble { get; set; } = new List<CpRetencionXCtCbtecble>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CtAnioFiscalXCuentaUtilidad> CtAnioFiscalXCuentaUtilidad { get; set; } = new List<CtAnioFiscalXCuentaUtilidad>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CtCbtecbleDet> CtCbtecbleDet { get; set; } = new List<CtCbtecbleDet>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CtCbtecbleReversado> CtCbtecbleReversadoCtCbtecble { get; set; } = new List<CtCbtecbleReversado>();

    [InverseProperty("CtCbtecbleNavigation")]
    public virtual ICollection<CtCbtecbleReversado> CtCbtecbleReversadoCtCbtecbleNavigation { get; set; } = new List<CtCbtecbleReversado>();

    [ForeignKey("IdEmpresa, IdTipoCbte")]
    [InverseProperty("CtCbtecble")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("CtCbtecble")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CxcAnticipoFacturado> CxcAnticipoFacturado { get; set; } = new List<CxcAnticipoFacturado>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CxcAnticipoFacturadoDet> CxcAnticipoFacturadoDet { get; set; } = new List<CxcAnticipoFacturadoDet>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CxcCobroXCtCbtecble> CxcCobroXCtCbtecble { get; set; } = new List<CxcCobroXCtCbtecble>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CxcCobroXCtCbtecbleXAnulado> CxcCobroXCtCbtecbleXAnulado { get; set; } = new List<CxcCobroXCtCbtecbleXAnulado>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<CxcConciliacion> CxcConciliacion { get; set; } = new List<CxcConciliacion>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<FaFacturaXCtCbtecble> FaFacturaXCtCbtecble { get; set; } = new List<FaFacturaXCtCbtecble>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<FaNotaCreDebXCtCbtecble> FaNotaCreDebXCtCbtecble { get; set; } = new List<FaNotaCreDebXCtCbtecble>();

    [InverseProperty("CtCbtecble")]
    public virtual ICollection<InMoviInveXCtCbteCble> InMoviInveXCtCbteCble { get; set; } = new List<InMoviInveXCtCbteCble>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CtCbtecble")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;

    [ForeignKey("CtIdEmpresa, CtIdTipoCbte, CtIdCbteCble")]
    [InverseProperty("CtCbtecble")]
    public virtual ICollection<AfDepreciacion> AfDepreciacion { get; set; } = new List<AfDepreciacion>();
}
