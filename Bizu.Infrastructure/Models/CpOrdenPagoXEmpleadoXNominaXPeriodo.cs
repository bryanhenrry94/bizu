using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdOrdenPago", "IdPersona", "IdEmpleado")]
[Table("cp_orden_pago_x_empleado_x_nomina_x_periodo")]
[Index("IdEmpresa", "IdEmpleado", Name = "FK_cp_orden_pago_x_empleado_x_nomina_x_periodo_ro_empleado")]
[Index("IdEmpresa", "IdNominaTipo", "IdNominaTipoLiqui", "IdPeriodo", Name = "FK_cp_orden_pago_x_empleado_x_nomina_x_periodo_ro_periodo_x_ro22")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoXEmpleadoXNominaXPeriodo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdEmpleado { get; set; }

    [Column("IdNomina_Tipo")]
    public int IdNominaTipo { get; set; }

    [Column("IdNomina_TipoLiqui")]
    public int IdNominaTipoLiqui { get; set; }

    public int IdPeriodo { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("IdTipo_op")]
    [StringLength(20)]
    public string? IdTipoOp { get; set; }

    public double? Valor { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Trasanc")]
    [MaxLength(6)]
    public DateTime? FechaTrasanc { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModificacion { get; set; }

    [Column("Fecha_UltModificacion")]
    [MaxLength(6)]
    public DateTime? FechaUltModificacion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioAnulacion { get; set; }

    [StringLength(150)]
    public string? MotivoAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [ForeignKey("IdEmpresa, IdOrdenPago")]
    [InverseProperty("CpOrdenPagoXEmpleadoXNominaXPeriodo")]
    public virtual CpOrdenPago CpOrdenPago { get; set; } = null!;
}
