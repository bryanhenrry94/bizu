using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdOrdenPago", "Secuencia")]
[Table("cp_orden_pago_det")]
[Index("IdEmpresa", "IdBanco", Name = "FK_cp_orden_pago_det_ba_Banco_Cuenta")]
[Index("IdFormaPago", Name = "FK_cp_orden_pago_det_cp_orden_pago_formapago")]
[Index("IdEmpresaCxp", "IdTipoCbteCxp", "IdCbteCbleCxp", Name = "FK_cp_orden_pago_det_ct_cbtecble")]
[Index("IdEmpresa", "IdOrdenPago", "Secuencia", "IdEstadoAprobacion", Name = "IX_cp_orden_pago_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [StringLength(500)]
    public string? Referencia { get; set; }

    [StringLength(20)]
    public string IdFormaPago { get; set; } = null!;

    [Column("Fecha_Pago")]
    public DateOnly FechaPago { get; set; }

    [StringLength(10)]
    public string IdEstadoAprobacion { get; set; } = null!;

    public int? IdBanco { get; set; }

    [Column("IdUsuario_Aprobacion")]
    [StringLength(20)]
    public string? IdUsuarioAprobacion { get; set; }

    [Column("fecha_hora_Aproba")]
    [MaxLength(6)]
    public DateTime? FechaHoraAproba { get; set; }

    [Column("Motivo_aproba")]
    [StringLength(150)]
    public string? MotivoAproba { get; set; }

    [InverseProperty("CpOrdenPagoDet")]
    public virtual ICollection<BaArchivoTransferenciaDet> BaArchivoTransferenciaDet { get; set; } = new List<BaArchivoTransferenciaDet>();

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("CpOrdenPagoDet")]
    public virtual BaBancoCuenta? BaBancoCuenta { get; set; }

    [InverseProperty("CpOrdenPagoDet")]
    public virtual ICollection<CpAprobacionOrdenPagoDet> CpAprobacionOrdenPagoDet { get; set; } = new List<CpAprobacionOrdenPagoDet>();

    [InverseProperty("CpOrdenPagoDet")]
    public virtual ICollection<CpConciliacionDet> CpConciliacionDet { get; set; } = new List<CpConciliacionDet>();

    [InverseProperty("CpOrdenPagoDet")]
    public virtual ICollection<CpCuotasXDocDet> CpCuotasXDocDet { get; set; } = new List<CpCuotasXDocDet>();

    [ForeignKey("IdEmpresa, IdOrdenPago")]
    [InverseProperty("CpOrdenPagoDet")]
    public virtual CpOrdenPago CpOrdenPago { get; set; } = null!;

    [InverseProperty("CpOrdenPagoDet")]
    public virtual ICollection<CpOrdenPagoCancelaciones> CpOrdenPagoCancelacionesCpOrdenPagoDet { get; set; } = new List<CpOrdenPagoCancelaciones>();

    [InverseProperty("CpOrdenPagoDetNavigation")]
    public virtual ICollection<CpOrdenPagoCancelaciones> CpOrdenPagoCancelacionesCpOrdenPagoDetNavigation { get; set; } = new List<CpOrdenPagoCancelaciones>();

    [ForeignKey("IdEmpresaCxp, IdTipoCbteCxp, IdCbteCbleCxp")]
    [InverseProperty("CpOrdenPagoDet")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdFormaPago")]
    [InverseProperty("CpOrdenPagoDet")]
    public virtual CpOrdenPagoFormapago IdFormaPagoNavigation { get; set; } = null!;
}
