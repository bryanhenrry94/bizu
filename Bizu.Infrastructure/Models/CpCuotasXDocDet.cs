using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCuota", "Secuencia")]
[Table("cp_cuotas_x_doc_det")]
[Index("IdEmpresaOp", "IdOrdenPago", "SecuenciaOp", Name = "FK_cp_cuotas_x_doc_det_cp_orden_pago_det1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCuotasXDocDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCuota { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("Num_cuota")]
    public int NumCuota { get; set; }

    [Column("Fecha_vcto_cuota")]
    [MaxLength(6)]
    public DateTime FechaVctoCuota { get; set; }

    [Column("Valor_cuota")]
    public double ValorCuota { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    public bool Estado { get; set; }

    [Column("IdEmpresa_op")]
    public int? IdEmpresaOp { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenPago { get; set; }

    [Column("Secuencia_op")]
    public int? SecuenciaOp { get; set; }

    [ForeignKey("IdEmpresa, IdCuota")]
    [InverseProperty("CpCuotasXDocDet")]
    public virtual CpCuotasXDoc CpCuotasXDoc { get; set; } = null!;

    [ForeignKey("IdEmpresaOp, IdOrdenPago, SecuenciaOp")]
    [InverseProperty("CpCuotasXDocDet")]
    public virtual CpOrdenPagoDet? CpOrdenPagoDet { get; set; }
}
