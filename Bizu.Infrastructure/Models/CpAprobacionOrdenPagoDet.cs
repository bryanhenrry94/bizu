using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAprobacion", "Secuencia")]
[Table("cp_Aprobacion_Orden_pago_det")]
[Index("IdEmpresaOp", "IdOrdenPagoOp", "SecuenciaOp", Name = "FK_cp_Aprobacion_Orden_pago_det_cp_orden_pago_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpAprobacionOrdenPagoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_OP")]
    public int IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_OP")]
    [Precision(18, 0)]
    public decimal IdOrdenPagoOp { get; set; }

    [Column("Secuencia_OP")]
    public int SecuenciaOp { get; set; }

    [ForeignKey("IdEmpresa, IdAprobacion")]
    [InverseProperty("CpAprobacionOrdenPagoDet")]
    public virtual CpAprobacionOrdenPago CpAprobacionOrdenPago { get; set; } = null!;

    [ForeignKey("IdEmpresaOp, IdOrdenPagoOp, SecuenciaOp")]
    [InverseProperty("CpAprobacionOrdenPagoDet")]
    public virtual CpOrdenPagoDet CpOrdenPagoDet { get; set; } = null!;
}
