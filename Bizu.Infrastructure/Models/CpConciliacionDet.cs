using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacion", "Secuencia")]
[Table("cp_conciliacion_det")]
[Index("IdEmpresaOp", "IdOrdenPagoOp", "SecuenciaOp", Name = "FK_cp_conciliacion_det_cp_orden_pago_det")]
[Index("IdEmpresaCxp", "IdTipoCbteCxp", "IdCbteCbleCxp", Name = "FK_cp_conciliacion_det_ct_cbtecble")]
[Index("IdEmpresaPago", "IdTipoCbtePago", "IdCbteCblePago", Name = "FK_cp_conciliacion_det_ct_cbtecble1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpConciliacionDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_op")]
    public int? IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_op")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [Column("Secuencia_op")]
    public int? SecuenciaOp { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdEmpresa_pago")]
    public int IdEmpresaPago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int IdTipoCbtePago { get; set; }

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal IdCbteCblePago { get; set; }

    public double MontoAplicado { get; set; }

    public double SaldoAnterior { get; set; }

    public double SaldoActual { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [Column("fechaTransaccion")]
    [MaxLength(6)]
    public DateTime FechaTransaccion { get; set; }

    [ForeignKey("IdEmpresa, IdConciliacion")]
    [InverseProperty("CpConciliacionDet")]
    public virtual CpConciliacion CpConciliacion { get; set; } = null!;

    [ForeignKey("IdEmpresaOp, IdOrdenPagoOp, SecuenciaOp")]
    [InverseProperty("CpConciliacionDet")]
    public virtual CpOrdenPagoDet? CpOrdenPagoDet { get; set; }

    [ForeignKey("IdEmpresaCxp, IdTipoCbteCxp, IdCbteCbleCxp")]
    [InverseProperty("CpConciliacionDetCtCbtecble")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresaPago, IdTipoCbtePago, IdCbteCblePago")]
    [InverseProperty("CpConciliacionDetCtCbtecbleNavigation")]
    public virtual CtCbtecble CtCbtecbleNavigation { get; set; } = null!;
}
