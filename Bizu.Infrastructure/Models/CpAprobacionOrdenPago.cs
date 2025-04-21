using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAprobacion")]
[Table("cp_Aprobacion_Orden_pago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpAprobacionOrdenPago
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

    [StringLength(1500)]
    public string? Observacion { get; set; }

    [Column("Fecha_Aprobacion")]
    [MaxLength(6)]
    public DateTime? FechaAprobacion { get; set; }

    [StringLength(20)]
    public string? UsuarioAprobacion { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [InverseProperty("CpAprobacionOrdenPago")]
    public virtual ICollection<CpAprobacionOrdenPagoDet> CpAprobacionOrdenPagoDet { get; set; } = new List<CpAprobacionOrdenPagoDet>();
}
